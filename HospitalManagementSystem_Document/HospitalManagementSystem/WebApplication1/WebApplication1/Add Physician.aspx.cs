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



public partial class AddPhysician : System.Web.UI.Page
{
    
    
    AddPhy_BL AddPhy_bl = new AddPhy_BL();
    AddPhy_BO AddPhy_bo = new AddPhy_BO();
    string s4 = "";
    string AddPhy_s1 = "";
    string AddPhy_s2 = "";
    string AddPhy_s3 = "";
    protected void Page_Load(object sender, EventArgs e)
    {

        AddPhy_dropState();
        AddPhy_dropInsurance();
        AddPhy_dropDept();
        if (IsPostBack)
        {
        }
            //if (!Page.IsPostBack)
            //{
            //    dropDept();
            //}
        
    }
    public void AddPhy_dropDept()
    {
        SqlDataAdapter deptData = AddPhy_bl.dropdept();
        //DataTable dt = new DataTable();
        DataSet deptDataDetails = new DataSet();
        deptData.Fill(deptDataDetails);
        DropDept_APhy.DataTextField = deptDataDetails.Tables[0].Columns["department_name"].ToString();
        DropDept_APhy.DataSource = deptDataDetails.Tables[0];
        AddPhy_s1 = DropDept_APhy.SelectedValue;
        DropDept_APhy.DataBind();
        DropDept_APhy.Items.Insert(0, new ListItem("Select Department ", "Select Department "));
    }
    private void AddPhy_dropState()
    {
        SqlDataAdapter stateData = AddPhy_bl.dropstate();
        //DataTable dt = new DataTable();
        DataSet stateDataDetails = new DataSet();
        stateData.Fill(stateDataDetails);

        DropState_APhy.DataTextField = stateDataDetails.Tables[0].Columns["state_name"].ToString();
        DropState_APhy.DataSource = stateDataDetails.Tables[0];
        AddPhy_s2 = DropState_APhy.SelectedValue;
        DropState_APhy.DataBind();
        DropState_APhy.Items.Insert(0, new ListItem("select state", "select state"));
    }
    private void AddPhy_dropInsurance()
    {
        SqlDataAdapter InsuranceData = AddPhy_bl.dropInsurance();
        //DataTable dt = new DataTable();
        DataSet InsuranceDataDetails = new DataSet();
        InsuranceData.Fill(InsuranceDataDetails);
        DropInsurance_APhy.DataTextField = InsuranceDataDetails.Tables[0].Columns["insurance_name"].ToString();
        DropInsurance_APhy.DataSource = InsuranceDataDetails.Tables[0];
        AddPhy_s3 = DropInsurance_APhy.SelectedValue;
        DropInsurance_APhy.DataBind();
        DropInsurance_APhy.Items.Insert(0, new ListItem("Select Insurance", "Select Insurance"));
    }
  
    protected void btn_Register_APhy_Click(object sender, EventArgs e)
    {
        AddPhy_bo.FirstName = txt_Fname_APhy.Text;
        AddPhy_bo.LastName = txt_Lname_Aphy.Text;
        AddPhy_bo.DepartmentName = AddPhy_s1;
        AddPhy_bo.EducationQualification = txt_Education_APhy.Text;
        AddPhy_bo.YearsOfExperience = txt_Experience_APhy.Text;
        AddPhy_bo.StateName = AddPhy_s2;
        AddPhy_bo.InsurancePlan = AddPhy_s3;
        try
        {


            int res = AddPhy_bl.SaveUserregisrationBL(AddPhy_bo);
            if (res == 0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>if(confirm('Registration not successful do you want to continue??')==true){window.location.replace('Add Physician.aspx')}</script>");
            }
            else
            {
                SqlDataAdapter PhyIDData = AddPhy_bl.view1(AddPhy_bo);
                DataTable PhyIDDataDetails = new DataTable();
                PhyIDData.Fill(PhyIDDataDetails);
                foreach (DataRow data in PhyIDDataDetails.Rows)
                {
                    s4 += data[0].ToString();
                }
                AddPhy_Label1.Text = "Physician Id is " + s4;
                //Response.Redirect("a.aspx");
            }
            
         }
            
            
        

        catch
        {
            Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>if(confirm('User already exists')==true){window.location.replace('Add Physician.aspx')}</script>");
        }
    }

    protected void Logout_btn_Click(object sender, EventArgs e)
    {
        Session.Remove("Id");
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
            
    }
}