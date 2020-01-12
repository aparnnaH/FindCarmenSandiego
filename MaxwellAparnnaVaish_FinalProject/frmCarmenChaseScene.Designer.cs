namespace ManoharanV_CarmenChaseScene
{
    partial class frmCarmenChaseScene
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarmenChaseScene));
            this.wmpEscape = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wmpEscape)).BeginInit();
            this.SuspendLayout();
            // 
            // wmpEscape
            // 
            this.wmpEscape.Enabled = true;
            this.wmpEscape.Location = new System.Drawing.Point(1, 0);
            this.wmpEscape.Name = "wmpEscape";
            this.wmpEscape.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpEscape.OcxState")));
            this.wmpEscape.Size = new System.Drawing.Size(749, 495);
            this.wmpEscape.TabIndex = 0;
            this.wmpEscape.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpEscape_PlayStateChange);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oh my! Carmen is escaping from the Big Ben...";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(276, 196);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(158, 44);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Catch her!";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 496);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wmpEscape);
            this.Name = "Form1";
            this.Text = "Where in the World is Carmen Sandiego?";
            ((System.ComponentModel.ISupportInitialize)(this.wmpEscape)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpEscape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
    }
}

