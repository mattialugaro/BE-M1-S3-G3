using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class salaNord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["BigliettoSN"];
            if (c != null) 
            {
                string nome = c.Values["nomeN"];
                string cognome = c.Values["cognomeN"];
                string ridotto = c.Values["ridottoN"];
                Response.Write($"Benvenuto nella Sala Nord {nome} {cognome}," +
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