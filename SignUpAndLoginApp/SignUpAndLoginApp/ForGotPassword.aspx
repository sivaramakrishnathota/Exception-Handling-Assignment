<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForGotPassword.aspx.cs" Inherits="SignUpAndLoginApp.ForGotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center>
            <div>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox><br />
                <asp:TextBox ID="txtUserName" runat="server" placeholder="userName"></asp:TextBox><br />
                <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" placeholder="NewPassword"></asp:TextBox><br />
                <asp:Button ID="btnResetPassword" runat="server" Text="ResetPassword" OnClick="btnResetPassword_Click" />
            </div>
        </center>
    </form>
</body>
</html>
