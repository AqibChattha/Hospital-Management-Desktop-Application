
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
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchSurgeon = new System.Windows.Forms.TextBox();
            this.btnRegisterSurgeon = new System.Windows.Forms.Button();
            this.dtvSurgeons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtvSurgeons)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(363, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 30);
            this.label16.TabIndex = 22;
            this.label16.Text = "Surgeons";
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
            // txtSearchSurgeon
            // 
            this.txtSearchSurgeon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchSurgeon.Location = new System.Drawing.Point(607, 58);
            this.txtSearchSurgeon.Name = "txtSearchSurgeon";
            this.txtSearchSurgeon.Size = new System.Drawing.Size(199, 23);
            this.txtSearchSurgeon.TabIndex = 20;
            // 
            // btnRegisterSurgeon
            // 
            this.btnRegisterSurgeon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterSurgeon.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRegisterSurgeon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterSurgeon.Location = new System.Drawing.Point(673, 505);
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
            this.dtvSurgeons.GridColor = System.Drawing.Color.Gainsboro;
            this.dtvSurgeons.Location = new System.Drawing.Point(18, 87);
            this.dtvSurgeons.Name = "dtvSurgeons";
            this.dtvSurgeons.RowTemplate.Height = 25;
            this.dtvSurgeons.Size = new System.Drawing.Size(788, 397);
            this.dtvSurgeons.TabIndex = 18;
            // 
            // ucSurgeonsData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSurgeon);
            this.Controls.Add(this.btnRegisterSurgeon);
            this.Controls.Add(this.dtvSurgeons);
            this.Name = "ucSurgeonsData";
            this.Size = new System.Drawing.Size(824, 561);
            this.Load += new System.EventHandler(this.ucSurgeonsData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvSurgeons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSurgeon;
        private System.Windows.Forms.Button btnRegisterSurgeon;
        private System.Windows.Forms.DataGridView dtvSurgeons;
    }
}
