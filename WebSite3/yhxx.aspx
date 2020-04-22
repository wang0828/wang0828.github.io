<%@ Page Language="C#" AutoEventWireup="true" CodeFile="yhxx.aspx.cs" Inherits="yhxx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>个人借阅信息</title>
    <style>
        #div6{
            width: 620px;
            height:500px;
            position:absolute;
            top:50%;
            left:50%;
            margin-left:-275px;
            margin-top:-250px;
            text-align:center;
        }
    </style>
</head >
<body  style="font-family: 华文楷体;  text-align:center; background-color:#d4f7ac">
    
    <form id="form1" runat="server" style="font-family: 华文楷体; background-color: #d4f7ac; text-align:center">
    <div id="div6" >
    
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
           <Columns>
                <asp:BoundField DataField="yhID" HeaderText="帐号" />
                <asp:BoundField DataField="yhxm" HeaderText="姓名" />
                <asp:BoundField DataField="lxfs" HeaderText="联系方式" />
                <asp:BoundField DataField="mz" HeaderText="书名" />
                <asp:BoundField DataField="jsrq" HeaderText="借书日期" />
                <asp:BoundField DataField="hsrq" HeaderText="还书日期" />
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
    
    </div>
    </form>
</body>
</html>
