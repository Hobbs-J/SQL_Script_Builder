using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Script_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Text = "Custom";
        }

        private void cbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCommand.Text == "Select")
            {
                lblUpdate1.Visible = false;
                txtUpdate1.Visible = false;
                cbUpdate1.Visible = false;
                lbtablecolumn.Text = "Column Name:";
                lblColumnTable2.Text = "Table Name:";
                cbInfo1.Visible = false;
                cbInfo2.Items.Add("From");
                cbInfo2.Text = "From";
                cbInfo3.Items.Add("Where");
                cbInfo3.Text = "Where";
                lblColumnTableName3.Text = "Column Name:";
                cbInfo4.Items.Add("=");
                cbInfo4.Items.Add("Like");
                cbInfo4.Text = "=";
                lblColumnTableName4.Text = "Value to Select by:";
            }
            if (cbCommand.Text == "Update")
            {
                lbtablecolumn.Text = "Table Name:";
                cbInfo1.Visible = false;
                cbInfo2.Items.Add("Set");
                cbInfo2.Text = "Set";
                lblColumnTable2.Text = "Column Name:";
                cbInfo3.Items.Add("=");
                cbInfo3.Text = "=";
                cbInfo4.Items.Add("Where");
                cbInfo4.Items.Add("From");
                cbInfo4.Text = "Where";
                lblColumnTableName3.Text = "Column Value:";
                lblColumnTableName4.Text = "Column Name:";
                lblUpdate1.Visible = true;
                txtUpdate1.Visible = true;
                cbUpdate1.Visible = true;
                cbUpdate1.Items.Add("=");
                cbUpdate1.Items.Add("Like");
                cbUpdate1.Text = "=";
            }
            if (cbCommand.Text == "Delete")
            {
                lbtablecolumn.Text = "Table Name:";
            }
            if (cbCommand.Text == "Insert")
            {
                lbtablecolumn.Text = "Table Name:";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCommand.Text == "Select")
            {
                txtResults.Text = "Use " + txtTargetDatabase.Text + Environment.NewLine + cbCommand.Text + " " + txtTableColumnName.Text + " " + cbInfo2.Text + " " + txtColumnTable2.Text + " " + Environment.NewLine + cbInfo3.Text + " " + txtColumnTableName3.Text + " " + cbInfo4.Text + " '" + txtColumnTableName4.Text + "'";
            }
            if (cbCommand.Text == "Update")
            {
                txtResults.Text = "Use " + txtTargetDatabase.Text + Environment.NewLine + cbCommand.Text + " " + txtTableColumnName.Text + " " + cbInfo2.Text + " " + txtColumnTable2.Text + " " + cbInfo3.Text + " '" + txtColumnTableName3.Text + "' " + cbInfo4.Text + " " + txtColumnTableName4.Text + " " + cbUpdate1.Text + " '" + txtUpdate1.Text + "'";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Replace file locations")
            {
                pnlPremadeFileLoc.Visible = true;
                pnlCustomStrings.Visible = false;                
                pnlClaimsRetire.Visible = false;
                pnlAssignFormtoNewPatient.Visible = false;
                pnlUnlockForm.Visible = false;

            }
            if (comboBox1.Text == "Retire or un-retire claims")
            {
                dtpClaims.CustomFormat = "yyyy-MM-dd";
                dtpClaimsTo.CustomFormat = "yyyy-MM-dd";
                pnlCustomStrings.Visible = false;
                pnlClaimsRetire.Visible = true;
                pnlPremadeFileLoc.Visible = false;
                dtpClaimsTo.Visible = false;
                pnlAssignFormtoNewPatient.Visible = false;
                pnlUnlockForm.Visible = false;
            }
            if (comboBox1.Text == "Move Forms to a different patient")
            {
                pnlCustomStrings.Visible = false;
                pnlPremadeFileLoc.Visible = false;
                pnlClaimsRetire.Visible = false;
                pnlAssignFormtoNewPatient.Visible = true;
                pnlUnlockForm.Visible = false;

            }
            if (comboBox1.Text == "Unlock Forms")
            {
                cbUseUnlock.Text = "DentalWriter";
                dtpUnlock.CustomFormat = "yyyy-MM-dd";
                pnlCustomStrings.Visible = false;
                pnlPremadeFileLoc.Visible = false;
                pnlClaimsRetire.Visible = false;
                pnlAssignFormtoNewPatient.Visible = false;
                pnlUnlockForm.Visible = true;

            }
            if (comboBox1.Text == "Custom")
            {
                pnlCustomStrings.Visible = true;
                pnlPremadeFileLoc.Visible = false;
                pnlClaimsRetire.Visible = false;
                pnlAssignFormtoNewPatient.Visible = false;
                pnlUnlockForm.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultsFileLoc.Text = "Update [DentalWriter].[dbo].[SystemConfig] set ItemValue = Replace(ItemValue, " + "'" + txtOld.Text + "', '" + txtNew.Text + "') where ItemValue like '" + txtOld.Text + "%'" + Environment.NewLine +
            "Update [DentalWriter].[dbo].SendTo set Docname = REPLACE(DocName, '" + txtOld.Text + "' ,'" + txtNew.Text + "')" + Environment.NewLine +
            "Update [DentalWriter].[dbo].ExmRslt set FieldValue = REPLACE(FieldValue, '" + txtOld.Text + "' ,'" + txtNew.Text + "')" + Environment.NewLine +
            "Update [DentalWriter].[dbo].Patient set PatientImageFilePath = REPLACE(PatientImageFilePath, '" + txtOld.Text + "' ,'" + txtNew.Text + "')" + Environment.NewLine;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string streGreaterLess = "";
            if (chkGreaterThan.Checked == true) 
            {
                streGreaterLess = ">=";
            }
            else
            {
                streGreaterLess = "<=";
            }
            if (dtpClaimsTo.Visible == false)
            {
                txtClaimsRetire.Text = "Update CMS1500" + Environment.NewLine + "Set CMS1500.Retired = '" + chkRetire.Checked + "'" + Environment.NewLine + "From CMS1500" + Environment.NewLine + "INNER JOIN Patientform" + Environment.NewLine + "ON Patientform.patientformid = CMS1500.PatientformFK" + Environment.NewLine + "Where Patientform.formdate " + streGreaterLess + " '" + dtpClaims.Text + " 00:00:00.000'";
            }
            else
            {
                txtClaimsRetire.Text = "Update CMS1500" + Environment.NewLine + "Set CMS1500.Retired = '" + chkRetire.Checked + "'" + Environment.NewLine + "From CMS1500" + Environment.NewLine + "INNER JOIN Patientform" + Environment.NewLine + "ON Patientform.patientformid = CMS1500.PatientformFK" + Environment.NewLine + "Where Patientform.formdate >= '" + dtpClaims.Text + " 00:00:00.000'" + " AND Patientform.formdate <= '" + dtpClaimsTo.Text + " 00:00:00.000'";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dtpClaimsTo.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           string FinalScript;
           string strBaseScript = "Update PatientForm set PatientID = '" + txtPatientIDMove.Text + "' where FormCode != 'FRMPATIENT' and PatientFormId = '";
           string strPatientFormIDs = txtFormIDMove.Text;
           string[] FormIDstrings = strPatientFormIDs.Split(',');
            if (strPatientFormIDs.Contains(','))
            {
                FinalScript = "";
                foreach (string FormID in FormIDstrings)
                {
                    if (FinalScript == "")
                    {
                        FinalScript = strBaseScript + FormID + "'";
                    }
                    else
                    {
                        FinalScript = FinalScript + " or PatientFormID = '" + FormID + "'";
                    }                    
                }
                txtMoveformtonewpatient.Text = FinalScript;
            }
            else
            {
                FinalScript = strBaseScript + txtFormIDMove.Text + "'";
                txtMoveformtonewpatient.Text = FinalScript;
            }
           
           
        }

        private void btnGenerateUnlock_Click(object sender, EventArgs e)
        {
            if (rbFormIDUnlock.Checked == true)
            {
                string FinalScript;
                string strBaseScript = "Use " + cbUseUnlock.Text + Environment.NewLine + "Update PatientForm set FormIsLocked = 0, LockedBy = NULL" + Environment.NewLine + "Where PatientFormID = '";
                string strPatientFormIDs = txtFormUnlockID.Text;
                string[] FormIDstrings = strPatientFormIDs.Split(',');
                if (strPatientFormIDs.Contains(','))
                {
                    FinalScript = "";
                    foreach (string FormID in FormIDstrings)
                    {
                        if (FinalScript == "")
                        {
                            FinalScript = strBaseScript + FormID + "'";
                        }
                        else
                        {
                            FinalScript = FinalScript + Environment.NewLine + "or PatientFormID = '" + FormID + "'";
                        }
                    }
                    txtResultUnlock.Text = FinalScript;
                }
                //txtResultUnlock.Text = "Use " + cbUseUnlock.Text + Environment.NewLine + "Update PatientForm Set FormIsLocked = 0, LockedBy = null " + Environment.NewLine + "Where PatientFormID = '" + txtFormUnlockID.Text + "'";
                return;
            }
            if (rbAfterDateUnlock.Checked == true)
            {
                txtResultUnlock.Text = "Use " + cbUseUnlock.Text + Environment.NewLine + "Update PatientForm Set FormIsLocked = 0, LockedBy = null " + Environment.NewLine + "Where FormDate >= '" + dtpUnlock.Text + " 00:00:00.000'";
                return;
            }
            if (rbBeforeDateUnlock.Checked == true)
            {
                txtResultUnlock.Text = "Use " + cbUseUnlock.Text + Environment.NewLine + "Update PatientForm Set FormIsLocked = 0, LockedBy = null " + Environment.NewLine + "Where FormDate <= '" + dtpUnlock.Text + " 00:00:00.000'";
                return;
            }
        }
    }
}
