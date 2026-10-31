
<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Companys.aspx.cs"
    Inherits="PlacementReport.Companys" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Company Placement Details</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            background: #f4f6f9;
            padding: 30px;
        }

        h2 {
            color: #1e3a8a;
        }

        .grid {
            width: 100%;
            border-collapse: collapse;
            background: white;
        }

        .grid th {
            background: #1e3a8a;
            color: white;
            padding: 12px;
            text-align: left;
        }

        .grid td {
            padding: 10px;
            border: 1px solid #ddd;
        }

        .link {
            display: inline-block;
            margin-top: 20px;
            color: #1e40af;
            font-weight: bold;
        }

        hr {
            margin: 30px 0;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Company Placement Details</h2>

        <asp:GridView ID="GridView1" runat="server"
            CssClass="grid"
            AutoGenerateColumns="False"
            EmptyDataText="No placement records found."
            GridLines="None">

            <Columns>
                <asp:BoundField DataField="Company"
                    HeaderText="Company Name" />

                <asp:BoundField DataField="Package"
                    HeaderText="Package Offer (LPA)"
                    DataFormatString="{0:N2}" />

                <asp:BoundField DataField="StudentID"
                    HeaderText="Student ID" />

                <asp:BoundField DataField="StudentName"
                    HeaderText="Student Name" />

                <asp:BoundField DataField="Department"
                    HeaderText="Department" />
            </Columns>

        </asp:GridView>

        <hr />

        <h2>Company Details Summary</h2>

        <asp:GridView ID="GridView2" runat="server"
            CssClass="grid"
            AutoGenerateColumns="False"
            EmptyDataText="No company summary available."
            GridLines="None">

            <Columns>
                <asp:BoundField DataField="Company"
                    HeaderText="Company Name" />

                <asp:BoundField DataField="Package"
                    HeaderText="Package Offer (LPA)"
                    DataFormatString="{0:N2}" />

                <asp:BoundField DataField="TotalStudents"
                    HeaderText="Total Students Selected" />
            </Columns>

        </asp:GridView>

        <a href="Default.aspx" class="link">
            Back to Student Details
        </a>

    </form>
</body>
</html>
