<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_exp.aspx.cs" Inherits="Gitexp_pro.Form_exp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" Text="Enter name:"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Text="Enter sur name:"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
