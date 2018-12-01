using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_ShoppingDataLayer;
using e_Shopping.EntityLayer;

namespace e_ShoppingBuisnessLayer
{
    public class FeedbackBLL
    {
        public FeedbackDLL objDatalayer = new FeedbackDLL();
       


        public int AddFeedback(FeedbackEntity _feedback)
        {

            return objDatalayer.AddFeedBack(_feedback.FeedBackName, _feedback.FeedBackEmail, _feedback.FeedBack);

        }
        public object LoadFeedback()
        {
            return objDatalayer.LoadFeedbackDB();
        }
    }
}
