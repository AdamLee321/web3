<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicketDetails.aspx.cs" Inherits="Web3project_BookIT.TicketDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="TicketDetail" runat="server" ItemType="Web3project_BookIT.Models.Ticket" SelectMethod ="GetTicket" RenderOuterTable="false">
        <ItemTemplate>
            <div> <!--Detail of single ticket-->
                <h1><%#:Item.TicketName %></h1>
            </div>
            <br />
            <table>
                <tr>
                    <td>
                        <img src="/Catalog/Images/<%#:Item.ImagePath %>" style="border:solid; height:300px" alt="<%#:Item.TicketName %>"/>
                    </td>
                    <td>&nbsp;</td>  
                    <td style="vertical-align: top; text-align:left;">
                        <b>Event Time:</b>&nbsp; <%#: Item.TicketTime %>
                        <br />
                        <span><b>Event Date:</b>&nbsp; <%#: Item.TicketDate %></span>
                        <br />
                        <span><b>Description:</b>&nbsp;<%#:Item.Description %></span>
                        <br />
                        <span><b>Venue:</b>&nbsp;<%#:Item.TicketVenue %></span>
                        <br />
                        <span><b>Price:</b>&nbsp;<%#: String.Format("{0:c}", Item.UnitPrice) %></span>
                        <br />
                        <span><b>Ticket Number:</b>&nbsp;<%#:Item.TicketID %></span>
                        <br />
                        <a href="/AddToCart.aspx?TicketID=<%#:Item.TicketID %>">               
                        <span class="TicketListItem">
                            <b>Add To Cart<b>
                        </span>           
                        </a>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>
