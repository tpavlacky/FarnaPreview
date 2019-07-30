namespace FarnaPreview
{
	partial class FarnaPropertySheetControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.lblTitleValue = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.rtbInfo = new System.Windows.Forms.RichTextBox();
			this.llblSpotify = new System.Windows.Forms.LinkLabel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.6645F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.3355F));
			this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblTitleValue, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblInfo, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.rtbInfo, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.llblSpotify, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 390);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(3, 5);
			this.lblTitle.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(82, 15);
			this.lblTitle.TabIndex = 0;
			this.lblTitle.Text = "File name:";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblTitleValue
			// 
			this.lblTitleValue.AutoSize = true;
			this.lblTitleValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTitleValue.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleValue.Location = new System.Drawing.Point(91, 5);
			this.lblTitleValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
			this.lblTitleValue.Name = "lblTitleValue";
			this.lblTitleValue.Size = new System.Drawing.Size(213, 15);
			this.lblTitleValue.TabIndex = 1;
			this.lblTitleValue.Text = "Text...";
			this.lblTitleValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInfo.Location = new System.Drawing.Point(3, 20);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(82, 15);
			this.lblInfo.TabIndex = 2;
			this.lblInfo.Text = "Info:";
			this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// rtbInfo
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.rtbInfo, 2);
			this.rtbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbInfo.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbInfo.Location = new System.Drawing.Point(3, 38);
			this.rtbInfo.Name = "rtbInfo";
			this.rtbInfo.ReadOnly = true;
			this.rtbInfo.Size = new System.Drawing.Size(301, 326);
			this.rtbInfo.TabIndex = 3;
			this.rtbInfo.Text = "";
			// 
			// llblSpotify
			// 
			this.llblSpotify.AutoSize = true;
			this.llblSpotify.Dock = System.Windows.Forms.DockStyle.Fill;
			this.llblSpotify.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.llblSpotify.LinkColor = System.Drawing.Color.Fuchsia;
			this.llblSpotify.Location = new System.Drawing.Point(91, 20);
			this.llblSpotify.Name = "llblSpotify";
			this.llblSpotify.Size = new System.Drawing.Size(213, 15);
			this.llblSpotify.TabIndex = 5;
			this.llblSpotify.TabStop = true;
			this.llblSpotify.Text = "Send me to spotify...";
			this.llblSpotify.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// FarnaPropertySheetControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "FarnaPropertySheetControl";
			this.Size = new System.Drawing.Size(307, 390);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Label lblTitleValue;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.RichTextBox rtbInfo;
		private System.Windows.Forms.LinkLabel llblSpotify;
	}
}
