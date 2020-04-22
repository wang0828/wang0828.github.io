<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ts2.aspx.cs" Inherits="ts2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>图书信息表</title>
    <style>
        #div2{
            width: 650px;
            height:500px;
            position:absolute;
            top:50%;
            left:50%;
            margin-left:-275px;
            margin-top:-250px;
            text-align:center;
        }
    </style>
</head>
<body style="font-family: 华文楷体; font-size:20px; background-color: #d4f7ac; ">
    <form id="form1" runat="server">
    <div id="div2">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bh" OnPageIndexChanging="GridView1_PageIndexChanging1" OnRowCancelingEdit="GridView1_RowCancelingEdit1" OnRowDeleting="GridView1_RowDeleting1" OnRowEditing="GridView1_RowEditing1" OnRowUpdating="GridView1_RowUpdating1" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="bh" HeaderText="编号" />
                <asp:BoundField DataField="mz" HeaderText="书名" />
                <asp:BoundField DataField="zz" HeaderText="作者" />
                <asp:BoundField DataField="cbs" HeaderText="出版社" />
                <asp:BoundField DataField="sl" HeaderText="数量" />
                <asp:BoundField DataField="wz" HeaderText="位置" />
                <asp:CommandField ButtonType="Button" SelectText="编辑" ShowEditButton="True" />
                <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" Text="添加图书" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回页面" OnClick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>
