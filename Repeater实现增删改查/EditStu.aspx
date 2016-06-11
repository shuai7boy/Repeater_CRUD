<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditStu.aspx.cs" Inherits="Repeater实现增删改查.EditStu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        编辑页面<br />
        姓名:<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        年龄:<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="保存修改" />
    
    </div>
    </form>
</body>
</html>
