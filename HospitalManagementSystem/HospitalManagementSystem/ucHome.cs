using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucHome : UserControl
    {
        private static ucHome _instence;
        public static ucHome Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucHome();
                }
                return _instence;
            }
        }
        public ucHome()
        {
            InitializeComponent();
        }
    }
}
