<%@ Page Language="C#" AutoEventWireup="true" CodeFile="T1.aspx.cs" Inherits="T1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登录界面</title>
    <style>
        body{
            overflow: hidden;
        }
        #div1{
            width:400px;
            height: 400px;
            font-family: 楷体;
            background:rgba(128, 128, 128,0.7);
            border-radius: 30px;
            position: absolute;
            top: 50%;
            left: 50%;
            margin-left: -200px;
            margin-top: -200px;
            text-align: center;
            box-shadow: 10px 10px 15px #fff;
        }
        #div1 #p1{
            font-size: 40px;
            font-weight: bold;
            padding-top: 30px;
        }
    </style>
</head>
<body style="background-color:#d4f7ac">
    <form id="form1" runat="server">
    <div id="div1">
        <P id="p1">图书管理系统</P>
        <%--<center><asp:Label ID="Label1" runat="server" BackColor="#d4f7ac" BorderColor="#d4f7ac" BorderStyle="None" BorderWidth="40px" Font-Size="XX-Large" ForeColor="Black" Text="用户登录" ></asp:Label></center>--%>

        <p id="p2">用户名:    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></p><br />
        <p id="p3">密&nbsp;&nbsp;码：<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></p>
        <br />
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" style="margin:auto"   RepeatDirection="Horizontal">
            <asp:ListItem>用户</asp:ListItem>
            <asp:ListItem>管理员</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
