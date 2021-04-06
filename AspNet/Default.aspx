<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:LoginView ID="LoginViewDefault" runat="server">
        <AnonymousTemplate>
                <div class="jumbotron">
        <h1>Bem vindo !</h1>
        <p class="lead">
            Aproveite ao máximo das receitas deste site! Para usufruir de todas as funcionalidades disponíveis , como área pessoal
            ou partilhar uma receita com a nossa comunidade, terá de se inscrever <a href="Registar.aspx">aqui</a>.
        </p>
    </div>
        </AnonymousTemplate>
        <LoggedInTemplate>
                <div class="jumbotron">
        <h1>Bem vindo !</h1>
        <p class="lead">
            Aproveite ao máximo das receitas deste site! Vote e comente as receitas que mais gosta!
            Acesse à área pessoal para ver as suas receitas favoritas e as receitas que criou!
        </p>
    </div>
        </LoggedInTemplate>
    </asp:LoginView>



</asp:Content>
