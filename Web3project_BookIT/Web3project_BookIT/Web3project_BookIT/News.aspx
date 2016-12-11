<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="News" %>
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
    <h3>Add News</h3>
    <table border="0" cellpadding="0" cellspacing="0">
    <tr>
        <td>
            Title:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtTitle" runat="server" Width = "550" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            Body:
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="btnSubmit" Text="Submit News" runat="server" OnClick="Submit" />
            <asp:Label ID="LabelAddBlog" runat="server" Text=""></asp:Label>
        </td>
    </tr>
</table> 
</asp:Content>
