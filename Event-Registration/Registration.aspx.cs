using System;

namespace EventRegistration
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblName.Text = txtName.Text;
                lblEnrollment.Text = txtEnrollment.Text;
                lblGR.Text = txtGR.Text;
                lblGender.Text = rblGender.SelectedValue;
                lblEvent.Text = ddlEvent.SelectedValue;
                lblEmail.Text = txtEmail.Text;

                pnlDetails.Visible = true;
            }
        }
    }
}