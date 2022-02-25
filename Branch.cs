using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GMS
{
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }
        private int id;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Branch_Load(object sender, EventArgs e)
        {
            GetBranchRecord();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(BranchView.SelectedRows[0].Cells[0].Value);
            brid.Text = BranchView.SelectedRows[0].Cells[0].Value.ToString();
            brname.Text = BranchView.SelectedRows[0].Cells[1].Value.ToString();
            bradd.Text = BranchView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void GetBranchRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM branch";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            BranchView.DataSource = dt;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO branch(br_id, br_name, br_address) VALUES(@BranchID, @BranchName, @BranchAddress)";
            cmd.Parameters.AddWithValue("@BranchID", brid.Text);
            cmd.Parameters.AddWithValue("@BranchName", brname.Text);
            cmd.Parameters.AddWithValue("@BranchAddress", bradd.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetBranchRecord();
            ResetFormData();
        }
        private void ResetFormData()
        {
            this.id = 0;
            brid.Clear();
            brname.Clear();
            bradd.Clear();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE branch SET br_name = @BranchName, br_address = @BranchAddress WHERE br_id = @BranchID";
                cmd.Parameters.AddWithValue("@BranchID", this.id);
                cmd.Parameters.AddWithValue("@BranchName", brname.Text);
                cmd.Parameters.AddWithValue("@BranchAddress", bradd.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetBranchRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a branch.");
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM branch WHERE br_id = @BranchID";
                cmd.Parameters.AddWithValue("@BranchID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetBranchRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a branch.");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }
    }
    }

