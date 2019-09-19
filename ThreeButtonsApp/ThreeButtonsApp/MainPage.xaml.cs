using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ThreeButtonsApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
		public String dot = ".";
		public String dash = "-";
        public string dotndashes = "";

		void OnDotButtonClicked(object sender, EventArgs args)
		{
            Button button = (Button)sender;
            input.Text = string.Concat(input.Text, dot);
		}

		void OnDashButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;

			input.Text = string.Concat(input.Text, dash);
		}

		void OnSpaceButtonClicked(object sender, EventArgs args)
		{
			Button button = (Button)sender;
			output.Text = MorseCoder(input.Text).ToString().Trim();
            input.Text = "Input: ";

        }

		private static String[] codes = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };

		private static char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };

		public static char MorseCoder(string code)
		{
			char result = '?';
            code = code.Substring(7);
			for (int i = 0; i < codes.Length; i++)
			{
				if (codes[i].Equals(code))
				{
					result = letters[i];
					break;
				}
			}
			return result;
		}
	}
}
