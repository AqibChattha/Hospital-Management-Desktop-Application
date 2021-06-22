
namespace HospitalManagementSystem
{
    partial class ucSurgeonsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSurgeonsData));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRegisterSurgeon = new System.Windows.Forms.Button();
            this.dtvSurgeons = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCnic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colView = new System.Windows.Forms.DataGridViewImageColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSurgeons)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Surgeons";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(559, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(607, 63);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search here...";
            this.txtSearch.Size = new System.Drawing.Size(199, 23);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearchSurgeon_TextChanged);
            // 
            // btnRegisterSurgeon
            // 
            this.btnRegisterSurgeon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterSurgeon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterSurgeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterSurgeon.Location = new System.Drawing.Point(674, 518);
            this.btnRegisterSurgeon.Name = "btnRegisterSurgeon";
            this.btnRegisterSurgeon.Size = new System.Drawing.Size(132, 30);
            this.btnRegisterSurgeon.TabIndex = 19;
            this.btnRegisterSurgeon.Text = "Register Surgeon";
            this.btnRegisterSurgeon.UseVisualStyleBackColor = false;
            this.btnRegisterSurgeon.Click += new System.EventHandler(this.btnRegisterSurgeon_Click);
            // 
            // dtvSurgeons
            // 
            this.dtvSurgeons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvSurgeons.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvSurgeons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvSurgeons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCnic,
            this.colPhoneNumber,
            this.colGender,
            this.colView,
            this.colEdit,
            this.colDelete});
            this.dtvSurgeons.GridColor = System.Drawing.Color.Gainsboro;
            this.dtvSurgeons.Location = new System.Drawing.Point(16, 92);
            this.dtvSurgeons.Name = "dtvSurgeons";
            this.dtvSurgeons.RowTemplate.Height = 25;
            this.dtvSurgeons.Size = new System.Drawing.Size(790, 420);
            this.dtvSurgeons.TabIndex = 18;
            this.dtvSurgeons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtvSurgeons_CellContentClick);
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
            // colGender
            // 
            this.colGender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colView
            // 
            this.colView.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colView.HeaderText = "";
            this.colView.Image = ((System.Drawing.Image)(resources.GetObject("colView.Image")));
            this.colView.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colView.Name = "colView";
            this.colView.Width = 21;
            // 
            // colEdit
            // 
            this.colEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEdit.HeaderText = "";
            this.colEdit.Image = ((System.Drawing.Image)(resources.GetObject("colEdit.Image")));
            this.colEdit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colEdit.Name = "colEdit";
            this.colEdit.Width = 21;
            // 
            // colDelete
            // 
            this.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDelete.HeaderText = "";
            this.colDelete.Image = ((System.Drawing.Image)(resources.GetObject("colDelete.Image")));
            this.colDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colDelete.Name = "colDelete";
            this.colDelete.Width = 21;
            // 
            // ucSurgeonsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnRegisterSurgeon);
            this.Controls.Add(this.dtvSurgeons);
            this.Name = "ucSurgeonsData";
            this.Size = new System.Drawing.Size(824, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dtvSurgeons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRegisterSurgeon;
        private System.Windows.Forms.DataGridView dtvSurgeons;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCnic;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewImageColumn colView;
        private System.Windows.Forms.DataGridViewImageColumn colEdit;
        private System.Windows.Forms.DataGridViewImageColumn colDelete;
    }
}
