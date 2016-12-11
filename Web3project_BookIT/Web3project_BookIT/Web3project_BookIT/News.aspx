<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="Web3project_BookIT.News" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
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
</asp:Content>
