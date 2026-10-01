using System;
using System.Windows.Forms;

namespace Odnawialne_Źródła_Energii;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new Start());
	}
}
