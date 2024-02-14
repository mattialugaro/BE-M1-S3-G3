using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class salaEst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie c = Request.Cookies["BigliettoSE"];
            if (c != null)
            {
                string nome = c.Values["nomeE"];
                string cognome = c.Values["cognomeE"];
                string ridotto = c.Values["ridottoE"];
                Response.Write($"Benvenuto nella Sala Est {nome} {cognome}," +
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