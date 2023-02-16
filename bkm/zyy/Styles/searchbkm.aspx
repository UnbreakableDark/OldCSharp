<%@ Page Language="C#" AutoEventWireup="true" CodeFile="searchbkm.aspx.cs" Inherits="searchbkm" %>

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
            height: 20px;
            width: 122px;
        }
        .style4
        {
            width: 122px;
        }
        .style5
        {
            width: 344px;
            height: 25px;
        }
        .style6
        {
            width: 122px;
            height: 25px;
        }
        .style7
        {
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3">
                    宝可梦的查询</td>
                <td class="style2" colspan="3">
                </td>
            </tr>
            <tr>
                <td class="style4" style="font-weight: 700">
                    宝可梦ID：</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBkmID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    宝可梦名：</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBkmname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    属性：</td>
                <td colspan="3">
                    <asp:TextBox ID="TextBkmsx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    特性：</td>
                <td class="style2" colspan="3">
                    <asp:TextBox ID="TextBkmtx" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    </td>
                <td class="style7">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="查询" />
                </td>
                <td class="style5">
                    <asp:Button ID="Buttj" runat="server" onclick="Buttj_Click" Text="我的宝可梦" />
                </td>
                <td class="style7">
                    <asp:Button ID="Butgmm" runat="server" onclick="Butgmm_Click" Text="修改密码" />
                </td>
            </tr>
            <tr>
                <td class="style4">
                    &nbsp;</td>
                <td colspan="3">
                    <asp:GridView ID="dgUserbkm" runat="server" AutoGenerateColumns="False" 
                        onpageindexchanging="dgUserbkm_PageIndexChanging">
                        <Columns>
                            <asp:BoundField DataField="bkmname" HeaderText="宝可梦名" />
                            <asp:BoundField DataField="sx" HeaderText="属性" />
                            <asp:BoundField DataField="tx" HeaderText="特性" />
                            <asp:BoundField DataField="ID" HeaderText="宝可梦ID" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
