﻿
namespace HospitalManagementSystem
{
    partial class ucAddOtherEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbInvalidInput = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnAddInput = new System.Windows.Forms.Button();
            this.dtpWHend = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.dtpWHstart = new System.Windows.Forms.DateTimePicker();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.nudSalary = new System.Windows.Forms.NumericUpDown();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.txtCnic = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbInvalidInput);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnClearInput);
            this.panel1.Controls.Add(this.btnAddInput);
            this.panel1.Controls.Add(this.dtpWHend);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.dtpWHstart);
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Controls.Add(this.nudSalary);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.txtCnic);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(19, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 488);
            this.panel1.TabIndex = 8;
            // 
            // lbInvalidInput
            // 
            this.lbInvalidInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvalidInput.AutoSize = true;
            this.lbInvalidInput.ForeColor = System.Drawing.Color.Red;
            this.lbInvalidInput.Location = new System.Drawing.Point(688, 418);
            this.lbInvalidInput.Name = "lbInvalidInput";
            this.lbInvalidInput.Size = new System.Drawing.Size(73, 15);
            this.lbInvalidInput.TabIndex = 17;
            this.lbInvalidInput.Text = "Invalid Input";
            // 
            // cbType
            // 
            this.cbType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Ward Boy",
            "Peon"});
            this.cbType.Location = new System.Drawing.Point(285, 115);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(221, 23);
            this.cbType.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(488, 436);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearInput.Location = new System.Drawing.Point(584, 436);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(90, 30);
            this.btnClearInput.TabIndex = 15;
            this.btnClearInput.Text = "Clear";
            this.btnClearInput.UseVisualStyleBackColor = true;
            this.btnClearInput.Click += new System.EventHandler(this.btnClearInput_Click);
            // 
            // btnAddInput
            // 
            this.btnAddInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddInput.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddInput.Location = new System.Drawing.Point(680, 436);
            this.btnAddInput.Name = "btnAddInput";
            this.btnAddInput.Size = new System.Drawing.Size(90, 30);
            this.btnAddInput.TabIndex = 14;
            this.btnAddInput.Text = "Add";
            this.btnAddInput.UseVisualStyleBackColor = false;
            this.btnAddInput.Click += new System.EventHandler(this.btnAddInput_Click);
            // 
            // dtpWHend
            // 
            this.dtpWHend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpWHend.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpWHend.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWHend.Location = new System.Drawing.Point(454, 194);
            this.dtpWHend.Name = "dtpWHend";
            this.dtpWHend.Size = new System.Drawing.Size(96, 23);
            this.dtpWHend.TabIndex = 0;
            this.dtpWHend.Value = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(10, 116);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(218, 23);
            this.dtpDateOfBirth.TabIndex = 11;
            this.dtpDateOfBirth.Value = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            // 
            // dtpWHstart
            // 
            this.dtpWHstart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpWHstart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpWHstart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWHstart.Location = new System.Drawing.Point(330, 194);
            this.dtpWHstart.Name = "dtpWHstart";
            this.dtpWHstart.Size = new System.Drawing.Size(94, 23);
            this.dtpWHstart.TabIndex = 11;
            this.dtpWHstart.Value = new System.DateTime(2021, 5, 22, 0, 0, 0, 0);
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemale.Location = new System.Drawing.Point(78, 195);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(63, 19);
            this.rbtnFemale.TabIndex = 10;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMale.Location = new System.Drawing.Point(20, 196);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(51, 19);
            this.rbtnMale.TabIndex = 10;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // nudSalary
            // 
            this.nudSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudSalary.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudSalary.Location = new System.Drawing.Point(584, 119);
            this.nudSalary.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudSalary.Name = "nudSalary";
            this.nudSalary.Size = new System.Drawing.Size(186, 23);
            this.nudSalary.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(11, 275);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(759, 123);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo.Location = new System.Drawing.Point(584, 39);
            this.txtPhoneNo.Mask = "0000-0000000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(189, 23);
            this.txtPhoneNo.TabIndex = 1;
            // 
            // txtCnic
            // 
            this.txtCnic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCnic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnic.Location = new System.Drawing.Point(285, 39);
            this.txtCnic.Mask = "00000-0000000-0";
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(221, 23);
            this.txtCnic.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(11, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 23);
            this.txtName.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(430, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "to";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(289, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "From";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(285, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "Working Hours:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Address:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(584, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(6, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date of Birth:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(580, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phone No.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(281, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "CNIC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Other Staff Information";
            // 
            // ucAddOtherEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucAddOtherEmployee";
            this.Size = new System.Drawing.Size(824, 561);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpWHstart;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.NumericUpDown nudSalary;
        private System.Windows.Forms.Button btnAddInput;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo;
        private System.Windows.Forms.MaskedTextBox txtCnic;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpWHend;
        private System.Windows.Forms.Label lbInvalidInput;
    }
}
