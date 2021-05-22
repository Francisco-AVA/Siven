using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace APP_SIVENTU
{
    
    public partial class InicioDeSeccion : Form
    {
        ventura ventuconfig = new ventura();

        public InicioDeSeccion()
        {
            InitializeComponent();
         
        }
        private void btIngreso_Click(object sender, EventArgs e)
        {
            string Nombre = txtnombre.Text.Trim(), 
                password= txtcontra.Text.Trim();

          bool result = ventuconfig.Login(Nombre, password);

            if(result )
            {
                menuFrom form = new menuFrom();
                form.Show();
                MessageBox.Show("usuario existe");
            }
            else
            {
                MessageBox.Show("usuario no existe");
            }
        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de salir?", "EXIT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else

            {
                MessageBox.Show("No se pudo cerrar");
            }
        }

        private void BtMini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void botonderegreso_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Quieres regresar a inicio?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Presentacion form = new Presentacion();
                form.Show();
            }
            else

            {
                MessageBox.Show("No se pudo regresar a inicio");
            }
        }

        private void olvidocontra_Click(object sender, EventArgs e)
        {
            Recuperacion rcfrom = new Recuperacion();
            rcfrom.Show();
        }

       
    }

}
