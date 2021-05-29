using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_SIVENTU
{
    class ventura
    {
        Conexion conn = new Conexion();

        public bool Login(string Nombre, string password)
        {
            string query = string.Format("Select * from usuarios where name='{0}' and password='{1}'", Nombre, password);
           DataRow[] dt = conn.readQuery(query, "Table", true);

            if (dt.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        // LOGIN
        public bool Register(string Nombre, string password1, string Telefono, string Sexo, string Correo)
        {
            bool set = conn.setData(string.Format("insert into usuarios (name, password, phone, sex, email) values ('{0}', '{1}', '{2}', '{3}', '{4}')", Nombre, password1, Telefono, Sexo, Correo));
            return set;
        }

        internal bool Register(string nombre, string password1, string correo, string Telé)
        {
            throw new NotImplementedException();
        }
        
        //CLIENTES
        public bool Registrar(string codigo, string nombre, string sexo, string telefono, string email, string direccion, string fecha)
        {    
            bool set = conn.setData(string.Format("insert into clientes (code, name, sex, phone, email, direccion, date) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", codigo, nombre, sexo, telefono, email, direccion, fecha));
            return set;
        }

        internal bool Registrar(string codigo, string nombre, string telefono, string email, string direccion, string fecha)
        {
           throw new NotImplementedException();
        }
        //elimnar
        public bool cliente(string codigo, string nombre)
        {
            string query = string.Format("Select * from clientes where name='{0}'", codigo, nombre);
            DataRow[] dt = conn.readQuery(query, "Table", true);

            if (dt.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Modificar
        public bool modificar(string Nombre)
        {
            string query = "UPDATE clientes SET (code, name, sex, phone, email, direccion, date) where ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')";
            DataRow[] dt = conn.readQuery(query, "Table", true);

            if (dt.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //PROVEEDORES

        public bool Registrador(string codigo, string nombre, string direccion, string telefono, string correo, string rubro, string product, string fecha)
        {
            bool set = conn.setData(string.Format("insert into proveedores (code, name, direccion, phone, email, rubro, product, date) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", codigo, nombre, direccion, telefono, correo, rubro, product, fecha));
            return set;
        }

        internal bool Registrador(string codigo, string nombre, string direccion, string pais, string telefono, string correo, string rubro, string product, string fecha)
        {
            throw new NotImplementedException();
        }

        //PRODUCTOS
        public bool Registradorpro(string codigo_prod, string descripcion, string precio, string existencias, string fecha)
        {
            bool set = conn.setData(string.Format("insert into productos (code, description, price, stocks, date) values ('{0}', '{1}', '{2}', '{3}', '{4}')", codigo_prod, descripcion, precio, existencias, fecha));
            return set;
        }
        internal bool Registradorpro( string descripcion, string precio, string existencias, string fecha)
        {
            throw new NotImplementedException();
        }
        //COMPRAS

        public bool Registercom(string codigo, string proveedor, string direccion, string telefono, string numerocom, string prododucosoli, string cantidad, string total, string descrip, string observa, string fecha)
        {
            bool set = conn.setData(string.Format("insert into compras (codigo, proveedor, direccion, telefono, NumeroDeCompras, ProductoSolicitado, Cantidad, TotalCompras, Descripcion, Observaciones, Fecha) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}')", codigo, proveedor, direccion, telefono, numerocom, prododucosoli, cantidad, total, descrip, observa, fecha));
            return set;
        }
        
        internal bool Registercom(string codigo, string proveedor, string direccion, string telefono, string numerocom, string prododucosoli, string cantidad, string total, string descrip, string observa)
        {
            throw new NotImplementedException();
        }

        //-------NUEVO-------- 15-04
        public bool veryfycorreo(string email)
        {
            string query = string.Format("SELECT * FROM usuarios WHERE email='{0}'",email); //presiento que no es name- cambie el 0 por 4
            DataRow[] dt = conn.readQuery(query, "usuario", true);

            return dt.Length == 1 ? true : false;
        }
        public bool changePassword(string newPassword, string email)
        {
            string query = string.Format("SELECT * FROM usuarios WHERE email='{0}'", email); //presiento que no es name
            DataRow[] dt = conn.readQuery(query, "usuario", true);

            if(dt.Length==1)

            {
                DataRow dtAlone = dt[0];
                int identifier = int.Parse(dtAlone[0].ToString().Trim());
                return updatePassword(newPassword, identifier);
            }
            else
            {
                return false;
            }
        }
        private bool updatePassword(string password, int id)
        {
            string query = string.Format("UPDATE usuarios SET password ='{0}' WHERE id ='{1}'", password, id); //cambio de 0 por 2
            bool isInsert = conn.setData(query);

            return isInsert;
        }

        public bool removeGeneral(string table, string idS, int id)
        {
            string Query = string.Format("DELETE FROM {0} WHERE {1} = {2}", table, idS, id);
            return conn.setData(Query);
        }
    }
}
