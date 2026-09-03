using System;

namespace LeaveManagement
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "student" &&
                txtPassword.Text == "1234")
            {
                Session["Username"] = txtUsername.Text;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid Login";
            }
        }
    }
}