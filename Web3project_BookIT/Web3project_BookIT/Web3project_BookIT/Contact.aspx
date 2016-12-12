<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Web3project_BookIT.Contact" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<%--<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>--%>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
    
    <link href="assets/css/style1.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />

    <style type="text/css">

.blankstar
{
background-image: url(Images/blank_star.png);
width: 16px;
height: 16px;
}
.waitingstar
{
background-image: url(Images/half_star.png);
width: 16px;
height: 16px;
}
.shiningstar
{
background-image: url(Images/shining_star.png);
width: 16px;
height: 16px;
}
</style>



    <h2><%: Title %>.</h2>

    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Contact Us</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Name" CssClass="col-md-2 control-label">Full Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="FullName" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Name"
                                CssClass="text-danger" ErrorMessage="Your Full name is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                                CssClass="text-danger" ErrorMessage="The email field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Subject" CssClass="col-md-2 control-label">Subject</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Subject" CssClass="form-control" TextMode="SingleLine" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Subject"
                                CssClass="text-danger" ErrorMessage="Subject is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Message" CssClass="col-md-2 control-label">Message</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Message" TextMode="MultiLine" CssClass="form-control" Height="100px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Message" CssClass="text-danger" ErrorMessage="A Message is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button runat="server" OnClick="Submit" Text="Send" CssClass="btn btn-default" />
                            <div class="divider"/>
                            <asp:Button runat="server" OnClick="Clear" Text="Clear" CssClass="btn btn-default" />
                        </div>
                        <p>
                        <asp:Label ID="DisplayMessage" runat="server" Visible="true" />
                        </p>
                    </div>
                </div> 
            </section>
        </div>
        </div>
     <h2>Tells us what you think of our site</h2>
      <h3>We value your input to help make BookIT better</h3>

        Message to: <asp:TextBox ID="txtTo" runat="server" BackColor="#ffcc66" BorderColor="Black" Text="S00153921@mail.itsligo.ie" /><br>
        Message from: <asp:TextBox ID="txtFrom"  BackColor="#ffcc66" BorderColor="Black" runat="server" /><br>
        Ticket Name: <asp:TextBox ID="txtSubject" BackColor="#ffcc66" BorderColor="Black" runat="server" /><br>
        Message Body:<br>
        <asp:TextBox ID="txtBody" BackColor="#ffcc66" BorderColor="Black" runat="server" Height="171px" TextMode="MultiLine" Width="270px" text="Give us a review"/><br>
        <asp:Button ID="Btn_SendMail" runat="server" onclick="Btn_SendMail_Click" Text="Send Email" /><br>
        <h2>You need a working SMTP service for sending email</h2>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

    <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server"></asp:UpdatePanel>

    <asp:Rating ID="Rating1" runat="server" StarCssClass="starRating" FilledStarCssClass="FilledStar" EmptyStarCssClass="Star" WaitingStarCssClass="WaitingStar"
         CurrentRating="4" MaxRating="5">
        
    </asp:Rating>--%><%--<asp:Rating ID="Rating1" runat="server"></asp:Rating>--%>

    <asp:Rating ID="Rating5" runat="server" AutoPostBack="true" StarCssClass="blankstar"
        WaitingStarCssClass="waitingstar" FilledStarCssClass="shiningstar"
        EmptyStarCssClass="blankstar" OnChanged="Rating5_Changed">
    </asp:Rating>
   
 
<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>, 
<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label> 

   
    <h2>Give us your thoughts</h2>

    Your Name: <asp:TextBox ID="Name" runat="server" BackColor="#ffcc66" BorderColor="Black" Text="Joe Smith" />
    Ticket Purchased: <asp:TextBox ID="TickeName" BackColor="#ffcc66" BorderColor="Black" runat="server" Text="En Pure" />
    Rating: <asp:TextBox ID="Rating2" runat="server" BackColor="#ffcc66" BorderColor="Black" Text="1-5" />
     <%--<asp:Button ID="btnValue" runat="server" Text="Submit" OnClick="btnValue_Click" />--%>
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
</asp:Content>