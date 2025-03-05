using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id {  get; set; }
        public string CodigoArticulo {  get; set; }
        public string NombreArticulo { get; set; }

        public string DescripcionArticulo { get; set; }

        public Marca Marca { get; set; }

        public Categoria Categoria { get; set; }

        public Decimal Precio {  get; set; }

        public List<Imagen> Imagenes { get; set; }
    }
}
