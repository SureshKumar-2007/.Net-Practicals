
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PlacementReport
{
    public partial class Companys : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPlacements();
            }
        }

        private void LoadPlacements()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["PlacementDBConnectionString"]
                .ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                // Company placement details
                string query = @"
                    SELECT
                        Company,
                        Package,
                        StudentID,
                        StudentName,
                        Department
                    FROM Students
                    WHERE Status = 'Placed'
                    ORDER BY Company";

                using (SqlDataAdapter da =
                    new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                string summaryQuery = @"
                    SELECT
                        Company,
                        Package,
                        COUNT(StudentID) AS TotalStudents
                    FROM Students
                    WHERE Status = 'Placed'
                    GROUP BY Company, Package
                    ORDER BY Company";

                using (SqlDataAdapter da2 =
                    new SqlDataAdapter(summaryQuery, con))
                {
                    DataTable dt2 = new DataTable();
                    da2.Fill(dt2);

                    GridView2.DataSource = dt2;
                    GridView2.DataBind();
                }
            }
        }
    }
}
