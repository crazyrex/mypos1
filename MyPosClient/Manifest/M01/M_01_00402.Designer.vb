Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00402
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00402))
            Dim CTag18 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag29 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag28 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag19 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag20 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag22 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag23 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag24 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag25 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag26 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag27 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag30 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.CheckEdit_RetailOperatorSalesShare = New DevExpress.XtraEditors.CheckEdit
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.LookUpEdit_PosType = New DevExpress.XtraEditors.LookUpEdit
            Me.Panel_FinancialPart = New System.Windows.Forms.Panel
            Me.SpinEdit_EmployeeCommissionRate = New DevExpress.XtraEditors.SpinEdit
            Me.Label6 = New System.Windows.Forms.Label
            Me.SpinEdit_PriceScale = New DevExpress.XtraEditors.SpinEdit
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.LinkLabel_ApplyQty = New System.Windows.Forms.LinkLabel
            Me.SpinEdit_SaftyInventoryQty = New DevExpress.XtraEditors.SpinEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.TextEdit_Remark = New DevExpress.XtraEditors.TextEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.TextEdit_SetCode = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.GridControl_WarePriceSetDtl = New DevExpress.XtraGrid.GridControl
            Me.GridView_WarePriceSetDtl = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_Select = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
            Me.GridColumn_UnitPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_UnitPrice = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_Unitcost = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_UnitCost = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_LowerLimit = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_LowerLimit = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_IndividualDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_IndividualDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
            Me.LinkLabel_UnselectAll = New System.Windows.Forms.LinkLabel
            Me.LinkLabel_SelectAll = New System.Windows.Forms.LinkLabel
            Me.Label_CustomerID = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.LinkLabel_AddItems = New System.Windows.Forms.LinkLabel
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label11 = New System.Windows.Forms.Label
            Me.Label12 = New System.Windows.Forms.Label
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.CheckEdit_RetailOperatorSalesShare.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_PosType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_FinancialPart.SuspendLayout()
            CType(Me.SpinEdit_EmployeeCommissionRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SpinEdit_PriceScale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SpinEdit_SaftyInventoryQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_SetCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.GridControl_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_LowerLimit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_IndividualDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl2.SuspendLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Add, Me.ToolStripButton_Save, Me.ToolStripButton_Remove, Me.ToolStripButton_Close})
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
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            resources.ApplyResources(Me.ToolStripButton_Add, "ToolStripButton_Add")
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            resources.ApplyResources(Me.ToolStripButton_Save, "ToolStripButton_Save")
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            resources.ApplyResources(Me.ToolStripButton_Remove, "ToolStripButton_Remove")
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Controls.Add(Me.CheckEdit_RetailOperatorSalesShare)
            Me.PanelControl1.Controls.Add(Me.Label_WareID)
            Me.PanelControl1.Controls.Add(Me.LookUpEdit_PosType)
            Me.PanelControl1.Controls.Add(Me.Panel_FinancialPart)
            Me.PanelControl1.Controls.Add(Me.Label4)
            Me.PanelControl1.Controls.Add(Me.LinkLabel_ApplyQty)
            Me.PanelControl1.Controls.Add(Me.SpinEdit_SaftyInventoryQty)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.TextEdit_Remark)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Controls.Add(Me.TextEdit_SetCode)
            Me.PanelControl1.Controls.Add(Me.Label1)
            resources.ApplyResources(Me.PanelControl1, "PanelControl1")
            Me.PanelControl1.Name = "PanelControl1"
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
            CTag18.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag18.IsButtonCustomed = False
            CTag18.IsTextValid = True
            CTag18.KeyValueAbsentable = False
            CTag18.LeagleText = ""
            CTag18.NumericButtonTextBox = Nothing
            CTag18.ParentControl = Me.PanelControl1
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag18
            '
            'CheckEdit_RetailOperatorSalesShare
            '
            resources.ApplyResources(Me.CheckEdit_RetailOperatorSalesShare, "CheckEdit_RetailOperatorSalesShare")
            Me.CheckEdit_RetailOperatorSalesShare.Name = "CheckEdit_RetailOperatorSalesShare"
            Me.CheckEdit_RetailOperatorSalesShare.Properties.Caption = resources.GetString("CheckEdit_RetailOperatorSalesShare.Properties.Caption")
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
            CTag2.ParentControl = Me.CheckEdit_RetailOperatorSalesShare
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.CheckEdit_RetailOperatorSalesShare.Tag = CTag2
            '
            'Label_WareID
            '
            resources.ApplyResources(Me.Label_WareID, "Label_WareID")
            Me.Label_WareID.Name = "Label_WareID"
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
            '
            'LookUpEdit_PosType
            '
            resources.ApplyResources(Me.LookUpEdit_PosType, "LookUpEdit_PosType")
            Me.LookUpEdit_PosType.Name = "LookUpEdit_PosType"
            Me.LookUpEdit_PosType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_PosType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_PosType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_PosType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_PosType.Properties.ValueMember = "ITEM_VALUE"
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
            CTag4.ParentControl = Me.LookUpEdit_PosType
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_PosType.Tag = CTag4
            '
            'Panel_FinancialPart
            '
            Me.Panel_FinancialPart.Controls.Add(Me.SpinEdit_EmployeeCommissionRate)
            Me.Panel_FinancialPart.Controls.Add(Me.Label6)
            Me.Panel_FinancialPart.Controls.Add(Me.SpinEdit_PriceScale)
            Me.Panel_FinancialPart.Controls.Add(Me.Label5)
            resources.ApplyResources(Me.Panel_FinancialPart, "Panel_FinancialPart")
            Me.Panel_FinancialPart.Name = "Panel_FinancialPart"
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
            CTag9.ParentControl = Me.Panel_FinancialPart
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_FinancialPart.Tag = CTag9
            '
            'SpinEdit_EmployeeCommissionRate
            '
            resources.ApplyResources(Me.SpinEdit_EmployeeCommissionRate, "SpinEdit_EmployeeCommissionRate")
            Me.SpinEdit_EmployeeCommissionRate.Name = "SpinEdit_EmployeeCommissionRate"
            Me.SpinEdit_EmployeeCommissionRate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag5.ParentControl = Me.SpinEdit_EmployeeCommissionRate
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.SpinEdit_EmployeeCommissionRate.Tag = CTag5
            '
            'Label6
            '
            resources.ApplyResources(Me.Label6, "Label6")
            Me.Label6.Name = "Label6"
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
            CTag6.ParentControl = Me.Label6
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag6
            '
            'SpinEdit_PriceScale
            '
            resources.ApplyResources(Me.SpinEdit_PriceScale, "SpinEdit_PriceScale")
            Me.SpinEdit_PriceScale.Name = "SpinEdit_PriceScale"
            Me.SpinEdit_PriceScale.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag7.ParentControl = Me.SpinEdit_PriceScale
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.SpinEdit_PriceScale.Tag = CTag7
            '
            'Label5
            '
            resources.ApplyResources(Me.Label5, "Label5")
            Me.Label5.Name = "Label5"
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
            CTag8.ParentControl = Me.Label5
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag8
            '
            'Label4
            '
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.Name = "Label4"
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
            'LinkLabel_ApplyQty
            '
            resources.ApplyResources(Me.LinkLabel_ApplyQty, "LinkLabel_ApplyQty")
            Me.LinkLabel_ApplyQty.Name = "LinkLabel_ApplyQty"
            Me.LinkLabel_ApplyQty.TabStop = True
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
            CTag11.ParentControl = Me.LinkLabel_ApplyQty
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_ApplyQty.Tag = CTag11
            '
            'SpinEdit_SaftyInventoryQty
            '
            resources.ApplyResources(Me.SpinEdit_SaftyInventoryQty, "SpinEdit_SaftyInventoryQty")
            Me.SpinEdit_SaftyInventoryQty.Name = "SpinEdit_SaftyInventoryQty"
            Me.SpinEdit_SaftyInventoryQty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag12.ParentControl = Me.SpinEdit_SaftyInventoryQty
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.SpinEdit_SaftyInventoryQty.Tag = CTag12
            '
            'Label3
            '
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.Name = "Label3"
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
            CTag13.ParentControl = Me.Label3
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag13
            '
            'TextEdit_Remark
            '
            resources.ApplyResources(Me.TextEdit_Remark, "TextEdit_Remark")
            Me.TextEdit_Remark.Name = "TextEdit_Remark"
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
            CTag14.ParentControl = Me.TextEdit_Remark
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Remark.Tag = CTag14
            '
            'Label2
            '
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.Name = "Label2"
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
            CTag15.ParentControl = Me.Label2
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag15
            '
            'TextEdit_SetCode
            '
            resources.ApplyResources(Me.TextEdit_SetCode, "TextEdit_SetCode")
            Me.TextEdit_SetCode.Name = "TextEdit_SetCode"
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
            CTag16.ParentControl = Me.TextEdit_SetCode
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_SetCode.Tag = CTag16
            '
            'Label1
            '
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.Name = "Label1"
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
            CTag17.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag17.IsButtonCustomed = False
            CTag17.IsTextValid = True
            CTag17.KeyValueAbsentable = False
            CTag17.LeagleText = ""
            CTag17.NumericButtonTextBox = Nothing
            CTag17.ParentControl = Me.Label1
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag17
            '
            'GroupControl1
            '
            Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.GroupControl1.Appearance.Options.UseBackColor = True
            Me.GroupControl1.Controls.Add(Me.GridControl_WarePriceSetDtl)
            Me.GroupControl1.Controls.Add(Me.PanelControl2)
            resources.ApplyResources(Me.GroupControl1, "GroupControl1")
            Me.GroupControl1.Name = "GroupControl1"
            CTag29.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag29.CalculatorRequired = True
            CTag29.ComboValueTextBox = Nothing
            CTag29.ControlRelatedCode = Nothing
            CTag29.DateButtonTextBox = Nothing
            CTag29.DateTimeButtonTextBox = Nothing
            CTag29.DisplayLinkControl = Nothing
            CTag29.DisplayLinkDisplayFieldName = Nothing
            CTag29.DisplayLinkKeyFieldName = Nothing
            CTag29.DisplayLinkTable = Nothing
            CTag29.FlexgridEditItem = ""
            CTag29.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag29.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag29.IsButtonCustomed = False
            CTag29.IsTextValid = True
            CTag29.KeyValueAbsentable = False
            CTag29.LeagleText = ""
            CTag29.NumericButtonTextBox = Nothing
            CTag29.ParentControl = Me.GroupControl1
            CTag29.SkipValidate = False
            CTag29.TimeButtonTextBox = Nothing
            CTag29.ToolTip = ""
            CTag29.ValueType = XL.Common.ControlValueType.Character
            Me.GroupControl1.Tag = CTag29
            '
            'GridControl_WarePriceSetDtl
            '
            resources.ApplyResources(Me.GridControl_WarePriceSetDtl, "GridControl_WarePriceSetDtl")
            Me.GridControl_WarePriceSetDtl.EmbeddedNavigator.Name = ""
            Me.GridControl_WarePriceSetDtl.MainView = Me.GridView_WarePriceSetDtl
            Me.GridControl_WarePriceSetDtl.Name = "GridControl_WarePriceSetDtl"
            Me.GridControl_WarePriceSetDtl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCalcEdit_LowerLimit, Me.RepositoryItemCalcEdit_IndividualDiscount, Me.RepositoryItemCalcEdit_UnitPrice, Me.RepositoryItemCalcEdit_UnitCost, Me.RepositoryItemCheckEdit_Select})
            Me.GridControl_WarePriceSetDtl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_WarePriceSetDtl})
            '
            'GridView_WarePriceSetDtl
            '
            Me.GridView_WarePriceSetDtl.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_Select, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_Unitcost, Me.GridColumn_LowerLimit, Me.GridColumn_IndividualDiscount, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_WarePriceSetDtl.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_WarePriceSetDtl.GridControl = Me.GridControl_WarePriceSetDtl
            Me.GridView_WarePriceSetDtl.Name = "GridView_WarePriceSetDtl"
            Me.GridView_WarePriceSetDtl.OptionsView.ColumnAutoWidth = False
            Me.GridView_WarePriceSetDtl.OptionsView.ShowFooter = True
            Me.GridView_WarePriceSetDtl.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_Select
            '
            resources.ApplyResources(Me.GridColumn_Select, "GridColumn_Select")
            Me.GridColumn_Select.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_Select.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_Select.Name = "GridColumn_Select"
            '
            'RepositoryItemCheckEdit_Select
            '
            resources.ApplyResources(Me.RepositoryItemCheckEdit_Select, "RepositoryItemCheckEdit_Select")
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
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
            'GridColumn_UnitName
            '
            resources.ApplyResources(Me.GridColumn_UnitName, "GridColumn_UnitName")
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_UnitPrice
            '
            resources.ApplyResources(Me.GridColumn_UnitPrice, "GridColumn_UnitPrice")
            Me.GridColumn_UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit_UnitPrice
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            '
            'RepositoryItemCalcEdit_UnitPrice
            '
            resources.ApplyResources(Me.RepositoryItemCalcEdit_UnitPrice, "RepositoryItemCalcEdit_UnitPrice")
            Me.RepositoryItemCalcEdit_UnitPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_UnitPrice.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_UnitPrice.Name = "RepositoryItemCalcEdit_UnitPrice"
            '
            'GridColumn_Unitcost
            '
            resources.ApplyResources(Me.GridColumn_Unitcost, "GridColumn_Unitcost")
            Me.GridColumn_Unitcost.ColumnEdit = Me.RepositoryItemCalcEdit_UnitCost
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            '
            'RepositoryItemCalcEdit_UnitCost
            '
            resources.ApplyResources(Me.RepositoryItemCalcEdit_UnitCost, "RepositoryItemCalcEdit_UnitCost")
            Me.RepositoryItemCalcEdit_UnitCost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_UnitCost.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_UnitCost.Name = "RepositoryItemCalcEdit_UnitCost"
            '
            'GridColumn_LowerLimit
            '
            resources.ApplyResources(Me.GridColumn_LowerLimit, "GridColumn_LowerLimit")
            Me.GridColumn_LowerLimit.ColumnEdit = Me.RepositoryItemCalcEdit_LowerLimit
            Me.GridColumn_LowerLimit.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_LowerLimit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_LowerLimit.FieldName = "LOWER_LIMIT"
            Me.GridColumn_LowerLimit.Name = "GridColumn_LowerLimit"
            '
            'RepositoryItemCalcEdit_LowerLimit
            '
            resources.ApplyResources(Me.RepositoryItemCalcEdit_LowerLimit, "RepositoryItemCalcEdit_LowerLimit")
            Me.RepositoryItemCalcEdit_LowerLimit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_LowerLimit.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_LowerLimit.Name = "RepositoryItemCalcEdit_LowerLimit"
            '
            'GridColumn_IndividualDiscount
            '
            resources.ApplyResources(Me.GridColumn_IndividualDiscount, "GridColumn_IndividualDiscount")
            Me.GridColumn_IndividualDiscount.ColumnEdit = Me.RepositoryItemCalcEdit_IndividualDiscount
            Me.GridColumn_IndividualDiscount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_IndividualDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_IndividualDiscount.FieldName = "INDIVIDUAL_DISCOUNT"
            Me.GridColumn_IndividualDiscount.Name = "GridColumn_IndividualDiscount"
            Me.GridColumn_IndividualDiscount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'RepositoryItemCalcEdit_IndividualDiscount
            '
            resources.ApplyResources(Me.RepositoryItemCalcEdit_IndividualDiscount, "RepositoryItemCalcEdit_IndividualDiscount")
            Me.RepositoryItemCalcEdit_IndividualDiscount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemCalcEdit_IndividualDiscount.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemCalcEdit_IndividualDiscount.Name = "RepositoryItemCalcEdit_IndividualDiscount"
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
            'PanelControl2
            '
            Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl2.Appearance.Options.UseBackColor = True
            Me.PanelControl2.Controls.Add(Me.LinkLabel_UnselectAll)
            Me.PanelControl2.Controls.Add(Me.LinkLabel_SelectAll)
            Me.PanelControl2.Controls.Add(Me.Label_CustomerID)
            Me.PanelControl2.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl2.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl2.Controls.Add(Me.LinkLabel_AddItems)
            Me.PanelControl2.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl2.Controls.Add(Me.Label11)
            Me.PanelControl2.Controls.Add(Me.Label12)
            resources.ApplyResources(Me.PanelControl2, "PanelControl2")
            Me.PanelControl2.Name = "PanelControl2"
            CTag28.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag28.CalculatorRequired = True
            CTag28.ComboValueTextBox = Nothing
            CTag28.ControlRelatedCode = Nothing
            CTag28.DateButtonTextBox = Nothing
            CTag28.DateTimeButtonTextBox = Nothing
            CTag28.DisplayLinkControl = Nothing
            CTag28.DisplayLinkDisplayFieldName = Nothing
            CTag28.DisplayLinkKeyFieldName = Nothing
            CTag28.DisplayLinkTable = Nothing
            CTag28.FlexgridEditItem = ""
            CTag28.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag28.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag28.IsButtonCustomed = False
            CTag28.IsTextValid = True
            CTag28.KeyValueAbsentable = False
            CTag28.LeagleText = ""
            CTag28.NumericButtonTextBox = Nothing
            CTag28.ParentControl = Me.PanelControl2
            CTag28.SkipValidate = False
            CTag28.TimeButtonTextBox = Nothing
            CTag28.ToolTip = ""
            CTag28.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl2.Tag = CTag28
            '
            'LinkLabel_UnselectAll
            '
            resources.ApplyResources(Me.LinkLabel_UnselectAll, "LinkLabel_UnselectAll")
            Me.LinkLabel_UnselectAll.Name = "LinkLabel_UnselectAll"
            Me.LinkLabel_UnselectAll.TabStop = True
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
            CTag19.ParentControl = Me.LinkLabel_UnselectAll
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_UnselectAll.Tag = CTag19
            '
            'LinkLabel_SelectAll
            '
            resources.ApplyResources(Me.LinkLabel_SelectAll, "LinkLabel_SelectAll")
            Me.LinkLabel_SelectAll.Name = "LinkLabel_SelectAll"
            Me.LinkLabel_SelectAll.TabStop = True
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
            CTag20.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag20.IsButtonCustomed = False
            CTag20.IsTextValid = True
            CTag20.KeyValueAbsentable = False
            CTag20.LeagleText = ""
            CTag20.NumericButtonTextBox = Nothing
            CTag20.ParentControl = Me.LinkLabel_SelectAll
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_SelectAll.Tag = CTag20
            '
            'Label_CustomerID
            '
            resources.ApplyResources(Me.Label_CustomerID, "Label_CustomerID")
            Me.Label_CustomerID.Name = "Label_CustomerID"
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
            CTag21.ParentControl = Me.Label_CustomerID
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomerID.Tag = CTag21
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            resources.ApplyResources(Me.Label_CustomCode, "Label_CustomCode")
            Me.Label_CustomCode.Name = "Label_CustomCode"
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
            CTag22.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag22.IsButtonCustomed = False
            CTag22.IsTextValid = True
            CTag22.KeyValueAbsentable = False
            CTag22.LeagleText = ""
            CTag22.NumericButtonTextBox = Nothing
            CTag22.ParentControl = Me.Label_CustomCode
            CTag22.SkipValidate = False
            CTag22.TimeButtonTextBox = Nothing
            CTag22.ToolTip = ""
            CTag22.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag22
            '
            'ButtonEdit_WareCode
            '
            resources.ApplyResources(Me.ButtonEdit_WareCode, "ButtonEdit_WareCode")
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
            CTag23.ParentControl = Me.ButtonEdit_WareCode
            CTag23.SkipValidate = False
            CTag23.TimeButtonTextBox = Nothing
            CTag23.ToolTip = ""
            CTag23.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag23
            '
            'LinkLabel_AddItems
            '
            resources.ApplyResources(Me.LinkLabel_AddItems, "LinkLabel_AddItems")
            Me.LinkLabel_AddItems.Name = "LinkLabel_AddItems"
            Me.LinkLabel_AddItems.TabStop = True
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
            CTag24.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag24.IsButtonCustomed = False
            CTag24.IsTextValid = True
            CTag24.KeyValueAbsentable = False
            CTag24.LeagleText = ""
            CTag24.NumericButtonTextBox = Nothing
            CTag24.ParentControl = Me.LinkLabel_AddItems
            CTag24.SkipValidate = False
            CTag24.TimeButtonTextBox = Nothing
            CTag24.ToolTip = ""
            CTag24.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_AddItems.Tag = CTag24
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.Name = "TextEdit_Search"
            CTag25.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag25.CalculatorRequired = True
            CTag25.ComboValueTextBox = Nothing
            CTag25.ControlRelatedCode = Nothing
            CTag25.DateButtonTextBox = Nothing
            CTag25.DateTimeButtonTextBox = Nothing
            CTag25.DisplayLinkControl = Nothing
            CTag25.DisplayLinkDisplayFieldName = Nothing
            CTag25.DisplayLinkKeyFieldName = Nothing
            CTag25.DisplayLinkTable = Nothing
            CTag25.FlexgridEditItem = ""
            CTag25.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag25.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag25.IsButtonCustomed = False
            CTag25.IsTextValid = True
            CTag25.KeyValueAbsentable = False
            CTag25.LeagleText = ""
            CTag25.NumericButtonTextBox = Nothing
            CTag25.ParentControl = Me.TextEdit_Search
            CTag25.SkipValidate = False
            CTag25.TimeButtonTextBox = Nothing
            CTag25.ToolTip = ""
            CTag25.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag25
            '
            'Label11
            '
            resources.ApplyResources(Me.Label11, "Label11")
            Me.Label11.Name = "Label11"
            CTag26.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag26.CalculatorRequired = True
            CTag26.ComboValueTextBox = Nothing
            CTag26.ControlRelatedCode = Nothing
            CTag26.DateButtonTextBox = Nothing
            CTag26.DateTimeButtonTextBox = Nothing
            CTag26.DisplayLinkControl = Nothing
            CTag26.DisplayLinkDisplayFieldName = Nothing
            CTag26.DisplayLinkKeyFieldName = Nothing
            CTag26.DisplayLinkTable = Nothing
            CTag26.FlexgridEditItem = ""
            CTag26.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag26.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag26.IsButtonCustomed = False
            CTag26.IsTextValid = True
            CTag26.KeyValueAbsentable = False
            CTag26.LeagleText = ""
            CTag26.NumericButtonTextBox = Nothing
            CTag26.ParentControl = Me.Label11
            CTag26.SkipValidate = False
            CTag26.TimeButtonTextBox = Nothing
            CTag26.ToolTip = ""
            CTag26.ValueType = XL.Common.ControlValueType.Character
            Me.Label11.Tag = CTag26
            '
            'Label12
            '
            resources.ApplyResources(Me.Label12, "Label12")
            Me.Label12.Name = "Label12"
            CTag27.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag27.CalculatorRequired = True
            CTag27.ComboValueTextBox = Nothing
            CTag27.ControlRelatedCode = Nothing
            CTag27.DateButtonTextBox = Nothing
            CTag27.DateTimeButtonTextBox = Nothing
            CTag27.DisplayLinkControl = Nothing
            CTag27.DisplayLinkDisplayFieldName = Nothing
            CTag27.DisplayLinkKeyFieldName = Nothing
            CTag27.DisplayLinkTable = Nothing
            CTag27.FlexgridEditItem = ""
            CTag27.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag27.FormStatus = XL.Win.Component.BaseForm.FormStatuses.BeforeLoading
            CTag27.IsButtonCustomed = False
            CTag27.IsTextValid = True
            CTag27.KeyValueAbsentable = False
            CTag27.LeagleText = ""
            CTag27.NumericButtonTextBox = Nothing
            CTag27.ParentControl = Me.Label12
            CTag27.SkipValidate = False
            CTag27.TimeButtonTextBox = Nothing
            CTag27.ToolTip = ""
            CTag27.ValueType = XL.Common.ControlValueType.Character
            Me.Label12.Tag = CTag27
            '
            'M_01_00402
            '
            resources.ApplyResources(Me, "$this")
            Me.Controls.Add(Me.GroupControl1)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_01_00402"
            CTag30.AutoAvailable = XL.Win.AutoAvailables.OnSelfIncludingSubOnes
            CTag30.CalculatorRequired = True
            CTag30.ComboValueTextBox = Nothing
            CTag30.ControlRelatedCode = Nothing
            CTag30.DateButtonTextBox = Nothing
            CTag30.DateTimeButtonTextBox = Nothing
            CTag30.DisplayLinkControl = Nothing
            CTag30.DisplayLinkDisplayFieldName = Nothing
            CTag30.DisplayLinkKeyFieldName = Nothing
            CTag30.DisplayLinkTable = Nothing
            CTag30.FlexgridEditItem = ""
            CTag30.FormReadingMode = XL.Win.Component.BaseForm.FormReadingMode.NoReading
            CTag30.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag30.IsButtonCustomed = False
            CTag30.IsTextValid = True
            CTag30.KeyValueAbsentable = False
            CTag30.LeagleText = ""
            CTag30.NumericButtonTextBox = Nothing
            CTag30.ParentControl = Me
            CTag30.SkipValidate = False
            CTag30.TimeButtonTextBox = Nothing
            CTag30.ToolTip = ""
            CTag30.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag30
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.CheckEdit_RetailOperatorSalesShare.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_PosType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_FinancialPart.ResumeLayout(False)
            Me.Panel_FinancialPart.PerformLayout()
            CType(Me.SpinEdit_EmployeeCommissionRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SpinEdit_PriceScale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SpinEdit_SaftyInventoryQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_SetCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            CType(Me.GridControl_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_WarePriceSetDtl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_LowerLimit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_IndividualDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl2.ResumeLayout(False)
            Me.PanelControl2.PerformLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_SetCode As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents LinkLabel_ApplyQty As System.Windows.Forms.LinkLabel
        Friend WithEvents SpinEdit_SaftyInventoryQty As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents TextEdit_Remark As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_PosType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Panel_FinancialPart As System.Windows.Forms.Panel
        Friend WithEvents SpinEdit_EmployeeCommissionRate As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents SpinEdit_PriceScale As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents LinkLabel_AddItems As System.Windows.Forms.LinkLabel
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents Label_CustomerID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents GridControl_WarePriceSetDtl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_WarePriceSetDtl As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_WareCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WareName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Spec As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Model As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Attribute4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_UnitPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_LowerLimit As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_IndividualDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_LowerLimit As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_IndividualDiscount As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents RepositoryItemCalcEdit_UnitPrice As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_UnitCost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_Select As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents LinkLabel_UnselectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents LinkLabel_SelectAll As System.Windows.Forms.LinkLabel
        Friend WithEvents CheckEdit_RetailOperatorSalesShare As DevExpress.XtraEditors.CheckEdit

#End Region

    End Class

End Namespace
