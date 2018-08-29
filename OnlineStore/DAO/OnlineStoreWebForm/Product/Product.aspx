<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Product.aspx.vb" Inherits="OnlineStoreWebForm.Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section id="prod">
        <h2>Productos</h2>

        <table>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Producto"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtproducto" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Precio"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" Text="Categoria"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlcategory" runat="server"></asp:DropDownList>
                </td>
            </tr>
        </table>
        <asp:Button ID="btnnuevo" runat="server" Text="Nuevo" />
        <br />
        <br />
        <asp:GridView ID="gvproduct" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="">
        </asp:LinqDataSource>
    </section>
</asp:Content>

