namespace Hospital_ISA
{
    partial class NurseAssignRoom
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
            this.RemoveRoomGridView = new System.Windows.Forms.DataGridView();
            this.AssignRoomGridView = new System.Windows.Forms.DataGridView();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AssignButton = new System.Windows.Forms.Button();
            this.SSNTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FinishButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignRoomGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(-1, -3);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(849, 98);
            this.button3.TabIndex = 65;
            this.button3.Text = "Nurse Assign Room";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // RemoveRoomGridView
            // 
            this.RemoveRoomGridView.AllowUserToAddRows = false;
            this.RemoveRoomGridView.AllowUserToDeleteRows = false;
            this.RemoveRoomGridView.AllowUserToResizeColumns = false;
            this.RemoveRoomGridView.AllowUserToResizeRows = false;
            this.RemoveRoomGridView.BackgroundColor = System.Drawing.Color.White;
            this.RemoveRoomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RemoveRoomGridView.Location = new System.Drawing.Point(352, 173);
            this.RemoveRoomGridView.MultiSelect = false;
            this.RemoveRoomGridView.Name = "RemoveRoomGridView";
            this.RemoveRoomGridView.ReadOnly = true;
            this.RemoveRoomGridView.RowHeadersVisible = false;
            this.RemoveRoomGridView.RowHeadersWidth = 51;
            this.RemoveRoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.RemoveRoomGridView.Size = new System.Drawing.Size(293, 244);
            this.RemoveRoomGridView.TabIndex = 100;
            this.RemoveRoomGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RemoveRoomGridView_CellMouseClick);
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
            this.AssignRoomGridView.Location = new System.Drawing.Point(18, 173);
            this.AssignRoomGridView.MultiSelect = false;
            this.AssignRoomGridView.Name = "AssignRoomGridView";
            this.AssignRoomGridView.ReadOnly = true;
            this.AssignRoomGridView.RowHeadersVisible = false;
            this.AssignRoomGridView.RowHeadersWidth = 51;
            this.AssignRoomGridView.RowTemplate.Height = 24;
            this.AssignRoomGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.AssignRoomGridView.Size = new System.Drawing.Size(300, 244);
            this.AssignRoomGridView.TabIndex = 99;
            this.AssignRoomGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AssignRoomGridView_CellMouseClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RemoveButton.ForeColor = System.Drawing.Color.White;
            this.RemoveButton.Location = new System.Drawing.Point(437, 423);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(111, 54);
            this.RemoveButton.TabIndex = 98;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AssignButton
            // 
            this.AssignButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.AssignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AssignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignButton.ForeColor = System.Drawing.Color.White;
            this.AssignButton.Location = new System.Drawing.Point(108, 422);
            this.AssignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(110, 54);
            this.AssignButton.TabIndex = 97;
            this.AssignButton.Text = "Assign";
            this.AssignButton.UseVisualStyleBackColor = false;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // SSNTextBox
            // 
            this.SSNTextBox.Enabled = false;
            this.SSNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSNTextBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.SSNTextBox.Location = new System.Drawing.Point(108, 107);
            this.SSNTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SSNTextBox.Name = "SSNTextBox";
            this.SSNTextBox.Size = new System.Drawing.Size(376, 38);
            this.SSNTextBox.TabIndex = 108;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 31);
            this.label6.TabIndex = 107;
            this.label6.Text = "SSN:";
            // 
            // FinishButton
            // 
            this.FinishButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.FinishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishButton.ForeColor = System.Drawing.Color.White;
            this.FinishButton.Location = new System.Drawing.Point(692, 509);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(141, 67);
            this.FinishButton.TabIndex = 109;
            this.FinishButton.Text = "Done";
            this.FinishButton.UseVisualStyleBackColor = false;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_ISA.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(18, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 110;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NurseAssignRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 587);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.SSNTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RemoveRoomGridView);
            this.Controls.Add(this.AssignRoomGridView);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AssignButton);
            this.Controls.Add(this.button3);
            this.Name = "NurseAssignRoom";
            this.Text = "a";
            ((System.ComponentModel.ISupportInitialize)(this.RemoveRoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssignRoomGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView RemoveRoomGridView;
        private System.Windows.Forms.DataGridView AssignRoomGridView;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.TextBox SSNTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FinishButton;
        internal System.Windows.Forms.PictureBox pictureBox1;
    }
}