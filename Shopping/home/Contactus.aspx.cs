using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_Shopping.EntityLayer;
using e_ShoppingBuisnessLayer;

namespace Shopping
{
    public partial class Contact_Us : System.Web.UI.Page
    {
        FeedbackBLL objLogic = new FeedbackBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Control C = this.Master.FindControl("sidebar");
            C.Visible = false;
        }

        protected void Save(object sender, EventArgs e)
        {
            int result = 0;
            FeedbackEntity _feedback = new FeedbackEntity();
            _feedback.FeedBackName = txtName.Text;
            _feedback.FeedBackEmail = txtEmail.Text;
            _feedback.FeedBack = txtFeedback.Text;
            result = objLogic.AddFeedback(_feedback);

            //Display success message.
            string message = "Thank you for your valuable Feedback.";
            string script = "window.onload = function(){ alert('";
            script += message;
            script += "')};";
            ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
        }
    }
}