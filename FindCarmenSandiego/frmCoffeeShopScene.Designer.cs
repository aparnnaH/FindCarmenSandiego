namespace Coffee_shop_Scene
{
	partial class frmCoffeeShopScene
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
			this.tmrCoffeeShop = new System.Windows.Forms.Timer(this.components);
			this.picAirplaneTicket = new System.Windows.Forms.PictureBox();
			this.picMainImage = new System.Windows.Forms.PictureBox();
			this.picCoffee = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picAirplaneTicket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picMainImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picCoffee)).BeginInit();
			this.SuspendLayout();
			// 
			// tmrCoffeeShop
			// 
			this.tmrCoffeeShop.Interval = 1000;
			this.tmrCoffeeShop.Tick += new System.EventHandler(this.tmrCoffeeShop_Tick);
			// 
			// picAirplaneTicket
			// 
			this.picAirplaneTicket.BackColor = System.Drawing.Color.Transparent;
			this.picAirplaneTicket.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.plane_ticket1;
			this.picAirplaneTicket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picAirplaneTicket.Location = new System.Drawing.Point(1, 353);
			this.picAirplaneTicket.Name = "picAirplaneTicket";
			this.picAirplaneTicket.Size = new System.Drawing.Size(214, 110);
			this.picAirplaneTicket.TabIndex = 0;
			this.picAirplaneTicket.TabStop = false;
			this.picAirplaneTicket.Visible = false;
			this.picAirplaneTicket.Click += new System.EventHandler(this.picAirplaneTicket_Click);
			// 
			// picMainImage
			// 
			this.picMainImage.BackColor = System.Drawing.Color.Transparent;
			this.picMainImage.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.plane_ticket1;
			this.picMainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picMainImage.Location = new System.Drawing.Point(1, 49);
			this.picMainImage.Name = "picMainImage";
			this.picMainImage.Size = new System.Drawing.Size(596, 394);
			this.picMainImage.TabIndex = 1;
			this.picMainImage.TabStop = false;
			this.picMainImage.Visible = false;
			this.picMainImage.Click += new System.EventHandler(this.picMainImage_Click);
			// 
			// picCoffee
			// 
			this.picCoffee.BackColor = System.Drawing.Color.Transparent;
			this.picCoffee.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.coffe;
			this.picCoffee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picCoffee.Enabled = false;
			this.picCoffee.Location = new System.Drawing.Point(425, 284);
			this.picCoffee.Name = "picCoffee";
			this.picCoffee.Size = new System.Drawing.Size(172, 179);
			this.picCoffee.TabIndex = 2;
			this.picCoffee.TabStop = false;
			this.picCoffee.Visible = false;
			// 
			// frmCoffeeShopScene
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FindCarmenSandiego.Properties.Resources.coffe_shop1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(620, 484);
			this.Controls.Add(this.picCoffee);
			this.Controls.Add(this.picMainImage);
			this.Controls.Add(this.picAirplaneTicket);
			this.Name = "frmCoffeeShopScene";
			this.Text = "Coffee Shop Scene";
			this.Load += new System.EventHandler(this.frmCoffeeShopScene_Load);
			((System.ComponentModel.ISupportInitialize)(this.picAirplaneTicket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picMainImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picCoffee)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrCoffeeShop;
		private System.Windows.Forms.PictureBox picAirplaneTicket;
		private System.Windows.Forms.PictureBox picMainImage;
		private System.Windows.Forms.PictureBox picCoffee;
	}
}

