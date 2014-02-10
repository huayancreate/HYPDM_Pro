<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewHttpRequest.aspx.cs"
    Inherits="WcfExtension.LogCenter.Info.NewHttpRequest" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>查询与本次请求相关的信息</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="PageTitle">
        <img src="../images/btn_hide_sidebar.png" alt="" />&nbsp;<span>WCF日志异常系统</span>>><span>日志异常信息列表</span>
    </div>
    <div class="liebiao">
        <table width="100%" class="sortable maintable">
            <tr>
                <th>
                    表名
                </th>
                <th>
                    机器名称
                </th>
                <th>
                    IP地址
                </th>
                <th>
                    名称
                </th>
                <th>
                    请求id
                </th>
                <th>
                    记录时间
                </th>
                <th class="sorttable_nosort">
                    查看
                </th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                ClientExceptionInfo
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineName")%>
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineIP")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("ExtraInfo")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("RequestIdentity")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("Time")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=ClientExceptionInfo"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="Repeater2" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                ClientInvokeInfo
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineName")%>
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineIP")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("ExtraInfo")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("RequestIdentity")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("Time")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=ClientInvokeInfo"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="Repeater3" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                ClientMessageInfo
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineName")%>
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineIP")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("ExtraInfo")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("RequestIdentity")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("Time")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=ClientMessageInfo"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="Repeater4" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                ServerExceptionInfo
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineName")%>
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineIP")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("ExtraInfo")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("RequestIdentity")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("Time")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=ServerExceptionInfo"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="Repeater5" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                ServerInvokeInfo
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineName")%>
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineIP")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("ExtraInfo")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("RequestIdentity")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("Time")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=ServerInvokeInfo"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            <asp:Repeater ID="Repeater6" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                ServerMessageInfo
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineName")%>
                            </div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("MachineIP")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("ExtraInfo")%></div>
                        </td>
               
                        <td>
                            <div align="center">
                                <%# Eval("RequestIdentity")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <%# Eval("Time")%></div>
                        </td>
                        <td>
                            <div align="center">
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=ServerMessageInfo"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
          
        </table>
    </div>
    </form>
</body>
</html>
