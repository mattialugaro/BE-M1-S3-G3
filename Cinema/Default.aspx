<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cinema._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <h1>Cinema</h1>

        <p>Proiezioni del giorno</p>
        <p>SALA NORD: Il ragazzo e l'airone</p>
        <p>SALA EST: Madame Web</p>
        <p>SALA SUD: I soliti idioti 3</p>

        <asp:Button ID="Button1" runat="server" Text="Compra Biglietto" OnClick="Button1_Click"/>
    </main>

</asp:Content>
