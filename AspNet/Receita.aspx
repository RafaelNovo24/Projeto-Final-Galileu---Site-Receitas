<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Receita.aspx.cs" Inherits="AspNet.Receita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" style="border: double aquamarine 2px">
        <div class="row">
            <h3 style="padding-left: 10px">
                <asp:Label ID="lbTituloReceita" Text="Nome Receita" runat="server" /></h3>
            <br />
            <div class="col-md-5 col-md-offset-1">
                <p>
                    <strong>Rating:</strong>
                    <asp:Label ID="lblRating" Text="?" runat="server" />/10
                </p>
            </div>
            <div class="col-md-5 col-md-offset-1">
                <p>
                    <strong>Data:</strong>
                    <asp:Label ID="lblData" Text="data de hoje" runat="server" />
                </p>
            </div>
        </div>
        <br />
        <div class="row" style="border: solid lightblue 1px; margin-left: 20px; margin-right: 20px;">
            <div class="col-md-3">
                Dificuldade:
                <asp:Label ID="lblDificuldade" Text="text" runat="server" />
            </div>
            <div class="col-md-3">
                Duração:
                <asp:Label ID="lblDuracao" Text="text" runat="server" />
            </div>
            <div class="col-md-4">
                Categoria:
                <asp:Label ID="lblCategoria" Text="text" runat="server" />
            </div>
            <div class="col-md-2">
                Quantidade:
                <asp:Label ID="lblPorcao" Text="text" runat="server" />
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-4">
                <h4 style="margin-left: 20px; margin-bottom: 15px;">Ingredientes</h4>
                <div class="col-md-12 col-md-offset-1">
                    <p>
                        <asp:ListBox ID="listBoxIngredientes" class="form-control" Style="width: 100%; height: 300px; margin-right: 10px;" runat="server"></asp:ListBox>
                    </p>
                </div>
            </div>
            <div class="col-md-8">
                <h4 style="margin-left: 20px; margin-bottom: 15px;">Preparação</h4>
                <div class="col-md-10 col-md-offset-1">
                    <asp:TextBox ID="txtBoxPreparacao" CssClass="textBoxFormat" runat="server" Style="height: 300px; width: 100%; margin-right: 10px; margin-left: 10px;" TextMode="MultiLine" Wrap="False" ReadOnly="True" />
                </div>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <div class="col-md-8">
            <p>
                <asp:TextBox ID="txtVotacao" type="number" runat="server" min="1" max="10" />
                <asp:Button ID="btnVotar" class="btn btn-warning" Text="Votar" runat="server" OnClick="btnVotar_Click" />
            </p>
            <asp:Label ID="lbVotarSucesso" Style="margin-left: 30px; color: dodgerblue; text-align: center;" Text="" runat="server" />
            <asp:Label ID="lblVotarErro" Style="margin-left: 30px; color: red; text-align: center;" Text="" runat="server" />
            <p>
                <asp:Label ID="lblVote1a10" Text="Vote de 1 a 10!" runat="server" /></p>

        </div>
        <div class="col-md-4">
            <asp:Button class="btn btn-warning btn-lg" Text="Adicionar aos Favoritos" ID="btnAdicionarFavs" Style="margin-top: 20px;" runat="server" OnClick="btnAdicionarFavs_Click" />
            <p>
                <asp:Label ID="lblFavoritosSucesso" Text="" Style="color: dodgerblue; text-align: center;" runat="server" />
                <asp:Label ID="lblFavoritosErro" Text="" Style="color: red; text-align: center;" runat="server" />
            </p>
        </div>
    </div>
    <br />
    <div class="container-fluid" style="border: solid aquamarine 2px">
        <h4>Inserir Comentário</h4>
        <br />
        <div class="row">
            <div class="col-md-2">
                <asp:Button ID="btnInserirComentário" class="btn btn-info btn-lg" Text="Inserir comentário" runat="server" OnClick="btnInserirComentário_Click" />
            </div>
            <div class="col-md-8 col-md-offset-1">
                <asp:TextBox Style="width: 100%; height: 50px; margin-bottom: 10px;" runat="server" ID="txtInserirComentario" />
                <asp:Label ID="lbltxtComentarioErro" Text="" runat="server" Style="color: red; width: 100%;" />
                <asp:Label ID="lbltxtComentarioSucesso" Text="" runat="server" Style="color:dodgerblue; width: 100%;" />
                <asp:Button ID="btnComRegistar" class="btn btn-info" Text="Login" runat="server" Visible="false" OnClick="btnComRegistar_Click" />
            </div>
        </div>
        <hr style="color: darkorchid" />
        <h4>Comentários</h4>
        <asp:ListBox ID="lbComentarios" Style="width: 100%; margin-bottom: 15px; height: 400px; word-spacing: 2px;" runat="server"></asp:ListBox>
    </div>
</asp:Content>
