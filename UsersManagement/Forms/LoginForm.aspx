<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="UsersManagement.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>
            <b style="text-align:center;">Login</b>
        </h3>
        <table style="border:1px black solid;text-align:center;">
            <tr>
                <td>
                    <asp:Label ID="username" runat="server" Text="Username"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="usernameValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwordValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="login" runat="server" Text="Login" OnClick="login_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="responseMessage" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
