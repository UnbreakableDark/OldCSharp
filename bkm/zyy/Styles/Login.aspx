<%@ Page Title="" Language="C#" MasterPageFile="~/Styles/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Styles_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style8
    {
        width: 435px;
            height: 264px;
        }
    .style9
    {
        height: 20px;
        width: 113px;
            background-color: #CCFFCC;
        }
        .style13
        {
            background-color: #CCFFFF;
        }
        .style14
        {
            height: 20px;
            width: 80px;
            font-family: 隶书;
            font-weight: bold;
            font-size: xx-large;
            letter-spacing: 3px;
            background-color: #CCFFFF;
        }
        .style15
        {
            background-color: #CCFFFF;
            height: 20px;
        }
        .style16
        {
            width: 80px;
            height: 20px;
            font-family: 隶书;
            font-weight: bold;
            font-size: xx-large;
        }
        .style18
        {
            width: 80px;
            height: 21px;
            font-family: 隶书;
            font-weight: bold;
            font-size: xx-large;
        }
        .style19
        {
            height: 21px;
        }
        .style28
        {
            color: #FF5050;
            font-weight: bold;
            font-size: x-large;
            margin-top: 30px;
            margin-bottom: 30px;
        }
        .style29
        {
            width: 112px;
            background-color: #CCFFFF;
            font-size: large;
            color: #0000FF;
            margin-top: 5px;
            margin-bottom: 5px;
        }
        .style30
        {
            font-size: medium;
            color: #0000FF;
            width: 110px;
            margin-top: 10px;
            margin-bottom: 10px;
        }
        .style31
        {
            color: #0000FF;
            font-weight: bold;
            font-size: medium;
            width: 115px;
            margin-top: 10px;
            margin-bottom: 10px;
        }
        .style32
        {
            width: 80px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style8">
    <tr>
        <td colspan="2" class="style13">
            <p class="style28" style="width: 594px">
            欢迎来到宝贝图鉴，请登陆</p>
        </td>
    </tr>
    <tr>
        <td class="style14">
            <p class="style29">
                用户名:</p>
        </td>
        <td class="style2" style="background-color: #CCFFFF">
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style18">
            <p class="style30">
                密码:</p>
        </td>
        <td class="style19">
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style32">
            <p class="style31">
                身份:</p>
        </td>
        <td>
            <asp:RadioButton ID="rdoUser" runat="server" Checked="True" GroupName="shenfen" 
                 Text="训练家" />
            <asp:RadioButton ID="rdomanage" runat="server" GroupName="shenfen" Text="馆主"  />
        </td>
    </tr>
    <tr>
        <td class="style16">
            </td>
        <td class="style2">
            <asp:Button ID="btnLogin_" runat="server" onclick="btnLogin__Click" Text="登陆" />
        </td>
    </tr>
    <tr>
        <td class="style14">
        </td>
        <td class="style2">
            <p style="text-align: center">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="注册" />
            </p>
        </td>
    </tr>
    <tr>
        <td colspan="2" class="style15">
            </td>
    </tr>
</table>
</asp:Content>

