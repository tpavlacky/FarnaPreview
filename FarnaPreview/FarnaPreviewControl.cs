using SharpShell.SharpPreviewHandler;
using System.IO;
using System.Media;

namespace FarnaPreview
{
	public partial class FarnaPreviewControl : PreviewHandlerControl
	{
		private enum SelectedSong
		{
			None,
			MelsMeVubecRad,
			MamBokyJakoSkrin,
			TaONas
		}

		private const string MelsMeVubecRad = "MelsMeVubecRad";
		private const string MamBokyJakoSkrin = "MamBokyJakoSkrin";
		private const string TaONas = "TaONas";

		private SelectedSong selectedSong = SelectedSong.None;


		private MusicPlayer player = new MusicPlayer();

		public FarnaPreviewControl()
		{
			InitializeComponent();
		}

		public void DoPreview(string selectedFilePath)
		{
			selectedSong = GetSelectedSong(selectedFilePath);
			SetPreview();
		}

		private void SetPreview()
		{
			switch (selectedSong)
			{
				case SelectedSong.None:
					break;
				case SelectedSong.MelsMeVubecRad:
					pbPhoto.Image = Properties.Resources.MelsMeVubecRad1;
					break;
				case SelectedSong.MamBokyJakoSkrin:
					pbPhoto.Image = Properties.Resources.MamBokyJakoSkrin1;
					break;
				case SelectedSong.TaONas:
					pbPhoto.Image = Properties.Resources.TaONas1;
					break;
			}
		}

		private SelectedSong GetSelectedSong(string selectedFilePath)
		{
			if (selectedFilePath.Contains(MelsMeVubecRad))
			{
				return SelectedSong.MelsMeVubecRad;
			}
			else if (selectedFilePath.Contains(MamBokyJakoSkrin))
			{
				return SelectedSong.MamBokyJakoSkrin;
			}
			else if (selectedFilePath.Contains(TaONas))
			{
				return SelectedSong.TaONas;
			}

			return SelectedSong.None;
		}

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
			player.Stop();
			base.Dispose(disposing);
		}

		private class MusicPlayer
		{
			private bool _playing;
			private SoundPlayer player = new SoundPlayer();
			public void Play(Stream sample)
			{
				player.Stream = sample;
				player.Play();
				_playing = true;
			}

			public void Stop()
			{
				if (!_playing)
				{
					return;
				}
				try
				{
					player.Stop();
				}
				catch
				{

				}
			}
		}

		private void llblPlaySample_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				switch (selectedSong)
				{
					case SelectedSong.TaONas:
						player.Play(Properties.Resources.TaONas);
						break;
					case SelectedSong.MelsMeVubecRad:
						player.Play(Properties.Resources.MelsMeVubecRad);
						break;
					case SelectedSong.MamBokyJakoSkrin:
						player.Play(Properties.Resources.MamBokyJakoSkrin);
						break;
					default:
						break;
				}
			}
			catch
			{
			}
		}
	}
}
