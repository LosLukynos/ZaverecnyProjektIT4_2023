namespace ZaverecnyProjektIT4_Machacek
{
    partial class FormLogin
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonalNumberLogin = new System.Windows.Forms.TextBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmLogin = new System.Windows.Forms.Button();
            this.btnCancelLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osobní číslo";
            // 
            // txtPersonalNumberLogin
            // 
            this.txtPersonalNumberLogin.Location = new System.Drawing.Point(141, 117);
            this.txtPersonalNumberLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPersonalNumberLogin.Name = "txtPersonalNumberLogin";
            this.txtPersonalNumberLogin.Size = new System.Drawing.Size(228, 22);
            this.txtPersonalNumberLogin.TabIndex = 1;
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(141, 183);
            this.txtPasswordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(228, 27);
            this.txtPasswordLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Heslo";
            // 
            // btnConfirmLogin
            // 
            this.btnConfirmLogin.Location = new System.Drawing.Point(269, 294);
            this.btnConfirmLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmLogin.Name = "btnConfirmLogin";
            this.btnConfirmLogin.Size = new System.Drawing.Size(177, 43);
            this.btnConfirmLogin.TabIndex = 4;
            this.btnConfirmLogin.Text = "Přihlásit";
            this.btnConfirmLogin.UseVisualStyleBackColor = true;
            this.btnConfirmLogin.Click += new System.EventHandler(this.btnConfirmLogin_Click);
            // 
            // btnCancelLogin
            // 
            this.btnCancelLogin.Location = new System.Drawing.Point(16, 295);
            this.btnCancelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelLogin.Name = "btnCancelLogin";
            this.btnCancelLogin.Size = new System.Drawing.Size(177, 43);
            this.btnCancelLogin.TabIndex = 5;
            this.btnCancelLogin.Text = "Ukončit";
            this.btnCancelLogin.UseVisualStyleBackColor = true;
            this.btnCancelLogin.Click += new System.EventHandler(this.btnCancelLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(148, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "Přihlášení";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelLogin);
            this.Controls.Add(this.btnConfirmLogin);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPersonalNumberLogin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Přihlášení do systému";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonalNumberLogin;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmLogin;
        private System.Windows.Forms.Button btnCancelLogin;
        private System.Windows.Forms.Label label3;
    }
}

