<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PendingRetrievalItems.aspx.cs" Inherits="WebForm_V1.View.PendingRetrievalItems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="/Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <script src="/Scripts/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="/Scripts/bootstrap.js" type="text/javascript"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1014px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="nav-justified">
                <tr>
                    <td class="auto-style2">
                        <ul class="nav nav-tabs">
                            <li class="active"><a href="PendingRetrievalItems.aspx">Process Retrieval Items</a></li>
                            <li><a href="ConfirmCollectedItems.aspx">Confirm Collected Items</a></li>
                        </ul>
                    </td>
                </tr>

                <tr>
                    <td>
                        <h1 class="text-center">Process Retrieval Items</h1>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="PendingRetrievalItemsView" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td>

                        <table>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style1">
                                    <asp:Button ID="Processbtn" runat="server" OnClick="Processbtn_Click" Text="Process" />
                                </td>
                            </tr>
                        </table>

                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
