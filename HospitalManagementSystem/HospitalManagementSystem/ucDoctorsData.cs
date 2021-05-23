using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucDoctorsData : UserControl
    {
        private static ucDoctorsData _instence;
        public static ucDoctorsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucDoctorsData();
                }
                return _instence;
            }
        }
        public ucDoctorsData()
        {
            InitializeComponent();
        }

        private void btnRegisterDoctor_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddDoctor.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddDoctor.Instence);
                ucAddDoctor.Instence.Dock = DockStyle.Fill;
                ucAddDoctor.Instence.BringToFront();
            }
            else
            {
                ucAddDoctor.Instence.BringToFront();
            }
        }

        private void dataGridViewDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
