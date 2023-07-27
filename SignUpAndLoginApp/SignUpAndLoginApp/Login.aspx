<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SignUpAndLoginApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div>
                <h2>Login</h2>
                <asp:TextBox ID="txtLoginEmail" runat="server" placeholder="Email"></asp:TextBox><br />
                <asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox><br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                <asp:Button ID="btnForGot" runat="server" Text="ForgotPassword" OnClick="btnForgotPassword_Click" />
            </div>
        </center>
    </form>
</body>
</html>
