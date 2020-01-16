namespace LinqToEntities
{
    partial class UserMangerForm
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteSelectedButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ManiplateGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.GoLastButton = new System.Windows.Forms.Button();
            this.GoFirstButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NavigationGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.DepartmentCheckBox = new System.Windows.Forms.CheckBox();
            this.SupervisorCheckBox = new System.Windows.Forms.CheckBox();
            this.NameCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchByDepartmentTextBox = new System.Windows.Forms.TextBox();
            this.SearchBySupervisorextBox = new System.Windows.Forms.TextBox();
            this.SearchByNameTtextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.MDataGridView = new System.Windows.Forms.DataGridView();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemmaleadioButton = new System.Windows.Forms.RadioButton();
            this.BirthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartmentComboBox = new System.Windows.Forms.ComboBox();
            this.SupervisorComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ManiplateGroupBox.SuspendLayout();
            this.NavigationGroupBox.SuspendLayout();
            this.SearchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MDataGridView)).BeginInit();
            this.GenderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(200, 30);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(137, 42);
            this.UpdateButton.TabIndex = 35;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteSelectedButton
            // 
            this.DeleteSelectedButton.Location = new System.Drawing.Point(510, 30);
            this.DeleteSelectedButton.Name = "DeleteSelectedButton";
            this.DeleteSelectedButton.Size = new System.Drawing.Size(137, 42);
            this.DeleteSelectedButton.TabIndex = 34;
            this.DeleteSelectedButton.Text = "Delete Selected";
            this.DeleteSelectedButton.UseVisualStyleBackColor = true;
            this.DeleteSelectedButton.Click += new System.EventHandler(this.DeleteSelectedButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(45, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(137, 42);
            this.AddButton.TabIndex = 32;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // ManiplateGroupBox
            // 
            this.ManiplateGroupBox.Controls.Add(this.UpdateButton);
            this.ManiplateGroupBox.Controls.Add(this.DeleteSelectedButton);
            this.ManiplateGroupBox.Controls.Add(this.DeleteButton);
            this.ManiplateGroupBox.Controls.Add(this.AddButton);
            this.ManiplateGroupBox.Location = new System.Drawing.Point(835, 360);
            this.ManiplateGroupBox.Name = "ManiplateGroupBox";
            this.ManiplateGroupBox.Size = new System.Drawing.Size(675, 98);
            this.ManiplateGroupBox.TabIndex = 55;
            this.ManiplateGroupBox.TabStop = false;
            this.ManiplateGroupBox.Text = "Manipulate Data";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(355, 30);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(137, 42);
            this.DeleteButton.TabIndex = 33;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // GoLastButton
            // 
            this.GoLastButton.Location = new System.Drawing.Point(250, 103);
            this.GoLastButton.Name = "GoLastButton";
            this.GoLastButton.Size = new System.Drawing.Size(128, 30);
            this.GoLastButton.TabIndex = 0;
            this.GoLastButton.Text = ">>";
            this.GoLastButton.UseVisualStyleBackColor = true;
            this.GoLastButton.Click += new System.EventHandler(this.GoLastButton_Click);
            // 
            // GoFirstButton
            // 
            this.GoFirstButton.Location = new System.Drawing.Point(37, 103);
            this.GoFirstButton.Name = "GoFirstButton";
            this.GoFirstButton.Size = new System.Drawing.Size(128, 30);
            this.GoFirstButton.TabIndex = 0;
            this.GoFirstButton.Text = "<<";
            this.GoFirstButton.UseVisualStyleBackColor = true;
            this.GoFirstButton.Click += new System.EventHandler(this.GoFirstButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(250, 46);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(128, 30);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(37, 46);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(128, 30);
            this.PreviousButton.TabIndex = 0;
            this.PreviousButton.Text = "<";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NavigationGroupBox
            // 
            this.NavigationGroupBox.Controls.Add(this.GoLastButton);
            this.NavigationGroupBox.Controls.Add(this.GoFirstButton);
            this.NavigationGroupBox.Controls.Add(this.NextButton);
            this.NavigationGroupBox.Controls.Add(this.PreviousButton);
            this.NavigationGroupBox.Location = new System.Drawing.Point(300, 298);
            this.NavigationGroupBox.Name = "NavigationGroupBox";
            this.NavigationGroupBox.Size = new System.Drawing.Size(402, 160);
            this.NavigationGroupBox.TabIndex = 54;
            this.NavigationGroupBox.TabStop = false;
            this.NavigationGroupBox.Text = "Navigation";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(384, 182);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(165, 48);
            this.SearchButton.TabIndex = 37;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchButton);
            this.SearchGroupBox.Controls.Add(this.DepartmentCheckBox);
            this.SearchGroupBox.Controls.Add(this.SupervisorCheckBox);
            this.SearchGroupBox.Controls.Add(this.NameCheckBox);
            this.SearchGroupBox.Controls.Add(this.label3);
            this.SearchGroupBox.Controls.Add(this.label2);
            this.SearchGroupBox.Controls.Add(this.label1);
            this.SearchGroupBox.Controls.Add(this.SearchByDepartmentTextBox);
            this.SearchGroupBox.Controls.Add(this.SearchBySupervisorextBox);
            this.SearchGroupBox.Controls.Add(this.SearchByNameTtextBox);
            this.SearchGroupBox.Location = new System.Drawing.Point(210, 12);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(643, 269);
            this.SearchGroupBox.TabIndex = 53;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Box";
            // 
            // DepartmentCheckBox
            // 
            this.DepartmentCheckBox.AutoSize = true;
            this.DepartmentCheckBox.Location = new System.Drawing.Point(531, 136);
            this.DepartmentCheckBox.Name = "DepartmentCheckBox";
            this.DepartmentCheckBox.Size = new System.Drawing.Size(18, 17);
            this.DepartmentCheckBox.TabIndex = 36;
            this.DepartmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SupervisorCheckBox
            // 
            this.SupervisorCheckBox.AutoSize = true;
            this.SupervisorCheckBox.Location = new System.Drawing.Point(531, 93);
            this.SupervisorCheckBox.Name = "SupervisorCheckBox";
            this.SupervisorCheckBox.Size = new System.Drawing.Size(18, 17);
            this.SupervisorCheckBox.TabIndex = 35;
            this.SupervisorCheckBox.UseVisualStyleBackColor = true;
            // 
            // NameCheckBox
            // 
            this.NameCheckBox.AutoSize = true;
            this.NameCheckBox.Location = new System.Drawing.Point(531, 50);
            this.NameCheckBox.Name = "NameCheckBox";
            this.NameCheckBox.Size = new System.Drawing.Size(18, 17);
            this.NameCheckBox.TabIndex = 34;
            this.NameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Supervisor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Name";
            // 
            // SearchByDepartmentTextBox
            // 
            this.SearchByDepartmentTextBox.Location = new System.Drawing.Point(191, 133);
            this.SearchByDepartmentTextBox.Name = "SearchByDepartmentTextBox";
            this.SearchByDepartmentTextBox.Size = new System.Drawing.Size(325, 22);
            this.SearchByDepartmentTextBox.TabIndex = 29;
            // 
            // SearchBySupervisorextBox
            // 
            this.SearchBySupervisorextBox.Location = new System.Drawing.Point(191, 90);
            this.SearchBySupervisorextBox.Name = "SearchBySupervisorextBox";
            this.SearchBySupervisorextBox.Size = new System.Drawing.Size(325, 22);
            this.SearchBySupervisorextBox.TabIndex = 28;
            // 
            // SearchByNameTtextBox
            // 
            this.SearchByNameTtextBox.Location = new System.Drawing.Point(191, 47);
            this.SearchByNameTtextBox.Name = "SearchByNameTtextBox";
            this.SearchByNameTtextBox.Size = new System.Drawing.Size(325, 22);
            this.SearchByNameTtextBox.TabIndex = 30;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(1113, 37);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(325, 22);
            this.IDTextBox.TabIndex = 40;
            // 
            // MDataGridView
            // 
            this.MDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MDataGridView.Location = new System.Drawing.Point(210, 473);
            this.MDataGridView.MultiSelect = false;
            this.MDataGridView.Name = "MDataGridView";
            this.MDataGridView.RowHeadersWidth = 51;
            this.MDataGridView.RowTemplate.Height = 24;
            this.MDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MDataGridView.Size = new System.Drawing.Size(1300, 357);
            this.MDataGridView.TabIndex = 39;
            this.MDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MDataGridView_CellClick);
            this.MDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MDataGridView_CellContentClick);
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.MaleRadioButton);
            this.GenderGroupBox.Controls.Add(this.FemmaleadioButton);
            this.GenderGroupBox.Location = new System.Drawing.Point(1115, 267);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(325, 87);
            this.GenderGroupBox.TabIndex = 52;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender";
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(209, 37);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(59, 21);
            this.MaleRadioButton.TabIndex = 0;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemmaleadioButton
            // 
            this.FemmaleadioButton.AutoSize = true;
            this.FemmaleadioButton.Location = new System.Drawing.Point(50, 37);
            this.FemmaleadioButton.Name = "FemmaleadioButton";
            this.FemmaleadioButton.Size = new System.Drawing.Size(86, 21);
            this.FemmaleadioButton.TabIndex = 0;
            this.FemmaleadioButton.TabStop = true;
            this.FemmaleadioButton.Text = "Femmale";
            this.FemmaleadioButton.UseVisualStyleBackColor = true;
            // 
            // BirthdateDateTimePicker
            // 
            this.BirthdateDateTimePicker.Location = new System.Drawing.Point(1113, 237);
            this.BirthdateDateTimePicker.Name = "BirthdateDateTimePicker";
            this.BirthdateDateTimePicker.Size = new System.Drawing.Size(325, 22);
            this.BirthdateDateTimePicker.TabIndex = 51;
            // 
            // DepartmentComboBox
            // 
            this.DepartmentComboBox.FormattingEnabled = true;
            this.DepartmentComboBox.Location = new System.Drawing.Point(1113, 157);
            this.DepartmentComboBox.Name = "DepartmentComboBox";
            this.DepartmentComboBox.Size = new System.Drawing.Size(325, 24);
            this.DepartmentComboBox.TabIndex = 50;
            // 
            // SupervisorComboBox
            // 
            this.SupervisorComboBox.FormattingEnabled = true;
            this.SupervisorComboBox.Location = new System.Drawing.Point(1113, 117);
            this.SupervisorComboBox.Name = "SupervisorComboBox";
            this.SupervisorComboBox.Size = new System.Drawing.Size(325, 24);
            this.SupervisorComboBox.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(992, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Birthdate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(992, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(992, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(992, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 45;
            this.label6.Text = "Supervisor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(992, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 44;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(992, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "ID";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(1113, 197);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(325, 22);
            this.SalaryTextBox.TabIndex = 42;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(1113, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(325, 22);
            this.NameTextBox.TabIndex = 41;
            // 
            // UserMangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 827);
            this.Controls.Add(this.ManiplateGroupBox);
            this.Controls.Add(this.NavigationGroupBox);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.MDataGridView);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.BirthdateDateTimePicker);
            this.Controls.Add(this.DepartmentComboBox);
            this.Controls.Add(this.SupervisorComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalaryTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Name = "UserMangerForm";
            this.Text = "UserMangerForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ManiplateGroupBox.ResumeLayout(false);
            this.NavigationGroupBox.ResumeLayout(false);
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MDataGridView)).EndInit();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteSelectedButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox ManiplateGroupBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button GoLastButton;
        private System.Windows.Forms.Button GoFirstButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.GroupBox NavigationGroupBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.CheckBox DepartmentCheckBox;
        private System.Windows.Forms.CheckBox SupervisorCheckBox;
        private System.Windows.Forms.CheckBox NameCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchByDepartmentTextBox;
        private System.Windows.Forms.TextBox SearchBySupervisorextBox;
        private System.Windows.Forms.TextBox SearchByNameTtextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.DataGridView MDataGridView;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemmaleadioButton;
        private System.Windows.Forms.DateTimePicker BirthdateDateTimePicker;
        private System.Windows.Forms.ComboBox DepartmentComboBox;
        private System.Windows.Forms.ComboBox SupervisorComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}