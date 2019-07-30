namespace FarnaPreview
{
	partial class FarnaPreviewControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;



		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.llblPlaySample = new System.Windows.Forms.LinkLabel();
			this.pbPhoto = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.llblPlaySample, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.pbPhoto, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(293, 372);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.Fuchsia;
			this.lblTitle.Location = new System.Drawing.Point(3, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(287, 26);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "Ewa Farna";
			// 
			// llblPlaySample
			// 
			this.llblPlaySample.AutoSize = true;
			this.llblPlaySample.Dock = System.Windows.Forms.DockStyle.Fill;
			this.llblPlaySample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llblPlaySample.Location = new System.Drawing.Point(3, 36);
			this.llblPlaySample.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.llblPlaySample.Name = "llblPlaySample";
			this.llblPlaySample.Size = new System.Drawing.Size(287, 20);
			this.llblPlaySample.TabIndex = 1;
			this.llblPlaySample.TabStop = true;
			this.llblPlaySample.Text = "Play sample";
			this.llblPlaySample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.llblPlaySample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblPlaySample_LinkClicked);
			// 
			// pbPhoto
			// 
			this.pbPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbPhoto.Location = new System.Drawing.Point(3, 69);
			this.pbPhoto.Name = "pbPhoto";
			this.pbPhoto.Size = new System.Drawing.Size(287, 300);
			this.pbPhoto.TabIndex = 2;
			this.pbPhoto.TabStop = false;
			// 
			// FarnaPreviewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FarnaPreviewControl";
			this.Size = new System.Drawing.Size(293, 372);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.LinkLabel llblPlaySample;
		private System.Windows.Forms.PictureBox pbPhoto;
	}
}
