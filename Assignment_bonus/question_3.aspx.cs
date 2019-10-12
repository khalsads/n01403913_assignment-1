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

                    //All Variable used declared
                    int Reminder;
                    int Loop;
                    Double Cost=0.25;
                    Double Total_Cost= Ticket_Ordered * Cost;

                    //Clearing previous stored in MsgOut variable.
                    string MsgOut = "";

                    //Display value as per user selection
                    MsgOut = "<br>You received a bundle of ";

                    //                    ticket_ordered_result.InnerHtml += MsgOut + Ticket_Ordered.ToString()+"<br>";

                    if (Ticket_Ordered <= 50)
                    {
                        for (var i=1; i<=Ticket_Ordered; i++) {
                            ticket_ordered_result.InnerHtml += MsgOut + "1! That's " +i.ToString()+ " ticket(s)!";
                        }
                        ticket_ordered_result.InnerHtml += "<br><br>Your total ticket(s) is "+Ticket_Ordered.ToString()+" and your cost is $"+Total_Cost.ToString()+"cad.";
                    }
                    else if ((Ticket_Ordered > 50) && (Ticket_Ordered <= 150))
                    {
                        Reminder = Ticket_Ordered % 2;
                        Loop = (Ticket_Ordered - Reminder) / 2;
                        for (var i = 1; i <= Loop; i++)
                        {
                            ticket_ordered_result.InnerHtml += MsgOut + "2! That's " +(i*2).ToString()+ " ticket(s)!";
                        }
                        if (Reminder > 0)
                        {
                            ticket_ordered_result.InnerHtml += "<br>Your leftover is "+Reminder.ToString()+" ticket(s). That's " + Ticket_Ordered.ToString() + " ticket(s)!";
                        }
                        ticket_ordered_result.InnerHtml += "<br><br>Your total ticket(s) is " + Ticket_Ordered.ToString() + " and your cost is $" + Total_Cost.ToString() + "cad!";
                    }
                    else if ((Ticket_Ordered > 150) && (Ticket_Ordered <= 300))
                    {
                        Reminder = Ticket_Ordered % 3;
                        Loop = (Ticket_Ordered - Reminder) / 3;
                        for (var i = 1; i <= Loop; i++)
                        {
                            ticket_ordered_result.InnerHtml += MsgOut + "3! That's " +(i*3).ToString()+ " ticket(s)!";
                        }
                        if (Reminder > 0) {
                            ticket_ordered_result.InnerHtml += "<br>Your leftover is "+Reminder.ToString()+" ticket(s). That's " + Ticket_Ordered.ToString()+ " ticket(s)!";
                        }
                        ticket_ordered_result.InnerHtml += "<br><br>Your total ticket(s) is " + Ticket_Ordered.ToString() + " and your cost is $" + Total_Cost.ToString() + "cad!";
                    }
                    else if (Ticket_Ordered > 300) {
                        Reminder = Ticket_Ordered % 5;
                        Loop = (Ticket_Ordered - Reminder) / 5;
                        for (var i = 1; i <= Loop; i++)
                        {
                            ticket_ordered_result.InnerHtml += MsgOut + "5! That's " +(i*5).ToString()+ " ticket(s)!";
                        }
                        if (Reminder > 0) {
                            ticket_ordered_result.InnerHtml += "<br>Your leftover is "+Reminder.ToString()+" ticket(s). That's "+Ticket_Ordered.ToString()+" ticket(s)!";
                        }
                        ticket_ordered_result.InnerHtml += "<br><br>Your total ticket(s) is "+Ticket_Ordered.ToString()+" and your cost is $"+Total_Cost.ToString()+"cad!";
                    }
                }
            }
        }
    }
}