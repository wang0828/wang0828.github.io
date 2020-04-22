﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

public partial class ts2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            databind();
        }

    }

    public void databind()
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
        SqlCommand cmd = new SqlCommand("select * from tsb", conn);//访问数据库的SQL语句存到了cmd中
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);//数据适配器 执行cmd
        adp.Fill(dt1);


        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }






    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        databind();
    }

    protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        databind();
    }

    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;  //GridView编辑项索引等于单击行的索引
        databind();
    }

    protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
    {

        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");

        string wz = (GridView1.Rows[e.RowIndex].Cells[5].Controls[0] as TextBox).Text.Trim();

        string aaa = "update tsb set wz='" + wz + "' where bh='" + (GridView1.DataKeys[e.RowIndex].Values[0]).ToString().Trim() + "'";

        SqlCommand cmd = new SqlCommand(aaa, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script>alert('修改成功!')</script>");
        GridView1.EditIndex = -1;
        databind();
    }

    protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");
        string sc = "delete from tsb where bh='" + (GridView1.Rows[e.RowIndex].Cells[0]).Text.Trim() + "'";

        SqlCommand cmd = new SqlCommand(sc, conn);
        conn.Open();
        cmd.ExecuteNonQuery();
        conn.Close();
        Response.Write("<script>alert('删除成功!')</script>");
        GridView1.EditIndex = -1;
        databind();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
 
        Response.Redirect("ns.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("T4.aspx");
    }
}