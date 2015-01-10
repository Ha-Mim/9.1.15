<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EntryUI.aspx.cs" Inherits="EntryInfo.UI.EntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div>
    <table>
       <tr>
           <td>
               <asp:Label ID="IdLavel" runat="server" Hidden="IdLabel"></asp:Label>
           </td>
       </tr>  
         <tr>
           <td>
               <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
               </td>
               <td>
               <asp:DropDownList ID="departmentDropDownList" runat="server">
               </asp:DropDownList>
           </td>
       </tr>  
        <tr>
            <td>
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                </td>
            <td>
        <asp:TextBox ID="firstNameTextBox" runat="server"></asp:TextBox>
                </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
            </td>
        <td>
        <asp:TextBox ID="addressTextBox" runat="server"></asp:TextBox>
            </td>
            </tr>
        
         <tr>
        <td>
        <asp:Label ID="Label3" runat="server" Text="Phone"></asp:Label>
            </td>
             <td>
        <asp:TextBox ID="phoneTextBox" runat="server"></asp:TextBox>
                 </td>
             </tr>
        
          <tr>
        <td>
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
            </td>
              <td>
        <asp:Button ID="updateButton" runat="server" OnClick="updateButton_Click" Text="Update" />
                  </td>
              </tr>

    </table>
    </div>
       <asp:Label ID="msgLabel" runat="server" Hidden="Label"></asp:Label>
    </form>
</body>
</html>
