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
            LoadComboBox(csHospital.Instence.getSamples(), csHospital.Instence.getLaboratories());
            txtCost.ReadOnly = true;
        }

        private void LoadComboBox(List<csSample> s, List<csLaboratory> l)
        {
            cbSample.Items.Clear();
            cbLaboratory.Items.Clear();
            for (int i = 0; i < s.Count; i++)
            {
                cbSample.Items.Add(s[i].Name);
            }
            for (int i = 0; i < l.Count; i++)
            {
                cbLaboratory.Items.Add(l[i].Id);
            }
        }
        private String GenerateTestId()
        {
            String id = "";
            bool flag = true;
            for (int i = 1; i <= csHospital.Instence.getLabTests().Count + 10; i++)
            {
                id = "TST-" + i;
                for (int j = 0; j < csHospital.Instence.getLabTests().Count; j++)
                {
                    if (id.Equals(csHospital.Instence.getLabTests()[j].TestId))
                    {
                        flag = false;
                    }
                }
                if (flag == false)
                {
                    flag = true;
                }
                else
                {
                    return id;
                }
            }
            return id;
        }

        private void btnGenerateID_Click(object sender, EventArgs e)
        {
            txtTestID.Text = GenerateTestId();
        }
        private void ClearAllFields()
        {
            txtPatientName.Text = "";
            txtPatientID.Text = "";
            txtTestID.Text = "";
            txtCost.Text = "";
            cbSample.Text = "";
            cbLaboratory.Text = "";
            dtpDueDate.Value = DateTime.Today;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private csSample getSample(String sName)
        {
            for(int i=0; i<csHospital.Instence.getSamples().Count; i++)
            {
                if (sName.Equals(csHospital.Instence.getSamples()[i].Name))
                {
                    return csHospital.Instence.getSamples()[i];
                }
            }
            return null;
        }

        private void btnAcknowledge_Click(object sender, EventArgs e)
        {
            String pName = txtPatientName.Text;
            String pID = txtPatientID.Text;
            String tID = txtTestID.Text;
            csSample tSample = null;
            String labID = "";
            if(cbSample.SelectedItem == null || cbLaboratory.SelectedItem == null)
            {
            }
            else
            {
                tSample = getSample(cbSample.SelectedItem.ToString());
                labID = cbLaboratory.SelectedItem.ToString();
            }
            DateTime dueDate = dtpDueDate.Value;
            if (sample != null)
            {
                if (Validat.LabTest(pName, pID, tID, labID, dueDate, tSample))
                {
                    csLabTest lt = new csLabTest(pName, pID, tID, labID, dueDate, tSample);

                }
            }
        }

        private void cbSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<csSample> samples = csHospital.Instence.getSamples();
            for(int i=0; i<samples.Count; i++)
            {
                if (cbSample.SelectedItem.ToString().Equals(samples[i].Name))
                {
                    txtCost.Text = samples[i].Cost.ToString();
                }                
            }
        }
    }
}
