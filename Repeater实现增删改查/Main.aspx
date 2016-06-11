<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Repeater实现增删改查.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function delMsg() {
            if (confirm('你确定要删除?')) {
                return true;
            } else {
                return false;
            }
        };
    </script>
</head>
<body>
<a href="AddStu.aspx">增加一个学生信息</a><br />
--------------数据列表----------------
    <form id="form1" runat="server">
    <div>
            
        <asp:Repeater ID="Repeater1" runat="server" 
            onitemcommand="Repeater1_ItemCommand">
        <HeaderTemplate>
        <table>
        <thead>
        <tr>
        <th>编号</th><th>姓名</th><th>年龄</th><th>操作</th>
        </tr>
        </thead>
        </HeaderTemplate>
        <ItemTemplate>
        <tbody>
        <tr>
        <td><%#Eval("StuId") %></td>
        <td><%#Eval("StuName") %></td>
        <td><%#Eval("StuAge") %></td>
        <td>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"~/EditStu.aspx?id="+Eval("StuId") %>'>编辑</asp:HyperLink>                  
         <!--OnClick是给服务端注册一个单击事件 我们因为要注册Js事件，所以使用OnClientClick-->
            <asp:LinkButton ID="LinkButton1" runat="server" CommandName="delete" CommandArgument='<%#Eval("StuId") %>' OnClientClick="return delMsg();">删除</asp:LinkButton>
        </td>
        </tr>
        </tbody>
        </ItemTemplate>
        <FooterTemplate>
        </table>
        </FooterTemplate>
        </asp:Repeater>
        <br />
        <p> <%--分页--%>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
         </p>
    </div>
    </form>
</body>
</html>
