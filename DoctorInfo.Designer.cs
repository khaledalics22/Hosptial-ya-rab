namespace Hospital_ISA
{
    partial class DoctorInfo
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.DrName = new System.Windows.Forms.Label();
            this.DocPhone = new System.Windows.Forms.Label();
            this.DocDep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DocShiftFromTo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.DocGender = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DocAge = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Blue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.MaximumSize = new System.Drawing.Size(1024, 70);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(802, 70);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "Doctor Info.";
            // 
            // DrName
            // 
            this.DrName.AutoSize = true;
            this.DrName.BackColor = System.Drawing.Color.White;
            this.DrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrName.ForeColor = System.Drawing.Color.Blue;
            this.DrName.Location = new System.Drawing.Point(13, 92);
            this.DrName.Name = "DrName";
            this.DrName.Size = new System.Drawing.Size(93, 29);
            this.DrName.TabIndex = 10;
            this.DrName.Text = "Name:";
            // 
            // DocPhone
            // 
            this.DocPhone.AutoSize = true;
            this.DocPhone.BackColor = System.Drawing.Color.White;
            this.DocPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPhone.ForeColor = System.Drawing.Color.Blue;
            this.DocPhone.Location = new System.Drawing.Point(12, 184);
            this.DocPhone.Name = "DocPhone";
            this.DocPhone.Size = new System.Drawing.Size(122, 20);
            this.DocPhone.TabIndex = 11;
            this.DocPhone.Text = "Phone number:";
            // 
            // DocDep
            // 
            this.DocDep.AutoSize = true;
            this.DocDep.BackColor = System.Drawing.Color.White;
            this.DocDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDep.ForeColor = System.Drawing.Color.Blue;
            this.DocDep.Location = new System.Drawing.Point(12, 254);
            this.DocDep.Name = "DocDep";
            this.DocDep.Size = new System.Drawing.Size(113, 20);
            this.DocDep.TabIndex = 12;
            this.DocDep.Text = "Specialization";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(14, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Shift";
            // 
            // DocShiftFromTo
            // 
            this.DocShiftFromTo.AutoSize = true;
            this.DocShiftFromTo.BackColor = System.Drawing.Color.White;
            this.DocShiftFromTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocShiftFromTo.ForeColor = System.Drawing.Color.Blue;
            this.DocShiftFromTo.Location = new System.Drawing.Point(106, 408);
            this.DocShiftFromTo.Name = "DocShiftFromTo";
            this.DocShiftFromTo.Size = new System.Drawing.Size(151, 20);
            this.DocShiftFromTo.TabIndex = 14;
            this.DocShiftFromTo.Text = "From 9 am to 2 pm";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Blue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(657, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Text = "Date";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 240);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(649, 421);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Book";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DocGender
            // 
            this.DocGender.AutoSize = true;
            this.DocGender.BackColor = System.Drawing.Color.White;
            this.DocGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocGender.ForeColor = System.Drawing.Color.Blue;
            this.DocGender.Location = new System.Drawing.Point(12, 323);
            this.DocGender.Name = "DocGender";
            this.DocGender.Size = new System.Drawing.Size(64, 20);
            this.DocGender.TabIndex = 20;
            this.DocGender.Text = "Gender";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_ISA.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(16, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DocAge
            // 
            this.DocAge.AutoSize = true;
            this.DocAge.BackColor = System.Drawing.Color.White;
            this.DocAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAge.ForeColor = System.Drawing.Color.Blue;
            this.DocAge.Location = new System.Drawing.Point(14, 147);
            this.DocAge.Name = "DocAge";
            this.DocAge.Size = new System.Drawing.Size(122, 20);
            this.DocAge.TabIndex = 21;
            this.DocAge.Text = "Phone number:";
            // 
            // DoctorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.DocAge);
            this.Controls.Add(this.DocGender);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DocShiftFromTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DocDep);
            this.Controls.Add(this.DocPhone);
            this.Controls.Add(this.DrName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitter1);
            this.Name = "DoctorInfo";
            this.Text = "DoctorInfo";
            this.Load += new System.EventHandler(this.DoctorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DrName;
        private System.Windows.Forms.Label DocPhone;
        private System.Windows.Forms.Label DocDep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DocShiftFromTo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DocGender;
        private System.Windows.Forms.Label DocAge;
    }
}