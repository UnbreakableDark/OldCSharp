using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class bkmtj : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void search_Click(object sender, EventArgs e)
    {
        dgUserBind();
    }
    protected void dgUserBind()
    {
        string stryhname = Textyhnanme.Text;
        if (stryhname == "")
            stryhname = "%";
        string sqlstr = "select * from search where name like @name";
        DataTable result = DBHelper.ExecuteDataTable(CommandType.Text, sqlstr, new SqlParameter("@name", stryhname));   //此处用数据表，也可以用数据集
        GridView3.DataSource = result;
        GridView3.DataBind();
    }
    protected void tianjia_Click(object sender, EventArgs e)
    {
        string stryhname = Textyhnanme.Text;
        string strbkm = Textbkmname.Text;
        string strdj = Textdj.Text;
        string sqlstr = "select * from search where name like @name";
        String sqlStr = "insert into search  values(@name,@ID,@dj)";
        DBHelper.ExecuteNonQuery(CommandType.Text, sqlStr, new SqlParameter("@name", stryhname), new SqlParameter("@ID", strbkm), new SqlParameter("@dj", strdj));
        Response.Write("<script>alert('信息增加成功！')</script>");
    }
}