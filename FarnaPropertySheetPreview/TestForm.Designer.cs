namespace FarnaPropertySheetPreview
{
	partial class TestForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
			this.farnaPropertySheetControl1 = new FarnaPreview.FarnaPropertySheetControl();
			this.SuspendLayout();
			// 
			// farnaPropertySheetControl1
			// 
			this.farnaPropertySheetControl1.Location = new System.Drawing.Point(12, 12);
			this.farnaPropertySheetControl1.Name = "farnaPropertySheetControl1";
			this.farnaPropertySheetControl1.PageIcon = ((System.Drawing.Icon)(resources.GetObject("farnaPropertySheetControl1.PageIcon")));
			this.farnaPropertySheetControl1.PageTitle = "Ewicka";
			this.farnaPropertySheetControl1.Size = new System.Drawing.Size(307, 390);
			this.farnaPropertySheetControl1.TabIndex = 1;
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.farnaPropertySheetControl1);
			this.Name = "TestForm";
			this.Text = "TestForm";
			this.ResumeLayout(false);

		}

		#endregion
		private FarnaPreview.FarnaPropertySheetControl farnaPropertySheetControl1;
	}
}