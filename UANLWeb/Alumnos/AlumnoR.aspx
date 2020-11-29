<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoR.aspx.cs" Inherits="UANLWeb.Alumnos.AlumnoR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:GridView ID="grd_alumnos" AutoGenerateColumns="false" runat="server" OnRowCommand="grd_alumnos_RowCommand" >
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/lapiz.png" Height="20px" Width="20"
                        CommandName="Editar" CommandArgument='<%# Eval("matricula") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Imagenes/trash.png" Height="20px" Width="20"
                        CommandName="Eliminar" CommandArgument='<%# Eval("matricula") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="Matricula" DataField="matricula"/>
            <asp:BoundField HeaderText="Nombre" DataField="nombre"/>
            <asp:BoundField HeaderText="Apellido" DataField="apellido"/>
            <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="fechaNacimiento" DataFormatString="{0:dd/MM/yyyy}"/>
            <asp:BoundField HeaderText="Facultad" DataField="nombreFacultad"/>
            <asp:BoundField HeaderText="semestre" DataField="semestre"/>

        </Columns>


   </asp:GridView>
</asp:Content>
 