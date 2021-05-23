using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAcknowledgeTest : UserControl
    {
        private static ucAcknowledgeTest _instence;
        public static ucAcknowledgeTest Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAcknowledgeTest();
                }
                return _instence;
            }
        }
        public ucAcknowledgeTest()
        {
            InitializeComponent();
        }
    }
}
