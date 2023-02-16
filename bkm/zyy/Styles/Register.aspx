<%@ Page Title="" Language="C#" MasterPageFile="~/Styles/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Styles_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style3
        {
            width: 128px;
        }
        .style5
        {
            width: 128px;
            height: 23px;
            font-family: 隶书;
            font-weight: bold;
            font-size: medium;
            background-color: #FFFFFF;
        }
        .style28
    {
        height: 20px;
        background-color: #CCFFFF;
    }
    .style29
    {
        height: 20px;
        width: 128px;
        background-color: #FFFFFF;
    }
    .style32
    {
        margin-top: 10px;
        margin-bottom: 10px;
    }
    .style33
    {
        font-family: 隶书;
        font-weight: bold;
        font-size: medium;
        margin-top: 10px;
        margin-bottom: 10px;
    }
    .style34
    {
            width: 128px;
            height: 20px;
            font-family: 隶书;
            font-weight: bold;
            font-size: medium;
            background-color: #FFFFFF;
        }
    .style35
    {
        height: 20px;
        text-align: center;
        background-color: #FFFFFF;
    }
    .style36
    {
        font-family: 隶书;
        font-weight: bold;
        font-size: xx-large;
        margin-top: 10px;
        margin-bottom: 10px;
    }
        .style37
        {
            background-color: #FFFFFF;
        }
        .style38
        {
            height: 23px;
            background-color: #FFFFFF;
        }
        .style39
        {
            height: 20px;
            width: 302px;
            background-color: #FFFFFF;
        }
        .style40
        {
            width: 128px;
            height: 20px;
            font-family: 新宋体;
            font-style: italic;
            font-weight: bold;
            font-size: xx-large;
            background-color: #FFFFFF;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <table class="style1">
            <tr>
                <td class="style29">
                </td>
                <td class="style35">
                    <p class="style36">
                    注册页面</p>
                </td>
                <td class="style39">
                </td>
            </tr>
            <tr>
                <td class="style34">
                    <p class="style32">
                    用户名：</p>
                </td>
                <td class="style37">
                    <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
                </td>
                <td class="style37">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtUser" ErrorMessage="用户名不能为空">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style34">
                    <p class="style32">
                    密码：</p>
                </td>
                <td class="style37">
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="style37">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtPwd" ErrorMessage="密码不能为空">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <p class="style33">
                    确定密码：</p>
                </td>
                <td class="style38">
                    <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="style38">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtPwd2" ErrorMessage="确认密码不能为空">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtPwd" ControlToValidate="txtPwd2" 
                        ErrorMessage="两次输入的密码不一致，请重新输入"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="style34">
                    <p class="style33">
                    年龄：</p>
                </td>
                <td class="style39">
                    <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
                </td>
                <td class="style39">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtAge" ErrorMessage="年龄不能为空">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtAge" ErrorMessage="年龄是1-100之间的整数" MaximumValue="100" 
                        MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td class="style34">
                    <p class="style32">
                    性别：</p>
                </td>
                <td class="style37">
                    <asp:RadioButton ID="rdoMale" runat="server" Checked="True" GroupName="rdoSex" 
                        Text="男" />
                    <asp:RadioButton ID="rdoFemale" runat="server" GroupName="rdoSex" Text="女" />
                </td>
                <td class="style37">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style34">
                    <p class="style32">
                    email：</p>
                </td>
                <td class="style37">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td class="style37">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Email不能为空">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Email格式错误" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    <p class="style33">
                    所属城市：</p>
                </td>
                <td class="style38">
                    <asp:DropDownList ID="city" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="city" DataValueField="city">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:pkmConnectionString5 %>" 
                        SelectCommand="SELECT [city] FROM [city]"></asp:SqlDataSource>
                </td>
                <td class="style38">
                    </td>
            </tr>
            <tr>
                <td class="style5">
                    <p class="style33">
                    所属地区：</p>
                </td>
                <td class="style38">
                    <asp:DropDownList ID="citizen" runat="server" DataSourceID="SqlDataSource2" 
                        DataTextField="citizen" DataValueField="citizen">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                        ConnectionString="<%$ ConnectionStrings:pkmConnectionString6 %>" 
                        SelectCommand="SELECT [citizen] FROM [union]"></asp:SqlDataSource>
                </td>
                <td class="style38">
                    </td>
            </tr>
            <tr>
                <td class="style40">
              
                    <asp:Label ID="Label1" runat="server" Text="   "></asp:Label>
                </td>
                <td class="style37">
                    <asp:Button ID="btnRegister" runat="server" Text="注册" 
                        onclick="btnRegister_Click" />
                </td>
                <td class="style37">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                        ShowMessageBox="True" ShowSummary="False" />
                </td>
            </tr>
        </table>
</asp:Content>

