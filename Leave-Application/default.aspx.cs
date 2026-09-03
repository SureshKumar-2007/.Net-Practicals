using System;

namespace LeaveManagement
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            lblDate.Text = Calendar1.SelectedDate.ToShortDateString();

            Session["LeaveDate"] = Calendar1.SelectedDate;
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Response.Redirect("Leave.aspx");
        }
    }
}