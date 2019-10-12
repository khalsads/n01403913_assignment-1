<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question_3.aspx.cs" Inherits="Assignment_bonus.question_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Question 3 | BONUS ASSIGNMENT</title>
</head>
<body>
    <h1>BONUS ASSIGNMENT</h1>
    <h2>Question: 3</h2>
    <p>Good News The HTTB program is doing a raffle for a brand new laptop.</p>
    <p>Each ticket is 25 cents ($0.25cad).</p>
    <form id="form1" runat="server">
        <div>
            <label for="ticket_ordered">How many tickets you wnat to purchase:</label>
            <asp:TextBox ID="ticket_ordered" runat="server"></asp:TextBox>
            <%-- Requiredfied validator to check if no value entered --%>
            <asp:RequiredFieldValidator
                runat="server"
                ControlToValidate="ticket_ordered"
                EnableClientScript="true"
                ErrorMessage="Please Enter Value, input field is empty!">
            </asp:RequiredFieldValidator>
            <%-- Compare Validator to prompt user to enter value higher than 0 (i.e. no negative value or 0 as input) --%>
            <asp:CompareValidator
                runat="server"
                ErrorMessage="Please choose value higher than 0"
                ControlToValidate="ticket_ordered"
                EnableClientScript="true"
                ValueToCompare= 0
                Operator="GreaterThan"
                Type="Integer">

            </asp:CompareValidator>

        </div>
        <asp:Button runat="server" Text="SUBMIT"/>
        <div id="ticket_ordered_result" runat="server"></div>
    </form>
</body>
</html>
