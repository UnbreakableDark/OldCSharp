<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yhSearch.aspx.cs" Inherits="yhSearch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 20px;
        }
        .style3
        {
            width: 185px;
        }
        .style4
        {
            height: 20px;
            width: 185px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">
                    用户信息查询</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    性别：</td>
                <td>
                    <asp:DropDownList ID="ddlSex" runat="server">
                        <asp:ListItem>不限</asp:ListItem>
                        <asp:ListItem>男</asp:ListItem>
                        <asp:ListItem Value="女"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    所属地区：</td>
                <td class="style2">
                    <asp:DropDownList ID="citizen" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="citizen" DataValueField="citizen">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:pkmConnectionString7 %>" 
                        SelectCommand="SELECT [citizen] FROM [union]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    所属城市：</td>
                <td>
                    <asp:DropDownList ID="city" runat="server" DataSourceID="SqlDataSource2" 
                        DataTextField="city" DataValueField="city">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:pkmConnectionString8 %>" 
                        SelectCommand="SELECT [city] FROM [city]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" Text="查询" />
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <asp:GridView ID="dgUser" runat="server" AllowPaging="True" 
                        AutoGenerateColumns="False" DataKeyNames="username" 
                        onpageindexchanging="dgUser_PageIndexChanging" 
                        onrowdeleting="dgUser_RowDeleting" PageSize="5" 
                        onrowdatabound="dgUser_RowDataBound" onrowediting="dgUser_RowEditing" 
                        onselectedindexchanged="dgUser_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="username" HeaderText="用户名" />
                            <asp:BoundField DataField="age" HeaderText="年龄" />
                            <asp:BoundField DataField="email" HeaderText="Email" />
                            <asp:BoundField DataField="sex" HeaderText="性别" />
                            <asp:BoundField DataField="city" HeaderText="所属城市" />
                            <asp:BoundField DataField="citizen" HeaderText="所属地区" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" ShowHeader="True" />
                            <asp:CommandField HeaderText="更新" ShowEditButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
