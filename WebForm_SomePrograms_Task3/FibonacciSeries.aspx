<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FibonacciSeries.aspx.cs" Inherits="WebForm_SomePrograms_Task3.FibonacciSeries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Fibonacci Series<br />
            <br />
            Enter the no. of elements you need in the Fibonacci Series:<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Display Series" 
                OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Fibonacci Series: " MaxLength="100"></asp:Label>
        </div>
    </form>
</body>
</html>
