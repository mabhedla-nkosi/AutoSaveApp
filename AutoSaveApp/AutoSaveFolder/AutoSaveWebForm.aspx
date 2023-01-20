<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="AutoSaveWebForm.aspx.vb" Inherits="AutoSaveApp.AutoSaveWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
     <div>
            <div>
                <asp:Label ID="typeOfNotesLabel" runat="server" Text="Type of Notes">Type of Notes:</asp:Label>
                <asp:DropDownList ID="notesDropDown" runat="server">
                    <asp:ListItem Value="" Selected="True" Enabled="false">Choose Type of Notes</asp:ListItem>
                    <asp:ListItem Value="Normal Notes">Normal Notes</asp:ListItem>
                    <asp:ListItem Value="Confidential Notes">Confidential Notes</asp:ListItem>
                </asp:DropDownList>
            </div>
            <br />
            <div>
                <asp:Label ID="notesLabel" runat="server" Text="Notes">Notes:</asp:Label>
                <asp:TextBox ID="notesTextBox" runat="server" TextMode="MultiLine" Rows="4" Columns="50"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Button ID="submitBtn" runat="server" Text="Submit" ToolTip="Submit" />
            </div>>
    </div>
    <div>
        <asp:Label ID="display" runat="server"></asp:Label>
    </div>
    <div>
        <asp:Label ID="showLabel" runat="server"></asp:Label>
    </div>
</asp:Content>
