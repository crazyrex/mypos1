Imports XL.Common

Namespace Reports

    Public Class R_02_00102LittleList_05

        Public Sub CreateDataBindings()

            Me.XrTableCell_RowRemark.DataBindings.Add("Text", Me.DataSource, "ROW_REMARK")
            Me.XrTableCell_WareAmount.DataBindings.Add("Text", Me.DataSource, "WARE_AMOUNT", "{0:0}")
            Me.XrTableCell_UnitPrice.DataBindings.Add("Text", Me.DataSource, "UNIT_PRICE", "{0:0.00}")
            Me.XrTableCell_SumPrice.DataBindings.Add("Text", Me.DataSource, "SUM_PRICE", "{0:0.00}")

        End Sub

        Private Sub Detail_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
            Me.XrTableCell_UnitPrice.Text = String.Format("{0:0.00}", CommTK.FDecimal(Me.XrTableCell_UnitPrice.Text))
        End Sub

    End Class

End Namespace
