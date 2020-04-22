using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class T1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        if (TextBox1.Text.Trim() != "")
        {
            if (RadioButtonList2.SelectedItem.Text == "用户")
            {

                SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
                SqlCommand cmd = new SqlCommand("select * from yhb where yhID='" + TextBox1.Text.Trim() + "' and yhmm='" + TextBox2.Text.Trim() + "'", conn);//访问数据库的SQL语句存到了cmd中
                conn.Open();//打开连接
                SqlDataReader dr1 = cmd.ExecuteReader();  //创建获取datareader
                if (dr1.Read())  //while
                {
                    Session["yhID"] = TextBox1.Text;                
                   // Session["yhxm"] = TextBox2.Text;
                    Response.Redirect("T3.aspx");
                }
                else
                {
                    Response.Write("<script>alert('密码错误!')</script>");
                }
                conn.Close();//关闭连接
            }
            


            else if (RadioButtonList2.SelectedItem.Text == "管理员")
            {
                SqlConnection conn = new SqlConnection("SERVER=.;DATABASE=tsgl;PWD=;UID=sa;");  //创建一个数据库连接
                SqlCommand cmd = new SqlCommand("select * from gly where glyID='" + TextBox1.Text.Trim() + "'and glymm='" + TextBox2.Text.Trim() + "' ", conn);//访问数据库的SQL语句存到了cmd中
                conn.Open();//打开连接
                SqlDataReader dr1 = cmd.ExecuteReader();  //创建获取datareader
                if (dr1.Read())  //while
                {
                    
                    Response.Redirect("T4.aspx");
                }
                else
                {
                    Response.Write("<script>alert('密码错误!')</script>");
                }
                conn.Close();//关闭连接
            }
           
        
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("T2.aspx");
    }
}







