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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
