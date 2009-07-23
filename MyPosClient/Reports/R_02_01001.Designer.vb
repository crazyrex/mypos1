Namespace Reports


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_02_01001
        Inherits DevExpress.XtraReports.UI.XtraReport

        'XtraReport overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Designer
        'It can be modified using the Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell_OrigionUnitPrice = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_UnitDiscount = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_SumPrice = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell_WareName = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_WareAmount = New DevExpress.XtraReports.UI.XRTableCell
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
            Me.XrLabel_WelcomeBack = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_ServiceTel = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_NTel = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_TotalMoney = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
            Me.XrLabel_TurnoverCode = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_Operator = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_BranchName = New DevExpress.XtraReports.UI.XRLabel
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
            Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrLabel_ReturnTurnoverCode = New DevExpress.XtraReports.UI.XRLabel
            CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4, Me.XrTable1})
            Me.Detail.Height = 34
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTable4
            '
            Me.XrTable4.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrTable4.Location = New System.Drawing.Point(0, 17)
            Me.XrTable4.Name = "XrTable4"
            Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow4})
            Me.XrTable4.Size = New System.Drawing.Size(175, 17)
            Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableRow4
            '
            Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell_OrigionUnitPrice, Me.XrTableCell_UnitDiscount, Me.XrTableCell_SumPrice})
            Me.XrTableRow4.Name = "XrTableRow4"
            Me.XrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableRow4.Size = New System.Drawing.Size(175, 17)
            Me.XrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTableCell_OrigionUnitPrice
            '
            Me.XrTableCell_OrigionUnitPrice.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_OrigionUnitPrice.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell_OrigionUnitPrice.Name = "XrTableCell_OrigionUnitPrice"
            Me.XrTableCell_OrigionUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_OrigionUnitPrice.Size = New System.Drawing.Size(50, 17)
            Me.XrTableCell_OrigionUnitPrice.StylePriority.UseTextAlignment = False
            Me.XrTableCell_OrigionUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTableCell_UnitDiscount
            '
            Me.XrTableCell_UnitDiscount.Location = New System.Drawing.Point(50, 0)
            Me.XrTableCell_UnitDiscount.Name = "XrTableCell_UnitDiscount"
            Me.XrTableCell_UnitDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_UnitDiscount.Size = New System.Drawing.Size(67, 17)
            Me.XrTableCell_UnitDiscount.StylePriority.UseTextAlignment = False
            Me.XrTableCell_UnitDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTableCell_SumPrice
            '
            Me.XrTableCell_SumPrice.Location = New System.Drawing.Point(117, 0)
            Me.XrTableCell_SumPrice.Name = "XrTableCell_SumPrice"
            Me.XrTableCell_SumPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_SumPrice.Size = New System.Drawing.Size(58, 17)
            Me.XrTableCell_SumPrice.StylePriority.UseTextAlignment = False
            Me.XrTableCell_SumPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTable1
            '
            Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrTable1.Location = New System.Drawing.Point(0, 0)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
            Me.XrTable1.Size = New System.Drawing.Size(175, 17)
            Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell_WareName, Me.XrTableCell_WareAmount})
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableRow1.Size = New System.Drawing.Size(175, 17)
            Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTableCell_WareName
            '
            Me.XrTableCell_WareName.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_WareName.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell_WareName.Name = "XrTableCell_WareName"
            Me.XrTableCell_WareName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_WareName.Size = New System.Drawing.Size(83, 17)
            Me.XrTableCell_WareName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_WareAmount
            '
            Me.XrTableCell_WareAmount.Location = New System.Drawing.Point(83, 0)
            Me.XrTableCell_WareAmount.Name = "XrTableCell_WareAmount"
            Me.XrTableCell_WareAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_WareAmount.Size = New System.Drawing.Size(92, 17)
            Me.XrTableCell_WareAmount.StylePriority.UseTextAlignment = False
            Me.XrTableCell_WareAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'PageFooter
            '
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_WelcomeBack, Me.XrLabel_ServiceTel, Me.XrLabel_NTel, Me.XrLabel_TotalMoney, Me.XrLabel6})
            Me.ReportFooter.Name = "ReportFooter"
            '
            'XrLabel_WelcomeBack
            '
            Me.XrLabel_WelcomeBack.Location = New System.Drawing.Point(0, 67)
            Me.XrLabel_WelcomeBack.Name = "XrLabel_WelcomeBack"
            Me.XrLabel_WelcomeBack.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_WelcomeBack.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_WelcomeBack.Text = "欢迎再次光临!"
            Me.XrLabel_WelcomeBack.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_ServiceTel
            '
            Me.XrLabel_ServiceTel.Location = New System.Drawing.Point(83, 33)
            Me.XrLabel_ServiceTel.Name = "XrLabel_ServiceTel"
            Me.XrLabel_ServiceTel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_ServiceTel.Size = New System.Drawing.Size(92, 25)
            Me.XrLabel_ServiceTel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_NTel
            '
            Me.XrLabel_NTel.Location = New System.Drawing.Point(0, 33)
            Me.XrLabel_NTel.Name = "XrLabel_NTel"
            Me.XrLabel_NTel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_NTel.Size = New System.Drawing.Size(75, 25)
            Me.XrLabel_NTel.Text = "服务热线:"
            Me.XrLabel_NTel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_TotalMoney
            '
            Me.XrLabel_TotalMoney.Font = New System.Drawing.Font("Century Gothic", 8.0!)
            Me.XrLabel_TotalMoney.Location = New System.Drawing.Point(117, 8)
            Me.XrLabel_TotalMoney.Name = "XrLabel_TotalMoney"
            Me.XrLabel_TotalMoney.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_TotalMoney.Size = New System.Drawing.Size(58, 17)
            Me.XrLabel_TotalMoney.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrLabel6
            '
            Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrLabel6.Location = New System.Drawing.Point(0, 8)
            Me.XrLabel6.Name = "XrLabel6"
            Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel6.Size = New System.Drawing.Size(33, 17)
            Me.XrLabel6.Text = "总计"
            Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_ReturnTurnoverCode, Me.XrLabel_TurnoverCode, Me.XrLabel_Operator, Me.XrLabel4, Me.XrLabel_BranchName})
            Me.ReportHeader.Height = 105
            Me.ReportHeader.Name = "ReportHeader"
            '
            'XrLabel_TurnoverCode
            '
            Me.XrLabel_TurnoverCode.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrLabel_TurnoverCode.Location = New System.Drawing.Point(0, 25)
            Me.XrLabel_TurnoverCode.Name = "XrLabel_TurnoverCode"
            Me.XrLabel_TurnoverCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_TurnoverCode.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_TurnoverCode.StylePriority.UseFont = False
            Me.XrLabel_TurnoverCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_Operator
            '
            Me.XrLabel_Operator.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrLabel_Operator.Location = New System.Drawing.Point(50, 75)
            Me.XrLabel_Operator.Name = "XrLabel_Operator"
            Me.XrLabel_Operator.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_Operator.Size = New System.Drawing.Size(83, 25)
            Me.XrLabel_Operator.StylePriority.UseFont = False
            Me.XrLabel_Operator.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel4
            '
            Me.XrLabel4.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrLabel4.Location = New System.Drawing.Point(0, 75)
            Me.XrLabel4.Name = "XrLabel4"
            Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel4.Size = New System.Drawing.Size(42, 25)
            Me.XrLabel4.StylePriority.UseFont = False
            Me.XrLabel4.Text = "操作员:"
            Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_BranchName
            '
            Me.XrLabel_BranchName.Font = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrLabel_BranchName.Location = New System.Drawing.Point(0, 0)
            Me.XrLabel_BranchName.Name = "XrLabel_BranchName"
            Me.XrLabel_BranchName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_BranchName.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_BranchName.StylePriority.UseFont = False
            Me.XrLabel_BranchName.StylePriority.UseTextAlignment = False
            Me.XrLabel_BranchName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3, Me.XrTable2})
            Me.PageHeader.Height = 34
            Me.PageHeader.Name = "PageHeader"
            '
            'XrTable3
            '
            Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrTable3.Location = New System.Drawing.Point(0, 17)
            Me.XrTable3.Name = "XrTable3"
            Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
            Me.XrTable3.Size = New System.Drawing.Size(175, 17)
            Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableRow3
            '
            Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell2, Me.XrTableCell9})
            Me.XrTableRow3.Name = "XrTableRow3"
            Me.XrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableRow3.Size = New System.Drawing.Size(175, 17)
            Me.XrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTableCell7
            '
            Me.XrTableCell7.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell7.Size = New System.Drawing.Size(50, 17)
            Me.XrTableCell7.StylePriority.UseTextAlignment = False
            Me.XrTableCell7.Text = "单价"
            Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTableCell2
            '
            Me.XrTableCell2.Font = New System.Drawing.Font("Century Gothic", 7.0!)
            Me.XrTableCell2.Location = New System.Drawing.Point(50, 0)
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell2.Size = New System.Drawing.Size(58, 17)
            Me.XrTableCell2.StylePriority.UseFont = False
            Me.XrTableCell2.StylePriority.UseTextAlignment = False
            Me.XrTableCell2.Text = "折扣"
            Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTableCell9
            '
            Me.XrTableCell9.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell9.Location = New System.Drawing.Point(108, 0)
            Me.XrTableCell9.Name = "XrTableCell9"
            Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell9.Size = New System.Drawing.Size(67, 17)
            Me.XrTableCell9.StylePriority.UseTextAlignment = False
            Me.XrTableCell9.Text = "金额"
            Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTable2
            '
            Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrTable2.Location = New System.Drawing.Point(0, 0)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
            Me.XrTable2.Size = New System.Drawing.Size(175, 17)
            Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableRow2
            '
            Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3})
            Me.XrTableRow2.Name = "XrTableRow2"
            Me.XrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.XrTableRow2.Size = New System.Drawing.Size(175, 17)
            Me.XrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTableCell1
            '
            Me.XrTableCell1.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell1.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell1.Size = New System.Drawing.Size(75, 17)
            Me.XrTableCell1.StylePriority.UseTextAlignment = False
            Me.XrTableCell1.Text = "货品名称"
            Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell3
            '
            Me.XrTableCell3.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell3.Location = New System.Drawing.Point(75, 0)
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell3.Size = New System.Drawing.Size(100, 17)
            Me.XrTableCell3.StylePriority.UseTextAlignment = False
            Me.XrTableCell3.Text = "数量"
            Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrLabel_ReturnTurnoverCode
            '
            Me.XrLabel_ReturnTurnoverCode.Font = New System.Drawing.Font("宋体", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrLabel_ReturnTurnoverCode.Location = New System.Drawing.Point(0, 50)
            Me.XrLabel_ReturnTurnoverCode.Name = "XrLabel_ReturnTurnoverCode"
            Me.XrLabel_ReturnTurnoverCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_ReturnTurnoverCode.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_ReturnTurnoverCode.StylePriority.UseFont = False
            Me.XrLabel_ReturnTurnoverCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'R_02_01001
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.ReportFooter, Me.ReportHeader, Me.PageHeader})
            Me.Margins = New System.Drawing.Printing.Margins(0, 10, 10, 0)
            Me.PageHeight = 700
            Me.PageWidth = 187
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            Me.Version = "8.1"
            CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
        Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell_WareName As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Friend WithEvents XrLabel_WelcomeBack As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_ServiceTel As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_NTel As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_TotalMoney As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents XrLabel_Operator As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_BranchName As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrTableCell_WareAmount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrLabel_TurnoverCode As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell_OrigionUnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_UnitDiscount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_SumPrice As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrLabel_ReturnTurnoverCode As DevExpress.XtraReports.UI.XRLabel
    End Class
End Namespace
