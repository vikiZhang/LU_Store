<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllRequisitions.aspx.cs" Inherits="WebForm_V1.View.AllRequisitions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link href="/Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <script src="/Scripts/jquery-1.8.2.js" type="text/javascript"></script>
    <script src="/Scripts/bootstrap.js" type="text/javascript"></script>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 485px;
        }
        .auto-style3 {
            width: 135px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">
                                    <ul class="nav nav-tabs">
                                        <li class="active"><a href="AllRequisitions.aspx">All Requisitions</a></li>
                                        <li><a href="Out-StandingRequisitions.aspx">Out-Standing Requisitions</a></li>
                                    </ul>

                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="requisitionDate" runat="server" ></asp:TextBox>
                                    </td>
                                <td>
                                    <asp:ImageButton ID="Canlendarbtn" runat="server" ImageUrl="~/Images/calendar.png" OnClick="ImageButton1_Click" Height="16px" Width="24px" />
                                 </td>
                                   <td>
                                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="allrequisitionsview" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
