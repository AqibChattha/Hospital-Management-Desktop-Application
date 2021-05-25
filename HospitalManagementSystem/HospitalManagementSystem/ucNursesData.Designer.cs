
namespace HospitalManagementSystem
{
    partial class ucNursesData
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
            this.txtSearchNurse = new System.Windows.Forms.TextBox();
            this.btnRegisterNurse = new System.Windows.Forms.Button();
            this.dtvNurse = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNurse)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(356, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 30);
            this.label16.TabIndex = 17;
            this.label16.Text = "Nurses";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search";
            // 
            // txtSearchNurse
            // 
            this.txtSearchNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchNurse.Location = new System.Drawing.Point(606, 64);
            this.txtSearchNurse.Name = "txtSearchNurse";
            this.txtSearchNurse.Size = new System.Drawing.Size(199, 23);
            this.txtSearchNurse.TabIndex = 15;
            // 
            // btnRegisterNurse
            // 
            this.btnRegisterNurse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterNurse.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterNurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterNurse.Location = new System.Drawing.Point(672, 511);
            this.btnRegisterNurse.Name = "btnRegisterNurse";
            this.btnRegisterNurse.Size = new System.Drawing.Size(132, 30);
            this.btnRegisterNurse.TabIndex = 14;
            this.btnRegisterNurse.Text = "Register Nurse";
            this.btnRegisterNurse.UseVisualStyleBackColor = false;
            this.btnRegisterNurse.Click += new System.EventHandler(this.btnRegisterNurse_Click);
            // 
            // dtvNurse
            // 
            this.dtvNurse.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvNurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNurse.Location = new System.Drawing.Point(13, 97);
            this.dtvNurse.Name = "dtvNurse";
            this.dtvNurse.RowTemplate.Height = 25;
            this.dtvNurse.Size = new System.Drawing.Size(791, 408);
            this.dtvNurse.TabIndex = 18;
            // 
            // ucNursesData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtvNurse);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchNurse);
            this.Controls.Add(this.btnRegisterNurse);
            this.Name = "ucNursesData";
            this.Size = new System.Drawing.Size(824, 561);
            this.Load += new System.EventHandler(this.ucNursesData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvNurse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchNurse;
        private System.Windows.Forms.Button btnRegisterNurse;
        private System.Windows.Forms.DataGridView dtvNurse;
    }
}
