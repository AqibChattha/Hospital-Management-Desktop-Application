
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
            this.dtvOtherStaff.GridColor = System.Drawing.Color.Gainsboro;
            this.dtvOtherStaff.Location = new System.Drawing.Point(18, 87);
            this.dtvOtherStaff.Name = "dtvOtherStaff";
            this.dtvOtherStaff.RowTemplate.Height = 25;
            this.dtvOtherStaff.Size = new System.Drawing.Size(788, 397);
            this.dtvOtherStaff.TabIndex = 18;
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
            this.Load += new System.EventHandler(this.ucOtherStaffData_Load);
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
    }
}
