<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web3project_BookIT.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
    <h2><%: Title %>.</h2>
    <div class="form-horizontal">
    <h3>Contact Us.</h3>
        <div class="form-group">
        
            <asp:TextBox ID="TextBox1" runat="server" Width="186px" BackColor="#27C00A" BorderColor="Black"></asp:TextBox>
        
            <br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server" Width="186px" BackColor="#27C00A" BorderColor="Black"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TextBox3" runat="server" Height="60px" Width="186px" BackColor="#27C00A" BorderColor="Black" TextMode="MultiLine"></asp:TextBox>
        
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" style="margin-left: 16px" Text="Send" Width="75px" />
        
            </div>
        
        </div>
    <address>
        123 Sligo IT<br />
        Sligo, Ireland<br />
        <abbr title="Phone">P:</abbr>
        0871234567
    </address>

    <address>
         <strong>Support:</strong>   <a href="mailto:s00153921@mail.itsligo.ie">s00153921@mail.itsligo.ie</a><br />
        <strong>Support2:</strong>   <a href="mailto:s00174787@mail.itsligo.ie">s00174787@mail.itsligo.ie</a><br />
        <strong>Marketing:</strong> <a href="mailto:Support@example.com">Marketing@example.com</a>
    </address>

        <script src="assets/plugins/jquery-1.10.2.js"></script>   
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
     </div>
</asp:Content>
