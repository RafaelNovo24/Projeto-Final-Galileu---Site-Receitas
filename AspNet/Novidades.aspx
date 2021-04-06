<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Novidades.aspx.cs" Inherits="AspNet.Novidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div class="container-fluid">
        <h2>Veja as mais recentes receitas inseridas!</h2>
        <hr style="color:aquamarine; " />
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <asp:ListBox runat="server" ID="listBoxReceitas" class="form-control" Style="width: 100%; margin-bottom: 20px; height:150px; font-size:large" ></asp:ListBox>
                <asp:Label Text="" ID="lblErro" style="color:red;" runat="server" />
            </div>
        </div>
        <br />
        <asp:Button ID="btnProcurar" class="btn btn-success btn-lg pull-right" Style="width: 250px; padding-right: 30px;" Text="Procurar" runat="server" OnClick="btnProcurar_Click" />
    </div>

</asp:Content>
