Namespace Reports

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_01_00201WareLabel03
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
            Me.XRLabel_Remark = New DevExpress.XtraReports.UI.XRLabel
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XRLabel_Remark, Me.XrBarCode_WareBarcode, Me.XrLabel_WareInfo})
            Me.Detail.Height = 180
            Me.Detail.Name = "Detail"
            '
            'XrLabel_WareInfo
            '
            Me.XrLabel_WareInfo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_WareInfo.Location = New System.Drawing.Point(0, 0)
            Me.XrLabel_WareInfo.Name = "XrLabel_WareInfo"
            Me.XrLabel_WareInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_WareInfo.ParentStyleUsing.UseFont = False
            Me.XrLabel_WareInfo.Size = New System.Drawing.Size(467, 42)
            Me.XrLabel_WareInfo.Text = "WareInfo"
            '
            'XrBarCode_WareBarcode
            '
            Me.XrBarCode_WareBarcode.Location = New System.Drawing.Point(0, 84)
            Me.XrBarCode_WareBarcode.Name = "XrBarCode_WareBarcode"
            Me.XrBarCode_WareBarcode.PaddingInfo = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
            Me.XrBarCode_WareBarcode.Size = New System.Drawing.Size(467, 51)
            Me.XrBarCode_WareBarcode.Symbology = Code128Generator1
            Me.XrBarCode_WareBarcode.Text = "BR070-BTDS-3-4.5"
            Me.XrBarCode_WareBarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XRLabel_Remark
            '
            Me.XRLabel_Remark.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XRLabel_Remark.Location = New System.Drawing.Point(0, 42)
            Me.XRLabel_Remark.Name = "XRLabel_Remark"
            Me.XRLabel_Remark.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XRLabel_Remark.ParentStyleUsing.UseFont = False
            Me.XRLabel_Remark.Size = New System.Drawing.Size(467, 42)
            Me.XRLabel_Remark.Text = "XRLabel_Remark"
            '
            'R_01_00201WareLabel03
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Margins = New System.Drawing.Printing.Margins(100, 28, 100, 100)
            Me.PageHeight = 500
            Me.PageWidth = 600
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents XRLabel_Remark As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrBarCode_WareBarcode As DevExpress.XtraReports.UI.XRBarCode
        Friend WithEvents XrLabel_WareInfo As DevExpress.XtraReports.UI.XRLabel
    End Class

End Namespace

