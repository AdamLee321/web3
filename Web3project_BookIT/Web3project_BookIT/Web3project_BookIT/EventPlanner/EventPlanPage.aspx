<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventPlanPage.aspx.cs" Inherits="Web3project_BookIT.EventPlanner.EventPlanPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<h1>Event Planner</h1>
    <hr />
    <h3>Add Ticket:</h3>
    <table>
        <tr>
            <td><asp:Label ID="LabelAddCategory" runat="server">Category:</asp:Label></td>
            <td>
                <!---->
                <asp:DropDownList ID="DropDownAddCategory" runat="server" 
                    ItemType="Web3project_BookIT.Models.Category" 
                    SelectMethod="GetCategories" DataTextField="CategoryName" 
                    DataValueField="CategoryID" >
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddName" runat="server">Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddTicketName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="* Ticket name required." ControlToValidate="AddTicketName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddTime" runat="server">Time:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddTicketTime" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="* Ticket time required." ControlToValidate="AddTicketTime" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDate" runat="server">Date:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddTicketDate" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="* Ticket date required." ControlToValidate="AddTicketDate" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddDescription" runat="server">Description:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddTicketDescription" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="* Description required." ControlToValidate="AddTicketDescription" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddTicket" runat="server">Price:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddTicketPrice" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="* Price required." ControlToValidate="AddTicketPrice" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Text="* Must be a valid price without $." ControlToValidate="AddTicketPrice" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelTicketVenue" runat="server">Venue:</asp:Label></td>
            <td>
                <asp:TextBox ID="AddTicketVenue" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Text="* Venue required." ControlToValidate="AddTicketVenue" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" Text="* Venue name required $." ControlToValidate="AddTicketVenue" SetFocusOnError="True" Display="Dynamic" ValidationExpression="^[0-9]*(\.)?[0-9]?[0-9]?$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelAddImageFile" runat="server">Image File:</asp:Label></td>
            <td>
                <asp:FileUpload ID="TicketImage" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="* Image path required." ControlToValidate="TicketImage" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddTicketButton" runat="server" Text="Add Ticket" OnClick="AddTicketButton_Click"  CausesValidation="true"/>
    <asp:Label ID="LabelAddStatus" runat="server" Text=""></asp:Label>
    <p> If you would like to remove an event please contact us</p>

    <h3>Add Venue:</h3>
    <p> If you do not see your venue listed please enter the venue details</p>
    <table>
        <tr>
            <td><asp:Label ID="LabelVenueName" runat="server">Venue Name:</asp:Label></td>
            <td>
                <asp:TextBox ID="VenueName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="* Venue name required." ControlToValidate="VenueName" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelVenueAdd1" runat="server">Venue Address Line 1:</asp:Label></td>
            <td>
                <asp:TextBox ID="VenueAdd1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" Text="* Venue address line 1 required." ControlToValidate="VenueAdd1" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelVenueAdd2" runat="server">Venue Address  Line 2<i>(optional)</i>:</asp:Label></td>
            <td>
                <asp:TextBox ID="VenueAdd2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelVenueCity" runat="server">Venue City:</asp:Label></td>
            <td>
                <asp:TextBox ID="VenueCity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" Text="* Venue city required." ControlToValidate="VenueCity" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelVenueCounty" runat="server">Venue County:</asp:Label></td>
            <td>
                <asp:TextBox ID="VenueCounty" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" Text="* Venue county required." ControlToValidate="VenueCounty" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="LabelVenueCapacity" runat="server">Venue Capacity:</asp:Label></td>
            <td>
                <asp:TextBox ID="VenueCapacity" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" Text="* Venue capacity required." ControlToValidate="VenueCapacity" SetFocusOnError="true" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <p></p>
    <p></p>
    <asp:Button ID="AddVenue" runat="server" Text="Add Venue" OnClick="AddVenueButton_Click"  CausesValidation="true"/>
    <asp:Label ID="LabelAddVenue" runat="server" Text=""></asp:Label>
    <p></p>
</asp:Content>
