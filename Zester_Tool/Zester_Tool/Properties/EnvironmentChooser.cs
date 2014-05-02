using System;
using Gtk;
using System.Data;
using MySql.Data.MySqlClient;

namespace Zester_Tool
{
	public partial class EnvironmentChooser : Gtk.Window
	{
		Gtk.ListStore LS_EnvironTree;
		Gtk.TreeViewColumn TVC_EnvironTree_Col1;
		Gtk.TreeViewColumn TVC_EnvironTree_Col2;

		public EnvironmentChooser () : 
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();

			EnviroTreeSetup();
			//EnviroSQL();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a){
			Application.Quit ();
			a.RetVal = true;
		}

		public void EnviroTreeSetup(){
			LS_EnvironTree = new Gtk.ListStore(typeof(string), typeof(string));

			Gtk.CellRendererText Data1_cell = new Gtk.CellRendererText();
			TVC_EnvironTree_Col1 = new Gtk.TreeViewColumn("Full Name", Data1_cell, 0);
			TVC_EnvironTree_Col1.FixedWidth = 150;
			TVC_EnvironTree_Col1.Expand = true;

			Gtk.CellRendererText Data2_cell = new Gtk.CellRendererText();
			TVC_EnvironTree_Col2 = new Gtk.TreeViewColumn("Short Name", Data2_cell, 0);
			TVC_EnvironTree_Col2.FixedWidth = 150;
			TVC_EnvironTree_Col2.Expand = true;

			EnvironTree_Main.AppendColumn(TVC_EnvironTree_Col1);
			EnvironTree_Main.AppendColumn(TVC_EnvironTree_Col2);

			TVC_EnvironTree_Col1.AddAttribute(Data1_cell, "text", 0);
			TVC_EnvironTree_Col2.AddAttribute(Data2_cell, "text", 1);

			//LS_EnvironTree.AppendValues("SomeText", "SomeOtherText");

			EnvironTree_Main.Model = LS_EnvironTree;
			return;
		}

		public void EnviroSQL(){
			MySqlConnectionStringBuilder sqlBuilder;
			sqlBuilder = new MySqlConnectionStringBuilder();
			sqlBuilder.ConnectionString = "Server=127.0.0.1; Port=3306; Database=device_collections; Uid=test;" + "Pwd=r3n4ult; ";
			//Console.WriteLine(sqlBuilder.ConnectionString);

			try{
				MySqlConnection connection = new MySqlConnection(sqlBuilder.ConnectionString);
				connection.Open();
				MySqlDataReader myReader = null;
				//MySqlCommand myCommand = new MySqlCommand("select * from devices", connection);
				//MySqlCommand myCommand = new MySqlCommand("SELECT Full_Name FROM manufacturer LEFT join devices ON manufacturer.Man_ID=devices.Man_ID WHERE devices.Man_ID = 1", connection);
				//MySqlCommand myCommand = new MySqlCommand("sp1", connection);
				MySqlCommand myCommand = new MySqlCommand("sp2", connection);
				myCommand.CommandType = CommandType.StoredProcedure;
				myCommand.Parameters.AddWithValue("var1", 1);

				myReader = myCommand.ExecuteReader();

				while(myReader.Read()){
					//Console.WriteLine("Man_ID: " + myReader["Man_ID"].ToString());
					//Console.WriteLine("OS_V_ID: " + myReader["OS_V_ID"].ToString());
					//LS_EnvironTree.AppendValues(myReader["Man_ID"].ToString());
					//LS_EnvironTree.AppendValues(myReader["Full_Name"].ToString());

				}

				EnvironTree_Main.Model = LS_EnvironTree;
				connection.Close();
			}
			catch(Exception e){
				Console.WriteLine(e.ToString());
			}
		}

		protected void OnButton1Clicked (object sender, EventArgs e){
			//Submit search
			label1.Text = "Checking...";
			LS_EnvironTree.Clear();

			MySqlConnectionStringBuilder sqlBuilder;
			sqlBuilder = new MySqlConnectionStringBuilder();
			sqlBuilder.ConnectionString = "Server=127.0.0.1; Port=3306; Database=device_collections; Uid=test;" + "Pwd=r3n4ult; ";

			bool btest = false;

			try{
				MySqlConnection connection = new MySqlConnection(sqlBuilder.ConnectionString);
				connection.Open();
				MySqlDataReader myReader = null;
				MySqlCommand myCommand = new MySqlCommand("sp3", connection);
				myCommand.CommandType = CommandType.StoredProcedure;

				myCommand.Parameters.AddWithValue("var1", entry1.Text);

				myReader = myCommand.ExecuteReader();
				while(myReader.Read()){
					Console.WriteLine(myReader["Full_Name"].ToString());
					Console.WriteLine(myReader["Short_Name"].ToString());
					//LS_EnvironTree.AppendValues(myReader["Man_ID"].ToString());
					LS_EnvironTree.AppendValues(myReader["Full_Name"].ToString(), myReader["Short_Name"].ToString());
					btest = true;
				}

				if(btest){
					label1.Text = "Results found";
					Console.WriteLine("Results found");
				}else{
					label1.Text = "No Results found";
					Console.WriteLine("No Results found");
				}

				//connection.Close();

				EnvironTree_Main.Model = LS_EnvironTree;
			}
			catch(Exception a){
				Console.WriteLine(a.ToString());
			}


		}
	}
}

