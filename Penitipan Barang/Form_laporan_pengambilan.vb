Public Class Form_laporan_pengambilan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.RefreshReport()
        CrystalReportViewer1.ReportSource = "laporan_pengambilan.rpt"
    End Sub
End Class
    