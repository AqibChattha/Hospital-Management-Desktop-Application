using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucNursesData : UserControl
    {
        private static ucNursesData _instence;
        public static ucNursesData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucNursesData();
                }
                return _instence;
            }
        }
        public ucNursesData()
        {
            InitializeComponent();
            dtvNurse.AllowUserToAddRows = false;
        }

        private void btnRegisterNurse_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddNurse.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddNurse.Instence);
                ucAddNurse.Instence.Dock = DockStyle.Fill;
                ucAddNurse.Instence.BringToFront();
            }
            else
            {
                ucAddNurse.Instence.BringToFront();
            }
        }

        
    }
}
