<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayDeptDetails.aspx.cs" Inherits="ModelFirst_Part2.DisplayDeptDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:Label runat="server" Text="Testing for entity frameowrk model"></asp:Label>
        
        <asp:GridView ID="GridView1" runat="server" DataSourceID="EntityDataSource1" AutoGenerateColumns="False" DataKeyNames="DeptID" EmptyDataText="No Data Found!" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="DeptID" HeaderText="DeptID" ReadOnly="True" SortExpression="DeptID" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                <asp:TemplateField HeaderText="Employees">
                    <ItemTemplate>
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval["Employees"] %>'>
                            <Columns>
                                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" />
                                <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                                <asp:BoundField DataField="Salary" HeaderText="Salary" />
                            </Columns>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        
    </div>
        <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=EmployeeContainer" DefaultContainerName="EmployeeContainer" EnableFlattening="False" EntitySetName="Departments" EntityTypeFilter="Department" Include="Employees">
        </asp:EntityDataSource>
    </form>
</body> 
</html>
