Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_01002
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
            Me.components = New System.ComponentModel.Container
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.TextEdit_ReliefTurnoverCode = New DevExpress.XtraEditors.TextEdit
            Me.Label7 = New System.Windows.Forms.Label
            Me.Label_ReliefTurnoverID = New System.Windows.Forms.Label
            Me.Label_ReliefTurnoverInfo = New System.Windows.Forms.Label
            Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.CheckEdit_IsCacheData = New DevExpress.XtraEditors.CheckEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.TextEdit_ReliefTurnoverCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_IsCacheData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DefaultLookAndFeel_Form
            '
            Me.DefaultLookAndFeel_Form.LookAndFeel.SkinName = ""
            '
            'Timer_Surveillant
            '
            '
            'ToolStrip_Form
            '
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(337, 25)
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
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Save.Text = "保存"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'TextEdit_ReliefTurnoverCode
            '
            Me.TextEdit_ReliefTurnoverCode.Location = New System.Drawing.Point(90, 39)
            Me.TextEdit_ReliefTurnoverCode.Name = "TextEdit_ReliefTurnoverCode"
            Me.TextEdit_ReliefTurnoverCode.Size = New System.Drawing.Size(211, 20)
            Me.TextEdit_ReliefTurnoverCode.TabIndex = 10002
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
            CTag2.ParentControl = Me.TextEdit_ReliefTurnoverCode
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_ReliefTurnoverCode.Tag = CTag2
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.BackColor = System.Drawing.Color.White
            Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label7.ForeColor = System.Drawing.Color.Black
            Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label7.Location = New System.Drawing.Point(17, 41)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(67, 15)
            Me.Label7.TabIndex = 10001
            CTag3.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag3.CalculatorRequired = True
            CTag3.ComboValueTextBox = Nothing
            CTag3.ControlRelatedCode = Nothing
            CTag3.DateButtonTextBox = Nothing
            CTag3.DateTimeButtonTextBox = Nothing
            CTag3.DisplayLinkControl = Nothing
            CTag3.DisplayLinkDisplayFieldName = Nothing
            CTag3.DisplayLinkKeyFieldName = Nothing
            CTag3.DisplayLinkTable = Nothing
            CTag3.FlexgridEditItem = ""
            CTag3.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag3.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag3.IsButtonCustomed = False
            CTag3.IsTextValid = True
            CTag3.KeyValueAbsentable = False
            CTag3.LeagleText = ""
            CTag3.NumericButtonTextBox = Nothing
            CTag3.ParentControl = Me.Label7
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label7.Tag = CTag3
            Me.Label7.Text = "待退货单号"
            '
            'Label_ReliefTurnoverID
            '
            Me.Label_ReliefTurnoverID.AutoSize = True
            Me.Label_ReliefTurnoverID.BackColor = System.Drawing.Color.White
            Me.Label_ReliefTurnoverID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_ReliefTurnoverID.ForeColor = System.Drawing.Color.Black
            Me.Label_ReliefTurnoverID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_ReliefTurnoverID.Location = New System.Drawing.Point(234, 169)
            Me.Label_ReliefTurnoverID.Name = "Label_ReliefTurnoverID"
            Me.Label_ReliefTurnoverID.Size = New System.Drawing.Size(67, 15)
            Me.Label_ReliefTurnoverID.TabIndex = 10000
            CTag4.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag4.CalculatorRequired = True
            CTag4.ComboValueTextBox = Nothing
            CTag4.ControlRelatedCode = Nothing
            CTag4.DateButtonTextBox = Nothing
            CTag4.DateTimeButtonTextBox = Nothing
            CTag4.DisplayLinkControl = Nothing
            CTag4.DisplayLinkDisplayFieldName = Nothing
            CTag4.DisplayLinkKeyFieldName = Nothing
            CTag4.DisplayLinkTable = Nothing
            CTag4.FlexgridEditItem = ""
            CTag4.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag4.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag4.IsButtonCustomed = False
            CTag4.IsTextValid = True
            CTag4.KeyValueAbsentable = False
            CTag4.LeagleText = ""
            CTag4.NumericButtonTextBox = Nothing
            CTag4.ParentControl = Me.Label_ReliefTurnoverID
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ReliefTurnoverID.Tag = CTag4
            Me.Label_ReliefTurnoverID.Text = "待退货单ID"
            '
            'Label_ReliefTurnoverInfo
            '
            Me.Label_ReliefTurnoverInfo.BackColor = System.Drawing.Color.White
            Me.Label_ReliefTurnoverInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_ReliefTurnoverInfo.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_ReliefTurnoverInfo.ForeColor = System.Drawing.Color.Black
            Me.Label_ReliefTurnoverInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_ReliefTurnoverInfo.Location = New System.Drawing.Point(90, 71)
            Me.Label_ReliefTurnoverInfo.Name = "Label_ReliefTurnoverInfo"
            Me.Label_ReliefTurnoverInfo.Size = New System.Drawing.Size(211, 113)
            Me.Label_ReliefTurnoverInfo.TabIndex = 10000
            CTag5.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag5.CalculatorRequired = True
            CTag5.ComboValueTextBox = Nothing
            CTag5.ControlRelatedCode = Nothing
            CTag5.DateButtonTextBox = Nothing
            CTag5.DateTimeButtonTextBox = Nothing
            CTag5.DisplayLinkControl = Nothing
            CTag5.DisplayLinkDisplayFieldName = Nothing
            CTag5.DisplayLinkKeyFieldName = Nothing
            CTag5.DisplayLinkTable = Nothing
            CTag5.FlexgridEditItem = ""
            CTag5.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag5.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag5.IsButtonCustomed = False
            CTag5.IsTextValid = True
            CTag5.KeyValueAbsentable = False
            CTag5.LeagleText = ""
            CTag5.NumericButtonTextBox = Nothing
            CTag5.ParentControl = Me.Label_ReliefTurnoverInfo
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ReliefTurnoverInfo.Tag = CTag5
            '
            'CheckEdit_IsCacheData
            '
            Me.CheckEdit_IsCacheData.Location = New System.Drawing.Point(88, 187)
            Me.CheckEdit_IsCacheData.Name = "CheckEdit_IsCacheData"
            Me.CheckEdit_IsCacheData.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.CheckEdit_IsCacheData.Properties.Appearance.Options.UseBackColor = True
            Me.CheckEdit_IsCacheData.Properties.Caption = "缓存数据"
            Me.CheckEdit_IsCacheData.Size = New System.Drawing.Size(75, 19)
            Me.CheckEdit_IsCacheData.TabIndex = 10000
            Me.CheckEdit_IsCacheData.TabStop = False
            CTag6.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag6.CalculatorRequired = True
            CTag6.ComboValueTextBox = Nothing
            CTag6.ControlRelatedCode = Nothing
            CTag6.DateButtonTextBox = Nothing
            CTag6.DateTimeButtonTextBox = Nothing
            CTag6.DisplayLinkControl = Nothing
            CTag6.DisplayLinkDisplayFieldName = Nothing
            CTag6.DisplayLinkKeyFieldName = Nothing
            CTag6.DisplayLinkTable = Nothing
            CTag6.FlexgridEditItem = ""
            CTag6.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag6.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag6.IsButtonCustomed = False
            CTag6.IsTextValid = True
            CTag6.KeyValueAbsentable = False
            CTag6.LeagleText = ""
            CTag6.NumericButtonTextBox = Nothing
            CTag6.ParentControl = Me.CheckEdit_IsCacheData
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_IsCacheData.Tag = CTag6
            '
            'M_02_01002
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.CheckEdit_IsCacheData)
            Me.Controls.Add(Me.Label_ReliefTurnoverID)
            Me.Controls.Add(Me.Label_ReliefTurnoverInfo)
            Me.Controls.Add(Me.TextEdit_ReliefTurnoverCode)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_01002"
            Me.Size = New System.Drawing.Size(337, 247)
            CTag7.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag7.CalculatorRequired = True
            CTag7.ComboValueTextBox = Nothing
            CTag7.ControlRelatedCode = Nothing
            CTag7.DateButtonTextBox = Nothing
            CTag7.DateTimeButtonTextBox = Nothing
            CTag7.DisplayLinkControl = Nothing
            CTag7.DisplayLinkDisplayFieldName = Nothing
            CTag7.DisplayLinkKeyFieldName = Nothing
            CTag7.DisplayLinkTable = Nothing
            CTag7.FlexgridEditItem = ""
            CTag7.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag7.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag7.IsButtonCustomed = False
            CTag7.IsTextValid = True
            CTag7.KeyValueAbsentable = False
            CTag7.LeagleText = ""
            CTag7.NumericButtonTextBox = Nothing
            CTag7.ParentControl = Me
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag7
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.TextEdit_ReliefTurnoverCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_IsCacheData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TextEdit_ReliefTurnoverCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label_ReliefTurnoverID As System.Windows.Forms.Label
        Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Friend WithEvents Label_ReliefTurnoverInfo As System.Windows.Forms.Label
        Friend WithEvents CheckEdit_IsCacheData As DevExpress.XtraEditors.CheckEdit

#End Region

    End Class

End Namespace

