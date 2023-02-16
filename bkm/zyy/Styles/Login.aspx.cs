using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Styles_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 //   protected void btnregister_Click(object sender, EventArgs e)
 //   {
 //       Response.Write("asdawsd");
 //       Response.Redirect("Register.aspx");
 //   }
    protected void btnLogin__Click(object sender, EventArgs e)
    {
       
        string strUser = txtUser.Text;
        string strPwd = txtPwd.Text;
        if (rdoUser.Checked == true)
        {
            string sqlstr = "select COUNT(*) from [trainer] where [username] = @name and password=@pwd";
            int count = DBHelper.ExecuteScalar<int>(CommandType.Text, sqlstr, new SqlParameter("@name", strUser), new SqlParameter("@pwd", strPwd));
            if (count > 0)
            {
                Session["user_name"] = strUser;
                Response.Write("<script>alert('登陆成功')</script>");//++
                Response.Redirect("bkmjieshao.aspx");       //    为了测试更新密码而改
               // Response.Redirect("bkmjieshao.aspx?para1=" + strUser);               
            }
            else
            {
                Response.Write("<script>alert('对不起，用户名密码错误，请重新输入！')</script>");
            }
        }
        else if (rdoUser.Checked == false)
        {
            //Response.Write("asdawsd");
            string sqlstr = "select COUNT(*) from [manager1] where [mname] = @name and mpassword=@pwd";
            int count = DBHelper.ExecuteScalar<int>(CommandType.Text, sqlstr, new SqlParameter("@name", strUser), new SqlParameter("@pwd", strPwd));
            if (count > 0)
            {
                Session["user_name"] = strUser;
                Response.Redirect("bkmguanli.aspx");
            }
            else
            {
                Response.Write("<script>alert('对不起，用户名密码错误，请重新输入！')</script>");
            }
            //可根据管理员表判断是否用户名密码成功，若成功则跳转至相应界面
        }    
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}
