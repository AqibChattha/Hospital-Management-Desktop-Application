using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public class ChangeUC
    {
        public static void To_ucDoctorsData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucDoctorsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucDoctorsData.Instence);
                ucDoctorsData.Instence.Dock = DockStyle.Fill;
                ucDoctorsData.Instence.BringToFront();
            }
            else
            {
                ucDoctorsData.Instence.RefreshUC();
                ucDoctorsData.Instence.BringToFront();
            }
        }
        public static void To_ucAddDoctor()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddDoctor.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddDoctor.Instence);
                ucAddDoctor.Instence.Dock = DockStyle.Fill;
                ucAddDoctor.Instence.BringToFront();
            }
            else
            {
                ucAddDoctor.Instence.RefreshUC();
                ucAddDoctor.Instence.BringToFront();
            }
        }
        public static void To_ucAddNurse()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddNurse.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddNurse.Instence);
                ucAddNurse.Instence.Dock = DockStyle.Fill;
                ucAddNurse.Instence.BringToFront();
            }
            else
            {
                ucAddNurse.Instence.RefreshUC();
                ucAddNurse.Instence.BringToFront();
            }
        }
        public static void To_ucNursesData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucNursesData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucNursesData.Instence);
                ucNursesData.Instence.Dock = DockStyle.Fill;
                ucNursesData.Instence.BringToFront();
            }
            else
            {
                ucNursesData.Instence.RefreshUC();
                ucNursesData.Instence.BringToFront();
            }
        }
        public static void To_ucLaboratoryTechniciansData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucLaboratoryTechniciansData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucLaboratoryTechniciansData.Instence);
                ucLaboratoryTechniciansData.Instence.Dock = DockStyle.Fill;
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
            else
            {
                ucLaboratoryTechniciansData.Instence.RefreshUC();
                ucLaboratoryTechniciansData.Instence.BringToFront();
            }
        }
        public static void To_ucAddLaboratoryTechnician()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddLaboratoryTechnician.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddLaboratoryTechnician.Instence);
                ucAddLaboratoryTechnician.Instence.Dock = DockStyle.Fill;
                ucAddLaboratoryTechnician.Instence.BringToFront();
            }
            else
            {
                ucAddLaboratoryTechnician.Instence.RefreshUC();
                ucAddLaboratoryTechnician.Instence.BringToFront();
            }
        }
        public static void To_ucPharmacistData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucPharmacistData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPharmacistData.Instence);
                ucPharmacistData.Instence.Dock = DockStyle.Fill;
                ucPharmacistData.Instence.BringToFront();
            }
            else
            {
                ucPharmacistData.Instence.RefreshUC();
                ucPharmacistData.Instence.BringToFront();
            }
        }
        public static void To_ucAddPharmacist()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddPharmacist.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddPharmacist.Instence);
                ucAddPharmacist.Instence.Dock = DockStyle.Fill;
                ucAddPharmacist.Instence.BringToFront();
            }
            else
            {
                ucAddDoctor.Instence.RefreshUC();
                ucAddPharmacist.Instence.BringToFront();
            }
        }
        public static void To_ucSurgeonsData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucSurgeonsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucSurgeonsData.Instence);
                ucSurgeonsData.Instence.Dock = DockStyle.Fill;
                ucSurgeonsData.Instence.BringToFront();
            }
            else
            {
                ucSurgeonsData.Instence.RefreshUC();
                ucSurgeonsData.Instence.BringToFront();
            }
        }

        public static void To_ucAddSurgeon()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddSurgeon.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddSurgeon.Instence);
                ucAddSurgeon.Instence.Dock = DockStyle.Fill;
                ucAddSurgeon.Instence.BringToFront();
            }
            else
            {
                ucAddSurgeon.Instence.RefreshUC();
                ucAddSurgeon.Instence.BringToFront();
            }
        }

        public static void To_ucReceptionistsData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucReceptionistsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucReceptionistsData.Instence);
                ucReceptionistsData.Instence.Dock = DockStyle.Fill;
                ucReceptionistsData.Instence.BringToFront();
            }
            else
            {
                ucReceptionistsData.Instence.RefreshUC();
                ucReceptionistsData.Instence.BringToFront();
            }
        }

        public static void To_ucAddReceptionist()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddReceptionist.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddReceptionist.Instence);
                ucAddReceptionist.Instence.Dock = DockStyle.Fill;
                ucAddReceptionist.Instence.BringToFront();
            }
            else
            {
                ucAddReceptionist.Instence.RefreshUC();
                ucAddReceptionist.Instence.BringToFront();
            }
        }

        public static void To_ucOtherStaffData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucOtherStaffData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucOtherStaffData.Instence);
                ucOtherStaffData.Instence.Dock = DockStyle.Fill;
                ucOtherStaffData.Instence.BringToFront();
            }
            else
            {
                ucOtherStaffData.Instence.RefreshUC();
                ucOtherStaffData.Instence.BringToFront();
            }
        }

        public static void To_ucAddOtherEmployee()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddOtherEmployee.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddOtherEmployee.Instence);
                ucAddOtherEmployee.Instence.Dock = DockStyle.Fill;
                ucAddOtherEmployee.Instence.BringToFront();
            }
            else
            {
                ucAddOtherEmployee.Instence.RefreshUC();
                ucAddOtherEmployee.Instence.BringToFront();
            }
        }

        public static void To_ucAcknowledgeTest()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAcknowledgeTest.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAcknowledgeTest.Instence);
                ucAcknowledgeTest.Instence.Dock = DockStyle.Fill;
                ucAcknowledgeTest.Instence.BringToFront();
            }
            else
            {
                ucAcknowledgeTest.Instence.RefreshUC();
                ucAcknowledgeTest.Instence.BringToFront();
            }
        }

        public static void To_ucTestsData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucTestsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucTestsData.Instence);
                ucTestsData.Instence.Dock = DockStyle.Fill;
                ucTestsData.Instence.BringToFront();
            }
            else
            {
                ucTestsData.Instence.RefreshUC();
                ucTestsData.Instence.BringToFront();
            }
        }

        public static void To_ucAddPatient()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddPatient.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddPatient.Instence);
                ucAddPatient.Instence.Dock = DockStyle.Fill;
                ucAddPatient.Instence.BringToFront();
            }
            else
            {
                ucAddPatient.Instence.RefreshUC();
                ucAddPatient.Instence.BringToFront();
            }
        }






        public static void To_ucPatientQueue()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucPatientQueue.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientQueue.Instence);
                ucPatientQueue.Instence.Dock = DockStyle.Fill;
                ucPatientQueue.Instence.BringToFront();
            }
            else
            {
                ucPatientQueue.Instence.RefreshUC();
                ucPatientQueue.Instence.BringToFront();
            }
        }

        public static void To_ucPatientsData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucPatientsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucPatientsData.Instence);
                ucPatientsData.Instence.Dock = DockStyle.Fill;
                ucPatientsData.Instence.BringToFront();
            }
            else
            {
                ucPatientsData.Instence.RefreshUC();
                ucPatientsData.Instence.BringToFront();
            }
        }

        public static void To_ucCapitalData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucCapitalData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucCapitalData.Instence);
                ucCapitalData.Instence.Dock = DockStyle.Fill;
                ucCapitalData.Instence.BringToFront();
            }
            else
            {
                ucCapitalData.Instence.BringToFront();
            }
        }
        public static void To_ucAddUnits()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucAddUnits.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucAddUnits.Instence);
                ucAddUnits.Instence.Dock = DockStyle.Fill;
                ucAddUnits.Instence.BringToFront();
            }
            else
            {
                ucAddUnits.Instence.BringToFront();
            }
        }
        public static void To_ucUnitsData()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucUnitsData.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucUnitsData.Instence);
                ucUnitsData.Instence.Dock = DockStyle.Fill;
                ucUnitsData.Instence.BringToFront();
            }
            else
            {
                ucUnitsData.Instence.BringToFront();
            }
        }
        public static void To_ucHome()
        {
            if (!MainForn.main_Panel.Controls.Contains(ucHome.Instence))
            {
                MainForn.main_Panel.Controls.Add(ucHome.Instence);
                ucHome.Instence.Dock = DockStyle.Fill;
                ucHome.Instence.BringToFront();
            }
            else
            {
                ucHome.Instence.BringToFront();
            }
        }
    }
}
