using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class MainForn : Form
    {
        public static Panel main_Panel;
        public MainForn()
        {
            InitializeComponent();
            customizeDesign();
            main_Panel = panel;

        }

        private void customizeDesign()
        {
            panelDoctorsSubMenu.Visible = false;
            panelPatientsSubMenu.Visible = false;
            panelLabSubMenu.Visible = false;
            panelRecordSubMenu.Visible = false;
            panelCapitalSubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelDoctorsSubMenu.Visible == true)
            {
                panelDoctorsSubMenu.Visible = false;
            }
            if (panelPatientsSubMenu.Visible == true)
            {
                panelPatientsSubMenu.Visible = false;
            }
            if (panelLabSubMenu.Visible == true)
            {
                panelLabSubMenu.Visible = false;
            }
            if (panelRecordSubMenu.Visible == true)
            {
                panelRecordSubMenu.Visible = false;
            }
            if (panelCapitalSubMenu.Visible == true)
            {
                panelCapitalSubMenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            showSubMenu(panelDoctorsSubMenu);
            panelSideSlecectedShow.Height = btnEmployees.Height;
            panelSideSlecectedShow.Top = btnEmployees.Top;
        }
        #region DoctorsSubMenu
        private void btnViewDoctor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucDoctorsData.Instence))
            {
                panel.Controls.Add(ucDoctorsData.Instence);
                ucDoctorsData.Instence.Dock = DockStyle.Fill;
                ucDoctorsData.Instence.BringToFront();
            }
            else
            {
                ucDoctorsData.Instence.BringToFront();
            }
            main_Panel = panel;
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucAddNurse.Instence))
            {
                panel.Controls.Add(ucAddNurse.Instence);
                ucAddNurse.Instence.Dock = DockStyle.Fill;
                ucAddNurse.Instence.BringToFront();
            }
            else
            {
                ucAddNurse.Instence.BringToFront();
            }
        }

        private void btnUpdateDoctor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRemoveDoctor_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnDoctorAttendence_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnPatients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPatientsSubMenu);
            panelSideSlecectedShow.Height = btnPatients.Height;
            panelSideSlecectedShow.Top = btnPatients.Top;
        }
        #region PatientsSubMenu
        private void btnViewPatient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnUpdatePatient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnRemovePatient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        private void btnLaboratory_Click(object sender, EventArgs e)
        {
            showSubMenu(panelLabSubMenu);
            panelSideSlecectedShow.Height = btnLaboratory.Height;
            panelSideSlecectedShow.Top = btnLaboratory.Top;
        }
        #region LabSubMenu
        private void btnAddTest_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnViewTests_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnStaffAtLab_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        private void btnRecord_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRecordSubMenu);
            panelSideSlecectedShow.Height = btnRecord.Height;
            panelSideSlecectedShow.Top = btnRecord.Top;
        }
        #region RecordsSubMenu
        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void btnCapital_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCapitalSubMenu);
            panelSideSlecectedShow.Height = btnCapital.Height;
            panelSideSlecectedShow.Top = btnCapital.Top;
        }
        #region CapitalSubMenu
        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
