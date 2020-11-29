<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoD.aspx.cs" Inherits="UANLWeb.Alumnos.AlumnoD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <table>
        <tr>
            <td>Matricula: </td>
            <td>
                <asp:Label ID="lblMatricula" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Nombre: </td>
            <td>
               <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Apellido: </td>
            <td>
               <asp:Label ID="lblApellido" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Fecha de nacimiento: </td>
            <td>
                <asp:Label ID="lblFechaNacimiento" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Facultad: </td>
            <td>
                <asp:DropDownList ID="ddlFacultad" runat="server" Enabled="false"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Semestre: </td>
            <td>
                <asp:Label ID="lblSemestre" runat="server" Text=""></asp:Label>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
