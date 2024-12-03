using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Negocio
{
    public class VoucherNegocio
    {
        public Voucher buscarVoucher(string codigo)
        {
            AccesoDatos.AccesoDatos datos = new AccesoDatos.AccesoDatos();
            Voucher voucher = new Voucher();
            try
            {
                string consulta = "SELECT CodigoVoucher, IdCliente, FechaCanje, IdArticulo " +
                                  "FROM Vouchers WHERE CodigoVoucher = '" + codigo + "'";

                datos.setConsulta(consulta);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    voucher.Codigo = (string)datos.Lector["CodigoVoucher"];
                    voucher.Cliente = new Cliente();
                    voucher.Articulo = new Articulo();

                    if (datos.Lector["IdCliente"] != DBNull.Value)
                        voucher.Cliente.Id = (int)datos.Lector["IdCliente"];
                    else
                        voucher.Cliente.Id = 0;

                    if (datos.Lector["FechaCanje"] != DBNull.Value)
                        voucher.FechaCanje = (DateTime)datos.Lector["FechaCanje"];
                    else
                        voucher.FechaCanje = DateTime.MinValue;

                    if (datos.Lector["IdArticulo"] != DBNull.Value)
                        voucher.Articulo.Id = (int)datos.Lector["IdArticulo"];
                    else
                        voucher.Articulo.Id = 0;

                    return voucher;
                }
                else
                    return null;

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

        public void canjearVoucher(string codVouch, int idClien, int idArt)
        {
            AccesoDatos.AccesoDatos datos = new AccesoDatos.AccesoDatos();

            try
            {
                string fechaActualString = DateTime.Now.ToString("yyyy-MM-dd");
                string consulta = "Update Vouchers Set IdCliente = " + idClien + ", FechaCanje =  '" + 
                                  fechaActualString + "', IdArticulo = " + idArt + "Where CodigoVoucher " + 
                                  "= '" + codVouch + "'";

                datos.setConsulta(consulta);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
