Imports d = DAO
Public Class Product
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If (IsPostBack = False) Then
            Dim p = New DAO.Operations()

            Dim lp = p.GetProduct()
            Dim lc = p.GetCategory()

            gvproduct.DataSource = lp
            gvproduct.DataBind()

            ddlcategory.DataTextField = "Categoria"
            ddlcategory.DataValueField = "Id"
            ddlcategory.DataSource = lc
            ddlcategory.DataBind()
        End If



    End Sub

    Protected Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click

        Dim p = New DAO.Operations()

        Dim pr = New DAO.Product
        pr.Producto = txtproducto.Text
        pr.Precio = txtprecio.Text
        Dim id = ddlcategory.SelectedItem.Value
        p.NewProduct(pr, id)


        Dim lp = p.GetProduct()
        gvproduct.DataSource = lp
        gvproduct.DataBind()

        txtproducto.Text = String.Empty
        txtprecio.Text = String.Empty

    End Sub
End Class