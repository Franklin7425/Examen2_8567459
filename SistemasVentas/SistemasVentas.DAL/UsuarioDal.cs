﻿using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuariosDal()
        {
            string consulta = "SELECT U.NOMBREUSER AS VENDEDOR, COUNT(DV.IDPRODUCTO) AS CANTIDAD\nFROM USUARIO U\nJOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR\nJOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\nGROUP BY U.NOMBREUSER;";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarUsuarioDal(Usuario usuario)
        {
            string consulta = "insert into usuario values(" + usuario.IdPersona + "," +
                                                        "'" + usuario.NombreUser + "'," +
                                                        "'" + usuario.Contraseña + "'," +
                                                        "'" + usuario.FechaReg + "')";
            Conexion.Ejecutar(consulta);
        }

        public Usuario ObtenerUsuarioId(int id)
        {
            string consulta = "select * from usuario where idusuario = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Usuario usuario = new Usuario();
            if (tabla.Rows.Count > 0)
            {
                usuario.IdUsuario = Convert.ToInt32(tabla.Rows[0]["idUsuario"]);
                usuario.IdPersona = Convert.ToInt32(tabla.Rows[0]["idPersona"]);
                usuario.NombreUser = tabla.Rows[0]["nombreUser"].ToString();
                usuario.Contraseña = tabla.Rows[0]["contraseña"].ToString();
                usuario.FechaReg = Convert.ToDateTime(tabla.Rows[0]["fechaReg"]);
            }
            return usuario;
        }

        public void EditarUsuarioDal(Usuario usuario)
        {
            string consulta = "update usuario set idpersona =" + usuario.IdPersona + "," +
                                                 "nombreUser ='" + usuario.NombreUser + "'," +
                                                 "contraseña ='" + usuario.Contraseña + "'," +
                                                 "fechaReg ='" + usuario.FechaReg + "' " +
                                    "where idusuario=" + usuario.IdUsuario;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarUsuarioDal(int id)
        {
            string consulta = "delete from usuario where idusuario =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
