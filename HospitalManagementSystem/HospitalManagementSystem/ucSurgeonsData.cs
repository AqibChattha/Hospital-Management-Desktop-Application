using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucSurgeonsData : UserControl
    {
        private static ucSurgeonsData _instence;
        public static ucSurgeonsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucSurgeonsData();
                }
                return _instence;
            }
        }
        public ucSurgeonsData()
        {
            InitializeComponent();
        }

        private void btnRegisterSurgeon_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddSurgeon.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddSurgeon.Instence);
                ucAddSurgeon.Instence.Dock = DockStyle.Fill;
                ucAddSurgeon.Instence.BringToFront();
            }
            else
            {
                ucAddSurgeon.Instence.BringToFront();
            }
        }
    }
}
