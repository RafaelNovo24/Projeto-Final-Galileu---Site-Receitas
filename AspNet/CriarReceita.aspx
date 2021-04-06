<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CriarReceita.aspx.cs" Inherits="AspNet.CriarReceita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="border: double aquamarine 2px">
        <div class="row">
            <h3 style="padding-left: 10px">
                <asp:Label ID="lbTituloReceita" Text="Nome Receita" runat="server" />
                <asp:TextBox Style="width: 80%; margin-right: 10px;" ID="txtTitulo" runat="server" /></h3>
            <br />
        </div>
        <br />
        <div class="row" style="border: solid lightblue 1px; margin-left: 20px; margin-right: 20px; padding-bottom: 20px; padding-top: 20px;">
            <div class="col-md-3">
                Dificuldade:
                <asp:DropDownList ID="ddlDificuldade" class="form-control" runat="server">
                </asp:DropDownList>
            </div>
            <div class="col-md-3">
                Duração:
                <asp:DropDownList ID="ddbDuracao" class="form-control" runat="server">
                </asp:DropDownList>
            </div>
            <div class="col-md-3">
                Categoria:
                <asp:DropDownList ID="ddlCategoria" class="form-control" runat="server">
                </asp:DropDownList>
            </div>
            <div class="col-md-3">
                Porção:
                <asp:DropDownList ID="ddlPorcao" class="form-control" runat="server">
                </asp:DropDownList>
            </div>
        </div>
        <br />
        <div class="container-fluid">
            <div class="col-md-7">
                <h4 style="margin-left: 20px; margin-bottom: 15px;">Ingredientes</h4>
                <div class="col-md-10 col-md-offset-1">
                    <p>
                        <asp:ListBox ID="lbIngredientes" Style="height: 300px; width: 400px;" runat="server"></asp:ListBox>
                    </p>
                    <p>
                        <asp:Label Text="" ID="lblErroIng" Style="color: red;" runat="server" />
                    </p>
                </div>
            </div>
            <div class="col-md-5">
                <h4>Inserir Ingredientes</h4>
                <div class="col-md-11 col-md-offset-1">
                    <h5>Ingredientes </h5>
                    <p>
                        <asp:DropDownList class="form-control" ID="ddlIngrediente" Style="width: 100%" runat="server">
                        </asp:DropDownList>
                    </p>
                    <h5>Quantidade: </h5>
                    <p>
                        <asp:TextBox ID="txtQuantidade" Style="width: 100%" runat="server" />
                    </p>
                    <p>
                        <asp:Label Text="" ID="lblErroQuantidade" Style="color: red;" runat="server" />
                    </p>
                    <h5>Unidade de Medida: </h5>
                    <p>
                        <asp:DropDownList class="form-control" ID="ddlUnidadeMedida" Style="width: 100%" runat="server">
                        </asp:DropDownList>
                    </p>
                    <br />
                    <p><asp:Button Text="Inserir" ID="btnInserir" class="btn btn-success" Width="200px" runat="server" EnableTheming="False" OnClick="btnInserir_Click" /></p>

                </div>
            </div>
        </div>
        <hr />
        <div class="container-fluid">
            <div class="row">
                <h4 style="margin-left: 20px; margin-bottom: 15px;">Preparação</h4>
                <div class="col-md-10 col-md-offset-1">
                    <asp:TextBox ID="txtBoxPreparacao" Style="margin-bottom: 20px;" runat="server" Height="300px" TextMode="MultiLine" Wrap="False" Width="997px" />
                    <p>
                        <asp:Label Text="" ID="lblErroPrep" Style="color: red;" runat="server" />
                    </p>
                    <br />
                </div>
            </div>
        </div>
        <br />
        <asp:Button Text="Adicionar Receita" ID="btnAdicionar" runat="server" class="btn btn-info pull-right" Style="margin-right: 20px; width: 250px" OnClick="btnAdicionar_Click" />
        <p>
            <asp:Label ID="lblEstadoCriar" Text="" Style="margin-left: 20px; margin-top: 20px; font-size: 16px; color: red" runat="server" />
        </p>
        <br />
        <h4 style="text-align: center"><strong>
            <asp:Label Text="Obrigado por fazer parte desta comunidade!" runat="server" /></strong></h4>
    </div>
</asp:Content>
