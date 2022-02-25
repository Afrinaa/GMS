namespace GMS
{
    partial class Staff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reset_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.StaffView = new System.Windows.Forms.DataGridView();
            this.br_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.joindate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.wage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.work = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.snum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            this.SuspendLayout();
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.Location = new System.Drawing.Point(620, 202);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 61;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(338, 202);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 60;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(479, 202);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 59;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.Black;
            this.insert_btn.Location = new System.Drawing.Point(197, 202);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 58;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // StaffView
            // 
            this.StaffView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffView.Location = new System.Drawing.Point(12, 257);
            this.StaffView.Name = "StaffView";
            this.StaffView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StaffView.Size = new System.Drawing.Size(857, 243);
            this.StaffView.TabIndex = 57;
            this.StaffView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffView_CellContentClick);
            // 
            // br_id
            // 
            this.br_id.BackColor = System.Drawing.SystemColors.Window;
            this.br_id.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_id.Location = new System.Drawing.Point(539, 153);
            this.br_id.Name = "br_id";
            this.br_id.Size = new System.Drawing.Size(330, 23);
            this.br_id.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(476, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Branch";
            // 
            // joindate
            // 
            this.joindate.BackColor = System.Drawing.SystemColors.Window;
            this.joindate.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joindate.Location = new System.Drawing.Point(539, 124);
            this.joindate.Name = "joindate";
            this.joindate.Size = new System.Drawing.Size(330, 23);
            this.joindate.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(462, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 53;
            this.label8.Text = "Join Date";
            // 
            // wage
            // 
            this.wage.BackColor = System.Drawing.SystemColors.Window;
            this.wage.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wage.Location = new System.Drawing.Point(539, 95);
            this.wage.Name = "wage";
            this.wage.Size = new System.Drawing.Size(330, 23);
            this.wage.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(489, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Wage";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // work
            // 
            this.work.BackColor = System.Drawing.SystemColors.Window;
            this.work.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work.Location = new System.Drawing.Point(539, 66);
            this.work.Name = "work";
            this.work.Size = new System.Drawing.Size(330, 23);
            this.work.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(489, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Work";
            // 
            // snum
            // 
            this.snum.BackColor = System.Drawing.SystemColors.Window;
            this.snum.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snum.Location = new System.Drawing.Point(113, 153);
            this.snum.Name = "snum";
            this.snum.Size = new System.Drawing.Size(330, 23);
            this.snum.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Contact";
            // 
            // saddress
            // 
            this.saddress.BackColor = System.Drawing.SystemColors.Window;
            this.saddress.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saddress.Location = new System.Drawing.Point(113, 124);
            this.saddress.Name = "saddress";
            this.saddress.Size = new System.Drawing.Size(330, 23);
            this.saddress.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Address";
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.SystemColors.Window;
            this.sname.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.Location = new System.Drawing.Point(113, 95);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(330, 23);
            this.sname.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Name";
            // 
            // sid
            // 
            this.sid.BackColor = System.Drawing.SystemColors.Window;
            this.sid.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sid.Location = new System.Drawing.Point(113, 66);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(330, 23);
            this.sid.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 41;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(815, -14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "X";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(332, 21);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 31);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Staff Details";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(855, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "X";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 512);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.StaffView);
            this.Controls.Add(this.br_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.joindate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.wage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.work);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.snum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.DataGridView StaffView;
        private System.Windows.Forms.TextBox br_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox joindate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox wage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox work;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox snum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label10;
    }
}