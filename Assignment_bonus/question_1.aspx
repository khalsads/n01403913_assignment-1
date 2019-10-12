<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question_1.aspx.cs" Inherits="Assignment_bonus.question_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Question 1 | BONUS ASSIGNMENT</title>
</head>
<body>
<%-- Page Discription --%>
    <h1>BONUS ASSIGNMENT</h1>
    <h2>Question: 1</h2>
    <p>A cartesian plane has an x axis and a y axis, and looks as follows.</p>
    <asp:Image runat="server" ImageUrl="images/Quadrant.jpg" Height="500px"/>

<%--form to get x and y values and runat server for result--%>
    <form id="form1" runat="server">

<%-- User Input for x and y values --%>
        <div>
            <label for="value_x_axis">Enter the Value for X axis:</label>
            <asp:TextBox runat="server" ID="value_x_axis" ></asp:TextBox>
            <asp:RequiredFieldValidator
                runat="server"
                ControlToValidate="value_x_axis"
                EnableClientScript="true"
                ErrorMessage="Please Enter Value, input field is empty!">
            </asp:RequiredFieldValidator>
        </div>
        <div>
            <label for="value_y_axis">Enter the Value for Y axis:</label>
            <asp:TextBox runat="server" ID="value_y_axis"></asp:TextBox>
            <asp:RequiredFieldValidator
                runat="server"
                ControlToValidate="value_y_axis"
                EnableClientScript="true"
                ErrorMessage="Please Enter Value, input field is empty!">
            </asp:RequiredFieldValidator>
        </div>
        <asp:Button runat="server" Text="SUBMIT"/>
        <div runat="server" id="value_selected_result"></div>
    </form>
</body>
</html>
