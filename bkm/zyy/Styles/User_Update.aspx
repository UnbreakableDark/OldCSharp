<%@ Page Language="C#" AutoEventWireup="true" CodeFile="User_Update.aspx.cs" Inherits="Styles_Default" %>

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
        }
        .style4
        {
            height: 20px;
            width: 244px;
        }
        .style5
        {
            width: 230px;
        }
        .style6
        {
            height: 20px;
            width: 230px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style3" colspan="3">
                    修改密码</td>
            </tr>
            <tr>
                <td class="style2">
                    用户名</td>
                <td class="style6">
                    <asp:Label ID="LabUser" runat="server" Text="LabUser"></asp:Label>
                </td>
                <td class="style2">
                </td>
            </tr>
            <tr>
                <td class="style3">
                    请输入原密码</td>
                <td class="style5">
                    <asp:TextBox ID="txtOldpwd" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style4">
                    请输入新密码</td>
                <td class="style6">
                    <asp:TextBox ID="txtNewpwd" runat="server"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    请再一次输入新密码</td>
                <td class="style5">
                    <asp:TextBox ID="txtNewpwd2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtNewpwd" ControlToValidate="txtNewpwd2" 
                        ErrorMessage="两次输入的密码不一致，请重新输入"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td colspan="2">
                    <asp:Button ID="bthUpdate" runat="server" onclick="bthUpdate_Click" Text="更改" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
