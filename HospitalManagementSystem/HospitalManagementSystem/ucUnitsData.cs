using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucUnitsData : UserControl
    {
        private static ucUnitsData _instence;
        public static ucUnitsData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucUnitsData();
                }
                return _instence;
            }
        }
        public ucUnitsData()
        {
            InitializeComponent();
            dtvUnits.AllowUserToAddRows = false;
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
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
    }
}
