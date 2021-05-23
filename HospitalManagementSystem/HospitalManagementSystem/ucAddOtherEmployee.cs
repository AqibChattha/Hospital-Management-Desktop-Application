using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddOtherEmployee : UserControl
    {
        private static ucAddOtherEmployee _instence;
        public static ucAddOtherEmployee Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddOtherEmployee();
                }
                return _instence;
            }
        }
        public ucAddOtherEmployee()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucOtherStaffData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucOtherStaffData.Instence);
                ucOtherStaffData.Instence.Dock = DockStyle.Fill;
                ucOtherStaffData.Instence.BringToFront();
            }
            else
            {
                ucOtherStaffData.Instence.BringToFront();
            }
        }
    }
}
