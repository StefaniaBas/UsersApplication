
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="UsersManagement.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>
            <b style="text-align:center;">Registration</b>
        </h3>
        <table style="border:1px black solid;text-align:center;">
            <tr>
                <td>
                    <asp:Label ID="username" runat="server" Text="Username"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="usernameValue" required="required" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="EmailValidator" runat="server" ControlToValidate="usernameValue" ErrorMessage="Enter proper email format" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwordValue" type="text" required="required"  runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="passwordConfirmation" name="passwordConfirmation" runat="server" Text="Confirm Password" ></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="passwordConfirmationValue" required="required" name="passwordConfirmationValue" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="ComparePassword" runat="server" ControlToCompare="passwordConfirmationValue" ControlToValidate="passwordValue" ErrorMessage="Password and confirm password must be same" ForeColor="Red"></asp:CompareValidator>  
          
                </td>
            </tr> 
            <tr>
                <td>
                    <asp:Label ID="firstName" runat="server" Text="First Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="firstNameValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="lastNameValue" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click" />
                </td>
            </tr>
        </table>
        <asp:Label ID="responseMessage" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
