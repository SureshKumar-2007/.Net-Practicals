<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="EventRegistration.Registration" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Event Registration</title>
</head>

<body>

<form id="form1" runat="server">

    <h2>Online Event Registration</h2>

    Full Name:
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vName" runat="server" ControlToValidate="txtName" ErrorMessage="Enter Name" ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />
    Enrollment No.:
    <asp:TextBox ID="txtEnrollment" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vEnrollment" runat="server" ControlToValidate="txtEnrollment" ErrorMessage="Enter Enrollment No." ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />
    GR No.:
    <asp:TextBox ID="txtGR" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vGR" runat="server" ControlToValidate="txtGR"
        ErrorMessage="Enter GR No."
        ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />


    Gender:

    <asp:RadioButtonList ID="rblGender" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        <asp:ListItem>Other</asp:ListItem>
    </asp:RadioButtonList>

    <asp:RequiredFieldValidator ID="vGender" runat="server" ControlToValidate="rblGender" ErrorMessage="Select Gender"
        ForeColor="Red">*</asp:RequiredFieldValidator>

    <br />


    Event Name:

    <asp:DropDownList ID="ddlEvent" runat="server">

        <asp:ListItem Text="Select Event" Value=""></asp:ListItem>
        <asp:ListItem>Technical Fest</asp:ListItem>
        <asp:ListItem>Cultural Fest</asp:ListItem>
        <asp:ListItem>Sports Event</asp:ListItem>

    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="vEvent" runat="server" ControlToValidate="ddlEvent" InitialValue="" ErrorMessage="Select Event" ForeColor="Red">*</asp:RequiredFieldValidator>

    <br /><br />

    Email:
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="vEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Enter Email" ForeColor="Red">*</asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator ID="vEmailFormat" runat="server" ControlToValidate="txtEmail" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
        ErrorMessage="Invalid Email"
        ForeColor="Red">*</asp:RegularExpressionValidator>

    <br /><br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />

    <br />

    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />

    <br /><br />


    <!-- Details -->

    <asp:Panel ID="pnlDetails" runat="server" Visible="false">

        <h3>Registration Details</h3>

        Full Name:
        <asp:Label ID="lblName" runat="server"></asp:Label>

        <br /><br />

        Enrollment No.:
        <asp:Label ID="lblEnrollment" runat="server"></asp:Label>

        <br /><br />

        GR No.:
        <asp:Label ID="lblGR" runat="server"></asp:Label>

        <br /><br />

        Gender:
        <asp:Label ID="lblGender" runat="server"></asp:Label>

        <br /><br />

        Event Name:
        <asp:Label ID="lblEvent" runat="server"></asp:Label>

        <br /><br />

        Email:
        <asp:Label ID="lblEmail" runat="server"></asp:Label>

        <br /><br />

        <b>Registration Successful!</b>

    </asp:Panel>

</form>

</body>
</html>