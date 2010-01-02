Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_01302
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
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_EditBom = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.TextEdit_TurnoverCode = New DevExpress.XtraEditors.TextEdit
            Me.Label_TurnoverCode = New System.Windows.Forms.Label
            Me.DateEdit_DepositTime = New DevExpress.XtraEditors.DateEdit
            Me.Label_TurnoverTime = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.LookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.LookUpEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextEdit_Remark = New DevExpress.XtraEditors.TextEdit
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label18 = New System.Windows.Forms.Label
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.GridControl_QuotationWareDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_QuotationWareDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_BatchCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CurrentAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitCost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_OrigionalPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.TextEdit_TurnoverCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_DepositTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_DepositTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl2.SuspendLayout()
            CType(Me.GridControl_QuotationWareDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_QuotationWareDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_EditBom, Me.ToolStripButton_Close})
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
            'ToolStripButton_EditBom
            '
            Me.ToolStripButton_EditBom.Name = "ToolStripButton_EditBom"
            Me.ToolStripButton_EditBom.Size = New System.Drawing.Size(63, 22)
            Me.ToolStripButton_EditBom.Text = "编辑Bom"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'TextEdit_TurnoverCode
            '
            Me.TextEdit_TurnoverCode.Location = New System.Drawing.Point(98, 10)
            Me.TextEdit_TurnoverCode.Name = "TextEdit_TurnoverCode"
            Me.TextEdit_TurnoverCode.Properties.ReadOnly = True
            Me.TextEdit_TurnoverCode.Size = New System.Drawing.Size(159, 21)
            Me.TextEdit_TurnoverCode.TabIndex = 10002
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
            CTag2.ParentControl = Me.TextEdit_TurnoverCode
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_TurnoverCode.Tag = CTag2
            '
            'Label_TurnoverCode
            '
            Me.Label_TurnoverCode.AutoSize = True
            Me.Label_TurnoverCode.BackColor = System.Drawing.Color.White
            Me.Label_TurnoverCode.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_TurnoverCode.ForeColor = System.Drawing.Color.Black
            Me.Label_TurnoverCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_TurnoverCode.Location = New System.Drawing.Point(21, 13)
            Me.Label_TurnoverCode.Name = "Label_TurnoverCode"
            Me.Label_TurnoverCode.Size = New System.Drawing.Size(55, 15)
            Me.Label_TurnoverCode.TabIndex = 10001
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
            CTag3.ParentControl = Me.Label_TurnoverCode
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_TurnoverCode.Tag = CTag3
            Me.Label_TurnoverCode.Text = "报价单号"
            '
            'DateEdit_DepositTime
            '
            Me.DateEdit_DepositTime.EditValue = Nothing
            Me.DateEdit_DepositTime.Location = New System.Drawing.Point(362, 10)
            Me.DateEdit_DepositTime.Name = "DateEdit_DepositTime"
            Me.DateEdit_DepositTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_DepositTime.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_DepositTime.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_DepositTime.Size = New System.Drawing.Size(95, 21)
            Me.DateEdit_DepositTime.TabIndex = 10004
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
            CTag4.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag4.IsButtonCustomed = False
            CTag4.IsTextValid = True
            CTag4.KeyValueAbsentable = False
            CTag4.LeagleText = ""
            CTag4.NumericButtonTextBox = Nothing
            CTag4.ParentControl = Me.DateEdit_DepositTime
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_DepositTime.Tag = CTag4
            '
            'Label_TurnoverTime
            '
            Me.Label_TurnoverTime.AutoSize = True
            Me.Label_TurnoverTime.BackColor = System.Drawing.Color.White
            Me.Label_TurnoverTime.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_TurnoverTime.ForeColor = System.Drawing.Color.Black
            Me.Label_TurnoverTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_TurnoverTime.Location = New System.Drawing.Point(285, 13)
            Me.Label_TurnoverTime.Name = "Label_TurnoverTime"
            Me.Label_TurnoverTime.Size = New System.Drawing.Size(55, 15)
            Me.Label_TurnoverTime.TabIndex = 10003
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
            CTag5.ParentControl = Me.Label_TurnoverTime
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label_TurnoverTime.Tag = CTag5
            Me.Label_TurnoverTime.Text = "建单时间"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(21, 45)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 15)
            Me.Label1.TabIndex = 10000
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
            CTag6.ParentControl = Me.Label1
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag6
            Me.Label1.Text = "单据类型"
            '
            'LookUpEdit_TurnoverStyle
            '
            Me.LookUpEdit_TurnoverStyle.Location = New System.Drawing.Point(98, 42)
            Me.LookUpEdit_TurnoverStyle.Name = "LookUpEdit_TurnoverStyle"
            Me.LookUpEdit_TurnoverStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit_TurnoverStyle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverStyle.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverStyle.Properties.NullText = ""
            Me.LookUpEdit_TurnoverStyle.Properties.ValueMember = "ITEM_VALUE"
            Me.LookUpEdit_TurnoverStyle.Size = New System.Drawing.Size(159, 21)
            Me.LookUpEdit_TurnoverStyle.TabIndex = 10005
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
            CTag7.ParentControl = Me.LookUpEdit_TurnoverStyle
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverStyle.Tag = CTag7
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label2.Location = New System.Drawing.Point(285, 45)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 15)
            Me.Label2.TabIndex = 10000
            CTag8.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag8.CalculatorRequired = True
            CTag8.ComboValueTextBox = Nothing
            CTag8.ControlRelatedCode = Nothing
            CTag8.DateButtonTextBox = Nothing
            CTag8.DateTimeButtonTextBox = Nothing
            CTag8.DisplayLinkControl = Nothing
            CTag8.DisplayLinkDisplayFieldName = Nothing
            CTag8.DisplayLinkKeyFieldName = Nothing
            CTag8.DisplayLinkTable = Nothing
            CTag8.FlexgridEditItem = ""
            CTag8.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag8.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag8.IsButtonCustomed = False
            CTag8.IsTextValid = True
            CTag8.KeyValueAbsentable = False
            CTag8.LeagleText = ""
            CTag8.NumericButtonTextBox = Nothing
            CTag8.ParentControl = Me.Label2
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag8
            Me.Label2.Text = "备注"
            '
            'TextEdit_Remark
            '
            Me.TextEdit_Remark.Location = New System.Drawing.Point(362, 42)
            Me.TextEdit_Remark.Name = "TextEdit_Remark"
            Me.TextEdit_Remark.Size = New System.Drawing.Size(320, 21)
            Me.TextEdit_Remark.TabIndex = 10000
            CTag9.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag9.CalculatorRequired = True
            CTag9.ComboValueTextBox = Nothing
            CTag9.ControlRelatedCode = Nothing
            CTag9.DateButtonTextBox = Nothing
            CTag9.DateTimeButtonTextBox = Nothing
            CTag9.DisplayLinkControl = Nothing
            CTag9.DisplayLinkDisplayFieldName = Nothing
            CTag9.DisplayLinkKeyFieldName = Nothing
            CTag9.DisplayLinkTable = Nothing
            CTag9.FlexgridEditItem = ""
            CTag9.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag9.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag9.IsButtonCustomed = False
            CTag9.IsTextValid = True
            CTag9.KeyValueAbsentable = False
            CTag9.LeagleText = ""
            CTag9.NumericButtonTextBox = Nothing
            CTag9.ParentControl = Me.TextEdit_Remark
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Remark.Tag = CTag9
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Controls.Add(Me.LookUpEdit_TurnoverStyle)
            Me.PanelControl1.Controls.Add(Me.Label_TurnoverCode)
            Me.PanelControl1.Controls.Add(Me.DateEdit_DepositTime)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Controls.Add(Me.Label4)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.Label_TurnoverTime)
            Me.PanelControl1.Controls.Add(Me.TextEdit_TurnoverCode)
            Me.PanelControl1.Controls.Add(Me.TextEdit_Remark)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(700, 72)
            Me.PanelControl1.TabIndex = 10006
            CTag12.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag12.CalculatorRequired = True
            CTag12.ComboValueTextBox = Nothing
            CTag12.ControlRelatedCode = Nothing
            CTag12.DateButtonTextBox = Nothing
            CTag12.DateTimeButtonTextBox = Nothing
            CTag12.DisplayLinkControl = Nothing
            CTag12.DisplayLinkDisplayFieldName = Nothing
            CTag12.DisplayLinkKeyFieldName = Nothing
            CTag12.DisplayLinkTable = Nothing
            CTag12.FlexgridEditItem = ""
            CTag12.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag12.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag12.IsButtonCustomed = False
            CTag12.IsTextValid = True
            CTag12.KeyValueAbsentable = False
            CTag12.LeagleText = ""
            CTag12.NumericButtonTextBox = Nothing
            CTag12.ParentControl = Me.PanelControl1
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag12
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label4.Location = New System.Drawing.Point(602, 12)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(80, 25)
            Me.Label4.TabIndex = 10003
            CTag10.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag10.CalculatorRequired = True
            CTag10.ComboValueTextBox = Nothing
            CTag10.ControlRelatedCode = Nothing
            CTag10.DateButtonTextBox = Nothing
            CTag10.DateTimeButtonTextBox = Nothing
            CTag10.DisplayLinkControl = Nothing
            CTag10.DisplayLinkDisplayFieldName = Nothing
            CTag10.DisplayLinkKeyFieldName = Nothing
            CTag10.DisplayLinkTable = Nothing
            CTag10.FlexgridEditItem = ""
            CTag10.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag10.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag10.IsButtonCustomed = False
            CTag10.IsTextValid = True
            CTag10.KeyValueAbsentable = False
            CTag10.LeagleText = ""
            CTag10.NumericButtonTextBox = Nothing
            CTag10.ParentControl = Me.Label4
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag10
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(518, 14)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 15)
            Me.Label3.TabIndex = 10003
            CTag11.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag11.CalculatorRequired = True
            CTag11.ComboValueTextBox = Nothing
            CTag11.ControlRelatedCode = Nothing
            CTag11.DateButtonTextBox = Nothing
            CTag11.DateTimeButtonTextBox = Nothing
            CTag11.DisplayLinkControl = Nothing
            CTag11.DisplayLinkDisplayFieldName = Nothing
            CTag11.DisplayLinkKeyFieldName = Nothing
            CTag11.DisplayLinkTable = Nothing
            CTag11.FlexgridEditItem = ""
            CTag11.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag11.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag11.IsButtonCustomed = False
            CTag11.IsTextValid = True
            CTag11.KeyValueAbsentable = False
            CTag11.LeagleText = ""
            CTag11.NumericButtonTextBox = Nothing
            CTag11.ParentControl = Me.Label3
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag11
            Me.Label3.Text = "最后修订人"
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BackColor = System.Drawing.Color.White
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_CustomCode.ForeColor = System.Drawing.Color.Black
            Me.Label_CustomCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_CustomCode.Location = New System.Drawing.Point(221, 6)
            Me.Label_CustomCode.Name = "Label_CustomCode"
            Me.Label_CustomCode.Size = New System.Drawing.Size(137, 28)
            Me.Label_CustomCode.TabIndex = 10010
            CTag13.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag13.CalculatorRequired = True
            CTag13.ComboValueTextBox = Nothing
            CTag13.ControlRelatedCode = Nothing
            CTag13.DateButtonTextBox = Nothing
            CTag13.DateTimeButtonTextBox = Nothing
            CTag13.DisplayLinkControl = Nothing
            CTag13.DisplayLinkDisplayFieldName = Nothing
            CTag13.DisplayLinkKeyFieldName = Nothing
            CTag13.DisplayLinkTable = Nothing
            CTag13.FlexgridEditItem = ""
            CTag13.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.Label_CustomCode
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag13
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(99, 9)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10009
            CTag14.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag14.CalculatorRequired = True
            CTag14.ComboValueTextBox = Nothing
            CTag14.ControlRelatedCode = Nothing
            CTag14.DateButtonTextBox = Nothing
            CTag14.DateTimeButtonTextBox = Nothing
            CTag14.DisplayLinkControl = Nothing
            CTag14.DisplayLinkDisplayFieldName = Nothing
            CTag14.DisplayLinkKeyFieldName = Nothing
            CTag14.DisplayLinkTable = Nothing
            CTag14.FlexgridEditItem = ""
            CTag14.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag14.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag14.IsButtonCustomed = False
            CTag14.IsTextValid = True
            CTag14.KeyValueAbsentable = False
            CTag14.LeagleText = ""
            CTag14.NumericButtonTextBox = Nothing
            CTag14.ParentControl = Me.ButtonEdit_WareCode
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag14
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.BackColor = System.Drawing.Color.White
            Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label18.ForeColor = System.Drawing.Color.Black
            Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label18.Location = New System.Drawing.Point(14, 12)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(79, 15)
            Me.Label18.TabIndex = 10008
            CTag15.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag15.CalculatorRequired = True
            CTag15.ComboValueTextBox = Nothing
            CTag15.ControlRelatedCode = Nothing
            CTag15.DateButtonTextBox = Nothing
            CTag15.DateTimeButtonTextBox = Nothing
            CTag15.DisplayLinkControl = Nothing
            CTag15.DisplayLinkDisplayFieldName = Nothing
            CTag15.DisplayLinkKeyFieldName = Nothing
            CTag15.DisplayLinkTable = Nothing
            CTag15.FlexgridEditItem = ""
            CTag15.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me.Label18
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag15
            Me.Label18.Text = "添加显示货品"
            '
            'PanelControl2
            '
            Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl2.Appearance.Options.UseBackColor = True
            Me.PanelControl2.Controls.Add(Me.Label_WareID)
            Me.PanelControl2.Controls.Add(Me.Label18)
            Me.PanelControl2.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl2.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl2.Location = New System.Drawing.Point(2, 21)
            Me.PanelControl2.Name = "PanelControl2"
            Me.PanelControl2.Size = New System.Drawing.Size(696, 41)
            Me.PanelControl2.TabIndex = 10007
            CTag17.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag17.CalculatorRequired = True
            CTag17.ComboValueTextBox = Nothing
            CTag17.ControlRelatedCode = Nothing
            CTag17.DateButtonTextBox = Nothing
            CTag17.DateTimeButtonTextBox = Nothing
            CTag17.DisplayLinkControl = Nothing
            CTag17.DisplayLinkDisplayFieldName = Nothing
            CTag17.DisplayLinkKeyFieldName = Nothing
            CTag17.DisplayLinkTable = Nothing
            CTag17.FlexgridEditItem = ""
            CTag17.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag17.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag17.IsButtonCustomed = False
            CTag17.IsTextValid = True
            CTag17.KeyValueAbsentable = False
            CTag17.LeagleText = ""
            CTag17.NumericButtonTextBox = Nothing
            CTag17.ParentControl = Me.PanelControl2
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl2.Tag = CTag17
            '
            'Label_WareID
            '
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(333, 9)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(25, 18)
            Me.Label_WareID.TabIndex = 10012
            CTag16.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag16.CalculatorRequired = True
            CTag16.ComboValueTextBox = Nothing
            CTag16.ControlRelatedCode = Nothing
            CTag16.DateButtonTextBox = Nothing
            CTag16.DateTimeButtonTextBox = Nothing
            CTag16.DisplayLinkControl = Nothing
            CTag16.DisplayLinkDisplayFieldName = Nothing
            CTag16.DisplayLinkKeyFieldName = Nothing
            CTag16.DisplayLinkTable = Nothing
            CTag16.FlexgridEditItem = ""
            CTag16.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag16.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag16.IsButtonCustomed = False
            CTag16.IsTextValid = True
            CTag16.KeyValueAbsentable = False
            CTag16.LeagleText = ""
            CTag16.NumericButtonTextBox = Nothing
            CTag16.ParentControl = Me.Label_WareID
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag16
            Me.Label_WareID.Text = "ID"
            Me.Label_WareID.Visible = False
            '
            'GridControl_QuotationWareDtl
            '
            Me.GridControl_QuotationWareDtl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_QuotationWareDtl.EmbeddedNavigator.Name = ""
            CTag18.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag18.CalculatorRequired = True
            CTag18.ComboValueTextBox = Nothing
            CTag18.ControlRelatedCode = Nothing
            CTag18.DateButtonTextBox = Nothing
            CTag18.DateTimeButtonTextBox = Nothing
            CTag18.DisplayLinkControl = Nothing
            CTag18.DisplayLinkDisplayFieldName = Nothing
            CTag18.DisplayLinkKeyFieldName = Nothing
            CTag18.DisplayLinkTable = Nothing
            CTag18.FlexgridEditItem = ""
            CTag18.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag18.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag18.IsButtonCustomed = False
            CTag18.IsTextValid = True
            CTag18.KeyValueAbsentable = False
            CTag18.LeagleText = ""
            CTag18.NumericButtonTextBox = Nothing
            CTag18.ParentControl = Me.GridControl_QuotationWareDtl.EmbeddedNavigator
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_QuotationWareDtl.EmbeddedNavigator.Tag = CTag18
            Me.GridControl_QuotationWareDtl.Location = New System.Drawing.Point(2, 62)
            Me.GridControl_QuotationWareDtl.MainView = Me.GridView_QuotationWareDtl
            Me.GridControl_QuotationWareDtl.Name = "GridControl_QuotationWareDtl"
            Me.GridControl_QuotationWareDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_QuotationWareDtl.Size = New System.Drawing.Size(696, 339)
            Me.GridControl_QuotationWareDtl.TabIndex = 10008
            Me.GridControl_QuotationWareDtl.TabStop = False
            Me.GridControl_QuotationWareDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_QuotationWareDtl})
            '
            'GridView_QuotationWareDtl
            '
            Me.GridView_QuotationWareDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_BatchCode, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_WareAmount, Me.GridColumn_SumPrice, Me.GridColumn_CurrentAmount, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_UnitCost, Me.GridColumn_OrigionalPrice, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "ROW_HIGHLIGHT_OUT_OF_STOCK"
            Me.GridView_QuotationWareDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_QuotationWareDtl.GridControl = Me.GridControl_QuotationWareDtl
            Me.GridView_QuotationWareDtl.Name = "GridView_QuotationWareDtl"
            Me.GridView_QuotationWareDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_QuotationWareDtl.OptionsView.ShowFooter = True
            Me.GridView_QuotationWareDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_BatchCode
            '
            Me.GridColumn_BatchCode.Caption = "批号"
            Me.GridColumn_BatchCode.FieldName = "BATCH_CODE"
            Me.GridColumn_BatchCode.Name = "GridColumn_BatchCode"
            Me.GridColumn_BatchCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_BatchCode.Visible = True
            Me.GridColumn_BatchCode.VisibleIndex = 0
            Me.GridColumn_BatchCode.Width = 36
            '
            'GridColumn_WareCode
            '
            Me.GridColumn_WareCode.Caption = "货品代码"
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_WareCode.Visible = True
            Me.GridColumn_WareCode.VisibleIndex = 1
            Me.GridColumn_WareCode.Width = 60
            '
            'GridColumn_CustomCode
            '
            Me.GridColumn_CustomCode.Caption = "自定货号"
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomCode.Visible = True
            Me.GridColumn_CustomCode.VisibleIndex = 2
            Me.GridColumn_CustomCode.Width = 60
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "货品名称"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 3
            Me.GridColumn_WareName.Width = 60
            '
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "货品规格"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 4
            Me.GridColumn_Spec.Width = 60
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "货品型号"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 5
            Me.GridColumn_Model.Width = 60
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "属性1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 6
            Me.GridColumn_Attribute1.Width = 43
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "属性2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 7
            Me.GridColumn_Attribute2.Width = 43
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "属性3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 8
            Me.GridColumn_Attribute3.Width = 43
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "属性4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 9
            Me.GridColumn_Attribute4.Width = 43
            '
            'GridColumn_WareAmount
            '
            Me.GridColumn_WareAmount.Caption = "数量"
            Me.GridColumn_WareAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_WareAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_WareAmount.FieldName = "WARE_AMOUNT"
            Me.GridColumn_WareAmount.Name = "GridColumn_WareAmount"
            Me.GridColumn_WareAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_WareAmount.Visible = True
            Me.GridColumn_WareAmount.VisibleIndex = 10
            Me.GridColumn_WareAmount.Width = 36
            '
            'GridColumn_SumPrice
            '
            Me.GridColumn_SumPrice.Caption = "总价"
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumPrice.SummaryItem.DisplayFormat = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_SumPrice.Visible = True
            Me.GridColumn_SumPrice.VisibleIndex = 11
            Me.GridColumn_SumPrice.Width = 36
            '
            'GridColumn_CurrentAmount
            '
            Me.GridColumn_CurrentAmount.Caption = "当前在库数量"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_CurrentAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_CurrentAmount.FieldName = "CURRENT_AMOUNT"
            Me.GridColumn_CurrentAmount.Name = "GridColumn_CurrentAmount"
            Me.GridColumn_CurrentAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_CurrentAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            Me.GridColumn_CurrentAmount.Visible = True
            Me.GridColumn_CurrentAmount.VisibleIndex = 12
            Me.GridColumn_CurrentAmount.Width = 84
            '
            'GridColumn_UnitName
            '
            Me.GridColumn_UnitName.Caption = "单位"
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitName.Visible = True
            Me.GridColumn_UnitName.VisibleIndex = 13
            Me.GridColumn_UnitName.Width = 36
            '
            'GridColumn_UnitPrice
            '
            Me.GridColumn_UnitPrice.Caption = "出货价"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitPrice.Visible = True
            Me.GridColumn_UnitPrice.VisibleIndex = 14
            Me.GridColumn_UnitPrice.Width = 48
            '
            'GridColumn_UnitCost
            '
            Me.GridColumn_UnitCost.Caption = "成本"
            Me.GridColumn_UnitCost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitCost.FieldName = "UNIT_COST"
            Me.GridColumn_UnitCost.Name = "GridColumn_UnitCost"
            Me.GridColumn_UnitCost.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitCost.Visible = True
            Me.GridColumn_UnitCost.VisibleIndex = 15
            Me.GridColumn_UnitCost.Width = 36
            '
            'GridColumn_OrigionalPrice
            '
            Me.GridColumn_OrigionalPrice.Caption = "原单价"
            Me.GridColumn_OrigionalPrice.FieldName = "ORIGION_UNIT_PRICE"
            Me.GridColumn_OrigionalPrice.Name = "GridColumn_OrigionalPrice"
            Me.GridColumn_OrigionalPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_OrigionalPrice.Visible = True
            Me.GridColumn_OrigionalPrice.VisibleIndex = 16
            '
            'GridColumn_Remarks
            '
            Me.GridColumn_Remarks.Caption = "备注"
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remarks.Visible = True
            Me.GridColumn_Remarks.VisibleIndex = 17
            Me.GridColumn_Remarks.Width = 36
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            Me.GridColumn_RowHighlight.Width = 60
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'GroupControl1
            '
            Me.GroupControl1.Controls.Add(Me.GridControl_QuotationWareDtl)
            Me.GroupControl1.Controls.Add(Me.PanelControl2)
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupControl1.Location = New System.Drawing.Point(0, 97)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(700, 403)
            Me.GroupControl1.TabIndex = 10000
            Me.GroupControl1.Text = "货品明细"
            '
            'M_02_01302
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GroupControl1)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_02_01302"
            Me.Size = New System.Drawing.Size(700, 500)
            CTag19.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag19.CalculatorRequired = True
            CTag19.ComboValueTextBox = Nothing
            CTag19.ControlRelatedCode = Nothing
            CTag19.DateButtonTextBox = Nothing
            CTag19.DateTimeButtonTextBox = Nothing
            CTag19.DisplayLinkControl = Nothing
            CTag19.DisplayLinkDisplayFieldName = Nothing
            CTag19.DisplayLinkKeyFieldName = Nothing
            CTag19.DisplayLinkTable = Nothing
            CTag19.FlexgridEditItem = ""
            CTag19.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag19.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag19.IsButtonCustomed = False
            CTag19.IsTextValid = True
            CTag19.KeyValueAbsentable = False
            CTag19.LeagleText = ""
            CTag19.NumericButtonTextBox = Nothing
            CTag19.ParentControl = Me
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag19
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.TextEdit_TurnoverCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_DepositTime.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_DepositTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl2.ResumeLayout(False)
            Me.PanelControl2.PerformLayout()
            CType(Me.GridControl_QuotationWareDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_QuotationWareDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents TextEdit_TurnoverCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label_TurnoverCode As System.Windows.Forms.Label
        Friend WithEvents DateEdit_DepositTime As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label_TurnoverTime As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_TurnoverStyle As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Remark As DevExpress.XtraEditors.TextEdit
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents ToolStripButton_EditBom As System.Windows.Forms.ToolStripButton
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents GridControl_QuotationWareDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_QuotationWareDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_BatchCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CurrentAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitCost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_OrigionalPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents Label_WareID As System.Windows.Forms.Label

#End Region

    End Class

End Namespace

