<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaymentStripe.aspx.cs" Inherits="Web3project_BookIT.PaymentStripe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />

    <div class="jumbotron">

        <h1>BookIT.</h1>
        <p class="lead"></p>
        <h2>BookIT can help you find the perfect event or to make your own.</h2>
        <p class="lead">This is the BookIT website where you can purchase tickets 
            for events or log in as an event planner and post rickets to your event here.</p>
    </div>

    <div class="row">
        <h2>Thank your for your interest. Click the pay now button below to complete your purchase</h2>
     </div>
     
     Enter Ticket Cost: <asp:TextBox ID="TicketPrice" runat="server" BackColor="#ffcc66" BorderColor="Black" Text="120" OnTextChanged="TicketPrice_TextChanged"/>
    <asp:CompareValidator runat="server" Operator="DataTypeCheck" Type="Integer" 
     ControlToValidate="TicketPrice" ErrorMessage="Value must be a whole number" />
    <asp:Label ID="lblChecker" Text="" runat="server" ></asp:Label>
     <script
            src="https://checkout.stripe.com/checkout.js" class="stripe-button"

               data-key="pk_test_VaUXp0vgAMBDqVmd1sJAUkm8"
               data-amount='<%= TicketPrice %>';
               data-name="BookIT Payment"
               data-description="Pay Here"
               data-image="https://stripe.com/img/documentation/checkout/marketplace.png"
               data-locale="auto"
               data-zip-code="true"
               data-currency="eur">
               

            </script>

     <%--<asp:ImageButton ID="CheckoutImageBtn" runat="server" 
                      ImageUrl="https://www.paypal.com/en_US/i/btn/btn_xpressCheckout.gif" 
                      Width="145" AlternateText="Check out with PayPal" 
                      OnClick="CheckoutBtn_Click" 
                      BackColor="Transparent" BorderWidth="0" />--%>
          
    <script src="assets/plugins/jquery-1.10.2.js"></script>   
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>

