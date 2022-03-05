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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }
        private int id;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }

        private void StaffView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(StaffView.SelectedRows[0].Cells[0].Value);
            sid.Text = StaffView.SelectedRows[0].Cells[0].Value.ToString();
            sname.Text = StaffView.SelectedRows[0].Cells[1].Value.ToString();
            saddress.Text = StaffView.SelectedRows[0].Cells[2].Value.ToString();
            snum.Text = StaffView.SelectedRows[0].Cells[3].Value.ToString();
            work.Text = StaffView.SelectedRows[0].Cells[4].Value.ToString();
            wage.Text = StaffView.SelectedRows[0].Cells[5].Value.ToString();
            joindate.Text = StaffView.SelectedRows[0].Cells[6].Value.ToString();
            br_id.Text = StaffView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            GetStaffRecord();
        }

        private void GetStaffRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM staff";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            StaffView.DataSource = dt;
        }
        private void ResetFormData()
        {
            this.id = 0;
            sid.Clear();
            sname.Clear();
            saddress.Clear();
            snum.Clear();
            work.Clear();
            wage.Clear();
            joindate.Clear();
            br_id.Clear();
        }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO staff(s_name, s_address, s_num, work, wage, br_id) VALUES(@StaffName, @StaffAddress, @StaffNum, @Work, @Wage, @BrID)";
            cmd.Parameters.AddWithValue("@StaffName", sname.Text);
            cmd.Parameters.AddWithValue("@StaffAddress", saddress.Text);
            cmd.Parameters.AddWithValue("@StaffNum", snum.Text);
            cmd.Parameters.AddWithValue("@Work", work.Text);
            cmd.Parameters.AddWithValue("@Wage", wage.Text);
            cmd.Parameters.AddWithValue("@BrID", br_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetStaffRecord();
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
                cmd.CommandText = "UPDATE staff SET s_name = @StaffName, s_address = @StaffAddress, s_num = @StaffNum, work = @Work, wage = @Wage, br_id = @BrID WHERE s_id = @StaffID";
                cmd.Parameters.AddWithValue("@StaffID", this.id);
                cmd.Parameters.AddWithValue("@StaffName", sname.Text);
                cmd.Parameters.AddWithValue("@StaffAddress", saddress.Text);
                cmd.Parameters.AddWithValue("@StaffNum", snum.Text);
                cmd.Parameters.AddWithValue("@Work", work.Text);
                cmd.Parameters.AddWithValue("@Wage", wage.Text);
                cmd.Parameters.AddWithValue("@BrID", br_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetStaffRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a staff.");
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
                cmd.CommandText = "DELETE FROM staff WHERE s_id = @StaffID";
                cmd.Parameters.AddWithValue("@StaffID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetStaffRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a staff.");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }
    }
}
