using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class datagridEmpleados : Form
    {
        
        ControlDe_dgv Control = new ControlDe_dgv();
        public string idS;
        ventura ventura = new ventura();
        public datagridEmpleados()
        {
            InitializeComponent();
        }

        private void btsalir3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getusuarios()
        {       
            //muestra de datagrid
            DataSet ds = Control.getusuarios();
            dataGridViewEmpleados.DataSource = ds.Tables[0].DefaultView;
        }

        private void datagridEmpleados_Load(object sender, EventArgs e)
        {
            getusuarios();
            dataGridViewEmpleados.Columns[0].Visible = false;
        }

        private void btmini3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void dataGridViewEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idS = dataGridViewEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void btlimpiar_regis_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar?", "ELIMINADO", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bool resp = ventura.removeGeneral("usuarios", "Id", Convert.ToInt32(idS));

                if (resp)
                {
                    MessageBox.Show("Se eliminó con exito");
                    getusuarios();
                }
                else
                {

                }
            }
            else

            {
            }
            

    }
}
}
