<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayAllEmployees.aspx.cs" Inherits="EntityFrameworkDemo.DisplayAllEmployees" %>

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
                <td style="margin-left: 40px">
                    
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DeptID" DataSourceID="EntityDataSource1">
                        <Columns>
                            <asp:BoundField DataField="DeptID" HeaderText="DeptID" ReadOnly="True" SortExpression="DeptID" />
                            <asp:BoundField DataField="DeptName" HeaderText="DeptName" SortExpression="DeptName" />
                            <asp:BoundField DataField="Location" HeaderText="Location" SortExpression="Location" />
                            <asp:TemplateField HeaderText="tbl_Pragim_Entity_Employee">
                                <ItemTemplate>
                                    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSource='<%# Eval("tbl_Pragim_Entity_Employee") %>'>
                                        <Columns>
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
                    
                </td>
            </tr>
            <tr>
                <td>

                    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=dbTestEntities" DefaultContainerName="dbTestEntities" EnableFlattening="False" EntitySetName="tbl_Pragim_Entity_Department" Include="tbl_Pragim_Entity_Employee">
                    </asp:EntityDataSource>

                </td>
            </tr>

        </table>

    </div>
    </form>
</body>
</html>
