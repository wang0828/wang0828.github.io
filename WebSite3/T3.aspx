<%@ Page Language="C#" AutoEventWireup="true" CodeFile="T3.aspx.cs" Inherits="T3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图书信息表</title>
    <style>
        #div1{
            width: 800px;
            height: 600px;
            position: absolute;
            top: 50%;
            left: 50%;
            margin-left: -400px;
            margin-top: -300px;
            font-family:楷体;
        }
       #p1{
            font-size: 24px;
            font-weight: bold;
        }
    </style>
</head>
<body style="background-color:#d4f7ac">
    <form id="form1" runat="server">
        <div id="div1">
            <p id="p1">欢迎<asp:TextBox ID="TextBox1" runat="server" style="font-family: 华文楷体; background-color: #d4f7ac; border:none;font-size: 24px; " Width="40px" ReadOnly="True"></asp:TextBox>同学</p>
            <p><asp:Button ID="Button1" runat="server" Text="查看个人借阅信息" OnClick="Button1_Click" /></p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  OnRowCommand="GridView1_RowCommand" style="width:800px; height:400px;text-align:center; " >
                <Columns>
                    <asp:BoundField DataField="mz" HeaderText="书名" />
                    <asp:BoundField DataField="zz" HeaderText="作者 " />
                    <asp:BoundField DataField="sl" HeaderText="库存" />
                    <asp:BoundField DataField="wz" HeaderText="位置" />
                    <asp:CommandField ButtonType="Button" SelectText="借书" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
