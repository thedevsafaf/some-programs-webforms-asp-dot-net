﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ArmstrongNoCheck.aspx.cs" Inherits="WebForm_SomePrograms_Task3.ArmstrongNoCheck" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Armstrong No: Check<br />
            <br />
            Enter a num:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" 
                Text="Check Armstrong Num or Not" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Result: "></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
