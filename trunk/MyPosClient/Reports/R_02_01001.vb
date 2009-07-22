Imports XL.Common
Namespace Reports


    Public Class R_02_01001

        Public Sub CreateDataBindings()

         
            Me.XrTableCell_WareName.DataBindings.Add("Text", Me.DataSource, "WARE_NAME")
            Me.XrTableCell_WareAmount.DataBindings.Add("Text", Me.DataSource, "WARE_AMOUNT", "{0:0}")
            Me.XrTableCell_UnitPrice.DataBindings.Add("Text", Me.DataSource, "UNIT_PRICE", "{0:0.00}")
            Me.XrTableCell_SumPrice.DataBindings.Add("Text", Me.DataSource, "SUM_PRICE", "{0:0.00}")
            Me.XrTableCell_UnitDiscount.DataBindings.Add("Text", Me.DataSource, "UNIT_DISCOUNT", "{0:0.00}")
            Me.XrTableCell_OrigionUnitPrice.DataBindings.Add("Text", Me.DataSource, "ORIGION_UNIT_PRICE", "{0:0.00}")
        

        End Sub

    End Class
End Namespace