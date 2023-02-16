using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Styles_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        string strUser = txtUser.Text;
        string strPwd = txtPwd.Text;
        int intAge = Convert.ToInt32(txtAge.Text);
        string strEmail = txtEmail.Text;
        string strSex;
        if (rdoMale.Checked == true)
            strSex = "男";  // strSex = "男";
        else
            strSex = "女";  // strSex = "女";
        string strcity = city.Text;
        string strcitizen = citizen.Text;
        try
        {
            String sqlStr = "insert into trainer(username,password,age,email,sex,city,citizen) values(@name,@pwd,@age,@email,@sex,@city,@citizen)";
            int res = DBHelper.ExecuteNonQuery(CommandType.Text, sqlStr, new SqlParameter("@name", strUser), new SqlParameter("@pwd", strPwd), new SqlParameter("@age", intAge), new SqlParameter("@email", strEmail), new SqlParameter("@sex", strSex), new SqlParameter("@city", strcity), new SqlParameter("@citizen", strcitizen));
            if (res > 0)
            { Response.Write("<script>alert('恭喜您，注册成功！')</script>"); }
        }
        catch
        {
            string sqlstr = "select COUNT(*) from trainer where username = @name";
            int count = DBHelper.ExecuteScalar<int>(CommandType.Text, sqlstr, new SqlParameter("@name", strUser));
            if (count > 0)
            { Response.Write("<script>alert('对不起，该用户名已经存在！')</script>"); }
            else
            { Response.Write("<script>alert('对不起，执行失败！')</script>"); }
        }
        //Response.Redirect("Login.aspx");
    }

}