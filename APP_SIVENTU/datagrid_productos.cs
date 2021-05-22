using System;
using System.Data;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class datagrid_productos : Form
    {
        ControlDe_dgv Control = new ControlDe_dgv();

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
        }

        //MOVIMIENTO
        int m, mx, my;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
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
