using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucPatientsData : UserControl
    {
        private static ucPatientsData _instence;
        public static ucPatientsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucPatientsData();
                }
                return _instence;
            }
        }
        public ucPatientsData()
        {
            InitializeComponent();
            dtvPatients.AllowUserToAddRows = false;
        }

    }
}
