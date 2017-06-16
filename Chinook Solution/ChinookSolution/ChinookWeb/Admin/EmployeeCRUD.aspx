<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="EmployeeCRUD.aspx.cs" Inherits="Admin_EmployeeCRUD" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
         <h1>Employee CRUD</h1>
        <h3>CRUD Exercise</h3>
    </div>
    <div class="row">
        <uc1:MessageUserControl runat="server" ID="MessageUserControl" />
    </div>
    <div class="row">
        <asp:ListView ID="EmployeeList" runat="server" 
            DataSourceID="EmployeeListODS"
            InsertItemPosition="LastItem" 
            DataKeyNames="EmployeeID">
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table runat="server">
                                <tr runat="server" id="itemPlaceholderContainer" style="background-color:#c0c0c0; color:black;">
                                    <th runat="server">&nbsp;&nbsp;</th>
                                    <th runat="server">ID&nbsp;&nbsp;</th>
                                    <th runat="server">Firstname&nbsp;&nbsp;</th>
                                    <th runat="server">Lastname&nbsp;&nbsp;</th>
                                    <th runat="server">Phone&nbsp;&nbsp;</th>
                                    <th runat="server">Active&nbsp;&nbsp;</th>
                                </tr>
                                <tr runat="server" id="itemPlaceholder"></tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField 
                                        ButtonType="Button" 
                                        ShowFirstPageButton="true" 
                                        ShowNextPageButton="false" 
                                        ShowPreviousPageButton="false" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField 
                                        ButtonType="Button" 
                                        ShowLastPageButton="true" 
                                        ShowNextPageButton="false" 
                                        ShowPreviousPageButton="false" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" />&nbsp;&nbsp;
                        <asp:Button ID="EditButton" runat="server" Text="Edit" CommandName="Edit" />&nbsp;&nbsp;
                    </td>
                    <td>
                         <asp:Label ID="EmployeeID" runat="server" Text='<%#Eval("EmployeeID") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:Label ID="FirstName" runat="server" Text='<%#Eval("FirstName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                         <asp:Label ID="LastName" runat="server" Text='<%#Eval("LastName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                         <asp:Label ID="Phone" runat="server" Text='<%#Eval("HomePhone") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:CheckBox ID="Active" runat="server" Checked='<%#Eval("Active") %>' Enabled="false"/>
                    </td>
                </tr>
            </ItemTemplate>
            <EditItemTemplate>
                <tr>
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" Text="Update" CommandName="Update" />&nbsp;&nbsp;
                        <asp:Button ID="CancelButton" runat="server" Text="Cancel" CommandName="Cancel" />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:Label ID="EmployeeIDLabel" runat="server" Text='<%#Bind("EmployeeID") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%#Bind("FirstName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="LastNameTextBos" runat="server" Text='<%#Bind("LastName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%#Bind("HomePhone") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%#Bind("Active") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <InsertItemTemplate>
                <tr>
                    <td>
                        <asp:Button ID="InsertButton" runat="server" Text="Insert" CommandName="Insert" />&nbsp;&nbsp;
                        <asp:Button ID="CancelButton" runat="server" Text="Cancel" CommandName="Clear" />&nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%#Bind("FirstName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="LastNameTextBos" runat="server" Text='<%#Bind("LastName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="PhoneTextBox" runat="server" Text='<%#Bind("HomePhone") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:CheckBox ID="ActiveCheckBox" runat="server" Checked='<%#Bind("Active") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <SelectedItemTemplate>
                <tr>
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" Text="Delete" CommandName="Delete" />
                        <asp:Button ID="EditButton" runat="server" Text="Edit" CommandName="Edit" />
                    </td>
                    <td>
                         <asp:Label ID="EmployeeID" runat="server" Text='<%#Eval("EmployeeID") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:Label ID="FirstName" runat="server" Text='<%#Eval("FirstName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                         <asp:Label ID="LastName" runat="server" Text='<%#Eval("LastName") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                         <asp:Label ID="Phone" runat="server" Text='<%#Eval("HomePhone") %>' />&nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:CheckBox ID="Active" runat="server" Checked='<%#Eval("Active") %>' ReadOnly="true"/>
                    </td>
                </tr>
            </SelectedItemTemplate>
            <EmptyDataTemplate>
                <tr>
                    <td>No data was returned</td>
                </tr>
            </EmptyDataTemplate>
        </asp:ListView>
    </div>
    <asp:ObjectDataSource ID="EmployeeListODS" runat="server"></asp:ObjectDataSource>
</asp:Content>

