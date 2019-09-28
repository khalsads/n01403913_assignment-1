<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="n01403913_assignment-1b-extra.aspx.cs" Inherits="n01403913_assignment_1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 1-B Web Form</title>
    <link rel="stylesheet" type="text/css" href="Content/Site.css" />
</head>
<body>
    <div class="page_container">
        <h1>BUS TOUR BOOKING</h1>
        <form id="form1" runat="server">
            <section>
                <h2>PERSONAL DETAILS</h2>
                <div>
                    <label for="booking_user_fname">FIRST NAME: </label>
                    <asp:TextBox runat="server" ID="booking_user_fname"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_fname"
                        ErrorMessage="**Please enter first name**">
                    </asp:RequiredFieldValidator>
                    <label for="booking_user_lname">LAST NAME: </label>
                    <asp:TextBox runat="server" ID="booking_user_lname"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_lname"
                        ErrorMessage="**Please enter last name**">
                    </asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="booking_user_age_group">SELECT AGE GROUP</label>
                    <asp:RadioButtonList runat="server" ID="booking_user_age_group">
                        <asp:ListItem Text="CHILDREN (Less Than 15 Years)" Value="1"></asp:ListItem>
                        <asp:ListItem Text="ADULT (15 to 60 Years)" Value="2"></asp:ListItem>
                        <asp:ListItem Text="SENIOR (More than 60 Years)" Value="3"></asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_age_group"
                        ErrorMessage="**Please select one age group**">
                    </asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="booking_user_gender">SELECT GENDER</label>
                    <asp:RadioButtonList runat="server" ID="booking_user_gender">
                        <asp:ListItem Text="MALE" Value="booking_user_gender_male"></asp:ListItem>
                        <asp:ListItem Text="FEMALE" Value="booking_user_gender_female"></asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_gender"
                        ErrorMessage="**Please select gender**">
                    </asp:RequiredFieldValidator>
                </div>
                <h2>CONTACT INFORMORMATION</h2>
                <div>
                    <label for="booking_user_email">EMAIL ID</label>
                    <asp:TextBox runat="server" ID="booking_user_email"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_email"
                        ErrorMessage="**Please enter email ID**">
                    </asp:RequiredFieldValidator>
                </div>
                <div>
                    <label for="booking_user_phone">PHONE #</label>
                    <asp:TextBox runat="server" ID="booking_user_phone"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_phone"
                        ErrorMessage="**Please enter phone number**">
                    </asp:RequiredFieldValidator>
                </div>
            </section>
            <section>
                <h2>BOOOKING DETAILS</h2>
                <div>
                    <label for="booking_user_select_location">CHOOSE LOCATION:</label>
                    <asp:DropDownList runat="server" ID="booking_user_select_location">
                        <asp:ListItem Text="--Location--" Value="5" Selected="True"></asp:ListItem>
                        <asp:ListItem Text="Monrteal" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Toronto" Value="2"></asp:ListItem>
                        <asp:ListItem Text="Niagra Falls" Value="3"></asp:ListItem>
                    </asp:DropDownList>
                    <%/* Compare Validator Used to compare the seleted value.
* Validator will check if the value submitted or selected is 5 which is assigned to "--Location--" then it will promt user to select location
* If any other value is submitted then no error msg will displayed.
*/ %>
                    <asp:CompareValidator
                        runat="server"
                        ErrorMessage="**Click the drop down menu to select value**"
                        ControlToValidate="booking_user_select_location"
                        ValueToCompare="5"
                        Operator="NotEqual">
                    </asp:CompareValidator>
                    <%/*                    
* <asp:RequiredFieldValidator
* runat="server"
* ControlToValidate="booking_user_select_location"
* ErrorMessage="Please choose location">
* </asp:RequiredFieldValidator>
*/%>
                </div>
                <div>
                    <label for="booking_user_select_date">ENTER DATE</label>
                    <asp:TextBox runat="server" ID="booking_user_select_date"></asp:TextBox>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_user_select_date"
                        ErrorMessage="**Please enter date**">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator
                        runat="server"
                        ControlToValidate="booking_user_select_date"
                        ErrorMessage="Enter a valid date in the format (mm/dd/yyyy)"
                        ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](10|20)\d\d$">
                    </asp:RegularExpressionValidator>
                    <%/* I found this regular expression validater posted by : Paulie Waulie
* Site:https ://stackoverflow.com/questions/3667199/date-validation-for-a-textbox
* I choosed to use this code as I tested for various values and it is working good,
* found that the original code was not allowing me to select  year older that 1900 so checked the expression and made changes,
* so now I can select as old as year 1000
*/ %>
                </div>
                <div>
                    <label for="booking_payment">SELECT PAYMENT METHOD: </label>
                    <asp:RadioButtonList runat="server" ID="booking_payment">
                        <asp:ListItem Text="CASH" Value="booking_payment_cash"></asp:ListItem>
                        <asp:ListItem Text="CREDIT CARD" Value="booking_payment_credit"></asp:ListItem>
                        <asp:ListItem Text="DEBIT CARD" Value="booking_payment_debit"></asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator
                        runat="server"
                        ControlToValidate="booking_payment"
                        ErrorMessage="**Please select payment method**">
                    </asp:RequiredFieldValidator>
                </div>
            </section>
            <section>
                <div>
                    <h3>After Filling the form do not forget to click SUBMIT</h3>
                    <asp:Button runat="server" Text="SUBMIT" />
                </div>
                <div runat="server" id="booking_summary"></div>
            </section>
        </form>
    </div>
</body>
</html>
