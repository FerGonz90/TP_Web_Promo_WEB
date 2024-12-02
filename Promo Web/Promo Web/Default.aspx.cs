using Dominio;
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
            vouch.Id = 1;

            Session.Add("voucher", vouch);
            Response.Redirect("ElegirPremio.aspx", false);
        }
    }
}