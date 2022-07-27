using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class ucCapitalData : UserControl
    {
        private static ucCapitalData _instence;
        public static ucCapitalData Instence
        {
            get
            {
                if (_instence == null)
                {
                    _instence = new ucCapitalData();
                }
                return _instence;
            }
        }
        public ucCapitalData()
        {
            InitializeComponent();
            cbViewType.SelectedText = "Month";
            lbTime.Text = "Month:";
            dtpTime.CustomFormat = "MMMM-yyyy";
        }

        private void cbViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbViewType.SelectedItem.ToString().Equals("Month"))
            {
                lbTime.Text = "Month:";
                dtpTime.CustomFormat = "MMMM-yyyy";
            }
            if (cbViewType.SelectedItem.ToString().Equals("Year"))
            {
                lbTime.Text = "Year:";
                dtpTime.CustomFormat = "yyyy";
            }
        }
    }
}
