<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editDepartmentActualQty.aspx.cs" Inherits="WebForm_V1.View.editDepartmentActualQty" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="disbursementListView" runat="server">
        </asp:GridView>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
    
    </div>
    </form>
</body>
</html>
