Namespace Reports

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_02_00801PractWareLabel01
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
            Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel
            Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode
            Me.XrLabel_WareInfo = New DevExpress.XtraReports.UI.XRLabel
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
            Me.Detail.Height = 108
            Me.Detail.Name = "Detail"
            '
            'XrPanel1
            '
            Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_WareInfo, Me.XrBarCode1})
            Me.XrPanel1.Location = New System.Drawing.Point(8, 8)
            Me.XrPanel1.Name = "XrPanel1"
            Me.XrPanel1.Size = New System.Drawing.Size(383, 92)
            '
            'XrBarCode1
            '
            Me.XrBarCode1.Location = New System.Drawing.Point(8, 33)
            Me.XrBarCode1.Name = "XrBarCode1"
            Me.XrBarCode1.PaddingInfo = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
            Me.XrBarCode1.Size = New System.Drawing.Size(368, 51)
            Me.XrBarCode1.Symbology = Code128Generator1
            Me.XrBarCode1.Text = "1234567890"
            Me.XrBarCode1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrLabel_WareInfo
            '
            Me.XrLabel_WareInfo.Location = New System.Drawing.Point(8, 8)
            Me.XrLabel_WareInfo.Name = "XrLabel_WareInfo"
            Me.XrLabel_WareInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_WareInfo.Size = New System.Drawing.Size(368, 25)
            Me.XrLabel_WareInfo.Text = "WareInfo"
            '
            'R_01_00201WareLabel01
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.PageHeight = 300
            Me.PageWidth = 600
            Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
        Friend WithEvents XrLabel_WareInfo As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    End Class

End Namespace

