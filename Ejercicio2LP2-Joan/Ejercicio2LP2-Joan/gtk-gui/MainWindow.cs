
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed2;

	private global::Gtk.Button btnAddOrder;

	private global::Gtk.Entry txtDatoEntrada;

	private global::Gtk.Label label3;

	private global::Gtk.Label label4;

	private global::Gtk.Label lblContador;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed2 = new global::Gtk.Fixed();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.btnAddOrder = new global::Gtk.Button();
		this.btnAddOrder.CanFocus = true;
		this.btnAddOrder.Name = "btnAddOrder";
		this.btnAddOrder.UseUnderline = true;
		this.btnAddOrder.Label = global::Mono.Unix.Catalog.GetString("Agregar y Ordenar");
		this.fixed2.Add(this.btnAddOrder);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.btnAddOrder]));
		w1.X = 350;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.txtDatoEntrada = new global::Gtk.Entry();
		this.txtDatoEntrada.CanFocus = true;
		this.txtDatoEntrada.Name = "txtDatoEntrada";
		this.txtDatoEntrada.IsEditable = true;
		this.txtDatoEntrada.InvisibleChar = '●';
		this.fixed2.Add(this.txtDatoEntrada);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.txtDatoEntrada]));
		w2.X = 160;
		w2.Y = 1;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("Ingrese un valor numerico");
		this.fixed2.Add(this.label3);
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Cantidad en Memoria");
		this.fixed2.Add(this.label4);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.label4]));
		w4.X = 500;
		w4.Y = 6;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.lblContador = new global::Gtk.Label();
		this.lblContador.Name = "lblContador";
		this.lblContador.LabelProp = global::Mono.Unix.Catalog.GetString("0");
		this.fixed2.Add(this.lblContador);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed2[this.lblContador]));
		w5.X = 555;
		w5.Y = 23;
		this.Add(this.fixed2);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 679;
		this.DefaultHeight = 297;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
