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
        </div>
        <asp:Button runat="server" Text="SUBMIT"/>
    </form>
</body>
</html>
