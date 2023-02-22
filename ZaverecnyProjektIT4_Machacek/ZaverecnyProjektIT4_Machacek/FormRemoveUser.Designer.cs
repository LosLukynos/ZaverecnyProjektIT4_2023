
namespace ZaverecnyProjektIT4_Machacek
{
    partial class FormRemoveUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemoveUser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnBackToMainPage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnAddNewUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.tsBtnManageUsers = new System.Windows.Forms.ToolStripButton();
            this.tsBtnWorkedHours = new System.Windows.Forms.ToolStripButton();
            this.tsBtnNewContract = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdminPersonalNumber = new System.Windows.Forms.Label();
            this.bntExitProgramRemoveUser = new System.Windows.Forms.Button();
            this.lvFormRemoveUser = new System.Windows.Forms.ListView();
            this.colPersonalNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 5;
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
            this.tsBtnBackToMainPage.Click += new System.EventHandler(this.tsBtnBackToMainPage_Click);
            // 
            // tsBtnAddNewUser
            // 
            this.tsBtnAddNewUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnAddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnAddNewUser.Image")));
            this.tsBtnAddNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnAddNewUser.Name = "tsBtnAddNewUser";
            this.tsBtnAddNewUser.Size = new System.Drawing.Size(24, 24);
            this.tsBtnAddNewUser.Text = "Přidat uživatele";
            this.tsBtnAddNewUser.Click += new System.EventHandler(this.tsBtnAddNewUser_Click);
            // 
            // tsBtnRemoveUser
            // 
            this.tsBtnRemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnRemoveUser.Enabled = false;
            this.tsBtnRemoveUser.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRemoveUser.Image")));
            this.tsBtnRemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRemoveUser.Name = "tsBtnRemoveUser";
            this.tsBtnRemoveUser.Size = new System.Drawing.Size(24, 24);
            this.tsBtnRemoveUser.Text = "Odebrat uživatele";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(455, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(512, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Přihlášen pod osobním číslem: ";
            // 
            // lblAdminPersonalNumber
            // 
            this.lblAdminPersonalNumber.AutoSize = true;
            this.lblAdminPersonalNumber.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAdminPersonalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdminPersonalNumber.Location = new System.Drawing.Point(656, 5);
            this.lblAdminPersonalNumber.Name = "lblAdminPersonalNumber";
            this.lblAdminPersonalNumber.Size = new System.Drawing.Size(41, 13);
            this.lblAdminPersonalNumber.TabIndex = 10;
            this.lblAdminPersonalNumber.Text = "label1";
            // 
            // bntExitProgramRemoveUser
            // 
            this.bntExitProgramRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bntExitProgramRemoveUser.Location = new System.Drawing.Point(10, 410);
            this.bntExitProgramRemoveUser.Name = "bntExitProgramRemoveUser";
            this.bntExitProgramRemoveUser.Size = new System.Drawing.Size(122, 29);
            this.bntExitProgramRemoveUser.TabIndex = 27;
            this.bntExitProgramRemoveUser.Text = "Ukončit program";
            this.bntExitProgramRemoveUser.UseVisualStyleBackColor = true;
            // 
            // lvFormRemoveUser
            // 
            this.lvFormRemoveUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPersonalNumber,
            this.colFirstName,
            this.colLastName,
            this.colEmail,
            this.colPhone,
            this.colRole});
            this.lvFormRemoveUser.GridLines = true;
            this.lvFormRemoveUser.HideSelection = false;
            this.lvFormRemoveUser.Location = new System.Drawing.Point(0, 24);
            this.lvFormRemoveUser.Margin = new System.Windows.Forms.Padding(2);
            this.lvFormRemoveUser.Name = "lvFormRemoveUser";
            this.lvFormRemoveUser.Size = new System.Drawing.Size(801, 379);
            this.lvFormRemoveUser.TabIndex = 29;
            this.lvFormRemoveUser.UseCompatibleStateImageBehavior = false;
            this.lvFormRemoveUser.View = System.Windows.Forms.View.Details;
            this.lvFormRemoveUser.SelectedIndexChanged += new System.EventHandler(this.lvFormRemoveUser_SelectedIndexChanged);
            // 
            // colPersonalNumber
            // 
            this.colPersonalNumber.Text = "Osobní číslo";
            this.colPersonalNumber.Width = 100;
            // 
            // colFirstName
            // 
            this.colFirstName.DisplayIndex = 2;
            this.colFirstName.Text = "Jméno";
            this.colFirstName.Width = 135;
            // 
            // colLastName
            // 
            this.colLastName.DisplayIndex = 3;
            this.colLastName.Text = "Přijmení";
            this.colLastName.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DisplayIndex = 4;
            this.colEmail.Text = "E-mail";
            this.colEmail.Width = 150;
            // 
            // colPhone
            // 
            this.colPhone.DisplayIndex = 5;
            this.colPhone.Text = "Telefonní číslo";
            this.colPhone.Width = 150;
            // 
            // colRole
            // 
            this.colRole.DisplayIndex = 1;
            this.colRole.Text = "Role";
            this.colRole.Width = 108;
            // 
            // FormRemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvFormRemoveUser);
            this.Controls.Add(this.bntExitProgramRemoveUser);
            this.Controls.Add(this.lblAdminPersonalNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormRemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin panel |Odebrání uživatele";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAdminPersonalNumber;
        private System.Windows.Forms.Button bntExitProgramRemoveUser;
        private System.Windows.Forms.ListView lvFormRemoveUser;
        private System.Windows.Forms.ColumnHeader colPersonalNumber;
        private System.Windows.Forms.ColumnHeader colFirstName;
        private System.Windows.Forms.ColumnHeader colLastName;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colRole;
    }
}