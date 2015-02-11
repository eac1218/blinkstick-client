
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.RadioAction saveAction;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action quitAction;
	
	private global::Gtk.Action BlinkStickAction;
	
	private global::Gtk.Action TestAction;
	
	private global::Gtk.Action ManageAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action SupportAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action HideAction;
	
	private global::Gtk.Action ReportABugAction;
	
	private global::Gtk.Action OpenLogAction;
	
	private global::Gtk.Action PatternsAction;
	
	private global::Gtk.RadioAction OverviewToolbarAction;
	
	private global::Gtk.RadioAction NotificationsToolbarAction;
	
	private global::Gtk.RadioAction TestToolbarAction;
	
	private global::Gtk.RadioAction HelpToolbarAction;
	
	private global::Gtk.RadioAction PatternsAction1;
	
	private global::Gtk.RadioAction EventsAction;
	
	private global::Gtk.VBox vbox2;
	
	private global::Gtk.MenuBar menubar2;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.HBox hbox1;
	
	private global::Gtk.Toolbar toolbar2;
	
	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.saveAction = new global::Gtk.RadioAction ("saveAction", null, null, "gtk-save", 0);
		this.saveAction.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		w1.Add (this.saveAction, null);
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.BlinkStickAction = new global::Gtk.Action ("BlinkStickAction", global::Mono.Unix.Catalog.GetString ("BlinkStick"), null, null);
		this.BlinkStickAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Device");
		w1.Add (this.BlinkStickAction, null);
		this.TestAction = new global::Gtk.Action ("TestAction", global::Mono.Unix.Catalog.GetString ("Test..."), null, null);
		this.TestAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Test...");
		w1.Add (this.TestAction, null);
		this.ManageAction = new global::Gtk.Action ("ManageAction", global::Mono.Unix.Catalog.GetString ("Manage..."), null, null);
		this.ManageAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Manage...");
		w1.Add (this.ManageAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.SupportAction = new global::Gtk.Action ("SupportAction", global::Mono.Unix.Catalog.GetString ("Support"), null, null);
		this.SupportAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Support");
		w1.Add (this.SupportAction, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.HideAction = new global::Gtk.Action ("HideAction", global::Mono.Unix.Catalog.GetString ("Hide"), null, null);
		this.HideAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Hide");
		w1.Add (this.HideAction, null);
		this.ReportABugAction = new global::Gtk.Action ("ReportABugAction", global::Mono.Unix.Catalog.GetString ("Report a Bug"), null, null);
		this.ReportABugAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Report a Bug");
		w1.Add (this.ReportABugAction, null);
		this.OpenLogAction = new global::Gtk.Action ("OpenLogAction", global::Mono.Unix.Catalog.GetString ("Open Log"), null, null);
		this.OpenLogAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Log");
		w1.Add (this.OpenLogAction, null);
		this.PatternsAction = new global::Gtk.Action ("PatternsAction", global::Mono.Unix.Catalog.GetString ("Patterns..."), null, null);
		this.PatternsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Patterns...");
		w1.Add (this.PatternsAction, null);
		this.OverviewToolbarAction = new global::Gtk.RadioAction ("OverviewToolbarAction", global::Mono.Unix.Catalog.GetString ("Overview"), null, null, 0);
		this.OverviewToolbarAction.Group = this.saveAction.Group;
		this.OverviewToolbarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Overview");
		w1.Add (this.OverviewToolbarAction, null);
		this.NotificationsToolbarAction = new global::Gtk.RadioAction ("NotificationsToolbarAction", global::Mono.Unix.Catalog.GetString ("Notifications"), null, null, 1);
		this.NotificationsToolbarAction.Group = this.saveAction.Group;
		this.NotificationsToolbarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Notifications");
		w1.Add (this.NotificationsToolbarAction, null);
		this.TestToolbarAction = new global::Gtk.RadioAction ("TestToolbarAction", global::Mono.Unix.Catalog.GetString ("Test"), null, null, 4);
		this.TestToolbarAction.Group = this.NotificationsToolbarAction.Group;
		this.TestToolbarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Test");
		w1.Add (this.TestToolbarAction, null);
		this.HelpToolbarAction = new global::Gtk.RadioAction ("HelpToolbarAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null, 5);
		this.HelpToolbarAction.Group = this.NotificationsToolbarAction.Group;
		this.HelpToolbarAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpToolbarAction, null);
		this.PatternsAction1 = new global::Gtk.RadioAction ("PatternsAction1", global::Mono.Unix.Catalog.GetString ("Patterns"), null, null, 2);
		this.PatternsAction1.Group = this.NotificationsToolbarAction.Group;
		this.PatternsAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Patterns");
		w1.Add (this.PatternsAction1, null);
		this.EventsAction = new global::Gtk.RadioAction ("EventsAction", global::Mono.Unix.Catalog.GetString ("Events"), null, null, 3);
		this.EventsAction.Group = this.NotificationsToolbarAction.Group;
		this.EventsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Events");
		w1.Add (this.EventsAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("BlinkStick");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'><menuitem name='HideAction' action='HideAction'/><menuitem name='quitAction' action='quitAction'/></menu><menu name='BlinkStickAction' action='BlinkStickAction'><menuitem name='TestAction' action='TestAction'/><menuitem name='ManageAction' action='ManageAction'/><menuitem name='PatternsAction' action='PatternsAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='SupportAction' action='SupportAction'/><menuitem name='ReportABugAction' action='ReportABugAction'/><menuitem name='OpenLogAction' action='OpenLogAction'/><separator/><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox2.Add (this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><toolbar name='toolbar2'><toolitem name='OverviewToolbarAction' action='OverviewToolbarAction'/><toolitem name='NotificationsToolbarAction' action='NotificationsToolbarAction'/><toolitem name='PatternsAction1' action='PatternsAction1'/><toolitem name='EventsAction' action='EventsAction'/><toolitem name='TestToolbarAction' action='TestToolbarAction'/><toolitem name='HelpToolbarAction' action='HelpToolbarAction'/></toolbar></ui>");
		this.toolbar2 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar2")));
		this.toolbar2.Name = "toolbar2";
		this.toolbar2.Orientation = ((global::Gtk.Orientation)(1));
		this.toolbar2.ShowArrow = false;
		this.toolbar2.ToolbarStyle = ((global::Gtk.ToolbarStyle)(2));
		this.toolbar2.IconSize = ((global::Gtk.IconSize)(3));
		this.hbox1.Add (this.toolbar2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.toolbar2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		this.vbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
		w4.Position = 0;
		this.vbox2.Add (this.vbox3);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.vbox3]));
		w5.Position = 1;
		// Container child vbox2.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox2.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.statusbar1]));
		w6.Position = 2;
		w6.Expand = false;
		w6.Fill = false;
		this.Add (this.vbox2);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 655;
		this.DefaultHeight = 607;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.quitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
		this.TestAction.Activated += new global::System.EventHandler (this.OnTestActionActivated);
		this.ManageAction.Activated += new global::System.EventHandler (this.OnManageActionActivated);
		this.SupportAction.Activated += new global::System.EventHandler (this.OnSupportActionActivated);
		this.AboutAction.Activated += new global::System.EventHandler (this.OnAboutActionActivated);
		this.HideAction.Activated += new global::System.EventHandler (this.OnHideActionActivated);
		this.ReportABugAction.Activated += new global::System.EventHandler (this.OnReportABugActionActivated);
		this.OpenLogAction.Activated += new global::System.EventHandler (this.OnOpenLogActionActivated);
		this.PatternsAction.Activated += new global::System.EventHandler (this.OnPatternsActionActivated);
		this.OverviewToolbarAction.Toggled += new global::System.EventHandler (this.ToolbarButtonToggled);
		this.NotificationsToolbarAction.Toggled += new global::System.EventHandler (this.ToolbarButtonToggled);
		this.TestToolbarAction.Toggled += new global::System.EventHandler (this.ToolbarButtonToggled);
		this.HelpToolbarAction.Toggled += new global::System.EventHandler (this.ToolbarButtonToggled);
		this.PatternsAction1.Toggled += new global::System.EventHandler (this.ToolbarButtonToggled);
		this.EventsAction.Toggled += new global::System.EventHandler (this.ToolbarButtonToggled);
	}
}
