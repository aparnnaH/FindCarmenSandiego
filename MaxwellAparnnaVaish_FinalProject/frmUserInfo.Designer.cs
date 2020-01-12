namespace ManoharanV_SplashScreen_FP
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
			this.lblScreen = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picACME)).BeginInit();
			this.SuspendLayout();
			// 
			// picACME
			// 
			this.picACME.BackColor = System.Drawing.Color.Transparent;
			this.picACME.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.ACME;
			this.picACME.Location = new System.Drawing.Point(351, 43);
			this.picACME.Name = "picACME";
			this.picACME.Size = new System.Drawing.Size(183, 127);
			this.picACME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picACME.TabIndex = 0;
			this.picACME.TabStop = false;
			// 
			// lblMessage
			// 
			this.lblMessage.BackColor = System.Drawing.Color.Transparent;
			this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMessage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblMessage.Location = new System.Drawing.Point(57, 413);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(765, 102);
			this.lblMessage.TabIndex = 1;
			this.lblMessage.Text = resources.GetString("lblMessage.Text");
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.BackColor = System.Drawing.Color.Transparent;
			this.lblLogin.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblLogin.Location = new System.Drawing.Point(152, 182);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(568, 41);
			this.lblLogin.TabIndex = 2;
			this.lblLogin.Text = "A.C.M.E   T E R M I N A L";
			// 
			// lblInstruction2
			// 
			this.lblInstruction2.BackColor = System.Drawing.Color.Transparent;
			this.lblInstruction2.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstruction2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInstruction2.Location = new System.Drawing.Point(282, 272);
			this.lblInstruction2.Name = "lblInstruction2";
			this.lblInstruction2.Size = new System.Drawing.Size(127, 38);
			this.lblInstruction2.TabIndex = 6;
			this.lblInstruction2.Text = "Password :";
			// 
			// lblInstruction1
			// 
			this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
			this.lblInstruction1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInstruction1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblInstruction1.Location = new System.Drawing.Point(274, 226);
			this.lblInstruction1.Name = "lblInstruction1";
			this.lblInstruction1.Size = new System.Drawing.Size(126, 37);
			this.lblInstruction1.TabIndex = 5;
			this.lblInstruction1.Text = "Agent Name : ";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(400, 226);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(187, 36);
			this.txtUserName.TabIndex = 7;
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(400, 272);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(187, 36);
			this.txtPassword.TabIndex = 8;
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnNext.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnNext.Location = new System.Drawing.Point(384, 315);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(91, 38);
			this.btnNext.TabIndex = 9;
			this.btnNext.Text = "Log In";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// lblScreen
			// 
			this.lblScreen.Location = new System.Drawing.Point(133, 32);
			this.lblScreen.Name = "lblScreen";
			this.lblScreen.Size = new System.Drawing.Size(587, 330);
			this.lblScreen.TabIndex = 10;
			this.lblScreen.Text = "label1";
			// 
			// frmUserInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.computerScreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(867, 526);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblInstruction2);
			this.Controls.Add(this.lblInstruction1);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.picACME);
			this.Controls.Add(this.lblScreen);
			this.Name = "frmUserInfo";
			this.Text = "Where in the World is Carmen Sandiego";
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
		private System.Windows.Forms.Label lblScreen;
	}
}