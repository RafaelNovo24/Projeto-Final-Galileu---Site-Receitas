<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisa.aspx.cs" Inherits="AspNet.Pesquisa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container-fluid">
        Pesquisar por Nome 
        <asp:TextBox ID="txBoxPesquisa" class="form-control" Style="width: 100%; margin-bottom: 30px;" runat="server" />
        <div class="col-md-6">
            Dificuldade:
                <asp:DropDownList ID="ddlDificuldade" class="form-control" AppendDataBoundItems="True" runat="server">
                    <asp:ListItem>--- Seleccione ---</asp:ListItem>
                </asp:DropDownList>
        </div>
        <div class="col-md-6">
            Duração:
                <asp:DropDownList ID="ddbDuracao" class="form-control" AppendDataBoundItems="True" runat="server">
                    <asp:ListItem>--- Seleccione ---</asp:ListItem>
                </asp:DropDownList>
        </div>
        <asp:Button ID="btnPesquisar" class="btn btn-success btn-lg pull-right" Style="width: 250px; padding-right: 30px; margin-top: 20px;" Text="Pesquisar" runat="server" OnClick="btnPesquisar_Click" />
    </div>

    <hr style="color: aquamarine;" />
    <br />
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <asp:ListBox runat="server" ID="listBoxReceitas" class="form-control" Style="width: 100%; margin-bottom: 20px; height: 150px; font-size: large"></asp:ListBox>
            <asp:Label  id="lbltextoErroLista" Text="" style="color:red" runat="server" />
        </div>
    </div>
    <asp:Button ID="btnProcurar" class="btn btn-success btn-lg pull-right" Style="width: 250px; padding-right: 30px; margin-top: 20px;" Text="Procurar Receita" runat="server" OnClick="btnProcurar_Click" />

    <br />

</asp:Content>
