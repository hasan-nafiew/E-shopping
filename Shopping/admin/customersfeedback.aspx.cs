using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using e_ShoppingBuisnessLayer;
using e_Shopping.EntityLayer;
namespace Shopping.admin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        
            FeedbackBLL objlogic;
            protected void Page_Load(object sender, EventArgs e)
            {
                objlogic = new FeedbackBLL();
                GridView1.DataSource = objlogic.LoadFeedback();
                GridView1.DataBind();
            }
        
    }
}