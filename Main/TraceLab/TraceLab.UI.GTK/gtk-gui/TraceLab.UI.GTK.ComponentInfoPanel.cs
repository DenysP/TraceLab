
// This file has been generated by the GUI designer. Do not modify.
namespace TraceLab.UI.GTK
{
	public partial class ComponentInfoPanel
	{
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.VBox vbox1;
		private global::Gtk.TextView errorTextView;
		private global::Gtk.Expander IOExpander;
		private global::Gtk.VBox vbox2;
		private global::Gtk.NodeView inputView;
		private global::Gtk.NodeView outputView;
		private global::Gtk.Label IOExpanderLabel;
		private global::Gtk.Expander configurationExpander;
		private global::Gtk.Label configurationExpanderLabel;
		private global::Gtk.Expander componentInfoExpander;
		private global::Gtk.Table infoTable;
		private global::Gtk.Label authorLbl;
		private global::Gtk.Label authorValue;
		private global::Gtk.Label componentLabelLbl;
		private global::Gtk.Entry componentLabelValue;
		private global::Gtk.Label componentNameLbl;
		private global::Gtk.Label componentNameValue;
		private global::Gtk.Label descriptionLbl;
		private global::Gtk.Label descriptionValue;
		private global::Gtk.Label versionLbl;
		private global::Gtk.Label versionValue;
		private global::Gtk.Label componentInfoExpanderLabel;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget TraceLab.UI.GTK.ComponentInfoPanel
			global::Stetic.BinContainer.Attach (this);
			this.Name = "TraceLab.UI.GTK.ComponentInfoPanel";
			// Container child TraceLab.UI.GTK.ComponentInfoPanel.Gtk.Container+ContainerChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.errorTextView = new global::Gtk.TextView ();
			this.errorTextView.CanFocus = true;
			this.errorTextView.Name = "errorTextView";
			this.errorTextView.Editable = false;
			this.errorTextView.CursorVisible = false;
			this.errorTextView.AcceptsTab = false;
			this.errorTextView.Justification = ((global::Gtk.Justification)(3));
			this.errorTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.errorTextView.LeftMargin = 3;
			this.errorTextView.RightMargin = 3;
			this.vbox1.Add (this.errorTextView);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.errorTextView]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Padding = ((uint)(3));
			// Container child vbox1.Gtk.Box+BoxChild
			this.IOExpander = new global::Gtk.Expander (null);
			this.IOExpander.CanFocus = true;
			this.IOExpander.Name = "IOExpander";
			this.IOExpander.Expanded = true;
			// Container child IOExpander.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.inputView = new global::Gtk.NodeView ();
			this.inputView.CanFocus = true;
			this.inputView.Name = "inputView";
			this.vbox2.Add (this.inputView);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.inputView]));
			w3.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.outputView = new global::Gtk.NodeView ();
			this.outputView.CanFocus = true;
			this.outputView.Name = "outputView";
			this.vbox2.Add (this.outputView);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.outputView]));
			w4.Position = 1;
			this.IOExpander.Add (this.vbox2);
			this.IOExpanderLabel = new global::Gtk.Label ();
			this.IOExpanderLabel.Name = "IOExpanderLabel";
			this.IOExpanderLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Input/Output");
			this.IOExpanderLabel.UseUnderline = true;
			this.IOExpander.LabelWidget = this.IOExpanderLabel;
			this.vbox1.Add (this.IOExpander);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.IOExpander]));
			w6.Position = 1;
			w6.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.configurationExpander = new global::Gtk.Expander (null);
			this.configurationExpander.CanFocus = true;
			this.configurationExpander.Name = "configurationExpander";
			this.configurationExpanderLabel = new global::Gtk.Label ();
			this.configurationExpanderLabel.Name = "configurationExpanderLabel";
			this.configurationExpanderLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Configuration");
			this.configurationExpanderLabel.UseUnderline = true;
			this.configurationExpander.LabelWidget = this.configurationExpanderLabel;
			this.vbox1.Add (this.configurationExpander);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.configurationExpander]));
			w7.Position = 2;
			w7.Expand = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.componentInfoExpander = new global::Gtk.Expander (null);
			this.componentInfoExpander.CanFocus = true;
			this.componentInfoExpander.Name = "componentInfoExpander";
			this.componentInfoExpander.Expanded = true;
			// Container child componentInfoExpander.Gtk.Container+ContainerChild
			this.infoTable = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.infoTable.Name = "infoTable";
			this.infoTable.RowSpacing = ((uint)(6));
			this.infoTable.ColumnSpacing = ((uint)(6));
			// Container child infoTable.Gtk.Table+TableChild
			this.authorLbl = new global::Gtk.Label ();
			this.authorLbl.Name = "authorLbl";
			this.authorLbl.Xpad = 3;
			this.authorLbl.Ypad = 2;
			this.authorLbl.Xalign = 0F;
			this.authorLbl.Yalign = 0F;
			this.authorLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Author:");
			this.infoTable.Add (this.authorLbl);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.infoTable [this.authorLbl]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.authorValue = new global::Gtk.Label ();
			this.authorValue.Name = "authorValue";
			this.authorValue.Xpad = 3;
			this.authorValue.Ypad = 2;
			this.authorValue.Xalign = 0F;
			this.authorValue.Yalign = 0F;
			this.infoTable.Add (this.authorValue);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.infoTable [this.authorValue]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.componentLabelLbl = new global::Gtk.Label ();
			this.componentLabelLbl.Name = "componentLabelLbl";
			this.componentLabelLbl.Xpad = 3;
			this.componentLabelLbl.Ypad = 2;
			this.componentLabelLbl.Xalign = 0F;
			this.componentLabelLbl.Yalign = 0F;
			this.componentLabelLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Label:");
			this.infoTable.Add (this.componentLabelLbl);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.infoTable [this.componentLabelLbl]));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.componentLabelValue = new global::Gtk.Entry ();
			this.componentLabelValue.CanFocus = true;
			this.componentLabelValue.Name = "componentLabelValue";
			this.componentLabelValue.IsEditable = true;
			this.componentLabelValue.InvisibleChar = '●';
			this.infoTable.Add (this.componentLabelValue);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.infoTable [this.componentLabelValue]));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.componentNameLbl = new global::Gtk.Label ();
			this.componentNameLbl.Name = "componentNameLbl";
			this.componentNameLbl.Xpad = 3;
			this.componentNameLbl.Ypad = 2;
			this.componentNameLbl.Xalign = 0F;
			this.componentNameLbl.Yalign = 0F;
			this.componentNameLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Component:");
			this.infoTable.Add (this.componentNameLbl);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.infoTable [this.componentNameLbl]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.componentNameValue = new global::Gtk.Label ();
			this.componentNameValue.Name = "componentNameValue";
			this.componentNameValue.Xpad = 3;
			this.componentNameValue.Ypad = 2;
			this.componentNameValue.Xalign = 0F;
			this.componentNameValue.Yalign = 0F;
			this.infoTable.Add (this.componentNameValue);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.infoTable [this.componentNameValue]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.descriptionLbl = new global::Gtk.Label ();
			this.descriptionLbl.Name = "descriptionLbl";
			this.descriptionLbl.Xpad = 3;
			this.descriptionLbl.Ypad = 2;
			this.descriptionLbl.Xalign = 0F;
			this.descriptionLbl.Yalign = 0F;
			this.descriptionLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Description:");
			this.infoTable.Add (this.descriptionLbl);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.infoTable [this.descriptionLbl]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.descriptionValue = new global::Gtk.Label ();
			this.descriptionValue.Name = "descriptionValue";
			this.descriptionValue.Xpad = 3;
			this.descriptionValue.Ypad = 2;
			this.descriptionValue.Xalign = 0F;
			this.descriptionValue.Yalign = 0F;
			this.descriptionValue.Wrap = true;
			this.infoTable.Add (this.descriptionValue);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.infoTable [this.descriptionValue]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.versionLbl = new global::Gtk.Label ();
			this.versionLbl.Name = "versionLbl";
			this.versionLbl.Xpad = 3;
			this.versionLbl.Ypad = 2;
			this.versionLbl.Xalign = 0F;
			this.versionLbl.Yalign = 0F;
			this.versionLbl.LabelProp = global::Mono.Unix.Catalog.GetString ("Version:");
			this.infoTable.Add (this.versionLbl);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.infoTable [this.versionLbl]));
			w16.TopAttach = ((uint)(2));
			w16.BottomAttach = ((uint)(3));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child infoTable.Gtk.Table+TableChild
			this.versionValue = new global::Gtk.Label ();
			this.versionValue.Name = "versionValue";
			this.versionValue.Xpad = 3;
			this.versionValue.Ypad = 2;
			this.versionValue.Xalign = 0F;
			this.versionValue.Yalign = 0F;
			this.infoTable.Add (this.versionValue);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.infoTable [this.versionValue]));
			w17.TopAttach = ((uint)(2));
			w17.BottomAttach = ((uint)(3));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			this.componentInfoExpander.Add (this.infoTable);
			this.componentInfoExpanderLabel = new global::Gtk.Label ();
			this.componentInfoExpanderLabel.Name = "componentInfoExpanderLabel";
			this.componentInfoExpanderLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Component Info");
			this.componentInfoExpanderLabel.UseUnderline = true;
			this.componentInfoExpander.LabelWidget = this.componentInfoExpanderLabel;
			this.vbox1.Add (this.componentInfoExpander);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.componentInfoExpander]));
			w19.Position = 3;
			w19.Expand = false;
			w19.Fill = false;
			w1.Add (this.vbox1);
			this.scrolledwindow1.Add (w1);
			this.Add (this.scrolledwindow1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.errorTextView.Hide ();
			this.Hide ();
			this.componentLabelValue.Changed += new global::System.EventHandler (this.HandleComponentLabelChanged);
		}
	}
}