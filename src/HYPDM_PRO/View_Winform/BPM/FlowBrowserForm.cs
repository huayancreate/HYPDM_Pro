using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace View_Winform.BPM
{
    public partial class FlowBrowserForm : DevExpress.XtraEditors.XtraForm
    {
        public FlowBrowserForm()
        {
            InitializeComponent();
        }
        public FlowBrowserForm(string url)
        {
            InitializeComponent();
            newPage(url);
        }

        private void FlowBrowserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Hide();
            //if (this.Tag == "start") {
            //    FlowListForm f = new FlowListForm();
            //    f.ShowDialog();
            //}
            //else
            //{
            //    UserWorksForm f = new UserWorksForm();
            //    f.ShowDialog();

            //}
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser myBrowser = (WebBrowser)sender;
            System.Windows.Forms.HtmlElement html = myBrowser.Document.CreateElement("div");
            html.InnerHtml += "<a id=\"popLink\" href=\"\" target=\"_blank\" style=\"display:none;\"></a>";
            myBrowser.Document.Body.AppendChild(html);

            string jsHtml = "";
            jsHtml += "window.open=function(url, title, prop)  ";
            jsHtml += "{";
            jsHtml += "obj = document.getElementById('popLink');  ";
            jsHtml += "obj.style.display='block';  ";
            jsHtml += "obj.href=url;  ";
            jsHtml += "obj.focus();  ";
            jsHtml += "obj.click();  ";
            jsHtml += "obj.style.display='none'  ";
            jsHtml += "} ";
            mshtml.IHTMLDocument2 doc = myBrowser.Document.DomDocument as mshtml.IHTMLDocument2;
            mshtml.IHTMLWindow2 win = doc.parentWindow as mshtml.IHTMLWindow2;
            win.execScript(jsHtml, "javascript");
            if (tctlControl.SelectedTabPage.Text == "")
            {
                tctlControl.SelectedTabPage.Text = "加载失败";
            }
        }

        private void newPage()
        {
            XtraTabPage mypage = new XtraTabPage();
            WebBrowser tempBrowser = new WebBrowser();
            tempBrowser.Navigated +=
               new WebBrowserNavigatedEventHandler(Browser_Navigated);
            tempBrowser.NewWindow +=
               new CancelEventHandler(Browser_NewWindow);
            tempBrowser.ProgressChanged +=
               new WebBrowserProgressChangedEventHandler(Browser_ProgressChanged);
            tempBrowser.StatusTextChanged +=
               new EventHandler(Browser_StatusTextChanged);
            tempBrowser.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(Browser_DocumentCompleted);
            tempBrowser.Dock = DockStyle.Fill;
            mypage.Controls.Add(tempBrowser);
            tctlControl.TabPages.Add(mypage);
            tctlControl.SelectedTabPage = mypage;
            mypage.Text = "加载中";
            DisbaledRight(tempBrowser);
        }

        private void newPage(string address)
        {
            XtraTabPage mypage = new XtraTabPage();
            WebBrowser tempBrowser = new WebBrowser();
            tempBrowser.Navigated +=
               new WebBrowserNavigatedEventHandler(Browser_Navigated);
            tempBrowser.NewWindow += new CancelEventHandler(Browser_NewWindow);
            tempBrowser.StatusTextChanged +=
               new EventHandler(Browser_StatusTextChanged);
            tempBrowser.ProgressChanged +=
               new WebBrowserProgressChangedEventHandler(Browser_ProgressChanged);
            tempBrowser.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(Browser_DocumentCompleted);
            tempBrowser.Url = getUrl(address);
            tempBrowser.Dock = DockStyle.Fill;
            mypage.Controls.Add(tempBrowser);
            tctlControl.TabPages.Add(mypage);
            mypage.Text = "加载中";
            DisbaledRight(tempBrowser);
        }

        private Uri getUrl(string address)
        {
            string tempaddress = address;
            if ((!address.StartsWith("http://")) &&
               (!address.StartsWith("https://")) && (!address.StartsWith("ftp://")))
            {
                tempaddress = "http://" + address;
            }
            Uri myurl;
            try
            {
                myurl = new Uri(tempaddress);
            }
            catch
            {
                myurl = new Uri("about:blank");
            }
            return myurl;
        }

        private void Browser_StatusTextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Browser_NewWindow(object sender, CancelEventArgs e)
        {
            //获取触发tempBrowser_NewWindow事件的浏览器
            WebBrowser myBrowser = (WebBrowser)sender;
            //获取触发tempBrowser_NewWindow事件的浏览器所在TabPage
            XtraTabPage mypage = (XtraTabPage)myBrowser.Parent;
            //通过StatusText属性获得新的url
            string NewURL = ((WebBrowser)sender).StatusText;
            //生成新的一页
            XtraTabPage TabPageTemp = new XtraTabPage();
            //生成新的tempBrowser
            WebBrowser tempBrowser = new WebBrowser();
            //临时浏览器定向到新的url
            tempBrowser.Navigate(NewURL);
            tempBrowser.Dock = DockStyle.Fill;
            //为临时浏览器关联NewWindow等事件
            tempBrowser.NewWindow +=
               new CancelEventHandler(Browser_NewWindow);
            tempBrowser.Navigated +=
               new WebBrowserNavigatedEventHandler(Browser_Navigated);
            tempBrowser.ProgressChanged +=
               new WebBrowserProgressChangedEventHandler(Browser_ProgressChanged);
            tempBrowser.StatusTextChanged +=
               new EventHandler(Browser_StatusTextChanged);
            tempBrowser.DocumentCompleted +=
                new WebBrowserDocumentCompletedEventHandler(Browser_DocumentCompleted);
            //将临时浏览器添加到临时TabPage中
            TabPageTemp.Controls.Add(tempBrowser);
            //将临时TabPage添加到主窗体中
            this.tctlControl.TabPages.Add(TabPageTemp);
            TabPageTemp.Text = "加载中";
            //使外部无法捕获此事件
            e.Cancel = true;
            DisbaledRight(tempBrowser);
        }

        private void Browser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //tscbUrl.Text = getCurrentBrowser().Url.ToString();
            WebBrowser mybrowser = (WebBrowser)sender;
            XtraTabPage mypage = (XtraTabPage)mybrowser.Parent;
            //设置临时浏览器所在tab标题
            mypage.Text = mybrowser.DocumentTitle;
        }

        private object getCurrentBrowser()
        {
            WebBrowser currentBrowser = (WebBrowser)tctlControl.SelectedTabPage.Controls[0];
            return currentBrowser;
        }

        private void DisbaledRight(WebBrowser b)
        {
            b.IsWebBrowserContextMenuEnabled = false;
        }

    }
}