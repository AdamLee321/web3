﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TicketList.aspx.cs" Inherits="Web3project_BookIT.TicketList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
    <section>
        <div>
            <hgroup>
                <h2><%: Page.Title %></h2>
            </hgroup>

            <asp:ListView ID="ticketList" runat="server" 
                DataKeyNames="TicketID" GroupItemCount="4"
                ItemType="Web3project_BookIT.Models.Ticket" SelectMethod="GetTickets">
                <EmptyDataTemplate>
                    <table >
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <EmptyItemTemplate>
                    <td/>
                </EmptyItemTemplate>
                <GroupTemplate>
                    <tr id="itemPlaceholderContainer" runat="server">
                        <td id="itemPlaceholder" runat="server"></td>
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td runat="server">
                        <table>
                            <tr>
                                <td>
                                    <a href="TicketDetails.aspx?TicketID=<%#:Item.TicketID%>">
                                        <img src="/Catalog/Images/Thumbs/<%#:Item.ImagePath%>"
                                            width="100" height="75" style="border: solid" /></a>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <a href="TicketDetails.aspx?TicketID=<%#:Item.TicketID%>">
                                        <span>
                                            <%#:Item.TicketName%>
                                        </span>
                                    </a>
                                    <br />
                                    <span>
                                        <b>Price: </b><%#:String.Format("{0:c}", Item.UnitPrice)%>
                                    </span>
                                    <br />
                                    <a href="/AddToCart.aspx?TicketID=<%#:Item.TicketID %>">               
                                        <span class="TicketListItem">
                                            <b>Add To Cart<b>
                                        </span>           
                                    </a>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                        </p>
                    </td>
                </ItemTemplate>
                <LayoutTemplate>
                    <table style="width:100%;">
                        <tbody>
                            <tr>
                                <td>
                                    <table id="groupPlaceholderContainer" runat="server" style="width:100%">
                                        <tr id="groupPlaceholder"></tr>
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td></td>
                            </tr>
                            <tr></tr>
                        </tbody>
                    </table>
                </LayoutTemplate>
            </asp:ListView>
        </div>
    </section>
        <script src="assets/plugins/jquery-1.10.2.js"></script>   
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>