using System;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class FormFactura : Form
    {
        ventura ventuconfig = new ventura();
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {

        }

        private void combofactu_SelectedIndexChanged(object sender, EventArgs e)
        {

            int cod;
            string nom;
            float precio;

            cod = combofactu.SelectedIndex;
            nom = combofactu.SelectedItem.ToString();
            precio = combofactu.SelectedIndex;

            switch (cod)
            {
                case 0: textBox1.Text = "0001"; break;
                case 1: textBox1.Text = "0002"; break;
                default: textBox1.Text = "0003"; break;
            }

            switch (nom)
            {
                case "jugo": textBox2.Text = "jugo"; break;
                case "galleta": textBox2.Text = "galleta"; break;
                default: textBox2.Text = "dulces"; break;
            }

            switch (precio)
            {
                case 0: textBox3.Text = "0.25"; break;
                case 1: textBox3.Text = "0.50"; break;
                default: textBox3.Text = "1.25"; break;
            }
        }

        private void btagregar_fac_Click(object sender, EventArgs e)
        {
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvfactu);

            file.Cells[0].Value = textBox1.Text;
            file.Cells[1].Value = textBox2.Text;
            file.Cells[2].Value = textBox3.Text;
            file.Cells[3].Value = txtcantidad.Text;
            file.Cells[4].Value = (float.Parse(textBox4.Text) * float.Parse(txtcantidad.Text)).ToString();

            dgvfactu.Rows.Add(file);

            textBox1.Text = textBox2.Text = textBox3.Text = txtcantidad.Text = combofactu.Text= "";
            obtenerTotal();
        }

        public void obtenerTotal()
        {
            float costo = 0;
            int contador = 0;

            contador = dgvfactu.RowCount;

            for (int i = 0; i < contador; i++)
            {
                costo += float.Parse(dgvfactu.Rows[i].Cells[4].Value.ToString());
            }

            textBox4.Text = costo.ToString();

        }

        private void btlimpiar_fac_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Esta seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvfactu.Rows.Remove(dgvfactu.CurrentRow);
                }

            }
            catch { }
            obtenerTotal();
        }

        private void txtefectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = (float.Parse(txtefectivo.Text) - float.Parse(textBox4.Text)).ToString();

            }
            catch { }

            if (txtefectivo.Text == "")
            {
                textBox5.Text = "";
            }
        }

        private void btguardar_fac_Click(object sender, EventArgs e)
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("CEREALES VENTURA"); //imprime una linea de descripcion
            Ticket1.TextoCentro("VENTA DE CEREALES"); //imprime una linea de descripcion
            Ticket1.TextoCentro("1a. calle oriente No.48, Usulután."); //imprime una linea de descripcion
            Ticket1.TextoCentro("El Salvador, C.A."); //imprime una linea de descripcion
            Ticket1.TextoCentro("Tel.: 2662-1843"); //imprime una
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0000001");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvfactu.Rows)
            {
                // PROD                     //PrECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(textBox4.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtefectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(textBox5.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            //this.Close();

            //................................................................................................................

            string codigo = textBox1.Text.Trim(),
                producto = combofactu.Text.Trim(),
                precio = textBox2.Text.Trim(),
                cantidad = txtcantidad.Text.Trim(),
                total = textBox3.Text.Trim();

            bool result = ventuconfig.Registerfac(codigo, producto, precio, cantidad, total);
            if (result)
            {
                MessageBox.Show("Facturado");
                textBox1.Text = textBox2.Text = textBox3.Text = txtcantidad.Text = combofactu.Text = textBox4.Text = textBox5.Text="";

            }
            else
            {
                MessageBox.Show("No facturado");
            }
        }

        private void labnum2_Click(object sender, EventArgs e)
        {
          //  labnum2 = "SELECT * FROM Factura WHERE Id= @Id";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
