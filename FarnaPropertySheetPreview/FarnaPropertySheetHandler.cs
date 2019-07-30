using FarnaPropertySheetPreview;
using SharpShell.Attributes;
using SharpShell.SharpPropertySheet;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace FarnaPreview
{
	[ComVisible(true)]
	[COMServerAssociation(AssociationType.ClassOfExtension, ".mp3")]
	public class FarnaPropertySheetHandler : SharpPropertySheet
	{
		protected override bool CanShowSheet()
		{
			return SelectedItemPaths.Count() == 1;
		}

		protected override IEnumerable<SharpPropertyPage> CreatePages()
		{
			var page = new FarnaPropertySheetControl();

			return new[] { page };
		}
	}

	[ComVisible(true)]
	[COMServerAssociation(AssociationType.ClassOfExtension, ".sop6")]
	public class Sop6PropertySheetHandler : SharpPropertySheet
	{
		protected override bool CanShowSheet()
		{
			return SelectedItemPaths.Count() == 1;
		}

		protected override IEnumerable<SharpPropertyPage> CreatePages()
		{
			var page = new Sop6PropertySheetControl();

			return new[] { page };
		}
	}
}
