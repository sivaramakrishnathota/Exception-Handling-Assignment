<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="SignUpAndLoginApp.Signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <h2>Registration</h2>
            <asp:TextBox ID="txtUserName" runat="server" placeholder="UserName"></asp:TextBox>
            <br/>
            <asp:TextBox ID="txtMobileNumber" runat="server" placeholder="MobileNumber"></asp:TextBox><br />
            <asp:TextBox ID="txtRegEmail" runat="server" placeholder="Email"></asp:TextBox><br />
            <asp:TextBox ID="txtRegPassword" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox><br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" /><br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
            </center>
    </form>
</body>
</html>
