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
    public partial class LlenarFormulario : System.Web.UI.Page
    {
        private bool encontrado;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                deshabilitarTextBox();

            }
        }

        private void deshabilitarTextBox()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtCiudad.Enabled = false;
            txtCP.Enabled = false;
        }

        private void habilitarTextBox()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtEmail.Enabled = true;
            txtDireccion.Enabled = true;
            txtCiudad.Enabled = true;
            txtCP.Enabled = true;
        }

        private void blanquearTextBox()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtCP.Text = "";
        }

        private void blanquearErrorLabel()
        {
            lblErrorDocumento.Text = "";
            lblErrorNombre.Text = "";
            lblErrorApellido.Text = "";
            lblErrorEmail.Text = "";
            lblErrorDireccion.Text = "";
            lblErrorCiudad.Text = "";
            lblErrorCP.Text = "";
            lblErrorTerminos.Text = "";
        }

        protected void btnParticipar_Click(object sender, EventArgs e)
        {
            if (!controlarCargaControles())
            {
                return;
            }
            else 
            { 
                blanquearErrorLabel();
                VoucherNegocio negocio = new VoucherNegocio();
                Voucher auxVoucher = (Voucher)Session["voucher"];
                string codigo = auxVoucher.Codigo;
                int idArticulo = int.Parse(Request.QueryString["id"]);

                if (encontrado)
                {
                    Cliente auxCliente = (Cliente)Session["cliente"];
                    int idCliente = auxCliente.Id;

                    negocio.canjearVoucher(codigo, idCliente, idArticulo);
                }
                else
                {
                    ClienteNegocio clienteNegocio = new ClienteNegocio();
                    int idCliente = clienteNegocio.maximoId() + 1;
                    Cliente cliente = new Cliente();

                    negocio.canjearVoucher(codigo, idCliente, idArticulo);

                    cliente.Documento = txtDocumento.Text;
                    cliente.Nombre = txtNombre.Text;
                    cliente.Apellido = txtApellido.Text;
                    cliente.Email = txtEmail.Text;
                    cliente.Direccion = txtDireccion.Text;
                    cliente.Ciudad = txtCiudad.Text;
                    cliente.CP = int.Parse(txtCP.Text);

                    clienteNegocio.insertarCliente(cliente);
                }

                Response.Redirect("CargaExitosa.aspx", false);
            }
        }

        private bool controlarCargaControles()
        {
            bool controlesCargados = true;

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                lblErrorDocumento.Text = "El campo Documento es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorDocumento.Text = "";

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                lblErrorNombre.Text = "El campo Nombre es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorNombre.Text = "";

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                lblErrorApellido.Text = "El campo Apellido es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorApellido.Text = "";

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                lblErrorEmail.Text = "El campo Email es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorEmail.Text = "";

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                lblErrorDireccion.Text = "El campo Dirección es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorDireccion.Text = "";

            if (string.IsNullOrWhiteSpace(txtCiudad.Text))
            {
                lblErrorCiudad.Text = "El campo Ciudad es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorCiudad.Text = "";

            if (string.IsNullOrWhiteSpace(txtCP.Text))
            {
                lblErrorCP.Text = "El campo CP es obligatorio.";
                controlesCargados = false;
            }
            else
                lblErrorCP.Text = "";

            if(!chkTerminos.Checked)
            {
                lblErrorTerminos.Text = "Debe aceptar los términos y condiciones";
                controlesCargados = false;
            }

            return controlesCargados;
        }

        protected void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            int documento;
            if (!int.TryParse(txtDocumento.Text, out documento) || documento < 1 || documento > 99999999)
                lblErrorDocumento.Text = "Debe ingresar un número entre 1 y 99999999.";
            else
            {
                lblErrorDocumento.Text = "";
                try
                {
                    ClienteNegocio negocio = new ClienteNegocio();
                    Cliente cliente = new Cliente();
                    string docu = txtDocumento.Text;
                    cliente.Documento = docu;

                    if (negocio.buscarCliente(cliente))
                    {
                        blanquearErrorLabel();
                        encontrado = true;
                        Session.Add("cliente", cliente);
                        txtNombre.Text = cliente.Nombre;
                        txtApellido.Text = cliente.Apellido;
                        txtEmail.Text = cliente.Email;
                        txtDireccion.Text = cliente.Direccion;
                        txtCiudad.Text = cliente.Ciudad;
                        txtCP.Text = cliente.CP.ToString();
                    }
                    else
                    {
                        encontrado = false;
                        blanquearTextBox();
                        habilitarTextBox();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}