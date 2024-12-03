using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ClienteNegocio
    {
        public bool buscarCliente(Cliente clien)
        {
            AccesoDatos.AccesoDatos datos = new AccesoDatos.AccesoDatos();
            Cliente cliente = new Cliente();

            try
            {
                string documento = clien.Documento;
                string consulta = "Select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP " +
                                  " From Clientes Where Documento = " + documento;
                
                datos.setConsulta(consulta);
                datos.ejecutarLectura();

                if(datos.Lector.Read())
                {
                    clien.Id = (int)datos.Lector["Id"];
                    clien.Documento = (string)datos.Lector["Documento"];
                    clien.Nombre = (string)datos.Lector["Nombre"];
                    clien.Apellido = (string)datos.Lector["Apellido"];
                    clien.Email = (string)datos.Lector["Email"];
                    clien.Direccion = (string)datos.Lector["Direccion"];
                    clien.Ciudad = (string)datos.Lector["Ciudad"];
                    clien.CP = (int)datos.Lector["CP"];

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (datos.Lector != null)
                    datos.Lector.Close();
                datos.cerrarConexion();
            }
        }
    }
}
