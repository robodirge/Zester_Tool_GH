using System;
using Gtk;

namespace Zester_Tool{

	public partial class NewProjectConfig : Gtk.Window{

		#region Globals

		//Strings
		public static string sClientName;
		public static string sProjectName;
		public static string sUrlUsed;
		public static string sBuildVersion;
		public static string sDateTested;
		public static string sErrorLog;
		//Bools
		public static bool bUrlUsed;
		public static bool bBuildVersion;
		public static bool bNextSection;
		//int
		public static int iErrorLog;
		#endregion

		public NewProjectConfig () : base (Gtk.WindowType.Toplevel){
			Build ();

			//Assign varibles for use. 
			sClientName = "";
			sProjectName = "";
			sUrlUsed = "";
			sBuildVersion = "";
			sDateTested = DateTime.Now.ToString("dd/MM/yyyy");
			sErrorLog = "";

			bUrlUsed = false;
			bBuildVersion = false;
			bNextSection = false;

			iErrorLog = 0;

			OnLoadActions();
		}
			
		protected void OnDeleteEvent (object sender, DeleteEventArgs a){
			Application.Quit ();
			a.RetVal = true;
		}
			
		public void OnLoadActions(){
			//Section 1
			ZT_SubVBox1_Entry1.Text = sClientName;

			//Section 2
			ZT_SubVBox2_Entry1.Text = sProjectName;

			//Section 3
			ZT_SubVBox3_Radio2.Active = true;
			ZT_SubVBox3_TextView1.Sensitive = false;
			ZT_SubVBox3_Scrolled1.SetPolicy(PolicyType.Never,PolicyType.Automatic);
			ZT_SubVBox3_TextView1.Buffer.Text = sUrlUsed;

			//Section 4
			ZT_SubVBox4_Radio2.Active = true;
			ZT_SubVBox4_TextView1.Sensitive = false;
			ZT_SubVBox4_Scrolled1.SetPolicy(PolicyType.Never,PolicyType.Automatic);
			ZT_SubVBox4_TextView1.Buffer.Text = sBuildVersion;

			//Section 5
			ZT_SubVBox5_Tick1.Active = false;
			ZT_SubVBox5_Tick2.Active = false;
			ZT_SubVBox5_Tick3.Active = false;
			ZT_SubVBox5_Tick4.Active = false;
			ZT_SubVBox5_Tick5.Active = false;

			//Section 6
			ZT_SubVBox6_Tick1.Active = false;
			ZT_SubVBox6_Tick2.Active = false;
			ZT_SubVBox6_Tick3.Active = false;
			ZT_SubVBox6_Tick4.Active = false;
			ZT_SubVBox6_Tick5.Active = false;
			ZT_SubVBox6_Button1.Sensitive = false;

			//Section 7
			ZT_SubVBox7_Entry1.Text = sDateTested;

			//Section 8
			ZT_SubVBox8_Button1.Sensitive = true;
			ZT_SubVBox8_Button2.Sensitive = true;

			return;
		}

		#region ToggleSection
		protected void OnZTSubVBox3Radio1Toggled (object sender, EventArgs e){
			if(ZT_SubVBox3_Radio2.Active){
				ZT_SubVBox3_TextView1.Sensitive = false;
				bUrlUsed = false;
			}else{
				ZT_SubVBox3_TextView1.Sensitive = true;
				bUrlUsed = true;
			}
		}

		protected void OnZTSubVBox4Radio1Toggled (object sender, EventArgs e){
			if(ZT_SubVBox4_Radio2.Active){
				ZT_SubVBox4_TextView1.Sensitive = false;
				bBuildVersion = false;
			}else{
				ZT_SubVBox4_TextView1.Sensitive = true;
				bBuildVersion = true;
			}
		}
		#endregion

		//Main Menu button
		protected void OnZTSubVBox8Button1Clicked (object sender, EventArgs e){

			MessageDialog ErrorMessage = new MessageDialog(this,
				DialogFlags.Modal,
				MessageType.Warning,
				ButtonsType.YesNo, "Do you want to save your progress?");


			ErrorMessage.Title= "Warning";
			ResponseType response = (ResponseType) ErrorMessage.Run();
			if (response == ResponseType.No || response == ResponseType.DeleteEvent){
				ErrorMessage.Destroy();
			}else if(response == ResponseType.Yes){
				//Open text file.
				//Open file dialog.
				//Compute save.
				ErrorMessage.Destroy();
			}

			Destroy();
			MainMenu MM = new MainMenu();
			MM.Show ();
		}

		//Next button
		protected void OnZTSubVBox8Button2Clicked (object sender, EventArgs e){
			if(ZT_SubVBox1_Entry1.Text == ""){
				sErrorLog += ("Client name is missing.\r\n");
				iErrorLog++;
			}

			if(ZT_SubVBox2_Entry1.Text == ""){
				sErrorLog += ("Project name is missing.\r\n");
				iErrorLog++;
			}

			if((ZT_SubVBox3_Radio1.Active == true)&&(ZT_SubVBox3_TextView1.Buffer.Text == "")){
				sErrorLog += ("URL used is missing.\r\n");
				iErrorLog++;
			}

			if((ZT_SubVBox4_Radio1.Active == true)&&(ZT_SubVBox4_TextView1.Buffer.Text == "")){
				sErrorLog += ("Version/Build number is missing.\r\n");
				iErrorLog++;
			}

			if(ZT_SubVBox7_Entry1.Text == ""){
				sErrorLog += ("Please enter a date of testing.\r\n");
				iErrorLog++;
			}

			if((!ZT_SubVBox5_Tick1.Active)&&
				(!ZT_SubVBox5_Tick2.Active)&&
				(!ZT_SubVBox5_Tick3.Active)&&
				(!ZT_SubVBox5_Tick4.Active)&&
				(!ZT_SubVBox5_Tick5.Active)){
				sErrorLog += ("Please select at least 1 testing activity.\r\n");
				iErrorLog++;
			}

			if(sErrorLog != ""){
				MessageDialog ErrorMessage = new MessageDialog(this,
					DialogFlags.Modal,
					MessageType.Warning,
					ButtonsType.Ok,
					(@"Error count: " + iErrorLog + "\n\n" +sErrorLog));


				ErrorMessage.Title= "Error Log";
				ResponseType response = (ResponseType) ErrorMessage.Run();
				if (response == ResponseType.Ok || response == ResponseType.DeleteEvent){
					ErrorMessage.Destroy();
					iErrorLog = 0;
					sErrorLog = "";
				}
			}else{
				bNextSection = true;
			}

			if(bNextSection){

				//Save data to config file

				Destroy();
				Zester_Tool.EnvironmentChooser EC = new Zester_Tool.EnvironmentChooser();
				EC.Show ();
			}
			//Launch environment chooser section
		}
	}
}

