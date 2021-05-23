
namespace HospitalManagementSystem
{
    partial class ucDoctorsData
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
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRegisterDoctor = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDoctors.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cnic,
            this.phoneNo,
            this.email,
            this.department,
            this.view,
            this.edit,
            this.delete});
            this.dataGridViewDoctors.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(17, 93);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowTemplate.Height = 25;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(788, 447);
            this.dataGridViewDoctors.TabIndex = 7;
            this.dataGridViewDoctors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellContentClick);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // cnic
            // 
            this.cnic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnic.HeaderText = "CNIC";
            this.cnic.Name = "cnic";
            // 
            // phoneNo
            // 
            this.phoneNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNo.HeaderText = "Phone Number";
            this.phoneNo.Name = "phoneNo";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.HeaderText = "Department";
            this.department.Name = "department";
            // 
            // view
            // 
            this.view.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.view.HeaderText = "View";
            this.view.Name = "view";
            this.view.Width = 38;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.Width = 33;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "Delete";
            this.delete.Name = "delete";
            this.delete.Width = 46;
            // 
            // btnRegisterDoctor
            // 
            this.btnRegisterDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterDoctor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterDoctor.Location = new System.Drawing.Point(672, 561);
            this.btnRegisterDoctor.Name = "btnRegisterDoctor";
            this.btnRegisterDoctor.Size = new System.Drawing.Size(132, 30);
            this.btnRegisterDoctor.TabIndex = 9;
            this.btnRegisterDoctor.Text = "Register Doctor";
            this.btnRegisterDoctor.UseVisualStyleBackColor = false;
            this.btnRegisterDoctor.Click += new System.EventHandler(this.btnRegisterDoctor_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(606, 64);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 23);
            this.txtSearch.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(362, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 30);
            this.label16.TabIndex = 12;
            this.label16.Text = "Doctors";
            // 
            // ucDoctorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRegisterDoctor);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Name = "ucDoctorsData";
            this.Size = new System.Drawing.Size(824, 611);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.Button btnRegisterDoctor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewButtonColumn view;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}
