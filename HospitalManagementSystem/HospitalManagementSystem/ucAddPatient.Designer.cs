
namespace HospitalManagementSystem
{
    partial class ucAddPatient
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cbPatientType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.btnAddToQueue = new System.Windows.Forms.Button();
            this.btnClearOutPatient = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCnic = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbRoomId = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth2 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAddToData = new System.Windows.Forms.Button();
            this.btnClearInPatient = new System.Windows.Forms.Button();
            this.txtAddress2 = new System.Windows.Forms.RichTextBox();
            this.rbtnFemale2 = new System.Windows.Forms.RadioButton();
            this.rbtnMale2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPhoneNo2 = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCnic2 = new System.Windows.Forms.MaskedTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbStaffId = new System.Windows.Forms.ComboBox();
            this.cbStaffType = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth3 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddToData2 = new System.Windows.Forms.Button();
            this.btnClearIllStaff = new System.Windows.Forms.Button();
            this.txtAddress3 = new System.Windows.Forms.RichTextBox();
            this.rbtnFemale3 = new System.Windows.Forms.RadioButton();
            this.rbtnMale3 = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtPhoneNo3 = new System.Windows.Forms.MaskedTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCnic3 = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(294, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Patient Information";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbPatientType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 105);
            this.panel2.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Type:";
            // 
            // cbPatientType
            // 
            this.cbPatientType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbPatientType.FormattingEnabled = true;
            this.cbPatientType.Items.AddRange(new object[] {
            "Out Patient",
            "In Patient",
            "Ill Staff"});
            this.cbPatientType.Location = new System.Drawing.Point(56, 69);
            this.cbPatientType.Name = "cbPatientType";
            this.cbPatientType.Size = new System.Drawing.Size(149, 23);
            this.cbPatientType.TabIndex = 15;
            this.cbPatientType.SelectedIndexChanged += new System.EventHandler(this.cbPatientType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.btnAddToQueue);
            this.panel1.Controls.Add(this.btnClearOutPatient);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.rbtnFemale);
            this.panel1.Controls.Add(this.rbtnMale);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtPhoneNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCnic);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 488);
            this.panel1.TabIndex = 3;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth.Location = new System.Drawing.Point(564, 129);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(220, 23);
            this.dtpDateOfBirth.TabIndex = 19;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(346, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(106, 25);
            this.label29.TabIndex = 1;
            this.label29.Text = "Out Patient";
            // 
            // btnAddToQueue
            // 
            this.btnAddToQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToQueue.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddToQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToQueue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToQueue.Location = new System.Drawing.Point(694, 437);
            this.btnAddToQueue.Name = "btnAddToQueue";
            this.btnAddToQueue.Size = new System.Drawing.Size(90, 30);
            this.btnAddToQueue.TabIndex = 18;
            this.btnAddToQueue.Text = "Add";
            this.btnAddToQueue.UseVisualStyleBackColor = false;
            this.btnAddToQueue.Click += new System.EventHandler(this.btnAddToQueue_Click);
            // 
            // btnClearOutPatient
            // 
            this.btnClearOutPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearOutPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearOutPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearOutPatient.Location = new System.Drawing.Point(598, 437);
            this.btnClearOutPatient.Name = "btnClearOutPatient";
            this.btnClearOutPatient.Size = new System.Drawing.Size(90, 30);
            this.btnClearOutPatient.TabIndex = 18;
            this.btnClearOutPatient.Text = "Clear";
            this.btnClearOutPatient.UseVisualStyleBackColor = true;
            this.btnClearOutPatient.Click += new System.EventHandler(this.btnClearOutPatient_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(28, 268);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(756, 123);
            this.txtAddress.TabIndex = 16;
            this.txtAddress.Text = "";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemale.Location = new System.Drawing.Point(98, 188);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(63, 19);
            this.rbtnFemale.TabIndex = 14;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMale.Location = new System.Drawing.Point(41, 188);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(51, 19);
            this.rbtnMale.TabIndex = 13;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Gender:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Date Of Birth :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(286, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Address:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(28, 131);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 23);
            this.txtEmail.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo.Location = new System.Drawing.Point(564, 72);
            this.txtPhoneNo.Mask = "0000-0000000";
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(220, 23);
            this.txtPhoneNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone No:";
            // 
            // txtCnic
            // 
            this.txtCnic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCnic.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnic.Location = new System.Drawing.Point(286, 72);
            this.txtCnic.Mask = "00000-0000000-0";
            this.txtCnic.Name = "txtCnic";
            this.txtCnic.Size = new System.Drawing.Size(201, 23);
            this.txtCnic.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNIC:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(28, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 23);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbRoomId);
            this.panel3.Controls.Add(this.dtpDateOfBirth2);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.btnAddToData);
            this.panel3.Controls.Add(this.btnClearInPatient);
            this.panel3.Controls.Add(this.txtAddress2);
            this.panel3.Controls.Add(this.rbtnFemale2);
            this.panel3.Controls.Add(this.rbtnMale2);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtPhoneNo2);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtCnic2);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtName2);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(0, 593);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 488);
            this.panel3.TabIndex = 4;
            // 
            // cbRoomId
            // 
            this.cbRoomId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRoomId.FormattingEnabled = true;
            this.cbRoomId.Location = new System.Drawing.Point(564, 164);
            this.cbRoomId.Name = "cbRoomId";
            this.cbRoomId.Size = new System.Drawing.Size(220, 23);
            this.cbRoomId.TabIndex = 20;
            // 
            // dtpDateOfBirth2
            // 
            this.dtpDateOfBirth2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateOfBirth2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth2.Location = new System.Drawing.Point(28, 161);
            this.dtpDateOfBirth2.Name = "dtpDateOfBirth2";
            this.dtpDateOfBirth2.Size = new System.Drawing.Size(201, 23);
            this.dtpDateOfBirth2.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(346, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "In Patient";
            // 
            // btnAddToData
            // 
            this.btnAddToData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToData.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddToData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToData.Location = new System.Drawing.Point(694, 437);
            this.btnAddToData.Name = "btnAddToData";
            this.btnAddToData.Size = new System.Drawing.Size(90, 30);
            this.btnAddToData.TabIndex = 18;
            this.btnAddToData.Text = "Add";
            this.btnAddToData.UseVisualStyleBackColor = false;
            this.btnAddToData.Click += new System.EventHandler(this.btnAddToData_Click);
            // 
            // btnClearInPatient
            // 
            this.btnClearInPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearInPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearInPatient.Location = new System.Drawing.Point(598, 437);
            this.btnClearInPatient.Name = "btnClearInPatient";
            this.btnClearInPatient.Size = new System.Drawing.Size(90, 30);
            this.btnClearInPatient.TabIndex = 18;
            this.btnClearInPatient.Text = "Clear";
            this.btnClearInPatient.UseVisualStyleBackColor = true;
            this.btnClearInPatient.Click += new System.EventHandler(this.btnClearInPatient_Click);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress2.Location = new System.Drawing.Point(28, 267);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(756, 123);
            this.txtAddress2.TabIndex = 16;
            this.txtAddress2.Text = "";
            // 
            // rbtnFemale2
            // 
            this.rbtnFemale2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnFemale2.AutoSize = true;
            this.rbtnFemale2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemale2.Location = new System.Drawing.Point(356, 168);
            this.rbtnFemale2.Name = "rbtnFemale2";
            this.rbtnFemale2.Size = new System.Drawing.Size(63, 19);
            this.rbtnFemale2.TabIndex = 14;
            this.rbtnFemale2.TabStop = true;
            this.rbtnFemale2.Text = "Female";
            this.rbtnFemale2.UseVisualStyleBackColor = true;
            // 
            // rbtnMale2
            // 
            this.rbtnMale2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnMale2.AutoSize = true;
            this.rbtnMale2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMale2.Location = new System.Drawing.Point(299, 168);
            this.rbtnMale2.Name = "rbtnMale2";
            this.rbtnMale2.Size = new System.Drawing.Size(51, 19);
            this.rbtnMale2.TabIndex = 13;
            this.rbtnMale2.TabStop = true;
            this.rbtnMale2.Text = "Male";
            this.rbtnMale2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(286, 144);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 21);
            this.label11.TabIndex = 12;
            this.label11.Text = "Gender:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Age:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 231);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Address:";
            // 
            // txtPhoneNo2
            // 
            this.txtPhoneNo2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNo2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo2.Location = new System.Drawing.Point(564, 89);
            this.txtPhoneNo2.Mask = "0000-0000000";
            this.txtPhoneNo2.Name = "txtPhoneNo2";
            this.txtPhoneNo2.Size = new System.Drawing.Size(220, 23);
            this.txtPhoneNo2.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(564, 62);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 21);
            this.label17.TabIndex = 4;
            this.label17.Text = "Phone No:";
            // 
            // txtCnic2
            // 
            this.txtCnic2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCnic2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnic2.Location = new System.Drawing.Point(288, 89);
            this.txtCnic2.Mask = "00000-0000000-0";
            this.txtCnic2.Name = "txtCnic2";
            this.txtCnic2.Size = new System.Drawing.Size(201, 23);
            this.txtCnic2.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(288, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 21);
            this.label18.TabIndex = 2;
            this.label18.Text = "CNIC:";
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName2.Location = new System.Drawing.Point(28, 89);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(201, 23);
            this.txtName2.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(559, 137);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 21);
            this.label16.TabIndex = 0;
            this.label16.Text = "Room ID";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 64);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 21);
            this.label19.TabIndex = 0;
            this.label19.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cbStaffId);
            this.panel4.Controls.Add(this.cbStaffType);
            this.panel4.Controls.Add(this.dtpDateOfBirth3);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.btnAddToData2);
            this.panel4.Controls.Add(this.btnClearIllStaff);
            this.panel4.Controls.Add(this.txtAddress3);
            this.panel4.Controls.Add(this.rbtnFemale3);
            this.panel4.Controls.Add(this.rbtnMale3);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.txtPhoneNo3);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Controls.Add(this.txtCnic3);
            this.panel4.Controls.Add(this.label27);
            this.panel4.Controls.Add(this.txtName3);
            this.panel4.Controls.Add(this.label28);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(0, 1081);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(824, 488);
            this.panel4.TabIndex = 5;
            // 
            // cbStaffId
            // 
            this.cbStaffId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStaffId.FormattingEnabled = true;
            this.cbStaffId.Location = new System.Drawing.Point(288, 138);
            this.cbStaffId.Name = "cbStaffId";
            this.cbStaffId.Size = new System.Drawing.Size(201, 23);
            this.cbStaffId.TabIndex = 20;
            // 
            // cbStaffType
            // 
            this.cbStaffType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStaffType.FormattingEnabled = true;
            this.cbStaffType.Location = new System.Drawing.Point(28, 138);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(201, 23);
            this.cbStaffType.TabIndex = 20;
            this.cbStaffType.SelectedIndexChanged += new System.EventHandler(this.cbStaffType_SelectedIndexChanged);
            // 
            // dtpDateOfBirth3
            // 
            this.dtpDateOfBirth3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOfBirth3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateOfBirth3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirth3.Location = new System.Drawing.Point(564, 138);
            this.dtpDateOfBirth3.Name = "dtpDateOfBirth3";
            this.dtpDateOfBirth3.Size = new System.Drawing.Size(220, 23);
            this.dtpDateOfBirth3.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(350, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 25);
            this.label14.TabIndex = 1;
            this.label14.Text = "Ill Staff";
            // 
            // btnAddToData2
            // 
            this.btnAddToData2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToData2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddToData2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToData2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddToData2.Location = new System.Drawing.Point(694, 437);
            this.btnAddToData2.Name = "btnAddToData2";
            this.btnAddToData2.Size = new System.Drawing.Size(90, 30);
            this.btnAddToData2.TabIndex = 18;
            this.btnAddToData2.Text = "Add";
            this.btnAddToData2.UseVisualStyleBackColor = false;
            this.btnAddToData2.Click += new System.EventHandler(this.btnAddToData2_Click);
            // 
            // btnClearIllStaff
            // 
            this.btnClearIllStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearIllStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearIllStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearIllStaff.Location = new System.Drawing.Point(598, 437);
            this.btnClearIllStaff.Name = "btnClearIllStaff";
            this.btnClearIllStaff.Size = new System.Drawing.Size(90, 30);
            this.btnClearIllStaff.TabIndex = 18;
            this.btnClearIllStaff.Text = "Clear";
            this.btnClearIllStaff.UseVisualStyleBackColor = true;
            this.btnClearIllStaff.Click += new System.EventHandler(this.btnClearIllStaff_Click);
            // 
            // txtAddress3
            // 
            this.txtAddress3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress3.Location = new System.Drawing.Point(28, 267);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(756, 123);
            this.txtAddress3.TabIndex = 16;
            this.txtAddress3.Text = "";
            // 
            // rbtnFemale3
            // 
            this.rbtnFemale3.AutoSize = true;
            this.rbtnFemale3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnFemale3.Location = new System.Drawing.Point(98, 197);
            this.rbtnFemale3.Name = "rbtnFemale3";
            this.rbtnFemale3.Size = new System.Drawing.Size(63, 19);
            this.rbtnFemale3.TabIndex = 14;
            this.rbtnFemale3.TabStop = true;
            this.rbtnFemale3.Text = "Female";
            this.rbtnFemale3.UseVisualStyleBackColor = true;
            // 
            // rbtnMale3
            // 
            this.rbtnMale3.AutoSize = true;
            this.rbtnMale3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnMale3.Location = new System.Drawing.Point(41, 197);
            this.rbtnMale3.Name = "rbtnMale3";
            this.rbtnMale3.Size = new System.Drawing.Size(51, 19);
            this.rbtnMale3.TabIndex = 13;
            this.rbtnMale3.TabStop = true;
            this.rbtnMale3.Text = "Male";
            this.rbtnMale3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 173);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 21);
            this.label20.TabIndex = 12;
            this.label20.Text = "Gender:";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(559, 112);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Age:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 231);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 21);
            this.label22.TabIndex = 8;
            this.label22.Text = "Address:";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(288, 112);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 21);
            this.label24.TabIndex = 8;
            this.label24.Text = "Staff ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(26, 112);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 21);
            this.label25.TabIndex = 6;
            this.label25.Text = "Staff Type:";
            // 
            // txtPhoneNo3
            // 
            this.txtPhoneNo3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNo3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNo3.Location = new System.Drawing.Point(564, 76);
            this.txtPhoneNo3.Mask = "0000-0000000";
            this.txtPhoneNo3.Name = "txtPhoneNo3";
            this.txtPhoneNo3.Size = new System.Drawing.Size(220, 23);
            this.txtPhoneNo3.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(561, 49);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(82, 21);
            this.label26.TabIndex = 4;
            this.label26.Text = "Phone No:";
            // 
            // txtCnic3
            // 
            this.txtCnic3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCnic3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCnic3.Location = new System.Drawing.Point(288, 76);
            this.txtCnic3.Mask = "00000-0000000-0";
            this.txtCnic3.Name = "txtCnic3";
            this.txtCnic3.Size = new System.Drawing.Size(201, 23);
            this.txtCnic3.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(288, 49);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 21);
            this.label27.TabIndex = 2;
            this.label27.Text = "CNIC:";
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName3.Location = new System.Drawing.Point(28, 76);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(201, 23);
            this.txtName3.TabIndex = 1;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 21);
            this.label28.TabIndex = 0;
            this.label28.Text = "Name:";
            // 
            // ucAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ucAddPatient";
            this.Size = new System.Drawing.Size(824, 1597);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbPatientType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnAddToQueue;
        private System.Windows.Forms.Button btnClearOutPatient;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtCnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddToData;
        private System.Windows.Forms.Button btnClearInPatient;
        private System.Windows.Forms.RichTextBox txtAddress2;
        private System.Windows.Forms.RadioButton rbtnFemale2;
        private System.Windows.Forms.RadioButton rbtnMale2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox txtCnic2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAddToData2;
        private System.Windows.Forms.Button btnClearIllStaff;
        private System.Windows.Forms.RichTextBox txtAddress3;
        private System.Windows.Forms.RadioButton rbtnFemale3;
        private System.Windows.Forms.RadioButton rbtnMale3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox txtPhoneNo3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.MaskedTextBox txtCnic3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth2;
        private System.Windows.Forms.RadioButton ebtnFemale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.ComboBox cbStaffType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbRoomId;
        private System.Windows.Forms.ComboBox cbStaffId;
    }
}
