using System;
using System.Data;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class datagrid_productos : Form
    {
        ControlDe_dgv Control = new ControlDe_dgv();
        public string idS;
        ventura ventura = new ventura();

        public datagrid_productos()
        {
            InitializeComponent();
        }

        private void btminiprod_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btsalirprod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getproductos()
        {
            DataSet ds = Control.getproductos();
            dataGridViewProductos.DataSource = ds.Tables[0].DefaultView;
        }

        private void datagrid_productos_Load(object sender, EventArgs e)
        {
            getproductos();
            dataGridViewProductos.Columns[0].Visible = false;

        }

        //MOVIMIENTO
        int m, mx, my;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridViewProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btlimpiar_prod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de salir?", "EXIT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool resp = ventura.removeGeneral("productos", "Id", Convert.ToInt32(idS));

                if (resp)
                {
                    MessageBox.Show("Se eliminó con exito");
                    getproductos();
                }
                else
                {

                }
            }
            else

            {
            }
           
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}
