<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicketDetails.aspx.cs" Inherits="Web3project_BookIT.TicketDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
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
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
        <script src="assets/plugins/jquery-1.10.2.js"></script>   
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>
