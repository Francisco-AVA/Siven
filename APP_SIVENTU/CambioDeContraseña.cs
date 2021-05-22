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
    public partial class CambioDeContraseña : Form
    {
        private string emailRecover;

        ventura login = new ventura();
        public CambioDeContraseña( string emailRecover)
        {
            InitializeComponent();

            this.emailRecover = emailRecover; //si no funciona con emailRecover cambiar a: recorreo
        }

        private void btrecuperar_Click(object sender, EventArgs e)
        {
            string newpass = txtcorreo_recuperacion.Text.Trim();
            string repitpass = txtcorreorecuperacion2.Text.Trim();

            if(string.IsNullOrEmpty(newpass) && string.IsNullOrEmpty(repitpass))
            {
                MessageBox.Show("Faltan datos por llenar", "Cambio de contraseña", MessageBoxButtons.OK);
            }
            else
            {
                if(newpass == repitpass) 
                {
                    bool validar_contra = login.changePassword(newpass,emailRecover); 

                    if (validar_contra)
                    {
                        MessageBox.Show("Contraseña actualizada con exito. Vuelva a iniciar sesión", "Cambio de contraseña", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("¡Error!", "Cambio de contraseña", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Contraseñas no coinciden, revise.", "Cambio de contraseña", MessageBoxButtons.OK);
                }
            }
        }
    }
}
