using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddPatient : UserControl
    {

        private static ucAddPatient _instence;
        public static ucAddPatient Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddPatient();
                }
                return _instence;
            }
        }
        public ucAddPatient()
        {
            InitializeComponent();
            cbPatientType.SelectedIndex = 0;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void cbPatientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPatientType.SelectedIndex == 0)
            {
                panel1.Visible = true;
                panel1.Dock = DockStyle.Fill;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            if (cbPatientType.SelectedIndex == 1)
            {
                panel3.Visible = true;
                panel3.Dock = DockStyle.Fill;
                panel1.Visible = false;
                panel4.Visible = false;
            }
            if (cbPatientType.SelectedIndex == 2)
            {
                panel4.Visible = true;
                panel4.Dock = DockStyle.Fill;
                panel1.Visible = false;
                panel3.Visible = false;
            }
        }

        private void btnAddToQueue_Click(object sender, EventArgs e)
        {

            //code here...

            if (!MainForn.main_Panel.Controls.Contains(ucPatientQueue.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientQueue.Instence);
                ucPatientQueue.Instence.Dock = DockStyle.Fill;
                ucPatientQueue.Instence.BringToFront();
            }
            else
            {
                ucPatientQueue.Instence.BringToFront();
            }
        }

        private void btnAddToData_Click(object sender, EventArgs e)
        {

            //code here...

            if (!MainForn.main_Panel.Controls.Contains(ucPatientsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientsData.Instence);
                ucPatientsData.Instence.Dock = DockStyle.Fill;
                ucPatientsData.Instence.BringToFront();
            }
            else
            {
                ucPatientsData.Instence.BringToFront();
            }
        }

        private void btnAddToData2_Click(object sender, EventArgs e)
        {


            //code here...

            if (!MainForn.main_Panel.Controls.Contains(ucPatientsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientsData.Instence);
                ucPatientsData.Instence.Dock = DockStyle.Fill;
                ucPatientsData.Instence.BringToFront();
            }
            else
            {
                ucPatientsData.Instence.BringToFront();
            }
        }
    }
}
