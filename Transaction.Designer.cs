namespace GMS
{
    partial class Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaction));
            this.details = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reset_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.CostView = new System.Windows.Forms.DataGridView();
            this.br_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.quantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.refid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.preview_btn = new System.Windows.Forms.Button();
            this.receipt_btn = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.CostView)).BeginInit();
            this.SuspendLayout();
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.SystemColors.Window;
            this.details.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(91, 228);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(330, 23);
            this.details.TabIndex = 90;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(28, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 16);
            this.label10.TabIndex = 89;
            this.label10.Text = "Details";
            // 
            // reset_btn
            // 
            this.reset_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.ForeColor = System.Drawing.Color.Black;
            this.reset_btn.Location = new System.Drawing.Point(470, 333);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(75, 23);
            this.reset_btn.TabIndex = 88;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.ForeColor = System.Drawing.Color.Black;
            this.update_btn.Location = new System.Drawing.Point(186, 333);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 23);
            this.update_btn.TabIndex = 87;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.Black;
            this.delete_btn.Location = new System.Drawing.Point(328, 333);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 86;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.ForeColor = System.Drawing.Color.Black;
            this.insert_btn.Location = new System.Drawing.Point(44, 333);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 85;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // CostView
            // 
            this.CostView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CostView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CostView.Location = new System.Drawing.Point(6, 403);
            this.CostView.Name = "CostView";
            this.CostView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CostView.Size = new System.Drawing.Size(900, 184);
            this.CostView.TabIndex = 84;
            this.CostView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemberView_CellContentClick);
            // 
            // br_id
            // 
            this.br_id.BackColor = System.Drawing.SystemColors.Window;
            this.br_id.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.br_id.Location = new System.Drawing.Point(91, 286);
            this.br_id.Name = "br_id";
            this.br_id.Size = new System.Drawing.Size(330, 23);
            this.br_id.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(28, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 16);
            this.label9.TabIndex = 82;
            this.label9.Text = "Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(45, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Date";
            // 
            // unit
            // 
            this.unit.BackColor = System.Drawing.SystemColors.Window;
            this.unit.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(91, 112);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(330, 23);
            this.unit.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 76;
            this.label6.Text = "Unit Cost";
            // 
            // cname
            // 
            this.cname.BackColor = System.Drawing.SystemColors.Window;
            this.cname.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cname.Location = new System.Drawing.Point(91, 83);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(330, 23);
            this.cname.TabIndex = 71;
            this.cname.TextChanged += new System.EventHandler(this.cname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Name";
            // 
            // cid
            // 
            this.cid.BackColor = System.Drawing.SystemColors.Window;
            this.cid.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cid.Location = new System.Drawing.Point(91, 54);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(330, 23);
            this.cid.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 68;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(892, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Broadway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(315, 8);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(298, 31);
            this.linkLabel1.TabIndex = 66;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Transaction Details";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(91, 259);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 23);
            this.dateTimePicker1.TabIndex = 91;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // quantity
            // 
            this.quantity.BackColor = System.Drawing.SystemColors.Window;
            this.quantity.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(91, 141);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(330, 23);
            this.quantity.TabIndex = 93;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "Quantity";
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.Window;
            this.total.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(91, 170);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(330, 23);
            this.total.TabIndex = 95;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 94;
            this.label5.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 16);
            this.label8.TabIndex = 96;
            this.label8.Text = "Transaction between ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(427, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 16);
            this.label11.TabIndex = 99;
            this.label11.Text = "to";
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.Black;
            this.search_btn.Location = new System.Drawing.Point(664, 371);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 100;
            this.search_btn.Text = "search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Mimmo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(227, 374);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker2.TabIndex = 101;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker3.Font = new System.Drawing.Font("Mimmo", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(464, 374);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker3.TabIndex = 102;
            // 
            // refid
            // 
            this.refid.BackColor = System.Drawing.SystemColors.Window;
            this.refid.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refid.Location = new System.Drawing.Point(91, 198);
            this.refid.Name = "refid";
            this.refid.Size = new System.Drawing.Size(330, 23);
            this.refid.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(32, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 103;
            this.label12.Text = "Ref ID";
            // 
            // print_btn
            // 
            this.print_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.ForeColor = System.Drawing.Color.Black;
            this.print_btn.Location = new System.Drawing.Point(741, 371);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(75, 23);
            this.print_btn.TabIndex = 105;
            this.print_btn.Text = "print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // preview_btn
            // 
            this.preview_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preview_btn.ForeColor = System.Drawing.Color.Black;
            this.preview_btn.Location = new System.Drawing.Point(612, 333);
            this.preview_btn.Name = "preview_btn";
            this.preview_btn.Size = new System.Drawing.Size(75, 23);
            this.preview_btn.TabIndex = 106;
            this.preview_btn.Text = "Preview";
            this.preview_btn.UseVisualStyleBackColor = true;
            this.preview_btn.Click += new System.EventHandler(this.preview_btn_Click);
            // 
            // receipt_btn
            // 
            this.receipt_btn.Font = new System.Drawing.Font("Mimmo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt_btn.ForeColor = System.Drawing.Color.Black;
            this.receipt_btn.Location = new System.Drawing.Point(754, 333);
            this.receipt_btn.Name = "receipt_btn";
            this.receipt_btn.Size = new System.Drawing.Size(75, 23);
            this.receipt_btn.TabIndex = 107;
            this.receipt_btn.Text = "Receipt";
            this.receipt_btn.UseVisualStyleBackColor = true;
            this.receipt_btn.Click += new System.EventHandler(this.receipt_btn_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(430, 50);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(476, 258);
            this.txtResult.TabIndex = 108;
            this.txtResult.Text = "";
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(918, 599);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.receipt_btn);
            this.Controls.Add(this.preview_btn);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.refid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.details);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.CostView);
            this.Controls.Add(this.br_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Transaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CostView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.DataGridView CostView;
        private System.Windows.Forms.TextBox br_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox refid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button print_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button preview_btn;
        public System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Button receipt_btn;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}