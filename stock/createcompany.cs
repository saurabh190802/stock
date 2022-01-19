using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stock
{
    public partial class createcompany : Form
    {
        public createcompany()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel5.Hide();
            panel3.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Hide();
            panel5.Show();
            textBoxname.Focus();
        }

        private void buttonhome_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome Welcome = new welcome();
            Welcome.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void createcompany_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'istockdataDataSet.companymaster' table. You can move, or remove it, as needed.
            this.companymasterTableAdapter.Fill(this.istockdataDataSet.companymaster);
            panel5.Hide();
            panel3.Hide();
            
            comboBoxtypeofbussiness.Text = "--Select From List--";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\Desktop\stock\stock\istockdata.mdf;Integrated Security=True");
            con.Open();
            string query = "select Name from companymaster";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Name");
            comboBoxselectcompany.DisplayMember = "Name";
            comboBoxselectcompany.DataSource = ds.Tables["Name"];
            comboBoxselectcompany.Text = "--Select From List--";
            con.Close();
            
        }
        bool check = true;
        private void buttoncreate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\Desktop\stock\stock\istockdata.mdf;Integrated Security=True");

            if (textBoxname.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxname.Focus();
                return;
            }
            if (textBoxwebsite.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Website", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxwebsite.Focus();
                return;
            }
            if (richTextBoxregdaddress.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Registered Address", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBoxregdaddress.Focus();
                return;
            }
            if (richTextBoxworkaddress.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please fil all the fields", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBoxworkaddress.Focus();
                return;
            }
            if (comboBoxtypeofbussiness.Text == "--Select From List--")
            {
                check = false;
                MessageBox.Show("Please Select Type of Bussiness", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBoxtypeofbussiness.Focus();
                return;
            }
            if (textBoxbussinesspassword.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxbussinesspassword.Focus();
                return;
            }
            if (textBoxpincode.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Pincode", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxpincode.Focus();
                return;
            }
            if (textBoxemail.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxemail.Focus();
                return;
            }
            if (textBoxvatno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter VAT No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxvatno.Focus();
                return;
            }
            if (textBoxgstinno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter GSTIN No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxgstinno.Focus();
                return;
            }
            if (textBoxcin.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter CIN", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxcin.Focus();
                return;
            }
            if (textBoxpanno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter PAN No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxpanno.Focus();
                return;
            }
            if (textBoxservicetaxno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Service TAX No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxservicetaxno.Focus();
                return;
            }
            if (textBoxmfglicenseno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter MFG License No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxmfglicenseno.Focus();
                return;
            }
            if (textBoxdlno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter DL No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxdlno.Focus();
                return;
            }
            if (textBoxtelephoneno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Telephone No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxtelephoneno.Focus();
                return;
            }
            if (textBoxfaxno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter FAX No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxfaxno.Focus();
                return;
            }
            if (textBoxcountry.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Country Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxcountry.Focus();
                return;
            }
            if (textBoxstate.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter State Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxstate.Focus();
                return;
            }
            if (textBoxcontactperson.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Contact Person Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxcontactperson.Focus();
                return;
            }
            if (textBoxcontactpersontelephoneno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Contact Person Telephone No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxcontactpersontelephoneno.Focus();
                return;
            }
            if (textBoxcontactpersonmobileno.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Contact Person Mobile No", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxcontactperson.Focus();
                return;
            }
            if (textBoxcontactpersonmail.Text == String.Empty)
            {
                check = false;
                MessageBox.Show("Please Enter Contact Person Email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxcontactpersonmail.Focus();
                return;
            }
            try
            {
                if (check == true)
                {
                    Guid newGUID = Guid.NewGuid();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert_CM_SP", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", newGUID.ToString());
                    cmd.Parameters.AddWithValue("@Name", textBoxname.Text);
                    cmd.Parameters.AddWithValue("@Website", textBoxwebsite.Text);
                    cmd.Parameters.AddWithValue("@Regd_Address", richTextBoxregdaddress.Text);
                    cmd.Parameters.AddWithValue("@Work_Address", richTextBoxworkaddress.Text);
                    cmd.Parameters.AddWithValue("@Type_Of_Bussiness", comboBoxtypeofbussiness.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Pincode", textBoxpincode.Text);
                    cmd.Parameters.AddWithValue("@Email", textBoxemail.Text);
                    cmd.Parameters.AddWithValue("@GstinNo", textBoxgstinno.Text);
                    cmd.Parameters.AddWithValue("@Cin", textBoxcin.Text);
                    cmd.Parameters.AddWithValue("@PanNo", textBoxpanno.Text);
                    cmd.Parameters.AddWithValue("@ServiceTaxNo", textBoxservicetaxno.Text);
                    cmd.Parameters.AddWithValue("@MfgLNo", textBoxmfglicenseno.Text);
                    cmd.Parameters.AddWithValue("@DLNo", textBoxdlno.Text);
                    cmd.Parameters.AddWithValue("@Telephone_No", textBoxtelephoneno.Text);
                    cmd.Parameters.AddWithValue("@Fax_No", textBoxfaxno.Text);
                    cmd.Parameters.AddWithValue("@Country", textBoxcountry.Text);
                    cmd.Parameters.AddWithValue("@State", textBoxstate.Text);
                    cmd.Parameters.AddWithValue("@Contact_Person", textBoxcontactperson.Text);
                    cmd.Parameters.AddWithValue("@Contact_Person_TelephpneNo", textBoxcontactpersontelephoneno.Text);
                    cmd.Parameters.AddWithValue("@Contact_person_Mobile_No", textBoxcontactpersonmobileno.Text);
                    cmd.Parameters.AddWithValue("@Contact_Person_Email ", textBoxcontactpersonmail.Text);
                    cmd.Parameters.AddWithValue("@Financial_Start_Date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@Financial_End_Date", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@Bussiness_password", textBoxbussinesspassword.Text);
                    cmd.Parameters.AddWithValue("@VatNo", textBoxvatno.Text);
                    cmd.Parameters.AddWithValue("@TinNo", textBoxtinno.Text);

                    

                    int numRes = cmd.ExecuteNonQuery();
                    con.Close();
                    
                    if (numRes > 0)
                    {
                        MessageBox.Show("Company Created Successfully !!!\nNow LogIn");
                        panel5.Hide();
                        panel3.Show();

                        
                        con.Open();
                        string query = "select Name from companymaster";
                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Name");
                        comboBoxselectcompany.DisplayMember = "Name";
                        comboBoxselectcompany.DataSource = ds.Tables["Name"];
                        con.Close();
                        int count = comboBoxselectcompany.Items.Count;
                        count--;
                        comboBoxselectcompany.SelectedItem = comboBoxselectcompany.Items[count];
                        







                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:- " + ex.Message);
            }


        }

        private void textBoxloginpassword_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxloginpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\saura\Desktop\stock\stock\istockdata.mdf;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("select * from [companymaster] where Name=@Name and Bussiness_password =@Bussiness_password", con);
                cmd.Parameters.AddWithValue("@Name", comboBoxselectcompany.Text);
                cmd.Parameters.AddWithValue("@Bussiness_password", textBoxloginpassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    dashboard Dashboard = new dashboard();
                    Dashboard.ShowDialog();

                }

                else
                {

                    MessageBox.Show("Please enter Correct Username and Password");
                }



            }
        }

        private void comboBoxselectcompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    

