
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class RemoteControlEditorWidget
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.Button buttonFixPermissions;
		
		private global::Gtk.Entry entryBindAddress;
		
		private global::Gtk.Label labelBindAddress;
		
		private global::Gtk.Label labelPort;
		
		private global::Gtk.SpinButton spinbuttonPort;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.RemoteControlEditorWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.RemoteControlEditorWidget";
			// Container child BlinkStickClient.RemoteControlEditorWidget.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(3)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.buttonFixPermissions = new global::Gtk.Button ();
			this.buttonFixPermissions.CanFocus = true;
			this.buttonFixPermissions.Name = "buttonFixPermissions";
			this.buttonFixPermissions.UseUnderline = true;
			this.buttonFixPermissions.Label = global::Mono.Unix.Catalog.GetString ("Fix Permissions");
			this.table1.Add (this.buttonFixPermissions);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.buttonFixPermissions]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(2));
			w1.RightAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryBindAddress = new global::Gtk.Entry ();
			this.entryBindAddress.CanFocus = true;
			this.entryBindAddress.Name = "entryBindAddress";
			this.entryBindAddress.IsEditable = true;
			this.entryBindAddress.InvisibleChar = '●';
			this.table1.Add (this.entryBindAddress);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryBindAddress]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(3));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelBindAddress = new global::Gtk.Label ();
			this.labelBindAddress.Name = "labelBindAddress";
			this.labelBindAddress.Xalign = 1F;
			this.labelBindAddress.LabelProp = global::Mono.Unix.Catalog.GetString ("Bind Address:");
			this.table1.Add (this.labelBindAddress);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelBindAddress]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.labelPort = new global::Gtk.Label ();
			this.labelPort.Name = "labelPort";
			this.labelPort.Xalign = 1F;
			this.labelPort.LabelProp = global::Mono.Unix.Catalog.GetString ("Port:");
			this.table1.Add (this.labelPort);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.labelPort]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.spinbuttonPort = new global::Gtk.SpinButton (1D, 65535D, 1D);
			this.spinbuttonPort.CanFocus = true;
			this.spinbuttonPort.Name = "spinbuttonPort";
			this.spinbuttonPort.Adjustment.PageIncrement = 10D;
			this.spinbuttonPort.ClimbRate = 1D;
			this.spinbuttonPort.Numeric = true;
			this.table1.Add (this.spinbuttonPort);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.spinbuttonPort]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonFixPermissions.Clicked += new global::System.EventHandler (this.OnButtonFixPermissionsClicked);
		}
	}
}