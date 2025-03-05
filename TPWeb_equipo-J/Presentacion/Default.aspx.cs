using Antlr.Runtime.Misc;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentacion
{
    public partial class _Default : Page
    {
        private List<Voucher> listadoVoucher = new List<Voucher>();

        private Voucher encontrarVoucher(string codigo, List<Voucher> listado)
        {
            Voucher voucher = null;

            foreach (Voucher cupon in listado)
            {
                if (cupon.CodigoVoucher.ToString() == codigo)
                {


                    voucher = cupon;
                    break;
                }
            }

            return voucher;
        }
        private void cuponUsado(Voucher voucher)
        {
            if (voucher == null)
            {
                Response.Redirect("Error.aspx", false);
                Session["voucher"] = null;
            }
            else if (voucher != null)
            {
                if (voucher.IdCliente == -1)
                {
                    Session["voucher"] = voucher;
                    Response.Redirect("Articulos.aspx", false);
                }
                else if (voucher.IdCliente != -1)
                {
                    Session["voucher"] = voucher;
                    Response.Redirect("Error.aspx", false);
                }
            }



            else
            {
                Response.Redirect("Articulos.aspx", false);
                Session["voucher"] = voucher;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listadoVoucher = new List<Voucher>();
                VoucherNegocio voucherNegocio = new VoucherNegocio();
                listadoVoucher = voucherNegocio.listarVoucher();
                Session["listadoVoucher"] = listadoVoucher;   //SE GUARDA EN SESSION EL LISTADO DE CUPONES.               
            }
        }
        protected void btnCanjearCupon_Click(object sender, EventArgs e)
        {
            if (Helper.Helper.campoVacio(txtVoucher.Text))
            {
                lblError.Text = "Debes ingresar el codigo";

                btnCanjearCupon.Visible = false;
                btnRecargar.Visible = true;
            }
            else
            {
                List<Voucher> vouchers = new List<Voucher>();
                Voucher voucher = new Voucher();

                if (Session["listadoVoucher"] != null)
                {
                    vouchers = (List<Voucher>)Session["listadoVoucher"]; // RECUPERO EL LISTADO DE LA SESSION PARA PODER ENCONTRAR EL CUPON

                    voucher = encontrarVoucher(txtVoucher.Text, vouchers);

                    cuponUsado(voucher);
                }
            }
        }

        protected void btnRecargar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx", false);
            Session.Clear();
        }

    }
}