<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categorias.aspx.cs" Inherits="AspNet.Categorias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container-fluid">
        <h3>Escolha a Categoria</h3>
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <asp:DropDownList id="ddlCategorias" class="form-control" style="width:300px" runat="server">
                </asp:DropDownList> 
                <asp:Button ID="btnSelect" class="btn btn-success btn-lg pull-right" Style="width: 250px; padding-right: 30px; padding-left:30px;" Text="Seleccionar" runat="server" OnClick="btnSelect_Click" />
            </div>
        </div>
    </div>
    <br />
    <div class="container-fluid">
        <h3>Escolha a Receita!</h3>
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <asp:ListBox runat="server" ID="listBoxReceitas" class="form-control" Style="width: 100%; margin-bottom: 20px;" Rows="12"></asp:ListBox>
                <asp:Label Text="" id="lblErroListReceitas" style="color:red" runat="server" />
            </div>
        </div>
        <br />
        <asp:Button ID="btnProcurar" class="btn btn-success btn-lg pull-right" Style="width: 250px; padding-right: 30px;" Text="Procurar" runat="server" OnClick="btnProcurar_Click" />
    </div>
</asp:Content>
