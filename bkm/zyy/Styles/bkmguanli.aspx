<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bkmguanli.aspx.cs" Inherits="bkmguanli" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            height: 20px;
            width: 100px;
        }
        .style4
        {
        }
        .style5
        {
            width: 100px;
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
                    宝可梦管理</td>
                <td class="style3" colspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    宝可梦ID:</td>
                <td class="style4" colspan="2">
                    <asp:TextBox ID="TextBKMID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style4">
                    宝可梦名:</td>
                <td class="style4" colspan="2">
                    <asp:TextBox ID="TextBKMname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    属性:</td>
                <td class="style3" colspan="2">
                    <asp:DropDownList ID="txtBKMsx" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="sx" DataValueField="sx">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:pkmConnectionString9 %>" 
                        SelectCommand="SELECT [sx] FROM [sx]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td class="style5">
                </td>
                <td class="style5">
                    <asp:Button ID="txtselect" runat="server" Text="查询" onclick="txtselect_Click" 
                        style="height: 21px" />
                </td>
                <td class="style5">
                    <asp:Button ID="Buttonyh" runat="server" onclick="Buttonyh_Click" 
                        Text="用户信息查询" />
                </td>
            </tr>
            <tr>
                <td class="style4" colspan="3">
                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                        onpageindexchanging="GridView2_PageIndexChanging" 
                        onrowdatabound="GridView2_RowDataBound" onrowdeleting="GridView2_RowDeleting" 
                        onrowediting="GridView2_RowEditing" 
                        onselectedindexchanged="GridView2_SelectedIndexChanged1" DataKeyNames="ID">
                        <Columns>
                            <asp:BoundField DataField="ID" HeaderText="宝可梦ID" />
                            <asp:BoundField DataField="bkmname" HeaderText="宝可梦名" />
                            <asp:BoundField DataField="sx" HeaderText="属性" />
                            <asp:BoundField DataField="tx" HeaderText="特性" />
                            <asp:CommandField HeaderText="删除" ShowDeleteButton="True" />
                            <asp:CommandField HeaderText="更新" ShowCancelButton="False" 
                                ShowEditButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
