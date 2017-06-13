<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ManagePlaylist.aspx.cs" Inherits="BusinessProcesses_ManagePlaylist" %>

<%@ Register Src="~/UserControls/MessageUserControl.ascx" TagPrefix="uc1" TagName="MessageUserControl" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:ObjectDataSource ID="ArtistsListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="ArtistsList" TypeName="ChinookSystem.BLL.ArtistController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="MediaTypesListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="MediaTypeList" TypeName="ChinookSystem.BLL.MediaTypeController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="GenresListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GenresList" TypeName="ChinookSystem.BLL.GenreController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="AlbumsListODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="AlbumList" TypeName="ChinookSystem.BLL.AlbumController"></asp:ObjectDataSource>
    <asp:ObjectDataSource ID="TracksForSelectionODS" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="TracksForPlayListSelection_Get" TypeName="ChinookSystem.BLL.TrackController">
        <SelectParameters>
            <asp:ControlParameter
                 ControlID="SearchArgID"
                 PropertyName="Text" 
                Name="id" Type="Int32"></asp:ControlParameter>
            <asp:ControlParameter
                ControlID="TracksBy" PropertyName="Text"  Name="fetchBy" Type="String"></asp:ControlParameter>
        </SelectParameters>
    </asp:ObjectDataSource>
    <div class="jumbotron">
        <h2>Manage Playlist</h2>
    </div>
    <div class="row">
        <uc1:MessageUserControl runat="server" ID="MessageUserControl" />
    </div>
    <div class="row">
        <div class="col-sm-3">
            <asp:Label ID="Artistlabel" runat="server" Text="Artist"></asp:Label>
            <br />
            <asp:DropDownList ID="ArtistsList" runat="server" Width="300px" DataSourceID="ArtistsListODS" DataTextField="DisplayText" DataValueField="PFKeyIdentifier"></asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Button ID="ArtistFetch" runat="server" Text="Fetch" Class="btn btn-primary"
                onClick="ArtistFetch_Click"/>
            <br /><br />

             <asp:Label ID="MediaTypeLabel" runat="server" Text="Media Type"></asp:Label>
            <br />
            <asp:DropDownList ID="MediaTypesList" runat="server" Width="300px" DataSourceID="MediaTypesListODS" DataTextField="DisplayText" DataValueField="PFKeyIdentifier"></asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Button ID="MediaTypeFetch" runat="server" Text="Fetch" Class="btn btn-primary"
                onClick="MediaTypeFetch_Click"/>
            <br /><br />

             <asp:Label ID="GenreLabel" runat="server" Text="Genre"></asp:Label>
            <br />
            <asp:DropDownList ID="GenresList" runat="server" Width="300px" DataSourceID="GenresListODS" DataTextField="DisplayText" DataValueField="PFKeyIdentifier"></asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Button ID="GenreFetch" runat="server" Text="Fetch" Class="btn btn-primary"
                onClick="GenreFetch_Click"/>
            <br /><br />

             <asp:Label ID="AlbumLabel" runat="server" Text="Album"></asp:Label>
            <br />
            <asp:DropDownList ID="AlbumsList" runat="server" Width="300px" DataSourceID="AlbumsListODS" DataTextField="DisplayText" DataValueField="PFKeyIdentifier"></asp:DropDownList>
            &nbsp;&nbsp;
            <asp:Button ID="AlbumFetch" runat="server" Text="Fetch" Class="btn btn-primary"
                onClick="AlbumFetch_Click"/>
            <br /><br />

        </div>
        <div class="col-sm-9">
            <asp:Label ID="ListViewLabel" runat="server" Text="Tracks by "></asp:Label>
            <asp:Label ID="TracksBy" runat="server"></asp:Label>
            <!--hidden Label control -->
            <asp:Label ID="SearchArgID" runat="server" Visible="false"></asp:Label>
            <br />
            <asp:ListView ID="TrackSearchList" runat="server" DataSourceID="TracksForSelectionODS" 
                OnItemCommand="TrackSearchList_ItemCommand">
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table runat="server" id="itemPlaceholderContainer" style="" border="0">
                        <tr runat="server" style="">
                            <th runat="server">TrackId</th>                           
                             <th runat="server">Name</th>
                             <th runat="server">Media Type</th>
                             <th runat="server">Genre</th>
                             <th runat="server">Composer</th>
                             <th runat="server">MSec</th>
                             <th runat="server">Bytes</th>
                             <th runat="server">Price</th>
                        </tr>
                        <tr runat="server" id="itemPlaceholder"></tr>
                    </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="">
                                <asp:DataPager ID="DataPager1" runat="server" PageSize="5">
                                    <Fields>
                                        <asp:NumericPagerField ButtonType="Button" ButtonCount="4" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                    
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:LinkButton ID="AddToPlaylist" runat="server" CssClass="btn" CommandArgument='<%#Eval("TrackId") %>'>
                                 <span aria-hidden="true" class="glyphicon glyphicon-plus" style="color:blue;"></span>
                            </asp:LinkButton>
                        </td>
                        <td>
                            <asp:Label ID="NameLabel" runat="server" Text='<%#Eval("Name") %>' />&nbsp;&nbsp;

                        </td>
                        <td>
                            <asp:Label ID="MediaLabel" runat="server" Text='<%#Eval("MediaName") %>' />&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:Label ID="GenreLabel" runat="server" Text='<%#Eval("GenreName") %>' />&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:Label ID="ComposerLabel" runat="server" Text='<%#Eval("Composer") %>' />&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:Label ID="MsecLabel" runat="server" Text='<%#Eval("Milliseconds") %>' />&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:Label ID="BytesLabel" runat="server" Text='<%#Eval("Bytes") %>' />&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:Label ID="UnitPriceLabel" runat="server" Text='<%#Eval("UnitPrice") %>' />&nbsp;&nbsp;
                        </td>
                    </tr>
                </ItemTemplate>
                <EmptyDataTemplate>
                    <tr>
                        <td>No data was returned ...</td>
                    </tr>
                </EmptyDataTemplate>
            </asp:ListView>
            <br />
            <asp:Label ID="PlaylistSearchLabel" runat="server" Text="Playlist"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="PlaylistName" runat="server"></asp:TextBox>
            &nbsp;&nbsp;
           <asp:Button ID="PlaylistFetch" runat="server" Text="Fetch" Class="btn btn-primary"
               onClick="PlaylistFetch_Click"/>
            &nbsp;&nbsp;
            <asp:LinkButton ID="DeleteTrack" runat="server" CssClass="btn"
                onClick="DeleteTrack_Click" />
                <span aria-hidden="true" class="glyphicon glyphicon-remove" style="color:red;"></span>
            </asp:LinkButton>
            <br /><br />
            <asp:GridView ID="CurrentPlaylist" runat="server"
                Caption="Playlist"
                GridLines="Horizontal"
                BorderStyle="None"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="Title">
                        <ItemTemplate>
                            <asp:Label ID="Title" runat="server" Text='<%#Eval("Title") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Length">
                        <ItemTemplate>
                            <asp:Label ID="TimeLength" runat="server" Text='<%#Eval("TimeLength") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Size">
                        <ItemTemplate>
                            <asp:Label ID="Size" runat="server" Text='<%#Eval("Size") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label ID="UnitPrice" runat="server" Text='<%#Eval("UnitPrice") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Label ID="TrackId" runat="server" Text='<%#Eval("TrackId") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>

                <EmptyDataTemplate>
                    No tracks on playlist
                </EmptyDataTemplate>
            </asp:GridView>
  
        </div>
    </div>

</asp:Content>

