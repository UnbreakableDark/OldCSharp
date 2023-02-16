using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class searchbkm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void dgUserBind()
    {
        string strID = "%" + TextBkmID.Text + "%";
        string strname = "%" + TextBkmname.Text + "%";
        string strsx = "%" + TextBkmsx.Text + "%";
        string strtx = "%" + TextBkmtx.Text + "%";
        if (strID == "")
            strID = "%";
        if (strname == "")
            strname = "%";
        if (strsx == "")
            strsx = "%";
        if (strtx == "")
            strtx = "%";
        string sqlstr = "select * from bkm where ID like @ID and bkmname like @name and sx like @sx and tx like @tx";
        DataTable result = DBHelper.ExecuteDataTable(CommandType.Text, sqlstr, new SqlParameter("@ID", strID), new SqlParameter("@name", strname), new SqlParameter("@sx", strsx),new SqlParameter("@tx", strtx));   //此处用数据表，也可以用数据集
        dgUserbkm.DataSource = result;
        dgUserbkm.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dgUserBind();
    }

    protected void dgUserbkm_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgUserbkm.PageIndex = e.NewPageIndex;
        dgUserBind();
    }
    protected void Buttj_Click(object sender, EventArgs e)
    {

        Response.Redirect("bkmtj.aspx");
    }
    protected void Butgmm_Click(object sender, EventArgs e)
    {

        Response.Redirect("User_Update.aspx");
    }
}