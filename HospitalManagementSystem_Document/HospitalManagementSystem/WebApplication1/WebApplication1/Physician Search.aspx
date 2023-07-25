<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Physician Search.aspx.cs" Inherits="Physician_search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="navbar.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
    .style5
    {
        text-align: right;
    }
        .style6
        {
            width: 450px;
        }
        .ButtonClass
        {
            cursor: pointer;
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
            var dept = document.getElementById("<%=DropDept_PS.ClientID %>");
            var dept_temp = dept.value;
            var state = document.getElementById("<%=Dropstate_ps.ClientID %>");
            var state_temp = state.value;
            var insurance = document.getElementById("<%=DropinsurancePlan_PS.ClientID %>");
            var insurance_temp = insurance.value;
           
            if (state_temp == "select state") {
                flag = 1;
                alert("Select a state");
            }
            else {
                flag = 0;
                if (insurance_temp == "Select Insurance") {
                    flag = 1;
                    alert("Select an insurance plan");
                }
                else {
                    flag = 0;
                    if (dept_temp == "Select Department ") {
                        flag = 1;
                        alert("Select a department");
                    }
                }
            }
            if (flag == 1) {
                return false;
            }
            else {

                return true;
            }
        
        
        
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
    <li><a href="Physician Search.aspx" id="onlink">Physician Search</a></li>
           <li><a href="Patient Diagnosis Details.aspx">Patient Diagnosis Details</a></li>
    <li><a href="View Patient History.aspx">View Patient History</a></li>
    </ul>
    </div>
    </div>
   <p style="margin-left: 320px">
         &nbsp;</p>
     <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <table class="style1" style="width: 51%; margin-left: 400px">
             <tr>
                 <td class="style5">
                     State&nbsp;&nbsp;&nbsp; <br />
                     <br />
                 </td>
                 <td class="style6">
                     <asp:DropDownList ID="Dropstate_ps" runat="server" Width="200px">
                         <asp:ListItem>Select State</asp:ListItem>
                     </asp:DropDownList>
                     <br />
                     <br />
                 </td>
             </tr>
             <tr>
                 <td class="style5">
                     Insurance Plan&nbsp;&nbsp;&nbsp; <br />
                     <br />
                 </td>
                 <td class="style6">
                     <asp:DropDownList ID="DropinsurancePlan_PS" runat="server" Width="200px">
                     </asp:DropDownList>
                     <br />
                     <br />
                 </td>
             </tr>
             <tr>
                 <td class="style5">
                     Department&nbsp;&nbsp;&nbsp; <br />
                     <br />
                 </td>
                 <td class="style6">
                     <asp:DropDownList ID="DropDept_PS" runat="server" Width="200px">
                     </asp:DropDownList>
                     <br />
                     <br />
                 </td>
             </tr>
         </table>
     </p>
     <div style="margin-left: 640px">
         <asp:Button ID="Search_PS" runat="server" Text="Search" 
             onclick="Search_PS_Click" OnClientClick="return validation();" 
             CssClass="Buttonclass" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;<input id="Reset_PS" type="reset" value="reset" 
             class="ButtonClass"  />&nbsp;&nbsp;&nbsp;&nbsp;
         </div>
     
         <asp:Button ID="Logout_btn" runat="server" 
             style="z-index: 1; left: 1263px; top: 19px; position: absolute" 
        Text="Logout" OnClientClick="return log();" onclick="Logout_btn_Click" 
        CssClass="Buttonclass" />
    
     <asp:Panel ID="Panel1" runat="server" Height="169px">
         <asp:GridView ID="SearchView_PS" runat="server" Width="200px" 
             
             style="z-index: 1; left: 214px; top: 684px; position: absolute; height: 133px; width: 200px" 
             CellPadding="4" ForeColor="#333333" GridLines="None">
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
     </asp:Panel>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

