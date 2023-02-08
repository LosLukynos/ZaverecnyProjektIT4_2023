
namespace ZaverecnyProjektIT4_Machacek
{
    partial class FormConfirmRemoveUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPersonalNumberConfirm = new System.Windows.Forms.Label();
            this.btnOKConfirmRemoveUser = new System.Windows.Forms.Button();
            this.btnCancelRemoveUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chystáte se odstranit uživatele s osobním číslem:";
            // 
            // lblPersonalNumberConfirm
            // 
            this.lblPersonalNumberConfirm.AutoSize = true;
            this.lblPersonalNumberConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPersonalNumberConfirm.Location = new System.Drawing.Point(175, 56);
            this.lblPersonalNumberConfirm.Name = "lblPersonalNumberConfirm";
            this.lblPersonalNumberConfirm.Size = new System.Drawing.Size(66, 24);
            this.lblPersonalNumberConfirm.TabIndex = 1;
            this.lblPersonalNumberConfirm.Text = "label2";
            // 
            // btnOKConfirmRemoveUser
            // 
            this.btnOKConfirmRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOKConfirmRemoveUser.Location = new System.Drawing.Point(254, 112);
            this.btnOKConfirmRemoveUser.Name = "btnOKConfirmRemoveUser";
            this.btnOKConfirmRemoveUser.Size = new System.Drawing.Size(150, 51);
            this.btnOKConfirmRemoveUser.TabIndex = 2;
            this.btnOKConfirmRemoveUser.Text = "OK";
            this.btnOKConfirmRemoveUser.UseVisualStyleBackColor = true;
            this.btnOKConfirmRemoveUser.Click += new System.EventHandler(this.btnOKConfirmRemoveUser_Click);
            // 
            // btnCancelRemoveUser
            // 
            this.btnCancelRemoveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancelRemoveUser.Location = new System.Drawing.Point(16, 112);
            this.btnCancelRemoveUser.Name = "btnCancelRemoveUser";
            this.btnCancelRemoveUser.Size = new System.Drawing.Size(150, 51);
            this.btnCancelRemoveUser.TabIndex = 4;
            this.btnCancelRemoveUser.Text = "Zpět";
            this.btnCancelRemoveUser.UseVisualStyleBackColor = true;
            // 
            // FormConfirmRemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 175);
            this.Controls.Add(this.btnCancelRemoveUser);
            this.Controls.Add(this.btnOKConfirmRemoveUser);
            this.Controls.Add(this.lblPersonalNumberConfirm);
            this.Controls.Add(this.label1);
            this.Name = "FormConfirmRemoveUser";
            this.Text = "FormConfirmRemoveUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonalNumberConfirm;
        private System.Windows.Forms.Button btnOKConfirmRemoveUser;
        private System.Windows.Forms.Button btnCancelRemoveUser;
    }
}