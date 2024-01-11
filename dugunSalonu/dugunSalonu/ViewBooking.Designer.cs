namespace dugunSalonu
{
    partial class ViewBooking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BookingDGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustIdCb = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CustNamelbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WaterPrice = new System.Windows.Forms.TextBox();
            this.WinePrice = new System.Windows.Forms.TextBox();
            this.SodaPrice = new System.Windows.Forms.TextBox();
            this.PersonnoCb = new System.Windows.Forms.TextBox();
            this.BDateCb = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 47);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Harrington", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1303, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Harrington", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "View Booking ";
            // 
            // BookingDGV
            // 
            this.BookingDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.BookingDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookingDGV.Location = new System.Drawing.Point(182, 147);
            this.BookingDGV.Name = "BookingDGV";
            this.BookingDGV.RowHeadersWidth = 51;
            this.BookingDGV.RowTemplate.Height = 24;
            this.BookingDGV.Size = new System.Drawing.Size(1039, 353);
            this.BookingDGV.TabIndex = 2;
            this.BookingDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(365, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 18;
            this.button1.Text = "Delete Booking ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(818, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 17;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(565, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Booking List";
            // 
            // CustIdCb
            // 
            this.CustIdCb.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustIdCb.FormattingEnabled = true;
            this.CustIdCb.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.CustIdCb.Location = new System.Drawing.Point(235, 72);
            this.CustIdCb.Name = "CustIdCb";
            this.CustIdCb.Size = new System.Drawing.Size(121, 29);
            this.CustIdCb.TabIndex = 20;
            this.CustIdCb.SelectedIndexChanged += new System.EventHandler(this.CustIdCb_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(61, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(154, 32);
            this.label17.TabIndex = 21;
            this.label17.Text = "CustomerId";
            // 
            // CustNamelbl
            // 
            this.CustNamelbl.AutoSize = true;
            this.CustNamelbl.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustNamelbl.ForeColor = System.Drawing.Color.Navy;
            this.CustNamelbl.Location = new System.Drawing.Point(378, 69);
            this.CustNamelbl.Name = "CustNamelbl";
            this.CustNamelbl.Size = new System.Drawing.Size(0, 32);
            this.CustNamelbl.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.groupBox1.Controls.Add(this.BDateCb);
            this.groupBox1.Controls.Add(this.WaterPrice);
            this.groupBox1.Controls.Add(this.WinePrice);
            this.groupBox1.Controls.Add(this.SodaPrice);
            this.groupBox1.Controls.Add(this.PersonnoCb);
            this.groupBox1.Location = new System.Drawing.Point(537, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 301);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // WaterPrice
            // 
            this.WaterPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WaterPrice.Enabled = false;
            this.WaterPrice.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WaterPrice.Location = new System.Drawing.Point(105, 248);
            this.WaterPrice.Name = "WaterPrice";
            this.WaterPrice.Size = new System.Drawing.Size(93, 29);
            this.WaterPrice.TabIndex = 21;
            // 
            // WinePrice
            // 
            this.WinePrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.WinePrice.Enabled = false;
            this.WinePrice.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinePrice.Location = new System.Drawing.Point(105, 191);
            this.WinePrice.Name = "WinePrice";
            this.WinePrice.Size = new System.Drawing.Size(93, 29);
            this.WinePrice.TabIndex = 20;
            // 
            // SodaPrice
            // 
            this.SodaPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SodaPrice.Enabled = false;
            this.SodaPrice.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SodaPrice.Location = new System.Drawing.Point(105, 139);
            this.SodaPrice.Name = "SodaPrice";
            this.SodaPrice.Size = new System.Drawing.Size(93, 29);
            this.SodaPrice.TabIndex = 19;
            // 
            // PersonnoCb
            // 
            this.PersonnoCb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PersonnoCb.Enabled = false;
            this.PersonnoCb.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonnoCb.Location = new System.Drawing.Point(105, 81);
            this.PersonnoCb.Name = "PersonnoCb";
            this.PersonnoCb.Size = new System.Drawing.Size(93, 29);
            this.PersonnoCb.TabIndex = 18;
            // 
            // BDateCb
            // 
            this.BDateCb.Location = new System.Drawing.Point(56, 39);
            this.BDateCb.Name = "BDateCb";
            this.BDateCb.Size = new System.Drawing.Size(200, 22);
            this.BDateCb.TabIndex = 22;
            this.BDateCb.ValueChanged += new System.EventHandler(this.BDateCb_ValueChanged);
            // 
            // ViewBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 994);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CustNamelbl);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CustIdCb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BookingDGV);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBooking";
            this.Load += new System.EventHandler(this.ViewBooking_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookingDGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView BookingDGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CustIdCb;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label CustNamelbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox WaterPrice;
        private System.Windows.Forms.TextBox WinePrice;
        private System.Windows.Forms.TextBox SodaPrice;
        private System.Windows.Forms.TextBox PersonnoCb;
        private System.Windows.Forms.DateTimePicker BDateCb;
    }
}