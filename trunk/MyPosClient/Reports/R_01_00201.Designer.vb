Namespace Reports

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_01_00201
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
            Me.XrLabel_WareInfo = New DevExpress.XtraReports.UI.XRLabel
            Me.XrBarCode_WareBarcode = New DevExpress.XtraReports.UI.XRBarCode
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode_WareBarcode, Me.XrLabel_WareInfo})
            Me.Detail.Name = "Detail"
            '
            'XrLabel_WareInfo
            '
            Me.XrLabel_WareInfo.Location = New System.Drawing.Point(0, 0)
            Me.XrLabel_WareInfo.Name = "XrLabel_WareInfo"
            Me.XrLabel_WareInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_WareInfo.Size = New System.Drawing.Size(575, 25)
            Me.XrLabel_WareInfo.Text = "WareInfo"
            '
            'XrBarCode_WareBarcode
            '
            Me.XrBarCode_WareBarcode.Location = New System.Drawing.Point(0, 25)
            Me.XrBarCode_WareBarcode.Name = "XrBarCode_WareBarcode"
            Me.XrBarCode_WareBarcode.PaddingInfo = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
            Me.XrBarCode_WareBarcode.Size = New System.Drawing.Size(575, 58)
            Me.XrBarCode_WareBarcode.Symbology = Code128Generator1
            Me.XrBarCode_WareBarcode.Text = "SF29539T-60(PR539-60)"
            Me.XrBarCode_WareBarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'R_01_00201
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Margins = New System.Drawing.Printing.Margins(100, 158, 100, 100)
            Me.PageHeight = 300
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents XrLabel_WareInfo As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrBarCode_WareBarcode As DevExpress.XtraReports.UI.XRBarCode
    End Class

End Namespace
