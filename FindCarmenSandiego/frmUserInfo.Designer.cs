namespace SplashScreen_FP
{
    partial class frmUserInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserInfo));
			this.picACME = new System.Windows.Forms.PictureBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblInstruction2 = new System.Windows.Forms.Label();
			this.lblInstruction1 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.btnNext = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picACME)).BeginInit();
			this.SuspendLayout();
			// 
			// picACME
			// 
			this.picACME.BackColor = System.Drawing.Color.Transparent;
			this.picACME.Image = global::FindCarmenSandiego.Properties.Resources.ACME;
			this.picACME.Location = new System.Drawing.Point(424, 66);
			this.picACME.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picACME.Name = "picACME";
			this.picACME.Size = new System.Drawing.Size(276, 175);
			this.picACME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picACME.TabIndex = 0;
			this.picACME.TabStop = false;
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMessage.Location = new System.Drawing.Point(76, 508);
			this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(1020, 126);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Text = resources.GetString("lblMessage.Text");
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.BackColor = System.Drawing.Color.Transparent;
			this.lblLogin.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblLogin.Location = new System.Drawing.Point(212, 245);
			this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(723, 53);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "A.C.M.E   T E R M I N A L";
			// 
			// lblInstruction2
			// 
			this.lblInstruction2.BackColor = System.Drawing.Color.Transparent;
			this.lblInstruction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstruction2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInstruction2.Location = new System.Drawing.Point(364, 376);
			this.lblInstruction2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstruction2.Name = "lblInstruction2";
			this.lblInstruction2.Size = new System.Drawing.Size(169, 47);
			this.lblInstruction2.TabIndex = 6;
			this.lblInstruction2.Text = "Password :";
			// 
			// lblInstruction1
			// 
			this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
			this.lblInstruction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstruction1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInstruction1.Location = new System.Drawing.Point(364, 313);
			this.lblInstruction1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblInstruction1.Name = "lblInstruction1";
			this.lblInstruction1.Size = new System.Drawing.Size(177, 46);
			this.lblInstruction1.TabIndex = 5;
			this.lblInstruction1.Text = "Agent Name : ";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(533, 312);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(248, 43);
			this.txtUserName.TabIndex = 7;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(533, 376);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(248, 43);
			this.txtPassword.TabIndex = 8;
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNext.Location = new System.Drawing.Point(481, 445);
			this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(179, 47);
			this.btnNext.TabIndex = 9;
			this.btnNext.Text = "Log In";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// frmUserInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.computerScreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(1156, 647);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblInstruction2);
			this.Controls.Add(this.lblInstruction1);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.picACME);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmUserInfo";
			this.Text = "frmUserInfo";
			((System.ComponentModel.ISupportInitialize)(this.picACME)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picACME;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblInstruction2;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnNext;
    }
}