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
            ChangeUC.To_ucDoctorsData();
            main_Panel = panel;

        }

        private void btnNurse_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucNursesData();
            main_Panel = panel;

        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucPharmacistData();
            main_Panel = panel;

        }

        private void btnLaboratoryTechnician_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucLaboratoryTechniciansData();
            main_Panel = panel;

        }

        private void btnSurgeon_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucSurgeonsData();
            main_Panel = panel;
        }

        private void btnReceptionist_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucReceptionistsData();
            main_Panel = panel;

        }

        private void btnOtherEmployees_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucOtherStaffData();
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
            ChangeUC.To_ucPatientQueue();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucAddPatient();

        }
        private void btnPatientRecord_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucPatientsData();
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
            ChangeUC.To_ucAcknowledgeTest();
        }
        private void btnTestsHistory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucTestsData();
        }
        #endregion

        private void btnCapital_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCapitalSubMenu);
            panelSideSlecectedShow.Height = btnCapital.Height;
            panelSideSlecectedShow.Top = btnCapital.Top;
        }
        #region CapitalSubMenu
        private void btnCapitalRecord_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucCapitalData();
        }
        #endregion

        private void btnUnits_Click(object sender, EventArgs e)
        {
            showSubMenu(panelUnitsSubMenu);
            panelSideSlecectedShow.Height = btnUnits.Height;
            panelSideSlecectedShow.Top = btnUnits.Top;
        }
        #region UnitsSubMenu
        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucAddUnits();
        }

        private void btnViewUnit_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            ChangeUC.To_ucUnitsData();

        }
#endregion

        private void panelMenuLogo_MouseClick(object sender, MouseEventArgs e)
        {
            hideSubMenu();
            panelSideSlecectedShow.Height = btnHome.Height;
            panelSideSlecectedShow.Top = btnHome.Top;
            ChangeUC.To_ucHome();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            csHospital.SaveData();
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            panelSideSlecectedShow.Height = btnHome.Height;
            panelSideSlecectedShow.Top = btnHome.Top;
            ChangeUC.To_ucHome();
        }

    }
}
