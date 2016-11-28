<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tickets.aspx.cs" Inherits="Web3project_BookIT.Tickets1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />   
    <link href="css/Style1.css" rel="stylesheet" />   
    <link href="assets/css/style.css" rel="stylesheet" />
    <link href='https://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />

    
    <div class="jumbotron" id="imageheader">

        <h1><%: Title %>.</h1>
        <p class="lead"></p>
        <h2>BookIT can help you find the perfect event or to make your own.</h2>
        <p class="lead">This is the BookIT website where you can purchase tickets 
            for events or log in as an event planner and post rickets to your event here.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                You can view all the tickets we have on sale or you can log-in and purchase tickets though our website.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Are You An Event Organizer?</h2>
            <p>
                Register with us today and sell your tickets from our website.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
    <div class="container">
        <asp:Button ID="button1" runat="server" OnClick="button1_Click" />
    </div>
    <div class="container">
        <h2>Ticketmaster widget</h2>
           <div id="ev1" w-type="event-discovery" w-tmapikey="M2t2GVVu0fVlZlucU1G5tif4GYAvoKx7" w-googleapikey="AIzaSyBQrJ5ECXDaXVlICIdUBOe8impKIGHDzdA" w-keyword="Music" w-theme="simple" w-colorscheme="light" w-width="250" w-height="500" w-size="25" w-border="0" w-borderradius="4" w-postalcode="0000" w-radius="25" w-country="" w-period="year" w-layout="vertical" w-attractionid="" w-promoterid="" w-venueid="" w-affiliateid="" w-segmentid="" w-proportion="custom"></div>
           <div id="ev2" w-type="event-discovery" w-tmapikey="M2t2GVVu0fVlZlucU1G5tif4GYAvoKx7" w-googleapikey="AIzaSyBQrJ5ECXDaXVlICIdUBOe8impKIGHDzdA" w-keyword="Sport" w-theme="simple" w-colorscheme="light" w-width="250" w-height="500" w-size="25" w-border="0" w-borderradius="4" w-postalcode="0000" w-radius="25" w-country="" w-period="year" w-layout="vertical" w-attractionid="" w-promoterid="" w-venueid="" w-affiliateid="" w-segmentid="" w-proportion="custom" w-countrycode="IE"></div>
           <div id="ev3" w-type="event-discovery" w-tmapikey="M2t2GVVu0fVlZlucU1G5tif4GYAvoKx7" w-googleapikey="AIzaSyBQrJ5ECXDaXVlICIdUBOe8impKIGHDzdA" w-keyword="Family" w-theme="simple" w-colorscheme="light" w-width="250" w-height="500" w-size="25" w-border="0" w-borderradius="4" w-postalcode="0000" w-radius="25" w-country="" w-period="year" w-layout="vertical" w-attractionid="" w-promoterid="" w-venueid="" w-affiliateid="" w-segmentid="" w-proportion="custom" w-countrycode="IE"></div>
           <div id="ev4" w-type="event-discovery" w-tmapikey="M2t2GVVu0fVlZlucU1G5tif4GYAvoKx7" w-googleapikey="AIzaSyBQrJ5ECXDaXVlICIdUBOe8impKIGHDzdA" w-keyword="Theatre" w-theme="simple" w-colorscheme="light" w-width="250" w-height="500" w-size="25" w-border="0" w-borderradius="4" w-postalcode="0000" w-radius="25" w-country="" w-period="year" w-layout="vertical" w-attractionid="K8vZ9174_c7" w-promoterid="" w-venueid="" w-affiliateid="" w-segmentid="" w-proportion="custom" w-countrycode="IE"></div>
          
           <script src="https://ticketmaster-api-staging.github.io/products-and-docs/widgets/event-discovery/1.0.0/lib/main-widget.js"></script>
    </div>
    <div class="container">
        <h2>Ticketmaster Events</h2>
    <p id="location">location there</p>
    <div id="map"></div>
    <div id="events"></div>
 <script>  
 function myMap() {
  var mapCanvas = document.getElementById("map");
  var mapOptions = {
    center: new google.maps.LatLng(51.508742,-0.120850),
    zoom: 5
  };
  var map = new google.maps.Map(mapCanvas, mapOptions);
}
</script>

<script src="https://maps.googleapis.com/maps/api/js?callback=myMap"></script>
    <script src="https://maps.googleapis.com/maps/api/js" async defer></script>
    </div>

     <script src="script.js"></script>
    <script src="assets/plugins/jquery-1.10.2.js"></script>
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>

