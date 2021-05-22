using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddNurse : UserControl
    {
        private static ucAddNurse _instence;
        public static ucAddNurse Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddNurse();
                }
                return _instence;
            }
        }
        public ucAddNurse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucNursesData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucNursesData.Instence);
                ucNursesData.Instence.Dock = DockStyle.Fill;
                ucNursesData.Instence.BringToFront();
            }
            else
            {
                ucNursesData.Instence.BringToFront();
            }
        }
    }
}
