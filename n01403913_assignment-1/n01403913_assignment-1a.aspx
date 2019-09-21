<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="n01403913_assignment-1a.aspx.cs" Inherits="n01403913_assignment_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Assignment 1 Web Form</title>
</head>
<body>
    <h1>BUS TOUR BOOKING</h1>
    <h2>Please fill in all the following information to help you with Bus Tour Booking</h2>
    <form id="form1" runat="server">
        <section>
            <h3>Personal Information</h3>
            <div>
                <label for="user_fname">Your First Name :</label>
                <asp:TextBox runat="server" ID="user_fname"></asp:TextBox>
            </div>
            <div>
                <label for="user_lname">Your Last Name :</label>
                <asp:TextBox runat="server" ID="user_lname"></asp:TextBox>
            </div>
        </section>
        <section>
            <h3>Select from following locations you desire (we will provide you best package accordingly):</h3>
            <asp:CheckBoxList runat="server" ID="location">
                <asp:ListItem Text="Montreal" Value="location_1"></asp:ListItem>
                <asp:ListItem Text="Toronto" Value="location_2"></asp:ListItem>
                <asp:ListItem Text="New York" Value="location_3"></asp:ListItem>
                <asp:ListItem Text="Ottawa" Value="location_4"></asp:ListItem>
            </asp:CheckBoxList>
        </section>
        <section>
            <h3>Choose your age group:</h3>
            <asp:DropDownList runat="server" ID="age_group">
                <asp:ListItem Text="01 - 15 YEARS" Value="age_group_1"></asp:ListItem>
                <asp:ListItem Text="16 - 30 YEARS" Value="age_group_2"></asp:ListItem>
                <asp:ListItem Text="31 - 45 YEARS" Value="age_group_3"></asp:ListItem>
                <asp:ListItem Text="46 - 60 YEARS" Value="age_group_4"></asp:ListItem>
                <asp:ListItem Text="60 + YEARS" Value="age_group_5"></asp:ListItem>
            </asp:DropDownList>
        </section>
        <section>
            <h3>Choose method of Payment:</h3>
            <asp:RadioButtonList runat="server" ID="payment_method">
                <asp:ListItem Text="CASH" Value="payment_method_cash"></asp:ListItem>
                <asp:ListItem Text="CREDIT CARD" Value="payment_method_credit"></asp:ListItem>
                <asp:ListItem Text="DEBIT CARD" Value="payment_method_debit"></asp:ListItem>
            </asp:RadioButtonList>
        </section>
        <section>
            <h3>After Filling the form do not forget to click SUBMIT</h3>
            <asp:Button runat="server" Text="SUBMIT" />
        </section>
    </form>
</body>
</html>
