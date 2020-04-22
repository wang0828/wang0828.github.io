using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
public partial class T3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!IsPostBack)
        {
            TextBox1.Text = Session["yhID"].ToString();
           
            DB();

        }
    }

    protected void DB()
    {
        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
        SqlCommand cmd = new SqlCommand("select * from tsb", conn);//访问数据库的SQL语句存到了cmd中
        DataTable dt1 = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);//数据适配器 执行cmd
        adp.Fill(dt1);

        GridView1.DataSource = dt1;
        GridView1.DataBind();
    }

   





    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["yhID"] = TextBox1.Text;
        Response.Redirect("yhxx.aspx"); 
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string mz = GridView1.Rows[Convert.ToInt16(e.CommandArgument)].Cells[0].Text, jsrq=DateTime.Now.ToShortDateString();

        Session["yhID"] = Session["yhID"] + "";

        SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
        SqlCommand cmd = new SqlCommand("select * from yhb where yhID='"+ Session["yhID"] + "'", conn);
        conn.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if(dr.Read())
        {
            string xm = dr["yhxm"].ToString(),lxfs=dr["lxfs"].ToString();
            SqlConnection conn1 = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
            SqlCommand cmd1= new SqlCommand("insert into jyb (yhID,yhxm,lxfs,mz,jsrq,hsrq)  values('"+ Session["yhID"] + "','" + xm + "','" + lxfs + "','" + mz + "','" +jsrq + "','') ", conn1);
            conn1.Open();
            cmd1.ExecuteNonQuery();
            conn1.Close();

            SqlConnection conn2 = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
            SqlCommand cmd2 = new SqlCommand("update tsb set  sl=sl-1 where mz='"+mz+"' ", conn2);
            conn2.Open();
            cmd2.ExecuteNonQuery();
            conn2.Close();
        }
        conn.Close();
        DB();
    }
}