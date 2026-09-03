<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="LeaveManagement.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Academic Calendar</h2>

    <asp:Calendar ID="Calendar1"
        runat="server"
        OnSelectionChanged="Calendar1_SelectionChanged">
    </asp:Calendar>

    <br />

    Selected Date:

    <asp:Label ID="lblDate" runat="server"></asp:Label>

    <br /><br />

    <asp:Button ID="btnApply"
        runat="server"
        Text="Apply Leave"
        OnClick="btnApply_Click" />

</form>

</body>
</html>