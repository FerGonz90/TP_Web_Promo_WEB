using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Promo_Web
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mensajeError = "";

            if (Session["error"] != null)
            {
                mensajeError = Session["error"].ToString();
            }
            else
            {
                mensajeError = "Ha ocurrido un error inesperado.";
            }

            lblDetalleError.Text = mensajeError;
            lblDetalleError.Visible = true;
            Session.Remove("error");
        }
    }
}