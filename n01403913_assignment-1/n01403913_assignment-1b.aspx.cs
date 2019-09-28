using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace n01403913_assignment_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) {
                Page.Validate();
                if (Page.IsValid) {
                    booking_summary.InnerHtml = "";
                    int Booking_User_Age_Group = Convert.ToInt32(booking_user_age_group);
                    int Booking_User_Select_Location = Convert.ToInt32(booking_user_select_location);

                    if (Booking_User_Age_Group = 1) {

                    }
                }
            }

        }
    }
}