
namespace HospitalManagementSystem
{
    partial class ucLaboratoryTechniciansData
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
            this.txtSearchLabTech = new System.Windows.Forms.TextBox();
            this.btnRegisterLabTech = new System.Windows.Forms.Button();
            this.dtvLabTechnician = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvLabTechnician)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(297, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(224, 30);
            this.label16.TabIndex = 22;
            this.label16.Text = "Laboratory Technicians";
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
            // txtSearchLabTech
            // 
            this.txtSearchLabTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchLabTech.Location = new System.Drawing.Point(607, 58);
            this.txtSearchLabTech.Name = "txtSearchLabTech";
            this.txtSearchLabTech.Size = new System.Drawing.Size(199, 23);
            this.txtSearchLabTech.TabIndex = 20;
            // 
            // btnRegisterLabTech
            // 
            this.btnRegisterLabTech.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterLabTech.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterLabTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterLabTech.Location = new System.Drawing.Point(623, 505);
            this.btnRegisterLabTech.Name = "btnRegisterLabTech";
            this.btnRegisterLabTech.Size = new System.Drawing.Size(182, 30);
            this.btnRegisterLabTech.TabIndex = 19;
            this.btnRegisterLabTech.Text = "Register Laboratory Technician";
            this.btnRegisterLabTech.UseVisualStyleBackColor = false;
            this.btnRegisterLabTech.Click += new System.EventHandler(this.btnRegisterLabTech_Click);
            // 
            // dtvLabTechnician
            // 
            this.dtvLabTechnician.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvLabTechnician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvLabTechnician.Location = new System.Drawing.Point(16, 90);
            this.dtvLabTechnician.Name = "dtvLabTechnician";
            this.dtvLabTechnician.RowTemplate.Height = 25;
            this.dtvLabTechnician.Size = new System.Drawing.Size(789, 409);
            this.dtvLabTechnician.TabIndex = 23;
            // 
            // ucLaboratoryTechniciansData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtvLabTechnician);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchLabTech);
            this.Controls.Add(this.btnRegisterLabTech);
            this.Name = "ucLaboratoryTechniciansData";
            this.Size = new System.Drawing.Size(824, 561);
            this.Load += new System.EventHandler(this.ucLaboratoryTechniciansData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvLabTechnician)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchLabTech;
        private System.Windows.Forms.Button btnRegisterLabTech;
        private System.Windows.Forms.DataGridView dtvLabTechnician;
    }
}
