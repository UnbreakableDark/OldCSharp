<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bkmtj.aspx.cs" Inherits="bkmtj" %>

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
        }
        .style3
        {
            width: 129px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    用户名：</td>
                <td>
                    <asp:TextBox ID="Textyhnanme" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    宝可梦ID：</td>
                <td>
                    <asp:TextBox ID="Textbkmname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    等级：</td>
                <td>
                    <asp:TextBox ID="Textdj" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Button ID="search" runat="server" onclick="search_Click" Text="查询" />
                </td>
                <td>
                    <asp:Button ID="tianjia" runat="server" onclick="tianjia_Click" Text="添加" />
                </td>
            </tr>
            <tr>
                <td class="style2" colspan="2">
                    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="name" HeaderText="用户名" />
                            <asp:BoundField DataField="ID" HeaderText="宝可梦ID" />
                            <asp:BoundField DataField="dj" HeaderText="等级" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
