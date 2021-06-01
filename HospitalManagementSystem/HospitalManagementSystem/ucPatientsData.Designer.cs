
namespace HospitalManagementSystem
{
    partial class ucPatientsData
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
            this.txtSearchSurgeon = new System.Windows.Forms.TextBox();
            this.dtvPatients = new System.Windows.Forms.DataGridView();
            this.btnRegisterPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(333, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(86, 30);
            this.label16.TabIndex = 23;
            this.label16.Text = "Patients";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // txtSearchSurgeon
            // 
            this.txtSearchSurgeon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSurgeon.Location = new System.Drawing.Point(603, 66);
            this.txtSearchSurgeon.Name = "txtSearchSurgeon";
            this.txtSearchSurgeon.Size = new System.Drawing.Size(199, 23);
            this.txtSearchSurgeon.TabIndex = 24;
            // 
            // dtvPatients
            // 
            this.dtvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvPatients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPatients.Location = new System.Drawing.Point(15, 96);
            this.dtvPatients.Name = "dtvPatients";
            this.dtvPatients.RowTemplate.Height = 25;
            this.dtvPatients.Size = new System.Drawing.Size(788, 397);
            this.dtvPatients.TabIndex = 26;
            // 
            // btnRegisterPatient
            // 
            this.btnRegisterPatient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterPatient.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPatient.Location = new System.Drawing.Point(669, 512);
            this.btnRegisterPatient.Name = "btnRegisterPatient";
            this.btnRegisterPatient.Size = new System.Drawing.Size(132, 30);
            this.btnRegisterPatient.TabIndex = 27;
            this.btnRegisterPatient.Text = "Register Patient";
            this.btnRegisterPatient.UseVisualStyleBackColor = false;
            this.btnRegisterPatient.Click += new System.EventHandler(this.btnRegisterPatient_Click);
            // 
            // ucPatientsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegisterPatient);
            this.Controls.Add(this.dtvPatients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSurgeon);
            this.Controls.Add(this.label16);
            this.Name = "ucPatientsData";
            this.Size = new System.Drawing.Size(824, 561);
            this.Load += new System.EventHandler(this.usPatientsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSurgeon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRegisterPatient;
        private System.Windows.Forms.DataGridView dtvPatients;
    }
}
