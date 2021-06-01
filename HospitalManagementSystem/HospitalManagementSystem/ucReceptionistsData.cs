using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucReceptionistsData : UserControl
    {
        private static ucReceptionistsData _instence;
        public static ucReceptionistsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucReceptionistsData();
                }
                return _instence;
            }
        }
        public ucReceptionistsData()
        {
            InitializeComponent();
            dtvReceptionists.AllowUserToAddRows = false;
        }

        private void btnRegisterReceptionist_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddReceptionist.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddReceptionist.Instence);
                ucAddReceptionist.Instence.Dock = DockStyle.Fill;
                ucAddReceptionist.Instence.BringToFront();
            }
            else
            {
                ucAddReceptionist.Instence.BringToFront();
            }
        }

       
    }
}
