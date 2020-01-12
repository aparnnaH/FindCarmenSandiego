namespace ManoharanV_OpenFieldLondon_FP
{
    partial class frmOpenField
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
			this.components = new System.ComponentModel.Container();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.picThought = new System.Windows.Forms.PictureBox();
			this.btnSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.picThought)).BeginInit();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// picThought
			// 
			this.picThought.BackColor = System.Drawing.Color.Transparent;
			this.picThought.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.fieldThought;
			this.picThought.Location = new System.Drawing.Point(25, 426);
			this.picThought.Name = "picThought";
			this.picThought.Size = new System.Drawing.Size(399, 128);
			this.picThought.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picThought.TabIndex = 0;
			this.picThought.TabStop = false;
			this.picThought.Visible = false;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnSearch.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSearch.Location = new System.Drawing.Point(555, 466);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(152, 43);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "Search Field";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Visible = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// frmOpenField
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.open_field;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(851, 566);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.picThought);
			this.Name = "frmOpenField";
			this.Text = "Where in the World is Carmen Sandiego";
			this.Load += new System.EventHandler(this.frmOpenField_Load);
			((System.ComponentModel.ISupportInitialize)(this.picThought)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picThought;
        private System.Windows.Forms.Button btnSearch;
    }
}

