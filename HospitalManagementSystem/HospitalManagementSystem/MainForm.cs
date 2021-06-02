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
            panel.Controls.Add(ucHome.Instence);
            ucHome.Instence.Dock = DockStyle.Fill;
            ucHome.Instence.BringToFront();
            main_Panel = panel;
        }

        private void customizeDesign()
        {
            panelDoctorsSubMenu.Visible = false;
            panelPatientsSubMenu.Visible = false;
            panelLabSubMenu.Visible = false;
            panelRecordSubMenu.Visible = false;
            panelCapitalSubMenu.Visible = false;
            panelUnitsSubMenu.Visible = false;
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
            if (panelUnitsSubMenu.Visible == true)
            {
                panelUnitsSubMenu.Visible = false;
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
        #region EmployeesSubMenu

        private void btnDoctor_Click(object sender, EventArgs e)
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

        private void btnNurse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucNursesData.Instence))
            {
                panel.Controls.Add(ucNursesData.Instence);
                ucNursesData.Instence.Dock = DockStyle.Fill;
                ucNursesData.Instence.BringToFront();
            }
            else
            {
                ucNursesData.Instence.BringToFront();
            }
            main_Panel = panel;

        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucPharmacistData.Instence))
            {
                panel.Controls.Add(ucPharmacistData.Instence);
                ucPharmacistData.Instence.Dock = DockStyle.Fill;
                ucPharmacistData.Instence.BringToFront();
            }
            else
            {
                ucPharmacistData.Instence.BringToFront();
            }
            main_Panel = panel;

        }

        private void btnLaboratoryTechnician_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucLaboratoryTechniciansData.Instence))
            {
                panel.Controls.Add(ucLaboratoryTechniciansData.Instence);
                ucLaboratoryTechniciansData.Instence.Dock = DockStyle.Fill;
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
            else
            {
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
            main_Panel = panel;

        }

        private void btnSurgeon_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucSurgeonsData.Instence))
            {
                panel.Controls.Add(ucSurgeonsData.Instence);
                ucSurgeonsData.Instence.Dock = DockStyle.Fill;
                ucSurgeonsData.Instence.BringToFront();
            }
            else
            {
                ucSurgeonsData.Instence.BringToFront();
            }
            main_Panel = panel;
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucReceptionistsData.Instence))
            {
                panel.Controls.Add(ucReceptionistsData.Instence);
                ucReceptionistsData.Instence.Dock = DockStyle.Fill;
                ucReceptionistsData.Instence.BringToFront();
            }
            else
            {
                ucReceptionistsData.Instence.BringToFront();
            }
            main_Panel = panel;

        }

        private void btnOtherEmployees_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucOtherStaffData.Instence))
            {
                panel.Controls.Add(ucOtherStaffData.Instence);
                ucOtherStaffData.Instence.Dock = DockStyle.Fill;
                ucOtherStaffData.Instence.BringToFront();
            }
            else
            {
                ucOtherStaffData.Instence.BringToFront();
            }
            main_Panel = panel;

        }
        #endregion

        private void btnPatients_Click(object sender, EventArgs e)
        {
            showSubMenu(panelPatientsSubMenu);
            panelSideSlecectedShow.Height = btnPatients.Height;
            panelSideSlecectedShow.Top = btnPatients.Top;
        }
        #region PatientsSubMenu

        private void btnPatientQueue_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panelSideSlecectedShow.Height = btnHome.Height;
            panelSideSlecectedShow.Top = btnHome.Top;
            if (!panel.Controls.Contains(ucAddPatient.Instence))
            {
                panel.Controls.Add(ucAddPatient.Instence);
                ucAddPatient.Instence.Dock = DockStyle.Fill;
                ucAddPatient.Instence.BringToFront();
            }
            else
            {
                ucAddPatient.Instence.BringToFront();
            }
            main_Panel = panel;

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
            if (!panel.Controls.Contains(ucAcknowledgeTest.Instence))
            {
                panel.Controls.Add(ucAcknowledgeTest.Instence);
                ucAcknowledgeTest.Instence.Dock = DockStyle.Fill;
                ucAcknowledgeTest.Instence.BringToFront();
            }
            else
            {
                ucAcknowledgeTest.Instence.BringToFront();
            }
            main_Panel = panel;
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panelSideSlecectedShow.Height = btnHome.Height;
            panelSideSlecectedShow.Top = btnHome.Top;
            if (!panel.Controls.Contains(ucHome.Instence))
            {
                panel.Controls.Add(ucHome.Instence);
                ucHome.Instence.Dock = DockStyle.Fill;
                ucHome.Instence.BringToFront();
            }
            else
            {
                ucHome.Instence.BringToFront();
            }
            main_Panel = panel;
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUnitsSubMenu);
            panelSideSlecectedShow.Height = btnCapital.Height;
            panelSideSlecectedShow.Top = btnCapital.Top;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucAddUnits.Instence))
            {
                panel.Controls.Add(ucAddUnits.Instence);
                ucAddUnits.Instence.Dock = DockStyle.Fill;
                ucAddUnits.Instence.BringToFront();
            }
            else
            {
                ucAddUnits.Instence.BringToFront();
            }
            main_Panel = panel;
        }

        private void btnViewUnit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (!panel.Controls.Contains(ucUnitsData.Instence))
            {
                panel.Controls.Add(ucUnitsData.Instence);
                ucUnitsData.Instence.Dock = DockStyle.Fill;
                ucUnitsData.Instence.BringToFront();
            }
            else
            {
                ucUnitsData.Instence.BringToFront();
            }
            main_Panel = panel;

        }

        private void panelMenuLogo_MouseClick(object sender, MouseEventArgs e)
        {
            hideSubMenu();
            panelSideSlecectedShow.Height = btnHome.Height;
            panelSideSlecectedShow.Top = btnHome.Top;
            if (!panel.Controls.Contains(ucHome.Instence))
            {
                panel.Controls.Add(ucHome.Instence);
                ucHome.Instence.Dock = DockStyle.Fill;
                ucHome.Instence.BringToFront();
            }
            else
            {
                ucHome.Instence.BringToFront();
            }
            main_Panel = panel;
        }
    }
}
