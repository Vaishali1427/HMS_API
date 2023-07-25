using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using BusinessObject;
using BusinessLogic;

public partial class ViewPatientHistory : System.Web.UI.Page
{
//    SqlConnection con = new SqlConnection("Data Source=PC180147\\SQLEXPRESS;Initial Catalog=hms1;User ID=sa;Password=password-1");
    
    PatientHistory_BL PatHistory_bl = new PatientHistory_BL();
    PatientHistory_BO PatHistory_bo = new PatientHistory_BO();
    string s1 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    
    protected void Submit_VPH_Click(object sender, EventArgs e)
    {
        PatHistory_bo.patient_id = txt_Patientid_VPH.Text;
        PatHistory_bo.Fname = txt_Fname_VPH.Text;
        PatHistory_bo.lname = txt_Lname_VPH.Text;
       
        try
        {
            SqlDataAdapter symptomData = PatHistory_bl.View1(PatHistory_bo);
            DataTable symptomDataDetails = new DataTable();
            symptomData.Fill(symptomDataDetails);
              //search_VPH_grid.DataSource = dt;
              //  search_VPH_grid.DataBind();
            if (symptomDataDetails.Rows.Count > 0)
            {
                DropSymptoms.DataSource = symptomDataDetails;
                DropSymptoms.DataTextField = "symptoms";
                DropSymptoms.DataValueField = "symptoms";

                s1 = DropSymptoms.SelectedValue;
                DropSymptoms.DataBind();
                DropSymptoms.Items.Insert(0, new ListItem("Select Symptom", "0"));
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>if(confirm('Patient details not available')==true){window.location.replace('View Patient History.aspx')}</script>");
            }
               
            
        }
        catch
        {
            throw;
        }
    }
    protected void btn_search_vph_Click(object sender, EventArgs e)
    {
       // Response.Write(s1);

        PatHistory_bo.patient_id = txt_Patientid_VPH.Text;
        PatHistory_bo.Fname = txt_Fname_VPH.Text;
        PatHistory_bo.lname = txt_Lname_VPH.Text;
        PatHistory_bo.symptom = DropSymptoms.SelectedValue;
        s1 = PatHistory_bo.symptom;
        if (PatHistory_bo.Fname == "" && PatHistory_bo.lname == "")
        {
            try
            {
                if (s1!= "0")
                {
                    //Label1.Text = s1;
                    SqlDataAdapter HistoryData = PatHistory_bl.view(PatHistory_bo);
                    DataTable HistoryDataDetails = new DataTable();
                    HistoryData.Fill(HistoryDataDetails);
                    if (HistoryDataDetails.Rows.Count >= 0)
                    {
                        search_VPH_grid.DataSource = HistoryDataDetails;
                        search_VPH_grid.DataBind();
                    }
                    else
                    {
                        
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('No data available');</script>");
                    }
                        
                }
                else
                {
                   
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Please select a symptom');</script>");
                    
                }
               
            }
            catch
            {
                throw;
            }
        }
        else
        {
            try
            {
                SqlDataAdapter HistoryData = PatHistory_bl.viewp(PatHistory_bo);
                DataTable HistoryDataDetails = new DataTable();
                HistoryData.Fill(HistoryDataDetails);
                if (HistoryDataDetails.Rows.Count >= 0)
                {
                    search_VPH_grid.DataSource = HistoryDataDetails;
                    search_VPH_grid.DataBind();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Data Doesn't exists')");
                }
                
            }
            catch
            {
                throw;
            }
        }

    }

    protected void Logout_btn_Click(object sender, EventArgs e)
    {
        Session.Remove("Id");
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
            

    }
}