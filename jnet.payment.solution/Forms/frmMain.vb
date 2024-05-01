Public Class frmMain
    Private Sub frmAccordionControlElementRecord_Click(sender As Object, e As EventArgs) Handles frmAccordionControlElementRecord.Click
        Dim frm As New frmRecordForm
        frm.ShowDialog()
    End Sub

    Private Sub frmAccordionControlElementPayment_Click(sender As Object, e As EventArgs) Handles frmAccordionControlElementPayment.Click
        Dim frm As New frmPaymentForm
        frm.ShowDialog()
    End Sub

    Private Sub frmAccordionControlScheduler_Click(sender As Object, e As EventArgs) Handles frmAccordionControlScheduler.Click
        Dim frm As New frmSchedulerForm
        frm.ShowDialog()
    End Sub
End Class
