Imports XL.Common

Namespace Reports
    Public Class R_02_00201

        Public Sub CreateDataBindings()

            'Me.XrTableCell_wRemark.DataBindings.Add("Text", Me.DataSource, "ROW_REMARK")
            'Me.XrTableCell_WareAmount.DataBindings.Add("Text", Me.DataSource, "WARE_AMOUNT", "{0:0}")
            'Me.XrTableCell_UnitPrice.DataBindings.Add("Text", Me.DataSource, "UNIT_PRICE", "{0:0.00}")
            'Me.XrTableCell_SumPrice.DataBindings.Add("Text", Me.DataSource, "SUM_PRICE", "{0:0.00}")

            Me.XrTableCell_Amount.DataBindings.Add("Text", Me.DataSource, "WARE_AMOUNT", "{0:0}")
            Me.XrTableCell_Classify.DataBindings.Add("Text", Me.DataSource, "WARE_CLASSIFY_NAME")
            Me.XrTableCell_Cost.DataBindings.Add("Text", Me.DataSource, "UNIT_COST", "{0:0.00}")
            Me.XrTableCell_CustomCode.DataBindings.Add("Text", Me.DataSource, "CUSTOM_CODE")
            Me.XrTableCell_Model.DataBindings.Add("Text", Me.DataSource, "MODEL")
            Me.XrTableCell_NO.DataBindings.Add("Text", Me.DataSource, "DSR_FT_ROW_ID")
            Me.XrTableCell_Price.DataBindings.Add("Text", Me.DataSource, "UNIT_PRICE", "{0:0.00}")
            Me.XrTableCell_Spec.DataBindings.Add("Text", Me.DataSource, "SPEC")
            Me.XrTableCell_UnitName.DataBindings.Add("Text", Me.DataSource, "UNIT_NAME")
            Me.XrTableCell_WareCode.DataBindings.Add("Text", Me.DataSource, "WARE_CODE")
            Me.XrTableCell_WareName.DataBindings.Add("Text", Me.DataSource, "WARE_NAME")


        End Sub
    End Class
End Namespace
