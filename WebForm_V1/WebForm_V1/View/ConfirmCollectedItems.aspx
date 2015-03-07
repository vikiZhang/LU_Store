<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmCollectedItems.aspx.cs" Inherits="WebForm_V1.View.ConfirmCollectedItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <script src="/Scripts/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="/Scripts/bootstrap.js" type="text/javascript"></script>
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
        <div>

            <table class="nav-justified">
                <tr>
                    <td class="auto-style2">
                        <ul class="nav nav-tabs">
                            <li><a href="PendingRetrievalItems.aspx">Process Retrieval Items</a></li>
                            <li class="active"><a href="ConfirmCollectedItems.aspx">Confirm Collected Items</a></li>
                        </ul>
                    </td>
                    <td>
                        <asp:Button ID="printbtn" runat="server" Text="Print All" OnClick="printbtn_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h1 class="text-center">Retrieval Items</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="ProcessedDate" runat="server" ></asp:TextBox>
                        <asp:ImageButton ID="Canlendarbtn1" runat="server" ImageUrl="~/Images/calendar.png" OnClick="ImageButton1_Click" Height="19px" />
                        <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="ConfirmItemsView" runat="server" OnSelectedIndexChanged="ConfirmItemsView_SelectedIndexChanged">
                            <Columns>
                                <asp:HyperLinkField NavigateUrl="~/View/editDepartmentActualQty.aspx" Text="edit" />
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Confirmbtn" runat="server" Text="Confirm Collected From Store" OnClick="Confirmbtn_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
