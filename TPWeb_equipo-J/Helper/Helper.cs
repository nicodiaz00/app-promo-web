using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Helper
{
    public static class Helper
    {
       public static bool nuevaFuncion()
        {
            return true;
        }

        public static bool campoVacio(string texto)
        {
            return string.IsNullOrEmpty(texto);
        }

        public static bool ValidarDocumento(string texto)
        {
            if(texto.Length == 8)
            {
                return true;
            }
            
            return false;
        }
        public static bool EsNumero(string texto)
        {
            int numero;
            return Int32.TryParse(texto, out numero);
        }
        public static bool mailValido(string emailUsuario)
        {
            try
            {
                MailAddress email = new MailAddress(emailUsuario);
                return true;
            }
            catch (FormatException)
            {
                {

                    return false;
                }

            }
        }
    }
}


