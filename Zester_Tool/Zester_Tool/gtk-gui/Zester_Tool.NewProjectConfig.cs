
// This file has been generated by the GUI designer. Do not modify.
namespace Zester_Tool
{
	public partial class NewProjectConfig
	{
		private global::Gtk.VBox ZT_MainVBox1;
		private global::Gtk.VBox ZT_SubVBox1;
		private global::Gtk.Label ZT_SubVBox1_Label1;
		private global::Gtk.Entry ZT_SubVBox1_Entry1;
		private global::Gtk.VBox ZT_SubVBox2;
		private global::Gtk.Label ZT_SubVBox2_Label1;
		private global::Gtk.Entry ZT_SubVBox2_Entry1;
		private global::Gtk.VBox ZT_SubVBox3;
		private global::Gtk.HBox ZT_SubVBox3_HBox1;
		private global::Gtk.Label ZT_SubVBox3_Label1;
		private global::Gtk.RadioButton ZT_SubVBox3_Radio1;
		private global::Gtk.RadioButton ZT_SubVBox3_Radio2;
		private global::Gtk.ScrolledWindow ZT_SubVBox3_Scrolled1;
		private global::Gtk.TextView ZT_SubVBox3_TextView1;
		private global::Gtk.VBox ZT_SubVBox4;
		private global::Gtk.HBox ZT_SubVBox4_HBox1;
		private global::Gtk.Label ZT_SubVBox4_Label1;
		private global::Gtk.RadioButton ZT_SubVBox4_Radio1;
		private global::Gtk.RadioButton ZT_SubVBox4_Radio2;
		private global::Gtk.ScrolledWindow ZT_SubVBox4_Scrolled1;
		private global::Gtk.TextView ZT_SubVBox4_TextView1;
		private global::Gtk.VBox ZT_SubVBox5;
		private global::Gtk.Label ZT_SubVBox5_Label1;
		private global::Gtk.HBox ZT_SubVBox5_HBox1;
		private global::Gtk.CheckButton ZT_SubVBox5_Tick1;
		private global::Gtk.CheckButton ZT_SubVBox5_Tick2;
		private global::Gtk.CheckButton ZT_SubVBox5_Tick3;
		private global::Gtk.HBox ZT_SubVBox5_HBox2;
		private global::Gtk.CheckButton ZT_SubVBox5_Tick4;
		private global::Gtk.CheckButton ZT_SubVBox5_Tick5;
		private global::Gtk.VBox ZT_SubVBox6;
		private global::Gtk.Label ZT_SubVBox6_Label1;
		private global::Gtk.HBox ZT_SubVBox6_HBox1;
		private global::Gtk.CheckButton ZT_SubVBox6_Tick1;
		private global::Gtk.CheckButton ZT_SubVBox6_Tick2;
		private global::Gtk.CheckButton ZT_SubVBox6_Tick3;
		private global::Gtk.HBox ZT_SubVBox6_HBox2;
		private global::Gtk.CheckButton ZT_SubVBox6_Tick4;
		private global::Gtk.CheckButton ZT_SubVBox6_Tick5;
		private global::Gtk.Button ZT_SubVBox6_Button1;
		private global::Gtk.VBox ZT_SubVBox7;
		private global::Gtk.Label ZT_SubVBox7_Label1;
		private global::Gtk.Entry ZT_SubVBox7_Entry1;
		private global::Gtk.VBox ZT_SubVBox8;
		private global::Gtk.HBox ZT_SubVBox7_HBox1;
		private global::Gtk.Button ZT_SubVBox8_Button1;
		private global::Gtk.HSeparator ZT_SubVBox8_Separator1;
		private global::Gtk.Button ZT_SubVBox8_Button2;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Zester_Tool.NewProjectConfig
			this.WidthRequest = 600;
			this.HeightRequest = 650;
			this.Name = "Zester_Tool.NewProjectConfig";
			this.Title = global::Mono.Unix.Catalog.GetString ("Zester Tool : New Project Config");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-preferences", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(5));
			this.Resizable = false;
			this.AllowShrink = true;
			this.DestroyWithParent = true;
			// Container child Zester_Tool.NewProjectConfig.Gtk.Container+ContainerChild
			this.ZT_MainVBox1 = new global::Gtk.VBox ();
			this.ZT_MainVBox1.Name = "ZT_MainVBox1";
			this.ZT_MainVBox1.Spacing = 6;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox1 = new global::Gtk.VBox ();
			this.ZT_SubVBox1.Name = "ZT_SubVBox1";
			this.ZT_SubVBox1.Spacing = 6;
			// Container child ZT_SubVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox1_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox1_Label1.Name = "ZT_SubVBox1_Label1";
			this.ZT_SubVBox1_Label1.Xalign = 0.02F;
			this.ZT_SubVBox1_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("*Client name:");
			this.ZT_SubVBox1.Add (this.ZT_SubVBox1_Label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox1 [this.ZT_SubVBox1_Label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child ZT_SubVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox1_Entry1 = new global::Gtk.Entry ();
			this.ZT_SubVBox1_Entry1.CanFocus = true;
			this.ZT_SubVBox1_Entry1.Name = "ZT_SubVBox1_Entry1";
			this.ZT_SubVBox1_Entry1.IsEditable = true;
			this.ZT_SubVBox1_Entry1.InvisibleChar = '●';
			this.ZT_SubVBox1.Add (this.ZT_SubVBox1_Entry1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox1 [this.ZT_SubVBox1_Entry1]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox2 = new global::Gtk.VBox ();
			this.ZT_SubVBox2.Name = "ZT_SubVBox2";
			this.ZT_SubVBox2.Spacing = 6;
			// Container child ZT_SubVBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox2_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox2_Label1.Name = "ZT_SubVBox2_Label1";
			this.ZT_SubVBox2_Label1.Xalign = 0.02F;
			this.ZT_SubVBox2_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("*Project name:");
			this.ZT_SubVBox2.Add (this.ZT_SubVBox2_Label1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox2 [this.ZT_SubVBox2_Label1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child ZT_SubVBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox2_Entry1 = new global::Gtk.Entry ();
			this.ZT_SubVBox2_Entry1.CanFocus = true;
			this.ZT_SubVBox2_Entry1.Name = "ZT_SubVBox2_Entry1";
			this.ZT_SubVBox2_Entry1.IsEditable = true;
			this.ZT_SubVBox2_Entry1.InvisibleChar = '●';
			this.ZT_SubVBox2.Add (this.ZT_SubVBox2_Entry1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox2 [this.ZT_SubVBox2_Entry1]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox2]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox3 = new global::Gtk.VBox ();
			this.ZT_SubVBox3.Name = "ZT_SubVBox3";
			this.ZT_SubVBox3.Spacing = 6;
			// Container child ZT_SubVBox3.Gtk.Box+BoxChild
			this.ZT_SubVBox3_HBox1 = new global::Gtk.HBox ();
			this.ZT_SubVBox3_HBox1.Name = "ZT_SubVBox3_HBox1";
			this.ZT_SubVBox3_HBox1.Spacing = 6;
			// Container child ZT_SubVBox3_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox3_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox3_Label1.WidthRequest = 300;
			this.ZT_SubVBox3_Label1.Name = "ZT_SubVBox3_Label1";
			this.ZT_SubVBox3_Label1.Xalign = 0.07F;
			this.ZT_SubVBox3_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("*Was a URL used for testing?");
			this.ZT_SubVBox3_HBox1.Add (this.ZT_SubVBox3_Label1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox3_HBox1 [this.ZT_SubVBox3_Label1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child ZT_SubVBox3_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox3_Radio1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Yes"));
			this.ZT_SubVBox3_Radio1.CanFocus = true;
			this.ZT_SubVBox3_Radio1.Name = "ZT_SubVBox3_Radio1";
			this.ZT_SubVBox3_Radio1.DrawIndicator = true;
			this.ZT_SubVBox3_Radio1.UseUnderline = true;
			this.ZT_SubVBox3_Radio1.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.ZT_SubVBox3_HBox1.Add (this.ZT_SubVBox3_Radio1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox3_HBox1 [this.ZT_SubVBox3_Radio1]));
			w8.Position = 1;
			// Container child ZT_SubVBox3_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox3_Radio2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("No"));
			this.ZT_SubVBox3_Radio2.CanFocus = true;
			this.ZT_SubVBox3_Radio2.Name = "ZT_SubVBox3_Radio2";
			this.ZT_SubVBox3_Radio2.DrawIndicator = true;
			this.ZT_SubVBox3_Radio2.UseUnderline = true;
			this.ZT_SubVBox3_Radio2.Group = this.ZT_SubVBox3_Radio1.Group;
			this.ZT_SubVBox3_HBox1.Add (this.ZT_SubVBox3_Radio2);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox3_HBox1 [this.ZT_SubVBox3_Radio2]));
			w9.Position = 2;
			this.ZT_SubVBox3.Add (this.ZT_SubVBox3_HBox1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox3 [this.ZT_SubVBox3_HBox1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child ZT_SubVBox3.Gtk.Box+BoxChild
			this.ZT_SubVBox3_Scrolled1 = new global::Gtk.ScrolledWindow ();
			this.ZT_SubVBox3_Scrolled1.HeightRequest = 75;
			this.ZT_SubVBox3_Scrolled1.Name = "ZT_SubVBox3_Scrolled1";
			this.ZT_SubVBox3_Scrolled1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.ZT_SubVBox3_Scrolled1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child ZT_SubVBox3_Scrolled1.Gtk.Container+ContainerChild
			this.ZT_SubVBox3_TextView1 = new global::Gtk.TextView ();
			this.ZT_SubVBox3_TextView1.CanFocus = true;
			this.ZT_SubVBox3_TextView1.Name = "ZT_SubVBox3_TextView1";
			this.ZT_SubVBox3_TextView1.AcceptsTab = false;
			this.ZT_SubVBox3_TextView1.WrapMode = ((global::Gtk.WrapMode)(1));
			this.ZT_SubVBox3_Scrolled1.Add (this.ZT_SubVBox3_TextView1);
			this.ZT_SubVBox3.Add (this.ZT_SubVBox3_Scrolled1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox3 [this.ZT_SubVBox3_Scrolled1]));
			w12.Position = 1;
			w12.Expand = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox3);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox3]));
			w13.Position = 2;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox4 = new global::Gtk.VBox ();
			this.ZT_SubVBox4.Name = "ZT_SubVBox4";
			this.ZT_SubVBox4.Spacing = 6;
			// Container child ZT_SubVBox4.Gtk.Box+BoxChild
			this.ZT_SubVBox4_HBox1 = new global::Gtk.HBox ();
			this.ZT_SubVBox4_HBox1.Name = "ZT_SubVBox4_HBox1";
			this.ZT_SubVBox4_HBox1.Spacing = 6;
			// Container child ZT_SubVBox4_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox4_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox4_Label1.WidthRequest = 300;
			this.ZT_SubVBox4_Label1.Name = "ZT_SubVBox4_Label1";
			this.ZT_SubVBox4_Label1.Xalign = 0.1F;
			this.ZT_SubVBox4_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("*Is a build / version number avalible?");
			this.ZT_SubVBox4_HBox1.Add (this.ZT_SubVBox4_Label1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox4_HBox1 [this.ZT_SubVBox4_Label1]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child ZT_SubVBox4_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox4_Radio1 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Yes"));
			this.ZT_SubVBox4_Radio1.CanFocus = true;
			this.ZT_SubVBox4_Radio1.Name = "ZT_SubVBox4_Radio1";
			this.ZT_SubVBox4_Radio1.DrawIndicator = true;
			this.ZT_SubVBox4_Radio1.UseUnderline = true;
			this.ZT_SubVBox4_Radio1.Group = new global::GLib.SList (global::System.IntPtr.Zero);
			this.ZT_SubVBox4_HBox1.Add (this.ZT_SubVBox4_Radio1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox4_HBox1 [this.ZT_SubVBox4_Radio1]));
			w15.Position = 1;
			// Container child ZT_SubVBox4_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox4_Radio2 = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("No"));
			this.ZT_SubVBox4_Radio2.CanFocus = true;
			this.ZT_SubVBox4_Radio2.Name = "ZT_SubVBox4_Radio2";
			this.ZT_SubVBox4_Radio2.DrawIndicator = true;
			this.ZT_SubVBox4_Radio2.UseUnderline = true;
			this.ZT_SubVBox4_Radio2.Group = this.ZT_SubVBox4_Radio1.Group;
			this.ZT_SubVBox4_HBox1.Add (this.ZT_SubVBox4_Radio2);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox4_HBox1 [this.ZT_SubVBox4_Radio2]));
			w16.Position = 2;
			this.ZT_SubVBox4.Add (this.ZT_SubVBox4_HBox1);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox4 [this.ZT_SubVBox4_HBox1]));
			w17.Position = 0;
			w17.Expand = false;
			w17.Fill = false;
			// Container child ZT_SubVBox4.Gtk.Box+BoxChild
			this.ZT_SubVBox4_Scrolled1 = new global::Gtk.ScrolledWindow ();
			this.ZT_SubVBox4_Scrolled1.HeightRequest = 75;
			this.ZT_SubVBox4_Scrolled1.Name = "ZT_SubVBox4_Scrolled1";
			this.ZT_SubVBox4_Scrolled1.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.ZT_SubVBox4_Scrolled1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child ZT_SubVBox4_Scrolled1.Gtk.Container+ContainerChild
			this.ZT_SubVBox4_TextView1 = new global::Gtk.TextView ();
			this.ZT_SubVBox4_TextView1.CanFocus = true;
			this.ZT_SubVBox4_TextView1.Name = "ZT_SubVBox4_TextView1";
			this.ZT_SubVBox4_TextView1.AcceptsTab = false;
			this.ZT_SubVBox4_TextView1.WrapMode = ((global::Gtk.WrapMode)(1));
			this.ZT_SubVBox4_Scrolled1.Add (this.ZT_SubVBox4_TextView1);
			this.ZT_SubVBox4.Add (this.ZT_SubVBox4_Scrolled1);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox4 [this.ZT_SubVBox4_Scrolled1]));
			w19.Position = 1;
			w19.Expand = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox4);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox4]));
			w20.Position = 3;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox5 = new global::Gtk.VBox ();
			this.ZT_SubVBox5.Name = "ZT_SubVBox5";
			this.ZT_SubVBox5.Spacing = 6;
			// Container child ZT_SubVBox5.Gtk.Box+BoxChild
			this.ZT_SubVBox5_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox5_Label1.HeightRequest = 30;
			this.ZT_SubVBox5_Label1.Name = "ZT_SubVBox5_Label1";
			this.ZT_SubVBox5_Label1.Xalign = 0.02F;
			this.ZT_SubVBox5_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("*Testing tasks");
			this.ZT_SubVBox5.Add (this.ZT_SubVBox5_Label1);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5 [this.ZT_SubVBox5_Label1]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child ZT_SubVBox5.Gtk.Box+BoxChild
			this.ZT_SubVBox5_HBox1 = new global::Gtk.HBox ();
			this.ZT_SubVBox5_HBox1.Name = "ZT_SubVBox5_HBox1";
			this.ZT_SubVBox5_HBox1.Spacing = 6;
			// Container child ZT_SubVBox5_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox5_Tick1 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox5_Tick1.CanFocus = true;
			this.ZT_SubVBox5_Tick1.Name = "ZT_SubVBox5_Tick1";
			this.ZT_SubVBox5_Tick1.Label = global::Mono.Unix.Catalog.GetString ("Scripting / Planning?");
			this.ZT_SubVBox5_Tick1.DrawIndicator = true;
			this.ZT_SubVBox5_Tick1.UseUnderline = true;
			this.ZT_SubVBox5_HBox1.Add (this.ZT_SubVBox5_Tick1);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5_HBox1 [this.ZT_SubVBox5_Tick1]));
			w22.Position = 0;
			// Container child ZT_SubVBox5_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox5_Tick2 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox5_Tick2.CanFocus = true;
			this.ZT_SubVBox5_Tick2.Name = "ZT_SubVBox5_Tick2";
			this.ZT_SubVBox5_Tick2.Label = global::Mono.Unix.Catalog.GetString ("Cross environments?");
			this.ZT_SubVBox5_Tick2.DrawIndicator = true;
			this.ZT_SubVBox5_Tick2.UseUnderline = true;
			this.ZT_SubVBox5_HBox1.Add (this.ZT_SubVBox5_Tick2);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5_HBox1 [this.ZT_SubVBox5_Tick2]));
			w23.Position = 1;
			// Container child ZT_SubVBox5_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox5_Tick3 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox5_Tick3.CanFocus = true;
			this.ZT_SubVBox5_Tick3.Name = "ZT_SubVBox5_Tick3";
			this.ZT_SubVBox5_Tick3.Label = global::Mono.Unix.Catalog.GetString ("Test execution?");
			this.ZT_SubVBox5_Tick3.DrawIndicator = true;
			this.ZT_SubVBox5_Tick3.UseUnderline = true;
			this.ZT_SubVBox5_HBox1.Add (this.ZT_SubVBox5_Tick3);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5_HBox1 [this.ZT_SubVBox5_Tick3]));
			w24.Position = 2;
			this.ZT_SubVBox5.Add (this.ZT_SubVBox5_HBox1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5 [this.ZT_SubVBox5_HBox1]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			// Container child ZT_SubVBox5.Gtk.Box+BoxChild
			this.ZT_SubVBox5_HBox2 = new global::Gtk.HBox ();
			this.ZT_SubVBox5_HBox2.Name = "ZT_SubVBox5_HBox2";
			this.ZT_SubVBox5_HBox2.Spacing = 6;
			// Container child ZT_SubVBox5_HBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox5_Tick4 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox5_Tick4.WidthRequest = 202;
			this.ZT_SubVBox5_Tick4.CanFocus = true;
			this.ZT_SubVBox5_Tick4.Name = "ZT_SubVBox5_Tick4";
			this.ZT_SubVBox5_Tick4.Label = global::Mono.Unix.Catalog.GetString ("Retests / IVs?");
			this.ZT_SubVBox5_Tick4.DrawIndicator = true;
			this.ZT_SubVBox5_Tick4.UseUnderline = true;
			this.ZT_SubVBox5_HBox2.Add (this.ZT_SubVBox5_Tick4);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5_HBox2 [this.ZT_SubVBox5_Tick4]));
			w26.Position = 0;
			w26.Expand = false;
			// Container child ZT_SubVBox5_HBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox5_Tick5 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox5_Tick5.CanFocus = true;
			this.ZT_SubVBox5_Tick5.Name = "ZT_SubVBox5_Tick5";
			this.ZT_SubVBox5_Tick5.Label = global::Mono.Unix.Catalog.GetString ("Test support?");
			this.ZT_SubVBox5_Tick5.DrawIndicator = true;
			this.ZT_SubVBox5_Tick5.UseUnderline = true;
			this.ZT_SubVBox5_HBox2.Add (this.ZT_SubVBox5_Tick5);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5_HBox2 [this.ZT_SubVBox5_Tick5]));
			w27.Position = 1;
			this.ZT_SubVBox5.Add (this.ZT_SubVBox5_HBox2);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox5 [this.ZT_SubVBox5_HBox2]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox5);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox5]));
			w29.Position = 4;
			w29.Expand = false;
			w29.Fill = false;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox6 = new global::Gtk.VBox ();
			this.ZT_SubVBox6.Name = "ZT_SubVBox6";
			this.ZT_SubVBox6.Spacing = 6;
			// Container child ZT_SubVBox6.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox6_Label1.HeightRequest = 30;
			this.ZT_SubVBox6_Label1.Name = "ZT_SubVBox6_Label1";
			this.ZT_SubVBox6_Label1.Xalign = 0.02F;
			this.ZT_SubVBox6_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Create (optional)");
			this.ZT_SubVBox6.Add (this.ZT_SubVBox6_Label1);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6 [this.ZT_SubVBox6_Label1]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			// Container child ZT_SubVBox6.Gtk.Box+BoxChild
			this.ZT_SubVBox6_HBox1 = new global::Gtk.HBox ();
			this.ZT_SubVBox6_HBox1.Name = "ZT_SubVBox6_HBox1";
			this.ZT_SubVBox6_HBox1.Spacing = 6;
			// Container child ZT_SubVBox6_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Tick1 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox6_Tick1.CanFocus = true;
			this.ZT_SubVBox6_Tick1.Name = "ZT_SubVBox6_Tick1";
			this.ZT_SubVBox6_Tick1.Label = global::Mono.Unix.Catalog.GetString ("Full scripted plan");
			this.ZT_SubVBox6_Tick1.DrawIndicator = true;
			this.ZT_SubVBox6_Tick1.UseUnderline = true;
			this.ZT_SubVBox6_HBox1.Add (this.ZT_SubVBox6_Tick1);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6_HBox1 [this.ZT_SubVBox6_Tick1]));
			w31.Position = 0;
			// Container child ZT_SubVBox6_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Tick2 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox6_Tick2.CanFocus = true;
			this.ZT_SubVBox6_Tick2.Name = "ZT_SubVBox6_Tick2";
			this.ZT_SubVBox6_Tick2.Label = global::Mono.Unix.Catalog.GetString ("Scripted plan");
			this.ZT_SubVBox6_Tick2.DrawIndicator = true;
			this.ZT_SubVBox6_Tick2.UseUnderline = true;
			this.ZT_SubVBox6_HBox1.Add (this.ZT_SubVBox6_Tick2);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6_HBox1 [this.ZT_SubVBox6_Tick2]));
			w32.Position = 1;
			// Container child ZT_SubVBox6_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Tick3 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox6_Tick3.CanFocus = true;
			this.ZT_SubVBox6_Tick3.Name = "ZT_SubVBox6_Tick3";
			this.ZT_SubVBox6_Tick3.Label = global::Mono.Unix.Catalog.GetString ("Exploratory plan");
			this.ZT_SubVBox6_Tick3.DrawIndicator = true;
			this.ZT_SubVBox6_Tick3.UseUnderline = true;
			this.ZT_SubVBox6_HBox1.Add (this.ZT_SubVBox6_Tick3);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6_HBox1 [this.ZT_SubVBox6_Tick3]));
			w33.Position = 2;
			this.ZT_SubVBox6.Add (this.ZT_SubVBox6_HBox1);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6 [this.ZT_SubVBox6_HBox1]));
			w34.Position = 1;
			w34.Expand = false;
			w34.Fill = false;
			// Container child ZT_SubVBox6.Gtk.Box+BoxChild
			this.ZT_SubVBox6_HBox2 = new global::Gtk.HBox ();
			this.ZT_SubVBox6_HBox2.Name = "ZT_SubVBox6_HBox2";
			this.ZT_SubVBox6_HBox2.Spacing = 6;
			// Container child ZT_SubVBox6_HBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Tick4 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox6_Tick4.WidthRequest = 106;
			this.ZT_SubVBox6_Tick4.CanFocus = true;
			this.ZT_SubVBox6_Tick4.Name = "ZT_SubVBox6_Tick4";
			this.ZT_SubVBox6_Tick4.Label = global::Mono.Unix.Catalog.GetString ("Ticket report template");
			this.ZT_SubVBox6_Tick4.DrawIndicator = true;
			this.ZT_SubVBox6_Tick4.UseUnderline = true;
			this.ZT_SubVBox6_HBox2.Add (this.ZT_SubVBox6_Tick4);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6_HBox2 [this.ZT_SubVBox6_Tick4]));
			w35.Position = 0;
			// Container child ZT_SubVBox6_HBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Tick5 = new global::Gtk.CheckButton ();
			this.ZT_SubVBox6_Tick5.CanFocus = true;
			this.ZT_SubVBox6_Tick5.Name = "ZT_SubVBox6_Tick5";
			this.ZT_SubVBox6_Tick5.Label = global::Mono.Unix.Catalog.GetString ("Folder tree");
			this.ZT_SubVBox6_Tick5.DrawIndicator = true;
			this.ZT_SubVBox6_Tick5.UseUnderline = true;
			this.ZT_SubVBox6_HBox2.Add (this.ZT_SubVBox6_Tick5);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6_HBox2 [this.ZT_SubVBox6_Tick5]));
			w36.Position = 1;
			// Container child ZT_SubVBox6_HBox2.Gtk.Box+BoxChild
			this.ZT_SubVBox6_Button1 = new global::Gtk.Button ();
			this.ZT_SubVBox6_Button1.WidthRequest = 100;
			this.ZT_SubVBox6_Button1.Sensitive = false;
			this.ZT_SubVBox6_Button1.CanFocus = true;
			this.ZT_SubVBox6_Button1.Name = "ZT_SubVBox6_Button1";
			this.ZT_SubVBox6_Button1.UseUnderline = true;
			this.ZT_SubVBox6_Button1.Label = global::Mono.Unix.Catalog.GetString ("Folder tree editor");
			this.ZT_SubVBox6_HBox2.Add (this.ZT_SubVBox6_Button1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6_HBox2 [this.ZT_SubVBox6_Button1]));
			w37.Position = 2;
			this.ZT_SubVBox6.Add (this.ZT_SubVBox6_HBox2);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox6 [this.ZT_SubVBox6_HBox2]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox6);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox6]));
			w39.Position = 5;
			w39.Expand = false;
			w39.Fill = false;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox7 = new global::Gtk.VBox ();
			this.ZT_SubVBox7.Name = "ZT_SubVBox7";
			this.ZT_SubVBox7.Spacing = 6;
			// Container child ZT_SubVBox7.Gtk.Box+BoxChild
			this.ZT_SubVBox7_Label1 = new global::Gtk.Label ();
			this.ZT_SubVBox7_Label1.HeightRequest = 30;
			this.ZT_SubVBox7_Label1.Name = "ZT_SubVBox7_Label1";
			this.ZT_SubVBox7_Label1.Xalign = 0.02F;
			this.ZT_SubVBox7_Label1.LabelProp = global::Mono.Unix.Catalog.GetString ("*Date Tested");
			this.ZT_SubVBox7.Add (this.ZT_SubVBox7_Label1);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox7 [this.ZT_SubVBox7_Label1]));
			w40.Position = 0;
			w40.Expand = false;
			w40.Fill = false;
			// Container child ZT_SubVBox7.Gtk.Box+BoxChild
			this.ZT_SubVBox7_Entry1 = new global::Gtk.Entry ();
			this.ZT_SubVBox7_Entry1.CanFocus = true;
			this.ZT_SubVBox7_Entry1.Name = "ZT_SubVBox7_Entry1";
			this.ZT_SubVBox7_Entry1.IsEditable = true;
			this.ZT_SubVBox7_Entry1.InvisibleChar = '●';
			this.ZT_SubVBox7.Add (this.ZT_SubVBox7_Entry1);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox7 [this.ZT_SubVBox7_Entry1]));
			w41.Position = 1;
			w41.Expand = false;
			w41.Fill = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox7);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox7]));
			w42.Position = 6;
			w42.Expand = false;
			w42.Fill = false;
			// Container child ZT_MainVBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox8 = new global::Gtk.VBox ();
			this.ZT_SubVBox8.Name = "ZT_SubVBox8";
			this.ZT_SubVBox8.Spacing = 6;
			// Container child ZT_SubVBox8.Gtk.Box+BoxChild
			this.ZT_SubVBox7_HBox1 = new global::Gtk.HBox ();
			this.ZT_SubVBox7_HBox1.Name = "ZT_SubVBox7_HBox1";
			this.ZT_SubVBox7_HBox1.Spacing = 6;
			// Container child ZT_SubVBox7_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox8_Button1 = new global::Gtk.Button ();
			this.ZT_SubVBox8_Button1.WidthRequest = 100;
			this.ZT_SubVBox8_Button1.CanFocus = true;
			this.ZT_SubVBox8_Button1.Name = "ZT_SubVBox8_Button1";
			this.ZT_SubVBox8_Button1.UseUnderline = true;
			this.ZT_SubVBox8_Button1.Label = global::Mono.Unix.Catalog.GetString ("Main Menu");
			this.ZT_SubVBox7_HBox1.Add (this.ZT_SubVBox8_Button1);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox7_HBox1 [this.ZT_SubVBox8_Button1]));
			w43.Position = 0;
			w43.Expand = false;
			w43.Fill = false;
			// Container child ZT_SubVBox7_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox8_Separator1 = new global::Gtk.HSeparator ();
			this.ZT_SubVBox8_Separator1.Name = "ZT_SubVBox8_Separator1";
			this.ZT_SubVBox7_HBox1.Add (this.ZT_SubVBox8_Separator1);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox7_HBox1 [this.ZT_SubVBox8_Separator1]));
			w44.Position = 1;
			// Container child ZT_SubVBox7_HBox1.Gtk.Box+BoxChild
			this.ZT_SubVBox8_Button2 = new global::Gtk.Button ();
			this.ZT_SubVBox8_Button2.WidthRequest = 100;
			this.ZT_SubVBox8_Button2.CanFocus = true;
			this.ZT_SubVBox8_Button2.Name = "ZT_SubVBox8_Button2";
			this.ZT_SubVBox8_Button2.UseUnderline = true;
			this.ZT_SubVBox8_Button2.Label = global::Mono.Unix.Catalog.GetString ("Next");
			this.ZT_SubVBox7_HBox1.Add (this.ZT_SubVBox8_Button2);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox7_HBox1 [this.ZT_SubVBox8_Button2]));
			w45.Position = 2;
			w45.Expand = false;
			w45.Fill = false;
			this.ZT_SubVBox8.Add (this.ZT_SubVBox7_HBox1);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.ZT_SubVBox8 [this.ZT_SubVBox7_HBox1]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			this.ZT_MainVBox1.Add (this.ZT_SubVBox8);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.ZT_MainVBox1 [this.ZT_SubVBox8]));
			w47.Position = 7;
			w47.Expand = false;
			w47.Fill = false;
			this.Add (this.ZT_MainVBox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 600;
			this.DefaultHeight = 650;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.ZT_SubVBox3_Radio1.Toggled += new global::System.EventHandler (this.OnZTSubVBox3Radio1Toggled);
			this.ZT_SubVBox3_Radio2.Toggled += new global::System.EventHandler (this.OnZTSubVBox3Radio1Toggled);
			this.ZT_SubVBox4_Radio1.Toggled += new global::System.EventHandler (this.OnZTSubVBox4Radio1Toggled);
			this.ZT_SubVBox4_Radio2.Toggled += new global::System.EventHandler (this.OnZTSubVBox4Radio1Toggled);
			this.ZT_SubVBox8_Button1.Clicked += new global::System.EventHandler (this.OnZTSubVBox8Button1Clicked);
			this.ZT_SubVBox8_Button2.Clicked += new global::System.EventHandler (this.OnZTSubVBox8Button2Clicked);
		}
	}
}