using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ImagenNegocio
    {
        public List<Imagen> listarImagenes()
        {
            List<Imagen> listaImagenes = new List<Imagen>();
            AccesoDatos accesoDatosImagen = new AccesoDatos();

            try
            {
                accesoDatosImagen.setearConsulta("Select I.Id, I.ImagenUrl from IMAGENES I");
                accesoDatosImagen.ejecutarLectura();
                while (accesoDatosImagen.Lector.Read())
                {
                    Imagen Imagen = new Imagen();
                    Imagen.Id = (int)accesoDatosImagen.Lector["Id"];
                    Imagen.UrlImagen = (string)accesoDatosImagen.Lector["ImagenUrl"];

                    listaImagenes.Add(Imagen);
                }

                return listaImagenes;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatosImagen.cerrarConexion();
            }
        }
        public List<Imagen> listarImagenesId(int id)
        {
            List<Imagen> listaImagen = new List<Imagen>();
            AccesoDatos accesodatosImagen = new AccesoDatos();

            try
            {
                accesodatosImagen.setearConsulta($"Select I.Id, I.IdArticulo, I.ImagenUrl from IMAGENES I where I.IdArticulo ={id}");
                accesodatosImagen.ejecutarLectura();
                while (accesodatosImagen.Lector.Read())
                {
                    Imagen Imagen = new Imagen();
                    Imagen.Id = (int)accesodatosImagen.Lector["Id"];
                    Imagen.IdArticulo = (int)accesodatosImagen.Lector["IdArticulo"];
                    Imagen.UrlImagen = (string)accesodatosImagen.Lector["ImagenUrl"];

                    listaImagen.Add(Imagen);
                }
                return listaImagen;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesodatosImagen.cerrarConexion();
            }
        }

    }
}

