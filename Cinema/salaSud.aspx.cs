using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class salaSud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["BigliettoSS"];
            if (c != null)
            {
                string nome = c.Values["nomeS"];
                string cognome = c.Values["cognomeS"];
                string ridotto = c.Values["ridottoS"];
                Response.Write($"Benvenuto nella Sala Sud {nome} {cognome}," +
                    $"ecco a Lei il suo biglietto e Buona Visione");
            }
            else
            {
                Response.Redirect("compraBiglietto");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("default");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("compraBiglietto");
        }
    }
}