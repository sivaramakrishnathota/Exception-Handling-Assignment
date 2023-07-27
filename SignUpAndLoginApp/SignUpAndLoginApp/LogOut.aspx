<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="SignUpAndLoginApp.LogOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <center><div>
            <h1>Login successful!</h1>
            <asp:Button ID="btnLogOut" runat="server" Text="Logout" OnClick="btnLogOut_Click" />
        </div></center>
    </form>
</body>
</html>
