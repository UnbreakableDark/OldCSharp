using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class bkmguanli : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void dgUserBind()
    {
        string strID = "%" + TextBKMID.Text + "%";
        string strname = "%" + TextBKMname.Text + "%";
        string strsx =  "%" + txtBKMsx.Text + "%";
        if (strID == "")
            strID = "%";
        if (strname == "")
            strname = "%";
        if (strsx == "%其它%")
            strsx = "%";
        string sqlstr = "select * from bkm where ID like @ID and bkmname like @name and sx like @sx";
        DataTable result = DBHelper.ExecuteDataTable(CommandType.Text, sqlstr, new SqlParameter("@ID", strID), new SqlParameter("@name", strname), new SqlParameter("@sx", strsx));   //此处用数据表，也可以用数据集
        GridView2.DataSource = result;
        GridView2.DataBind();
    }
    protected void txtselect_Click(object sender, EventArgs e)
    {
        dgUserBind();
    }
    protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView2.PageIndex = e.NewPageIndex;
        dgUserBind();
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sqlstr = "delete from bkm where ID=@ID";
        DBHelper.ExecuteNonQuery(CommandType.Text, sqlstr, new SqlParameter("@ID", GridView2.DataKeys[e.RowIndex].Value.ToString()));
        dgUserBind();
    }
    protected void GridView2_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)(e.Row.Cells[4].Controls[0])).Attributes.Add("onclick", "return confirm('确定要删除该记录吗？')");
        }
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Response.Redirect("bkmInfo.aspx?name=" + GridView2.DataKeys[e.NewEditIndex].Value.ToString());
        Response.Redirect("bkmInfo.aspx");
    }
    
    protected void GridView2_SelectedIndexChanged1(object sender, EventArgs e)
    {
        
    }
    protected void Buttonyh_Click(object sender, EventArgs e)
    {
        Response.Redirect("yhSearch.aspx");
    }
}