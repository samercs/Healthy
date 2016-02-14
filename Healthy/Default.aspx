<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Healthy.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
            <!-- Indicators -->
            <ol class="carousel-indicators">
                <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
                <li data-target="#carousel-example-generic" data-slide-to="1"></li>
                <li data-target="#carousel-example-generic" data-slide-to="2"></li>
            </ol>

            <!-- Wrapper for slides -->
            <div class="carousel-inner" role="listbox">
                <div class="item active">
                    <img src="images/1.jpg" class="img-responsive" alt="...">
                    
                </div>
                <div class="item">
                    <img src="images/3.jpg" class="img-responsive" alt="...">
                    
                </div>
                <div class="item">
                    <img src="images/2.jpg" class="img-responsive" alt="...">
                    
                </div>
            </div>

            
        </div>
    </div>
    <div class="body">
        <div class="section">
            <div class="article">
                <h2>Welcome to Cardio Center!</h2>
                <img src="images/heart.jpg" alt="">
                <p>
                    This website template has been designed by <a href="http://www.freewebsitetemplates.com/">Free Website Templates</a> for you, for free. You can replace all this text with your own text. You can remove any link to our website from this website template, you're free to use this website template without linking back to us. If you're having problems editing this website template, then don't hesitate to ask for help on the <a href="http://www.freewebsitetemplates.com/forums/">Forums</a>.
                </p>
            </div>
            <div class="aside">
                <b>Patients' testimonials</b>
                <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in vestibulum mi. Donec felis nunc, placerat quis varius quis, posuere sed velit. In convallis pulvinar rutrum. Suspendisse nec mi lectus, at fermentum felis.
                </p>
                <a href="#">-Mr.Robinson, Ohio</a>
            </div>
        </div>
    </div>
    <div class="footer">
        <div>
            <a href="doctors.html">
                <img src="images/doctors.jpg" alt=""></a>
            <h3>our doctors</h3>
            <p>
                Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus in vestibulum mi.
            </p>
        </div>
        <div>
            <a href="services.html">
                <img src="images/what-can-we-do.jpg" alt=""></a>
            <h3>what we can do for you</h3>
            <p>
                Suspendisse nec mi lectus, at fermentum felis. Pellentesque ipsum lectus, cursus non.
            </p>
        </div>
        <div>
            <a href="services.html">
                <img src="images/where-you-can-find.jpg" alt=""></a>
            <h3>where you can find us</h3>
            <p>
                Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.
            </p>
        </div>
    </div>
</asp:Content>
