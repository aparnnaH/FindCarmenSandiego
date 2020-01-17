namespace frmIndia
{
    partial class frmLadyTalking
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
            this.btnSpeak = new System.Windows.Forms.Button();
            this.rdbThree = new System.Windows.Forms.RadioButton();
            this.rdbTwo = new System.Windows.Forms.RadioButton();
            this.rdbOne = new System.Windows.Forms.RadioButton();
            this.grpChoices = new System.Windows.Forms.GroupBox();
            this.lblAgent3 = new System.Windows.Forms.Label();
            this.lblLadySpeech2 = new System.Windows.Forms.Label();
            this.lblAgent2 = new System.Windows.Forms.Label();
            this.lblAgent1 = new System.Windows.Forms.Label();
            this.lblLadySpeech1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpChoices.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.Color.Black;
            this.btnSpeak.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.Location = new System.Drawing.Point(481, 150);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 26);
            this.btnSpeak.TabIndex = 3;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click_1);
            // 
            // rdbThree
            // 
            this.rdbThree.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThree.Location = new System.Drawing.Point(378, 19);
            this.rdbThree.Name = "rdbThree";
            this.rdbThree.Size = new System.Drawing.Size(163, 139);
            this.rdbThree.TabIndex = 2;
            this.rdbThree.TabStop = true;
            this.rdbThree.Text = "Hi, what are you doing here?";
            this.rdbThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbThree.UseVisualStyleBackColor = true;
            // 
            // rdbTwo
            // 
            this.rdbTwo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTwo.Location = new System.Drawing.Point(215, 19);
            this.rdbTwo.Name = "rdbTwo";
            this.rdbTwo.Size = new System.Drawing.Size(133, 139);
            this.rdbTwo.TabIndex = 1;
            this.rdbTwo.TabStop = true;
            this.rdbTwo.Text = "Hi, who are you?";
            this.rdbTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbTwo.UseVisualStyleBackColor = true;
            // 
            // rdbOne
            // 
            this.rdbOne.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOne.Location = new System.Drawing.Point(15, 19);
            this.rdbOne.Name = "rdbOne";
            this.rdbOne.Size = new System.Drawing.Size(165, 139);
            this.rdbOne.TabIndex = 0;
            this.rdbOne.TabStop = true;
            this.rdbOne.Text = "Hello, what is your name?";
            this.rdbOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbOne.UseVisualStyleBackColor = true;
            // 
            // grpChoices
            // 
            this.grpChoices.BackColor = System.Drawing.Color.Transparent;
            this.grpChoices.Controls.Add(this.btnSpeak);
            this.grpChoices.Controls.Add(this.rdbThree);
            this.grpChoices.Controls.Add(this.rdbTwo);
            this.grpChoices.Controls.Add(this.rdbOne);
            this.grpChoices.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpChoices.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpChoices.Location = new System.Drawing.Point(326, 409);
            this.grpChoices.Name = "grpChoices";
            this.grpChoices.Size = new System.Drawing.Size(558, 181);
            this.grpChoices.TabIndex = 1;
            this.grpChoices.TabStop = false;
            this.grpChoices.Text = "What do you want to say?";
            // 
            // lblAgent3
            // 
            this.lblAgent3.BackColor = System.Drawing.Color.Transparent;
            this.lblAgent3.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgent3.Location = new System.Drawing.Point(370, 308);
            this.lblAgent3.Name = "lblAgent3";
            this.lblAgent3.Size = new System.Drawing.Size(411, 45);
            this.lblAgent3.TabIndex = 10;
            this.lblAgent3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLadySpeech2
            // 
            this.lblLadySpeech2.BackColor = System.Drawing.Color.Transparent;
            this.lblLadySpeech2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadySpeech2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadySpeech2.Location = new System.Drawing.Point(162, 259);
            this.lblLadySpeech2.Name = "lblLadySpeech2";
            this.lblLadySpeech2.Size = new System.Drawing.Size(558, 52);
            this.lblLadySpeech2.TabIndex = 9;
            this.lblLadySpeech2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAgent2
            // 
            this.lblAgent2.BackColor = System.Drawing.Color.Transparent;
            this.lblAgent2.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgent2.Location = new System.Drawing.Point(308, 164);
            this.lblAgent2.Name = "lblAgent2";
            this.lblAgent2.Size = new System.Drawing.Size(535, 95);
            this.lblAgent2.TabIndex = 8;
            this.lblAgent2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAgent1
            // 
            this.lblAgent1.BackColor = System.Drawing.Color.Transparent;
            this.lblAgent1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgent1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAgent1.Location = new System.Drawing.Point(281, 63);
            this.lblAgent1.Name = "lblAgent1";
            this.lblAgent1.Size = new System.Drawing.Size(551, 50);
            this.lblAgent1.TabIndex = 6;
            this.lblAgent1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLadySpeech1
            // 
            this.lblLadySpeech1.BackColor = System.Drawing.Color.Transparent;
            this.lblLadySpeech1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadySpeech1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLadySpeech1.Location = new System.Drawing.Point(162, 113);
            this.lblLadySpeech1.Name = "lblLadySpeech1";
            this.lblLadySpeech1.Size = new System.Drawing.Size(551, 51);
            this.lblLadySpeech1.TabIndex = 7;
            this.lblLadySpeech1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Black;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(626, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(266, 36);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Continue interviewing people";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmLadyTalking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.sariLadyConvo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 602);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblAgent3);
            this.Controls.Add(this.lblLadySpeech2);
            this.Controls.Add(this.lblAgent2);
            this.Controls.Add(this.lblLadySpeech1);
            this.Controls.Add(this.lblAgent1);
            this.Controls.Add(this.grpChoices);
            this.DoubleBuffered = true;
            this.Name = "frmLadyTalking";
            this.Text = "frmLadyTalking";
            this.grpChoices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.RadioButton rdbThree;
        private System.Windows.Forms.RadioButton rdbTwo;
        private System.Windows.Forms.RadioButton rdbOne;
        private System.Windows.Forms.GroupBox grpChoices;
        private System.Windows.Forms.Label lblAgent3;
        private System.Windows.Forms.Label lblLadySpeech2;
        private System.Windows.Forms.Label lblAgent2;
        private System.Windows.Forms.Label lblAgent1;
        private System.Windows.Forms.Label lblLadySpeech1;
        private System.Windows.Forms.Button btnBack;
    }
}