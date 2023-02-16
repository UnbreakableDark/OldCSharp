<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bkmInfo.aspx.cs" Inherits="Styles_bkmInfo" %>

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
            width: 166px;
        }
        .style3
        {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="2">
                    宝可梦的更新</td>
            </tr>
            <tr>
                <td class="style2">
                    宝可梦名</td>
                <td>
                    <asp:TextBox ID="txtbkmname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    ID</td>
                <td>
                    <asp:TextBox ID="txtbkmID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    属性</td>
                <td>
                    <asp:DropDownList ID="ddlsx" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="sx" DataValueField="sx">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:pkmConnectionString10 %>" 
                        SelectCommand="SELECT [sx] FROM [sx]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    特性</td>
                <td>
                    <asp:TextBox ID="txtbkmtx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3" colspan="2">
                    <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" Text="更新" />
                    <asp:Button ID="btninsert" runat="server" onclick="btninsert_Click" Text="增加" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
