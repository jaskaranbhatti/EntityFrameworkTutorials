<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayDepartmentDetails.aspx.cs" Inherits="CodeFirstApproach.DisplayDepartmentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>

                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" EmptyDataText="No Data Found!" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="DeptID" SortExpression="DeptID" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                        <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                        <asp:TemplateField HeaderText="EmployeeData">
                            <ItemTemplate>
                                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" EmptyDataText="No Employees Found!" DataSource='<%# Eval("Employees") %>'>
                                    <Columns>
                                        <asp:BoundField DataField="Id" HeaderText="Id" />
                                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                                        <asp:BoundField DataField="LastName" HeaderText="LastName" />
                                        <asp:BoundField DataField="Salary" HeaderText="Salary" />
                                    </Columns>
                                </asp:GridView>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            </td>
        </tr>
        <tr>
            <td>

                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetAllDepartments" TypeName="CodeFirstApproach.EmployeeRepository"></asp:ObjectDataSource>

            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
