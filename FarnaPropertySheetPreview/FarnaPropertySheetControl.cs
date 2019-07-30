using SharpShell.SharpPropertySheet;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FarnaPreview
{
	public partial class FarnaPropertySheetControl : SharpPropertyPage
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
		private string url = string.Empty;

		private string filePath = "";
		public FarnaPropertySheetControl()
		{
			InitializeComponent();

			PageTitle = "Ewicka";
			PageIcon = FarnaPropertySheetPreview.Properties.Resources.image823;
		}

		public void Init()
		{
			InitPage();
			SetUrl(GetSelectedSong(MelsMeVubecRad));
		}

		protected override void OnPropertyPageInitialised(SharpPropertySheet parent)
		{
			filePath = parent.SelectedItemPaths.FirstOrDefault();
			if(filePath == null)
			{
				return;
			}
			InitPage();
			SetUrl(GetSelectedSong(filePath));
		}

		private void SetUrl(SelectedSong selectedSong)
		{
			if (selectedSong == SelectedSong.None)
			{
				return;
			}

			url = GetSelectedSongUrl(selectedSong);
		}

		private string GetSelectedSongUrl(SelectedSong selectedSong)
		{
			var baseUrl = "https://open.spotify.com/search/results/";

			switch (selectedSong)
			{
				case SelectedSong.None:
					return string.Empty;
				case SelectedSong.MelsMeVubecRad:
					return baseUrl + "mels%20me%20vubec%20rad";
				case SelectedSong.MamBokyJakoSkrin:
					return baseUrl + "mam%20boky%20jako%20skrin";
				case SelectedSong.TaONas:
					return baseUrl + "ta%20o%20nas";
			}

			return string.Empty;
		}

		private void InitPage()
		{
			lblTitleValue.Text = filePath;
			rtbInfo.Text = "Ewa Farna (* 12. srpna 1993 Třinec) je zpěvačka polsko-české národnosti. Působí v oblasti populární a rockové hudby, zpívá česky a polsky, v Česku i v Polsku. Pochází z české části Těšínska, žije ve Vendryni.Za svou kariéru získala řadu českých i polských ocenění. ";
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

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (url == string.Empty)
			{
				return;
			}
			llblSpotify.LinkVisited = true;
			Process.Start(url);
		}
	}
}
