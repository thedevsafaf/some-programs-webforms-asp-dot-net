<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimeNoCheck.aspx.cs" Inherits="WebForm_SomePrograms_Task3.PrimeNoCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Prime No: Check:<br />
        <br />
        Enter a number:<br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check if Prime No or Not" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
        <br />
    </form>
</body>
</html>
