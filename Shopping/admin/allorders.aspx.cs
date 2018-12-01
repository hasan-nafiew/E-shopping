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
    public partial class WebForm4 : System.Web.UI.Page
    {
        ProductsBuisnessLayer productsBuisnessLayerObj = new ProductsBuisnessLayer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGridview();
            }
            
        }

        protected void fillGridview()
        {
            List<BillInformation> billInfoList = productsBuisnessLayerObj.GetBillIfo();
            GridView1.DataSource = billInfoList;
            GridView1.DataBind();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            fillGridview();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            fillGridview();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label id = (Label)GridView1.Rows[e.RowIndex].FindControl("labelbillid");

            string bid = id.Text;

            TextBox deliveryStatus = (TextBox)GridView1.Rows[e.RowIndex].Cells[7].Controls[0];
            string s = deliveryStatus.Text;

            productsBuisnessLayerObj.billupdate(bid, s);

            GridView1.EditIndex = -1;
            fillGridview();

        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

            GridView1.PageIndex = e.NewPageIndex;
            fillGridview();
        }
    }
}