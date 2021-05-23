using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddLaboratoryTechnician : UserControl
    {
        private static ucAddLaboratoryTechnician _instence;
        public static ucAddLaboratoryTechnician Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddLaboratoryTechnician();
                }
                return _instence;
            }
        }
        public ucAddLaboratoryTechnician()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!MainForn.main_Panel.Controls.Contains(ucLaboratoryTechniciansData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucLaboratoryTechniciansData.Instence);
                ucLaboratoryTechniciansData.Instence.Dock = DockStyle.Fill;
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
            else
            {
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
        }
    }
}
