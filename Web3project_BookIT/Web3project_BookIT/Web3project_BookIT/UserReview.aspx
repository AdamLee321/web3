<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserReview.aspx.cs" Inherits="Web3project_BookIT.UserReview" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
  <%-- <style type="text/css">
       .starRating{
               width:50px;
               height:50px;
               cursor:pointer;
               background-repeat:no-repeat;
               display:block;
       }
       
        .EmptyStar
        {
            background-image: url(Images/Empty_star.png);
          
        }
        .WaitingStar
        {
            background-image: url(Images/WaitingStar.png);
          
        }
        .FilledStar
        {
            background-image: url(Images/Star.png);
          
        }
    </style>--%>
    
    <div class="jumbotron">

        <h1>BookIT.</h1>
      
        <p class="lead"></p>
        <h2>BookIT can help you find the perfect event or to make your own.</h2>
        <p class="lead">This is the BookIT website where you can purchase tickets 
            for events or log in as an event planner and post rickets to your event here.</p>
    </div>
    
      <h2>Tells us what you think of our site</h2>
      <h3>We value your input to help make BookIT better</h3>

        Message to: <asp:TextBox ID="txtTo" runat="server" Text="S00153921@mail.itsligo.ie" /><br>
        Message from: <asp:TextBox ID="txtFrom" runat="server" /><br>
        Ticket Name: <asp:TextBox ID="txtSubject" runat="server" /><br>
        Message Body:<br>
        <asp:TextBox ID="txtBody" runat="server" Height="171px" TextMode="MultiLine" Width="270px" text="Give us a review"/><br>
        <asp:Button ID="Btn_SendMail" runat="server" onclick="Btn_SendMail_Click" Text="Send Email" /><br>
        <h2>You need a working SMTP service for sending email</h2>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
   
    

   
       
        <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>

    <asp:Rating ID="Rating1" runat="server" StarCssClass="starRating" FilledStarCssClass="FilledStar" EmptyStarCssClass="Star" WaitingStarCssClass="WaitingStar"
         CurrentRating="4" MaxRating="5">
        
    </asp:Rating>--%>
   
    <h2>Give us your thoughts</h2>

    Your Name: <asp:TextBox ID="Name" runat="server" Text="Joe Smith" />
    Ticket Purchased: <asp:TextBox ID="TickeName" runat="server" Text="En Pure" />
    Rating: <asp:TextBox ID="Rating2" runat="server" Text="1-5" />
     <asp:Button ID="btnValue" runat="server" Text="Submit" OnClick="btnValue_Click" />
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblThanks" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label12" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
    <br />

<%--    <table width="100%" cellpadding="4" cellspacing="4">
    <tr>
    <td colspan="2" align="center"><h3>USER DETAIL</h3></td>
    </tr>
        <tr>
            <td align="right">
                Name :
            </td>
            <td align="left">
                <asp:TextBox ID="txtName" runat="server" Width="200px" autocomplete="off"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Address :
            </td>
            <td align="left">
                <asp:TextBox ID="txtAddress" runat="server" Width="200px" autocomplete="off"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                 </td>
            <td align="left">
                <asp:Label ID="lblmessage" runat="server" style="color: #FF3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                 </td>
            <td align="left">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
            </td>
        </tr>
    </table>--%>
    <script src="assets/plugins/jquery-1.10.2.js"></script>   
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>
