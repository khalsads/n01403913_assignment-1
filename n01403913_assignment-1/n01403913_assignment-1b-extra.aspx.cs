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
                    int Booking_User_Age_Group = Convert.ToInt32(booking_user_age_group.SelectedValue);
                    int Booking_User_Select_Location = Convert.ToInt32(booking_user_select_location.SelectedValue);

                    if (Booking_User_Age_Group == 1) {
                        if (Booking_User_Select_Location == 1) {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $100";
                        }
                        else if (Booking_User_Select_Location == 2)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $200";
                        }
                        else if (Booking_User_Select_Location == 3) {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $300";
                        }

                    }
                    if (Booking_User_Age_Group == 2)
                    {
                        if (Booking_User_Select_Location == 1)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $200";
                        }
                        else if (Booking_User_Select_Location == 2)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $400";
                        }
                        else if (Booking_User_Select_Location == 3)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $600";
                        }

                    }
                    if (Booking_User_Age_Group == 3)
                    {
                        if (Booking_User_Select_Location == 1)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $150";
                        }
                        else if (Booking_User_Select_Location == 2)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $300";
                        }
                        else if (Booking_User_Select_Location == 3)
                        {
                            booking_summary.InnerHtml = "Price for your Seleted Location as per your age group is $450";
                        }

                    }

                }
            }

        }
    }
}