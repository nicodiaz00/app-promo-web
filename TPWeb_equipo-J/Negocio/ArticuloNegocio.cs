using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> ListaArticuloSP()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            List<Imagen> listaDeImagenes = new List<Imagen>();
            ImagenNegocio ImagenNegocio = new ImagenNegocio();

            try
            {
                datos.setearProcedimiento("storepListarArt");
                
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["ArticuloId"];
                    aux.CodigoArticulo = (string)datos.Lector["CodigoArticulo"];
                    aux.NombreArticulo = (string)datos.Lector["NombreArticulo"];
                    aux.DescripcionArticulo = (string)datos.Lector["DescripcionArticulo"];
                    aux.Precio = Math.Round((decimal)datos.Lector["Precio"],0);

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.DescripcionMarca = (string)datos.Lector["DescripcionMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.DescripcionCategoria = (string)datos.Lector["DescripcionCategoria"];

                    aux.Imagenes = ImagenNegocio.listarImagenesId(aux.Id);
              
                    lista.Add(aux);
                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { 
                datos.cerrarConexion();
            
            }

        }
        public List<Articulo> listarArticulo()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos accesoDatosArticulo = new AccesoDatos();
            List<Imagen> listaDeImagenes = new List<Imagen>();
            ImagenNegocio ImagenNegocio = new ImagenNegocio();
            try
            {
                accesoDatosArticulo.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, C.descripcion as Categoria, M.descripcion as Marca, A.Precio  from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                accesoDatosArticulo.ejecutarLectura();
                while (accesoDatosArticulo.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatosArticulo.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatosArticulo.Lector["Codigo"];
                    articulo.NombreArticulo = (string)accesoDatosArticulo.Lector["Nombre"];
                    articulo.DescripcionArticulo = (string)accesoDatosArticulo.Lector["Descripcion"];
                    articulo.Precio = Math.Round((decimal)accesoDatosArticulo.Lector["Precio"], 0);

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatosArticulo.Lector["IdMarca"];
                    articulo.Marca.DescripcionMarca = (string)accesoDatosArticulo.Lector["Marca"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatosArticulo.Lector["IdCategoria"];
                    articulo.Categoria.DescripcionCategoria = (string)accesoDatosArticulo.Lector["Categoria"];

                    articulo.Imagenes = ImagenNegocio.listarImagenesId(articulo.Id);

                    listaArticulos.Add(articulo);

                }
                return listaArticulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatosArticulo.cerrarConexion();
            }
        }
        public Articulo seleccionarArticulo(int id)
        {
            Articulo articuloAux = new Articulo();

            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("Select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, C.descripcion as Categoria, M.descripcion as Marca, A.Precio  from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdMarca = M.Id and A.IdCategoria = C.Id and A.Id =" + id);

                accesoDatos.ejecutarLectura();


                while (accesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();
                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.NombreArticulo = (string)accesoDatos.Lector["Nombre"];
                    articulo.DescripcionArticulo = (string)accesoDatos.Lector["Descripcion"];
                    articulo.Precio = Math.Round((decimal)accesoDatos.Lector["Precio"], 0);

                    articulo.Marca = new Marca();
                    articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    articulo.Marca.DescripcionMarca = (string)accesoDatos.Lector["Marca"];

                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    articulo.Categoria.DescripcionCategoria = (string)accesoDatos.Lector["Categoria"];
                    List<Imagen> listaDeImagenes = new List<Imagen>();
                    ImagenNegocio ImagenNegocio = new ImagenNegocio();
                    articulo.Imagenes = ImagenNegocio.listarImagenesId(articulo.Id);

                    articuloAux = articulo;

                }
                return articuloAux;
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
