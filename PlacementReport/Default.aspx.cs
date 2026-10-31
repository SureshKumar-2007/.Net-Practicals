
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PlacementReport
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }

        private void LoadStudents()
        {
            string cs = ConfigurationManager
                .ConnectionStrings["PlacementDBConnectionString"]
                .ConnectionString;

            string query = @"
                SELECT StudentID,
                       StudentName,
                       Department,
                       Company,
                       Package,
                       Status
                FROM Students
                ORDER BY StudentID";

            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlDataAdapter da =
                    new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
        }
    }
}
