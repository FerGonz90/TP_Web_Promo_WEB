using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Seguridad;

namespace Promo_Web
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(Page is Default || Page is Error))
            {
                if (!Seguridad.Validar.SesionActiva(Session["voucher"]))
                    Response.Redirect("Default.aspx", false);

            }
        }
    }
}