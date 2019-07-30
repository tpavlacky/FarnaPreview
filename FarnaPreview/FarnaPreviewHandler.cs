using SharpShell.Attributes;
using SharpShell.SharpPreviewHandler;
using System.Runtime.InteropServices;

namespace FarnaPreview
{
	[ComVisible(true)]
	[PreviewHandler()]
	[COMServerAssociation(AssociationType.ClassOfExtension,".mp3")]
	[DisplayName("Icon Preview Handler")]
	public class FarnaPreviewHandler : SharpPreviewHandler
	{
		protected override PreviewHandlerControl DoPreview()
		{
			var handler = new FarnaPreviewControl();
			if (!string.IsNullOrEmpty(SelectedFilePath) && SelectedFilePath.Contains("Farna"))
			{
				handler.DoPreview(SelectedFilePath);
				return handler;
			}

			return null;
		}
	}
}


//C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319\RegAsm.exe FarnaPreview.dll /codebase