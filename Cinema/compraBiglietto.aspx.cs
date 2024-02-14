using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cinema
{
    public partial class compraBiglietto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("BigliettoSN");
            c.Values["nomeN"] = nomeN.Text;
            c.Values["cognomeN"] = cognomeN.Text;
            c.Values["ridottoN"] = ridottoN.Checked.ToString();
            c.Expires = DateTime.Now.AddHours(4);
            Response.Cookies.Add(c);
            Response.Redirect("salaNord");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("BigliettoSE");
            c.Values["nomeE"] = nomeE.Text;
            c.Values["cognomeE"] = cognomeE.Text;
            c.Values["ridottoE"] = ridottoE.Checked.ToString();
            c.Expires = DateTime.Now.AddHours(4);
            Response.Cookies.Add(c);
            Response.Redirect("salaEst");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            HttpCookie c = new HttpCookie("BigliettoSS");
            c.Values["nomeS"] = nomeS.Text;
            c.Values["cognomeS"] = cognomeS.Text;
            c.Values["ridottoS"] = ridottoS.Checked.ToString();
            c.Expires = DateTime.Now.AddHours(4);
            Response.Cookies.Add(c);
            Response.Redirect("salaSud");
        }
    }
}