using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class RegistroDeEmpleados : Form
    {
        ventura ventuconfig = new ventura();
        public RegistroDeEmpleados()
        {
            InitializeComponent();
        }
        private void btguardar_regis_Click(object sender, EventArgs e)
        {
            
            string Nombre= txtNombre2.Text.Trim(), 
                password1 = txtContra2.Text.Trim(),
                RepetirContraseña=txtConfirmacion.Text.Trim(),
                Sexo = comboBox1.Text.Trim(),
                Correo= txtCorreo.Text.Trim(),
                Teléfono= txtTelefono.Text.Trim();

           bool result = ventuconfig.Register( Nombre, password1,Sexo, Correo, Teléfono);
            if (result)
            {
                MessageBox.Show("Usuario registrado");

                txtNombre2.Text = "";
                txtContra2.Text = "";
                txtConfirmacion.Text = "";
                comboBox1.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtTelefono.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       
       
        private void RegistroDeEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'databaseSIVENTUDataSet2.Table' Puede moverla o quitarla según sea necesario.
            //this.tableTableAdapter.Fill(this.databaseSIVENTUDataSet2.Table);
            // TODO: esta línea de código carga datos en la tabla 'databaseSIVENTUDataSet1.Table' Puede moverla o quitarla según sea necesario.
           // this.tableTableAdapter.Fill(this.databaseSIVENTUDataSet1.Table);

        }

        private bool txtCorreo_OnValueChanged(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtContra2_OnValueChanged(object sender, EventArgs e)
        {
            if (txtContra2.Text != String.Empty)
            {
                bool contNum = false;
                bool contString = false;
                foreach (char item in txtContra2.Text)
                {
                    if (Char.IsNumber(item))
                    {
                        contNum = true;
                    }
                    else if (Char.IsLetter(item))
                    {
                        contString = true;
                    }
                }
                if (!contString || !contNum)
                {
                    //falta numero o string
                }
            }
            else
            {
                //msj no puede dejar en blanco etc etc
            }
        }

        private void BtMini3_Click_1(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void BtSalir3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //SOLO CORREO
        // se crea el método para validar el Email
        public static bool Email_Valido(String email) // Método para validar el Email ingresado
        {
            String validando;
            validando = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
            if (Regex.IsMatch(email, validando))
            {
                if (Regex.Replace(email, validando, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
              //  this.tableTableAdapter.FillBy(this.databaseSIVENTUDataSet1.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

      
        private void btlimpiar_clientes_Click(object sender, EventArgs e)
        {
            //llamado al datagrid
            datagridEmpleados dtusu = new datagridEmpleados();
            dtusu.Show();
        }

        private void txtCorreo_OnValueChanged(object sender, EventArgs e)
        {
            //correo validado

            if (Email_Valido(txtCorreo.Text) == false)// llamado del metodo Email_Valido
            {
                errorempleados.SetError(txtCorreo, " Ingrese un Email Válido");
               txtCorreo.Focus();
                btlimpiar_regis.Enabled = true;
                return;
            }
            else
            {
                errorempleados.Clear();
                btguardar_regis.Visible = true;
                btlimpiar_regis.Enabled = true;
            }
        }

        private void txttelefonoo_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloNumeros(e);
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validacion.SoloLetras(e);
        }

        //OCULTAR Y MOSTRAR CONTRASEÑA
        private void button_mostrar_emple_Click(object sender, EventArgs e)
        {
            txtContra2.isPassword = false;
            button_mostrar_emple.Visible = false;
            button_ocultar_emple.Visible = true;
            txtContra2.Focus();
        }
        
        private void button_ocultar_emple_Click(object sender, EventArgs e)
        {
            txtContra2.isPassword = true;
            button_ocultar_emple.Visible = false;
            button_mostrar_emple.Visible = true;
            txtContra2.Focus();
        }
        //-------------------------------------------------------------------------------------
        private void button_mostrar_emple2_Click(object sender, EventArgs e)
        {
            txtConfirmacion.isPassword = false;
            button_mostrar_emple2.Visible = false;
           button_mostrar_emple2.Visible = true;
           txtConfirmacion.Focus();
        }

        private void button_ocultar_emple2_Click(object sender, EventArgs e)
        {
            txtConfirmacion.isPassword = true;
            button_ocultar_emple2.Visible = false;
            button_mostrar_emple2.Visible = true;
            txtConfirmacion.Focus();
        }
        //-------------------------------------------------------------------------------
        private void txtContra2_OnValueChanged_1(object sender, EventArgs e)
        {
            txtContra2.isPassword = true;
        }

        private void txtConfirmacion_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmacion.isPassword = true;
        }
    }
}
