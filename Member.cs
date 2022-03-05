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
            cmd.Parameters.AddWithValue("@Membership",mem_status.Text);
            cmd.Parameters.AddWithValue("@TID", t_id.Text);
            cmd.Parameters.AddWithValue("@ScID", sc_id.Text);
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
            sc_id.Clear();
            br_id.Clear();
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
            sc_id.Text = MemberView.SelectedRows[0].Cells[8].Value.ToString(); 
            br_id.Text = MemberView.SelectedRows[0].Cells[9].Value.ToString();
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
                cmd.Parameters.AddWithValue("@TID",t_id.Text);
                cmd.Parameters.AddWithValue("@ScID", sc_id.Text);
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
    }
    }
