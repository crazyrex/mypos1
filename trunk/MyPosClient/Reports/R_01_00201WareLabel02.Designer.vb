Namespace Reports


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_01_00201WareLabel02
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
            Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.XrLabel_Cash = New DevExpress.XtraReports.UI.XRLabel
            Me.XrBarCode_WareBarcode = New DevExpress.XtraReports.UI.XRBarCode
            Me.XRLabel_WareInfoEN = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_CustomCode = New DevExpress.XtraReports.UI.XRLabel
            Me.XrLabel_WareInfo = New DevExpress.XtraReports.UI.XRLabel
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_Cash, Me.XrBarCode_WareBarcode, Me.XRLabel_WareInfoEN, Me.XrLabel_CustomCode, Me.XrLabel_WareInfo})
            Me.Detail.Height = 148
            Me.Detail.Name = "Detail"
            '
            'XrLabel_Cash
            '
            Me.XrLabel_Cash.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_Cash.Location = New System.Drawing.Point(75, 117)
            Me.XrLabel_Cash.Name = "XrLabel_Cash"
            Me.XrLabel_Cash.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_Cash.ParentStyleUsing.UseFont = False
            Me.XrLabel_Cash.Size = New System.Drawing.Size(167, 25)
            Me.XrLabel_Cash.Text = "Cash"
            '
            'XrBarCode_WareBarcode
            '
            Me.XrBarCode_WareBarcode.Location = New System.Drawing.Point(67, 75)
            Me.XrBarCode_WareBarcode.Module = 1.2!
            Me.XrBarCode_WareBarcode.Name = "XrBarCode_WareBarcode"
            Me.XrBarCode_WareBarcode.PaddingInfo = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
            Me.XrBarCode_WareBarcode.Size = New System.Drawing.Size(183, 42)
            Me.XrBarCode_WareBarcode.Symbology = Code128Generator1
            Me.XrBarCode_WareBarcode.Text = "001-0001"
            Me.XrBarCode_WareBarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XRLabel_WareInfoEN
            '
            Me.XRLabel_WareInfoEN.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XRLabel_WareInfoEN.Location = New System.Drawing.Point(75, 50)
            Me.XRLabel_WareInfoEN.Name = "XRLabel_WareInfoEN"
            Me.XRLabel_WareInfoEN.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XRLabel_WareInfoEN.ParentStyleUsing.UseFont = False
            Me.XRLabel_WareInfoEN.Size = New System.Drawing.Size(167, 20)
            Me.XRLabel_WareInfoEN.Text = "XrLabel_WareInfo"
            Me.XRLabel_WareInfoEN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_CustomCode
            '
            Me.XrLabel_CustomCode.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_CustomCode.Location = New System.Drawing.Point(75, 33)
            Me.XrLabel_CustomCode.Name = "XrLabel_CustomCode"
            Me.XrLabel_CustomCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_CustomCode.ParentStyleUsing.UseFont = False
            Me.XrLabel_CustomCode.Size = New System.Drawing.Size(167, 20)
            Me.XrLabel_CustomCode.Text = "XrLabel_WareInfo"
            Me.XrLabel_CustomCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrLabel_WareInfo
            '
            Me.XrLabel_WareInfo.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_WareInfo.Location = New System.Drawing.Point(75, 17)
            Me.XrLabel_WareInfo.Name = "XrLabel_WareInfo"
            Me.XrLabel_WareInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_WareInfo.ParentStyleUsing.UseFont = False
            Me.XrLabel_WareInfo.Size = New System.Drawing.Size(167, 20)
            Me.XrLabel_WareInfo.Text = "XrLabel_WareInfo"
            Me.XrLabel_WareInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'R_01_00201WareLabel02
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Margins = New System.Drawing.Printing.Margins(0, 0, 5, 0)
            Me.PageHeight = 200
            Me.PageWidth = 291
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents XRLabel_WareInfoEN As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_CustomCode As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_WareInfo As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrLabel_Cash As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrBarCode_WareBarcode As DevExpress.XtraReports.UI.XRBarCode
    End Class

End Namespace
