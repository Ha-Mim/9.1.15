<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorUI.aspx.cs" Inherits="CalculatorApp.CalculatorUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        &nbsp;<asp:Label ID="Label1" runat="server" Text="First Number "></asp:Label>
        <asp:TextBox ID="firstNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Second Number"></asp:Label>
            <asp:TextBox ID="secondNumberTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>&nbsp;
            <asp:TextBox ID="resultTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add" />
            <asp:Button ID="substractButton" runat="server" OnClick="substractButton_Click" Text="Substract" />
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="Multiply" />
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="Divide" />
        </p>
    </form>
</body>
</html>
