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
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }
        private void Trainer_Load(object sender, EventArgs e)
        {
            GetTrainerRecord();
        }
        private int id;
        private void GetTrainerRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM trainer";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            TrainerView.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TrainerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(TrainerView.SelectedRows[0].Cells[0].Value);
            tid.Text = TrainerView.SelectedRows[0].Cells[0].Value.ToString();
            tname.Text = TrainerView.SelectedRows[0].Cells[1].Value.ToString();
            taddress.Text = TrainerView.SelectedRows[0].Cells[2].Value.ToString();
            tnum.Text = TrainerView.SelectedRows[0].Cells[3].Value.ToString();
            payment.Text = TrainerView.Rows[0].Cells[4].Value.ToString();
            regdate.Text = TrainerView.Rows[0].Cells[5].Value.ToString();
            sc_id.Text = TrainerView.SelectedRows[0].Cells[6].Value.ToString();
            br_id.Text = TrainerView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO trainer(t_name, t_address, t_num, payment, sc_id, br_id) VALUES(@TrainerName, @TrainerAddress, @TrainerNum, @Payment, @StayDate, @ScID, @BrID)";
            cmd.Parameters.AddWithValue("@TrainerName", tname.Text);
            cmd.Parameters.AddWithValue("@TrainerAddress", taddress.Text);
            cmd.Parameters.AddWithValue("@TrainerNum", tnum.Text);
            cmd.Parameters.AddWithValue("@Payment", payment.Text);
            cmd.Parameters.AddWithValue("@ScID", sc_id.Text);
            cmd.Parameters.AddWithValue("@BrID", br_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetTrainerRecord();
            ResetFormData();
        }

        private void ResetFormData()
        {
            this.id = 0;
            tid.Clear();
            tname.Clear();
            taddress.Clear();
            tnum.Clear();
            payment.Clear();
            regdate.Clear();    
            br_id.Clear();
            sc_id.Clear(); 
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
                cmd.CommandText = "UPDATE trainer SET t_name = @TrainerName, t_address = @TrainerAddress, t_num = @TrainerNum, payment = @Payment, sc_id = @ScID, br_id = @BrID WHERE t_id = @TrainerID";
                cmd.Parameters.AddWithValue("@TrainerID", this.id);
                cmd.Parameters.AddWithValue("@TrainerName", tname.Text);
                cmd.Parameters.AddWithValue("@TrainerAddress", taddress.Text);
                cmd.Parameters.AddWithValue("@TrainerNum", tnum.Text);
                cmd.Parameters.AddWithValue("@Payment", payment.Text);
                cmd.Parameters.AddWithValue("@ScID", sc_id.Text);
                cmd.Parameters.AddWithValue("@BrID", br_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetTrainerRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a trainer.");
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
                cmd.CommandText = "DELETE FROM trainer WHERE t_id = @TrainerID";
                cmd.Parameters.AddWithValue("@TrainerID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetTrainerRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a trainer.");
            }
        }
    }
}
