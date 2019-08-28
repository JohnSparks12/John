Public Class frmInvoiceTotal
    Private Sub BtnCaculate_Click(sender As Object, e As EventArgs, texDiscountAmount As Object) Handles btnCaculate.()
       
        txtDiscountAmount.Text =
            (Convert.ToDecimal(txtSubtotal.Text)
            *Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString(*0.00*);
            txtTotal.Text =
            (Convert.ToDecimal(txtSubtotal.Text)
            *Convert.ToDecimal(txtDiscountPercentAmount).Text)).ToString(*0.00*);
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim this As Object = Nothing
        this.close()
    End Sub

    Private Sub TxtDiscountamout_TextChanged(sender As Object, e As EventArgs) Handles txtDiscountamout.TextChanged

    End Sub
End Class
