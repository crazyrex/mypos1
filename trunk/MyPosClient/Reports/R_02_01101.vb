Imports XL.Common
Namespace Reports


    Public Class R_02_01101

        Public Sub CreateDataBindings()


            Me.XrTableCell_WareCode.DataBindings.Add("Text", Me.DataSource, "WARE_CODE")
            Me.XrTableCell_WareName.DataBindings.Add("Text", Me.DataSource, "WARE_NAME")
            Me.XrTableCell_WareAmount.DataBindings.Add("Text", Me.DataSource, "WARE_AMOUNT", "{0:0}")
            Me.XrTableCell_UsePoint.DataBindings.Add("Text", Me.DataSource, "USE_POINT", "{0:0.00}")


        End Sub

    End Class
End Namespace