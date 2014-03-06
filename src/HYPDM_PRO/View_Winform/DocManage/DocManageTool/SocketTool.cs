using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Net;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;

namespace View_Winform.DocManage.DocManageTool
{
    /// <summary>
    /// 服务端
    /// </summary>
    public class SocketServer
    {
        private string ip;
        private int port;
        private string filename;
        public  TcpListener lisner;
        public Thread TempThread;
        public bool flag = false;

        public SocketServer(string ip, int port,string filename)
        {
            this.ip = ip;
            this.port = port;
            this.filename = filename;
        }

        public void start()
        {
            TempThread = new Thread(new ThreadStart(this.StartReceive));
            TempThread.Start();
        }

        public void StartReceive()
        {
            //创建一个网络端点
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
            //创建网络监听
            lisner = new TcpListener(ipep);
            lisner.Start();
            while (true)
            {
                ////确认连接
                if (!lisner.Pending())
                {
                    Thread.Sleep(1000);
                    continue;
                }
                flag = false;
                Socket client = lisner.AcceptSocket();
                //获得客户端节点对象
                IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;
                //获得[文件名]
                string SendFileName = System.Text.Encoding.Unicode.GetString(TransferFiles.ReceiveVarData(client));
                //获得[包的大小]
                string bagSize = System.Text.Encoding.Unicode.GetString(TransferFiles.ReceiveVarData(client));
                //获得[包的总数量]
                int bagCount = int.Parse(System.Text.Encoding.Unicode.GetString(TransferFiles.ReceiveVarData(client)));
                //获得[最后一个包的大小]
                string bagLast = System.Text.Encoding.Unicode.GetString(TransferFiles.ReceiveVarData(client));
                //创建一个新文件
                string   fileFullName = filename + SendFileName;
                FileStream MyFileStream = new FileStream(fileFullName, FileMode.Create, FileAccess.Write, FileShare.Read);
                //已发送包的个数
                int SendedCount = 0;
                while (true)
                {
                    byte[] data = TransferFiles.ReceiveVarData(client);
                    if (data.Length == 0)
                    {
                        break;
                    }
                    else
                    {
                        SendedCount++;
                        //将接收到的数据包写入到文件流对象
                        MyFileStream.Write(data, 0, data.Length);
                    }
                }
                //关闭文件流
                MyFileStream.Close();
                //关闭套接字
                client.Close();
                flag = true;
            }
        }

    }

    /// <summary>
    /// 客户端
    /// </summary>
    public class Client
    {
        // 文件名
        private string filename ;
        // ip地址
        private string ip;
        // 端口号
        private int port;
        //生成文件
        private string genfile;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        public Client(string filename,string genfile, string ip, int port)
        {
            this.filename = filename;
            this.genfile = genfile;
            this.ip = ip;
            this.port = port;
        }

        /// <summary>
        /// 开启发送线程
        /// </summary>
        public void start()
        {
            Thread TempThread = new Thread(new ThreadStart(this.StartSend));
            TempThread.Start();
        }

        /// <summary>
        /// 发送
        /// </summary>
        public void StartSend()
        {
            //创建一个文件对象  
            FileInfo EzoneFile = new FileInfo(filename);
            //打开文件流  
            FileStream EzoneStream = EzoneFile.OpenRead();
            //包的大小  
            int PacketSize = 100000;
            //包的数量  
            int PacketCount = (int)(EzoneStream.Length / ((long)PacketSize));

            //最后一个包的大小  
            int LastDataPacket = (int)(EzoneStream.Length - ((long)(PacketSize * PacketCount)));
            //指向远程服务端节点  
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), port);
            //创建套接字  
            Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //连接到发送端  
            client.Connect(ipep);
            //获得客户端节点对象  
            IPEndPoint clientep = (IPEndPoint)client.RemoteEndPoint;
            //获得客户端的IP地址  
            //this.textBox7.Text=clientep.Address.ToString();  
            //发送[文件名]到客户端  
            TransferFiles.SendVarData(client, System.Text.Encoding.Unicode.GetBytes(genfile));
            //发送[包的大小]到客户端  
            TransferFiles.SendVarData(client, System.Text.Encoding.Unicode.GetBytes(PacketSize.ToString()));
            //发送[包的总数量]到客户端  
            TransferFiles.SendVarData(client, System.Text.Encoding.Unicode.GetBytes(PacketCount.ToString()));
            //发送[最后一个包的大小]到客户端  
            TransferFiles.SendVarData(client, System.Text.Encoding.Unicode.GetBytes(LastDataPacket.ToString()));
            //数据包  
            byte[] data = new byte[PacketSize];
            //开始循环发送数据包  
            for (int i = 0; i < PacketCount; i++)
            {
                //从文件流读取数据并填充数据包  
                EzoneStream.Read(data, 0, data.Length);
                //发送数据包  
                TransferFiles.SendVarData(client, data);
            }

            //如果还有多余的数据包,则应该发送完毕!  
            if (LastDataPacket != 0)
            {
                data = new byte[LastDataPacket];
                EzoneStream.Read(data, 0, data.Length);
                TransferFiles.SendVarData(client, data);
            }

            //关闭套接字  
            client.Close();
            //关闭文件流  
            EzoneStream.Close();
        }  
    }

    /// <summary>
    /// 工具类
    /// </summary>
    class TransferFiles
    {
        /// <summary>
        /// 发送数据共同类
        /// </summary>
        /// <param name="s"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static int SendVarData(Socket s, byte[] data) // return integer indicate how many data sent.
        {
            int total = 0;
            int size = data.Length;
            int dataleft = size;
            int sent;
            byte[] datasize = new byte[4];
            datasize = BitConverter.GetBytes(size);
            sent = s.Send(datasize);//send the size of data array.

            while (total < size)
            {
                sent = s.Send(data, total, dataleft, SocketFlags.None);
                total += sent;
                dataleft -= sent;
            }

            return total;
        }

        /// <summary>
        /// 接受数据共同类
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] ReceiveVarData(Socket s) // return array that store the received data.
        {
            int total = 0;
            int recv;
            byte[] datasize = new byte[4];
            recv = s.Receive(datasize, 0, 4, SocketFlags.None);//receive the size of data array for initialize a array.
            int size = BitConverter.ToInt32(datasize, 0);
            int dataleft = size;
            byte[] data = new byte[size];

            while (total < size)
            {
                recv = s.Receive(data, total, dataleft, SocketFlags.None);
                if (recv == 0)
                {
                    data = null;
                    break;
                }
                total += recv;
                dataleft -= recv;
            }

            return data;

        }
    }
}
