<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DemoApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="CSS/Style.css" rel="stylesheet" />
</head>
<body>
    <h1>Login Page</h1>
    <form id="form1" runat="server">
        <div>
            <span id="error_message" runat="server"></span>
            <div class="control">
                <asp:Label Text="Username *" ID="lblUsername" runat="server" />
                <asp:TextBox ID="txtUsername" placeholder="Enter username..." runat="server" />
                <span runat="server" id="errUsername"></span>
            </div>
            <div class="control">
                <asp:Label Text="Password *" ID="lblPassword" runat="server" />
                <asp:TextBox TextMode="Password" ID="txtPassword" placeholder="Enter password..." runat="server" />
                <span runat="server" id="errPassword"></span>                
            </div>
            <div class="control">
                <asp:CheckBox ID="chkRemember" runat="server" Text="Remember Me" />
            </div>
            <div class="control">
                <asp:Button Text="Login" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
