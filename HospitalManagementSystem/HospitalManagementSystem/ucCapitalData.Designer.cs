
namespace HospitalManagementSystem
{
    partial class ucCapitalData
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHospitalRevenue = new System.Windows.Forms.DataGridView();
            this.dgvFunds = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalCapital = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.lbHospitalRevenue = new System.Windows.Forms.Label();
            this.lbFunds = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbViewType = new System.Windows.Forms.ComboBox();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunds)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(325, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hospital Capital";
            // 
            // dgvHospitalRevenue
            // 
            this.dgvHospitalRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHospitalRevenue.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHospitalRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHospitalRevenue.Location = new System.Drawing.Point(15, 178);
            this.dgvHospitalRevenue.Name = "dgvHospitalRevenue";
            this.dgvHospitalRevenue.RowTemplate.Height = 25;
            this.dgvHospitalRevenue.Size = new System.Drawing.Size(791, 170);
            this.dgvHospitalRevenue.TabIndex = 10;
            // 
            // dgvFunds
            // 
            this.dgvFunds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFunds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunds.Location = new System.Drawing.Point(15, 418);
            this.dgvFunds.Name = "dgvFunds";
            this.dgvFunds.RowTemplate.Height = 25;
            this.dgvFunds.Size = new System.Drawing.Size(791, 141);
            this.dgvFunds.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(490, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Capital:";
            // 
            // lbTotalCapital
            // 
            this.lbTotalCapital.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTotalCapital.AutoSize = true;
            this.lbTotalCapital.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTotalCapital.Location = new System.Drawing.Point(617, 63);
            this.lbTotalCapital.Name = "lbTotalCapital";
            this.lbTotalCapital.Size = new System.Drawing.Size(24, 30);
            this.lbTotalCapital.TabIndex = 9;
            this.lbTotalCapital.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(11, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Donations/Funds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hospital revenue:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Details:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Details:";
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFunds.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFunds.Location = new System.Drawing.Point(704, 565);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(102, 30);
            this.btnAddFunds.TabIndex = 11;
            this.btnAddFunds.Text = "Add Capital";
            this.btnAddFunds.UseVisualStyleBackColor = false;
            // 
            // lbHospitalRevenue
            // 
            this.lbHospitalRevenue.AutoSize = true;
            this.lbHospitalRevenue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbHospitalRevenue.Location = new System.Drawing.Point(161, 125);
            this.lbHospitalRevenue.Name = "lbHospitalRevenue";
            this.lbHospitalRevenue.Size = new System.Drawing.Size(22, 25);
            this.lbHospitalRevenue.TabIndex = 9;
            this.lbHospitalRevenue.Text = "0";
            // 
            // lbFunds
            // 
            this.lbFunds.AutoSize = true;
            this.lbFunds.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFunds.Location = new System.Drawing.Point(162, 365);
            this.lbFunds.Name = "lbFunds";
            this.lbFunds.Size = new System.Drawing.Size(22, 25);
            this.lbFunds.TabIndex = 9;
            this.lbFunds.Text = "0";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.Location = new System.Drawing.Point(299, 68);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(163, 23);
            this.dtpTime.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(10, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "View By:";
            // 
            // cbViewType
            // 
            this.cbViewType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbViewType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbViewType.FormattingEnabled = true;
            this.cbViewType.Items.AddRange(new object[] {
            "Month",
            "Year"});
            this.cbViewType.Location = new System.Drawing.Point(95, 68);
            this.cbViewType.Name = "cbViewType";
            this.cbViewType.Size = new System.Drawing.Size(121, 23);
            this.cbViewType.TabIndex = 13;
            this.cbViewType.SelectedIndexChanged += new System.EventHandler(this.cbViewType_SelectedIndexChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(229, 66);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(72, 25);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "Month:";
            // 
            // ucCapitalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbViewType);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnAddFunds);
            this.Controls.Add(this.dgvFunds);
            this.Controls.Add(this.dgvHospitalRevenue);
            this.Controls.Add(this.lbTotalCapital);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbFunds);
            this.Controls.Add(this.lbHospitalRevenue);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucCapitalData";
            this.Size = new System.Drawing.Size(824, 609);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHospitalRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHospitalRevenue;
        private System.Windows.Forms.DataGridView dgvFunds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalCapital;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddFunds;
        private System.Windows.Forms.Label lbHospitalRevenue;
        private System.Windows.Forms.Label lbFunds;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbViewType;
        private System.Windows.Forms.Label lbTime;
    }
}
