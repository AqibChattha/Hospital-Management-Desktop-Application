using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucPharmacistData : UserControl
    {
        private static ucPharmacistData _instence;
        public static ucPharmacistData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucPharmacistData();
                }
                return _instence;
            }
        }
        public ucPharmacistData()
        {
            InitializeComponent();
        }

        private void btnRegisterPharmacist_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddPharmacist.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddPharmacist.Instence);
                ucAddPharmacist.Instence.Dock = DockStyle.Fill;
                ucAddPharmacist.Instence.BringToFront();
            }
            else
            {
                ucAddPharmacist.Instence.BringToFront();
            }
        }
    }
}
