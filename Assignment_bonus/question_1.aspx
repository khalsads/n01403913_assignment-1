<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question_1.aspx.cs" Inherits="Assignment_bonus.question_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Question 1 | BONUS ASSIGNMENT</title>
</head>
<body>
    <h1>BONUS ASSIGNMENT</h1>
    <h2>Question: 1</h2>
    <form id="form1" runat="server">
        <div>
            <label for="value_Xaxis">Enter the Value for X axis:</label>
            <asp:TextBox runat="server" ID="value_Xaxis"></asp:TextBox>
        </div>
        <div>
            <label for="value_Yaxis">Enter the Value for Y axis:</label>
            <asp:TextBox runat="server" ID="value_Yaxis"></asp:TextBox>
        </div>
        <asp:Button runat="server" Text="SUBMIT"/>
    </form>
</body>
</html>
