
namespace HospitalManagementSystem
{
    partial class ucUnitsData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucUnitsData));
            this.label1 = new System.Windows.Forms.Label();
            this.dtvUnits = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchNurse = new System.Windows.Forms.TextBox();
            this.btnRegisterNurse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtvUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(340, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Units";
            // 
            // dtvUnits
            // 
            this.dtvUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvUnits.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtvUnits.Location = new System.Drawing.Point(16, 92);
            this.dtvUnits.Name = "dtvUnits";
            this.dtvUnits.RowTemplate.Height = 25;
            this.dtvUnits.Size = new System.Drawing.Size(791, 408);
            this.dtvUnits.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Search";
            // 
            // txtSearchNurse
            // 
            this.txtSearchNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchNurse.AutoCompleteCustomSource.AddRange(new string[] {
            "Ward",
            "Pharmacy",
            "Laboratory",
            "Operation Theater",
            "Department"});
            this.txtSearchNurse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchNurse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchNurse.Location = new System.Drawing.Point(609, 59);
            this.txtSearchNurse.Name = "txtSearchNurse";
            this.txtSearchNurse.PlaceholderText = "Search Units Withname";
            this.txtSearchNurse.Size = new System.Drawing.Size(199, 23);
            this.txtSearchNurse.TabIndex = 20;
            // 
            // btnRegisterNurse
            // 
            this.btnRegisterNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterNurse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNurse.Location = new System.Drawing.Point(675, 506);
            this.btnRegisterNurse.Name = "btnRegisterNurse";
            this.btnRegisterNurse.Size = new System.Drawing.Size(132, 30);
            this.btnRegisterNurse.TabIndex = 19;
            this.btnRegisterNurse.Text = "Add Unit";
            this.btnRegisterNurse.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Unit Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Ward",
            "Pharmacy",
            "Laborartory",
            "Operation Theater",
            "Department"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ward",
            "Pharmacy",
            "Laboratory",
            "Operation Theater",
            "Department"});
            this.comboBox1.Location = new System.Drawing.Point(81, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Address";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "";
            this.Column3.Image = ((System.Drawing.Image)(resources.GetObject("Column3.Image")));
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.Name = "Column3";
            this.Column3.Width = 21;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "";
            this.Column4.Image = ((System.Drawing.Image)(resources.GetObject("Column4.Image")));
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.Width = 21;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.HeaderText = "";
            this.Column5.Image = ((System.Drawing.Image)(resources.GetObject("Column5.Image")));
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.Name = "Column5";
            this.Column5.Width = 21;
            // 
            // ucUnitsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtvUnits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchNurse);
            this.Controls.Add(this.btnRegisterNurse);
            this.Controls.Add(this.label1);
            this.Name = "ucUnitsData";
            this.Size = new System.Drawing.Size(824, 561);
            ((System.ComponentModel.ISupportInitialize)(this.dtvUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtvUnits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchNurse;
        private System.Windows.Forms.Button btnRegisterNurse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
    }
}
