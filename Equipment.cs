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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }
        private int id;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            GetEquipmentRecord();
        }

        private void GetEquipmentRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM equipment";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            EquipmentView.DataSource = dt;
        }

        private void EquipmentView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(EquipmentView.SelectedRows[0].Cells[0].Value);
            eid.Text = EquipmentView.SelectedRows[0].Cells[0].Value.ToString();
            ename.Text = EquipmentView.SelectedRows[0].Cells[1].Value.ToString();
            specification.Text = EquipmentView.SelectedRows[0].Cells[2].Value.ToString();
            qnt.Text = EquipmentView.SelectedRows[0].Cells[3].Value.ToString();
            u_price.Text = EquipmentView.SelectedRows[0].Cells[4].Value.ToString();
            br_id.Text = EquipmentView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO equipment(e_name, specification, qnt, u_price, br_id) VALUES(@EquipmentName, @Specification, @Qnt, @UPrice, @BrID)";
            cmd.Parameters.AddWithValue("@EquipmentName", ename.Text);
            cmd.Parameters.AddWithValue("@Specification", specification.Text);
            cmd.Parameters.AddWithValue("@Qnt", qnt.Text);
            cmd.Parameters.AddWithValue("@UPrice", u_price.Text);
            cmd.Parameters.AddWithValue("@BrID", br_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetEquipmentRecord();
            ResetFormData();
        }

        private void ResetFormData()
        {
            this.id = 0;
            eid.Clear();
            ename.Clear();
            specification.Clear();
            qnt.Clear();
            u_price.Clear();
            br_id.Clear();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE equipment SET e_name = @EquipmentName, specification = @Specification, qnt = @Qnt, u_price = @UPrice, br_id = @BrID WHERE e_id = @EquipmentID";
                cmd.Parameters.AddWithValue("@EquipmentID", this.id);
                cmd.Parameters.AddWithValue("@EquipmentName", ename.Text);
                cmd.Parameters.AddWithValue("@Specification", specification.Text);
                cmd.Parameters.AddWithValue("@Qnt", qnt.Text);
                cmd.Parameters.AddWithValue("@UPrice", u_price.Text);
                cmd.Parameters.AddWithValue("@BrID", br_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetEquipmentRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a equipment.");
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
                cmd.CommandText = "DELETE FROM equipment WHERE e_id = @EquipmentID";
                cmd.Parameters.AddWithValue("@EquipmentID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetEquipmentRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a equipment.");
            }
        }
    }
}
