<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PalindromeStringCheck.aspx.cs" Inherits="WebForm_SomePrograms_Task3.PalindromeStringCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Palindrome String Check:<br />
            <br />
            Enter a string:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" style="margin-right: 7px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server"  Text="Palindrome String Check" 
                OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Result : "></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
