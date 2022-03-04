﻿using System;
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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }
        private int id;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            GetCostRecord();
        }

        private void GetCostRecord()
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM cost";
            MySqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            con.Close();
            CostView.DataSource = dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Menu log = new Menu();
            this.Hide();
            log.Show();
        }

        private void MemberView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(CostView.SelectedRows[0].Cells[0].Value);
            cid.Text = CostView.SelectedRows[0].Cells[0].Value.ToString();
            cname.Text = CostView.SelectedRows[0].Cells[1].Value.ToString();
            unit.Text = CostView.SelectedRows[0].Cells[2].Value.ToString();
            quantity.Text = CostView.SelectedRows[0].Cells[3].Value.ToString();
            total.Text = CostView.SelectedRows[0].Cells[4].Value.ToString();
            details.Text = CostView.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = CostView.SelectedRows[0].Cells[6].Value.ToString();
            br_id.Text = CostView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
            con.Open();

            MySqlCommand cmd;
            cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO cost(c_name, unit, quantity, total, details, c_date, br_id) VALUES(@CostName, @CostUnit, @CostQuantity, @CostTotal, @CostDetails, @CostDate, @BrID)";
            cmd.Parameters.AddWithValue("@CostName", cname.Text);
            cmd.Parameters.AddWithValue("@CostUnit", unit.Text);
            cmd.Parameters.AddWithValue("@CostQuantity", quantity.Text);
            double up = Convert.ToDouble(unit.Text);
            double qnt = Convert.ToDouble(quantity.Text);
            double total = up*qnt;
            cmd.Parameters.AddWithValue("@CostTotal", total);
            cmd.Parameters.AddWithValue("@CostDetails", details.Text);
            cmd.Parameters.AddWithValue("@CostDate", this.dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@BrID", br_id.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data successfully inserted.");
            GetCostRecord();
            ResetFormData();
        }

        private void ResetFormData()
        {
            this.id = 0;
            cid.Clear();
            cname.Clear();
            unit.Clear();
            quantity.Clear();
            total.Clear();
            details.Clear();
            dateTimePicker1.Value = DateTime.Now;
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
                cmd.CommandText = "UPDATE cost SET c_name = @CostName, unit = @CostUnit, details = @CostDetails, c_date = @CostDate, br_id = @BrID WHERE c_id = @CostID";
                cmd.Parameters.AddWithValue("@CostID", this.id);
                cmd.Parameters.AddWithValue("@CostName", cname.Text);
                cmd.Parameters.AddWithValue("@CostUnit", unit.Text);
                cmd.Parameters.AddWithValue("@CostQuantity", quantity.Text);
                double up = Convert.ToDouble(unit.Text);
                double qnt = Convert.ToDouble(quantity.Text);
                double total = up * qnt;
                cmd.Parameters.AddWithValue("@CostTotal", total);
                cmd.Parameters.AddWithValue("@CostDetails", details.Text);
                cmd.Parameters.AddWithValue("@CostDate", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@BrID", br_id.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully updated.");
                GetCostRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a transaction.");
            }
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            ResetFormData();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (this.id != 0)
            {
                MySqlConnection con = new MySqlConnection(ConnectionDB.ConnectionString());
                con.Open();

                MySqlCommand cmd;
                cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM cost WHERE c_id = @CostID";
                cmd.Parameters.AddWithValue("@CostID", this.id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data successfully deleted.");
                GetCostRecord();
                ResetFormData();
            }
            else
            {
                MessageBox.Show("Please, select a transaction.");
            }
        }
    }
}
