<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" Inherits="PatientDiagnosisDetails" Codebehind="Patient Diagnosis Details.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="navbar.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style5
    {
        width: 443px;
        text-align: right;
        margin-left: 450px;
    }
        .style6
        {
            width: 244px;
            text-align: right;
        }
        .style7
        {
            width: 166px;
        }
        #Reset1
        {
            z-index: 1;
            left: 824px;
            top: 1048px;
            position: absolute;
            height: 26px;
            width: 49px;
        }
        .style8
        {
            text-align: left;
            width: 574px;
        }
        .style9
        {
            width: 166px;
            height: 42px;
        }
        .style10
        {
            height: 42px;
        }
    </style>
    <script language="javascript" type="text/javascript">

        function log() {
            if (confirm("Are you sure?") == true) {
                return true;
            }
            else {
                return false;
            }
        }
        function validate() {
            var u="";
            var summary = "";

            summary += isvaliduser();
            summary += isvaliddiagid();
            summary += isvalidsymptom();
            summary += isvaliddiagnosisprovided();
            summary += isvalidphysician();
            summary += isvaliddate();
            summary += isvalidfollowup();
          summary += isvalidfollowdate();
            summary += isvalidcard();
            summary += isvalidmode();
            summary += isvalidbill(); 


            if (summary != "") {

                alert(summary);

                return false;

            }

            else {

                return true;

            }

        }

        function isvaliduser() {

            var uid;

            var temp = document.getElementById("<%=PatientId_PDD.ClientID %>");

            uid = temp.value;
            ptID = /^([a-zA-Z0-9])+$/;
            if (uid == "") {

                return ("Please Enter UserName" + "\n");

            }
            else if (!uid.match(ptID)) {

                return("Invalid patient Id" + "\n");

                

            }
            else {

                return "";

            }

        }

        function isvaliddiagid() {

            var uid;

            var temp = document.getElementById("<%=DiagnosisID_PDD.ClientID %>");

            uid = temp.value;
            diagID = /^([a-zA-Z0-9])+$/;
            if (uid == "") {

                return ("Please enter diagnosis id" + "\n");

            }
            else if (!uid.match(diagID)) {

                return ("Invalid diagnosis Id" + "\n");



            }
            else {

                return "";

            }

        }

        function isvalidsymptom() {

            var uid;

            var temp = document.getElementById("<%=Symptoms_PDD.ClientID %>");

            uid = temp.value;
            symptom = /^([a-zA-Z0-9])+$/;
            if (uid == "") {

                return ("Please enter symptoms" + "\n");

            }
            else if (!uid.match(symptom)) {

                return ("Invalid symptoms" + "\n");
            }

            else {

                return "";

            }

        }
        function isvaliddiagnosisprovided() {

            var uid;

            var temp = document.getElementById("<%=DiagnosisProvided_PDD.ClientID %>");

            uid = temp.value;
            diagprovided = /^([a-zA-Z])+$/;
            if (uid == "") {

                return ("Please enter diagnosis provided details" + "\n");

            }
            else if (!uid.match(diagprovided)) {

                return ("Invalid diagnosis details" + "\n");
            }
            else {

                return "";

            }

        }
        function isvalidphysician() {

            var uid;
            var temp = document.getElementById("<%=PhyName_txt.ClientID %>");
            uid = temp.value;
            if (uid == "Select Physician") {

                return ("Please enter physician provided details" + "\n");

            }
           
            else {

                return "";

            }
           

        }
        function isvaliddate() {

            var uid;

            var temp = document.getElementById("<%=DateOfDiagnosis_PDD.ClientID %>");

            uid = temp.value;
            diagdate = /(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$/;
            if (uid == "") {

                return ("Please enter diagnosis date" + "\n");

            }
            else if (!uid.match(diagdate)) {

                return ("Invalid date" + "\n");
            }
            else {

                return "";

            }

        }
        function isvalidfollowup() {

            var uid;

            var temp = document.getElementById("<%=DropDownList2.ClientID %>");

            uid = temp.value;
            u = uid;
            if (uid == "Select") {
                
                return ("Please select option" + "\n");

            }
           
            else {
                
                return "";

            }

        }
       
        function isvalidfollowdate() {

            var uid;

            var temp = document.getElementById("<%=DateOfFollowUp_PDD.ClientID %>");

            uid = temp.value;
            followdate = /(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$/;
            if (uid == ""&&u=="Yes") {

                return ("Please enter follow up date" + "\n");

            }
            else if (uid == "" && (u == "No"||u=="Select")) {

            return "";

            }
            else if (!uid.match(followdate)) {

                return ("Invalid date" + "\n");
            }
            else {

                return "";

            }

        }
        
        function isvalidcard() {

            var uid;

            var temp = document.getElementById("<%=CardNo_PDD.ClientID %>");

            uid = temp.value;
            card = /^([0-9])+$/;
            if (uid == "") {

                return ("Please enter card number" + "\n");

            }
            else if (!uid.match(card)) {

                return ("Invalid card number" + "\n");
            }
            else {

                return "";

            }

        }
        function isvalidmode() {

            var uid;

            var temp = document.getElementById("<%=DropModeOfPay_PDD.ClientID %>");

            uid = temp.value;
            
            if (uid == "Select an option") {

                return ("Please select mode" + "\n");

            }
          
            else {

                return "";

            }

        }
        function isvalidbill() {

            var uid;

            var temp = document.getElementById("<%=BillAmount_PDD.ClientID %>");

            uid = temp.value;
            bill = /^([0-9])+$/;
            if (uid == "") {

                return ("Please enter amount" + "\n");

            }
            else if (!uid.match(bill)) {

                return ("Invalid bill amount" + "\n");
            }
            else {

                return "";

            }

        }

//        function DisableEnable() {
//            var DropDown_Total = document.getElementById("<%=DropDownList2.ClientID %>")

//            var Textbox_Date = document.getElementById("<%= DateOfFollowUp_PDD.ClientID %>")

//            if (DropDown_Total.options[DropDown_Total.selectedIndex].text == "yes") {

//                Textbox_Date.disabled = true;
//            }

//            else {
//                Textbox_Date.disabled = false;
//            }

//         
//        }



        function Reset1_onclick() {

        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<div id="navbar" style="background-color: #05519D">
    <div id="holder">
        
    <ul >
        <li ><a href="Home.aspx"  >Home</a></li>
     <li ><a href="Add Patient.aspx">Add Patient</a></li>
    <li><a href="Add Physician.aspx">Add Physician</a></li>
    <li><a href="Physician Search.aspx">Physician Search</a></li>
    <li><a href="Patient Diagnosis Details.aspx" id="onlink">Patient Diagnosis Details</a></li>
         <li><a href="View Patient History.aspx">View Patient History</a></li>
    </ul>
    </div>
    </div>
    <p>
         &nbsp;</p>
     <p>
         &nbsp;</p>
     <table class="style1">
         <tr>
             <td class="style6">
                 Patient Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="PatientId_PDD" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style6">
                 Diagnosis Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="DiagnosisID_PDD" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style6">
                 Symptoms&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="Symptoms_PDD" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style6">
                 Diagnosis Provided&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="DiagnosisProvided_PDD" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style8">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PhysicianVisited&nbsp; 
                 <br />
                 <br />
             </td>
             <td class="style2">
                 
                 <br />
                 <asp:TextBox ID="PhyName_txt" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style6">
                 Date Of Diagnosis&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                  <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="DateOfDiagnosis_PDD" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style6">
                 Follow-up Required&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                     onselectedindexchanged="DropDownList2_SelectedIndexChanged" Width="180px">
                     <asp:ListItem>Select</asp:ListItem>
                     <asp:ListItem>Yes</asp:ListItem>
                     <asp:ListItem>No</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style6">
                 Date of Follow-Up&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="DateOfFollowUp_PDD" runat="server" Width="180px" Visible="True"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
     </table>
     <p style="margin-left: 680px">
&nbsp;&nbsp;&nbsp;
     </p>
     <p style="margin-left: 680px">
         <asp:Button ID="Logout_btn" runat="server" 
             style="z-index: 1; left: 1263px; top: 19px; position: absolute" 
             Text="Logout" onclick="Logout_btn_Click"  OnClientClick="return log();" 
             CssClass="Buttonclass" />
    </p>
     <table class="style5">
         <tr>
             <td class="style7">
                 Card Number&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:TextBox ID="BillAmount_PDD" runat="server" 
                     
                     style="z-index: 1; left: 636px; top: 1013px; position: absolute; width: 154px" 
                     Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style9">
                 Mode Of Payment&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style10">
                 <asp:TextBox ID="CardNo_PDD" runat="server" 
                     
                     style="z-index: 1; left: 633px; top: 926px; position: absolute; width: 150px" 
                     Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style7">
                 Bill Amount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td>
                 <asp:DropDownList ID="DropModeOfPay_PDD" runat="server" 
                     
                     style="z-index: 1; left: 636px; top: 971px; position: absolute; width: 130px" 
                     Width="180px">
                     <asp:ListItem>Select an option</asp:ListItem>
                     <asp:ListItem>cash</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <br />
             </td>
         </tr>
     </table>
     <input id="Reset1" type="reset" value="reset" 
        onclick="return Reset1_onclick()" class="Buttonclass"/><p style="margin-left: 680px">
         <asp:Button ID="Submit_PDD" runat="server" Text="Submit" 
             onclick="Submit_PDD_Click" OnClientClick=" return validate()" 
             CssClass="Buttonclass" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

