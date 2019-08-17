using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_DOLLARCOMPUTER
{
	public static class Program
	{
		public static SplashScreen splashscreen;
		public static StartScreen startscreen;
		public static SelectForm selectform;
		public static lblMainForm mainform;
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
	      static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			splashscreen = new SplashScreen();
			startscreen = new StartScreen();
			mainform = new lblMainForm();
			selectform = new SelectForm();


			Application.Run(splashscreen);
		}
	}
}
