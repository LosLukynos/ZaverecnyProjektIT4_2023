
namespace ZaverecnyProjektIT4_Machacek
{
    partial class FormAdminPanelEditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminPanelEditUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnBackToMainPage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAddNewUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnManageUsers = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWorkedHours = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNewContract = new System.Windows.Forms.ToolStripButton();
            this.lvFormEditUser = new System.Windows.Forms.ListView();
            this.colPersonalNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBirthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bntExitProgramRemoveUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAdminPersonalNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblEditUserPersonalNumber = new System.Windows.Forms.Label();
            this.comboBoxUserRoleEdit = new System.Windows.Forms.ComboBox();
            this.txtFirstNameEdit = new System.Windows.Forms.TextBox();
            this.txtLastNameEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDateEdit = new System.Windows.Forms.DateTimePicker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnBackToMainPage,
            this.tsBtnAddNewUser,
            this.tsBtnRemoveUser,
            this.tsBtnManageUsers,
            this.tsBtnWorkedHours,
            this.tsBtnNewContract});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(1303, 27);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnBackToMainPage
            // 
            this.tsBtnBackToMainPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBackToMainPage.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBackToMainPage.Image")));
            this.tsBtnBackToMainPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackToMainPage.Name = "tsBtnBackToMainPage";
            this.tsBtnBackToMainPage.Size = new System.Drawing.Size(24, 24);
            this.tsBtnBackToMainPage.Text = "toolStripButton1";
            // 
            // tsBtnAddNewUser
            // 
            this.tsBtnAddNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAddNewUser.Image")));
            this.tsBtnAddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddNewUser.Name = "tsBtnAddNewUser";
            this.tsBtnAddNewUser.Size = new System.Drawing.Size(24, 24);
            this.tsBtnAddNewUser.Text = "Přidat uživatele";
            // 
            // tsBtnRemoveUser
            // 
            this.tsBtnRemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRemoveUser.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRemoveUser.Image")));
            this.tsBtnRemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRemoveUser.Name = "tsBtnRemoveUser";
            this.tsBtnRemoveUser.Size = new System.Drawing.Size(24, 24);
            this.tsBtnRemoveUser.Text = "Odebrat uživatele";
            // 
            // tsBtnManageUsers
            // 
            this.tsBtnManageUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnManageUsers.Enabled = false;
            this.tsBtnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnManageUsers.Image")));
            this.tsBtnManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnManageUsers.Name = "tsBtnManageUsers";
            this.tsBtnManageUsers.Size = new System.Drawing.Size(24, 24);
            this.tsBtnManageUsers.Text = "Spravovat uživatele";
            // 
            // tsBtnWorkedHours
            // 
            this.tsBtnWorkedHours.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnWorkedHours.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnWorkedHours.Image")));
            this.tsBtnWorkedHours.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnWorkedHours.Name = "tsBtnWorkedHours";
            this.tsBtnWorkedHours.Size = new System.Drawing.Size(24, 24);
            this.tsBtnWorkedHours.Text = "Odpracované hodiny uživatelů";
            // 
            // tsBtnNewContract
            // 
            this.tsBtnNewContract.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnNewContract.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnNewContract.Image")));
            this.tsBtnNewContract.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnNewContract.Name = "tsBtnNewContract";
            this.tsBtnNewContract.Size = new System.Drawing.Size(24, 24);
            this.tsBtnNewContract.Text = "Vytvořit novou zakázku";
            // 
            // lvFormEditUser
            // 
            this.lvFormEditUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPersonalNumber,
            this.colRole,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone,
            this.colBirthDate});
            this.lvFormEditUser.GridLines = true;
            this.lvFormEditUser.HideSelection = false;
            this.lvFormEditUser.Location = new System.Drawing.Point(0, 29);
            this.lvFormEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.lvFormEditUser.Name = "lvFormEditUser";
            this.lvFormEditUser.Size = new System.Drawing.Size(918, 379);
            this.lvFormEditUser.TabIndex = 30;
            this.lvFormEditUser.UseCompatibleStateImageBehavior = false;
            this.lvFormEditUser.View = System.Windows.Forms.View.Details;
            this.lvFormEditUser.SelectedIndexChanged += new System.EventHandler(this.lvFormEditUser_SelectedIndexChanged);
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.Text = "Osobní číslo";
            this.colPersonalNumber.Width = 100;
            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 108;
            // 
            // colFirstName
            // 
            this.colFirstName.Text = "Jméno";
            this.colFirstName.Width = 135;
            // 
            // colLastName
            // 
            this.colLastName.Text = "Přijmení";
            this.colLastName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.Text = "E-mail";
            this.colEmail.Width = 150;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Telefonní číslo";
            this.colPhone.Width = 150;
            // 
            // colBirthDate
            // 
            this.colBirthDate.Text = "Datum narození";
            this.colBirthDate.Width = 120;
            // 
            // bntExitProgramRemoveUser
            // 
            this.bntExitProgramRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bntExitProgramRemoveUser.Location = new System.Drawing.Point(10, 414);
            this.bntExitProgramRemoveUser.Name = "bntExitProgramRemoveUser";
            this.bntExitProgramRemoveUser.Size = new System.Drawing.Size(122, 29);
            this.bntExitProgramRemoveUser.TabIndex = 31;
            this.bntExitProgramRemoveUser.Text = "Ukončit program";
            this.bntExitProgramRemoveUser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1169, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "Potvrdit změny";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblAdminPersonalNumber
            // 
            this.lblAdminPersonalNumber.AutoSize = true;
            this.lblAdminPersonalNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdminPersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdminPersonalNumber.Location = new System.Drawing.Point(1138, 5);
            this.lblAdminPersonalNumber.Name = "lblAdminPersonalNumber";
            this.lblAdminPersonalNumber.Size = new System.Drawing.Size(41, 13);
            this.lblAdminPersonalNumber.TabIndex = 33;
            this.lblAdminPersonalNumber.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(937, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Admin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(994, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Přihlášen pod osobním číslem: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(947, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Jméno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(947, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Přijmení";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(947, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(947, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Telefonní číslo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(947, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Datum narození";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(923, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 18);
            this.label9.TabIndex = 41;
            this.label9.Text = "Editace uživatele s osbním číslem";
            // 
            // lblEditUserPersonalNumber
            // 
            this.lblEditUserPersonalNumber.AutoSize = true;
            this.lblEditUserPersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEditUserPersonalNumber.Location = new System.Drawing.Point(1159, 52);
            this.lblEditUserPersonalNumber.Name = "lblEditUserPersonalNumber";
            this.lblEditUserPersonalNumber.Size = new System.Drawing.Size(61, 18);
            this.lblEditUserPersonalNumber.TabIndex = 42;
            this.lblEditUserPersonalNumber.Text = "label10";
            // 
            // comboBoxUserRoleEdit
            // 
            this.comboBoxUserRoleEdit.FormattingEnabled = true;
            this.comboBoxUserRoleEdit.Location = new System.Drawing.Point(1037, 92);
            this.comboBoxUserRoleEdit.Name = "comboBoxUserRoleEdit";
            this.comboBoxUserRoleEdit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUserRoleEdit.TabIndex = 43;
            // 
            // txtFirstNameEdit
            // 
            this.txtFirstNameEdit.Location = new System.Drawing.Point(1037, 142);
            this.txtFirstNameEdit.Name = "txtFirstNameEdit";
            this.txtFirstNameEdit.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameEdit.TabIndex = 44;
            // 
            // txtLastNameEdit
            // 
            this.txtLastNameEdit.Location = new System.Drawing.Point(1037, 192);
            this.txtLastNameEdit.Name = "txtLastNameEdit";
            this.txtLastNameEdit.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameEdit.TabIndex = 45;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Location = new System.Drawing.Point(1037, 242);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(200, 20);
            this.txtEmailEdit.TabIndex = 46;
            // 
            // txtPhoneNumberEdit
            // 
            this.txtPhoneNumberEdit.Location = new System.Drawing.Point(1037, 292);
            this.txtPhoneNumberEdit.Name = "txtPhoneNumberEdit";
            this.txtPhoneNumberEdit.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneNumberEdit.TabIndex = 47;
            // 
            // dateTimePickerBirthDateEdit
            // 
            this.dateTimePickerBirthDateEdit.Location = new System.Drawing.Point(1037, 342);
            this.dateTimePickerBirthDateEdit.Name = "dateTimePickerBirthDateEdit";
            this.dateTimePickerBirthDateEdit.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBirthDateEdit.TabIndex = 48;
            // 
            // FormAdminPanelEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 453);
            this.Controls.Add(this.dateTimePickerBirthDateEdit);
            this.Controls.Add(this.txtPhoneNumberEdit);
            this.Controls.Add(this.txtEmailEdit);
            this.Controls.Add(this.txtLastNameEdit);
            this.Controls.Add(this.txtFirstNameEdit);
            this.Controls.Add(this.comboBoxUserRoleEdit);
            this.Controls.Add(this.lblEditUserPersonalNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdminPersonalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntExitProgramRemoveUser);
            this.Controls.Add(this.lvFormEditUser);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAdminPanelEditUser";
            this.Text = "Admin panel |Editace uživatelů";
            this.Load += new System.EventHandler(this.FormAdminPanelEditUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnBackToMainPage;
        private System.Windows.Forms.ToolStripButton tsBtnAddNewUser;
        private System.Windows.Forms.ToolStripButton tsBtnRemoveUser;
        private System.Windows.Forms.ToolStripButton tsBtnManageUsers;
        private System.Windows.Forms.ToolStripButton tsBtnWorkedHours;
        private System.Windows.Forms.ToolStripButton tsBtnNewContract;
        private System.Windows.Forms.ListView lvFormEditUser;
        private System.Windows.Forms.ColumnHeader colPersonalNumber;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colRole;
        private System.Windows.Forms.Button bntExitProgramRemoveUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader colBirthDate;
        private System.Windows.Forms.Label lblAdminPersonalNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblEditUserPersonalNumber;
        private System.Windows.Forms.ComboBox comboBoxUserRoleEdit;
        private System.Windows.Forms.TextBox txtFirstNameEdit;
        private System.Windows.Forms.TextBox txtLastNameEdit;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txtPhoneNumberEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDateEdit;
    }
}