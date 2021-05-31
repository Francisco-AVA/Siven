using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class menuFrom : Form
    {
        public menuFrom()
        {
            InitializeComponent();
        }

        private void BtMini3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtSalir3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de salir?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else

            {
            }
        }

        private void changeForms(object fh)
        {
            if (Panel6contenedor.Controls.Count> 0) 
            {
               Panel6contenedor.Controls.Clear();
            }
            Form fromhijonuevo = fh as Form;
            fromhijonuevo.TopLevel = false; //acoplo del  nuevo form que viene
            fromhijonuevo.Dock = DockStyle.Fill; //llene todo
            Panel6contenedor.Controls.Add(fromhijonuevo); 
            Panel6contenedor.Tag = fromhijonuevo;//se le indica que esta entrando el nuevo
            fromhijonuevo.Show();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
             changeForms (new FormClientes());
        }

        private void btproveedores_Click(object sender, EventArgs e)
        {
            changeForms(new FormProveedores());
        }

        private void btfactura_Click(object sender, EventArgs e)
        {
           changeForms(new FormFactura());
        }

        private void btproductos_Click(object sender, EventArgs e)
        {
            changeForms(new FormProductos());
        }

        private void btcompras_Click(object sender, EventArgs e)
        {
           changeForms(new FormCompras());
        }

        private void btayuda_Click(object sender, EventArgs e)
        {
            changeForms(new FormAyuda());
        }
        private void btregistro_Click(object sender, EventArgs e)
        {
            changeForms(new RegistroDeEmpleados());
        }

        private void botonderegreso2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea regresar a inicio de sesion", "A regresado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                InicioDeSeccion form = new InicioDeSeccion();
                form.Show();
            }
            else

            {
            }
        }
    }
}
