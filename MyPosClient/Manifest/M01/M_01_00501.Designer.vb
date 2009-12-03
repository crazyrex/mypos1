Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00501
        'Inherits System.Windows.Forms.UserControl
        Inherits XL.Win.Component.BaseForm

#Region" Windows 窗体设计器生成的代码"

        Public Sub New()
            MyBase.New()

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()

            '在 InitializeComponent() 调用之后添加任何初始化

        End Sub

        '窗体重写 dispose 以清理组件列表。
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Windows 窗体设计器所必需的
        Private components As System.ComponentModel.IContainer

        '注意: 以下过程是 Windows 窗体设计器所必需的
        '可以使用 Windows 窗体设计器修改此过程。
        '不要使用代码编辑器修改它。
        Friend WithEvents ToolStrip_Form As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton_Add As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.SuspendLayout()
            '
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripButton() {            Me.ToolStripButton_Add,            Me.ToolStripButton_Remove,            Me.ToolStripButton_Refresh,            Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name ="ToolStrip_Form"
            Me.ToolStrip_Form.ShowItemToolTips = True
            Me.ToolStrip_Form.Size = New System.Drawing.Size(700, 52)
            Me.ToolStrip_Form.TabIndex = 10000
            '
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Text ="添加"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Text ="去除"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Text ="刷新"
            '
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Text ="关闭"
            'M_01_00501
            '
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name ="M_01_00501"
            Me.Size = New System.Drawing.Size(700, 500)
            Me.ResumeLayout(False)

        End Sub

#End Region

    End Class

End Namespace

