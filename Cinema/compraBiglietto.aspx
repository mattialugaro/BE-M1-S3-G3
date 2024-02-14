<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compraBiglietto.aspx.cs" Inherits="Cinema.compraBiglietto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <p class="display-1">Compila i campi e acquista il biglietto per il film che desideri guardare...</p>
        <div class="d-flex justify-content-center align-items-center">

            <div class="card center-card border border-1 rounded-3">
                <img src="content/img/uno.jpg" class="card-img-top" width="300px" height="420px" alt="copertina film" />
                <div class="card-body">
                    <h4 class="card-title">Il ragazzo e l'airone</h4>
                    <strong> Nome: </strong>
                    <asp:TextBox ID="nomeN" runat="server"></asp:TextBox>
                    <br />
                    <strong> Cognome: </strong>
                    <asp:TextBox ID="cognomeN" runat="server"></asp:TextBox>
                    <br />
                    <strong> Ridotto: </strong>
                    <asp:CheckBox ID="ridottoN" runat="server" />
                    <br />
                    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Compra" OnClick="Button1_Click" />
                </div>
            </div>

            <br />

            <div class="card center-card border border-1 rounded-3">
                <img src="content/img/due.jpg" class="card-img-top" width="300px" height="420px" alt="copertina film" />
                <div class="card-body">
                    <h4 class="card-title">Madame Web</h4>
                    <strong> Nome: </strong>
                    <asp:TextBox ID="nomeE" runat="server"></asp:TextBox>
                    <br />
                    <strong> Cognome: </strong>
                    <asp:TextBox ID="cognomeE" runat="server"></asp:TextBox>
                    <br />
                    <strong> Ridotto: </strong>
                    <asp:CheckBox ID="ridottoE" runat="server" />
                    <br />
                    <asp:Button CssClass="btn btn-primary" ID="Button2" runat="server" Text="Compra" OnClick="Button2_Click" />
                </div>
            </div>

            <br />

            <div class="card center-card border border-1 rounded-3">
                <img src="content/img/tre.jpg" class="card-img-top" width="300px" height="420px" alt="copertina film" />
                <div class="card-body">
                    <h4 class="card-title">I soliti idioti 3</h4>
                    <strong> Nome: </strong>
                    <asp:TextBox ID="nomeS" runat="server"></asp:TextBox>
                    <br />
                    <strong> Cognome: </strong>
                    <asp:TextBox ID="cognomeS" runat="server"></asp:TextBox>
                    <br />
                    <strong> Ridotto: </strong>
                    <asp:CheckBox ID="ridottoS" runat="server" />
                    <br />
                    <asp:Button CssClass="btn btn-primary" ID="Button3" runat="server" Text="Compra" OnClick="Button3_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
