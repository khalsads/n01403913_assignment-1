using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_bonus
{
    public partial class question_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Verifying that page is loaded after the submit button is clicked (i.e Uses provided the input and is validated by the client side validator.)
            if (Page.IsPostBack)
            {

                // Validating the page @ server side
                Page.Validate();

                // If page is validated on both client & server side then proceed
                if (Page.IsValid)
                {

                    //Clearing if there is any value stored in "value_selected_result"
                    ticket_ordered_result.InnerHtml = "";

                    //Storing values submitted by form to server side integers.
                    int Ticket_Ordered = Convert.ToInt32(ticket_ordered.Text);

                    //Clearing previous stored in MsgOut variable.
                    string MsgOut = "";

                    //Display value as per user selection
                    MsgOut = "You Selected ";
                    ticket_ordered_result.InnerHtml += "<br>"+MsgOut + Ticket_Ordered.ToString()+"<br>";

                    if (Ticket_Ordered <= 50)
                    {
                        ticket_ordered_result.InnerHtml += "<br> your selected value is less than or equal to 50 <br>";
                    }
                    else if ((Ticket_Ordered > 50) && (Ticket_Ordered <= 150))
                    {

                        ticket_ordered_result.InnerHtml += "<br> your selected value is higher than 50 and less than 150 <br>";
                    }
                    else if ((Ticket_Ordered > 150) && (Ticket_Ordered <= 300))
                    {

                        ticket_ordered_result.InnerHtml += "<br> your selected value is higher than 150 and less than 300 <br>";
                    }
                    else if (Ticket_Ordered > 300) {
                        ticket_ordered_result.InnerHtml += "<br> your selected value is higher than 300<br>";

                    }
                }
            }
        }
    }
}