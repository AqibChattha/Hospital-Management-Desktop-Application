
namespace HospitalManagementSystem
{
    partial class ucOtherStaffData
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
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchOtherStaff = new System.Windows.Forms.TextBox();
            this.btnRegisterOtherStaff = new System.Windows.Forms.Button();
            this.dtvOtherStaff = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvOtherStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(363, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 30);
            this.label16.TabIndex = 22;
            this.label16.Text = "Other Staff";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search";
            // 
            // txtSearchOtherStaff
            // 
            this.txtSearchOtherStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchOtherStaff.Location = new System.Drawing.Point(607, 58);
            this.txtSearchOtherStaff.Name = "txtSearchOtherStaff";
            this.txtSearchOtherStaff.Size = new System.Drawing.Size(199, 23);
            this.txtSearchOtherStaff.TabIndex = 20;
            // 
            // btnRegisterOtherStaff
            // 
            this.btnRegisterOtherStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterOtherStaff.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterOtherStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterOtherStaff.Location = new System.Drawing.Point(653, 505);
            this.btnRegisterOtherStaff.Name = "btnRegisterOtherStaff";
            this.btnRegisterOtherStaff.Size = new System.Drawing.Size(152, 30);
            this.btnRegisterOtherStaff.TabIndex = 19;
            this.btnRegisterOtherStaff.Text = "Register Other Employee";
            this.btnRegisterOtherStaff.UseVisualStyleBackColor = false;
            this.btnRegisterOtherStaff.Click += new System.EventHandler(this.btnRegisterOtherStaff_Click);
            // 
            // dtvOtherStaff
            // 
            this.dtvOtherStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvOtherStaff.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvOtherStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvOtherStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.cnic,
            this.phoneNo,
            this.email,
            this.department,
            this.view,
            this.edit,
            this.delete});
            this.dtvOtherStaff.GridColor = System.Drawing.Color.Gainsboro;
            this.dtvOtherStaff.Location = new System.Drawing.Point(18, 87);
            this.dtvOtherStaff.Name = "dtvOtherStaff";
            this.dtvOtherStaff.RowTemplate.Height = 25;
            this.dtvOtherStaff.Size = new System.Drawing.Size(788, 397);
            this.dtvOtherStaff.TabIndex = 18;
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
            // ucOtherStaffData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchOtherStaff);
            this.Controls.Add(this.btnRegisterOtherStaff);
            this.Controls.Add(this.dtvOtherStaff);
            this.Name = "ucOtherStaffData";
            this.Size = new System.Drawing.Size(824, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dtvOtherStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchOtherStaff;
        private System.Windows.Forms.Button btnRegisterOtherStaff;
        private System.Windows.Forms.DataGridView dtvOtherStaff;
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
