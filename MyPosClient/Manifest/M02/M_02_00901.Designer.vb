Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00901
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
        Friend WithEvents ToolStripButton_Create As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_PrintLabels As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag22 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag20 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag23 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag24 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_PrintLabels = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.Label_SupplierID = New System.Windows.Forms.Label
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label18 = New System.Windows.Forms.Label
            Me.Label_SupplierName = New System.Windows.Forms.Label
            Me.ButtonEdit_SupplierCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label_Supplier = New System.Windows.Forms.Label
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.TextEdit_PractWareCode = New DevExpress.XtraEditors.TextEdit
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextEdit_TurnoverCode = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_PratcWare = New DevExpress.XtraGrid.GridControl
            Me.GridView_PractWare = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_PractWareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowSelect = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_SupplierCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_PractWareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_TurnoverCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_PratcWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_PractWare, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_PrintLabels, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(660, 25)
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
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            Me.ToolStripButton_Create.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Create.Text = "新建"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            Me.ToolStripButton_Revise.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Revise.Text = "修改"
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            Me.ToolStripButton_Delete.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Delete.Text = "删除"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Refresh.Text = "刷新"
            '
            'ToolStripButton_Print
            '
            Me.ToolStripButton_PrintLabels.Name = "ToolStripButton_Print"
            Me.ToolStripButton_PrintLabels.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_PrintLabels.Text = "打印"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Close.Text = "关闭"
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.Label_SupplierID)
            Me.PanelControl1.Controls.Add(Me.Label_WareID)
            Me.PanelControl1.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl1.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl1.Controls.Add(Me.Label18)
            Me.PanelControl1.Controls.Add(Me.Label_SupplierName)
            Me.PanelControl1.Controls.Add(Me.ButtonEdit_SupplierCode)
            Me.PanelControl1.Controls.Add(Me.Label_Supplier)
            Me.PanelControl1.Controls.Add(Me.LookUpEdit_Pos)
            Me.PanelControl1.Controls.Add(Me.DateEdit_ToDate)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.DateEdit_FromDate)
            Me.PanelControl1.Controls.Add(Me.Label5)
            Me.PanelControl1.Controls.Add(Me.Label4)
            Me.PanelControl1.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl1.Controls.Add(Me.TextEdit_PractWareCode)
            Me.PanelControl1.Controls.Add(Me.Label6)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Controls.Add(Me.TextEdit_TurnoverCode)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(660, 127)
            Me.PanelControl1.TabIndex = 10000
            CTag22.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag22.CalculatorRequired = True
            CTag22.ComboValueTextBox = Nothing
            CTag22.ControlRelatedCode = Nothing
            CTag22.DateButtonTextBox = Nothing
            CTag22.DateTimeButtonTextBox = Nothing
            CTag22.DisplayLinkControl = Nothing
            CTag22.DisplayLinkDisplayFieldName = Nothing
            CTag22.DisplayLinkKeyFieldName = Nothing
            CTag22.DisplayLinkTable = Nothing
            CTag22.FlexgridEditItem = ""
            CTag22.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag22.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag22.IsButtonCustomed = False
            CTag22.IsTextValid = True
            CTag22.KeyValueAbsentable = False
            CTag22.LeagleText = ""
            CTag22.NumericButtonTextBox = Nothing
            CTag22.ParentControl = Me.PanelControl1
            CTag22.SkipValidate = False
            CTag22.TimeButtonTextBox = Nothing
            CTag22.ToolTip = ""
            CTag22.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag22
            '
            'Label_SupplierID
            '
            Me.Label_SupplierID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_SupplierID.Location = New System.Drawing.Point(362, 41)
            Me.Label_SupplierID.Name = "Label_SupplierID"
            Me.Label_SupplierID.Size = New System.Drawing.Size(25, 18)
            Me.Label_SupplierID.TabIndex = 10017
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
            CTag2.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag2.IsButtonCustomed = False
            CTag2.IsTextValid = True
            CTag2.KeyValueAbsentable = False
            CTag2.LeagleText = ""
            CTag2.NumericButtonTextBox = Nothing
            CTag2.ParentControl = Me.Label_SupplierID
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierID.Tag = CTag2
            Me.Label_SupplierID.Text = "ID"
            Me.Label_SupplierID.Visible = False
            '
            'Label_WareID
            '
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(362, 68)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(25, 18)
            Me.Label_WareID.TabIndex = 10016
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
            CTag3.ParentControl = Me.Label_WareID
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag3
            Me.Label_WareID.Text = "ID"
            Me.Label_WareID.Visible = False
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_CustomCode.Location = New System.Drawing.Point(219, 67)
            Me.Label_CustomCode.Name = "Label_CustomCode"
            Me.Label_CustomCode.Size = New System.Drawing.Size(137, 18)
            Me.Label_CustomCode.TabIndex = 10015
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
            CTag4.ParentControl = Me.Label_CustomCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag4
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(97, 65)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10014
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
            CTag5.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag5.IsButtonCustomed = False
            CTag5.IsTextValid = True
            CTag5.KeyValueAbsentable = False
            CTag5.LeagleText = ""
            CTag5.NumericButtonTextBox = Nothing
            CTag5.ParentControl = Me.ButtonEdit_WareCode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag5
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label18.Location = New System.Drawing.Point(18, 68)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 15)
            Me.Label18.TabIndex = 10013
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
            CTag6.ParentControl = Me.Label18
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag6
            Me.Label18.Text = "货品代码"
            '
            'Label_SupplierName
            '
            Me.Label_SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_SupplierName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_SupplierName.Location = New System.Drawing.Point(219, 40)
            Me.Label_SupplierName.Name = "Label_SupplierName"
            Me.Label_SupplierName.Size = New System.Drawing.Size(137, 18)
            Me.Label_SupplierName.TabIndex = 10012
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
            CTag7.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag7.IsButtonCustomed = False
            CTag7.IsTextValid = True
            CTag7.KeyValueAbsentable = False
            CTag7.LeagleText = ""
            CTag7.NumericButtonTextBox = Nothing
            CTag7.ParentControl = Me.Label_SupplierName
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierName.Tag = CTag7
            '
            'ButtonEdit_SupplierCode
            '
            Me.ButtonEdit_SupplierCode.Location = New System.Drawing.Point(97, 38)
            Me.ButtonEdit_SupplierCode.Name = "ButtonEdit_SupplierCode"
            Me.ButtonEdit_SupplierCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_SupplierCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_SupplierCode.TabIndex = 10011
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
            CTag8.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag8.IsButtonCustomed = False
            CTag8.IsTextValid = True
            CTag8.KeyValueAbsentable = False
            CTag8.LeagleText = ""
            CTag8.NumericButtonTextBox = Nothing
            CTag8.ParentControl = Me.ButtonEdit_SupplierCode
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_SupplierCode.Tag = CTag8
            '
            'Label_Supplier
            '
            Me.Label_Supplier.AutoSize = True
            Me.Label_Supplier.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_Supplier.Location = New System.Drawing.Point(18, 41)
            Me.Label_Supplier.Name = "Label_Supplier"
            Me.Label_Supplier.Size = New System.Drawing.Size(43, 15)
            Me.Label_Supplier.TabIndex = 10010
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
            CTag9.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag9.IsButtonCustomed = False
            CTag9.IsTextValid = True
            CTag9.KeyValueAbsentable = False
            CTag9.LeagleText = ""
            CTag9.NumericButtonTextBox = Nothing
            CTag9.ParentControl = Me.Label_Supplier
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label_Supplier.Tag = CTag9
            Me.Label_Supplier.Text = "供应商"
            '
            'Label_SupplierID
            '
            Me.Label_SupplierID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_SupplierID.Location = New System.Drawing.Point(362, 41)
            Me.Label_SupplierID.Name = "Label_SupplierID"
            Me.Label_SupplierID.Size = New System.Drawing.Size(25, 18)
            Me.Label_SupplierID.TabIndex = 10017
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
            CTag2.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag2.IsButtonCustomed = False
            CTag2.IsTextValid = True
            CTag2.KeyValueAbsentable = False
            CTag2.LeagleText = ""
            CTag2.NumericButtonTextBox = Nothing
            CTag2.ParentControl = Me.Label_SupplierID
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierID.Tag = CTag2
            Me.Label_SupplierID.Text = "ID"
            Me.Label_SupplierID.Visible = False
            '
            'Label_WareID
            '
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(362, 68)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(25, 18)
            Me.Label_WareID.TabIndex = 10016
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
            CTag3.ParentControl = Me.Label_WareID
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag3
            Me.Label_WareID.Text = "ID"
            Me.Label_WareID.Visible = False
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_CustomCode.Location = New System.Drawing.Point(219, 67)
            Me.Label_CustomCode.Name = "Label_CustomCode"
            Me.Label_CustomCode.Size = New System.Drawing.Size(137, 18)
            Me.Label_CustomCode.TabIndex = 10015
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
            CTag4.ParentControl = Me.Label_CustomCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag4
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(97, 65)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10014
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
            CTag5.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag5.IsButtonCustomed = False
            CTag5.IsTextValid = True
            CTag5.KeyValueAbsentable = False
            CTag5.LeagleText = ""
            CTag5.NumericButtonTextBox = Nothing
            CTag5.ParentControl = Me.ButtonEdit_WareCode
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag5
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label18.Location = New System.Drawing.Point(18, 68)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 15)
            Me.Label18.TabIndex = 10013
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
            CTag6.ParentControl = Me.Label18
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag6
            Me.Label18.Text = "货品代码"
            '
            'Label_SupplierName
            '
            Me.Label_SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_SupplierName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_SupplierName.Location = New System.Drawing.Point(219, 40)
            Me.Label_SupplierName.Name = "Label_SupplierName"
            Me.Label_SupplierName.Size = New System.Drawing.Size(137, 18)
            Me.Label_SupplierName.TabIndex = 10012
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
            CTag7.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag7.IsButtonCustomed = False
            CTag7.IsTextValid = True
            CTag7.KeyValueAbsentable = False
            CTag7.LeagleText = ""
            CTag7.NumericButtonTextBox = Nothing
            CTag7.ParentControl = Me.Label_SupplierName
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierName.Tag = CTag7
            '
            'ButtonEdit_SupplierCode
            '
            Me.ButtonEdit_SupplierCode.Location = New System.Drawing.Point(97, 38)
            Me.ButtonEdit_SupplierCode.Name = "ButtonEdit_SupplierCode"
            Me.ButtonEdit_SupplierCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_SupplierCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_SupplierCode.TabIndex = 10011
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
            CTag8.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag8.IsButtonCustomed = False
            CTag8.IsTextValid = True
            CTag8.KeyValueAbsentable = False
            CTag8.LeagleText = ""
            CTag8.NumericButtonTextBox = Nothing
            CTag8.ParentControl = Me.ButtonEdit_SupplierCode
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_SupplierCode.Tag = CTag8
            '
            'Label_Supplier
            '
            Me.Label_Supplier.AutoSize = True
            Me.Label_Supplier.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_Supplier.Location = New System.Drawing.Point(18, 41)
            Me.Label_Supplier.Name = "Label_Supplier"
            Me.Label_Supplier.Size = New System.Drawing.Size(43, 15)
            Me.Label_Supplier.TabIndex = 10010
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
            CTag9.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag9.IsButtonCustomed = False
            CTag9.IsTextValid = True
            CTag9.KeyValueAbsentable = False
            CTag9.LeagleText = ""
            CTag9.NumericButtonTextBox = Nothing
            CTag9.ParentControl = Me.Label_Supplier
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label_Supplier.Tag = CTag9
            Me.Label_Supplier.Text = "供应商"
            '
            'LookUpEdit_Pos
            '
            Me.LookUpEdit_Pos.Location = New System.Drawing.Point(470, 12)
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
            Me.LookUpEdit_Pos.Size = New System.Drawing.Size(171, 21)
            Me.LookUpEdit_Pos.TabIndex = 10009
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
            CTag10.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag10.IsButtonCustomed = False
            CTag10.IsTextValid = True
            CTag10.KeyValueAbsentable = False
            CTag10.LeagleText = ""
            CTag10.NumericButtonTextBox = Nothing
            CTag10.ParentControl = Me.LookUpEdit_Pos
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag10
            '
            'DateEdit_ToDate
            '
            Me.DateEdit_ToDate.EditValue = Nothing
            Me.DateEdit_ToDate.Location = New System.Drawing.Point(244, 9)
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_ToDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_ToDate.Size = New System.Drawing.Size(112, 21)
            Me.DateEdit_ToDate.TabIndex = 10003
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
            CTag11.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag11.IsButtonCustomed = False
            CTag11.IsTextValid = True
            CTag11.KeyValueAbsentable = False
            CTag11.LeagleText = ""
            CTag11.NumericButtonTextBox = Nothing
            CTag11.ParentControl = Me.DateEdit_ToDate
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag11
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(219, 13)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(19, 15)
            Me.Label3.TabIndex = 10004
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
            CTag12.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag12.IsButtonCustomed = False
            CTag12.IsTextValid = True
            CTag12.KeyValueAbsentable = False
            CTag12.LeagleText = ""
            CTag12.NumericButtonTextBox = Nothing
            CTag12.ParentControl = Me.Label3
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag12
            Me.Label3.Text = "至"
            '
            'DateEdit_FromDate
            '
            Me.DateEdit_FromDate.EditValue = Nothing
            Me.DateEdit_FromDate.Location = New System.Drawing.Point(97, 9)
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_FromDate.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_FromDate.Size = New System.Drawing.Size(116, 21)
            Me.DateEdit_FromDate.TabIndex = 10001
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
            CTag13.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag13.IsButtonCustomed = False
            CTag13.IsTextValid = True
            CTag13.KeyValueAbsentable = False
            CTag13.LeagleText = ""
            CTag13.NumericButtonTextBox = Nothing
            CTag13.ParentControl = Me.DateEdit_FromDate
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag13
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label5.Location = New System.Drawing.Point(408, 12)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(55, 15)
            Me.Label5.TabIndex = 10002
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
            CTag14.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag14.IsButtonCustomed = False
            CTag14.IsTextValid = True
            CTag14.KeyValueAbsentable = False
            CTag14.LeagleText = ""
            CTag14.NumericButtonTextBox = Nothing
            CTag14.ParentControl = Me.Label5
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag14
            Me.Label5.Text = "所在地点"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label4.Location = New System.Drawing.Point(18, 13)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(43, 15)
            Me.Label4.TabIndex = 10002
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
            CTag15.ParentControl = Me.Label4
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag15
            Me.Label4.Text = "日期从"
            '
            'TextEdit_Search
            '
            Me.TextEdit_Search.Location = New System.Drawing.Point(469, 95)
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Size = New System.Drawing.Size(172, 21)
            Me.TextEdit_Search.TabIndex = 1
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
            CTag16.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag16.IsButtonCustomed = False
            CTag16.IsTextValid = True
            CTag16.KeyValueAbsentable = False
            CTag16.LeagleText = ""
            CTag16.NumericButtonTextBox = Nothing
            CTag16.ParentControl = Me.TextEdit_Search
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag16
            '
            'TextEdit_PractWareCode
            '
            Me.TextEdit_PractWareCode.Location = New System.Drawing.Point(469, 66)
            Me.TextEdit_PractWareCode.Name = "TextEdit_PractWareCode"
            Me.TextEdit_PractWareCode.Size = New System.Drawing.Size(172, 21)
            Me.TextEdit_PractWareCode.TabIndex = 1
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
            CTag17.ParentControl = Me.TextEdit_PractWareCode
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_PractWareCode.Tag = CTag17
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(408, 97)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(31, 15)
            Me.Label6.TabIndex = 0
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
            CTag18.ParentControl = Me.Label6
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag18
            Me.Label6.Text = "查找"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(408, 68)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(43, 15)
            Me.Label2.TabIndex = 0
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
            CTag19.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag19.IsButtonCustomed = False
            CTag19.IsTextValid = True
            CTag19.KeyValueAbsentable = False
            CTag19.LeagleText = ""
            CTag19.NumericButtonTextBox = Nothing
            CTag19.ParentControl = Me.Label2
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag19
            Me.Label2.Text = "条码号"
            '
            'TextEdit_TurnoverCode
            '
            Me.TextEdit_TurnoverCode.Location = New System.Drawing.Point(470, 38)
            Me.TextEdit_TurnoverCode.Name = "TextEdit_TurnoverCode"
            Me.TextEdit_TurnoverCode.Size = New System.Drawing.Size(171, 21)
            Me.TextEdit_TurnoverCode.TabIndex = 1
            CTag20.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag20.CalculatorRequired = True
            CTag20.ComboValueTextBox = Nothing
            CTag20.ControlRelatedCode = Nothing
            CTag20.DateButtonTextBox = Nothing
            CTag20.DateTimeButtonTextBox = Nothing
            CTag20.DisplayLinkControl = Nothing
            CTag20.DisplayLinkDisplayFieldName = Nothing
            CTag20.DisplayLinkKeyFieldName = Nothing
            CTag20.DisplayLinkTable = Nothing
            CTag20.FlexgridEditItem = ""
            CTag20.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag20.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag20.IsButtonCustomed = False
            CTag20.IsTextValid = True
            CTag20.KeyValueAbsentable = False
            CTag20.LeagleText = ""
            CTag20.NumericButtonTextBox = Nothing
            CTag20.ParentControl = Me.TextEdit_TurnoverCode
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_TurnoverCode.Tag = CTag20
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(408, 41)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(55, 15)
            Me.Label1.TabIndex = 0
            CTag21.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag21.CalculatorRequired = True
            CTag21.ComboValueTextBox = Nothing
            CTag21.ControlRelatedCode = Nothing
            CTag21.DateButtonTextBox = Nothing
            CTag21.DateTimeButtonTextBox = Nothing
            CTag21.DisplayLinkControl = Nothing
            CTag21.DisplayLinkDisplayFieldName = Nothing
            CTag21.DisplayLinkKeyFieldName = Nothing
            CTag21.DisplayLinkTable = Nothing
            CTag21.FlexgridEditItem = ""
            CTag21.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag21.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag21.IsButtonCustomed = False
            CTag21.IsTextValid = True
            CTag21.KeyValueAbsentable = False
            CTag21.LeagleText = ""
            CTag21.NumericButtonTextBox = Nothing
            CTag21.ParentControl = Me.Label1
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag21
            Me.Label1.Text = "出入单号"
            '
            'GridControl_PratcWare
            '
            Me.GridControl_PratcWare.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_PratcWare.EmbeddedNavigator.Name = ""
            CTag23.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag23.CalculatorRequired = True
            CTag23.ComboValueTextBox = Nothing
            CTag23.ControlRelatedCode = Nothing
            CTag23.DateButtonTextBox = Nothing
            CTag23.DateTimeButtonTextBox = Nothing
            CTag23.DisplayLinkControl = Nothing
            CTag23.DisplayLinkDisplayFieldName = Nothing
            CTag23.DisplayLinkKeyFieldName = Nothing
            CTag23.DisplayLinkTable = Nothing
            CTag23.FlexgridEditItem = ""
            CTag23.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag23.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag23.IsButtonCustomed = False
            CTag23.IsTextValid = True
            CTag23.KeyValueAbsentable = False
            CTag23.LeagleText = ""
            CTag23.NumericButtonTextBox = Nothing
            CTag23.ParentControl = Me.GridControl_PratcWare.EmbeddedNavigator
            CTag23.SkipValidate = False
            CTag23.TimeButtonTextBox = Nothing
            CTag23.ToolTip = ""
            CTag23.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_PratcWare.EmbeddedNavigator.Tag = CTag23
            Me.GridControl_PratcWare.Location = New System.Drawing.Point(0, 152)
            Me.GridControl_PratcWare.MainView = Me.GridView_PractWare
            Me.GridControl_PratcWare.Name = "GridControl_PratcWare"
            Me.GridControl_PratcWare.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TurnoverBookStatus, Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_PratcWare.Size = New System.Drawing.Size(660, 348)
            Me.GridControl_PratcWare.TabIndex = 10001
            Me.GridControl_PratcWare.TabStop = False
            Me.GridControl_PratcWare.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_PractWare})
            '
            'GridView_PractWare
            '
            Me.GridView_PractWare.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_PractWareCode, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_RowHighlight, Me.GridColumn_RowSelect})
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
            Me.GridView_PractWare.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
            Me.GridView_PractWare.GridControl = Me.GridControl_PratcWare
            Me.GridView_PractWare.Name = "GridView_PractWare"
            Me.GridView_PractWare.OptionsView.ColumnAutoWidth = False
            Me.GridView_PractWare.OptionsView.ShowFooter = True
            Me.GridView_PractWare.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_PractWareCode
            '
            Me.GridColumn_PractWareCode.Caption = "序列条码"
            Me.GridColumn_PractWareCode.FieldName = "PRACT_BARCODE"
            Me.GridColumn_PractWareCode.Name = "GridColumn_PractWareCode"
            Me.GridColumn_PractWareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_PractWareCode.Visible = True
            Me.GridColumn_PractWareCode.VisibleIndex = 1
            Me.GridColumn_PractWareCode.Width = 60
            '
            'GridColumn_WareCode
            '
            Me.GridColumn_WareCode.Caption = "货品代码"
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_WareCode.Visible = True
            Me.GridColumn_WareCode.VisibleIndex = 3
            Me.GridColumn_WareCode.Width = 60
            '
            'GridColumn_CustomCode
            '
            Me.GridColumn_CustomCode.Caption = "自定货号"
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomCode.Visible = True
            Me.GridColumn_CustomCode.VisibleIndex = 4
            Me.GridColumn_CustomCode.Width = 60
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "品名"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 5
            Me.GridColumn_WareName.Width = 60
            '
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "规格"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 6
            Me.GridColumn_Spec.Width = 60
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "型号"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 7
            Me.GridColumn_Model.Width = 60
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "属性1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 8
            Me.GridColumn_Attribute1.Width = 43
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "属性2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 9
            Me.GridColumn_Attribute2.Width = 43
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "属性3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 10
            Me.GridColumn_Attribute3.Width = 43
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "属性4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 11
            Me.GridColumn_Attribute4.Width = 43
            '
            'GridColumn_UnitName
            '
            Me.GridColumn_UnitName.Caption = "备注"
            Me.GridColumn_UnitName.FieldName = "PRACT_REMARKS"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitName.Visible = True
            Me.GridColumn_UnitName.VisibleIndex = 2
            Me.GridColumn_UnitName.Width = 36
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "高亮显示"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            Me.GridColumn_RowHighlight.Width = 60
            '
            'GridColumn_RowSelect
            '
            Me.GridColumn_RowSelect.Caption = "选择"
            Me.GridColumn_RowSelect.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_RowSelect.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelect.Name = "GridColumn_RowSelect"
            Me.GridColumn_RowSelect.Visible = True
            Me.GridColumn_RowSelect.VisibleIndex = 0
            Me.GridColumn_RowSelect.Width = 36
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'RepositoryItemLookUpEdit_TurnoverBookStatus
            '
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.AutoHeight = False
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.Name = "RepositoryItemLookUpEdit_TurnoverBookStatus"
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.NullText = ""
            Me.RepositoryItemLookUpEdit_TurnoverBookStatus.ValueMember = "ITEM_VALUE"
            '
            'M_02_00901
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_PratcWare)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_02_00901"
            Me.Size = New System.Drawing.Size(660, 500)
            CTag24.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag24.CalculatorRequired = True
            CTag24.ComboValueTextBox = Nothing
            CTag24.ControlRelatedCode = Nothing
            CTag24.DateButtonTextBox = Nothing
            CTag24.DateTimeButtonTextBox = Nothing
            CTag24.DisplayLinkControl = Nothing
            CTag24.DisplayLinkDisplayFieldName = Nothing
            CTag24.DisplayLinkKeyFieldName = Nothing
            CTag24.DisplayLinkTable = Nothing
            CTag24.FlexgridEditItem = ""
            CTag24.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag24.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag24.IsButtonCustomed = False
            CTag24.IsTextValid = True
            CTag24.KeyValueAbsentable = False
            CTag24.LeagleText = ""
            CTag24.NumericButtonTextBox = Nothing
            CTag24.ParentControl = Me
            CTag24.SkipValidate = False
            CTag24.TimeButtonTextBox = Nothing
            CTag24.ToolTip = ""
            CTag24.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag24
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_SupplierCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_PractWareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_TurnoverCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_PratcWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_PractWare, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverBookStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_PractWareCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_TurnoverCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents GridControl_PratcWare As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_PractWare As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_PractWareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverBookStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowSelect As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents Label_SupplierName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_SupplierCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_Supplier As System.Windows.Forms.Label
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents Label_SupplierID As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label

#End Region

    End Class

End Namespace
