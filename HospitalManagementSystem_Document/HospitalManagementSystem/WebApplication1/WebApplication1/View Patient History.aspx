<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View Patient History.aspx.cs" Inherits="ViewPatientHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="navbar.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style6
        {
            width: 273px;
            text-align: right;
        }
        .style7
        {
            text-align: right;
            width: 355px;
        }
        .style8
        {
            width: 355px;
        }
        .style10
        {
            width: 355px;
            height: 23px;
        }
        .style11
        {
            text-align: left;
            margin-left: 560px;
        }
        .style12
        {
            width: 355px;
            height: 23px;
        }
        .style13
        {
            text-align: right;
            margin-left: 560px;
            height: 23px;
            width: 273px;
        }
        .style14
        {
            text-align: right;
            margin-left: 560px;
            width: 273px;
        }
       
        
    </style>
      <script type="text/javascript" language="javascript">
          function log() {
              if (confirm("Are you sure?") == true) {
                  return true;
              }
              else {
                  return false;
              }
          }
          function validation() {
              flag = 1;
              var pat_id = document.getElementById("<%=txt_Patientid_VPH.ClientID %>");
              var pat_id_temp = pat_id.value;
              var fname = document.getElementById("<%=txt_Fname_VPH.ClientID %>");
              var fname_temp = fname.value;
              var re = /^([a-zA-Z])+$/;
              var lname = document.getElementById("<%=txt_Lname_VPH.ClientID %>");
              var lname_temp = lname.value;
              var re1 = /^([a-zA-Z0-9])+$/;
              var re2 = /^([a-zA-Z])+$/;
              if (pat_id_temp == "" && (fname_temp == "" && lname_temp == "")) {
                  flag = 1;
                  alert("Please enter patient id or first name and last name");
              }
              else if (pat_id_temp != "" && ((fname_temp == "" && lname_temp != "") || (fname_temp != "" && lname_temp == "") || (fname_temp != "" && lname_temp != ""))) {
                  flag = 1;
                  alert("Please enter either patient id or first name and last name");

              }
              else if (pat_id_temp != "" && (fname_temp == "" && lname_temp == "")) {
                  if (!re1.test(pat_id_temp)) {
                      flag = 1;
                      alert("Please enter valid patient id");
                  }
                  else {
                      flag = 0;
                  }

              }
              else if (pat_id_temp == "" && (fname_temp != "" && lname_temp != "")) {

                  if (!re.test(fname_temp)) {
                      flag = 1;
                      alert("Please enter valid first name");

                  }
                  else {

                      if (lname_temp != " ") {

                          if (!re2.test(lname_temp)) {
                              flag = 1;
                              alert("Please enter valid last name");
                          }
                          else {
                              flag = 0;
                          }

                      }
                      else {
                          flag = 1;
                          alert("Please enter last name");
                      }
                  }

              }






              if (flag == 0) {
                  return true;
              }
              else {
                  return false;
              }
          }





          function Reset1_onclick() {

          }

      </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div id="navbar" style="background-color: #05519D">
    <div id="holder">
        
    <ul >
        <li ><a href="Home.aspx"  >Home</a></li>
     <li ><a href="Add Patient.aspx" >Add Patient</a></li>
    <li><a href="Add Physician.aspx">Add Physician</a></li>
    <li><a href="Physician Search.aspx">Physician Search</a></li>
    <li><a href="Patient Diagnosis Details.aspx">Patient Diagnosis Details</a></li>
    <li><a href="View Patient History.aspx" id="onlink">View Patient History</a></li>
    </ul>
    </div>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <table class="style1" style="margin-left: 240px; width: 73%;">
        <tr>
            <td class="style6">
                Patient Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
                <br />
            </td>
            <td class="style7" style="text-align: left">
                <asp:TextBox ID="txt_Patientid_VPH" runat="server" Width="180px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                or&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style14">
                First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style8">
                <asp:TextBox ID="txt_Fname_VPH" runat="server" Width="180px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style14">
                Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                <br />
            </td>
            <td class="style8">
                <asp:TextBox ID="txt_Lname_VPH" runat="server" Width="180px"></asp:TextBox>
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td class="style14">
                &nbsp;</td>
            <td class="style11">
        <asp:Button ID="Submit_VPH" runat="server" Text="Submit" 
            onclick="Submit_VPH_Click" OnClientClick="return validation();" 
                    CssClass="Buttonclass" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
        <tr>
            <td class="style13">
                Symptoms&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            <td class="style10">
                <asp:DropDownList ID="DropSymptoms" runat="server" Width="200px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style13">
                &nbsp;</td>
            <td class="style12">
                <asp:Button ID="btn_search_vph" runat="server" onclick="btn_search_vph_Click" 
                    Text="Search" CssClass="Buttonclass" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
    </table>
    <div style="margin-left: 680px">
        <asp:Button ID="Logout_btn" runat="server" 
            style="z-index: 1; left: 1263px; top: 19px; position: absolute" 
            Text="Logout" OnClientClick="return log();" onclick="Logout_btn_Click" 
            CssClass="Buttonclass" />
        &nbsp;&nbsp;&nbsp;
        <br />
        <br />
    </div>
    
    <p>
        &nbsp;</p>
    <asp:GridView ID="search_VPH_grid" runat="server" CellPadding="4" 
        ForeColor="#333333" GridLines="None" 
        style="z-index: 1; left: 157px; top: 731px; position: absolute; height: 132px; width: 372px" 
        Width="200px">
        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>


