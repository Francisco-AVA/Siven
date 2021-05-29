using System;
using System.Data;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class datagrid_proveedores : Form
    {
        ControlDe_dgv Control = new ControlDe_dgv();
        public string idS;
        ventura ventura = new ventura();

        public datagrid_proveedores()
        {
            InitializeComponent();
        }

        private void btminiprov_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btsalirprov_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void getproveedores()
        {
            DataSet ds = Control.getproveedores();
            dataGridViewProveedores.DataSource = ds.Tables[0].DefaultView;
        }

        private void datagrid_proveedores_Load(object sender, EventArgs e)
        {
            getproveedores();
            dataGridViewProveedores.Columns[0].Visible = false;
        }

        //MOVIMIENTOS
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

        private void dataGridViewProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridViewProveedores.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void btlimpiar_prov_Click(object sender, EventArgs e)
        {
            bool resp = ventura.removeGeneral("proveedores", "Id", Convert.ToInt32(idS));

            if (resp)
            {
                MessageBox.Show("Se eliminó con exito");
                getproveedores();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar");
            }

        }

    }
}
