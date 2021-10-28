
namespace SQL_Script_Builder
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCommand = new System.Windows.Forms.ComboBox();
            this.pnlCustomStrings = new System.Windows.Forms.Panel();
            this.cbUpdate1 = new System.Windows.Forms.ComboBox();
            this.txtUpdate1 = new System.Windows.Forms.TextBox();
            this.lblUpdate1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTargetDatabase = new System.Windows.Forms.TextBox();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbInfo4 = new System.Windows.Forms.ComboBox();
            this.txtColumnTableName4 = new System.Windows.Forms.TextBox();
            this.lblColumnTableName4 = new System.Windows.Forms.Label();
            this.cbInfo3 = new System.Windows.Forms.ComboBox();
            this.cbInfo2 = new System.Windows.Forms.ComboBox();
            this.cbInfo1 = new System.Windows.Forms.ComboBox();
            this.txtColumnTableName3 = new System.Windows.Forms.TextBox();
            this.lblColumnTableName3 = new System.Windows.Forms.Label();
            this.txtColumnTable2 = new System.Windows.Forms.TextBox();
            this.lblColumnTable2 = new System.Windows.Forms.Label();
            this.txtTableColumnName = new System.Windows.Forms.TextBox();
            this.lbtablecolumn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlPremadeFileLoc = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtResultsFileLoc = new System.Windows.Forms.RichTextBox();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlClaimsRetire = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.dtpClaimsTo = new System.Windows.Forms.DateTimePicker();
            this.chkGreaterThan = new System.Windows.Forms.CheckBox();
            this.chkRetire = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtClaimsRetire = new System.Windows.Forms.RichTextBox();
            this.dtpClaims = new System.Windows.Forms.DateTimePicker();
            this.pnlAssignFormtoNewPatient = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormIDMove = new System.Windows.Forms.TextBox();
            this.txtPatientIDMove = new System.Windows.Forms.TextBox();
            this.txtMoveformtonewpatient = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlUnlockForm = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUseUnlock = new System.Windows.Forms.ComboBox();
            this.rbAfterDateUnlock = new System.Windows.Forms.RadioButton();
            this.rbBeforeDateUnlock = new System.Windows.Forms.RadioButton();
            this.rbFormIDUnlock = new System.Windows.Forms.RadioButton();
            this.txtFormUnlockID = new System.Windows.Forms.TextBox();
            this.dtpUnlock = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateUnlock = new System.Windows.Forms.Button();
            this.txtResultUnlock = new System.Windows.Forms.RichTextBox();
            this.pnlCustomStrings.SuspendLayout();
            this.pnlPremadeFileLoc.SuspendLayout();
            this.pnlClaimsRetire.SuspendLayout();
            this.pnlAssignFormtoNewPatient.SuspendLayout();
            this.pnlUnlockForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbCommand
            // 
            this.cbCommand.FormattingEnabled = true;
            this.cbCommand.Items.AddRange(new object[] {
            "Update",
            "Insert",
            "Select",
            "Delete"});
            this.cbCommand.Location = new System.Drawing.Point(4, 112);
            this.cbCommand.Name = "cbCommand";
            this.cbCommand.Size = new System.Drawing.Size(92, 21);
            this.cbCommand.TabIndex = 0;
            this.cbCommand.SelectedIndexChanged += new System.EventHandler(this.cbCommand_SelectedIndexChanged);
            // 
            // pnlCustomStrings
            // 
            this.pnlCustomStrings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCustomStrings.Controls.Add(this.cbUpdate1);
            this.pnlCustomStrings.Controls.Add(this.txtUpdate1);
            this.pnlCustomStrings.Controls.Add(this.lblUpdate1);
            this.pnlCustomStrings.Controls.Add(this.label2);
            this.pnlCustomStrings.Controls.Add(this.txtTargetDatabase);
            this.pnlCustomStrings.Controls.Add(this.lblTarget);
            this.pnlCustomStrings.Controls.Add(this.txtResults);
            this.pnlCustomStrings.Controls.Add(this.button1);
            this.pnlCustomStrings.Controls.Add(this.cbInfo4);
            this.pnlCustomStrings.Controls.Add(this.txtColumnTableName4);
            this.pnlCustomStrings.Controls.Add(this.lblColumnTableName4);
            this.pnlCustomStrings.Controls.Add(this.cbInfo3);
            this.pnlCustomStrings.Controls.Add(this.cbInfo2);
            this.pnlCustomStrings.Controls.Add(this.cbInfo1);
            this.pnlCustomStrings.Controls.Add(this.txtColumnTableName3);
            this.pnlCustomStrings.Controls.Add(this.lblColumnTableName3);
            this.pnlCustomStrings.Controls.Add(this.txtColumnTable2);
            this.pnlCustomStrings.Controls.Add(this.lblColumnTable2);
            this.pnlCustomStrings.Controls.Add(this.txtTableColumnName);
            this.pnlCustomStrings.Controls.Add(this.lbtablecolumn);
            this.pnlCustomStrings.Controls.Add(this.label1);
            this.pnlCustomStrings.Controls.Add(this.cbCommand);
            this.pnlCustomStrings.Location = new System.Drawing.Point(11, 53);
            this.pnlCustomStrings.Name = "pnlCustomStrings";
            this.pnlCustomStrings.Size = new System.Drawing.Size(776, 495);
            this.pnlCustomStrings.TabIndex = 1;
            // 
            // cbUpdate1
            // 
            this.cbUpdate1.FormattingEnabled = true;
            this.cbUpdate1.Location = new System.Drawing.Point(342, 250);
            this.cbUpdate1.Name = "cbUpdate1";
            this.cbUpdate1.Size = new System.Drawing.Size(78, 21);
            this.cbUpdate1.TabIndex = 23;
            this.cbUpdate1.Visible = false;
            // 
            // txtUpdate1
            // 
            this.txtUpdate1.Location = new System.Drawing.Point(426, 251);
            this.txtUpdate1.Name = "txtUpdate1";
            this.txtUpdate1.Size = new System.Drawing.Size(140, 20);
            this.txtUpdate1.TabIndex = 22;
            this.txtUpdate1.Visible = false;
            // 
            // lblUpdate1
            // 
            this.lblUpdate1.AutoSize = true;
            this.lblUpdate1.Location = new System.Drawing.Point(423, 232);
            this.lblUpdate1.Name = "lblUpdate1";
            this.lblUpdate1.Size = new System.Drawing.Size(75, 13);
            this.lblUpdate1.TabIndex = 21;
            this.lblUpdate1.Text = "Column Value:";
            this.lblUpdate1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(345, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Use the % symbol at the beginning or end of search criteria for wildcards";
            // 
            // txtTargetDatabase
            // 
            this.txtTargetDatabase.Location = new System.Drawing.Point(102, 54);
            this.txtTargetDatabase.Name = "txtTargetDatabase";
            this.txtTargetDatabase.Size = new System.Drawing.Size(224, 20);
            this.txtTargetDatabase.TabIndex = 19;
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(2, 57);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(90, 13);
            this.lblTarget.TabIndex = 18;
            this.lblTarget.Text = "Target Database:";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(4, 390);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(684, 93);
            this.txtResults.TabIndex = 17;
            this.txtResults.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(694, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbInfo4
            // 
            this.cbInfo4.FormattingEnabled = true;
            this.cbInfo4.Location = new System.Drawing.Point(102, 250);
            this.cbInfo4.Name = "cbInfo4";
            this.cbInfo4.Size = new System.Drawing.Size(78, 21);
            this.cbInfo4.TabIndex = 15;
            // 
            // txtColumnTableName4
            // 
            this.txtColumnTableName4.Location = new System.Drawing.Point(186, 251);
            this.txtColumnTableName4.Name = "txtColumnTableName4";
            this.txtColumnTableName4.Size = new System.Drawing.Size(140, 20);
            this.txtColumnTableName4.TabIndex = 14;
            // 
            // lblColumnTableName4
            // 
            this.lblColumnTableName4.AutoSize = true;
            this.lblColumnTableName4.Location = new System.Drawing.Point(183, 232);
            this.lblColumnTableName4.Name = "lblColumnTableName4";
            this.lblColumnTableName4.Size = new System.Drawing.Size(68, 13);
            this.lblColumnTableName4.TabIndex = 13;
            this.lblColumnTableName4.Text = "Table Name:";
            // 
            // cbInfo3
            // 
            this.cbInfo3.FormattingEnabled = true;
            this.cbInfo3.Location = new System.Drawing.Point(102, 203);
            this.cbInfo3.Name = "cbInfo3";
            this.cbInfo3.Size = new System.Drawing.Size(78, 21);
            this.cbInfo3.TabIndex = 12;
            // 
            // cbInfo2
            // 
            this.cbInfo2.FormattingEnabled = true;
            this.cbInfo2.Location = new System.Drawing.Point(102, 158);
            this.cbInfo2.Name = "cbInfo2";
            this.cbInfo2.Size = new System.Drawing.Size(78, 21);
            this.cbInfo2.TabIndex = 11;
            // 
            // cbInfo1
            // 
            this.cbInfo1.FormattingEnabled = true;
            this.cbInfo1.Location = new System.Drawing.Point(102, 112);
            this.cbInfo1.Name = "cbInfo1";
            this.cbInfo1.Size = new System.Drawing.Size(78, 21);
            this.cbInfo1.TabIndex = 10;
            // 
            // txtColumnTableName3
            // 
            this.txtColumnTableName3.Location = new System.Drawing.Point(186, 204);
            this.txtColumnTableName3.Name = "txtColumnTableName3";
            this.txtColumnTableName3.Size = new System.Drawing.Size(140, 20);
            this.txtColumnTableName3.TabIndex = 9;
            // 
            // lblColumnTableName3
            // 
            this.lblColumnTableName3.AutoSize = true;
            this.lblColumnTableName3.Location = new System.Drawing.Point(183, 186);
            this.lblColumnTableName3.Name = "lblColumnTableName3";
            this.lblColumnTableName3.Size = new System.Drawing.Size(68, 13);
            this.lblColumnTableName3.TabIndex = 8;
            this.lblColumnTableName3.Text = "Table Name:";
            // 
            // txtColumnTable2
            // 
            this.txtColumnTable2.Location = new System.Drawing.Point(186, 159);
            this.txtColumnTable2.Name = "txtColumnTable2";
            this.txtColumnTable2.Size = new System.Drawing.Size(140, 20);
            this.txtColumnTable2.TabIndex = 5;
            // 
            // lblColumnTable2
            // 
            this.lblColumnTable2.AutoSize = true;
            this.lblColumnTable2.Location = new System.Drawing.Point(183, 141);
            this.lblColumnTable2.Name = "lblColumnTable2";
            this.lblColumnTable2.Size = new System.Drawing.Size(68, 13);
            this.lblColumnTable2.TabIndex = 4;
            this.lblColumnTable2.Text = "Table Name:";
            // 
            // txtTableColumnName
            // 
            this.txtTableColumnName.Location = new System.Drawing.Point(186, 113);
            this.txtTableColumnName.Name = "txtTableColumnName";
            this.txtTableColumnName.Size = new System.Drawing.Size(140, 20);
            this.txtTableColumnName.TabIndex = 3;
            // 
            // lbtablecolumn
            // 
            this.lbtablecolumn.AutoSize = true;
            this.lbtablecolumn.Location = new System.Drawing.Point(183, 96);
            this.lbtablecolumn.Name = "lbtablecolumn";
            this.lbtablecolumn.Size = new System.Drawing.Size(68, 13);
            this.lbtablecolumn.TabIndex = 2;
            this.lbtablecolumn.Text = "Table Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Command:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "PreMade:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Custom",
            "Replace file locations",
            "Retire or un-retire claims",
            "Move Forms to a different patient",
            "Unlock Forms"});
            this.comboBox1.Location = new System.Drawing.Point(115, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnlPremadeFileLoc
            // 
            this.pnlPremadeFileLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPremadeFileLoc.Controls.Add(this.button2);
            this.pnlPremadeFileLoc.Controls.Add(this.txtResultsFileLoc);
            this.pnlPremadeFileLoc.Controls.Add(this.txtNew);
            this.pnlPremadeFileLoc.Controls.Add(this.txtOld);
            this.pnlPremadeFileLoc.Controls.Add(this.label5);
            this.pnlPremadeFileLoc.Controls.Add(this.label4);
            this.pnlPremadeFileLoc.Location = new System.Drawing.Point(12, 53);
            this.pnlPremadeFileLoc.Name = "pnlPremadeFileLoc";
            this.pnlPremadeFileLoc.Size = new System.Drawing.Size(775, 159);
            this.pnlPremadeFileLoc.TabIndex = 21;
            this.pnlPremadeFileLoc.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Generate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtResultsFileLoc
            // 
            this.txtResultsFileLoc.Location = new System.Drawing.Point(7, 58);
            this.txtResultsFileLoc.Name = "txtResultsFileLoc";
            this.txtResultsFileLoc.Size = new System.Drawing.Size(763, 93);
            this.txtResultsFileLoc.TabIndex = 4;
            this.txtResultsFileLoc.Text = "";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(465, 12);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(231, 20);
            this.txtNew.TabIndex = 3;
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(113, 12);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(231, 20);
            this.txtOld.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Path to New location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Path to Old location:";
            // 
            // pnlClaimsRetire
            // 
            this.pnlClaimsRetire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlClaimsRetire.Controls.Add(this.button4);
            this.pnlClaimsRetire.Controls.Add(this.dtpClaimsTo);
            this.pnlClaimsRetire.Controls.Add(this.chkGreaterThan);
            this.pnlClaimsRetire.Controls.Add(this.chkRetire);
            this.pnlClaimsRetire.Controls.Add(this.button3);
            this.pnlClaimsRetire.Controls.Add(this.txtClaimsRetire);
            this.pnlClaimsRetire.Controls.Add(this.dtpClaims);
            this.pnlClaimsRetire.Location = new System.Drawing.Point(12, 53);
            this.pnlClaimsRetire.Name = "pnlClaimsRetire";
            this.pnlClaimsRetire.Size = new System.Drawing.Size(775, 134);
            this.pnlClaimsRetire.TabIndex = 24;
            this.pnlClaimsRetire.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(213, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Inbetween";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dtpClaimsTo
            // 
            this.dtpClaimsTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaimsTo.Location = new System.Drawing.Point(294, 4);
            this.dtpClaimsTo.Name = "dtpClaimsTo";
            this.dtpClaimsTo.Size = new System.Drawing.Size(200, 20);
            this.dtpClaimsTo.TabIndex = 6;
            this.dtpClaimsTo.Visible = false;
            // 
            // chkGreaterThan
            // 
            this.chkGreaterThan.AutoSize = true;
            this.chkGreaterThan.Location = new System.Drawing.Point(593, 7);
            this.chkGreaterThan.Name = "chkGreaterThan";
            this.chkGreaterThan.Size = new System.Drawing.Size(89, 17);
            this.chkGreaterThan.TabIndex = 5;
            this.chkGreaterThan.Text = "Greater Than";
            this.chkGreaterThan.UseVisualStyleBackColor = true;
            // 
            // chkRetire
            // 
            this.chkRetire.AutoSize = true;
            this.chkRetire.Checked = true;
            this.chkRetire.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRetire.Location = new System.Drawing.Point(533, 7);
            this.chkRetire.Name = "chkRetire";
            this.chkRetire.Size = new System.Drawing.Size(54, 17);
            this.chkRetire.TabIndex = 4;
            this.chkRetire.Text = "Retire";
            this.chkRetire.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(694, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Generate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtClaimsRetire
            // 
            this.txtClaimsRetire.Location = new System.Drawing.Point(7, 31);
            this.txtClaimsRetire.Name = "txtClaimsRetire";
            this.txtClaimsRetire.Size = new System.Drawing.Size(762, 98);
            this.txtClaimsRetire.TabIndex = 1;
            this.txtClaimsRetire.Text = "";
            // 
            // dtpClaims
            // 
            this.dtpClaims.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClaims.Location = new System.Drawing.Point(7, 4);
            this.dtpClaims.Name = "dtpClaims";
            this.dtpClaims.Size = new System.Drawing.Size(200, 20);
            this.dtpClaims.TabIndex = 0;
            // 
            // pnlAssignFormtoNewPatient
            // 
            this.pnlAssignFormtoNewPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAssignFormtoNewPatient.Controls.Add(this.label8);
            this.pnlAssignFormtoNewPatient.Controls.Add(this.button5);
            this.pnlAssignFormtoNewPatient.Controls.Add(this.label7);
            this.pnlAssignFormtoNewPatient.Controls.Add(this.label6);
            this.pnlAssignFormtoNewPatient.Controls.Add(this.txtFormIDMove);
            this.pnlAssignFormtoNewPatient.Controls.Add(this.txtPatientIDMove);
            this.pnlAssignFormtoNewPatient.Controls.Add(this.txtMoveformtonewpatient);
            this.pnlAssignFormtoNewPatient.Location = new System.Drawing.Point(13, 54);
            this.pnlAssignFormtoNewPatient.Name = "pnlAssignFormtoNewPatient";
            this.pnlAssignFormtoNewPatient.Size = new System.Drawing.Size(774, 152);
            this.pnlAssignFormtoNewPatient.TabIndex = 24;
            this.pnlAssignFormtoNewPatient.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "*When dealing with multiple form ID\'s, seperate the form ID\'s with a comma.";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(692, 115);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Generate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Form ID\'s to move to the Patient:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Patient ID to move the form\'s to:";
            // 
            // txtFormIDMove
            // 
            this.txtFormIDMove.Location = new System.Drawing.Point(420, 8);
            this.txtFormIDMove.Name = "txtFormIDMove";
            this.txtFormIDMove.Size = new System.Drawing.Size(347, 20);
            this.txtFormIDMove.TabIndex = 2;
            // 
            // txtPatientIDMove
            // 
            this.txtPatientIDMove.Location = new System.Drawing.Point(172, 8);
            this.txtPatientIDMove.Name = "txtPatientIDMove";
            this.txtPatientIDMove.Size = new System.Drawing.Size(75, 20);
            this.txtPatientIDMove.TabIndex = 1;
            // 
            // txtMoveformtonewpatient
            // 
            this.txtMoveformtonewpatient.Location = new System.Drawing.Point(2, 56);
            this.txtMoveformtonewpatient.Name = "txtMoveformtonewpatient";
            this.txtMoveformtonewpatient.Size = new System.Drawing.Size(685, 82);
            this.txtMoveformtonewpatient.TabIndex = 0;
            this.txtMoveformtonewpatient.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(564, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Always make a backup before running scripts!";
            // 
            // pnlUnlockForm
            // 
            this.pnlUnlockForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUnlockForm.Controls.Add(this.label10);
            this.pnlUnlockForm.Controls.Add(this.cbUseUnlock);
            this.pnlUnlockForm.Controls.Add(this.rbAfterDateUnlock);
            this.pnlUnlockForm.Controls.Add(this.rbBeforeDateUnlock);
            this.pnlUnlockForm.Controls.Add(this.rbFormIDUnlock);
            this.pnlUnlockForm.Controls.Add(this.txtFormUnlockID);
            this.pnlUnlockForm.Controls.Add(this.dtpUnlock);
            this.pnlUnlockForm.Controls.Add(this.btnGenerateUnlock);
            this.pnlUnlockForm.Controls.Add(this.txtResultUnlock);
            this.pnlUnlockForm.Location = new System.Drawing.Point(12, 53);
            this.pnlUnlockForm.Name = "pnlUnlockForm";
            this.pnlUnlockForm.Size = new System.Drawing.Size(775, 180);
            this.pnlUnlockForm.TabIndex = 26;
            this.pnlUnlockForm.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(145, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(361, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "*When dealing with multiple form ID\'s, seperate the form ID\'s with a comma.";
            // 
            // cbUseUnlock
            // 
            this.cbUseUnlock.FormattingEnabled = true;
            this.cbUseUnlock.Items.AddRange(new object[] {
            "DentalWriter",
            "DentalRegistration"});
            this.cbUseUnlock.Location = new System.Drawing.Point(4, 14);
            this.cbUseUnlock.Name = "cbUseUnlock";
            this.cbUseUnlock.Size = new System.Drawing.Size(109, 21);
            this.cbUseUnlock.TabIndex = 10;
            // 
            // rbAfterDateUnlock
            // 
            this.rbAfterDateUnlock.AutoSize = true;
            this.rbAfterDateUnlock.Location = new System.Drawing.Point(426, 16);
            this.rbAfterDateUnlock.Name = "rbAfterDateUnlock";
            this.rbAfterDateUnlock.Size = new System.Drawing.Size(73, 17);
            this.rbAfterDateUnlock.TabIndex = 9;
            this.rbAfterDateUnlock.Text = "After Date";
            this.rbAfterDateUnlock.UseVisualStyleBackColor = true;
            // 
            // rbBeforeDateUnlock
            // 
            this.rbBeforeDateUnlock.AutoSize = true;
            this.rbBeforeDateUnlock.Location = new System.Drawing.Point(505, 16);
            this.rbBeforeDateUnlock.Name = "rbBeforeDateUnlock";
            this.rbBeforeDateUnlock.Size = new System.Drawing.Size(82, 17);
            this.rbBeforeDateUnlock.TabIndex = 8;
            this.rbBeforeDateUnlock.Text = "Before Date";
            this.rbBeforeDateUnlock.UseVisualStyleBackColor = true;
            // 
            // rbFormIDUnlock
            // 
            this.rbFormIDUnlock.AutoSize = true;
            this.rbFormIDUnlock.Checked = true;
            this.rbFormIDUnlock.Location = new System.Drawing.Point(147, 16);
            this.rbFormIDUnlock.Name = "rbFormIDUnlock";
            this.rbFormIDUnlock.Size = new System.Drawing.Size(62, 17);
            this.rbFormIDUnlock.TabIndex = 7;
            this.rbFormIDUnlock.TabStop = true;
            this.rbFormIDUnlock.Text = "Form ID";
            this.rbFormIDUnlock.UseVisualStyleBackColor = true;
            // 
            // txtFormUnlockID
            // 
            this.txtFormUnlockID.Location = new System.Drawing.Point(215, 15);
            this.txtFormUnlockID.Name = "txtFormUnlockID";
            this.txtFormUnlockID.Size = new System.Drawing.Size(129, 20);
            this.txtFormUnlockID.TabIndex = 6;
            // 
            // dtpUnlock
            // 
            this.dtpUnlock.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUnlock.Location = new System.Drawing.Point(593, 14);
            this.dtpUnlock.Name = "dtpUnlock";
            this.dtpUnlock.Size = new System.Drawing.Size(96, 20);
            this.dtpUnlock.TabIndex = 5;
            // 
            // btnGenerateUnlock
            // 
            this.btnGenerateUnlock.Location = new System.Drawing.Point(693, 152);
            this.btnGenerateUnlock.Name = "btnGenerateUnlock";
            this.btnGenerateUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateUnlock.TabIndex = 1;
            this.btnGenerateUnlock.Text = "Generate";
            this.btnGenerateUnlock.UseVisualStyleBackColor = true;
            this.btnGenerateUnlock.Click += new System.EventHandler(this.btnGenerateUnlock_Click);
            // 
            // txtResultUnlock
            // 
            this.txtResultUnlock.Location = new System.Drawing.Point(3, 49);
            this.txtResultUnlock.Name = "txtResultUnlock";
            this.txtResultUnlock.Size = new System.Drawing.Size(685, 126);
            this.txtResultUnlock.TabIndex = 0;
            this.txtResultUnlock.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlAssignFormtoNewPatient);
            this.Controls.Add(this.pnlUnlockForm);
            this.Controls.Add(this.pnlCustomStrings);
            this.Controls.Add(this.pnlPremadeFileLoc);
            this.Controls.Add(this.pnlClaimsRetire);
            this.Name = "Form1";
            this.Text = "Script Generator";
            this.pnlCustomStrings.ResumeLayout(false);
            this.pnlCustomStrings.PerformLayout();
            this.pnlPremadeFileLoc.ResumeLayout(false);
            this.pnlPremadeFileLoc.PerformLayout();
            this.pnlClaimsRetire.ResumeLayout(false);
            this.pnlClaimsRetire.PerformLayout();
            this.pnlAssignFormtoNewPatient.ResumeLayout(false);
            this.pnlAssignFormtoNewPatient.PerformLayout();
            this.pnlUnlockForm.ResumeLayout(false);
            this.pnlUnlockForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCommand;
        private System.Windows.Forms.Panel pnlCustomStrings;
        private System.Windows.Forms.Label lbtablecolumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableColumnName;
        private System.Windows.Forms.TextBox txtColumnTable2;
        private System.Windows.Forms.Label lblColumnTable2;
        private System.Windows.Forms.TextBox txtColumnTableName3;
        private System.Windows.Forms.Label lblColumnTableName3;
        private System.Windows.Forms.ComboBox cbInfo3;
        private System.Windows.Forms.ComboBox cbInfo2;
        private System.Windows.Forms.ComboBox cbInfo1;
        private System.Windows.Forms.ComboBox cbInfo4;
        private System.Windows.Forms.TextBox txtColumnTableName4;
        private System.Windows.Forms.Label lblColumnTableName4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtResults;
        private System.Windows.Forms.TextBox txtTargetDatabase;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlPremadeFileLoc;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtResultsFileLoc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbUpdate1;
        private System.Windows.Forms.TextBox txtUpdate1;
        private System.Windows.Forms.Label lblUpdate1;
        private System.Windows.Forms.Panel pnlClaimsRetire;
        private System.Windows.Forms.RichTextBox txtClaimsRetire;
        private System.Windows.Forms.DateTimePicker dtpClaims;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkGreaterThan;
        private System.Windows.Forms.CheckBox chkRetire;
        private System.Windows.Forms.DateTimePicker dtpClaimsTo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel pnlAssignFormtoNewPatient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFormIDMove;
        private System.Windows.Forms.TextBox txtPatientIDMove;
        private System.Windows.Forms.RichTextBox txtMoveformtonewpatient;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlUnlockForm;
        private System.Windows.Forms.Button btnGenerateUnlock;
        private System.Windows.Forms.RichTextBox txtResultUnlock;
        private System.Windows.Forms.RadioButton rbAfterDateUnlock;
        private System.Windows.Forms.RadioButton rbBeforeDateUnlock;
        private System.Windows.Forms.RadioButton rbFormIDUnlock;
        private System.Windows.Forms.TextBox txtFormUnlockID;
        private System.Windows.Forms.DateTimePicker dtpUnlock;
        private System.Windows.Forms.ComboBox cbUseUnlock;
        private System.Windows.Forms.Label label10;
    }
}

