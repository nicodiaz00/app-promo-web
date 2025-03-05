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

    public partial class Registro : System.Web.UI.Page
    {
        public Articulo Articulo { get; set; }
        public Cliente Cliente { get; set; }
        public Voucher voucher { get; set; }
        private DateTime DateTime { get; set; }

        private void desactivartxt()
        {
            txtId.Enabled = false;
            txtDocumentoCliente.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtCodigoPostal.Enabled = false;
            txtCodigoArticulo.Enabled = false;
            txtFecha.Enabled = false;

        }
        private bool comprobarcampos(string nombre, string apellido, string email, string direccion, string codigoPostal, string ciudad)
        {
            if (Helper.Helper.campoVacio(nombre) && Helper.Helper.campoVacio(apellido) && Helper.Helper.campoVacio(email) && Helper.Helper.campoVacio(direccion) && Helper.Helper.campoVacio(codigoPostal) && Helper.Helper.campoVacio(ciudad))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void mostrarlbl()
        {
            lblrequerido1.Visible = true;
            lblrequerido2.Visible = true;
            lblrequerido3.Visible = true;
            lblrequerido4.Visible = true;
            lblrequerido5.Visible = true;
            lblrequerido6.Visible = true;
            lblrequerido7.Visible = true;
        }
        private void desactivartxt2()
        {
            txtId.Enabled = false;
            txtCodigoArticulo.Enabled = false;
            txtFecha.Enabled = false;
            txtDocumentoCliente.Enabled = false;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["articulo"] != null)
                {

                    Articulo = (Articulo)Session["articulo"];
                    voucher = (Voucher)Session["voucher"];
                    DateTime = DateTime.Now;
                    if (Session["cliente"] != null)
                    {
                        Cliente = (Cliente)Session["cliente"];
                        txtId.Text = Cliente.Id.ToString();
                        txtDocumentoCliente.Text = Cliente.Dni.ToString();
                        txtNombre.Text = Cliente.Nombre.ToString();
                        txtApellido.Text = Cliente.Apellido.ToString();
                        txtEmail.Text = Cliente.Email.ToString();
                        txtDireccion.Text = Cliente.Direccion.ToString();
                        txtCiudad.Text = Cliente.Ciudad.ToString();
                        txtCodigoPostal.Text = Cliente.Cp.ToString();
                        txtCodigoArticulo.Text = Articulo.Id.ToString();
                        txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        desactivartxt();
                    }
                    else
                    {
                        txtDocumentoCliente.Text = (string)Session["dni"];

                        txtCodigoArticulo.Text = Articulo.Id.ToString();
                        txtFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
                        desactivartxt2();
                        mostrarlbl();
                    }




                }
            }
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            AccesoDatos accesoDatos = new AccesoDatos();

            if (IsPostBack)
            {
                if (Session["cliente"] == null)
                {
                    if (comprobarcampos(txtNombre.Text, txtApellido.Text, txtEmail.Text, txtDireccion.Text, txtCodigoPostal.Text, txtCiudad.Text))
                    {
                        try
                        {
                            ScriptManager.RegisterStartupScript(this, GetType(), "ShowPopup","setTimeout(function() { window.mostrarPopup(); }, 500);", true);


                        }
                        catch (Exception ex)
                        {

                            throw ex;
                        }
                        

                    } if(txtEmail.Text != "")
                    {
                        if(Helper.Helper.mailValido(txtEmail.Text) == false)
                    {
                            ScriptManager.RegisterStartupScript(this, GetType(), "ShowPopup", "setTimeout(function() { window.mostrarPopup2(); }, 500);", true);
                        }
                        else
                        {




                            Cliente clienteAux = new Cliente();
                            ClienteNegocio clienteNegocio = new ClienteNegocio();


                            clienteAux.Dni = txtDocumentoCliente.Text;
                            clienteAux.Nombre = txtNombre.Text;
                            clienteAux.Apellido = txtApellido.Text;
                            clienteAux.Email = txtEmail.Text;
                            clienteAux.Direccion = txtDireccion.Text;
                            clienteAux.Ciudad = txtCiudad.Text;
                            clienteAux.Cp = int.Parse(txtCodigoPostal.Text);

                            clienteNegocio.registrarCliente(clienteAux);

                            int ultimoId = accesoDatos.obtenerUltimoIdCliente();


                            voucher = (Voucher)Session["voucher"];
                            voucher.IdArticulo = int.Parse(txtCodigoArticulo.Text);
                            voucher.IdCliente = ultimoId;
                            voucher.FechaCanje = DateTime.Parse(txtFecha.Text);
                            voucherNegocio.modificarVoucher(voucher);


                            Response.Redirect("Exito.aspx", false);
                        }
                    }
                   

                    
                }
                else
                {
                    voucher = (Voucher)Session["voucher"];
                    voucher.IdArticulo = int.Parse(txtCodigoArticulo.Text);
                    voucher.IdCliente = int.Parse(txtId.Text);
                    voucher.FechaCanje = DateTime.Parse(txtFecha.Text);

                    voucherNegocio.modificarVoucher(voucher);
                    Response.Redirect("Exito.aspx", false);

                }



            }


        }
    }

}