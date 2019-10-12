using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_bonus
{
    public partial class question_1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
//Verifying that page is loaded after the submit button is clicked (i.e Uses provided the input and is validated by the client side validator.)
            if (Page.IsPostBack) {

// Validating the page @ server side
                Page.Validate();

// If page is validated on both client & server side then proceed
                if (Page.IsValid) {
                    
                    //Clearing if there is any value stored in "value_selected_result"
                    value_selected_result.InnerHtml = "";
                    
                    //Storing values submitted by form to server side integers.
                    int Value_X_Axis = Convert.ToInt32(value_x_axis.Text);
                    int Value_Y_Axis = Convert.ToInt32(value_y_axis.Text);
                    int Total = Value_X_Axis * Value_Y_Axis;
                    
                    //Clearing previous stored in MsgOut variable.
                    string MsgOut = "";

                    //Check if value of X or Y Axis is submitted 0 if yes the Message will be displayed
                    if (Value_X_Axis == 0 || Value_Y_Axis == 0)
                    {
                        MsgOut = "One of the value is 0, Please enter value higher or lower than 0";
                        value_selected_result.InnerHtml = MsgOut.ToString() + "<br>";
                    }

                    // If not then proceed with further code
                    else
                    {
                        //Condition check the value entered for X Axis is positive
                        if (Value_X_Axis > 0)
                        {
                            //Condition check the value entered for Y Axix is positive
                            if (Value_Y_Axis > 0)
                            {
                                MsgOut = "Entered Value of ( X, Y) = (" + Value_X_Axis + " , " + Value_Y_Axis + ") lies in Quadrant I" + "<br>";
                                value_selected_result.InnerHtml += MsgOut.ToString();
                            }
                            //Condition check the value entered for Y Axix is negative
                            else if (Value_Y_Axis < 0) {
                                MsgOut = "Entered Value of ( X, Y) = (" + Value_X_Axis + " , " + Value_Y_Axis + ") lies in Quadrant IV" + "<br>";
                                value_selected_result.InnerHtml += MsgOut.ToString();
                            }
                        }

                        //Condition check the value entered for X Axix is negative
                        else if (Value_X_Axis < 0)
                        {
                            //Condition check the value entered for Y Axix is positive
                            if (Value_Y_Axis > 0)
                            {
                                MsgOut = "Entered Value of ( X, Y) = (" + Value_X_Axis + " , " + Value_Y_Axis + ") lies in Quadrant II" + "<br>";
                                value_selected_result.InnerHtml += MsgOut.ToString();
                            }
                            //Condition check the value entered for Y Axix is negative
                            else if (Value_Y_Axis < 0)
                            {
                                MsgOut = "Entered Value of ( X, Y) = (" + Value_X_Axis + " , " + Value_Y_Axis + ") lies in Quadrant III" + "<br>";
                                value_selected_result.InnerHtml += MsgOut.ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}