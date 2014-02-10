<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogList.aspx.cs" Inherits="WcfExtension.LogCenter.Info.LogList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>WCF日志查询</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <link href="../css/calendar.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/calendar.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="PageTitle">
        <img src="../images/btn_hide_sidebar.png" alt="" />&nbsp;<span>WCF日志异常系统</span>>><span>日志异常信息列表</span>
    </div>
    <div>
        <fieldset class="search">
            <legend><b>查询</b></legend>
            <table border="0" cellpadding="3" cellspacing="0">
                <tr>
                    <td>
                        请选择年月:<asp:DropDownList ID="ddlMonth" runat="server">
                            <asp:ListItem Value="-1">请选择年月</asp:ListItem>
                            <asp:ListItem Selected="True"  >201105</asp:ListItem>
                            <asp:ListItem>201106</asp:ListItem>
                            <asp:ListItem>201107</asp:ListItem>
                        </asp:DropDownList>
                        数据表:<asp:DropDownList ID="ddlDatabaseName" AppendDataBoundItems="true" runat="server">
                            <asp:ListItem>ClientExceptionInfo</asp:ListItem>
                            <asp:ListItem>ClientInvokeInfo</asp:ListItem>
                            <asp:ListItem>ClientMessageInfo</asp:ListItem>
                            <asp:ListItem>ServerExceptionInfo</asp:ListItem>
                            <asp:ListItem>ServerInvokeInfo</asp:ListItem>
                            <asp:ListItem>ServerMessageInfo</asp:ListItem>
                            <asp:ListItem>ClientStartInfo</asp:ListItem>
                            <asp:ListItem>ServerStartInfo</asp:ListItem>
                        </asp:DropDownList>
                                               <%-- 服务器IP:
                        <asp:DropDownList ID="ddlMachineIP" runat="server" AppendDataBoundItems="true">
                            <asp:ListItem Selected="True" Value="0">请选择服务器IP</asp:ListItem>
                        </asp:DropDownList>
                        服务名称:<asp:TextBox ID="tbServiceName" runat="server"></asp:TextBox>
                        契约名称:<asp:TextBox ID="tbContractName" runat="server"></asp:TextBox>--%>
                        开始日期:
                        <asp:TextBox ID="tbBeginDate" onclick="showcalendar(event, $(this.id),true);" runat="server"
                            Width="120"></asp:TextBox>&nbsp;结束日期
                        <asp:TextBox ID="tbEndDate" onclick="showcalendar(event, $(this.id),true);" runat="server"
                            Width="120"></asp:TextBox>&nbsp;<%--内容搜索:
                        <asp:TextBox ID="tbMessage" runat="server" Width="150px"></asp:TextBox>--%>
                        <asp:Button ID="btSearch" runat="server" CssClass="button" Text="搜索" OnClick="btSearch_Click" />
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
    <div class="liebiao">
        <table width="100%" class="sortable maintable">
            <tr>
             <th>
                    Type
                </th>
                <th>
                    MachineName
                </th>
                <th>
                    MachineIP
                </th>
                <th>
                    ExtraInfo
                </th>
                <th>
                    RequestIdentity
                </th>
                <th>
                    Time
                </th>
                <th class="sorttable_nosort">
                    View
                </th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                      <td>
                            <div align="center">
                                <%# Container.DataItem.GetType().Name%>
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
                                <span><a href="LogDetail.aspx?id=<%# Eval("ID")%>&dbname=<%=dbName %>&tablename=<%=collectionName %>"
                                    target="_blank">
                                    <img src="../images/a.gif" alt="查看详情" /></a> </span>
                            </div>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div class="Pager">
            <asp:Button ID="btShouye" runat="server" Text="首页" Enabled="false" OnClick="btShouye_Click" />
            <asp:Button ID="btShangyiye" runat="server" Enabled="false" Text="上一页" OnClick="btShangyiye_Click" />
            <asp:Label ID="lbPageMessage" runat="server" Text=""></asp:Label>
            <asp:Label ID="liPageCount" runat="server"></asp:Label>
            <asp:Button ID="btXiayiye" runat="server" Enabled="false" Text="下一页" OnClick="btXiayiye_Click" />
        </div>
    </div>
    </form>
</body>
</html>
