<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoC.aspx.cs" Inherits="UANLWeb.Alumnos.AlumnoC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <table>
        <tr>
            <td>Matricula: </td>
            <td>
                <asp:TextBox ID="txtMatricula" MaxLength="10" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_matricula" runat="server" ControlToValidate="txtMatricula" Display="Dynamic"
                    ErrorMessage="La matricula es requerida" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_codigo" runat="server" ControlToValidate="txtMatricula"
                    ValidationExpression="\b[0-9]{7}$" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="Solo se acepta 7 digitos"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Nombre: </td>
            <td>
                <asp:TextBox ID="txtNombre" MaxLength="100" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_nombre" runat="server" ControlToValidate="txtNombre" Display="Dynamic"
                    ErrorMessage="El nombre es requerido" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_nombre" runat="server" ControlToValidate="txtNombre"
                    ValidationExpression="^[a-zA-Z_ ]*$" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="Solo se aceptan palabras"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Apellido: </td>
            <td>
                <asp:TextBox ID="txtApellido" MaxLength="100" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_Apellido" runat="server" ControlToValidate="txtApellido" Display="Dynamic"
                    ErrorMessage="El apellido es requerido" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_apellido" runat="server" ControlToValidate="txtApellido"
                    ValidationExpression="^[a-zA-Z_ ]*$" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="Solo se aceptan palabras"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>Fecha de nacimiento: </td>
            <td>
                <asp:TextBox ID="txtfechaNacimiento" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_fechaNacimiento" runat="server" ControlToValidate="txtfechaNacimiento"
                    ErrorMessage="La fecha de nacimiento es requerida" ValidationGroup="vlg1" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cv_fecha" runat="server" ControlToValidate="txtfechaNacimiento"
                    Type="Date" Operator="DataTypeCheck" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="El formato es incorrecto (dd/MM/yyyy)"></asp:CompareValidator></td>
        </tr>
        <tr>
            <td>Facultad: </td>
            <td>
                <asp:DropDownList ID="ddlFacultad" CssClass="Lista" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfv_Facultad" runat="server" ControlToValidate="ddlFacultad"
                    ErrorMessage="La Facultad es requerida" ValidationGroup="vlg1" InitialValue="0" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Semestre: </td>
            <td>
                <asp:TextBox ID="txtSemestre" MaxLength="1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv_semestre" runat="server" ControlToValidate="txtSemestre" Display="Dynamic"
                    ErrorMessage="El semestre es requerido" ValidationGroup="vlg1"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev_semestre" runat="server" ControlToValidate="txtSemestre"
                    ValidationExpression="\b\d\b" ValidationGroup="vlg1" Display="Dynamic"
                    ErrorMessage="Solo se acepta un numero"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" ValidationGroup="vlg1" />
            </td>
        </tr>
    </table>
            </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
