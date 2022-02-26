using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMS
{
    public partial class Login : Form
    {
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Name = txtname.Text;
            String Password = txtpassword.Text;
            cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM admin where name='" + txtname.Text + "' AND password='" + txtpassword.Text + "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Successful");
                Menu log = new Menu();
                this.Hide();
                log.Show();
            }
            else
            {
                MessageBox.Show("Invalid name and password");
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = true;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
