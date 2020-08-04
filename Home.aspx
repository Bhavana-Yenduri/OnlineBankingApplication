<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineBankingSystem.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 166px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td colspan="2"><h1><center>Online Banking System</center></h1></td>
                </tr>
                <tr>
                    <td class="auto-style2">Account Balance</td>
                    <td>&nbsp;<asp:TextBox ID="txt_balance"  runat="server" ReadOnly="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Button ID="btn_fundtransfer" runat="server" Text="Fund Transfer" OnClick="btn_fundtransfer_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2"> <h3>Transaction History</h3></td>
                </tr>
                <tr>
                    <td colspan="2"> &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2"><asp:GridView ID="grdView" runat="server"></asp:GridView></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
