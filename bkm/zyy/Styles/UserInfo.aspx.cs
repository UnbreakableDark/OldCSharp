using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)   //防止页面多次加载
        {
            string strUser = Request.QueryString["name"];
            string sqlstr = "select username,sex,age,email,city,citizen from trainer where username = @name ";
            DataTable result = DBHelper.ExecuteDataTable(CommandType.Text, sqlstr, new SqlParameter("@name", strUser));
            txtUser.Text = strUser;
            txtSex.Text = result.Rows[0]["sex"].ToString();
            txtEmail.Text = result.Rows[0]["email"].ToString();
            txtAge.Text = result.Rows[0]["age"].ToString();
            txtcity.Text = result.Rows[0]["city"].ToString();
            txtcitizen.Text = result.Rows[0]["citizen"].ToString();
        }
    }


    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string strUser = txtUser.Text;
        string strEmail = txtEmail.Text;
        string strSex = txtSex.Text;
        string strAge = txtAge.Text;
        string strcity = txtcity.Text;
        string strcitizen = txtcitizen.Text;
        String sqlStr = "update trainer set city=@city,citizen=@citizen where username=@name";
        DBHelper.ExecuteNonQuery(CommandType.Text, sqlStr, new SqlParameter("@name", strUser), new SqlParameter("@email", strEmail), new SqlParameter("@age", strAge), new SqlParameter("@email", strEmail), new SqlParameter("@city", strcity), new SqlParameter("@citizen", strcitizen));
    }
}