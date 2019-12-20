namespace Hospital_ISA
{
    partial class EditDoctor
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
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DocDepCombo = new System.Windows.Forms.ComboBox();
            this.DocCity = new System.Windows.Forms.TextBox();
            this.DocAge = new System.Windows.Forms.TextBox();
            this.DocPhone = new System.Windows.Forms.TextBox();
            this.DocSalary = new System.Windows.Forms.TextBox();
            this.DocFName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DocShiftCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.DocAvailableRoomsCombo = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DocClinicCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DocNewSSN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.DocCurrRoomsGrid = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.DocClinicShiftsGrid = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.DocAvailableClinicShiftsCombo = new System.Windows.Forms.ComboBox();
            this.DocStreet = new System.Windows.Forms.TextBox();
            this.DocLName = new System.Windows.Forms.TextBox();
            this.DocHouseNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.roomsAssigned = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DocCurrRoomsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocClinicShiftsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, -2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1291, 98);
            this.button3.TabIndex = 10;
            this.button3.Text = "Edit Doctor";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 31;
            this.comboBox2.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox2.Location = new System.Drawing.Point(1073, 262);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 39);
            this.comboBox2.TabIndex = 47;
            // 
            // DocDepCombo
            // 
            this.DocDepCombo.BackColor = System.Drawing.Color.White;
            this.DocDepCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocDepCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocDepCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocDepCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocDepCombo.FormattingEnabled = true;
            this.DocDepCombo.ItemHeight = 31;
            this.DocDepCombo.Items.AddRange(new object[] {
            "Doctors",
            "Nurses",
            "Employees",
            "Patients"});
            this.DocDepCombo.Location = new System.Drawing.Point(200, 252);
            this.DocDepCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocDepCombo.Name = "DocDepCombo";
            this.DocDepCombo.Size = new System.Drawing.Size(273, 39);
            this.DocDepCombo.TabIndex = 46;
            // 
            // DocCity
            // 
            this.DocCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocCity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocCity.Location = new System.Drawing.Point(156, 314);
            this.DocCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocCity.Name = "DocCity";
            this.DocCity.Size = new System.Drawing.Size(156, 41);
            this.DocCity.TabIndex = 45;
            // 
            // DocAge
            // 
            this.DocAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAge.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocAge.Location = new System.Drawing.Point(1058, 118);
            this.DocAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocAge.Name = "DocAge";
            this.DocAge.Size = new System.Drawing.Size(129, 41);
            this.DocAge.TabIndex = 44;
            // 
            // DocPhone
            // 
            this.DocPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocPhone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocPhone.Location = new System.Drawing.Point(249, 188);
            this.DocPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocPhone.Name = "DocPhone";
            this.DocPhone.Size = new System.Drawing.Size(285, 41);
            this.DocPhone.TabIndex = 43;
            // 
            // DocSalary
            // 
            this.DocSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocSalary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocSalary.Location = new System.Drawing.Point(1058, 184);
            this.DocSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocSalary.Name = "DocSalary";
            this.DocSalary.Size = new System.Drawing.Size(129, 41);
            this.DocSalary.TabIndex = 42;
            // 
            // DocFName
            // 
            this.DocFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocFName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocFName.Location = new System.Drawing.Point(137, 116);
            this.DocFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocFName.Name = "DocFName";
            this.DocFName.Size = new System.Drawing.Size(140, 41);
            this.DocFName.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(24, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(203, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Phone Number:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label9.Location = new System.Drawing.Point(30, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 31);
            this.label9.TabIndex = 39;
            this.label9.Text = "Department:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(30, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 31);
            this.label8.TabIndex = 38;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(958, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 31);
            this.label7.TabIndex = 37;
            this.label7.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(979, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 31);
            this.label5.TabIndex = 36;
            this.label5.Text = "Age:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(958, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 35;
            this.label4.Text = "Salary:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(24, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 34;
            this.label1.Text = "Name:";
            // 
            // DocShiftCombo
            // 
            this.DocShiftCombo.BackColor = System.Drawing.Color.White;
            this.DocShiftCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocShiftCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocShiftCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocShiftCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocShiftCombo.FormattingEnabled = true;
            this.DocShiftCombo.ItemHeight = 31;
            this.DocShiftCombo.Items.AddRange(new object[] {
            "06:00 : 12:00",
            "12:00 : 18:00",
            "18:00 : 24:00",
            "",
            ""});
            this.DocShiftCombo.Location = new System.Drawing.Point(956, 380);
            this.DocShiftCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocShiftCombo.Name = "DocShiftCombo";
            this.DocShiftCombo.Size = new System.Drawing.Size(232, 39);
            this.DocShiftCombo.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(870, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "Shift:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1089, 677);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 68);
            this.button5.TabIndex = 55;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AssignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignButton.ForeColor = System.Drawing.Color.White;
            this.AssignButton.Location = new System.Drawing.Point(674, 697);
            this.AssignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(110, 38);
            this.AssignButton.TabIndex = 54;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = false;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // DocAvailableRoomsCombo
            // 
            this.DocAvailableRoomsCombo.BackColor = System.Drawing.Color.White;
            this.DocAvailableRoomsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocAvailableRoomsCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocAvailableRoomsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAvailableRoomsCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocAvailableRoomsCombo.FormattingEnabled = true;
            this.DocAvailableRoomsCombo.ItemHeight = 31;
            this.DocAvailableRoomsCombo.Items.AddRange(new object[] {
            "Doctors",
            "Nurses",
            "Employees",
            "Patients"});
            this.DocAvailableRoomsCombo.Location = new System.Drawing.Point(674, 627);
            this.DocAvailableRoomsCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocAvailableRoomsCombo.Name = "DocAvailableRoomsCombo";
            this.DocAvailableRoomsCombo.Size = new System.Drawing.Size(111, 39);
            this.DocAvailableRoomsCombo.TabIndex = 53;
            this.DocAvailableRoomsCombo.SelectedIndexChanged += new System.EventHandler(this.DocAvailableRoomsCombo_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label12.Location = new System.Drawing.Point(938, 445);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(224, 31);
            this.label12.TabIndex = 52;
            this.label12.Text = "Reserved Rooms";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // DocClinicCombo
            // 
            this.DocClinicCombo.BackColor = System.Drawing.Color.White;
            this.DocClinicCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocClinicCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocClinicCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocClinicCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocClinicCombo.FormattingEnabled = true;
            this.DocClinicCombo.ItemHeight = 31;
            this.DocClinicCombo.Location = new System.Drawing.Point(124, 443);
            this.DocClinicCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocClinicCombo.Name = "DocClinicCombo";
            this.DocClinicCombo.Size = new System.Drawing.Size(111, 39);
            this.DocClinicCombo.TabIndex = 51;
            this.DocClinicCombo.SelectedIndexChanged += new System.EventHandler(this.DocClinicCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(24, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 31);
            this.label3.TabIndex = 50;
            this.label3.Text = "Clinic:";
            // 
            // DocNewSSN
            // 
            this.DocNewSSN.Enabled = false;
            this.DocNewSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocNewSSN.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocNewSSN.Location = new System.Drawing.Point(113, 472);
            this.DocNewSSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocNewSSN.Name = "DocNewSSN";
            this.DocNewSSN.Size = new System.Drawing.Size(239, 38);
            this.DocNewSSN.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(30, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 31);
            this.label6.TabIndex = 48;
            this.label6.Text = "SSN:";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(883, 627);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(110, 40);
            this.removeButton.TabIndex = 62;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // DocCurrRoomsGrid
            // 
            this.DocCurrRoomsGrid.AllowUserToAddRows = false;
            this.DocCurrRoomsGrid.AllowUserToDeleteRows = false;
            this.DocCurrRoomsGrid.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DocCurrRoomsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocCurrRoomsGrid.Location = new System.Drawing.Point(883, 485);
            this.DocCurrRoomsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocCurrRoomsGrid.Name = "DocCurrRoomsGrid";
            this.DocCurrRoomsGrid.ReadOnly = true;
            this.DocCurrRoomsGrid.RowHeadersWidth = 62;
            this.DocCurrRoomsGrid.RowTemplate.Height = 28;
            this.DocCurrRoomsGrid.Size = new System.Drawing.Size(331, 132);
            this.DocCurrRoomsGrid.TabIndex = 63;
            this.DocCurrRoomsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocCurrRoomsGrid_CellMouseClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(21, 563);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 52);
            this.button2.TabIndex = 101;
            this.button2.Text = "Reserved Shifts";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // DocClinicShiftsGrid
            // 
            this.DocClinicShiftsGrid.AllowUserToAddRows = false;
            this.DocClinicShiftsGrid.AllowUserToDeleteRows = false;
            this.DocClinicShiftsGrid.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.DocClinicShiftsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DocClinicShiftsGrid.Location = new System.Drawing.Point(137, 563);
            this.DocClinicShiftsGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocClinicShiftsGrid.MultiSelect = false;
            this.DocClinicShiftsGrid.Name = "DocClinicShiftsGrid";
            this.DocClinicShiftsGrid.ReadOnly = true;
            this.DocClinicShiftsGrid.RowHeadersWidth = 62;
            this.DocClinicShiftsGrid.RowTemplate.Height = 28;
            this.DocClinicShiftsGrid.Size = new System.Drawing.Size(275, 131);
            this.DocClinicShiftsGrid.TabIndex = 100;
            this.DocClinicShiftsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DocClinicShiftsGrid_CellMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label13.Location = new System.Drawing.Point(24, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 31);
            this.label13.TabIndex = 99;
            this.label13.Text = "Shift:";
            // 
            // DocAvailableClinicShiftsCombo
            // 
            this.DocAvailableClinicShiftsCombo.BackColor = System.Drawing.Color.White;
            this.DocAvailableClinicShiftsCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DocAvailableClinicShiftsCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DocAvailableClinicShiftsCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocAvailableClinicShiftsCombo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocAvailableClinicShiftsCombo.FormattingEnabled = true;
            this.DocAvailableClinicShiftsCombo.ItemHeight = 31;
            this.DocAvailableClinicShiftsCombo.Items.AddRange(new object[] {
            "06:00 : 09:00",
            "09:00 : 12:00",
            "12:00 : 15:00",
            "15:00 : 18:00",
            "18:00 : 21:00",
            "21:00 : 24:00",
            "",
            "",
            ""});
            this.DocAvailableClinicShiftsCombo.Location = new System.Drawing.Point(124, 494);
            this.DocAvailableClinicShiftsCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocAvailableClinicShiftsCombo.Name = "DocAvailableClinicShiftsCombo";
            this.DocAvailableClinicShiftsCombo.Size = new System.Drawing.Size(232, 39);
            this.DocAvailableClinicShiftsCombo.TabIndex = 98;
            // 
            // DocStreet
            // 
            this.DocStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocStreet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocStreet.Location = new System.Drawing.Point(333, 314);
            this.DocStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocStreet.Name = "DocStreet";
            this.DocStreet.Size = new System.Drawing.Size(140, 41);
            this.DocStreet.TabIndex = 102;
            // 
            // DocLName
            // 
            this.DocLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocLName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocLName.Location = new System.Drawing.Point(311, 121);
            this.DocLName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocLName.Name = "DocLName";
            this.DocLName.Size = new System.Drawing.Size(140, 41);
            this.DocLName.TabIndex = 103;
            // 
            // DocHouseNum
            // 
            this.DocHouseNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocHouseNum.ForeColor = System.Drawing.Color.DodgerBlue;
            this.DocHouseNum.Location = new System.Drawing.Point(494, 314);
            this.DocHouseNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DocHouseNum.Name = "DocHouseNum";
            this.DocHouseNum.Size = new System.Drawing.Size(78, 41);
            this.DocHouseNum.TabIndex = 104;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label11.Location = new System.Drawing.Point(552, 630);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 31);
            this.label11.TabIndex = 105;
            this.label11.Text = "Rooms";
            // 
            // roomsAssigned
            // 
            this.roomsAssigned.AutoSize = true;
            this.roomsAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomsAssigned.ForeColor = System.Drawing.Color.DodgerBlue;
            this.roomsAssigned.Location = new System.Drawing.Point(808, 630);
            this.roomsAssigned.MaximumSize = new System.Drawing.Size(100, 0);
            this.roomsAssigned.Name = "roomsAssigned";
            this.roomsAssigned.Size = new System.Drawing.Size(0, 20);
            this.roomsAssigned.TabIndex = 106;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(302, 705);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 107;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 849);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.roomsAssigned);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DocHouseNum);
            this.Controls.Add(this.DocLName);
            this.Controls.Add(this.DocStreet);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DocClinicShiftsGrid);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.DocAvailableClinicShiftsCombo);
            this.Controls.Add(this.DocCurrRoomsGrid);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.DocShiftCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.DocAvailableRoomsCombo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DocClinicCombo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DocNewSSN);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.DocDepCombo);
            this.Controls.Add(this.DocCity);
            this.Controls.Add(this.DocAge);
            this.Controls.Add(this.DocPhone);
            this.Controls.Add(this.DocSalary);
            this.Controls.Add(this.DocFName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EditDoctor";
            this.Text = "EditDoctor";
            this.Load += new System.EventHandler(this.EditDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DocCurrRoomsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocClinicShiftsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox DocDepCombo;
        private System.Windows.Forms.TextBox DocCity;
        private System.Windows.Forms.TextBox DocAge;
        private System.Windows.Forms.TextBox DocPhone;
        private System.Windows.Forms.TextBox DocSalary;
        private System.Windows.Forms.TextBox DocFName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DocShiftCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.ComboBox DocAvailableRoomsCombo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox DocClinicCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DocNewSSN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView DocCurrRoomsGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView DocClinicShiftsGrid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox DocAvailableClinicShiftsCombo;
        private System.Windows.Forms.TextBox DocStreet;
        private System.Windows.Forms.TextBox DocLName;
        private System.Windows.Forms.TextBox DocHouseNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label roomsAssigned;
        private System.Windows.Forms.Button button1;
    }
}