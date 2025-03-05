using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class DocumentoForm : System.Web.UI.Page
    {
        private List<Cliente> listaCliente { get; set; }
        private Cliente Cliente { get; set; }

        private Cliente encontrarCliente(string dni, List<Cliente> listadoCliente)
        {
            Cliente cliente = null;
            foreach (Cliente clienteAux in listadoCliente)
            {
                if (dni == clienteAux.Dni.ToString())
                {
                    cliente = clienteAux;
                    break;
                }
            }
            return cliente;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                listaCliente = clienteNegocio.listarClientes();

                Session["clientes"] = listaCliente;
            }
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string documento = txtDocumento.Text;


            if (!Helper.Helper.campoVacio(documento))
            {
                if (Helper.Helper.EsNumero(documento))
                {
                    if (Helper.Helper.ValidarDocumento(documento))
                    {
                        List<Cliente> listadoDeClientes = (List<Cliente>)Session["clientes"];
                        Cliente = encontrarCliente(documento, listadoDeClientes);

                        if (Cliente != null)
                        {
                            Session["cliente"] = Cliente;
                            Response.Redirect("Registro.aspx", false);

                        }
                        else
                        {
                            Session["dni"] = documento;
                            Response.Redirect("Registro.aspx", false);
                        }
                    }
                    else
                    {
                        lblerrorDni.Text = "El documento debe tener al menos 8 dígitos numéricos";
                        btnIngresar.Visible = false;
                        btnErrorDni.Visible = true;
                    }

                    

                }
                else
                {
                    lblerrorDni.Text = "Debes ingresar numeros";
                    btnIngresar.Visible = false;
                    btnErrorDni.Visible = true;
                }
                 
                
            }
            else
            {
                lblerrorDni.Text = "No puede estar vacio";
                btnIngresar.Visible = false;
                btnErrorDni.Visible = true;
            }

        }
    
    
        protected void btnErrorDni_Click(object sender, EventArgs e)
        {
            lblerrorDni.Text = "";
            txtDocumento.Text = string.Empty;
            btnIngresar.Visible = true;
            btnErrorDni.Visible = false;
        }
    }
}
