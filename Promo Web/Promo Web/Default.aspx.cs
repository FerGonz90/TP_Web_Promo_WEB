using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Promo_Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Voucher vouch = new Voucher();
            VoucherNegocio negocio = new VoucherNegocio();

            string codigo = txtVoucher.Text;

            vouch = negocio.buscarVoucher(codigo);

            if (vouch == null)
            {
                Session.Add("error", "Voucher inexistente. Verifique e intente nuevamente");
                Response.Redirect("Error.aspx", false);
            }
            else
            {
                if(vouch.FechaCanje != DateTime.MinValue )
                {
                    Session.Add("error", "Voucher canjeado. Verifique e intente nuevamente");
                    Response.Redirect("Error.aspx", false);
                }
                else
                {
                    Session.Add("voucher", vouch);
                    Response.Redirect("ElegirPremio.aspx", false);
                }
            }
        }
    }
}