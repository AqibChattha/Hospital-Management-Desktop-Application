using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucLaboratoryTechniciansData : UserControl
    {
        private static ucLaboratoryTechniciansData _instence;
        public static ucLaboratoryTechniciansData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucLaboratoryTechniciansData();
                }
                return _instence;
            }
        }
        public ucLaboratoryTechniciansData()
        {
            InitializeComponent();
        }

        private void btnRegisterLabTech_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddLaboratoryTechnician.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddLaboratoryTechnician.Instence);
                ucAddLaboratoryTechnician.Instence.Dock = DockStyle.Fill;
                ucAddLaboratoryTechnician.Instence.BringToFront();
            }
            else
            {
                ucAddLaboratoryTechnician.Instence.BringToFront();
            }
        }
    }
}
