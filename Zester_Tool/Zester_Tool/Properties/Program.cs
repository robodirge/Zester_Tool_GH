using System;
using Gtk;

namespace Zester_Tool
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainMenu win = new MainMenu ();
			win.Show ();
			Application.Run ();
		}
	}
}
