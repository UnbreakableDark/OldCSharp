using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Styles_bkmjieshao : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strUser =Request["para1"];
        Response.Write("欢迎用户"+strUser+"登陆本站");
    }
    protected void btutz_Click(object sender, EventArgs e)
    {
        Response.Redirect("searchbkm.aspx"); 
    }
}