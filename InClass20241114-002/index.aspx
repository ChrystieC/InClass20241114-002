<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="InClass20241114_002.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lbPizzaCompanies" runat="server"></asp:ListBox>
            </br>
            <asp:Button ID="cmdSelectPizzaCompany" runat="server" Text="Select A Pizza Company" OnClick="cmdSelectPizzaCompany_Click" />
            </br>
            <asp:Label ID="lblSelectedPizzaCompany" runat="server" Text=""></asp:Label>
            </br>
            <asp:CheckBoxList ID="cblIngredients" runat="server"></asp:CheckBoxList>
        </div>
    </form>
</body>
</html>
