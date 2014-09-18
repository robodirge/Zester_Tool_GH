using System;
using Gtk;

public partial class MainMenu: Gtk.Window
{
	public MainMenu () : base (Gtk.WindowType.Toplevel){
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a){
		Application.Quit ();
		a.RetVal = true;
	}

	public void OnZTSVB1S2Button1Clicked (object sender, EventArgs e){
		Destroy();
		Zester_Tool.NewProjectConfig NPC = new Zester_Tool.NewProjectConfig();
		//Zester_Tool.CreateConfig NC = new Zester_Tool.CreateConfig();
		NPC.Show ();
		return;
	}
}
