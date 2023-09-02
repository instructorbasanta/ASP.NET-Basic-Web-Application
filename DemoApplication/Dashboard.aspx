<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="DemoApplication.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dashboard Page</title>
</head>
<body>
    <h1>Dashboard</h1>
    <form id="form1" runat="server">
        <div>
            <span id="welcome" runat="server">Welcome Admin</span>
            <br />
            <asp:Button Text="Logout" runat="server" ID="btnLogout" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
