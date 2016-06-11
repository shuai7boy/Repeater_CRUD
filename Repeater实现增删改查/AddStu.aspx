<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddStu.aspx.cs" Inherits="Repeater实现增删改查.AddStu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        添加学生信息界面<br />
        姓名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        年龄:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="增加" />
    
    </div>
    </form>
</body>
</html>
