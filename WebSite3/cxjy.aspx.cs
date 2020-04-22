using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cxjy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
       
        if (!IsPostBack)
        {
            databind();
        }
    }

    protected void databind()
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
        SqlCommand cmd = new SqlCommand("select * from jyb", conn);//访问数据库的SQL语句存到了cmd中
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);//数据适配器 执行cmd
        adp.Fill(dt1);

        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("njyb.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("T4.aspx");
    }




    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        databind();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        databind();
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;  //GridView编辑项索引等于单击行的索引
        databind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");

        string hsrq = (GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text.Trim();

        string aaa = "update jyb set hsrq='" + hsrq + "' where yhID='" + (GridView1.DataKeys[e.RowIndex].Values[0]).ToString().Trim() + "'";

        SqlCommand cmd = new SqlCommand(aaa, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script>alert('修改成功!')</script>");
        GridView1.EditIndex = -1;
        databind();
    }


    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");
        string sc = "delete from jyb where yhID='" + (GridView1.Rows[e.RowIndex].Cells[0]).Text.Trim() + "'";

        SqlCommand cmd = new SqlCommand(sc, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script>alert('删除成功!')</script>");
        GridView1.EditIndex = -1;
        databind();
    }
}