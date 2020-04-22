using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class yhxx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Session["yhID"]="";
        if (!IsPostBack)
        {           
            DB();
        }
    }

    protected void DB()
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
        SqlCommand cmd = new SqlCommand("select * from jyb where yhID='" + Session["yhID"].ToString() + "'", conn);//访问数据库的SQL语句存到了cmd中
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);//数据适配器 执行cmd
        adp.Fill(dt1);

        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }

}
