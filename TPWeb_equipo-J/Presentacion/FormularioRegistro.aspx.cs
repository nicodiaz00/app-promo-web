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
    public partial class FormularioRegistro : System.Web.UI.Page
    {
        public Cliente cliente { get; set; }

        public void desactivarCampos()
        {
            txtId.Enabled = false;
            txtDocumentoCliente.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtCodigoPostal.Enabled = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                
                if (Session["cliente"] != null)
                {
                    
                    

                    Cliente cliente = (Cliente)Session["Cliente"];
                    txtId.Text = cliente.Id.ToString();
                    txtDocumentoCliente.Text = cliente.Dni.ToString();
                    txtNombre.Text = cliente.Nombre.ToString();
                    txtApellido.Text = cliente.Apellido.ToString();
                    txtCiudad.Text = cliente.Ciudad.ToString();
                    txtEmail.Text = cliente.Email.ToString();
                    txtDireccion.Text = cliente.Direccion.ToString();
                    txtCodigoPostal.Text = cliente.Cp.ToString();

                    desactivarCampos();
                }
            }
            
        }

       

        protected void btnParticipar_Click(object sender, EventArgs e)
        {

        }
    }
}