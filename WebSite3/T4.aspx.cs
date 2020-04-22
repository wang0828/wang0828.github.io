using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class T4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
    
        Response.Redirect("yh2.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
     
        Response.Redirect("ts2.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("cxjy.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        

        Response.Redirect("gsb.aspx");
    }
}