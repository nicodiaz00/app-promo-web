using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
    public class VoucherNegocio
    {
        public List<Voucher> listarVoucher()
        {
            
            List <Voucher> listaVouchers = new List<Voucher>();
            AccesoDatos accesoDatos  = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("Select CodigoVoucher, IdCliente, FechaCanje, IdArticulo  from Vouchers");
                accesoDatos.ejecutarLectura();
                while (accesoDatos.Lector.Read())
                {
                    Voucher voucher = new Voucher();
                    voucher.CodigoVoucher = (string)accesoDatos.Lector["CodigoVoucher"];
                    voucher.IdCliente = accesoDatos.Lector["IdCliente"] == DBNull.Value ? -1 : Convert.ToInt32(accesoDatos.Lector["IdCliente"]);
                    voucher.FechaCanje = accesoDatos.Lector["FechaCanje"] == DBNull.Value ? DateTime.MinValue : (DateTime)accesoDatos.Lector["FechaCanje"];
                    voucher.IdArticulo = accesoDatos.Lector["IdArticulo"] == DBNull.Value ? -1 : (int)accesoDatos.Lector["IdCliente"];

                    listaVouchers.Add(voucher);
                }
                return listaVouchers;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();   
            }
        }
        public void modificarVoucher(Voucher voucher)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("Update Vouchers set IdCliente = @idCliente, FechaCanje = @fechaCanje, IdArticulo = @idArticulo where CodigoVoucher = @codigoVoucher");

                accesoDatos.setearParametro("@idCliente", voucher.IdCliente);
                accesoDatos.setearParametro("@fechaCanje", voucher.FechaCanje);
                accesoDatos.setearParametro("@idArticulo",voucher.IdArticulo);
                accesoDatos.setearParametro("@codigoVoucher", voucher.CodigoVoucher);
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
