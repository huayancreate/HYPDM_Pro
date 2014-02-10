<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogDetail.aspx.cs" Inherits="WcfExtension.LogCenter.Info.LogDetail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>查看日志详情</title>
    <link href="../css/base.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function js_back() {
            history.back(-1);
        }
        function copyToClipBoard() {
            var clipBoardContent = this.location.href; 
            window.clipboardData.setData("Text", clipBoardContent);
            document.getElementById("spanMessage").innerHTML = "OK!";
        }
        function Button3_onclick() {

            location.href = "NewHttpRequest.aspx?id=<%=requestid %>&dbname=<%=dbName %>"

        }


        function SetCwinHeight(obj) {
            var cwin = obj;
            if (document.getElementById) {
                if (cwin && !window.opera) {
                    if (cwin.contentDocument && cwin.contentDocument.body.offsetHeight)
                        cwin.height = cwin.contentDocument.body.offsetHeight;
                    else if (cwin.Document && cwin.Document.body.scrollHeight)
                        cwin.height = cwin.Document.body.scrollHeight;
                }
            }
        }

    </script>
</head>
<body>
    <div>
        <fieldset class="search">
            <legend><b>Detail</b></legend>
            <table height="30" border="0" cellpadding="3" cellspacing="0">
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <input id="Button1" type="button" onclick="js_back();" class="button" value="Return" />&nbsp;<input
                            id="Button3" type="button" class="button" value="View related information" onclick="return Button3_onclick()" />&nbsp;<input
                                id="Button2" type="button" onclick="copyToClipBoard();" class="button" value="Copy url" />&nbsp;<span
                                    id="spanMessage" style="color: Red;"></span>&nbsp;
                    </td>
                </tr>
                    <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                    &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Literal ID="liDbName" runat="server"></asp:Literal></td>
                </tr>
            </table>
            <table height="30" border="0" cellpadding="3" cellspacing="0">
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        Key
                    </td>
                    <td>
                        Value
                    </td>
                </tr>
                <asp:Literal ID="liContent" runat="server"></asp:Literal>
            </table>
        </fieldset>
    </div>
</body>
</html>
