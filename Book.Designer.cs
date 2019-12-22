namespace Hospital_ISA
{
    partial class Book
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.patiendFName = new System.Windows.Forms.TextBox();
            this.patientSSn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patiendLName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatientPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(356, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "Booking";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.MaximumSize = new System.Drawing.Size(1152, 88);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(902, 88);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // patiendFName
            // 
            this.patiendFName.BackColor = System.Drawing.Color.White;
            this.patiendFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patiendFName.ForeColor = System.Drawing.Color.Blue;
            this.patiendFName.Location = new System.Drawing.Point(150, 115);
            this.patiendFName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patiendFName.Name = "patiendFName";
            this.patiendFName.Size = new System.Drawing.Size(190, 41);
            this.patiendFName.TabIndex = 13;
            // 
            // patientSSn
            // 
            this.patientSSn.BackColor = System.Drawing.Color.White;
            this.patientSSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientSSn.ForeColor = System.Drawing.Color.Blue;
            this.patientSSn.Location = new System.Drawing.Point(226, 194);
            this.patientSSn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientSSn.Name = "patientSSn";
            this.patientSSn.Size = new System.Drawing.Size(347, 41);
            this.patientSSn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(36, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 36);
            this.label3.TabIndex = 16;
            this.label3.Text = "Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(252, 415);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_ISA.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // patiendLName
            // 
            this.patiendLName.BackColor = System.Drawing.Color.White;
            this.patiendLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patiendLName.ForeColor = System.Drawing.Color.Blue;
            this.patiendLName.Location = new System.Drawing.Point(363, 115);
            this.patiendLName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patiendLName.Name = "patiendLName";
            this.patiendLName.Size = new System.Drawing.Size(190, 41);
            this.patiendLName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(36, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone";
            // 
            // PatientPhone
            // 
            this.PatientPhone.BackColor = System.Drawing.Color.White;
            this.PatientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientPhone.ForeColor = System.Drawing.Color.Blue;
            this.PatientPhone.Location = new System.Drawing.Point(150, 332);
            this.PatientPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PatientPhone.Name = "PatientPhone";
            this.PatientPhone.Size = new System.Drawing.Size(347, 41);
            this.PatientPhone.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(36, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "National ID";
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.White;
            this.Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.Color.Blue;
            this.Pass.Location = new System.Drawing.Point(206, 261);
            this.Pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(347, 41);
            this.Pass.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Brown;
            this.label6.Location = new System.Drawing.Point(14, 540);
            this.label6.MaximumSize = new System.Drawing.Size(788, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(775, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "please, note that data is stored depending on your national ID, so if it exists t" +
    "he appointment will be submitted but with old data stored before. ";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 621);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PatientPhone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patiendLName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientSSn);
            this.Controls.Add(this.patiendFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox patiendFName;
        private System.Windows.Forms.TextBox patientSSn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox patiendLName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PatientPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pass;
        private System.Windows.Forms.Label label6;
    }
}