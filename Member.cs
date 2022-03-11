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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();

        }

        private void Member_Load(object sender, EventArgs e)
        {
            GetMemberRecord();
            GetComboBox1();
            comboBox1.SelectedIndex = -1;
            GetComboBoxBr();
            br_id.SelectedIndex = -1;
        }
        
        private void GetComboBox1()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from schedule", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            comboBox1.ValueMember = "sc_id";
            comboBox1.DisplayMember = "sc_id";
            comboBox1.DataSource = dt;
            con.Close();
        }
        private void GetComboBoxBr()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from branch", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            br_id.ValueMember = "br_id";
            br_id.DisplayMember = "br_id";
            br_id.DataSource = dt;
            con.Close();
        }
        private int id;
        private void GetMemberRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM member";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            MemberView.DataSource = dt;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO member(m_name, m_address, m_num, fees, mem_status, t_id, sc_id, br_id) VALUES(@MemberName, @MemberAddress, @MemberNum, @Fees, @Membership, @TID, @ScID, @BrID)";
            cmd.Parameters.AddWithValue("@MemberName", mname.Text);
            cmd.Parameters.AddWithValue("@MemberAddress", maddress.Text);
            cmd.Parameters.AddWithValue("@MemberNum", mnum.Text);
            cmd.Parameters.AddWithValue("@Fees", fees.Text);
            cmd.Parameters.AddWithValue("@Membership", mem_status.Text);
            cmd.Parameters.AddWithValue("@TID", t_id.Text);
            cmd.Parameters.AddWithValue("@ScID", comboBox1.Text);
            cmd.Parameters.AddWithValue("@BrID", br_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetMemberRecord();
            ResetFormData();
        }

        private void ResetFormData()
        {
            this.id = 0;
            mid.Clear();
            mname.Clear();
            maddress.Clear();
            mnum.Clear();
            regdate.Clear();
            fees.Clear();
            mem_status.Clear();
            t_id.Clear();
            comboBox1.SelectedIndex = -1;
            br_id.SelectedIndex = -1;
        }

        private void MemberView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(MemberView.SelectedRows[0].Cells[0].Value);
            mid.Text = MemberView.SelectedRows[0].Cells[0].Value.ToString();
            mname.Text = MemberView.SelectedRows[0].Cells[1].Value.ToString();
            maddress.Text = MemberView.SelectedRows[0].Cells[2].Value.ToString();
            mnum.Text = MemberView.SelectedRows[0].Cells[3].Value.ToString();
            regdate.Text = MemberView.SelectedRows[0].Cells[5].Value.ToString();
            fees.Text = MemberView.SelectedRows[0].Cells[4].Value.ToString();
            mem_status.Text = MemberView.SelectedRows[0].Cells[6].Value.ToString();
            t_id.Text = MemberView.SelectedRows[0].Cells[7].Value.ToString();
            //sc_id.Text = MemberView.SelectedRows[0].Cells[8].Value.ToString();
            br_id.Text = MemberView.SelectedRows[0].Cells[9].Value.ToString();
            comboBox1.Text = MemberView.SelectedRows[0].Cells[8].Value.ToString();
            //comboBox2.Text = MemberView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE member SET m_name = @MemberName, m_address = @MemberAddress, m_num = @MemberNum, fees = @Fees, mem_status = @Membership, t_id = @TID, sc_id = @ScID, br_id = @BrID WHERE m_id = @MemberID";
                cmd.Parameters.AddWithValue("@MemberID", this.id);
                cmd.Parameters.AddWithValue("@MemberName", mname.Text);
                cmd.Parameters.AddWithValue("@MemberAddress", maddress.Text);
                cmd.Parameters.AddWithValue("@MemberNum", mnum.Text);
                cmd.Parameters.AddWithValue("@Fees", fees.Text);
                cmd.Parameters.AddWithValue("@@Membership", mem_status.Text);
                cmd.Parameters.AddWithValue("@TID", t_id.Text);
                cmd.Parameters.AddWithValue("@ScID", comboBox1.Text);
                cmd.Parameters.AddWithValue("@BrID", br_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetMemberRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a member.");
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
                cmd.CommandText = "DELETE FROM member WHERE m_id = @MemberID";
                cmd.Parameters.AddWithValue("@MemberID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetMemberRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a member.");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }
        public int sid;
        public string scid;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (comboBox1.SelectedText != "")//comboBox1.SelectedValue.ToString() != null)
            {
                scid = Convert.ToString(comboBox1.SelectedText);
                //sid = Convert.ToInt32(comboBox1.SelectedItem.ToString());
                GetComboBox2(scid);
            }*/
        }

        /*private void GetComboBox2(string sid)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM trainer WHERE sc_id = @sid", con);
            cmd.Parameters.AddWithValue("@sid", sid);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            

            comboBox2.ValueMember = "t_id";
            comboBox2.DisplayMember = "t_id";
            comboBox2.DataSource = dt;
            con.Close();
        }*/

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
