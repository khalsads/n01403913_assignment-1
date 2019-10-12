using System;
using System.Web.UI;

namespace Assignment_bonus
{
    public partial class question_2 : System.Web.UI.Page
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
                    value_selected_result.InnerHtml = "";

                    //Variables
                    var Days_InOctober = DateTime.DaysInMonth(2019, 10);
                    //                    value_selected_result.InnerHtml += Days_InOctober;

                    //For Loop to Print every day of the month
                    for (int i = 1; i <= Days_InOctober; i++)
                    {
                        DateTime dt = new DateTime(2019, 10, i);
                        //                        string dayt = dt.DayOfWeek.ToString();
                        //                        value_selected_result.InnerHtml += dayt+"<br>";
                        int dtt = Convert.ToInt32(dt.DayOfWeek);

                        //Condition check for SUNDAY
                        if (dtt == 0 && selected_DaySunday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "<br>Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 0 && selected_DaySunday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "<br>Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        //Condition check for MONDAY
                        if (dtt == 1 && selected_DayMonday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 1 && selected_DayMonday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        //Condition check for TUESDAY
                        if (dtt == 2 && selected_DayTuesday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 2 && selected_DayTuesday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        //Condition check for WEDNESSDAY
                        if (dtt == 3 && selected_DayWednessday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 3 && selected_DayWednessday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        //Condition check for THURSDAY
                        if (dtt == 4 && selected_DayThursday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 4 && selected_DayThursday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        //Condition check for FRIDAY
                        if (dtt == 5 && selected_DayFriday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 5 && selected_DayFriday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        //Condition check for SATURDAY
                        if (dtt == 6 && selected_DaySaturday.Checked == true)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to work...<br>";
                        }
                        else if (dtt == 6 && selected_DaySaturday.Checked == false)
                        {
                            value_selected_result.InnerHtml += "Oct " + dt.Day.ToString() + " is a " + dt.DayOfWeek + "! Time to have fun!...<br>";
                        }

                        // dt.Month.ToString();
                        //                        value_selected_result.InnerHtml += "<br>" + dt.DayOfWeek + " int value " + dtt.ToString();
                    }




                    //Clearing previous stored in MsgOut variable.
                    //string MsgOut = "";

                    //Verifying which check box is Selected
                    //if (selected_DaySunday.Checked == true)
                    //{
                    //    MsgOut = "SUNDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}
                    //if (selected_DayMonday.Checked == true)
                    //{
                    //    MsgOut = "MONDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}
                    //if (selected_DayTuesday.Checked == true)
                    //{
                    //    MsgOut = "TUESDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}
                    //if (selected_DayWednessday.Checked == true)
                    //{
                    //    MsgOut = "WEDNESSDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}
                    //if (selected_DayThursday.Checked == true)
                    //{
                    //    MsgOut = "THURSDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}
                    //if (selected_DayFriday.Checked == true)
                    //{
                    //    MsgOut = "FRIDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}
                    //if (selected_DaySaturday.Checked == true)
                    //{
                    //    MsgOut = "SATURDAY is Selected<br>";
                    //    value_selected_result.InnerHtml += MsgOut.ToString();
                    //}

                }
            }
        }
    }
}