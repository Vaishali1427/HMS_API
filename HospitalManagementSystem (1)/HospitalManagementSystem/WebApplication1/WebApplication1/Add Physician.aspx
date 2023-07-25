<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" Inherits="AddPhysician" Codebehind="Add Physician.aspx.cs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="navbar.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
    .style5
    {
        width: 162px;
    }
    .style6
    {
            text-align: left;
            width: 142px;
        }
        
</style>
<script type="text/javascript" language="javascript">

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
    function validate() {
        flag = 1;
        var fname = document.getElementById("<%=txt_Fname_APhy.ClientID %>");
        var fname_temp = fname.value;
        var re = /^([a-zA-Z])+$/;
        var lname = document.getElementById("<%=txt_Lname_Aphy.ClientID %>");
        var lname_temp = lname.value;
        var dept = document.getElementById("<%=DropDept_APhy.ClientID %>");
        var dept_temp = dept.value;
        var qual = document.getElementById("<%=txt_Education_APhy.ClientID %>");
        var qual_temp = qual.value;
        var qual_re = /^([a-zA-Z' '])+$/;
        var yoe_re = /^([0-9])+$/;
        var yoe = document.getElementById("<%=txt_Experience_APhy.ClientID %>");
        var yoe_temp = yoe.value;
        var state = document.getElementById("<%=DropState_APhy.ClientID %>");
        var state_temp = state.value;
        var ins = document.getElementById("<%=DropInsurance_APhy.ClientID %>");
        var ins_temp = ins.value;
        if (fname_temp == "" || lname_temp == "" || qual_temp == "" || yoe_temp == "" || dept_temp == "" || state_temp == "" || ins_temp == "") {
            flag = 1;
            alert("Please enter all the fields");
        }
        else if (!re.test(fname_temp)) {
            flag = 1;
            alert("first name should contain only alphabets");
        }
        else {
            flag = 0;
            if (!re.test(lname_temp)) {
                flag = 1;
                alert("Last name should contain only alphabets");
            }
            else {
                flag = 0;
                if (!qual_re.test(qual_temp)) {
                    flag = 1;
                    alert("Qualifiction field should contain only alphabets and spaces");
                }
                else {
                    flag = 0;
                    if (!yoe_re.test(yoe_temp)) {
                        flag = 1;
                        alert("Experience field should contain only numbers");
                    }
                    else {
                        flag = 0;
                        if (dept_temp == "Select Department ") {
                            flag = 1;
                            alert("Select a department");
                        }
                        else {
                            flag = 0;
                            if (state_temp == "select state") {
                                flag = 1;
                                alert("Please select a state");
                            }
                            else {
                                flag = 0;
                                if (ins_temp == "Select Insurance") {
                                    flag = 1;
                                    alert("Please select a insurance plan");
                                }
                                else {
                                    flag = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
        
      

//        if (dept_temp == "Select Department ") {
//            flag = 1;
//            alert("Select a department");
//        }

//        if (state_temp == "select state") {
//            flag = 1;
//            alert("Please select a state");
//        }
//        if (ins_temp == "Select Insurance") {
//            flag = 1;
//            alert("Please select a insurance plan");
//        }
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
    <li><a href="Add Physician.aspx" id="onlink">Add Physician</a></li>
        <li><a href="Physician Search.aspx">Physician Search</a></li>
    <li><a href="Patient Diagnosis Details.aspx">Patient Diagnosis Details</a></li>
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
             <td class="style4">
                 First Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style5">
                 <asp:TextBox ID="txt_Fname_APhy" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
             <td class="style7">
                 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="AddPhy_Label1" runat="server" ForeColor="#05519D"></asp:Label>
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style4">
                 Last Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style5">
                 <asp:TextBox ID="txt_Lname_Aphy" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
             <td class="style7">
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style4">
                 Department&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style5">
                 <asp:DropDownList ID="DropDept_APhy" runat="server" Width="180px">
                     <asp:ListItem>Select Department</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <br />
             </td>
             <td class="style7">
                 <br />
                 <br />
             </td>
         </tr>
         <tr>
             <td class="style4">
                 Educational Qualification&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style5">
                 <asp:TextBox ID="txt_Education_APhy" runat="server" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
             <td class="style7">
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style4">
                 Years Of Experience&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style5">
                 <asp:TextBox ID="txt_Experience_APhy" runat="server" onkeypress="return isNumber(event)" Width="180px"></asp:TextBox>
                 <br />
                 <br />
             </td>
             <td class="style7">
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style4">
                 State&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style5">
                 <asp:DropDownList ID="DropState_APhy" runat="server" Width="180px">
                     <asp:ListItem>Select a State</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <br />
             </td>
             <td class="style7">
                 &nbsp;</td>
         </tr>
         <tr>
             <td class="style3" style="text-align: right">
                 Insurance Plan&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
                 <br />
             </td>
             <td class="style6">
                 <asp:DropDownList ID="DropInsurance_APhy" runat="server" Width="180px">
                     <asp:ListItem>Choose a Plan</asp:ListItem>
                 </asp:DropDownList>
                 <br />
                 <br />
             </td>
             <td class="style2">
             </td>
         </tr>
     </table>
     <div style="margin-left: 640px">
         <br />
         <asp:Button ID="btn_Register_APhy" runat="server" Text="Register" OnClientClick=" return validate();"
             onclick="btn_Register_APhy_Click" CssClass="Buttonclass"  />
&nbsp;&nbsp;&nbsp;&nbsp;
         <input id="Rest_APhy" type="reset" value="reset" class="Buttonclass" /><br />
         <asp:Button ID="Logout_btn" runat="server" 
             style="z-index: 1; left: 1263px; top: 19px; position: absolute" 
             Text="Logout" OnClientClick="return log();" onclick="Logout_btn_Click" 
             CssClass="Buttonclass" />
         <asp:GridView ID="GridPhyId_APhy" runat="server" CellPadding="4" 
             ForeColor="#333333" GridLines="None">
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
         <br />
         <br />
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

