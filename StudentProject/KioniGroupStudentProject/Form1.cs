using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KioniGroupStudentProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        static string myString = @"Data Source=DESKTOP-EVC6IPJ;Initial Catalog=UniDB;Integrated Security=True";
        SqlConnection cnn = new SqlConnection(myString);
            
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                cnn.Open();
                string query = "insert into Student values("+txtStudId.Text+",'" + txtName.Text + "','" + txtRegNo.Text + " ','" + txtEmail.Text + " ','" + txtPhone.Text + " ','" + texPassword.Text + " ',' "+btMale.Text+" ')";
                SqlCommand cmd = new SqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("inserted succesfully");
                cnn.Close();
               

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtName.Clear();
            this.txtPhone.Text = "";
            this.txtPhone.Clear();
            this.txtEmail.Text = "";
            this.txtEmail.Clear();
            this.txtRegNo.Text = "";
            this.txtRegNo.Clear();
            this.texPassword.Text = "";
            this.texPassword.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void texPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtEmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
