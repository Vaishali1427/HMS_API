<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" Inherits="AddPatient" Codebehind="Add Patient.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="navbar.css" rel="stylesheet" type="text/css" />
     
        <script language="javascript" type="text/javascript">

            function isNumber(evt) {
                evt = (evt) ? evt : window.event;
                var charCode = (evt.which) ? evt.which : evt.keyCode;
                if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                    alert("Enter only numbers");
                    return false;
                }
                return true;
            }
            function log() {
                if (confirm("Are you sure?") == true) {
                    return true;
                }
                else {
                    return false;
                }
            }

            function userValid() {

                var fname = document.getElementById("<%=txt_Fname_AP.ClientID %>");
                var fname_temp = fname.value;
                var fname_re = /^([a-zA-Z' '])+$/;
                var doj = document.getElementById("<%=txt_DOB_AP.ClientID %>");
                var doj_temp = doj.value;
                var lname = document.getElementById("<%=txt_Lname_AP.ClientID %>");
                var lname_temp = lname.value;
                var lname_re = /^([a-zA-Z' '])+$/;
                var email = document.getElementById("<%=txt_Mail_AP.ClientID %>");
                var email_temp = email.value;
                var email_re = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/;
                var contact = document.getElementById("<%=txt_Phno_AP.ClientID %>");
                var contact_temp = contact.value;
                var contact_re = /^\d{10}$/;
//                var state = document.getElementById("<%=DropState_AP.ClientID %>");
//                var state_temp = state.value;



                if (fname_temp == "" || doj_temp == "" || lname_temp == "" || email_temp == "" || contact_temp == "") {
                    flag = 1;
                    alert("All fields are Mandatory");
                }
                else {
                    if (!fname_re.test(fname_temp)) {
                        flag = 1;
                        alert("first name should contain only alphabets");
                        
                    }
                    else {

                        if (!lname_re.test(lname_temp)) {
                            flag = 1;
                            alert("last name should contain only alphabets");
                        }
                        else {

                            if (!email_re.test(email_temp)) {
                                flag = 1;
                                alert("invalid email id");
                            }
                            else {

                                if (!contact_re.test(contact_temp)) {
                                    flag = 1;
                                    alert("invalid phone number");
                                }
                              
                                    else {
                                        flag = 0;
                                    }
                                }
                                if (flag == 1) {
                                    return false;
                                }
                                else {
                                    return true;
                                }
                            }
                        }
                    }
                }

            
</script>
   
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div id="navbar" style="background-color: #05519D">
    <div id="holder">
        
    <ul >
        <li ><a href="Home.aspx"  >Home</a></li>
     <li ><a href="Add Patient.aspx" id="onlink">Add Patient</a></li>
         <li><a href="Add Physician.aspx">Add Physician</a></li>
    <li><a href="Physician Search.aspx">Physician Search</a></li>
    <li><a href="Patient Diagnosis Details.aspx">Patient Diagnosis Details</a></li>
    <li><a href="View Patient History.aspx">View Patient History</a></li>
    </ul>

    </div>
     
    </div>
    
   <br />
    <br />
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" 
        BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" 
        Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" 
        onselectionchanged="Calendar1_SelectionChanged" ShowGridLines="True" 
        style="z-index: 1; left: 862px; top: 565px; position: absolute; height: 132px; width: 165px">
        <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
        <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
        <OtherMonthDayStyle ForeColor="#CC9966" />
        <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
        <SelectorStyle BackColor="#FFCC66" />
        <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" 
            ForeColor="#FFFFCC" />
        <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
    </asp:Calendar>
    <br />
   
    
    
    <table class="style1" style="width: 93%">
        <tr>
            <td class="style4">
                First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style3">
                <asp:TextBox ID="txt_Fname_AP" runat="server" Width="180px"></asp:TextBox>
                <br />
                <br />
            </td>
            <td>
                <br />
                <asp:Label ID="AddPat_Label1_AP" runat="server" ForeColor="#05519D"></asp:Label>
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style4">
                Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <asp:ImageButton ID="ImageButton1" runat="server" 
                    ImageUrl="~/Images/images.jpg" onclick="ImageButton1_Click" 
                    style="z-index: 1; left: 832px; top: 564px; position: absolute; height: 24px" />
                <br />
            </td>
            <td class="style3">
                <asp:TextBox ID="txt_Lname_AP" runat="server" Width="180px"></asp:TextBox>
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Date Of Birth&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style3">
                <asp:TextBox ID="txt_DOB_AP" runat="server" Width="180px" Enabled="False"></asp:TextBox>
                <br />
                <br />
            </td>
            <td>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style4">
                Email Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style3">
                <asp:TextBox ID="txt_Mail_AP" runat="server" Width="180px"></asp:TextBox>
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Contact Number&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style3">
                <asp:TextBox ID="txt_Phno_AP" runat="server" onkeypress="return isNumber(event)" Width="180px"></asp:TextBox>
                <br />
                <br />
            </td>
            <td>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style4">
                State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style3">
                <asp:DropDownList ID="DropState_AP" runat="server" Width="180px">
                    <asp:ListItem>Select a State</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style4">
                Insurance Plan&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style3">
                <asp:DropDownList ID="DropInsurance_AP" runat="server" Width="180px">
                    <asp:ListItem>Choose a Plan</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    &nbsp;&nbsp;&nbsp;
    <div style="margin-left: 440px">
        <p style="margin-left: 280px">
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Submit_AP" runat="server" Text="Submit" 
                onclick="Submit_AP_Click" OnClientClick="return userValid();" 
                CssClass="Buttonclass" />
        &nbsp;&nbsp;&nbsp; &nbsp;<input id="Reset_AP" type="reset" value="reset" 
                class="Buttonclass" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </div>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Logout_btn" runat="server" 
        style="z-index: 1; left: 1263px; top: 19px; position: absolute; width: 57px"  
        Text="Logout" onclick="Logout_btn_Click" OnClientClick="return log()" 
        CssClass="Buttonclass" />
    <br />
    <table class="style1">
        <tr>
            <td class="style4">
                &nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

