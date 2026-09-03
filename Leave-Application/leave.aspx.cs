using System;

namespace LeaveManagement
{
    public partial class Leave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LeaveDate"] != null)
                {
                    DateTime date = (DateTime)Session["LeaveDate"];
                    lblDate.Text = date.ToShortDateString();
                }

                if (Request.Cookies["StudentName"] != null)
                {
                    txtName.Text = Request.Cookies["StudentName"].Value;
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Session["Name"] = txtName.Text;
                Session["Enrollment"] = txtEnrollment.Text;
                Session["LeaveType"] = ddlLeave.SelectedValue;
                Session["Reason"] = txtReason.Text;

                Response.Cookies["StudentName"].Value = txtName.Text;

                lblName.Text = txtName.Text;
                lblEnrollment.Text = txtEnrollment.Text;
                lblLeave.Text = ddlLeave.SelectedValue;
                lblLeaveDate.Text = lblDate.Text;
                lblLeaveReason.Text = txtReason.Text;

                pnlDetails.Visible = true;

                lblMessage.Text = "Leave Applied Successfully";
            }
        }
    }
}