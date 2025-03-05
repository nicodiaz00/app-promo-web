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
        public List<Cliente> listarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("Select Id, Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP from Clientes");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id = (int)accesoDatos.Lector["Id"];
                    cliente.Dni = (string)accesoDatos.Lector["Documento"];
                    cliente.Nombre = (string)accesoDatos.Lector["Nombre"];
                    cliente.Apellido = (string)accesoDatos.Lector["Apellido"];
                    cliente.Email = (string)accesoDatos.Lector["Email"];
                    cliente.Direccion = (string)accesoDatos.Lector["Direccion"];
                    cliente.Ciudad = (string)accesoDatos.Lector["Ciudad"];
                    cliente.Cp = (int)accesoDatos.Lector["CP"];

                    listaClientes.Add(cliente);
                }
                return listaClientes;
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
        public void registrarCliente(Cliente clienteNuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("insert into Clientes(Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) values (@documento, @nombre, @apellido, @email, @direccion, @ciudad, @cp)");
                accesoDatos.setearParametro("@documento", clienteNuevo.Dni);
                accesoDatos.setearParametro("@nombre", clienteNuevo.Nombre);
                accesoDatos.setearParametro("@apellido", clienteNuevo.Apellido);
                accesoDatos.setearParametro("@email", clienteNuevo.Email);
                accesoDatos.setearParametro("@direccion", clienteNuevo.Direccion);
                accesoDatos.setearParametro("@ciudad", clienteNuevo.Ciudad);
                accesoDatos.setearParametro("@cp", clienteNuevo.Cp);

                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
