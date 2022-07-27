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
            LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
            dtvLabTests.AllowUserToAddRows = false;
        }
        private void LoadLabTestsDataInDtv(List<csLabTest> labTests)
        {
            dtvLabTests.Rows.Clear();
            for (int i = 0; i < labTests.Count; i++)
            {
                if (!labTests[i].Result.Equals(""))
                {
                    dtvLabTests.Rows.Add(labTests[i].TestId, labTests[i].PatientId, labTests[i].PatientName, labTests[i].DueDate.ToShortDateString());
                }
            }
        }

        public void RefreshUC()
        {
            LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
        }
        private int getLabTestIndex(int indx)
        {
            List<csLabTest> labTests = csHospital.Instence.getLabTests();
            for (int i = 0; i < labTests.Count; i++)
            {
                if (labTests[i].TestId.Equals(dtvLabTests.Rows[indx].Cells[0].Value.ToString()) == true && labTests[i].PatientId.Equals(dtvLabTests.Rows[indx].Cells[1].Value.ToString()) == true)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            ChangeUC.To_ucAcknowledgeTest();
        }

        private void dtvLabTests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    DialogResult dr = MessageBox.Show("Are you sure you want to delete this Lab-Test.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        csHospital.Instence.DeleteLabTest(getLabTestIndex(e.RowIndex));
                        LoadLabTestsDataInDtv(csHospital.Instence.getLabTests());
                    }
                }

                if (e.ColumnIndex == 5)
                {
                    if (!MainForn.main_Panel.Controls.Contains(ucAcknowledgeTest.Instence))
                    {
                        MainForn.main_Panel.Controls.Add(ucAcknowledgeTest.Instence);
                        ucAcknowledgeTest.Instence.Dock = DockStyle.Fill;
                        ucAcknowledgeTest.Instence.UpdateColumnClicked(getLabTestIndex(e.RowIndex));
                        ucAcknowledgeTest.Instence.BringToFront();
                    }
                    else
                    {
                        ucAcknowledgeTest.Instence.UpdateColumnClicked(getLabTestIndex(e.RowIndex));
                        ucAcknowledgeTest.Instence.BringToFront();
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    csHospital.Instence.ViewLabTest(getLabTestIndex(e.RowIndex));
                    txtSearch.Text = "";
                }
            }
        }
    }
}
