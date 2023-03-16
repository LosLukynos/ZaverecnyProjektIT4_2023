namespace ZaverecnyProjektIT4_Machacek
{
    partial class FormAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewUser));
            this.lblAdminPersonalNumber = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnBackToMainPage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAddNewUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnManageUsers = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWorkedHours = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNewContract = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstNameNewUser = new System.Windows.Forms.TextBox();
            this.txtLastNameNewUser = new System.Windows.Forms.TextBox();
            this.txtPasswordNewUser = new System.Windows.Forms.TextBox();
            this.txtEmailNewUser = new System.Windows.Forms.TextBox();
            this.txtPhoneNumberNewUser = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDateNewUser = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxRoleNewUser = new System.Windows.Forms.ComboBox();
            this.bntExitProgramNewUser = new System.Windows.Forms.Button();
            this.btnAddNewUserConfirm = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdminPersonalNumber
            // 
            this.lblAdminPersonalNumber.AutoSize = true;
            this.lblAdminPersonalNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdminPersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdminPersonalNumber.Location = new System.Drawing.Point(656, 5);
            this.lblAdminPersonalNumber.Name = "lblAdminPersonalNumber";
            this.lblAdminPersonalNumber.Size = new System.Drawing.Size(41, 13);
            this.lblAdminPersonalNumber.TabIndex = 5;
            this.lblAdminPersonalNumber.Text = "label1";
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnBackToMainPage
            // 
            this.tsBtnBackToMainPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnBackToMainPage.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnBackToMainPage.Image")));
            this.tsBtnBackToMainPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnBackToMainPage.Name = "tsBtnBackToMainPage";
            this.tsBtnBackToMainPage.Size = new System.Drawing.Size(24, 24);
            this.tsBtnBackToMainPage.Text = "Zpět";
            this.tsBtnBackToMainPage.Click += new System.EventHandler(this.tsBtnBackToMainPage_Click);
            // 
            // tsBtnAddNewUser
            // 
            this.tsBtnAddNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAddNewUser.Enabled = false;
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
            this.tsBtnRemoveUser.Click += new System.EventHandler(this.tsBtnRemoveUser_Click);
            // 
            // tsBtnManageUsers
            // 
            this.tsBtnManageUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnManageUsers.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnManageUsers.Image")));
            this.tsBtnManageUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnManageUsers.Name = "tsBtnManageUsers";
            this.tsBtnManageUsers.Size = new System.Drawing.Size(24, 24);
            this.tsBtnManageUsers.Text = "Spravovat uživatele";
            this.tsBtnManageUsers.Click += new System.EventHandler(this.tsBtnManageUsers_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(512, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Přihlášen pod osobním číslem: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(455, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Admin ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jméno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Přijmení";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Heslo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rok narození";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Telefonní číslo";
            // 
            // txtFirstNameNewUser
            // 
            this.txtFirstNameNewUser.Location = new System.Drawing.Point(201, 114);
            this.txtFirstNameNewUser.Name = "txtFirstNameNewUser";
            this.txtFirstNameNewUser.Size = new System.Drawing.Size(239, 20);
            this.txtFirstNameNewUser.TabIndex = 14;
            // 
            // txtLastNameNewUser
            // 
            this.txtLastNameNewUser.Location = new System.Drawing.Point(201, 164);
            this.txtLastNameNewUser.Name = "txtLastNameNewUser";
            this.txtLastNameNewUser.Size = new System.Drawing.Size(239, 20);
            this.txtLastNameNewUser.TabIndex = 15;
            // 
            // txtPasswordNewUser
            // 
            this.txtPasswordNewUser.Location = new System.Drawing.Point(201, 214);
            this.txtPasswordNewUser.Name = "txtPasswordNewUser";
            this.txtPasswordNewUser.Size = new System.Drawing.Size(239, 20);
            this.txtPasswordNewUser.TabIndex = 16;
            // 
            // txtEmailNewUser
            // 
            this.txtEmailNewUser.Location = new System.Drawing.Point(201, 314);
            this.txtEmailNewUser.Name = "txtEmailNewUser";
            this.txtEmailNewUser.Size = new System.Drawing.Size(239, 20);
            this.txtEmailNewUser.TabIndex = 18;
            // 
            // txtPhoneNumberNewUser
            // 
            this.txtPhoneNumberNewUser.Location = new System.Drawing.Point(201, 364);
            this.txtPhoneNumberNewUser.Name = "txtPhoneNumberNewUser";
            this.txtPhoneNumberNewUser.Size = new System.Drawing.Size(239, 20);
            this.txtPhoneNumberNewUser.TabIndex = 19;
            // 
            // dateTimePickerBirthDateNewUser
            // 
            this.dateTimePickerBirthDateNewUser.Location = new System.Drawing.Point(201, 264);
            this.dateTimePickerBirthDateNewUser.Name = "dateTimePickerBirthDateNewUser";
            this.dateTimePickerBirthDateNewUser.Size = new System.Drawing.Size(239, 20);
            this.dateTimePickerBirthDateNewUser.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(63, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Role";
            // 
            // comboBoxRoleNewUser
            // 
            this.comboBoxRoleNewUser.FormattingEnabled = true;
            this.comboBoxRoleNewUser.Location = new System.Drawing.Point(107, 57);
            this.comboBoxRoleNewUser.Name = "comboBoxRoleNewUser";
            this.comboBoxRoleNewUser.Size = new System.Drawing.Size(122, 21);
            this.comboBoxRoleNewUser.TabIndex = 22;
            this.comboBoxRoleNewUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoleNewUser_SelectedIndexChanged);
            // 
            // bntExitProgramNewUser
            // 
            this.bntExitProgramNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bntExitProgramNewUser.Location = new System.Drawing.Point(9, 409);
            this.bntExitProgramNewUser.Name = "bntExitProgramNewUser";
            this.bntExitProgramNewUser.Size = new System.Drawing.Size(122, 29);
            this.bntExitProgramNewUser.TabIndex = 23;
            this.bntExitProgramNewUser.Text = "Ukončit program";
            this.bntExitProgramNewUser.UseVisualStyleBackColor = true;
            this.bntExitProgramNewUser.Click += new System.EventHandler(this.bntExitProgramNewUser_Click);
            // 
            // btnAddNewUserConfirm
            // 
            this.btnAddNewUserConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewUserConfirm.Location = new System.Drawing.Point(666, 409);
            this.btnAddNewUserConfirm.Name = "btnAddNewUserConfirm";
            this.btnAddNewUserConfirm.Size = new System.Drawing.Size(122, 29);
            this.btnAddNewUserConfirm.TabIndex = 24;
            this.btnAddNewUserConfirm.Text = "Přidat";
            this.btnAddNewUserConfirm.UseVisualStyleBackColor = true;
            this.btnAddNewUserConfirm.Click += new System.EventHandler(this.btnAddNewUserConfirm_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(249, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(495, 36);
            this.label10.TabIndex = 25;
            this.label10.Text = "Pokud zvolíte nepřiřazenou roli, uživatel s nepřiřazenou\r\nrolí se nebude moci při" +
    "hlásit, dokud mu nebude jedna z dvou rolí přidělena.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(455, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 30);
            this.label11.TabIndex = 26;
            this.label11.Text = "Heslo pro prvotní přihlášení je rok narození nového uživatele.\r\nNapříklad 3. břez" +
    "na 1980 -> 03031980";
            // 
            // FormAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnAddNewUserConfirm);
            this.Controls.Add(this.bntExitProgramNewUser);
            this.Controls.Add(this.comboBoxRoleNewUser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerBirthDateNewUser);
            this.Controls.Add(this.txtPhoneNumberNewUser);
            this.Controls.Add(this.txtEmailNewUser);
            this.Controls.Add(this.txtPasswordNewUser);
            this.Controls.Add(this.txtLastNameNewUser);
            this.Controls.Add(this.txtFirstNameNewUser);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdminPersonalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin panel |Přidání nového uživatele";
            this.Load += new System.EventHandler(this.FormAddNewUser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminPersonalNumber;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBtnAddNewUser;
        private System.Windows.Forms.ToolStripButton tsBtnRemoveUser;
        private System.Windows.Forms.ToolStripButton tsBtnManageUsers;
        private System.Windows.Forms.ToolStripButton tsBtnWorkedHours;
        private System.Windows.Forms.ToolStripButton tsBtnNewContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstNameNewUser;
        private System.Windows.Forms.TextBox txtLastNameNewUser;
        private System.Windows.Forms.TextBox txtPasswordNewUser;
        private System.Windows.Forms.TextBox txtEmailNewUser;
        private System.Windows.Forms.TextBox txtPhoneNumberNewUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDateNewUser;
        private System.Windows.Forms.ToolStripButton tsBtnBackToMainPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxRoleNewUser;
        private System.Windows.Forms.Button bntExitProgramNewUser;
        private System.Windows.Forms.Button btnAddNewUserConfirm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}