using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddSurgeon : UserControl
    {
        private static ucAddSurgeon _instence;
        public static ucAddSurgeon Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddSurgeon();
                }
                return _instence;
            }
        }
        public ucAddSurgeon()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucSurgeonsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucSurgeonsData.Instence);
                ucSurgeonsData.Instence.Dock = DockStyle.Fill;
                ucSurgeonsData.Instence.BringToFront();
            }
            else
            {
                ucSurgeonsData.Instence.BringToFront();
            }
        }
    }
}
