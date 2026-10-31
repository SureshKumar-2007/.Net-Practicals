
<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs"
    Inherits="PlacementReport.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Student Details</title>

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
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <h2>Student Details</h2>

        <asp:GridView ID="GridView1" runat="server"
            CssClass="grid"
            AutoGenerateColumns="False"
            EmptyDataText="No student records found."
            GridLines="None">

            <Columns>
                <asp:BoundField DataField="StudentID"
                    HeaderText="Student ID" />

                <asp:BoundField DataField="StudentName"
                    HeaderText="Student Name" />

                <asp:BoundField DataField="Department"
                    HeaderText="Department" />

                <asp:BoundField DataField="Company"
                    HeaderText="Company" />

                <asp:BoundField DataField="Package"
                    HeaderText="Package (LPA)"
                    DataFormatString="{0:N2}" />

                <asp:BoundField DataField="Status"
                    HeaderText="Is Placed" />
            </Columns>

        </asp:GridView>

        <a href="Companys.aspx" class="link">
            View Company Details
        </a>

    </form>
</body>
</html>
