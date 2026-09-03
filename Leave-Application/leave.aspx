<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Leave.aspx.cs"
    Inherits="LeaveManagement.Leave"
    UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Leave Management</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Leave Management</h2>

    Name:

    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator
        ID="vName"
        runat="server"
        ControlToValidate="txtName"
        ErrorMessage="Enter Name"
        ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />


    Enrollment No.:

    <asp:TextBox ID="txtEnrollment" runat="server"></asp:TextBox>

    <asp:RequiredFieldValidator
        ID="vEnrollment"
        runat="server"
        ControlToValidate="txtEnrollment"
        ErrorMessage="Enter Enrollment No."
        ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />


    Leave Type:

    <asp:DropDownList ID="ddlLeave" runat="server">

        <asp:ListItem Text="Select Leave" Value=""></asp:ListItem>
        <asp:ListItem>Medical Leave</asp:ListItem>
        <asp:ListItem>Casual Leave</asp:ListItem>
        <asp:ListItem>Personal Leave</asp:ListItem>

    </asp:DropDownList>

    <asp:RequiredFieldValidator
        ID="vLeave"
        runat="server"
        ControlToValidate="ddlLeave"
        InitialValue=""
        ErrorMessage="Select Leave"
        ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />


    Leave Date:

    <asp:Label ID="lblDate" runat="server"></asp:Label>

    <br /><br />


    Reason:

    <asp:TextBox ID="txtReason"
        runat="server"
        TextMode="MultiLine">
    </asp:TextBox>

    <asp:RequiredFieldValidator
        ID="vReason"
        runat="server"
        ControlToValidate="txtReason"
        ErrorMessage="Enter Reason"
        ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />

    <asp:Button ID="btnSubmit"
        runat="server"
        Text="Submit"
        OnClick="btnSubmit_Click" />

    <br /><br />

    <asp:Label ID="lblMessage"
        runat="server"
        ForeColor="Green">
    </asp:Label>

    <br /><br />


    <asp:Panel ID="pnlDetails"
        runat="server"
        Visible="false">

        <h3>Leave Details</h3>

        Name:
        <asp:Label ID="lblName" runat="server"></asp:Label>

        <br /><br />

        Enrollment No.:
        <asp:Label ID="lblEnrollment" runat="server"></asp:Label>

        <br /><br />

        Leave Type:
        <asp:Label ID="lblLeave" runat="server"></asp:Label>

        <br /><br />

        Leave Date:
        <asp:Label ID="lblLeaveDate" runat="server"></asp:Label>

        <br /><br />

        Reason:
        <asp:Label ID="lblLeaveReason" runat="server"></asp:Label>

    </asp:Panel>

</form>

</body>
</html>