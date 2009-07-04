Namespace Reports

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_02_00102LittleList_05
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
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell_RowRemark = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_WareAmount = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_UnitPrice = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_SumPrice = New DevExpress.XtraReports.UI.XRTableCell
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
            Me.XrLabel_CompanyTitle = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_TurnoverCode = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_Employee = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_NEmployee = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_Pos = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_DepositTime = New DevExpress.XtraReports.UI.XRLabel
            Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
            Me.XrLabel_WelcomeBack = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_ServiceTel = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_NTel = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_TotalMoney = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_TotalAmount = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
            Me.Detail.Height = 17
            Me.Detail.Name = "Detail"
            '
            'XrTable1
            '
            Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrTable1.Location = New System.Drawing.Point(0, 0)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.ParentStyleUsing.UseFont = False
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
            Me.XrTable1.Size = New System.Drawing.Size(175, 17)
            Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell_RowRemark, Me.XrTableCell_WareAmount, Me.XrTableCell_UnitPrice, Me.XrTableCell_SumPrice})
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Size = New System.Drawing.Size(175, 17)
            '
            'XrTableCell_RowRemark
            '
            Me.XrTableCell_RowRemark.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_RowRemark.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell_RowRemark.Name = "XrTableCell_RowRemark"
            Me.XrTableCell_RowRemark.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_RowRemark.ParentStyleUsing.UseFont = False
            Me.XrTableCell_RowRemark.Size = New System.Drawing.Size(67, 17)
            Me.XrTableCell_RowRemark.Text = "12345678901"
            Me.XrTableCell_RowRemark.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_WareAmount
            '
            Me.XrTableCell_WareAmount.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_WareAmount.Location = New System.Drawing.Point(67, 0)
            Me.XrTableCell_WareAmount.Name = "XrTableCell_WareAmount"
            Me.XrTableCell_WareAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_WareAmount.ParentStyleUsing.UseFont = False
            Me.XrTableCell_WareAmount.Size = New System.Drawing.Size(26, 17)
            Me.XrTableCell_WareAmount.Text = "999"
            Me.XrTableCell_WareAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTableCell_UnitPrice
            '
            Me.XrTableCell_UnitPrice.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_UnitPrice.Location = New System.Drawing.Point(93, 0)
            Me.XrTableCell_UnitPrice.Name = "XrTableCell_UnitPrice"
            Me.XrTableCell_UnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_UnitPrice.ParentStyleUsing.UseFont = False
            Me.XrTableCell_UnitPrice.Size = New System.Drawing.Size(41, 17)
            Me.XrTableCell_UnitPrice.Text = "000.00"
            Me.XrTableCell_UnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrTableCell_SumPrice
            '
            Me.XrTableCell_SumPrice.Font = New System.Drawing.Font("Century Gothic", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrTableCell_SumPrice.Location = New System.Drawing.Point(134, 0)
            Me.XrTableCell_SumPrice.Name = "XrTableCell_SumPrice"
            Me.XrTableCell_SumPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_SumPrice.ParentStyleUsing.UseFont = False
            Me.XrTableCell_SumPrice.Size = New System.Drawing.Size(41, 17)
            Me.XrTableCell_SumPrice.Text = "0000.00"
            Me.XrTableCell_SumPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_CompanyTitle, Me.XrLabel_TurnoverCode, Me.XrLabel_Employee, Me.XrLabel_NEmployee, Me.XrLabel_Pos, Me.XrLabel_DepositTime})
            Me.PageHeader.Height = 118
            Me.PageHeader.Name = "PageHeader"
            '
            'XrLabel_CompanyTitle
            '
            Me.XrLabel_CompanyTitle.Font = New System.Drawing.Font("黑体", 13.0!)
            Me.XrLabel_CompanyTitle.Location = New System.Drawing.Point(0, 0)
            Me.XrLabel_CompanyTitle.Name = "XrLabel_CompanyTitle"
            Me.XrLabel_CompanyTitle.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_CompanyTitle.ParentStyleUsing.UseFont = False
            Me.XrLabel_CompanyTitle.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_CompanyTitle.Text = "MITSUBOSHI白金店"
            Me.XrLabel_CompanyTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_TurnoverCode
            '
            Me.XrLabel_TurnoverCode.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrLabel_TurnoverCode.Location = New System.Drawing.Point(0, 50)
            Me.XrLabel_TurnoverCode.Name = "XrLabel_TurnoverCode"
            Me.XrLabel_TurnoverCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_TurnoverCode.ParentStyleUsing.UseFont = False
            Me.XrLabel_TurnoverCode.Size = New System.Drawing.Size(175, 17)
            Me.XrLabel_TurnoverCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_Employee
            '
            Me.XrLabel_Employee.Location = New System.Drawing.Point(58, 67)
            Me.XrLabel_Employee.Name = "XrLabel_Employee"
            Me.XrLabel_Employee.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_Employee.Size = New System.Drawing.Size(116, 25)
            Me.XrLabel_Employee.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_NEmployee
            '
            Me.XrLabel_NEmployee.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrLabel_NEmployee.Location = New System.Drawing.Point(0, 67)
            Me.XrLabel_NEmployee.Name = "XrLabel_NEmployee"
            Me.XrLabel_NEmployee.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_NEmployee.ParentStyleUsing.UseFont = False
            Me.XrLabel_NEmployee.Size = New System.Drawing.Size(58, 25)
            Me.XrLabel_NEmployee.Text = "操作员:"
            Me.XrLabel_NEmployee.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_Pos
            '
            Me.XrLabel_Pos.Font = New System.Drawing.Font("黑体", 13.0!)
            Me.XrLabel_Pos.Location = New System.Drawing.Point(0, 25)
            Me.XrLabel_Pos.Name = "XrLabel_Pos"
            Me.XrLabel_Pos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_Pos.ParentStyleUsing.UseFont = False
            Me.XrLabel_Pos.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_Pos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_DepositTime
            '
            Me.XrLabel_DepositTime.Location = New System.Drawing.Point(0, 92)
            Me.XrLabel_DepositTime.Name = "XrLabel_DepositTime"
            Me.XrLabel_DepositTime.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_DepositTime.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_DepositTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'ReportFooter
            '
            Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_WelcomeBack, Me.XrLabel_ServiceTel, Me.XrLabel_NTel, Me.XrLabel_TotalMoney, Me.XrLabel_TotalAmount, Me.XrLabel6})
            Me.ReportFooter.Height = 104
            Me.ReportFooter.Name = "ReportFooter"
            '
            'XrLabel_WelcomeBack
            '
            Me.XrLabel_WelcomeBack.Location = New System.Drawing.Point(0, 50)
            Me.XrLabel_WelcomeBack.Name = "XrLabel_WelcomeBack"
            Me.XrLabel_WelcomeBack.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_WelcomeBack.Size = New System.Drawing.Size(175, 25)
            Me.XrLabel_WelcomeBack.Text = "欢迎再次光临!"
            Me.XrLabel_WelcomeBack.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_ServiceTel
            '
            Me.XrLabel_ServiceTel.Location = New System.Drawing.Point(75, 25)
            Me.XrLabel_ServiceTel.Name = "XrLabel_ServiceTel"
            Me.XrLabel_ServiceTel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_ServiceTel.Size = New System.Drawing.Size(99, 25)
            Me.XrLabel_ServiceTel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_NTel
            '
            Me.XrLabel_NTel.Location = New System.Drawing.Point(0, 25)
            Me.XrLabel_NTel.Name = "XrLabel_NTel"
            Me.XrLabel_NTel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_NTel.Size = New System.Drawing.Size(75, 25)
            Me.XrLabel_NTel.Text = "服务热线:"
            Me.XrLabel_NTel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_TotalMoney
            '
            Me.XrLabel_TotalMoney.Font = New System.Drawing.Font("Century Gothic", 8.0!)
            Me.XrLabel_TotalMoney.Location = New System.Drawing.Point(117, 0)
            Me.XrLabel_TotalMoney.Name = "XrLabel_TotalMoney"
            Me.XrLabel_TotalMoney.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_TotalMoney.ParentStyleUsing.UseFont = False
            Me.XrLabel_TotalMoney.Size = New System.Drawing.Size(58, 17)
            Me.XrLabel_TotalMoney.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrLabel_TotalAmount
            '
            Me.XrLabel_TotalAmount.Font = New System.Drawing.Font("Century Gothic", 8.0!)
            Me.XrLabel_TotalAmount.Location = New System.Drawing.Point(67, 0)
            Me.XrLabel_TotalAmount.Name = "XrLabel_TotalAmount"
            Me.XrLabel_TotalAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_TotalAmount.ParentStyleUsing.UseFont = False
            Me.XrLabel_TotalAmount.Size = New System.Drawing.Size(25, 17)
            Me.XrLabel_TotalAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            '
            'XrLabel6
            '
            Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Me.XrLabel6.Location = New System.Drawing.Point(0, 0)
            Me.XrLabel6.Name = "XrLabel6"
            Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel6.ParentStyleUsing.UseFont = False
            Me.XrLabel6.Size = New System.Drawing.Size(58, 17)
            Me.XrLabel6.Text = "总计"
            Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'R_02_00102LittleList_05
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.ReportFooter})
            Me.Margins = New System.Drawing.Printing.Margins(0, 10, 10, 0)
            Me.PageHeight = 700
            Me.PageWidth = 187
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Friend WithEvents XrLabel_DepositTime As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_Employee As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_NEmployee As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_Pos As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
        Friend WithEvents XrLabel_TotalMoney As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_TotalAmount As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_ServiceTel As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_NTel As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_WelcomeBack As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_TurnoverCode As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell_RowRemark As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_WareAmount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_UnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_SumPrice As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrLabel_CompanyTitle As DevExpress.XtraReports.UI.XRLabel
    End Class

End Namespace
