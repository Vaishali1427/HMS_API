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

public partial class Physician_search : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection("Data Source=PC180147\\SQLEXPRESS;Initial Catalog=hms1;User ID=sa;Password=password-1");
    //SqlCommand com;
    PhySearch_BL PhySearch_bl = new PhySearch_BL();
    PhySearch_BO PhySearch_bo = new PhySearch_BO();
    string s1 = "";
    string s2 = "";
    string s3 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PhySearch_dropDept();
            PhySearch_dropState();
            PhySearch_dropInsurance();
        }
        
        
    }
    private void PhySearch_dropDept()
    {
        //com = new SqlCommand("select * from department", con);
        //SqlDataAdapter da = new SqlDataAdapter(com);
        //DataTable dt = new DataTable();
        //da.Fill(dt);
        
        //DropDept_PS.DataSource = dt;
        //DropDept_PS.DataTextField = "department_name";
        ////s1 = Dept_PS.SelectedItem.Text;
        //s1 = DropDept_PS.SelectedValue;
       
        //DropDept_PS.DataBind();
        SqlDataAdapter deptData = PhySearch_bl.PhySearch_dropdept();
        //DataTable dt = new DataTable();
        DataSet deptDataDetails = new DataSet();
        deptData.Fill(deptDataDetails);

        DropDept_PS.DataTextField = deptDataDetails.Tables[0].Columns["department_name"].ToString();
        DropDept_PS.DataSource = deptDataDetails.Tables[0];
        s1 = DropDept_PS.SelectedValue;
        DropDept_PS.DataBind();
        DropDept_PS.Items.Insert(0, new ListItem("Select Department ", "Select Department "));

    }
    private void PhySearch_dropState()
    {
        SqlDataAdapter stateData = PhySearch_bl.PhySearch_dropstate();
        //DataTable dt = new DataTable();
        DataSet stateDataDetails = new DataSet();
        stateData.Fill(stateDataDetails);
        Dropstate_ps.DataTextField = stateDataDetails.Tables[0].Columns["state_name"].ToString();
        Dropstate_ps.DataSource = stateDataDetails.Tables[0];
        s2 = Dropstate_ps.SelectedValue;
        Dropstate_ps.DataBind();
        Dropstate_ps.Items.Insert(0, new ListItem("select state", "select state"));
    }
    private void PhySearch_dropInsurance()
    {
        SqlDataAdapter InsuranceData = PhySearch_bl.PhySearch_dropInsurance();
        //DataTable dt = new DataTable();
        DataSet InsuranceDataDetails = new DataSet();
        InsuranceData.Fill(InsuranceDataDetails);
        DropinsurancePlan_PS.DataTextField = InsuranceDataDetails.Tables[0].Columns["insurance_name"].ToString();
        DropinsurancePlan_PS.DataSource = InsuranceDataDetails.Tables[0];
        s3 = DropinsurancePlan_PS.SelectedValue;
        DropinsurancePlan_PS.DataBind();
        DropinsurancePlan_PS.Items.Insert(0, new ListItem("Select Insurance", "Select Insurance"));
    }

    protected void Search_PS_Click(object sender, EventArgs e)
    {
        PhySearch_bo.StateName = Dropstate_ps.SelectedValue;

        PhySearch_bo.DepartmentName = DropDept_PS.SelectedValue;

        PhySearch_bo.InsurancePlan = DropinsurancePlan_PS.SelectedValue;
        try
        {
            SqlDataAdapter SearchResult = PhySearch_bl.PhySearch_View1(PhySearch_bo);
            DataTable SearchResultDetails = new DataTable();
            SearchResult.Fill(SearchResultDetails);
            if (SearchResultDetails.Rows.Count == 0)
            {
                
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>if(confirm('No Physician available')==true){window.location.replace('Physician Search.aspx')}</script>");
            }
            else
            {

                SearchView_PS.DataSource = SearchResultDetails;
                SearchView_PS.DataBind();
            }
        }
        catch
        {
            throw;
        }
    }
    protected void Logout_btn_Click(object sender, EventArgs e)
    {
        Session.Remove("Id");
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
            
    }
}