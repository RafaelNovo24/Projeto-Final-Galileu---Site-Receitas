<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AreaPessoal.aspx.cs" Inherits="AspNet.AreaPessoal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-6">
            <h3>Alterar E-mail</h3>
            <p>
                <asp:Label Text="Username" runat="server" />
                <asp:TextBox ID="txtBoxUserEmail" runat="server" Style="width: 100%" ReadOnly="True" />
            </p>
            <p>
                <asp:Label Text="Endereço de E-mail " runat="server" />
                <asp:TextBox ID="txtBoxMail" runat="server" Style="width: 100%" Wrap="False" ReadOnly="True" />
            </p>
            <p>
                <asp:Label Text="Novo Endereço de E-mail " runat="server" />
                <asp:TextBox ID="txtBoxUserNovoMail" runat="server" Style="width: 100%" Wrap="False" />
            </p>
            <br />
            <asp:Button ID="btnAlterarEmail" Text="Confirmar" class="btn btn-info" runat="server" Style="width: 70%; margin-left: 60px; margin-right: 60px;" OnClick="btnAlterarEmail_Click" />
            <asp:Label ID="lblAlterarEmail" Text=" " runat="server" Style="color: slateblue" />

        </div>
        <div class="col-md-4 col-md-offset-1">
            <h3>Alterar Palavra-Chave</h3>
            <p>
                Username 
                <asp:TextBox ID="txtUserPass" runat="server" ReadOnly="True" Style="width: 100%" />
            </p>
            <p>
                Nova Palavra-Chave 
                <asp:TextBox ID="txtNewPass" runat="server" Style="width: 100%" TextMode="Password" />
            </p>
            <p>
                Resposta de Segurança
                <asp:TextBox ID="txtPassResposta" runat="server" Style="width: 100%" />
            </p>
            <br />
            <asp:Button Text="Confirmar" class="btn btn-info" Style="width: 70%; margin-left: 60px; margin-right: 60px;" runat="server" />
            <p>
                <asp:Label Text=" " ID="lblPass" runat="server" />
            </p>
        </div>
    </div>
    <hr />
    <div class="row">
        <div class="col-md-5">
            <h3>Receitas Favoritas</h3>
            <p>
                <asp:ListBox ID="lbReceitasFav" runat="server" Rows="10" Width="500px"></asp:ListBox>
                <asp:Label ID="lblReceitasFavoritasErro" Text="" Style="color: red;" runat="server" />
            </p>
            <asp:Button ID="btnProcurarReceitasfav" Text="Procurar" class="btn btn-info" Style="width: 70%; margin-left: 60px; margin-right: 60px;" runat="server" OnClick="btnProcurarReceitasfav_Click" />
        </div>

        <div class="col-md-1" style="border-right: 1px solid #000; height: 250px"></div>
        <div class="col-md-1"></div>

        <div class="col-md-5">
            <h3>Minhas Receitas</h3>
            <p>
                <asp:ListBox ID="lbMinhasReceitas" runat="server" Rows="10" Width="500px"></asp:ListBox>
                <asp:Label ID="lblMinhasReceitasErro" Text="" Style="color: red;" runat="server" />

            </p>
            <asp:Button ID="btnProcurarMinhasReceitas" Text="Procurar" class="btn btn-info" Style="width: 70%; margin-left: 60px; margin-right: 60px;" runat="server" OnClick="btnProcurarMinhasReceitas_Click" />
        </div>

    </div>

</asp:Content>
