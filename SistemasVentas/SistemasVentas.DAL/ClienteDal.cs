using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "SELECT        PERSONA.NOMBRE, PERSONA.APELLIDO\nFROM            CLIENTE INNER JOIN\n                         PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values(" + cliente.IdPersona + "," +
                                                        "'" + cliente.TipoCliente + "'," +
                                                        "'" + cliente.CodigoCliente + "'," +
                                                        "'" + cliente.Estado + "')";
            Conexion.Ejecutar(consulta);
        }

        public Cliente ObtenerClienteId(int id)
        {
            string consulta = "select * from cliente where idcliente = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Cliente cliente = new Cliente();
            if (tabla.Rows.Count > 0)
            {
                cliente.IdCliente = Convert.ToInt32(tabla.Rows[0]["idCliente"]);
                cliente.IdPersona = Convert.ToInt32(tabla.Rows[0]["IdPersona"]);
                cliente.TipoCliente = tabla.Rows[0]["tipoCliente"].ToString();
                cliente.CodigoCliente = tabla.Rows[0]["codigoCliente"].ToString();
                cliente.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return cliente;
        }

        public void EditarClienteDal(Cliente cliente)
        {
            string consulta = "update cliente set idPersona =" + cliente.IdPersona + "," +
                                                 "tipoCliente ='" + cliente.TipoCliente + "'," +
                                                 "codigoCliente ='" + cliente.CodigoCliente + "'," +
                                                 "estado ='" + cliente.Estado + "'" +
                                    "where idcliente=" + cliente.IdCliente;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarClienteDal(int id)
        {
            string consulta = "delete from cliente where idcliente =" + id;
            Conexion.Ejecutar(consulta);
        }
        public DataTable ExamenClientesDal()
        {
            string consulta = "SELECT P.NOMBRE, P.APELLIDO, SUM(V.TOTAL) AS TOTAL\nFROM CLIENTE C\nJOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA\nJOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\nGROUP BY P.NOMBRE, P.APELLIDO;";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public DataTable ExamenClienteDal()
        {
            string consulta = "SELECT P.NOMBRE, P.APELLIDO, SUM(V.TOTAL) AS TOTAL\nFROM CLIENTE C\nJOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA\nJOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE\nGROUP BY P.NOMBRE, P.APELLIDO\nHAVING SUM(V.TOTAL) > 50;";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
    }
}
