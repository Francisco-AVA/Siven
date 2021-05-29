using System;
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

            }
        }

        private void olvidocontra_Click(object sender, EventArgs e)
        {
            Recuperacion rcfrom = new Recuperacion();
            rcfrom.Show();
        }

        //OCULTAR CONTRASEÑA
        private void txtcontra_OnValueChanged(object sender, EventArgs e)
        {
            txtcontra.isPassword = true;
        }

        private void button_desactive_Click(object sender, EventArgs e)
        {
            txtcontra.isPassword = false;
            button_desactive.Visible = false;
            button_ocultar.Visible = true;
            txtcontra.Focus();
        }

        private void button_ocultar_Click(object sender, EventArgs e)
        {
            txtcontra.isPassword = true;
            button_ocultar.Visible = false;
            button_desactive.Visible = true;
            txtcontra.Focus();
        }

        private void InicioDeSeccion_Load(object sender, EventArgs e)
        {

        }
    }

}
