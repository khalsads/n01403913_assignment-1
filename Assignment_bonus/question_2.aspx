<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question_2.aspx.cs" Inherits="Assignment_bonus.question_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Question 2 | BONUS ASSIGNMENT</title>
</head>
<body>
    <h1>BONUS ASSIGNMENT</h1>
    <h2>Question: 2</h2>
    <form id="form1" runat="server">
        <h3>Select the days of week you working this month.</h3>
        <div>
            <label for="selected_DaySunday">SUNDAY</label>
            <asp:CheckBox runat="server" id="selected_DaySunday"/>

            <label for="selected_DayMonday">MONDAY</label>
            <asp:CheckBox runat="server" ID="selected_DayMonday" />

            <label for="selected_DayTuesday">TUESDAY</label>
            <asp:CheckBox runat="server" ID="selected_DayTuesday" />

            <label for="selected_DayWednessday">WEDNESSDAY</label>
            <asp:CheckBox runat="server" ID="selected_DayWednessday" />

            <label for="selected_DayThursday">THURSDAY</label>
            <asp:CheckBox runat="server" ID="selected_DayThursday" />

            <label for="selected_DayFriday">FRIDAY</label>
            <asp:CheckBox runat="server" ID="selected_DayFriday" />

            <label for="selected_DaySaturday">SATURDAY  </label>
            <asp:CheckBox runat="server" ID="selected_DaySaturday" />
        </div>
        <asp:Button runat="server" Text="SUBMIT"/>
    </form>
</body>
</html>
