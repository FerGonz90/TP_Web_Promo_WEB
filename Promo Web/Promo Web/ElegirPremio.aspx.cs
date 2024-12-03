using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Dominio;
using Negocio;

namespace Promo_Web
{
    public partial class ElegirPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarImagenesCards();   
                cargarDatosCards();
            }
        }

        private void cargarImagenesCards()
        {
            try
            {
                ImagenNegocio negocio = new ImagenNegocio();

                List<Imagen> listaImagenes = negocio.listarUrlImagenes(1);
                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            imgCarrusel1_1.ImageUrl = listaImagenes[i].Url;
                            break;
                        case 1:
                            imgCarrusel1_2.ImageUrl = listaImagenes[i].Url;
                            break;
                        case 2:
                            imgCarrusel1_3.ImageUrl = listaImagenes[i].Url;
                            break;

                    }
                }

                listaImagenes = negocio.listarUrlImagenes(2);
                for (int i = 0; i < 3; i++)
                {

                    switch (i)
                    {
                        case 0:
                            imgCarrusel2_1.ImageUrl = listaImagenes[i].Url;
                            break;
                        case 1:
                            imgCarrusel2_2.ImageUrl = listaImagenes[i].Url;
                            break;
                        case 2:
                            imgCarrusel2_3.ImageUrl = listaImagenes[i].Url;
                            break;

                    }
                }

                listaImagenes = negocio.listarUrlImagenes(3);
                for (int i = 0; i < 3; i++)
                {

                    switch (i)
                    {
                        case 0:
                            imgCarrusel3_1.ImageUrl = listaImagenes[i].Url;
                            break;
                        case 1:
                            imgCarrusel3_2.ImageUrl = listaImagenes[i].Url;
                            break;
                        case 2:
                            imgCarrusel3_3.ImageUrl = listaImagenes[i].Url;
                            break;
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            } 
        }

        private void cargarDatosCards()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                List<Articulo> listaArticulos = negocio.listarArticulos();
                lblNombre.Text = listaArticulos[0].Nombre;
                lblDescripcion.Text = listaArticulos[0].Descripcion;
                lblNombre2.Text = listaArticulos[1].Nombre;
                lblDescripcion2.Text = listaArticulos[1].Descripcion;
                lblNombre3.Text = listaArticulos[2].Nombre;
                lblDescripcion3.Text = listaArticulos[2].Descripcion;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnElegir_Click(object sender, EventArgs e)
        {
            Response.Redirect("LlenarFormulario.aspx?id=1", false);
        }

        protected void btnElegir2_Click(object sender, EventArgs e)
        {
            Response.Redirect("LlenarFormulario.aspx?id=2", false);
        }

        protected void btnElegir3_Click(object sender, EventArgs e)
        {
            Response.Redirect("LlenarFormulario.aspx?id=3", false);
        }
    }
}