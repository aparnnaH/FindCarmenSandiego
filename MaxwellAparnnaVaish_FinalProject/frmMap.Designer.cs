namespace ManoharanV_SplashScreen_FP
{
    partial class frmMap
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
			this.picAcme = new System.Windows.Forms.PictureBox();
			this.txtNotebook = new System.Windows.Forms.TextBox();
			this.picMagGrid = new System.Windows.Forms.PictureBox();
			this.tlpNewYork = new System.Windows.Forms.ToolTip(this.components);
			this.tlpRio = new System.Windows.Forms.ToolTip(this.components);
			this.picRiodeJaneiro = new System.Windows.Forms.PictureBox();
			this.picNewYork = new System.Windows.Forms.PictureBox();
			this.tlpAgra = new System.Windows.Forms.ToolTip(this.components);
			this.picAgra = new System.Windows.Forms.PictureBox();
			this.tlpLondon = new System.Windows.Forms.ToolTip(this.components);
			this.picLondon = new System.Windows.Forms.PictureBox();
			this.lblFlights = new System.Windows.Forms.Label();
			this.lblFlightNumbers = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picAcme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMagGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRiodeJaneiro)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewYork)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picAgra)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLondon)).BeginInit();
			this.SuspendLayout();
			// 
			// picAcme
			// 
			this.picAcme.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.ACMEwhite;
			this.picAcme.Location = new System.Drawing.Point(883, 416);
			this.picAcme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picAcme.Name = "picAcme";
			this.picAcme.Size = new System.Drawing.Size(99, 65);
			this.picAcme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picAcme.TabIndex = 10;
			this.picAcme.TabStop = false;
			// 
			// txtNotebook
			// 
			this.txtNotebook.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNotebook.Location = new System.Drawing.Point(679, 416);
			this.txtNotebook.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtNotebook.Multiline = true;
			this.txtNotebook.Name = "txtNotebook";
			this.txtNotebook.Size = new System.Drawing.Size(301, 205);
			this.txtNotebook.TabIndex = 9;
			// 
			// picMagGrid
			// 
			this.picMagGrid.Image = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.mapPic;
			this.picMagGrid.Location = new System.Drawing.Point(289, 1);
			this.picMagGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picMagGrid.Name = "picMagGrid";
			this.picMagGrid.Size = new System.Drawing.Size(692, 363);
			this.picMagGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picMagGrid.TabIndex = 11;
			this.picMagGrid.TabStop = false;
			// 
			// tlpNewYork
			// 
			this.tlpNewYork.Tag = "1";
			this.tlpNewYork.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			// 
			// picRiodeJaneiro
			// 
			this.picRiodeJaneiro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.picRiodeJaneiro.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.mapIcon;
			this.picRiodeJaneiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picRiodeJaneiro.Location = new System.Drawing.Point(476, 240);
			this.picRiodeJaneiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picRiodeJaneiro.Name = "picRiodeJaneiro";
			this.picRiodeJaneiro.Size = new System.Drawing.Size(32, 30);
			this.picRiodeJaneiro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picRiodeJaneiro.TabIndex = 14;
			this.picRiodeJaneiro.TabStop = false;
			this.tlpRio.SetToolTip(this.picRiodeJaneiro, "Rio De Janeiro");
			this.picRiodeJaneiro.Click += new System.EventHandler(this.picRiodeJaneiro_Click);
			// 
			// picNewYork
			// 
			this.picNewYork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.picNewYork.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.mapIcon;
			this.picNewYork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picNewYork.Location = new System.Drawing.Point(395, 103);
			this.picNewYork.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picNewYork.Name = "picNewYork";
			this.picNewYork.Size = new System.Drawing.Size(35, 30);
			this.picNewYork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picNewYork.TabIndex = 18;
			this.picNewYork.TabStop = false;
			this.tlpRio.SetToolTip(this.picNewYork, "NewYork");
			this.picNewYork.Click += new System.EventHandler(this.picNewYork_Click_1);
			// 
			// picAgra
			// 
			this.picAgra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.picAgra.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.mapIcon;
			this.picAgra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picAgra.Location = new System.Drawing.Point(733, 146);
			this.picAgra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picAgra.Name = "picAgra";
			this.picAgra.Size = new System.Drawing.Size(33, 32);
			this.picAgra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAgra.TabIndex = 13;
			this.picAgra.TabStop = false;
			this.tlpAgra.SetToolTip(this.picAgra, "Agra");
			this.picAgra.Click += new System.EventHandler(this.picAgra_Click);
			// 
			// picLondon
			// 
			this.picLondon.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.mapIcon;
			this.picLondon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picLondon.Location = new System.Drawing.Point(592, 103);
			this.picLondon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.picLondon.Name = "picLondon";
			this.picLondon.Size = new System.Drawing.Size(32, 30);
			this.picLondon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picLondon.TabIndex = 15;
			this.picLondon.TabStop = false;
			this.tlpLondon.SetToolTip(this.picLondon, "London");
			this.picLondon.Click += new System.EventHandler(this.picLondon_Click);
			// 
			// lblFlights
			// 
			this.lblFlights.BackColor = System.Drawing.Color.Black;
			this.lblFlights.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFlights.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblFlights.Location = new System.Drawing.Point(305, 482);
			this.lblFlights.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFlights.Name = "lblFlights";
			this.lblFlights.Size = new System.Drawing.Size(304, 105);
			this.lblFlights.TabIndex = 16;
			this.lblFlights.Text = "New York              \r\nAgra                 \r\nLondon              \r\nRio De Janei" +
    "ro         ";
			// 
			// lblFlightNumbers
			// 
			this.lblFlightNumbers.BackColor = System.Drawing.Color.Black;
			this.lblFlightNumbers.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFlightNumbers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblFlightNumbers.Location = new System.Drawing.Point(544, 482);
			this.lblFlightNumbers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFlightNumbers.Name = "lblFlightNumbers";
			this.lblFlightNumbers.Size = new System.Drawing.Size(77, 105);
			this.lblFlightNumbers.TabIndex = 17;
			this.lblFlightNumbers.Text = "1526\r\n5056\r\n2123\r\n0348";
			// 
			// frmMap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::MaxwellAparnnaVaish_FinalProject.Properties.Resources.map;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1023, 636);
			this.Controls.Add(this.picAcme);
			this.Controls.Add(this.picNewYork);
			this.Controls.Add(this.lblFlightNumbers);
			this.Controls.Add(this.lblFlights);
			this.Controls.Add(this.picLondon);
			this.Controls.Add(this.picRiodeJaneiro);
			this.Controls.Add(this.picAgra);
			this.Controls.Add(this.picMagGrid);
			this.Controls.Add(this.txtNotebook);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmMap";
			this.Text = "Where in the World is Carmen Sandiego";
			((System.ComponentModel.ISupportInitialize)(this.picAcme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMagGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRiodeJaneiro)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picNewYork)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picAgra)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLondon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAcme;
        private System.Windows.Forms.TextBox txtNotebook;
        private System.Windows.Forms.PictureBox picMagGrid;
        private System.Windows.Forms.ToolTip tlpNewYork;
        private System.Windows.Forms.ToolTip tlpRio;
        private System.Windows.Forms.ToolTip tlpAgra;
        private System.Windows.Forms.ToolTip tlpLondon;
        private System.Windows.Forms.Label lblFlights;
        private System.Windows.Forms.Label lblFlightNumbers;
        private System.Windows.Forms.PictureBox picRiodeJaneiro;
        private System.Windows.Forms.PictureBox picLondon;
        private System.Windows.Forms.PictureBox picAgra;
        private System.Windows.Forms.PictureBox picNewYork;
    }
}