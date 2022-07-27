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
            LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
            dtvAcknowlegedTests.AllowUserToAddRows = false;
        }
        private void LoadLabTestsDataInDtv(List<csLabTest> labTests)
        {
            dtvAcknowlegedTests.Rows.Clear();
            for (int i = 0; i < labTests.Count; i++)
            {
                if (labTests[i].Result.Equals(""))
                {
                    dtvAcknowlegedTests.Rows.Add(labTests[i].PatientName, labTests[i].PatientId, labTests[i].TestId, labTests[i].Sample.Name, labTests[i].DueDate.ToShortDateString());
                }
            }
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

        private void ClearAllFields()
        {
            txtPatientName.Text = "";
            txtPatientID.Text = "";
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
            for (int i = 0; i < csHospital.Instence.getSamples().Count; i++)
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
            csSample tSample = null;
            String labID = "";
            if (cbSample.SelectedItem == null || cbLaboratory.SelectedItem == null)
            {
            }
            else
            {
                tSample = getSample(cbSample.SelectedItem.ToString());
                labID = cbLaboratory.SelectedItem.ToString();
            }
            DateTime dueDate = dtpDueDate.Value;
            if (tSample != null && labID != "" && txtPatientName.Text !="" && txtPatientID.Text != "" && txtCost.Text != "")
            {
                if (Validat.LabTest(pName, pID, labID, dueDate, tSample))
                {
                    csLabTest lt = new csLabTest(pName, pID, labID, tSample, dueDate);
                    csHospital.Instence.AddLabTest(lt);
                    ClearAllFields();
                    LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
                    return;

                }
            }
            MessageBox.Show("Invalid information. Please try again.");
        }

        private void cbSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<csSample> samples = csHospital.Instence.getSamples();
            for (int i = 0; i < samples.Count; i++)
            {
                if (cbSample.SelectedItem.ToString().Equals(samples[i].Name))
                {
                    txtCost.Text = samples[i].Cost.ToString();
                }
            }
        }
        private int getAcknowledgedSampleIndex(int indx)
        {
            List<csLabTest> labTests = csHospital.Instence.getLabTests();
            for (int i = 0; i < labTests.Count; i++)
            {
                if (labTests[i].TestId.Equals(dtvAcknowlegedTests.Rows[indx].Cells[2].Value.ToString()) == true && labTests[i].PatientId.Equals(dtvAcknowlegedTests.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }

        public void RefreshUC()
        {
            LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
        }

        private void dtvAcknowlegedTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    string value = "";
                    if (InputBox.Show("Test Result", "Enter the result of the test:") == DialogResult.OK)
                    {
                        value = InputBox.input;
                        MessageBox.Show(getAcknowledgedSampleIndex(e.RowIndex) + "" + value);
                        csHospital.Instence.AddLabTesResult(getAcknowledgedSampleIndex(e.RowIndex), value);
                        LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
                    }
                }
                if (e.ColumnIndex == 5)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to remove this Lab-Test.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        csHospital.Instence.DeleteLabTest(getAcknowledgedSampleIndex(e.RowIndex));
                        LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
                    }
                }
            }
        }

        public void UpdateColumnClicked(int index)
        {
            csHospital.Instence.AddLabTesResult(index, "");
            LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
        }
    }
}
