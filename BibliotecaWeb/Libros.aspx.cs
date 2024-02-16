using BibliotecaWeb.ServiceReferenceLibro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaWeb
{
    public partial class Libros : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BttConsulta_Click(object sender, EventArgs e)
        {
            using(LibroClient cliente = new LibroClient())
            {
                GridLibros.DataSource = cliente.Consultar();
                GridLibros.DataBind();
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            using (LibroClient cliente = new LibroClient())
            {
                GridLibros.DataSource = cliente.Consultar1();
                GridLibros.DataBind();
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            using (LibroClient cliente = new LibroClient())
            {
                GridLibros.DataSource = cliente.Consultar2();
                GridLibros.DataBind();
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (LibroClient cliente = new LibroClient())
            {
                Libro_Ubicacion libro = new Libro_Ubicacion
                {
                    Isbn = txt1.Text,
                    Titulo = txt2.Text,
                    Estante = txt3.Text,
                    Sala = txt4.Text,
                    Librero = txt5.Text,
                    Posicion = txt6.Text
                };

                cliente.guardaLibro(libro);

                GridLibros.DataSource = cliente.Consultar();
                GridLibros.DataBind();
            }

            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
        }
    }
}