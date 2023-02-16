using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Styles_bkmInfo : System.Web.UI.Page
{
 /* 
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)   //防止页面多次加载
        {
            string strUser = Request.QueryString["bkmname"];
            string sqlstr = "select bkmname,ID,sx,tx from bkm where bkmnname = @name ";
            DataTable result = DBHelper.ExecuteDataTable(CommandType.Text, sqlstr, new SqlParameter("@name", strUser));
            txtbkmname.Text = strUser;
            txtbkmID.Text = result.Rows[0]["ID"].ToString();
            txtbkmtx.Text = result.Rows[0]["tx"].ToString();
            ddlsx.SelectedValue = result.Rows[0]["sx"].ToString();

        }
    }
    */
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string strUser = txtbkmname.Text;
        string strID = txtbkmID.Text;
        string strsx = ddlsx.Text;
        string strtx = txtbkmtx.Text;
        string sqlstr = "select COUNT(*) from [bkm] where [bkmname] = @name ";
      String sqlStr = "update bkm set bkmname=@name,ID=@bkmID,sx=@bkmsx,tx=@bkmtx where bkmname=@name";
      DBHelper.ExecuteNonQuery(CommandType.Text, sqlStr, new SqlParameter("@name", strUser), new SqlParameter("@bkmID", strID), new SqlParameter("@bkmtx", strtx), new SqlParameter("@bkmsx", strsx));
      Response.Write("<script>alert('宝可梦信息修改成功！')</script>");
      
 
    }



    protected void btninsert_Click(object sender, EventArgs e)
    {
        string strUser = txtbkmname.Text;
        string strID = txtbkmID.Text;
        string strsx = ddlsx.Text;
        string strtx = txtbkmtx.Text;
        string sqlstr = "select COUNT(*) from [bkm] where [bkmname] = @name ";
        String sqlStr = "insert into bkm values('@bkmID','@name','@bkmsx','@bkmtx')";
        DBHelper.ExecuteNonQuery(CommandType.Text, sqlStr, new SqlParameter("@name", strUser), new SqlParameter("@bkmID", strID), new SqlParameter("@bkmtx", strtx), new SqlParameter("@bkmsx", strsx));
        Response.Write("<script>alert('宝可梦信息增加成功！')</script>");
      
    }
}
