using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucOtherStaffData : UserControl
    {
        private static ucOtherStaffData _instence;
        public static ucOtherStaffData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucOtherStaffData();
                }
                return _instence;
            }
        }
        public ucOtherStaffData()
        {
            InitializeComponent();
        }

        private void btnRegisterOtherStaff_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddOtherEmployee.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddOtherEmployee.Instence);
                ucAddOtherEmployee.Instence.Dock = DockStyle.Fill;
                ucAddOtherEmployee.Instence.BringToFront();
            }
            else
            {
                ucAddOtherEmployee.Instence.BringToFront();
            }
        }
    }
}
