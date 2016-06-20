<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeInfo.aspx.cs" Inherits="Part19_CodeFirst_TPH_Inheritnce.EmployeeInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButtonList ID="rbl_EmployeeInfo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbl_EmployeeInfo_SelectedIndexChanged">
            <asp:ListItem Value="AllEmployees">Load All Employees</asp:ListItem>
            <asp:ListItem Value="Permanent">Only Permanent Employees</asp:ListItem>
            <asp:ListItem Value="Contractor">Only Contractor Employees</asp:ListItem>
        </asp:RadioButtonList>

        <asp:GridView ID="gv_EmployeeData" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
