using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpShell.SharpPropertySheet;

namespace FarnaPropertySheetPreview
{
	public partial class Sop6PropertySheetControl : SharpPropertyPage
	{
		public Sop6PropertySheetControl()
		{
			InitializeComponent();
			PageTitle = "Sop6 information";
			PageIcon = Properties.Resources.image823;
		}

		protected override void OnPropertyPageInitialised(SharpPropertySheet parent)
		{
			var filePath = parent.SelectedItemPaths.FirstOrDefault();
			if (filePath == null)
			{
				return;
			}

			lblfileName.Text = filePath;
			lblOfficeVersion.Text = "Office 8.3";
		}
	}
}
