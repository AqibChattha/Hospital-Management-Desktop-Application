
namespace HospitalManagementSystem
{
    partial class ucPharmacistData
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
            this.dtvPharmacist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchPharmacist = new System.Windows.Forms.TextBox();
            this.btnRegisterPharmacist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvPharmacist)).BeginInit();
            this.SuspendLayout();
            // 
            // dtvPharmacist
            // 
            this.dtvPharmacist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvPharmacist.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvPharmacist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvPharmacist.GridColor = System.Drawing.Color.Gainsboro;
            this.dtvPharmacist.Location = new System.Drawing.Point(17, 93);
            this.dtvPharmacist.Name = "dtvPharmacist";
            this.dtvPharmacist.RowTemplate.Height = 25;
            this.dtvPharmacist.Size = new System.Drawing.Size(788, 397);
            this.dtvPharmacist.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(362, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pharmacists";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Search";
            // 
            // txtSearchPharmacist
            // 
            this.txtSearchPharmacist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPharmacist.Location = new System.Drawing.Point(606, 64);
            this.txtSearchPharmacist.Name = "txtSearchPharmacist";
            this.txtSearchPharmacist.Size = new System.Drawing.Size(199, 23);
            this.txtSearchPharmacist.TabIndex = 13;
            // 
            // btnRegisterPharmacist
            // 
            this.btnRegisterPharmacist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterPharmacist.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterPharmacist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterPharmacist.Location = new System.Drawing.Point(672, 511);
            this.btnRegisterPharmacist.Name = "btnRegisterPharmacist";
            this.btnRegisterPharmacist.Size = new System.Drawing.Size(132, 30);
            this.btnRegisterPharmacist.TabIndex = 16;
            this.btnRegisterPharmacist.Text = "Register Pharmacist";
            this.btnRegisterPharmacist.UseVisualStyleBackColor = false;
            this.btnRegisterPharmacist.Click += new System.EventHandler(this.btnRegisterPharmacist_Click);
            // 
            // ucPharmacistData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegisterPharmacist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchPharmacist);
            this.Controls.Add(this.dtvPharmacist);
            this.Name = "ucPharmacistData";
            this.Size = new System.Drawing.Size(824, 561);
            this.Load += new System.EventHandler(this.ucPharmacistData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvPharmacist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtvPharmacist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchPharmacist;
        private System.Windows.Forms.Button btnRegisterPharmacist;
    }
}
