using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucAddUnits : UserControl
    {
        private static ucAddUnits _instence;
        public static ucAddUnits Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucAddUnits();
                }
                return _instence;
            }
        }
        public ucAddUnits()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
