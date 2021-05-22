using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;



namespace APP_SIVENTU
{
    public partial class CodigoDeRecuperacion : Form
    {
        private string recorreo;
        private int codes;

        public CodigoDeRecuperacion(int codess, string recorreos)
        {
            InitializeComponent();
            this.recorreo =recorreos;
            this.codes= codess;
        }

        private void btsalirconfir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btrecuperar_Click(object sender, EventArgs e)
        {
            string verificarcodigo = txtconfirm_num.Text.Trim();
            if (codes.ToString() == verificarcodigo) 
            {
                CambioDeContraseña changePass = new CambioDeContraseña(recorreo);
                changePass.Show();
                this.Close();
            } 
            else
            {
                MessageBox.Show("Código invalido", "Recuperando contraseña...", MessageBoxButtons.OK);
            }
        }
    }
}

