
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDoctorsData));
            this.btnRegisterDoctor = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtvDoctor = new System.Windows.Forms.DataGridView();
            this.colStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterDoctor
            // 
            this.btnRegisterDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterDoctor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterDoctor.Location = new System.Drawing.Point(674, 518);
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
            this.txtSearch.Location = new System.Drawing.Point(607, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Doctor...";
            this.txtSearch.Size = new System.Drawing.Size(199, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 67);
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
            this.label16.Location = new System.Drawing.Point(364, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 30);
            this.label16.TabIndex = 12;
            this.label16.Text = "Doctors";
            // 
            // dtvDoctor
            // 
            this.dtvDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvDoctor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffId,
            this.colName,
            this.colCnic,
            this.colPhoneNumber,
            this.colView,
            this.colEdit,
            this.colDelete});
            this.dtvDoctor.Location = new System.Drawing.Point(16, 92);
            this.dtvDoctor.Name = "dtvDoctor";
            this.dtvDoctor.RowTemplate.Height = 25;
            this.dtvDoctor.Size = new System.Drawing.Size(790, 420);
            this.dtvDoctor.TabIndex = 13;
            this.dtvDoctor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvDoctor_CellContentClick);
            // 
            // colStaffId
            // 
            this.colStaffId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffId.HeaderText = "Staff ID";
            this.colStaffId.Name = "colStaffId";
            this.colStaffId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCnic
            // 
            this.colCnic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCnic.HeaderText = "Cnic";
            this.colCnic.Name = "colCnic";
            this.colCnic.ReadOnly = true;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            // 
            // colView
            // 
            this.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colView.HeaderText = "";
            this.colView.Image = ((System.Drawing.Image)(resources.GetObject("colView.Image")));
            this.colView.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colView.Name = "colView";
            this.colView.ReadOnly = true;
            this.colView.Width = 21;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEdit.Name = "colEdit";
            this.colEdit.ReadOnly = true;
            this.colEdit.Width = 21;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 21;
            // 
            // ucDoctorsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtvDoctor);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRegisterDoctor);
            this.Name = "ucDoctorsData";
            this.Size = new System.Drawing.Size(824, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegisterDoctor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dtvDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
