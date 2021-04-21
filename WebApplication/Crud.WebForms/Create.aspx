<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Crud.WebForms.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 98px;
        }
        .auto-style2 {
            width: 98px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 760px;
        }
        .auto-style4 {
            width: 5px;
            height: 23px;
        }
        .auto-style5 {
            width: 5px;
        }
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            width: 760px;
        }
    </style>
</head>
<body style="width: 257px">
    <form id="form1" runat="server">
        <table class="auto-style6">
            <tr>
                <td class="auto-style2">ID</td>
                <td class="auto-style4">:</td>
                <td class="auto-style3">
                    <input id="Text1" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Username</td>
                <td class="auto-style5">:</td>
                <td class="auto-style7">
                    <input id="Text2" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Password</td>
                <td class="auto-style5">:</td>
                <td class="auto-style7">
                    <input id="Text3" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Firstname</td>
                <td class="auto-style5">:</td>
                <td class="auto-style7">
                    <input id="Text4" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Surname</td>
                <td class="auto-style5">:</td>
                <td class="auto-style7">
                    <input id="Text5" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Contact</td>
                <td class="auto-style5">:</td>
                <td class="auto-style7">
                    <input id="Text6" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style1">Email</td>
                <td class="auto-style5">:</td>
                <td class="auto-style7">
                    <input id="Text7" type="text" /></td>
            </tr>
        </table>
        <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create" />
    </form>
</body>
</html>
