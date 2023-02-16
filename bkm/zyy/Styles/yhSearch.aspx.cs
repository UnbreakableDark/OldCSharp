using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class yhSearch : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    void dgUserBind()
    {
        string strUser = "%" + txtUser.Text+"%";
        string strSex = "%" + ddlSex.Text + "%";
        string strcity = "%" + city.Text.Trim() + "%";
        string strcitizen = "%" + citizen.Text.Trim() + "%";
        if (strUser == "")
            strUser = "%";
        if (strSex == "%不限%")
            strSex = "%";
        if (strcity == "%不限%")
            strcity = "%";
        if (strcitizen == "%不限%")
            strcitizen = "%";
        Response.Write(strcity +"-"+strcitizen);
        string sqlstr = "select * from trainer where username like @name and sex like @sex and city like @city and citizen like @citizen";
        DataTable result = DBHelper.ExecuteDataTable(CommandType.Text, sqlstr, new SqlParameter("@name", strUser), new SqlParameter("@sex", strSex), new SqlParameter("@city", strcity),new SqlParameter("@citizen", strcitizen)); //此处用数据表，也可以用数据集
        dgUser.DataSource = result;
        dgUser.DataBind();
    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        dgUserBind();
    }
   
    protected void dgUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgUser.PageIndex = e.NewPageIndex;
        dgUserBind();
    }
    protected void dgUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sqlstr = "delete from trainer where username=@name";
        DBHelper.ExecuteNonQuery(CommandType.Text, sqlstr, new SqlParameter("@name", dgUser.DataKeys[e.RowIndex].Value.ToString()));
        dgUserBind();
    }
    protected void dgUser_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            ((LinkButton)(e.Row.Cells[6].Controls[0])).Attributes.Add("onclick", "return confirm('确定要删除该记录吗？')");
        }
    }
    protected void dgUser_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Response.Redirect("UserInfo.aspx?name=" + dgUser.DataKeys[e.NewEditIndex].Value.ToString());
    }
    protected void dgUser_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("UserInfo.aspx"); 
    }
}