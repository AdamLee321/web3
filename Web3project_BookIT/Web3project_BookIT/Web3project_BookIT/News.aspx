<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Web3project_BookIT.News" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
    <h2><%: Title %>.</h2>
    <br />
    <div>Write Your Post</div>
    <h2>
    <asp:Label ID="lblTitle" runat="server" /></h2>
    <hr />
    <asp:Label ID="lblBody" runat="server" />
    <h2>
    Blogs</h2>
    <br />
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Admin.aspx" Text="Add News" runat="server" />
    <hr />
    <asp:Repeater ID="rptPages" runat="server">
    <ItemTemplate>
        <%# Container.ItemIndex + 1 %>
        <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# string.Format("~/News/{0}/{1}.aspx", Eval("BlogId"), Eval("Slug")) %>'
            Text='<%# Eval("Title") %>' runat="server" />
    </ItemTemplate>
    <SeparatorTemplate>
    <br />
    </SeparatorTemplate>
</asp:Repeater>   
    <script src="script.js"></script>
    <script src="assets/plugins/jquery-1.10.2.js"></script>
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>
