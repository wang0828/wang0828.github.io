﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class njyb : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
        SqlCommand cmd = new SqlCommand("select * from jyb", conn);//访问数据库的SQL语句存到了cmd中
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);//数据适配器 执行cmd
        adp.Fill(dt1);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection conn1 = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");
        SqlCommand cmd1 = new SqlCommand("insert into jyb(yhID,yhxm,lxfs,mz,jsrq,hsrq)    values('" + TextBox1.Text + "' ,'" + TextBox2.Text + "' ,'" + TextBox3.Text + "','" + TextBox4.Text + "' ,'" + TextBox5.Text + "','" + TextBox6.Text + "' )", conn1);
        conn1.Open();//打开连接
        cmd1.ExecuteNonQuery();//执行Command对象的各种数据库操作
        conn1.Close();//关闭连接
        Response.Write("<script>alert('添加成功!')</script>");
       // Response.Redirect("T1.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("cxjy.aspx");
    }
}