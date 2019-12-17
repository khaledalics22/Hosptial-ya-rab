namespace Hospital_ISA
{
    partial class EditNurse
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
            this.ShiftComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.LnameTextBox = new System.Windows.Forms.TextBox();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.FnameTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ClinicShiftComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.AssignRoomGridView = new System.Windows.Forms.DataGridView();
            this.RemoveRoomGridView = new System.Windows.Forms.DataGridView();
            this.ClinicGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AssignRoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ShiftComboBox
            // 
            this.ShiftComboBox.BackColor = System.Drawing.Color.White;
            this.ShiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShiftComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShiftComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShiftComboBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ShiftComboBox.FormattingEnabled = true;
            this.ShiftComboBox.ItemHeight = 31;
            this.ShiftComboBox.Items.AddRange(new object[] {
            "06:00:00",
            "12:00:00",
            "18:00:00"});
            this.ShiftComboBox.Location = new System.Drawing.Point(710, 246);
            this.ShiftComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShiftComboBox.Name = "ShiftComboBox";
            this.ShiftComboBox.Size = new System.Drawing.Size(232, 39);
            this.ShiftComboBox.TabIndex = 85;
            this.ShiftComboBox.SelectedIndexChanged += new System.EventHandler(this.ShiftComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(625, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 84;
            this.label2.Text = "Shift:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(582, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 81;
            this.label3.Text = "Clinic:";
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Enabled = false;
            this.SSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SSNTextBox.Location = new System.Drawing.Point(173, 107);
            this.SSNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(376, 38);
            this.SSNTextBox.TabIndex = 80;
            this.SSNTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(77, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 31);
            this.label6.TabIndex = 79;
            this.label6.Text = "SSN:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.PhoneTextBox.Location = new System.Drawing.Point(173, 315);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(376, 41);
            this.PhoneTextBox.TabIndex = 76;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AgeTextBox.Location = new System.Drawing.Point(783, 114);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(129, 41);
            this.AgeTextBox.TabIndex = 75;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.LnameTextBox.Location = new System.Drawing.Point(173, 248);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(376, 41);
            this.LnameTextBox.TabIndex = 74;
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SalaryTextBox.Location = new System.Drawing.Point(783, 181);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(129, 41);
            this.SalaryTextBox.TabIndex = 73;
            // 
            // FnameTextBox
            // 
            this.FnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.FnameTextBox.Location = new System.Drawing.Point(173, 181);
            this.FnameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FnameTextBox.Name = "FnameTextBox";
            this.FnameTextBox.Size = new System.Drawing.Size(376, 41);
            this.FnameTextBox.TabIndex = 72;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(14, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 31);
            this.label10.TabIndex = 71;
            this.label10.Text = "Last Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(55, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 31);
            this.label8.TabIndex = 69;
            this.label8.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(704, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 31);
            this.label5.TabIndex = 67;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(683, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 66;
            this.label4.Text = "Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "First Name:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(956, 98);
            this.button3.TabIndex = 64;
            this.button3.Text = "Edit Nurse";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ClinicShiftComboBox
            // 
            this.ClinicShiftComboBox.BackColor = System.Drawing.Color.White;
            this.ClinicShiftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClinicShiftComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClinicShiftComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClinicShiftComboBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ClinicShiftComboBox.FormattingEnabled = true;
            this.ClinicShiftComboBox.ItemHeight = 31;
            this.ClinicShiftComboBox.Location = new System.Drawing.Point(710, 467);
            this.ClinicShiftComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClinicShiftComboBox.Name = "ClinicShiftComboBox";
            this.ClinicShiftComboBox.Size = new System.Drawing.Size(232, 39);
            this.ClinicShiftComboBox.TabIndex = 87;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(520, 470);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(151, 31);
            this.label13.TabIndex = 88;
            this.label13.Text = "Clinic Shift:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(335, 551);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(111, 54);
            this.RemoveButton.TabIndex = 94;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(801, 538);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(141, 67);
            this.SaveButton.TabIndex = 92;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AssignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignButton.ForeColor = System.Drawing.Color.White;
            this.AssignButton.Location = new System.Drawing.Point(61, 551);
            this.AssignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(110, 54);
            this.AssignButton.TabIndex = 91;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = false;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // AssignRoomGridView
            // 
            this.AssignRoomGridView.AllowUserToAddRows = false;
            this.AssignRoomGridView.AllowUserToDeleteRows = false;
            this.AssignRoomGridView.AllowUserToResizeColumns = false;
            this.AssignRoomGridView.AllowUserToResizeRows = false;
            this.AssignRoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.AssignRoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssignRoomGridView.GridColor = System.Drawing.Color.DodgerBlue;
            this.AssignRoomGridView.Location = new System.Drawing.Point(49, 396);
            this.AssignRoomGridView.MultiSelect = false;
            this.AssignRoomGridView.Name = "AssignRoomGridView";
            this.AssignRoomGridView.ReadOnly = true;
            this.AssignRoomGridView.RowHeadersVisible = false;
            this.AssignRoomGridView.RowHeadersWidth = 51;
            this.AssignRoomGridView.RowTemplate.Height = 24;
            this.AssignRoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AssignRoomGridView.Size = new System.Drawing.Size(137, 150);
            this.AssignRoomGridView.TabIndex = 95;
            this.AssignRoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AssignRoomGridView_CellContentClick);
            this.AssignRoomGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AssignRoomGridView_CellMouseClick);
            // 
            // RemoveRoomGridView
            // 
            this.RemoveRoomGridView.AllowUserToAddRows = false;
            this.RemoveRoomGridView.AllowUserToDeleteRows = false;
            this.RemoveRoomGridView.AllowUserToResizeColumns = false;
            this.RemoveRoomGridView.AllowUserToResizeRows = false;
            this.RemoveRoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.RemoveRoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemoveRoomGridView.Location = new System.Drawing.Point(320, 396);
            this.RemoveRoomGridView.MultiSelect = false;
            this.RemoveRoomGridView.Name = "RemoveRoomGridView";
            this.RemoveRoomGridView.ReadOnly = true;
            this.RemoveRoomGridView.RowHeadersVisible = false;
            this.RemoveRoomGridView.RowHeadersWidth = 51;
            this.RemoveRoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RemoveRoomGridView.Size = new System.Drawing.Size(137, 150);
            this.RemoveRoomGridView.TabIndex = 96;
            this.RemoveRoomGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveRoomGridView_CellContentClick);
            this.RemoveRoomGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RemoveRoomGridView_CellMouseClick);
            // 
            // ClinicGridView
            // 
            this.ClinicGridView.AllowUserToAddRows = false;
            this.ClinicGridView.AllowUserToDeleteRows = false;
            this.ClinicGridView.AllowUserToResizeColumns = false;
            this.ClinicGridView.AllowUserToResizeRows = false;
            this.ClinicGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClinicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClinicGridView.Location = new System.Drawing.Point(710, 312);
            this.ClinicGridView.MultiSelect = false;
            this.ClinicGridView.Name = "ClinicGridView";
            this.ClinicGridView.ReadOnly = true;
            this.ClinicGridView.RowHeadersVisible = false;
            this.ClinicGridView.RowHeadersWidth = 51;
            this.ClinicGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.ClinicGridView.Size = new System.Drawing.Size(137, 150);
            this.ClinicGridView.TabIndex = 97;
            this.ClinicGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClinicGridView_CellMouseClick);
            // 
            // EditNurse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 616);
            this.Controls.Add(this.ClinicGridView);
            this.Controls.Add(this.RemoveRoomGridView);
            this.Controls.Add(this.AssignRoomGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ClinicShiftComboBox);
            this.Controls.Add(this.ShiftComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AgeTextBox);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.FnameTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditNurse";
            this.Text = "EditNurse";
            this.Load += new System.EventHandler(this.EditNurse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AssignRoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClinicGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ShiftComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox LnameTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox FnameTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ClinicShiftComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.DataGridView AssignRoomGridView;
        private System.Windows.Forms.DataGridView RemoveRoomGridView;
        private System.Windows.Forms.DataGridView ClinicGridView;
    }
}