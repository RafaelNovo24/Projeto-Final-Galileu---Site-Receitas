<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NovoLogin.aspx.cs" Inherits="AspNet.NovoLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <h4>Para utilizar todas as funcionalidades do site , como criar receitas e adicionar favoritos, é necessário criar conta! </h4>
    <h5>Ainda não tem conta? Registe-se <a href="Registar.aspx">aqui</a></h5>.
    <hr />
    <asp:Login ID="Login" DestinationPageUrl="~/Default.aspx" runat="server" Width="684px" Height="241px" OnAuthenticate="Login_Authenticate">
        <CheckBoxStyle BorderStyle="Dashed" HorizontalAlign="Justify" BorderWidth="1px" CssClass="checkBoxMeLogin" />
        <LabelStyle Font-Size="Small" Width="300px" HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
        <TextBoxStyle BorderStyle="Double" Width="500px" />
    </asp:Login>
</asp:Content>
