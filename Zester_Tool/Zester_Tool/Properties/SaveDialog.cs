using System;
using Gtk;

namespace Zester_Tool{

	public partial class SaveDialog : Gtk.Window{

		public SaveDialog () :
			base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}
	}
}

