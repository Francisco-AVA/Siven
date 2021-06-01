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
    public partial class datagrid_compras : Form
    {
        ControlDe_dgv Control = new ControlDe_dgv();
        public string idS;
        ventura ventura = new ventura();

        public datagrid_compras()
        {
            InitializeComponent();
        }

        private void btminicom_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btsalircom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getcompras()
        {
            DataSet ds = Control.getcompras();
            dataGridViewCompras.DataSource = ds.Tables[0].DefaultView;
        }

        private void datagrid_compras_Load(object sender, EventArgs e)
        {
            getcompras();
            dataGridViewCompras.Columns[0].Visible = false;
        }

        //MOVIMIENTO
        int m, mx, my;
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }

        private void dataGridViewCompras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridViewCompras.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btlimpiar_com_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar?", "ELIMINAR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool resp = ventura.removeGeneral("compras", "Id", Convert.ToInt32(idS));

                if (resp)
                {
                    MessageBox.Show("Se eliminó con exito");
                    getcompras();
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
