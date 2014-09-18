using System;
using Gtk;
using System.IO;
using System.Configuration;

namespace Zester_Tool {

	public partial class CreateConfig : Gtk.Window {

		//Global
		string mytempfilename;
		string sDateTemp;

		public CreateConfig (string[] aContentArray, bool[] aTaskArray, bool[] aOpArray ) : base (Gtk.WindowType.Toplevel) {
			Build ();

			//Remove incorrect date chars
			sDateTemp = aContentArray[4];
			string invalid = new string(System.IO.Path.GetInvalidFileNameChars()) + new string(System.IO.Path.GetInvalidPathChars());
			foreach (char c in invalid){
				sDateTemp = sDateTemp.Replace(c.ToString(), ""); 
			}

			//Set default save location  --- >>>  enable prefences 

			//Current default location
			mytempfilename = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Documents\Zester_Tool\" + aContentArray[0] + @"\" + aContentArray[1];
			ZT_SubVBox1_TextView1.Buffer.Text = mytempfilename;
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a){
			Application.Quit ();
			a.RetVal = true;
		}

		protected void OnZTSubVBox1Button1Clicked (object sender, EventArgs e){
			Gtk.FileChooserDialog fc = new Gtk.FileChooserDialog("Choose a folder path", this, FileChooserAction.SelectFolder, "Cancel", ResponseType.Cancel, "Choose", ResponseType.Accept);

			bool btemp1 = false;
			//Set folder path
			do{
				if(fc.Run() == (int)ResponseType.Accept){
					mytempfilename = fc.CurrentFolder;

					if(mytempfilename != null){
						ZT_SubVBox1_TextView1.Buffer.Text = mytempfilename;
						fc.Destroy();
						btemp1 = true;
					}
				}else{
					btemp1 = true;
					fc.Destroy();
				}
			}while(!btemp1);
		}

		protected void OnZTSubVBox3Button2Clicked (object sender, EventArgs e){
			bool mynewloop = false;
			int myloopint = 0;

			string stempLoop = mytempfilename + @"\" + sDateTemp + @"_Config.txt";

			//Check if file already exists and change if needed. 
			do{
				if(File.Exists(stempLoop)){
					stempLoop = mytempfilename + @"\" + sDateTemp + @"_Config_V" + ++myloopint + ".txt";
				}else{
					mynewloop = true;
				}
			}while(!mynewloop);

			//Create folder path
			DirectoryInfo wd = Directory.CreateDirectory(mytempfilename);
			//Create config
			TextWriter tw = File.CreateText(stempLoop);
			//insert meta data


			tw.Close();

		}
	}
}

