using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Styles_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_name"] != null)
            LabUser.Text = Session["user_name"].ToString();
        else
            Response.Write("<script>alert('对不起，您还没有登录！')</script>");

    }
    protected void bthUpdate_Click(object sender, EventArgs e)
    {
        string strOldpwd = txtOldpwd.Text;
        string strNewpwd = txtNewpwd.Text; ;
        string sqlstr = "select COUNT(*) from [trainer] where [username] = @name and password=@pwd";
        int count = DBHelper.ExecuteScalar<int>(CommandType.Text, sqlstr, new SqlParameter("@name", Session["user_name"].ToString()), new SqlParameter("@pwd", strOldpwd));
        if (count > 0)
        {
            String sqlstr2 = "update trainer set password=@pwd where username=@name";
            int res = DBHelper.ExecuteNonQuery(CommandType.Text, sqlstr2, new SqlParameter("@name", Session["user_name"].ToString()), new SqlParameter("@pwd", strNewpwd));
            if (res > 0)
            { Response.Write("<script>alert('密码修改成功！')</script>"); }
        }
        else
        { Response.Write("<script>alert('对不起，您输入的旧密码错误！')</script>"); }


    }
}