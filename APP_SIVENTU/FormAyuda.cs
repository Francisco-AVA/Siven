using System;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class FormAyuda : Form
    {
        ventura ventuconfig = new ventura();
        public FormAyuda()
        {
            InitializeComponent();
        }
        //LLAMADO DE FORMULARIOS
        /*
        private void changeForms(object fh)
        {
            if (panel9info.Controls.Count > 0)
            {
               panel9info.Controls.Clear();
            }

            Form fromhijonuevo = fh as Form;
            fromhijonuevo.TopLevel = false; //acoplo del  nuevo form que viene
            fromhijonuevo.Dock = DockStyle.Fill; //llene todo
            panel9info.Controls.Add(fromhijonuevo);
            panel9info.Tag = fromhijonuevo;//se le indica que esta entrando el nuevo
            fromhijonuevo.Show();
        }
        */
     
        // LLAMADO DE BOTONES A FORM
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Ayuda1 ayu = new Ayuda1();
            ayu.Show();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Ayuda2 ayu = new Ayuda2();
            ayu.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Ayuda5 ayu = new Ayuda5();
            ayu.Show();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            Ayuda4 ayu = new Ayuda4();
            ayu.Show();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            Ayuda3 ayu = new Ayuda3();
            ayu.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Ayuda6 ayu = new Ayuda6();
            ayu.Show();
        }

        private void busqueda_OnTextChange(object sender, EventArgs e)
        {
            /*¿como crear una factura?
             * ¿como agregar mas registros?
            ¿como anular registros?
            ¿como eliminar un producto de una factura?
            ¿por que al ingresar datoos en los registros, los toma como invalidos?
            ¿como puedo modificar datos erroneoss ingresados en los registros?*/

        }

        private void FormAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}
