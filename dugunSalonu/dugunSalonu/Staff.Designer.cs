namespace dugunSalonu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.StaffGenderCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StaffNameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffPhoneTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffPassTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.StaffDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).BeginInit();
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
            this.label5.Size = new System.Drawing.Size(75, 35);
            this.label5.TabIndex = 3;
            this.label5.Text = "Staff";
            // 
            // StaffGenderCb
            // 
            this.StaffGenderCb.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffGenderCb.FormattingEnabled = true;
            this.StaffGenderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.StaffGenderCb.Location = new System.Drawing.Point(671, 85);
            this.StaffGenderCb.Name = "StaffGenderCb";
            this.StaffGenderCb.Size = new System.Drawing.Size(136, 29);
            this.StaffGenderCb.TabIndex = 10;
            this.StaffGenderCb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(562, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Gender";
            // 
            // StaffNameTb
            // 
            this.StaffNameTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffNameTb.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameTb.Location = new System.Drawing.Point(101, 82);
            this.StaffNameTb.Name = "StaffNameTb";
            this.StaffNameTb.Size = new System.Drawing.Size(134, 29);
            this.StaffNameTb.TabIndex = 12;
            this.StaffNameTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // StaffPhoneTb
            // 
            this.StaffPhoneTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffPhoneTb.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPhoneTb.Location = new System.Drawing.Point(392, 82);
            this.StaffPhoneTb.Name = "StaffPhoneTb";
            this.StaffPhoneTb.Size = new System.Drawing.Size(134, 29);
            this.StaffPhoneTb.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(277, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Phone";
            // 
            // StaffPassTb
            // 
            this.StaffPassTb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StaffPassTb.Font = new System.Drawing.Font("Harrington", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffPassTb.Location = new System.Drawing.Point(1016, 82);
            this.StaffPassTb.Name = "StaffPassTb";
            this.StaffPassTb.Size = new System.Drawing.Size(145, 29);
            this.StaffPassTb.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(864, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Harrington", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(599, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 32);
            this.label6.TabIndex = 20;
            this.label6.Text = "Booking List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(294, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add Staff";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.Location = new System.Drawing.Point(747, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Delete Staff";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.Location = new System.Drawing.Point(516, 136);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 41);
            this.button4.TabIndex = 24;
            this.button4.Text = "Edit Staff";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.Location = new System.Drawing.Point(969, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 41);
            this.button5.TabIndex = 23;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.Location = new System.Drawing.Point(641, 635);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 41);
            this.button6.TabIndex = 25;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // StaffDGV
            // 
            this.StaffDGV.BackgroundColor = System.Drawing.Color.Beige;
            this.StaffDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDGV.GridColor = System.Drawing.Color.White;
            this.StaffDGV.Location = new System.Drawing.Point(132, 258);
            this.StaffDGV.Name = "StaffDGV";
            this.StaffDGV.RowHeadersWidth = 51;
            this.StaffDGV.RowTemplate.Height = 24;
            this.StaffDGV.Size = new System.Drawing.Size(1094, 371);
            this.StaffDGV.TabIndex = 39;
            this.StaffDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffDGV_CellContentClick);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 994);
            this.Controls.Add(this.StaffDGV);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StaffPassTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffPhoneTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffNameTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffGenderCb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox StaffGenderCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StaffNameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffPhoneTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StaffPassTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView StaffDGV;
    }
}