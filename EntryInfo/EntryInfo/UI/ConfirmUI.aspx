<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmUI.aspx.cs" Inherits="EntryInfo.UI.ConfirmUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <table>
        <tr>
            <td>
        <asp:Label ID="Label1" runat="server" Text="Department"></asp:Label>
                </td>
            <td>
        <asp:DropDownList ID="departmentDropDownList" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
        <tr>
            <td>
        <asp:Label ID="Label2" runat="server" Text="StudentName"></asp:Label>
                </td>
            <td>
        <asp:DropDownList ID="studentDropDownList" runat="server">
        </asp:DropDownList>
                </td>
            </tr>
        <tr>
            <td>
            <asp:Button ID="confirmButton" runat="server" OnClick="confirmButton_Click" Text="Confirm" />
       </td>
                 </tr>
        </table>
    </form>
</body>
</html>
