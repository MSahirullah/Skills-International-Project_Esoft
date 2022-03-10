
namespace skills_international_project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.linklabelLogout = new System.Windows.Forms.LinkLabel();
            this.labelHeading = new System.Windows.Forms.Label();
            this.grpBoxStuReg = new System.Windows.Forms.GroupBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.grpBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.labelParentName = new System.Windows.Forms.Label();
            this.labelContactNumber = new System.Windows.Forms.Label();
            this.labelNIC = new System.Windows.Forms.Label();
            this.grpBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.cmbBoxRegNo = new System.Windows.Forms.ComboBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.grpBoxBasicDetails = new System.Windows.Forms.GroupBox();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.dateTimeDOB = new System.Windows.Forms.DateTimePicker();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.labelLName = new System.Windows.Forms.Label();
            this.labelFName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.linkLabelExit = new System.Windows.Forms.LinkLabel();
            this.grpBoxStuReg.SuspendLayout();
            this.grpBoxParentDetails.SuspendLayout();
            this.grpBoxContactDetails.SuspendLayout();
            this.grpBoxBasicDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklabelLogout
            // 
            this.linklabelLogout.AutoSize = true;
            this.linklabelLogout.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklabelLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklabelLogout.Location = new System.Drawing.Point(12, 9);
            this.linklabelLogout.Name = "linklabelLogout";
            this.linklabelLogout.Size = new System.Drawing.Size(55, 18);
            this.linklabelLogout.TabIndex = 17;
            this.linklabelLogout.TabStop = true;
            this.linklabelLogout.Text = "Logout";
            this.linklabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabelLogout_LinkClicked);
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelHeading.Location = new System.Drawing.Point(189, 15);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(303, 39);
            this.labelHeading.TabIndex = 3;
            this.labelHeading.Text = "Skills International";
            // 
            // grpBoxStuReg
            // 
            this.grpBoxStuReg.Controls.Add(this.BtnUpdate);
            this.grpBoxStuReg.Controls.Add(this.BtnDelete);
            this.grpBoxStuReg.Controls.Add(this.BtnRegister);
            this.grpBoxStuReg.Controls.Add(this.BtnClear);
            this.grpBoxStuReg.Controls.Add(this.grpBoxParentDetails);
            this.grpBoxStuReg.Controls.Add(this.grpBoxContactDetails);
            this.grpBoxStuReg.Controls.Add(this.cmbBoxRegNo);
            this.grpBoxStuReg.Controls.Add(this.labelRegNo);
            this.grpBoxStuReg.Controls.Add(this.grpBoxBasicDetails);
            this.grpBoxStuReg.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxStuReg.Location = new System.Drawing.Point(15, 61);
            this.grpBoxStuReg.Name = "grpBoxStuReg";
            this.grpBoxStuReg.Size = new System.Drawing.Size(655, 702);
            this.grpBoxStuReg.TabIndex = 0;
            this.grpBoxStuReg.TabStop = false;
            this.grpBoxStuReg.Text = "Student Registration";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(131, 653);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(83, 30);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(543, 653);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(83, 30);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.White;
            this.BtnRegister.Location = new System.Drawing.Point(30, 653);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(83, 30);
            this.BtnRegister.TabIndex = 13;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.Gray;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(442, 653);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(83, 30);
            this.BtnClear.TabIndex = 16;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // grpBoxParentDetails
            // 
            this.grpBoxParentDetails.Controls.Add(this.txtContactNumber);
            this.grpBoxParentDetails.Controls.Add(this.txtNIC);
            this.grpBoxParentDetails.Controls.Add(this.txtParentName);
            this.grpBoxParentDetails.Controls.Add(this.labelParentName);
            this.grpBoxParentDetails.Controls.Add(this.labelContactNumber);
            this.grpBoxParentDetails.Controls.Add(this.labelNIC);
            this.grpBoxParentDetails.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxParentDetails.Location = new System.Drawing.Point(30, 478);
            this.grpBoxParentDetails.Name = "grpBoxParentDetails";
            this.grpBoxParentDetails.Size = new System.Drawing.Size(596, 162);
            this.grpBoxParentDetails.TabIndex = 14;
            this.grpBoxParentDetails.TabStop = false;
            this.grpBoxParentDetails.Text = "Parent Details";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(171, 112);
            this.txtContactNumber.MaxLength = 10;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(231, 26);
            this.txtContactNumber.TabIndex = 12;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(171, 72);
            this.txtNIC.MaxLength = 12;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(231, 26);
            this.txtNIC.TabIndex = 11;
            this.txtNIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNIC_KeyPress);
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(171, 33);
            this.txtParentName.MaxLength = 45;
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(401, 26);
            this.txtParentName.TabIndex = 10;
            this.txtParentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Location = new System.Drawing.Point(42, 36);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(95, 18);
            this.labelParentName.TabIndex = 5;
            this.labelParentName.Text = "Parent Name";
            // 
            // labelContactNumber
            // 
            this.labelContactNumber.AutoSize = true;
            this.labelContactNumber.Location = new System.Drawing.Point(42, 115);
            this.labelContactNumber.Name = "labelContactNumber";
            this.labelContactNumber.Size = new System.Drawing.Size(118, 18);
            this.labelContactNumber.TabIndex = 8;
            this.labelContactNumber.Text = "Contact Number";
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(42, 75);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(33, 18);
            this.labelNIC.TabIndex = 7;
            this.labelNIC.Text = "NIC";
            // 
            // grpBoxContactDetails
            // 
            this.grpBoxContactDetails.Controls.Add(this.txtHomePhone);
            this.grpBoxContactDetails.Controls.Add(this.txtMobilePhone);
            this.grpBoxContactDetails.Controls.Add(this.txtEmail);
            this.grpBoxContactDetails.Controls.Add(this.txtAddress);
            this.grpBoxContactDetails.Controls.Add(this.labelAddress);
            this.grpBoxContactDetails.Controls.Add(this.labelHomePhone);
            this.grpBoxContactDetails.Controls.Add(this.labelMobilePhone);
            this.grpBoxContactDetails.Controls.Add(this.labelEmail);
            this.grpBoxContactDetails.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxContactDetails.Location = new System.Drawing.Point(30, 275);
            this.grpBoxContactDetails.Name = "grpBoxContactDetails";
            this.grpBoxContactDetails.Size = new System.Drawing.Size(596, 195);
            this.grpBoxContactDetails.TabIndex = 11;
            this.grpBoxContactDetails.TabStop = false;
            this.grpBoxContactDetails.Text = "Contact Details";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(448, 146);
            this.txtHomePhone.MaxLength = 10;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(125, 26);
            this.txtHomePhone.TabIndex = 9;
            this.txtHomePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(171, 146);
            this.txtMobilePhone.MaxLength = 10;
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(125, 26);
            this.txtMobilePhone.TabIndex = 8;
            this.txtMobilePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtContact_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 106);
            this.txtEmail.MaxLength = 45;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(401, 26);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(171, 32);
            this.txtAddress.MaxLength = 45;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(401, 60);
            this.txtAddress.TabIndex = 6;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(42, 35);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(63, 18);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address";
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(328, 148);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(95, 18);
            this.labelHomePhone.TabIndex = 8;
            this.labelHomePhone.Text = "Home Phone";
            this.labelHomePhone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(42, 149);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(100, 18);
            this.labelMobilePhone.TabIndex = 8;
            this.labelMobilePhone.Text = "Mobile Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(42, 109);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 18);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // cmbBoxRegNo
            // 
            this.cmbBoxRegNo.FormattingEnabled = true;
            this.cmbBoxRegNo.Location = new System.Drawing.Point(201, 34);
            this.cmbBoxRegNo.MaxLength = 6;
            this.cmbBoxRegNo.Name = "cmbBoxRegNo";
            this.cmbBoxRegNo.Size = new System.Drawing.Size(231, 26);
            this.cmbBoxRegNo.TabIndex = 0;
            this.cmbBoxRegNo.SelectedValueChanged += new System.EventHandler(this.CmbBoxRegNo_SelectedValueChanged);
            this.cmbBoxRegNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtID_KeyPress);
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Location = new System.Drawing.Point(72, 37);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(57, 18);
            this.labelRegNo.TabIndex = 3;
            this.labelRegNo.Text = "Reg No";
            // 
            // grpBoxBasicDetails
            // 
            this.grpBoxBasicDetails.Controls.Add(this.radioButtonFemale);
            this.grpBoxBasicDetails.Controls.Add(this.radioButtonMale);
            this.grpBoxBasicDetails.Controls.Add(this.dateTimeDOB);
            this.grpBoxBasicDetails.Controls.Add(this.txtFName);
            this.grpBoxBasicDetails.Controls.Add(this.txtLName);
            this.grpBoxBasicDetails.Controls.Add(this.labelLName);
            this.grpBoxBasicDetails.Controls.Add(this.labelFName);
            this.grpBoxBasicDetails.Controls.Add(this.labelGender);
            this.grpBoxBasicDetails.Controls.Add(this.labelDOB);
            this.grpBoxBasicDetails.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxBasicDetails.Location = new System.Drawing.Point(30, 73);
            this.grpBoxBasicDetails.Name = "grpBoxBasicDetails";
            this.grpBoxBasicDetails.Size = new System.Drawing.Size(596, 194);
            this.grpBoxBasicDetails.TabIndex = 2;
            this.grpBoxBasicDetails.TabStop = false;
            this.grpBoxBasicDetails.Text = "Basic Details";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.Location = new System.Drawing.Point(315, 156);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(87, 22);
            this.radioButtonFemale.TabIndex = 5;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(171, 154);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(62, 22);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimeDOB
            // 
            this.dateTimeDOB.Location = new System.Drawing.Point(171, 109);
            this.dateTimeDOB.Name = "dateTimeDOB";
            this.dateTimeDOB.Size = new System.Drawing.Size(231, 26);
            this.dateTimeDOB.TabIndex = 3;
            this.dateTimeDOB.Value = new System.DateTime(2000, 12, 31, 0, 0, 0, 0);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(171, 31);
            this.txtFName.MaxLength = 45;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(401, 26);
            this.txtFName.TabIndex = 1;
            this.txtFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(171, 71);
            this.txtLName.MaxLength = 45;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(401, 26);
            this.txtLName.TabIndex = 2;
            this.txtLName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // labelLName
            // 
            this.labelLName.AutoSize = true;
            this.labelLName.Location = new System.Drawing.Point(42, 74);
            this.labelLName.Name = "labelLName";
            this.labelLName.Size = new System.Drawing.Size(81, 18);
            this.labelLName.TabIndex = 6;
            this.labelLName.Text = "Last Name";
            // 
            // labelFName
            // 
            this.labelFName.AutoSize = true;
            this.labelFName.Location = new System.Drawing.Point(42, 34);
            this.labelFName.Name = "labelFName";
            this.labelFName.Size = new System.Drawing.Size(82, 18);
            this.labelFName.TabIndex = 5;
            this.labelFName.Text = "First Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(42, 156);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(55, 18);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Gender";
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(42, 115);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(92, 18);
            this.labelDOB.TabIndex = 7;
            this.labelDOB.Text = "Date of Birth";
            // 
            // linkLabelExit
            // 
            this.linkLabelExit.AutoSize = true;
            this.linkLabelExit.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelExit.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabelExit.Location = new System.Drawing.Point(637, 780);
            this.linkLabelExit.Name = "linkLabelExit";
            this.linkLabelExit.Size = new System.Drawing.Size(33, 18);
            this.linkLabelExit.TabIndex = 18;
            this.linkLabelExit.TabStop = true;
            this.linkLabelExit.Text = "Exit";
            this.linkLabelExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelExit_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 813);
            this.Controls.Add(this.linkLabelExit);
            this.Controls.Add(this.grpBoxStuReg);
            this.Controls.Add(this.labelHeading);
            this.Controls.Add(this.linklabelLogout);
            this.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration - Skills International";
            this.Load += new System.EventHandler(this.Register_Load);
            this.grpBoxStuReg.ResumeLayout(false);
            this.grpBoxStuReg.PerformLayout();
            this.grpBoxParentDetails.ResumeLayout(false);
            this.grpBoxParentDetails.PerformLayout();
            this.grpBoxContactDetails.ResumeLayout(false);
            this.grpBoxContactDetails.PerformLayout();
            this.grpBoxBasicDetails.ResumeLayout(false);
            this.grpBoxBasicDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklabelLogout;
        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.GroupBox grpBoxStuReg;
        private System.Windows.Forms.GroupBox grpBoxBasicDetails;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.ComboBox cmbBoxRegNo;
        private System.Windows.Forms.Label labelFName;
        private System.Windows.Forms.Label labelLName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.DateTimePicker dateTimeDOB;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.GroupBox grpBoxContactDetails;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox grpBoxParentDetails;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.Label labelContactNumber;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.LinkLabel linkLabelExit;
    }
}