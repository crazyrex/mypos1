Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00202
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
        Friend WithEvents ToolStripButton_Save As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Remove As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00202))
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
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
            Dim CTag20 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ImportFromMobile = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Label_EmployeeID = New System.Windows.Forms.Label
            Me.Label_EmployeeName = New System.Windows.Forms.Label
            Me.ButtonEdit_EmployeeCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label4 = New System.Windows.Forms.Label
            Me.LookUpEdit_PosList = New DevExpress.XtraEditors.LookUpEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.CheckEdit_CheckingAll = New DevExpress.XtraEditors.CheckEdit
            Me.TextEdit_InventoryCode = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.DateEdit_CreateDate = New DevExpress.XtraEditors.DateEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.GridControl_WareList = New DevExpress.XtraGrid.GridControl
            Me.GridView_WareList = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WareName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Spec = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Model = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Attribute4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_InventoryAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_InventoryAmount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_UnitName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_ShowDetailInput = New DevExpress.XtraEditors.CheckEdit
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label18 = New System.Windows.Forms.Label
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_PosList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.CheckEdit_CheckingAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_InventoryCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_CreateDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_CreateDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.GridControl_WareList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_WareList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_InventoryAmount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.CheckEdit_ShowDetailInput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Save, Me.ToolStripButton_Add, Me.ToolStripButton_Revise, Me.ToolStripButton_Remove, Me.ToolStripButton_ImportFromMobile, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Close})
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
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
            resources.ApplyResources(Me.ToolStripButton_Save, "ToolStripButton_Save")
            '
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            resources.ApplyResources(Me.ToolStripButton_Add, "ToolStripButton_Add")
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            resources.ApplyResources(Me.ToolStripButton_Remove, "ToolStripButton_Remove")
            '
            'ToolStripButton_ImportFromMobile
            '
            Me.ToolStripButton_ImportFromMobile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ImportFromMobile, "ToolStripButton_ImportFromMobile")
            Me.ToolStripButton_ImportFromMobile.Name = "ToolStripButton_ImportFromMobile"
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_EmployeeName)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_EmployeeCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label4)
            Me.PanelControl_Filter.Controls.Add(Me.LookUpEdit_PosList)
            Me.PanelControl_Filter.Controls.Add(Me.Label3)
            Me.PanelControl_Filter.Controls.Add(Me.CheckEdit_CheckingAll)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_InventoryCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label2)
            Me.PanelControl_Filter.Controls.Add(Me.DateEdit_CreateDate)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag13.ParentControl = Me.PanelControl_Filter
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag13
            '
            'Label_EmployeeID
            '
            resources.ApplyResources(Me.Label_EmployeeID, "Label_EmployeeID")
            Me.Label_EmployeeID.Name = "Label_EmployeeID"
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
            CTag2.ParentControl = Me.Label_EmployeeID
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeID.Tag = CTag2
            '
            'Label_EmployeeName
            '
            Me.Label_EmployeeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            resources.ApplyResources(Me.Label_EmployeeName, "Label_EmployeeName")
            Me.Label_EmployeeName.Name = "Label_EmployeeName"
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
            CTag3.ParentControl = Me.Label_EmployeeName
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_EmployeeName.Tag = CTag3
            '
            'ButtonEdit_EmployeeCode
            '
            resources.ApplyResources(Me.ButtonEdit_EmployeeCode, "ButtonEdit_EmployeeCode")
            Me.ButtonEdit_EmployeeCode.Name = "ButtonEdit_EmployeeCode"
            Me.ButtonEdit_EmployeeCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag4.ParentControl = Me.ButtonEdit_EmployeeCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_EmployeeCode.Tag = CTag4
            '
            'Label4
            '
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.Name = "Label4"
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
            CTag5.ParentControl = Me.Label4
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag5
            '
            'LookUpEdit_PosList
            '
            resources.ApplyResources(Me.LookUpEdit_PosList, "LookUpEdit_PosList")
            Me.LookUpEdit_PosList.Name = "LookUpEdit_PosList"
            Me.LookUpEdit_PosList.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_PosList.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_PosList.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_PosList.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_PosList.Properties.ValueMember = "POS_ID"
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
            CTag6.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag6.IsButtonCustomed = False
            CTag6.IsTextValid = True
            CTag6.KeyValueAbsentable = False
            CTag6.LeagleText = ""
            CTag6.NumericButtonTextBox = Nothing
            CTag6.ParentControl = Me.LookUpEdit_PosList
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_PosList.Tag = CTag6
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.Name = "Label3"
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
            CTag7.ParentControl = Me.Label3
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag7
            '
            'CheckEdit_CheckingAll
            '
            resources.ApplyResources(Me.CheckEdit_CheckingAll, "CheckEdit_CheckingAll")
            Me.CheckEdit_CheckingAll.Name = "CheckEdit_CheckingAll"
            Me.CheckEdit_CheckingAll.Properties.Caption = resources.GetString("CheckEdit_CheckingAll.Properties.Caption")
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
            CTag8.ParentControl = Me.CheckEdit_CheckingAll
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_CheckingAll.Tag = CTag8
            '
            'TextEdit_InventoryCode
            '
            resources.ApplyResources(Me.TextEdit_InventoryCode, "TextEdit_InventoryCode")
            Me.TextEdit_InventoryCode.Name = "TextEdit_InventoryCode"
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
            CTag9.ParentControl = Me.TextEdit_InventoryCode
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_InventoryCode.Tag = CTag9
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.Name = "Label2"
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
            CTag10.ParentControl = Me.Label2
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag10
            '
            'DateEdit_CreateDate
            '
            Me.DateEdit_CreateDate.EditValue = Nothing
            resources.ApplyResources(Me.DateEdit_CreateDate, "DateEdit_CreateDate")
            Me.DateEdit_CreateDate.Name = "DateEdit_CreateDate"
            Me.DateEdit_CreateDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_CreateDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_CreateDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag11.ParentControl = Me.DateEdit_CreateDate
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_CreateDate.Tag = CTag11
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Name = "Label1"
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
            CTag12.ParentControl = Me.Label1
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag12
            '
            'GroupControl1
            '
            Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.GroupControl1.Appearance.Options.UseBackColor = True
            Me.GroupControl1.Controls.Add(Me.GridControl_WareList)
            Me.GroupControl1.Controls.Add(Me.PanelControl1)
            resources.ApplyResources(Me.GroupControl1, "GroupControl1")
            Me.GroupControl1.Name = "GroupControl1"
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
            CTag20.ParentControl = Me.GroupControl1
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.GroupControl1.Tag = CTag20
            '
            'GridControl_WareList
            '
            resources.ApplyResources(Me.GridControl_WareList, "GridControl_WareList")
            Me.GridControl_WareList.EmbeddedNavigator.Name = ""
            Me.GridControl_WareList.MainView = Me.GridView_WareList
            Me.GridControl_WareList.Name = "GridControl_WareList"
            Me.GridControl_WareList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit_InventoryAmount})
            Me.GridControl_WareList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_WareList})
            '
            'GridView_WareList
            '
            Me.GridView_WareList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_InventoryAmount, Me.GridColumn_UnitName, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_WareList.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_WareList.GridControl = Me.GridControl_WareList
            Me.GridView_WareList.Name = "GridView_WareList"
            Me.GridView_WareList.OptionsView.ColumnAutoWidth = False
            Me.GridView_WareList.OptionsView.ShowFooter = True
            Me.GridView_WareList.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_WareCode
            '
            resources.ApplyResources(Me.GridColumn_WareCode, "GridColumn_WareCode")
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_CustomCode
            '
            resources.ApplyResources(Me.GridColumn_CustomCode, "GridColumn_CustomCode")
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_WareName
            '
            resources.ApplyResources(Me.GridColumn_WareName, "GridColumn_WareName")
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Spec
            '
            resources.ApplyResources(Me.GridColumn_Spec, "GridColumn_Spec")
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Model
            '
            resources.ApplyResources(Me.GridColumn_Model, "GridColumn_Model")
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute1
            '
            resources.ApplyResources(Me.GridColumn_Attribute1, "GridColumn_Attribute1")
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute2
            '
            resources.ApplyResources(Me.GridColumn_Attribute2, "GridColumn_Attribute2")
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute3
            '
            resources.ApplyResources(Me.GridColumn_Attribute3, "GridColumn_Attribute3")
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Attribute4
            '
            resources.ApplyResources(Me.GridColumn_Attribute4, "GridColumn_Attribute4")
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            '
            'GridColumn_InventoryAmount
            '
            resources.ApplyResources(Me.GridColumn_InventoryAmount, "GridColumn_InventoryAmount")
            Me.GridColumn_InventoryAmount.ColumnEdit = Me.RepositoryItemCalcEdit_InventoryAmount
            Me.GridColumn_InventoryAmount.FieldName = "INVENTORY_AMOUNT"
            Me.GridColumn_InventoryAmount.Name = "GridColumn_InventoryAmount"
            Me.GridColumn_InventoryAmount.SummaryItem.FieldName = "CURRENT_AMOUNT"
            Me.GridColumn_InventoryAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemCalcEdit_InventoryAmount
            '
            Me.RepositoryItemCalcEdit_InventoryAmount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_InventoryAmount.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_InventoryAmount.Name = "RepositoryItemCalcEdit_InventoryAmount"
            '
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_Remarks
            '
            resources.ApplyResources(Me.GridColumn_Remarks, "GridColumn_Remarks")
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'PanelControl1
            '
            Me.PanelControl1.Controls.Add(Me.CheckEdit_ShowDetailInput)
            Me.PanelControl1.Controls.Add(Me.Label_WareID)
            Me.PanelControl1.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl1.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl1.Controls.Add(Me.Label18)
            resources.ApplyResources(Me.PanelControl1, "PanelControl1")
            Me.PanelControl1.Name = "PanelControl1"
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
            CTag19.ParentControl = Me.PanelControl1
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag19
            '
            'CheckEdit_ShowDetailInput
            '
            resources.ApplyResources(Me.CheckEdit_ShowDetailInput, "CheckEdit_ShowDetailInput")
            Me.CheckEdit_ShowDetailInput.Name = "CheckEdit_ShowDetailInput"
            Me.CheckEdit_ShowDetailInput.Properties.Caption = resources.GetString("CheckEdit_ShowDetailInput.Properties.Caption")
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
            CTag14.ParentControl = Me.CheckEdit_ShowDetailInput
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_ShowDetailInput.Tag = CTag14
            '
            'Label_WareID
            '
            resources.ApplyResources(Me.Label_WareID, "Label_WareID")
            Me.Label_WareID.Name = "Label_WareID"
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
            CTag15.ParentControl = Me.Label_WareID
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag15
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            resources.ApplyResources(Me.Label_CustomCode, "Label_CustomCode")
            Me.Label_CustomCode.Name = "Label_CustomCode"
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
            CTag16.ParentControl = Me.Label_CustomCode
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag16
            '
            'ButtonEdit_WareCode
            '
            resources.ApplyResources(Me.ButtonEdit_WareCode, "ButtonEdit_WareCode")
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag17.ParentControl = Me.ButtonEdit_WareCode
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag17
            '
            'Label18
            '
            resources.ApplyResources(Me.Label18, "Label18")
            Me.Label18.Name = "Label18"
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
            CTag18.ParentControl = Me.Label18
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag18
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_02_00202
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GroupControl1)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00202"
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
            CTag21.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag21.IsButtonCustomed = False
            CTag21.IsTextValid = True
            CTag21.KeyValueAbsentable = False
            CTag21.LeagleText = ""
            CTag21.NumericButtonTextBox = Nothing
            CTag21.ParentControl = Me
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag21
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.ButtonEdit_EmployeeCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_PosList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.CheckEdit_CheckingAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_InventoryCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_CreateDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_CreateDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            CType(Me.GridControl_WareList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_WareList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_InventoryAmount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.CheckEdit_ShowDetailInput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_CreateDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_PosList As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents CheckEdit_CheckingAll As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents TextEdit_InventoryCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label_EmployeeID As System.Windows.Forms.Label
        Friend WithEvents Label_EmployeeName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_EmployeeCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents CheckEdit_ShowDetailInput As DevExpress.XtraEditors.CheckEdit
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents GridControl_WareList As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_WareList As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_InventoryAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_InventoryAmount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ImportFromMobile As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace
