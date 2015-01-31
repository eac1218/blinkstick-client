
// This file has been generated by the GUI designer. Do not modify.
namespace BlinkStickClient
{
	public partial class BlinkStickInfoWidget
	{
		private global::Gtk.Table tableInfo;
		
		private global::Gtk.Button button265;
		
		private global::Gtk.Label labelConnected;
		
		private global::Gtk.Label labelConnectedInfo;
		
		private global::Gtk.Label labelManufacturer;
		
		private global::Gtk.Label labelManufacturer1;
		
		private global::Gtk.Label labelModeInfo;
		
		private global::Gtk.Label labelProduct;
		
		private global::Gtk.Label labelProductInfo;
		
		private global::Gtk.Label labelSerialNumber;
		
		private global::Gtk.Label labelSerialNumberInfo;
		
		private global::Gtk.Label labeMode;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget BlinkStickClient.BlinkStickInfoWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "BlinkStickClient.BlinkStickInfoWidget";
			// Container child BlinkStickClient.BlinkStickInfoWidget.Gtk.Container+ContainerChild
			this.tableInfo = new global::Gtk.Table (((uint)(5)), ((uint)(3)), false);
			this.tableInfo.Name = "tableInfo";
			this.tableInfo.RowSpacing = ((uint)(16));
			this.tableInfo.ColumnSpacing = ((uint)(6));
			this.tableInfo.BorderWidth = ((uint)(12));
			// Container child tableInfo.Gtk.Table+TableChild
			this.button265 = new global::Gtk.Button ();
			this.button265.CanFocus = true;
			this.button265.Name = "button265";
			this.button265.UseUnderline = true;
			this.button265.Label = global::Mono.Unix.Catalog.GetString ("Change");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.button265.Image = w1;
			this.tableInfo.Add (this.button265);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.button265]));
			w2.TopAttach = ((uint)(4));
			w2.BottomAttach = ((uint)(5));
			w2.LeftAttach = ((uint)(2));
			w2.RightAttach = ((uint)(3));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelConnected = new global::Gtk.Label ();
			this.labelConnected.Name = "labelConnected";
			this.labelConnected.Xalign = 1F;
			this.labelConnected.LabelProp = global::Mono.Unix.Catalog.GetString ("Connected:");
			this.tableInfo.Add (this.labelConnected);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelConnected]));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelConnectedInfo = new global::Gtk.Label ();
			this.labelConnectedInfo.Name = "labelConnectedInfo";
			this.labelConnectedInfo.Xalign = 0F;
			this.labelConnectedInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("[Yes/No]");
			this.tableInfo.Add (this.labelConnectedInfo);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelConnectedInfo]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelManufacturer = new global::Gtk.Label ();
			this.labelManufacturer.Name = "labelManufacturer";
			this.labelManufacturer.Xalign = 1F;
			this.labelManufacturer.LabelProp = global::Mono.Unix.Catalog.GetString ("Manufacturer:");
			this.tableInfo.Add (this.labelManufacturer);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelManufacturer]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelManufacturer1 = new global::Gtk.Label ();
			this.labelManufacturer1.Name = "labelManufacturer1";
			this.labelManufacturer1.Xalign = 0F;
			this.labelManufacturer1.LabelProp = global::Mono.Unix.Catalog.GetString ("[Manufacturer]");
			this.tableInfo.Add (this.labelManufacturer1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelManufacturer1]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelModeInfo = new global::Gtk.Label ();
			this.labelModeInfo.Name = "labelModeInfo";
			this.labelModeInfo.Xalign = 0F;
			this.labelModeInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("[Mode]");
			this.tableInfo.Add (this.labelModeInfo);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelModeInfo]));
			w7.TopAttach = ((uint)(4));
			w7.BottomAttach = ((uint)(5));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelProduct = new global::Gtk.Label ();
			this.labelProduct.Name = "labelProduct";
			this.labelProduct.Xalign = 1F;
			this.labelProduct.LabelProp = global::Mono.Unix.Catalog.GetString ("Product:");
			this.tableInfo.Add (this.labelProduct);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelProduct]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelProductInfo = new global::Gtk.Label ();
			this.labelProductInfo.Name = "labelProductInfo";
			this.labelProductInfo.Xalign = 0F;
			this.labelProductInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("[Product]");
			this.tableInfo.Add (this.labelProductInfo);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelProductInfo]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelSerialNumber = new global::Gtk.Label ();
			this.labelSerialNumber.Name = "labelSerialNumber";
			this.labelSerialNumber.Xalign = 1F;
			this.labelSerialNumber.LabelProp = global::Mono.Unix.Catalog.GetString ("Serial Number:");
			this.tableInfo.Add (this.labelSerialNumber);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelSerialNumber]));
			w10.TopAttach = ((uint)(2));
			w10.BottomAttach = ((uint)(3));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labelSerialNumberInfo = new global::Gtk.Label ();
			this.labelSerialNumberInfo.Name = "labelSerialNumberInfo";
			this.labelSerialNumberInfo.Xalign = 0F;
			this.labelSerialNumberInfo.LabelProp = global::Mono.Unix.Catalog.GetString ("[Serial]");
			this.tableInfo.Add (this.labelSerialNumberInfo);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labelSerialNumberInfo]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableInfo.Gtk.Table+TableChild
			this.labeMode = new global::Gtk.Label ();
			this.labeMode.Name = "labeMode";
			this.labeMode.Xalign = 1F;
			this.labeMode.LabelProp = global::Mono.Unix.Catalog.GetString ("Mode:");
			this.tableInfo.Add (this.labeMode);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.tableInfo [this.labeMode]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.tableInfo);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}
