using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class Recuperacion : Form
    {
        ventura login = new ventura();

        //Correo de asistencia
        const string soportewii = "venturacereales@gmail.com";
        const string soportecontrawi = "ventur@123Cereales";

        public Recuperacion()
        {
            InitializeComponent();
        }
        private void btsalirrecu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrecuperar_Click(object sender, EventArgs e)
        {
            string recorcorreo = txtcorreo_recuperacion.Text.Trim();
            if(string.IsNullOrEmpty(recorcorreo))
            {
                MessageBox.Show("Ingrese un correo valido, por favor", "Recuperando contraseña...", MessageBoxButtons.OK);
            }
            else
            {
                bool validate_correo = login.veryfycorreo(recorcorreo);
                if(validate_correo)
                {
                    Random randum = new Random();
                    int codes = randum.Next(10000,99999);
                    sendcorreoRecover(codes, recorcorreo);
                }
                else
                {
                    MessageBox.Show("Correo no existente", "Recuperando contraseña...", MessageBoxButtons.OK);
                }
            }
        }

        private void sendcorreoRecover(int codes, string recorreo)
        {
           
            try
            {        //PREPARACION DE EMAIL
                MailAddress correofulanito = new MailAddress(soportewii, "Cereales Ventura"); //nuestro email
                MailAddress correoparafulanito = new MailAddress(recorreo);  //el email a quien se lo mandaremos
                string asunto = " Restablecer contraseña de usuario. Cereales Ventura";
                string mensaje = "Se ha solicitado un cambio de contraseña de su cuenta en Cereales Ventura. Su código de verificación es el siguiente: " + codes +
                    " Si usted no ha solicitado un cambio de contraseña contactese con soporte tecnico.";

                //Configuración de servidores
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(soportewii, soportecontrawi);

                //confiración de email
                MailMessage email = new MailMessage(correofulanito, correoparafulanito);
                email.Subject = asunto;
                email.Body = mensaje;

                //enviaremos el email
                smtp.Send(email);
                MessageBox.Show("Se le ha enviado el codigo a su correo, por favor verifique.", "Recuperando contraseña...", MessageBoxButtons.OK);

                //verificación
                CodigoDeRecuperacion codefrom = new CodigoDeRecuperacion(codes,recorreo);
                codefrom.Show();
                this.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error con la conexión", "Recuperando contraseña...", MessageBoxButtons.OK);
                Console.WriteLine(e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Recuperacion_Load(object sender, EventArgs e)
        {

        }
    }
}
