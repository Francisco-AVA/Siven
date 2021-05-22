using System.Data;

namespace APP_SIVENTU
{
    class ControlDe_dgv
    {
        Conexion conn = new Conexion();

        public DataSet getusuarios()
        {
            string Query = "SELECT * FROM usuarios";
            return conn.readQuery(Query, "usuarios");
        }

        public DataSet getclientes()
        {
            string Query = "SELECT * FROM clientes";
            return conn.readQuery(Query, "clientes");
        }
        public DataSet getproveedores()
        {
            string Query = "SELECT * FROM proveedores";
            return conn.readQuery(Query, "proveedores");
        }

        public DataSet getproductos()
        {
            string Query = "SELECT * FROM productos";
            return conn.readQuery(Query, "productos");
        }

        public DataSet getcompras()
        {
            string Query = "SELECT * FROM compras";
            return conn.readQuery(Query, "compras");
        }
    }
}
