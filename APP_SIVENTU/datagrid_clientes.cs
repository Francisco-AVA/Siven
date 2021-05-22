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
    
    public partial class datagrid_clientes : Form
    {
        ControlDe_dgv Control = new ControlDe_dgv();
        public string idS;
        ventura ventura = new ventura();

        public datagrid_clientes()
        {
            InitializeComponent();
        }

        private void btminiclient_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btsalirclient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btlimpiar_clientesgri_Click(object sender, EventArgs e)
        {
            bool resp = ventura.removeGeneral("clientes", "Id", Convert.ToInt32(idS));

            if (resp) {
                MessageBox.Show("Se eliminó con exito");
                getclientes();
            }
            else
            {
                MessageBox.Show("no funcionó");
            }
        }

        private void getclientes()
        {
            DataSet ds = Control.getclientes();
            dataGridViewClientes.DataSource = ds.Tables[0].DefaultView;
        }

        private void datagrid_clientes_Load(object sender, EventArgs e)
        {
            getclientes();
            dataGridViewClientes.Columns[0].Visible = false;
        }

        //EVENTO PARA MOVER FORMULARIO

        int m, mx, my;

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx=e.X;
            my = e.Y;
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridViewClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if(m ==1)
            {
                this.SetDesktopLocation(MousePosition.X-mx,MousePosition.Y-my) ;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
