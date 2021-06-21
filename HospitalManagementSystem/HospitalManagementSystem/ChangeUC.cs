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
    }
}
