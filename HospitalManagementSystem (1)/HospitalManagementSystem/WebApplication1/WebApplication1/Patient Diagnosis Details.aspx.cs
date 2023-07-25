using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BL;
using BO;
using DA;
using System.Data.SqlClient;
using System.Configuration;

public partial class PatientDiagnosisDetails : System.Web.UI.Page
{
    
    PDD_BO bo = new PDD_BO();
    PDD_BL bl = new PDD_BL();
   
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (DropDownList2.SelectedValue.ToString() == "Select" || DropDownList2.SelectedValue.ToString() == "No")
        {
            DateOfFollowUp_PDD.Text = "01/01/2011";
            DateOfFollowUp_PDD.Enabled = false;

        }
    }
   
    protected void Submit_PDD_Click(object sender, EventArgs e)
    {
        bo.physician_id = PatientId_PDD.Text;
        int r = bl.check_bll(bo);
        if (r == 1)
        {
            bo.diagnosisid = DiagnosisID_PDD.Text;
            bo.symptoms = Symptoms_PDD.Text;
            bo.diagnosisprovided = DiagnosisProvided_PDD.Text;
            bo.physician =PhyName_txt.Text ;
           
            
            String MyString = DateOfDiagnosis_PDD.Text;
            DateTime MyDateTime = new DateTime();
            MyDateTime = DateTime.ParseExact(MyString, "dd/MM/yyyy", null);
            String MyString_new = MyDateTime.ToString("yyyy/MM/dd");
            bo.dt = Convert.ToDateTime(MyString_new); 

            bo.followup = DropDownList2.SelectedValue;

            String MyString1 = DateOfFollowUp_PDD.Text;
            DateTime MyDateTime1 = new DateTime();
            MyDateTime1 = DateTime.ParseExact(MyString, "dd/MM/yyyy", null);
            String MyString_new1 = MyDateTime.ToString("yyyy/MM/dd");
            bo.followupdate = Convert.ToDateTime(MyString_new1);


            bo.card = CardNo_PDD.Text;

            bo.mode = DropModeOfPay_PDD.SelectedValue;
            bo.bill = BillAmount_PDD.Text;

        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Not a Registered Patient');", true);
        }
        bo.diagnosisid = DiagnosisID_PDD.Text;
        bo.symptoms = Symptoms_PDD.Text;
        bo.diagnosisprovided = DiagnosisProvided_PDD.Text;
      


        bo.physician = PhyName_txt.Text;
     
        String MyString3 = DateOfDiagnosis_PDD.Text;
        DateTime MyDateTime3 = new DateTime();
        MyDateTime3 = DateTime.ParseExact(MyString3, "dd/MM/yyyy", null);
        String MyString_new3 = MyDateTime3.ToString("yyyy/MM/dd");
        bo.dt = Convert.ToDateTime(MyString_new3);


        bo.followup = DropDownList2.SelectedValue;

  
        String MyString4 = DateOfFollowUp_PDD.Text;
        DateTime MyDateTime4 = new DateTime();
        MyDateTime4 = DateTime.ParseExact(MyString4, "dd/MM/yyyy", null);
        String MyString_new4 = MyDateTime4.ToString("yyyy/MM/dd");
        bo.followupdate = Convert.ToDateTime(MyString_new4);

        bo.card = CardNo_PDD.Text;

        bo.mode = DropModeOfPay_PDD.SelectedValue;
        bo.bill = BillAmount_PDD.Text;

      
        try
        {

            int rev = bl.SaveUserregisrationBL(bo);
            
            if (rev > 0)
            {
                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList2.SelectedValue.ToString()=="Yes")
        {
            DateOfFollowUp_PDD.Enabled = true;
        }
        else
        {
         
            DateOfFollowUp_PDD.Enabled = false;
        }
    }

    protected void Logout_btn_Click(object sender, EventArgs e)
    {
        Session.Remove("Id");
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
            
    }

  
   

  
}