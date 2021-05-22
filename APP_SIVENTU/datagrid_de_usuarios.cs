using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace APP_SIVENTU
{
    public partial class datagridEmpleados : Form
    {
        
        ControlDe_dgv Control = new ControlDe_dgv();
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

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void btlimpiar_regis_Click(object sender, EventArgs e)
        {
            //dataGridViewEmpleados.Rows.RemoveAt(dataGridViewEmpleados.SelectedRows[0].Index);
          
            

        }

    }
}
