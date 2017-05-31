<%@ Page Ttle Language="C#" MastterPageFile="~Site.mater" AutoEventWireup="true" CodeFile %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>


<asp:Content ID="Contet">
<asp:objectdatasource runat="server"></asp:objectdatasource>
<asp:objectdatasource runat="server"></asp:objectdatasource>
<div class ="row jumbotron">
    <h2>Demonstrating Access to GridView and ListView</h2>
    </div>
<div class="row">
    <uc1:MessageUserControl runat="server" id="MessageUserControl" />
    </div>
<div class="row">
    <asp:Panel ID="ControlPanel" runat="serve">
        <asp:Label ID="TrackBy"  runat="server" Text="Label"></asp:Label>

        <asp:LinkButton ID="Fecth" runat="server">LinkButton</asp:LinkButton>
        <asp:GridView ID="TrackListGV" runat="server"></asp:GridView>
</div>
</asp:Content>

