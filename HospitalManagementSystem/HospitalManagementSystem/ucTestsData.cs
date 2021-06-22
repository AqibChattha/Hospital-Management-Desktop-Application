using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucTestsData : UserControl
    {
        private static ucTestsData _instence;
        public static ucTestsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucTestsData();
                }
                return _instence;
            }
        }
        public ucTestsData()
        {
            InitializeComponent();
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAcknowledgeTest();
        }
    }
}
