Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00701
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
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00701))
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridControl2 = New DevExpress.XtraGrid.GridControl
            Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerControl1.SuspendLayout()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = "Money Twins"
            '
            'Timer_Surveillant
            '
            '
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton_Save, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(700, 25)
            Me.ToolStrip_Form.TabIndex = 10000
            CTag1.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag1.CalculatorRequired = True
            CTag1.ComboValueTextBox = Nothing
            CTag1.ControlRelatedCode = Nothing
            CTag1.DateButtonTextBox = Nothing
            CTag1.DateTimeButtonTextBox = Nothing
            CTag1.DisplayLinkControl = Nothing
            CTag1.DisplayLinkDisplayFieldName = Nothing
            CTag1.DisplayLinkKeyFieldName = Nothing
            CTag1.DisplayLinkTable = Nothing
            CTag1.FlexgridEditItem = ""
            CTag1.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag1.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag1.IsButtonCustomed = False
            CTag1.IsTextValid = True
            CTag1.KeyValueAbsentable = False
            CTag1.LeagleText = ""
            CTag1.NumericButtonTextBox = Nothing
            CTag1.ParentControl = Me.ToolStrip_Form
            CTag1.SkipValidate = False
            CTag1.TimeButtonTextBox = Nothing
            CTag1.ToolTip = ""
            CTag1.ValueType = XL.Common.ControlValueType.Character
            Me.ToolStrip_Form.Tag = CTag1
            '
            'ToolStripButton1
            '
            Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
            Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton1.Name = "ToolStripButton1"
            Me.ToolStripButton1.Size = New System.Drawing.Size(57, 22)
            Me.ToolStripButton1.Text = "导入手持"
            '
            'ToolStripButton2
            '
            Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
            Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ToolStripButton2.Name = "ToolStripButton2"
            Me.ToolStripButton2.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton2.Text = "修改"
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(57, 22)
            Me.ToolStripButton_Save.Text = "全部保存"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(33, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'GroupControl1
            '
            Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.GroupControl1.Appearance.Options.UseBackColor = True
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.GroupControl1.Location = New System.Drawing.Point(0, 25)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(700, 81)
            Me.GroupControl1.TabIndex = 10000
            '
            'SplitContainerControl1
            '
            Me.SplitContainerControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.SplitContainerControl1.Appearance.Options.UseBackColor = True
            Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 106)
            Me.SplitContainerControl1.Name = "SplitContainerControl1"
            Me.SplitContainerControl1.Panel1.Appearance.BackColor = System.Drawing.Color.White
            Me.SplitContainerControl1.Panel1.Appearance.Options.UseBackColor = True
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.GridControl1)
            Me.SplitContainerControl1.Panel1.Text = "Panel1"
            Me.SplitContainerControl1.Panel2.Appearance.BackColor = System.Drawing.Color.White
            Me.SplitContainerControl1.Panel2.Appearance.Options.UseBackColor = True
            Me.SplitContainerControl1.Panel2.Controls.Add(Me.GridControl2)
            Me.SplitContainerControl1.Panel2.Text = "Panel2"
            Me.SplitContainerControl1.Size = New System.Drawing.Size(700, 394)
            Me.SplitContainerControl1.SplitterPosition = 271
            Me.SplitContainerControl1.TabIndex = 10000
            Me.SplitContainerControl1.Text = "SplitContainerControl1"
            '
            'GridControl1
            '
            Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl1.EmbeddedNavigator.Name = ""
            Me.GridControl1.Location = New System.Drawing.Point(0, 0)
            Me.GridControl1.MainView = Me.GridView1
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.Size = New System.Drawing.Size(265, 388)
            Me.GridControl1.TabIndex = 0
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'GridView1
            '
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn10, Me.GridColumn11})
            Me.GridView1.GridControl = Me.GridControl1
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsView.ColumnAutoWidth = False
            Me.GridView1.OptionsView.ShowGroupPanel = False
            '
            'GridColumn1
            '
            Me.GridColumn1.Caption = "时间"
            Me.GridColumn1.Name = "GridColumn1"
            Me.GridColumn1.Visible = True
            Me.GridColumn1.VisibleIndex = 0
            Me.GridColumn1.Width = 36
            '
            'GridColumn2
            '
            Me.GridColumn2.Caption = "客户"
            Me.GridColumn2.Name = "GridColumn2"
            Me.GridColumn2.Visible = True
            Me.GridColumn2.VisibleIndex = 1
            Me.GridColumn2.Width = 36
            '
            'GridColumn3
            '
            Me.GridColumn3.Caption = "操作人"
            Me.GridColumn3.Name = "GridColumn3"
            Me.GridColumn3.Visible = True
            Me.GridColumn3.VisibleIndex = 2
            Me.GridColumn3.Width = 48
            '
            'GridColumn10
            '
            Me.GridColumn10.Caption = "出入类型"
            Me.GridColumn10.Name = "GridColumn10"
            Me.GridColumn10.Visible = True
            Me.GridColumn10.VisibleIndex = 3
            Me.GridColumn10.Width = 60
            '
            'GridColumn11
            '
            Me.GridColumn11.Caption = "出入形式"
            Me.GridColumn11.Name = "GridColumn11"
            Me.GridColumn11.Visible = True
            Me.GridColumn11.VisibleIndex = 4
            Me.GridColumn11.Width = 60
            '
            'GridControl2
            '
            Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl2.EmbeddedNavigator.Name = ""
            Me.GridControl2.Location = New System.Drawing.Point(0, 0)
            Me.GridControl2.MainView = Me.GridView2
            Me.GridControl2.Name = "GridControl2"
            Me.GridControl2.Size = New System.Drawing.Size(417, 388)
            Me.GridControl2.TabIndex = 1
            Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
            '
            'GridView2
            '
            Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn12, Me.GridColumn13})
            Me.GridView2.GridControl = Me.GridControl2
            Me.GridView2.Name = "GridView2"
            Me.GridView2.OptionsView.ColumnAutoWidth = False
            Me.GridView2.OptionsView.ShowGroupPanel = False
            '
            'GridColumn4
            '
            Me.GridColumn4.Caption = "货品名"
            Me.GridColumn4.Name = "GridColumn4"
            Me.GridColumn4.Visible = True
            Me.GridColumn4.VisibleIndex = 0
            Me.GridColumn4.Width = 48
            '
            'GridColumn5
            '
            Me.GridColumn5.Caption = "规格"
            Me.GridColumn5.Name = "GridColumn5"
            Me.GridColumn5.Visible = True
            Me.GridColumn5.VisibleIndex = 1
            Me.GridColumn5.Width = 36
            '
            'GridColumn6
            '
            Me.GridColumn6.Caption = "型号"
            Me.GridColumn6.Name = "GridColumn6"
            Me.GridColumn6.Visible = True
            Me.GridColumn6.VisibleIndex = 2
            Me.GridColumn6.Width = 36
            '
            'GridColumn7
            '
            Me.GridColumn7.Caption = "Attribute1"
            Me.GridColumn7.Name = "GridColumn7"
            Me.GridColumn7.Visible = True
            Me.GridColumn7.VisibleIndex = 3
            Me.GridColumn7.Width = 69
            '
            'GridColumn8
            '
            Me.GridColumn8.Caption = "Attribute2"
            Me.GridColumn8.Name = "GridColumn8"
            Me.GridColumn8.Visible = True
            Me.GridColumn8.VisibleIndex = 4
            Me.GridColumn8.Width = 69
            '
            'GridColumn9
            '
            Me.GridColumn9.Caption = "Attribute3"
            Me.GridColumn9.Name = "GridColumn9"
            Me.GridColumn9.Visible = True
            Me.GridColumn9.VisibleIndex = 5
            Me.GridColumn9.Width = 69
            '
            'GridColumn12
            '
            Me.GridColumn12.Caption = "Attribute4"
            Me.GridColumn12.Name = "GridColumn12"
            Me.GridColumn12.Visible = True
            Me.GridColumn12.VisibleIndex = 6
            Me.GridColumn12.Width = 69
            '
            'GridColumn13
            '
            Me.GridColumn13.Caption = "数量"
            Me.GridColumn13.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn13.Name = "GridColumn13"
            Me.GridColumn13.Visible = True
            Me.GridColumn13.VisibleIndex = 7
            Me.GridColumn13.Width = 36
            '
            'M_02_00701
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.SplitContainerControl1)
            Me.Controls.Add(Me.GroupControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_02_00701"
            Me.Size = New System.Drawing.Size(700, 500)
            CTag2.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag2.CalculatorRequired = True
            CTag2.ComboValueTextBox = Nothing
            CTag2.ControlRelatedCode = Nothing
            CTag2.DateButtonTextBox = Nothing
            CTag2.DateTimeButtonTextBox = Nothing
            CTag2.DisplayLinkControl = Nothing
            CTag2.DisplayLinkDisplayFieldName = Nothing
            CTag2.DisplayLinkKeyFieldName = Nothing
            CTag2.DisplayLinkTable = Nothing
            CTag2.FlexgridEditItem = ""
            CTag2.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag2.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag2.IsButtonCustomed = False
            CTag2.IsTextValid = True
            CTag2.KeyValueAbsentable = False
            CTag2.LeagleText = ""
            CTag2.NumericButtonTextBox = Nothing
            CTag2.ParentControl = Me
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag2
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerControl1.ResumeLayout(False)
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
