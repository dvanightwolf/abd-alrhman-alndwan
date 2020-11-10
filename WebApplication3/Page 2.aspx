<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page 2.aspx.cs" Inherits="WebApplication3.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 209px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="off"></asp:Label>
            <asp:CheckBox ID="CheckBox1" runat="server" Enabled="False" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="change" />
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" Enabled="False" PostBackUrl="~/Page 1.aspx" Text="Preview page"  />
    </form>
</body>
</html>
