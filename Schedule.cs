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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        private string id;
        private void GetScheduleRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM schedule";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            ScheduleView.DataSource = dt;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO schedule(sc_id, sc_name, description) VALUES(@ScheduleID, @ScheduleName, @Description)";
            cmd.Parameters.AddWithValue("@ScheduleID", scid.Text);
            cmd.Parameters.AddWithValue("@ScheduleName", scname.Text);
            cmd.Parameters.AddWithValue("@Description", description.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetScheduleRecord();
            ResetFormData();
        }
        private void ResetFormData()
        {
            this.id = null;
            scid.Clear();
            scname.Clear();
            description.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (this.id != null)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE schedule SET sc_name = @ScheduleName, description = @Description WHERE sc_id = @ScheduleID";
                cmd.Parameters.AddWithValue("@ScheduleID", this.id);
                cmd.Parameters.AddWithValue("@ScheduleName", scname.Text);
                cmd.Parameters.AddWithValue("@Description", description.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetScheduleRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a schedule.");
            }
        }

        private void ScheduleView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = ScheduleView.SelectedRows[0].Cells[0].Value.ToString();
            scid.Text = ScheduleView.SelectedRows[0].Cells[0].Value.ToString();
            scname.Text = ScheduleView.SelectedRows[0].Cells[1].Value.ToString();
            description.Text = ScheduleView.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            GetScheduleRecord();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (this.id != null)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM schedule WHERE sc_id = @ScheduleID";
                cmd.Parameters.AddWithValue("@ScheduleID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetScheduleRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a schedule.");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }
    }
}
