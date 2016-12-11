<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web3project_BookIT._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <link href="assets/css/bootstrap.css" rel="stylesheet" />
  
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
   
    <link href="assets/css/style.css" rel="stylesheet" />
   
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
    
    <div class="jumbotron">

        <h1><%: Title %>.</h1>
        <p class="lead"></p>
        <h2>BookIT can help you find the perfect event or to make your own.</h2>
        <p class="lead">This is the BookIT website where you can purchase tickets 
            for events or log in as an event planner and post tickets to your event here.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Looking for an event?</h2>
            <p>
                Looking for a great night out or something nice for you and kids? BookIT with us!
            </p>
            <p>
                <a class="btn btn-default" href="TicketList.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Are you an event planner?</h2>
            <p>
                Register with us today and sell your tickets from our website.
            </p>
            <p>
                <a class="btn btn-default" href="Account/RegisterEventPlanner.aspx">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Who are we at BookIT?</h2>
            <p>
                We bagan this website to allow customers and event organizers to buy and post tickets for events.
            </p>
            <p>
                <a class="btn btn-default" href="About">Learn more &raquo;</a>
            </p>
        </div>
    </div>
     <section id="services">
        <div class="container">

            <div class="row text-center">
                <div class="col-md-8 col-md-offset-2">
                    <h2>Our Services</h2>

                </div>

            </div>

            <div class="row text-center space-pad">
                <div class="col-md-3 col-sm-3">

                    <div>

                        <i class="fa fa-camera fa-4x main-color"></i>


                       <a href="Tickets.html"><h3>Find events easily</h3></a>
                        <p>
                           You can view events near you based on your location, so you don't have to look hard.
                        </p>

                    </div>

                </div>
                <div class="col-md-3 col-sm-3">

                    <div>

                        <i class="fa fa-briefcase fa-4x main-color"></i>


                        <h3>Easy to use </h3>
                        <p>
                            We are proud of the ease of use on this site, find what you are looking for quickly.
                        </p>

                    </div>

                </div>
                <div class="col-md-3 col-sm-3">

                    <div>

                        <i class="fa fa-desktop fa-4x main-color"></i>


                       <a href="Account/Register.aspx"><h3>Register With us</h3></a>
                        
                        <p>
                            Sign up for an account and get started going to your favourite events today.
                        </p>

                    </div>

                </div>
                <div class="col-md-3 col-sm-3">

                    <div>

                        <i class="fa fa-folder fa-4x main-color"></i>


                        <h3>Video Tutorial </h3>
                        <p>
                           This will give you a detailed walkthrough of our site and how to use it.
                        </p>

                    </div>

                </div>
            </div>
            <div class="row ">
                <div class="col-md-6 col-sm-6">
                    <h3>Here at BookIT</h3>
                    <p>
                       We try and bring people together through their same love in music,
                        sport and other passions. We guarntee you will not have a better
                        time anywhere else than front row to your favourite band. So just BookIT.

                    </p>
                </div>
                <div class="col-md-6 col-sm-6">
                    <div class="panel panel-default">

                        <div class="panel-body">
                            <ul class="nav nav-pills" style="background-color: #ECECEC;">
                                <li class="active">
                                    <a href="#home-pills" data-toggle="tab">Sports</a>
                                </li>
                                <li class="">
                                    <a href="#profile-pills" data-toggle="tab">Music</a>
                                </li>
                                <li class="">
                                    <a href="#messages-pills" data-toggle="tab">Arts</a>
                                </li>
                                <li class="">
                                    <a href="#settings-pills" data-toggle="tab">Comedy</a>
                                </li>
                            </ul>

                            <div class="tab-content">
                                <div class="tab-pane fade  active in" id="home-pills">
                                    <h4>Sports</h4>
                                    <img src="assets/img/sport.jpg" height="300 px" width="300 px" />
                                </div>
                                <div class="tab-pane fade" id="profile-pills">
                                    <h4>Music</h4>
                                    <img src="assets/img/music.jpg" height="300 px" width="300 px"/>
                                </div>
                                <div class="tab-pane fade" id="messages-pills">
                                    <h4>Arts</h4>
                                    <img src="assets/img/arts.jpg" height="300 px" width="300 px" />
                                </div>
                                <div class="tab-pane fade" id="settings-pills">
                                    <h4>Comedy</h4>
                                    <img src="assets/img/comedy.jpg" height="300 px" width="300 px" />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>

            </div>
        </div>


    </section>

    <script src="assets/plugins/jquery-1.10.2.js"></script>   
    <script src="assets/plugins/bootstrap.js"></script>
    <script src="assets/plugins/4jquery.parallax-1.1.3.js"></script>
    <script src="assets/js/custom.js"></script>
</asp:Content>
