using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddReceptionist : UserControl
    {
        private static ucAddReceptionist _instence;
        public static ucAddReceptionist Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddReceptionist();
                }
                return _instence;
            }
        }
        public ucAddReceptionist()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucReceptionistsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucReceptionistsData.Instence);
                ucReceptionistsData.Instence.Dock = DockStyle.Fill;
                ucReceptionistsData.Instence.BringToFront();
            }
            else
            {
                ucReceptionistsData.Instence.BringToFront();
            }
        }
    }
}
