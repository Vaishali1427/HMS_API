using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using BusinessLogic;
using BusinessObject;
using System.Configuration;


public partial class AddPatient : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
    SqlCommand com;
    AddPat_BO AddPat_objBO = new AddPat_BO();
    AddPat_BL AddPat_objBL = new AddPat_BL();
    string AddPat_s1 = "";
    string AddPat_s2 = "";
    string AddPat_s3 = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Calendar1.Visible = false;
        }
        dropState();
        dropInsurance();
    }
    private void dropState()
    {
        com = new SqlCommand("StateNameDrop_SP", con);

        com.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DropState_AP.DataSource = dt;
        DropState_AP.DataTextField = "state_name";
        AddPat_s1 = DropState_AP.SelectedItem.Text;
        DropState_AP.DataBind();
        DropState_AP.Items.Insert(0, new ListItem("select state", "select state"));
    }
    private void dropInsurance()
    {
        com = new SqlCommand("InsuranceDrop_SP", con);

        com.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DropInsurance_AP.DataSource = dt;
        DropInsurance_AP.DataTextField = "insurance_name";
        AddPat_s2 = DropInsurance_AP.SelectedItem.Text;
        DropInsurance_AP.DataBind();
        DropInsurance_AP.Items.Insert(0, new ListItem("Select Insurance", "Select Insurance"));
    }
    protected void Submit_AP_Click(object sender, EventArgs e)
    {
        AddPat_objBO.FirstName = txt_Fname_AP.Text;
        AddPat_objBO.LastName = txt_Lname_AP.Text;
        //AddPat_objBO.DOB = Convert.ToDateTime(txt_DOB_AP.Text.ToString().Trim());
        String MyString = txt_DOB_AP.Text;
        DateTime MyDateTime = new DateTime();
        MyDateTime = DateTime.ParseExact(MyString, "dd/MM/yyyy", null);
        String MyString_new = MyDateTime.ToString("yyyy/MM/dd");
        AddPat_objBO.DOB = Convert.ToDateTime(MyString_new);
        AddPat_objBO.Email = txt_Mail_AP.Text;
        AddPat_objBO.ContactNO = txt_Phno_AP.Text;
        AddPat_objBO.state_name = AddPat_s1;
        AddPat_objBO.insurance_name = AddPat_s2;
        try
        {

            int res = AddPat_objBL.SaveUserregisrationBL(AddPat_objBO);
            if (res > 0)
            {
                SqlDataAdapter PatIdData = AddPat_objBL.DispPatID(AddPat_objBO);
                DataTable PatDetails = new DataTable();
                PatIdData.Fill(PatDetails);
                foreach (DataRow data in PatDetails.Rows)
                {
                    AddPat_s3 += data[0].ToString();
                }
                AddPat_Label1_AP.Text = "Patient ID is " + AddPat_s3;
            }
        }
        catch
        {
            throw;
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
        }
        else
        {
            Calendar1.Visible = true;
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txt_DOB_AP.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
        Calendar1.Visible = false;
    }

    protected void Logout_btn_Click(object sender, EventArgs e)
    {
        Session.Remove("Id");
        Session.RemoveAll();
        Response.Redirect("Login.aspx");
            
    }
}