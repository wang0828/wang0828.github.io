<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ns.aspx.cs" Inherits="ns" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>新书入库</title>
</head>
<body style="background-color:#d4f7ac">

    <form id="form1" runat="server" style="font-family: 华文楷体; font-size:20px; background-color: #d4f7ac; text-align:center">
        
            <br />
            <br />
            &nbsp;&nbsp;&nbsp; 新书入库<br />
            <br />
        
            编号：&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
        
           
            <br />
        
        
           
            <br />
            书名：&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        
        
           
            <br />
        
        
           
            <br />
            作者：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        
        
           
            
            <br />
        
        
           
            <br />
            出版社：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        
        
           
            <br />
        
        
           
            <br />
            数量：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        
        
           
            <br />
            <br />
            位置：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        
        
           
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="入库" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"  />
        
        
           
    </form>

    </body>
</html>
