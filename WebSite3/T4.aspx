<%@ Page Language="C#" AutoEventWireup="true" CodeFile="T4.aspx.cs" Inherits="T4" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>后台管理界面</title>
    <style>
        #div1{
            width: 420px;
            height: 420px;
            background: #ffbb00;
            position:absolute;
            top:50%;
            left:50%;
            margin-left:-210px;
            margin-top:-210px;
            text-align:center;
            padding-top:10px;
            border-radius: 20px;
        }
    </style>
</head>
<body style="font-family: 华文楷体; background-color: #d4f7ac; text-align:center">
    <form id="form1" runat="server" >
    <div id="div1">
        <asp:Button ID="Button1" runat="server" Text="用户信息" BackColor="#CCFF66" BorderColor="#CCFF66" Font-Size="20pt" OnClick="Button1_Click" Width="200px" Height="200px" style="border-radius:20px;" />
        <asp:Button ID="Button2" runat="server" Text="图书信息" BackColor="#CCFF66" BorderColor="#CCFF66" Font-Size="20pt" OnClick="Button2_Click" Width="200px" Height="200px" style="border-radius:20px;" />
        <asp:Button ID="Button3" runat="server" Text="借阅信息" BackColor="#CCFF66" BorderColor="#CCFF66" Font-Size="20pt" OnClick="Button3_Click" Width="200px" Height="200px" style="border-radius:20px;margin-top:10px;" />
        <asp:Button ID="Button4" runat="server" Text="挂失信息" BackColor="#CCFF66" BorderColor="#CCFF66" Font-Size="20pt" OnClick="Button4_Click" Width="200px" Height="200px" style="border-radius:20px;" />
    </div>
    </form>
</body>
</html>
