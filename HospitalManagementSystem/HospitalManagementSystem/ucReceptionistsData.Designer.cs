
namespace HospitalManagementSystem
{
    partial class ucReceptionistsData
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
            this.txtSearchReceptionist = new System.Windows.Forms.TextBox();
            this.btnRegisterReceptionist = new System.Windows.Forms.Button();
            this.dtvReceptionists = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvReceptionists)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(345, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(135, 30);
            this.label16.TabIndex = 22;
            this.label16.Text = "Receptionists";
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
            // txtSearchReceptionist
            // 
            this.txtSearchReceptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchReceptionist.Location = new System.Drawing.Point(607, 58);
            this.txtSearchReceptionist.Name = "txtSearchReceptionist";
            this.txtSearchReceptionist.Size = new System.Drawing.Size(199, 23);
            this.txtSearchReceptionist.TabIndex = 20;
            // 
            // btnRegisterReceptionist
            // 
            this.btnRegisterReceptionist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterReceptionist.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterReceptionist.Location = new System.Drawing.Point(667, 505);
            this.btnRegisterReceptionist.Name = "btnRegisterReceptionist";
            this.btnRegisterReceptionist.Size = new System.Drawing.Size(138, 30);
            this.btnRegisterReceptionist.TabIndex = 19;
            this.btnRegisterReceptionist.Text = "Register Receptionist";
            this.btnRegisterReceptionist.UseVisualStyleBackColor = false;
            this.btnRegisterReceptionist.Click += new System.EventHandler(this.btnRegisterReceptionist_Click);
            // 
            // dtvReceptionists
            // 
            this.dtvReceptionists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtvReceptionists.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtvReceptionists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvReceptionists.GridColor = System.Drawing.Color.Gainsboro;
            this.dtvReceptionists.Location = new System.Drawing.Point(18, 87);
            this.dtvReceptionists.Name = "dtvReceptionists";
            this.dtvReceptionists.RowTemplate.Height = 25;
            this.dtvReceptionists.Size = new System.Drawing.Size(788, 397);
            this.dtvReceptionists.TabIndex = 18;
            // 
            // ucReceptionistsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchReceptionist);
            this.Controls.Add(this.btnRegisterReceptionist);
            this.Controls.Add(this.dtvReceptionists);
            this.Name = "ucReceptionistsData";
            this.Size = new System.Drawing.Size(824, 561);
            this.Load += new System.EventHandler(this.ucReceptionistsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvReceptionists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchReceptionist;
        private System.Windows.Forms.Button btnRegisterReceptionist;
        private System.Windows.Forms.DataGridView dtvReceptionists;
    }
}
