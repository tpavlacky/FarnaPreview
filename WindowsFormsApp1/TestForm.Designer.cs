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
			this.farnaPropertySheetControl2 = new FarnaPreview.FarnaPropertySheetControl();
			this.SuspendLayout();
			// 
			// farnaPropertySheetControl2
			// 
			this.farnaPropertySheetControl2.Location = new System.Drawing.Point(12, 12);
			this.farnaPropertySheetControl2.Name = "farnaPropertySheetControl2";
			this.farnaPropertySheetControl2.PageIcon = ((System.Drawing.Icon)(resources.GetObject("farnaPropertySheetControl2.PageIcon")));
			this.farnaPropertySheetControl2.PageTitle = "Ewicka";
			this.farnaPropertySheetControl2.Size = new System.Drawing.Size(307, 390);
			this.farnaPropertySheetControl2.TabIndex = 0;
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.farnaPropertySheetControl2);
			this.Name = "TestForm";
			this.Text = "TestForm";
			this.ResumeLayout(false);

		}

		#endregion
		private FarnaPreview.FarnaPropertySheetControl farnaPropertySheetControl2;
	}
}