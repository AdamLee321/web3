<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CheckoutError.aspx.cs" Inherits="Web3project_BookIT.Checkout.CheckoutError" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
     
    <h1>Checkout Error</h1>
    <p></p>
	<table id="ErrorTable">
		<tr>
			<td class="field"></td>
			<td><%=Request.QueryString.Get("ErrorCode")%></td>
		</tr>
		<tr>
			<td class="field"></td>
			<td><%=Request.QueryString.Get("Desc")%></td>
		</tr>
		<tr>
			<td class="field"></td>
			<td><%=Request.QueryString.Get("Desc2")%></td>
		</tr>
	</table>
    <p></p>
    <script src="script.js"></script>
    <script src="assets/plugins/jquery-1.10.2.js"></script>
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>