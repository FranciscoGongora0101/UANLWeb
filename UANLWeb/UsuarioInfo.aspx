<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsuarioInfo.aspx.cs" Inherits="UANLWeb.UsuarioInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <table>
        <tr>
            <td>ID: </td>
            <td>
                <asp:Label ID="lblID" runat="server" Text=""></asp:Label>
            </td>
        </tr>
                
        <tr>
            <td>Username: </td>
            <td>
                <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Contraseña: </td>
            <td>
                <asp:Label ID="lblPass" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        </table>
</asp:Content>
