
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
            this.btnRegisterDoctor = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtvDoctor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterDoctor
            // 
            this.btnRegisterDoctor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterDoctor.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterDoctor.Location = new System.Drawing.Point(672, 511);
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
            // dtvDoctor
            // 
            this.dtvDoctor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDoctor.Location = new System.Drawing.Point(14, 94);
            this.dtvDoctor.Name = "dtvDoctor";
            this.dtvDoctor.RowTemplate.Height = 25;
            this.dtvDoctor.Size = new System.Drawing.Size(791, 411);
            this.dtvDoctor.TabIndex = 13;
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
            this.Load += new System.EventHandler(this.ucDoctorsData_Load);
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
    }
}
