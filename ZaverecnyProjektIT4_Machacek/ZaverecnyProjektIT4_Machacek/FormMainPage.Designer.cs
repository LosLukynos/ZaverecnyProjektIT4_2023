namespace ZaverecnyProjektIT4_Machacek
{
    partial class FormMainPage
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
            this.lblLoggedAsMainPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLoggedAsMainPage
            // 
            this.lblLoggedAsMainPage.AutoSize = true;
            this.lblLoggedAsMainPage.Location = new System.Drawing.Point(352, 122);
            this.lblLoggedAsMainPage.Name = "lblLoggedAsMainPage";
            this.lblLoggedAsMainPage.Size = new System.Drawing.Size(35, 13);
            this.lblLoggedAsMainPage.TabIndex = 0;
            this.lblLoggedAsMainPage.Text = "label1";
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLoggedAsMainPage);
            this.Name = "FormMainPage";
            this.Text = "Hlavní stránka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoggedAsMainPage;
    }
}