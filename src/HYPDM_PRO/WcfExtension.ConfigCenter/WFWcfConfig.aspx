<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFWcfConfig.aspx.cs" Inherits="WcfExtension.ConfigCenter.WFWcfConfig"
    ValidateRequest="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>WcfConfig后台配置</title>
    <style type="text/css">
        *
        {
            font-size: 10pt;
        }
        legend
        {
            font-size: x-large;
            font-weight: bolder;
        }
        .messageinfo
        {
            color: Red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <!-- Service Farm -->
        <fieldset>
            <legend>ServiceFarm</legend>
            <table>
                <tr>
                    <td>
                        <span>ServerFarmName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBServerFarmName" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td>
                        <span>ServerFarmAddress</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBServerFarmAddress" runat="server" Text="127.0.0.1"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtnAddServerFarm" runat="server" Text="Submit" 
                OnClick="BtnAddServerFarm_Click" />
            <asp:GridView ID="GVServerFarm" runat="server" AutoGenerateColumns="False" EnableModelValidation="True"
                OnRowDeleting="GVServerFarm_RowDeleting" CellPadding="4" ForeColor="#333333"
                GridLines="None" onrowediting="GVServerFarm_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
                    <asp:BoundField DataField="ServerFarmName" HeaderText="ServerFarmName" />
                    <asp:BoundField DataField="ServerFarmAddress" HeaderText="ServerFarmAddress" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:Label ID="LabelServerFarmErrorMessage" runat="server" Text="提示信息" CssClass="messageinfo"></asp:Label>
        </fieldset>
        <!-- Service -->
        <fieldset>
            <legend>Service</legend>
            <table>
                <tr>
                    <td>
                        <span>ServerFarmName</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLServerFarm" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <span>ServiceType</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBServiceType" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td>
                        <span>ServerMachineIP</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBServerMachineIP" runat="server" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>ServiceBehaviorXml</span>
                    </td>
                    <td colspan="3">
                        <asp:TextBox ID="TBServiceBehaviorXml" runat="server" Text="" Height="150px" TextMode="MultiLine"
                            Width="450px"></asp:TextBox>
                    </td>
                    <td>
                        <span>ServiceConfig</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBServiceConfig" runat="server" Text="" Height="150px" TextMode="MultiLine"
                            Width="450px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtnAddService" runat="server" Text="Submit" 
                OnClick="BtnAddService_Click" />
            <asp:GridView ID="GVService" runat="server" AutoGenerateColumns="False" EnableModelValidation="True"
                OnRowDeleting="GVService_RowDeleting" OnSelectedIndexChanged="GVService_SelectedIndexChanged"
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                onrowediting="GVService_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
                    <asp:BoundField DataField="ServiceType" HeaderText="ServiceType" ItemStyle-Width="300px">
                        <ItemStyle Width="300px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServiceBehaviorXml" HeaderText="ServiceBehaviorXml" ItemStyle-Width="400px">
                        <ItemStyle Width="400px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServerFarmName" HeaderText="ServiceFarmName" ItemStyle-Width="200px">
                        <ItemStyle Width="200px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServiceConfig" HeaderText="ServiceConfig" ItemStyle-Width="400px">
                        <ItemStyle Width="400px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServerMachineIP" HeaderText="ServerMachineIP" />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField SelectText="通知服务端" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:Label ID="LabelServiceErrorMessage" runat="server" Text="提示信息" CssClass="messageinfo"></asp:Label>
        </fieldset>
        <!-- ServciceEndPoint -->
        <fieldset>
            <legend>ServciceEndPoint</legend>
            <table>
                <tr>
                    <td>
                        <span>ServiceContractType</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBSEPServiceContractType" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td>
                        <span>ServiceContractVersion</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBSEPServiceContractVersion" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td>
                        <span>ServiceType</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBSEPServiceType" runat="server" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>ServiceEndPointBindingName</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLSEPServiceEndPointBindingName" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>
                        <span>ServiceEndPointPort</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBSEPServiceEndPointPort" runat="server" Text="0"></asp:TextBox>
                    </td>
                    <td>
                        <span>ServiceEndPointName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBSEPServiceEndPointName" runat="server" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>ServiceEndPointBehaviorXml</span>
                    </td>
                    <td colspan="5">
                        <asp:TextBox ID="TBSEPServiceEndPointBehaviorXml" runat="server" Text="" Height="150px"
                            TextMode="MultiLine" Width="450px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtnAddServiceEndPoint" runat="server" Text="Submit" 
                OnClick="BtnAddServiceEndPoint_Click" />
            <asp:GridView ID="GVSEPServiceEndPoint" runat="server" AutoGenerateColumns="False"
                EnableModelValidation="True" OnRowDeleting="GVSEPServiceEndPoint_RowDeleting"
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                onrowediting="GVSEPServiceEndPoint_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
                    <asp:BoundField DataField="ServiceContractType" HeaderText="ServiceContractType"
                        ItemStyle-Width="300px">
                        <ItemStyle Width="300px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServiceContractVersion" HeaderText="ServiceContractVersion" />
                    <asp:BoundField DataField="ServiceType" HeaderText="ServiceType" ItemStyle-Width="400px">
                        <ItemStyle Width="400px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServiceEndpointBehaviorXml" HeaderText="ServiceEndPointBehaviorXml"
                        ItemStyle-Width="400px">
                        <ItemStyle Width="400px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ServiceEndpointBindingName" HeaderText="ServiceEndPointBindingName" />
                    <asp:BoundField DataField="ServiceEndpointPort" HeaderText="ServiceEndPointPort" />
                    <asp:BoundField DataField="ServiceEndpointName" HeaderText="ServiceEndPointName" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:Label ID="LabelSEPServiceEndPointErrorMessage" runat="server" Text="提示信息" CssClass="messageinfo"></asp:Label>
        </fieldset>
        <!-- Binding -->
        <fieldset>
            <legend>Binding</legend>
            <table>
                <tr>
                    <td>
                        <span>BindingName</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBBindingName" runat="server" Text=""></asp:TextBox>
                    </td>
                    <td>
                        <span>BindingType</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLBindingType" runat="server">
                            <asp:ListItem Text="BasicHttpBinding" Value="BasicHttpBinding"></asp:ListItem>
                            <asp:ListItem Text="WSHttpBinding" Value="WSHttpBinding"></asp:ListItem>
                            <asp:ListItem Text="WSDualHttpBinding" Value="WSDualHttpBinding"></asp:ListItem>
                            <asp:ListItem Text="WSFederationBinding" Value="WSFederationBinding"></asp:ListItem>
                            <asp:ListItem Text="NetTcpBinding" Value="NetTcpBinding"></asp:ListItem>
                            <asp:ListItem Text="NetNamePipeBinding" Value="NetNamePipeBinding"></asp:ListItem>
                            <asp:ListItem Text="NetMsmqBinding" Value="NetMsmqBinding"></asp:ListItem>
                            <asp:ListItem Text="MsmqIntegrationBinding" Value="MsmqIntegrationBinding"></asp:ListItem>
                            <asp:ListItem Text="NetPeerTcpBinding" Value="NetPeerTcpBinding"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <span>BindingPriority</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLBindingPriority" runat="server">
                            <asp:ListItem Text="1<High>" Value="1"></asp:ListItem>
                            <asp:ListItem Text="2" Value="2"></asp:ListItem>
                            <asp:ListItem Text="3" Value="3"></asp:ListItem>
                            <asp:ListItem Text="4" Value="4"></asp:ListItem>
                            <asp:ListItem Text="5" Value="5"></asp:ListItem>
                            <asp:ListItem Text="6" Value="6"></asp:ListItem>
                            <asp:ListItem Text="7" Value="7"></asp:ListItem>
                            <asp:ListItem Text="8" Value="8"></asp:ListItem>
                            <asp:ListItem Text="9<Low>" Value="9"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <span>BindingProtocol</span>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLBindingProtocol" runat="server">
                            <asp:ListItem Text="Protocol:http" Value="http"></asp:ListItem>
                            <asp:ListItem Text="Protocol:net.tcp" Value="net.tcp"></asp:ListItem>
                            <asp:ListItem Text="Protocol:net.pipe" Value="net.pipe"></asp:ListItem>
                            <asp:ListItem Text="Protocol:net.msmq" Value="net.msmq"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>BindingXml</span>
                    </td>
                    <td colspan="7">
                        <asp:TextBox ID="TBBindingXml" runat="server" Height="150px" TextMode="MultiLine"
                            Width="450px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="BtnAddBinding" runat="server" Text="Submit" 
                OnClick="BtnAddBinding_Click" />
            <asp:GridView ID="GVBinding" runat="server" AutoGenerateColumns="False" EnableModelValidation="True"
                OnRowDeleting="GVBinding_RowDeleting" CellPadding="4" ForeColor="#333333" 
                GridLines="None" onrowediting="GVBinding_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
                    <asp:BoundField DataField="BindingName" HeaderText="BindingName" />
                    <asp:BoundField DataField="BindingType" HeaderText="BindingType" />
                    <asp:BoundField DataField="BindingPriority" HeaderText="BindingPriority" />
                    <asp:BoundField DataField="BindingXml" HeaderText="BindingXml" ItemStyle-Width="800px">
                        <ItemStyle Width="800px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="BindingProtocol" HeaderText="BindingProtocol" />
                    <asp:CommandField ShowEditButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:Label ID="LabelBindingErrorMessage" runat="server" Text="提示信息" CssClass="messageinfo"></asp:Label>
        </fieldset>
        <!-- ClientEndPoint -->
        <fieldset>
            <legend>ClientEndPoint</legend>
            <table>
                <tr>
                    <td>
                        <span>ServiceContractType</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBServiceContractType" runat="server" Text=""></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>ClientEndpointBehaviorXml</span>
                    </td>
                    <td>
                        <asp:TextBox ID="TBClientEndpointBehaviorXml" runat="server" Text="" Height="150px"
                            TextMode="MultiLine" Width="450px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="BtnAddClientEndPoint" runat="server" Text="Submit" 
                OnClick="BtnAddClientEndPoint_Click" />
            <asp:GridView ID="GVClientEndPoint" runat="server" AutoGenerateColumns="False" EnableModelValidation="True"
                OnRowDeleting="GVClientEndPoint_RowDeleting" OnSelectedIndexChanged="GVClientEndPoint_SelectedIndexChanged"
                CellPadding="4" ForeColor="#333333" GridLines="None" 
                onrowediting="GVClientEndPoint_RowEditing">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowDeleteButton="True"></asp:CommandField>
                    <asp:BoundField DataField="ServiceContractType" HeaderText="ServiceContractType"
                        ItemStyle-Width="400px">
                        <ItemStyle Width="400px"></ItemStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="ClientEndpointBehaviorXml" HeaderText="ClientEndpointBehaviorXml"
                        ItemStyle-Width="400px">
                        <ItemStyle Width="400px"></ItemStyle>
                    </asp:BoundField>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField SelectText="通知客户端" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            </asp:GridView>
            <asp:Label ID="LabelClientEndPointErrorMessage" runat="server" Text="提示信息" CssClass="messageinfo"></asp:Label>
        </fieldset>
    </div>
    </form>
</body>
</html>
