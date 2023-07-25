<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication9.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript" src="Scripts/jquery-1.4.1.min.js"></script>
<script type="text/javascript">
    function log() {
        if (confirm("Are you sure?") == true) {
            return true;
        }
        else {
            return false;
        }
    }
    function slideShow() {
        var $active = $('#s_show IMG.active');
        if ($active.length == 0) $active = $('#s_show IMG:last');
        var $next = $active.next().length ? $active.next()
        : $('#s_show IMG:first');
        $active.addClass('last-active');
        $next.css({ opacity: 0.0 })
        .addClass('active')
        .animate({ opacity: 1.0 }, 1000, function () {
            $active.removeClass('active last-active');
        });
    }

    $(function () {
        setInterval("slideShow()", 3000);
    });
</script>
<style type="text/css">
#s_show {
    position:relative;
    height:350px;
    background-color:White;
    border:Black;
}
#s_show IMG {
    border:White;
        position:absolute;
        
    top:63px;
    left:292px;
        z-index:8;
        opacity:0.0;
        height: 364px;
        width: 60%;
        right: 141px;
    }
#s_show IMG.active {
    z-index:10;
    opacity:1.0;
}
 
#s_show IMG.last-active {
    z-index:9;
}
    .style5
    {
        width: 100%;
    }
    
    .style6
    {
        color: #FFFFFF;
        text-align: center;
        font-size: medium;
        height: 40px;
    }
    
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div id="navbar" style="background-color: #05519D">
    <div id="holder">
        
    <ul >
        <li ><a href="Home.aspx" id="onlink" >Home</a></li>
     <li ><a href="Add Patient.aspx" >Add Patient</a></li>
         <li><a href="Add Physician.aspx">Add Physician</a></li>
    <li><a href="Physician Search.aspx">Physician Search</a></li>
    <li><a href="Patient Diagnosis Details.aspx">Patient Diagnosis Details</a></li>
    <li><a href="View Patient History.aspx">View Patient History</a></li>
  
    </ul>

    </div>
     
    </div>
<div id="s_show">
    
    <br />
    <br />
    <br />
    <br />
    <table style="height: 215px; width: 254px; margin-top: 0px;">
    <tr>
    <td style="background-color: #05519D" class="style6">
        <strong>Latest Updates</strong></td>
    </tr>
    <tr>
    <td>
    <marquee direction="up" scrolldelay=200 >
    <p>
    World Hypertension Day (WHD) is observed on 17th of May to raise awareness on Hypertension.
     The theme of WHD is 'Know Your Numbers' with an aim 
     to increase awareness on high blood pressure.
    </p>
    <p>-----------------------------------------</p>
    <p>
    The Center for Liver Diseases and Transplantation, Aikya Hospitals, is equipped with the state-of-the-art technology
     for liver surgery and has successfully performed over 450 liver transplants so far.</p>
     <p>-----------------------------------------</p></marquee><asp:Button ID="Logout_btn" 
            runat="server" 
            style="z-index: 1; left: 1263px; top: -355px; position: absolute; opacity:60px;"  
            Text="Logout" onclick="Logout_btn_Click" OnClientClick="return log();" 
            CssClass="Buttonclass" />
        </td>
    </tr>
    </table>
    <br />
    <table class="style5">
        <tr>
            
            <td><img src="images/4.jpg" alt="img5" />
    <%--<img src="images/hospital-erp-india.jpg" alt="img1" />
    <img src="Images/Features_large.jpg" alt="img1" width="50px" />
    <img src="Images/5.jpg"  alt="img4" width="50px"/>
    <img src="Images/8.jpg" alt="img2" width="50px"/>--%><img src="Images/Chhatrapati_Shivaji_Terminus_(Victoria_Terminus).jpg" alt="img" class="active" />
                <img src="Images/465702013-600x330.jpg" alt="img1"/>
                <img src="Images/photo_1796.jpg" alt="img2" />
                <img src="Images/SPP-EHL-_A_4509053.jpg" alt="img3"/>
                <img src="Images/untitled.png" alt="img4" />
    <img src="images/3.jpg" alt="img6"  ;style="background-color: #00FFFF; width: 96%;"/>
    
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    
</div>
<h1 style="font-family: 'Comic Sans MS'; font-size: xx-large; color: Navy; background-color:White; position: absolute;"></h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
