<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Out-StandingRequisitions.aspx.cs" Inherits="WebForm_V1.View.Out_StandingRequisitions" %>

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
             <table class="auto-style1">
                <tr>
                    <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">
                                    <ul class="nav nav-tabs">
                                        <li><a href="AllRequisitions.aspx">All Requisitions</a></li>
                                        <li class="active"><a href="Out-StandingRequisitions.aspx">Out-Standing Requisitions</a></li>
                                    </ul>

                                </td>                            
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:GridView ID="outstandingrequisitionsview" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
