Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_02_00101
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
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Revise As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_02_00101))
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag24 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag21 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
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
            Dim CTag22 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag23 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag25 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag26 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Revise = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ConsignQuery = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_DeliveryQuery = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_PaymentQuery = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_StaffCommission = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ExportExcel = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Print = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Panel_DateRange = New System.Windows.Forms.Panel
            Me.Label2 = New System.Windows.Forms.Label
            Me.DateEdit_FromDate = New DevExpress.XtraEditors.DateEdit
            Me.DateEdit_ToDate = New DevExpress.XtraEditors.DateEdit
            Me.Label3 = New System.Windows.Forms.Label
            Me.Panel_Options = New System.Windows.Forms.Panel
            Me.Label_CustomerID = New System.Windows.Forms.Label
            Me.Label_CustomerName = New System.Windows.Forms.Label
            Me.LookUpEdit_Pos = New DevExpress.XtraEditors.LookUpEdit
            Me.ButtonEdit_CustomerCode = New DevExpress.XtraEditors.ButtonEdit
            Me.LookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.LookUpEdit
            Me.Label_Customer = New System.Windows.Forms.Label
            Me.Label_SupplierID = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.Label_SupplierName = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.ButtonEdit_SupplierCode = New DevExpress.XtraEditors.ButtonEdit
            Me.LookUpEdit_TurnoverType = New DevExpress.XtraEditors.LookUpEdit
            Me.Label_Supplier = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_Turnover = New DevExpress.XtraGrid.GridControl
            Me.ContextMenuStrip_Grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.ToolStripMenuItem_CopyTurnoverCode = New System.Windows.Forms.ToolStripMenuItem
            Me.GridView_Turnover = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_TurnoverCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverTime = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PosName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_EmployeeName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_TurnoverStyle = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverStyle = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_TurnoverConsignStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_ConsignStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_BalanceStatus = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_BalanceStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_PayAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SumPrice = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointUse = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointGain = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointToRMBRate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RMBToPointRAte = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SupplierName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.SaveFileDialog_ExportExcel = New System.Windows.Forms.SaveFileDialog
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            Me.Panel_DateRange.SuspendLayout()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel_Options.SuspendLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_CustomerCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ButtonEdit_SupplierCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LookUpEdit_TurnoverType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Turnover, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ContextMenuStrip_Grid.SuspendLayout()
            CType(Me.GridView_Turnover, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_ConsignStatus, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_BalanceStatus, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.AccessibleDescription = Nothing
            Me.ToolStrip_Form.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStrip_Form, "ToolStrip_Form")
            Me.ToolStrip_Form.BackgroundImage = Nothing
            Me.ToolStrip_Form.Font = Nothing
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_Create, Me.ToolStripButton_Revise, Me.ToolStripButton_Delete, Me.ToolStripButton_ConsignQuery, Me.ToolStripButton_DeliveryQuery, Me.ToolStripButton_PaymentQuery, Me.ToolStripButton_StaffCommission, Me.ToolStripButton_Refresh, Me.ToolStripButton_ExportExcel, Me.ToolStripButton_Print, Me.ToolStripButton_Close})
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
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.AccessibleDescription = Nothing
            Me.ToolStripButton_Choose.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Choose, "ToolStripButton_Choose")
            Me.ToolStripButton_Choose.BackgroundImage = Nothing
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            '
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.AccessibleDescription = Nothing
            Me.ToolStripButton_Create.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Create, "ToolStripButton_Create")
            Me.ToolStripButton_Create.BackgroundImage = Nothing
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            '
            'ToolStripButton_Revise
            '
            Me.ToolStripButton_Revise.AccessibleDescription = Nothing
            Me.ToolStripButton_Revise.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Revise, "ToolStripButton_Revise")
            Me.ToolStripButton_Revise.BackgroundImage = Nothing
            Me.ToolStripButton_Revise.Name = "ToolStripButton_Revise"
            '
            'ToolStripButton_Delete
            '
            Me.ToolStripButton_Delete.AccessibleDescription = Nothing
            Me.ToolStripButton_Delete.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Delete, "ToolStripButton_Delete")
            Me.ToolStripButton_Delete.BackgroundImage = Nothing
            Me.ToolStripButton_Delete.Name = "ToolStripButton_Delete"
            '
            'ToolStripButton_ConsignQuery
            '
            Me.ToolStripButton_ConsignQuery.AccessibleDescription = Nothing
            Me.ToolStripButton_ConsignQuery.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ConsignQuery, "ToolStripButton_ConsignQuery")
            Me.ToolStripButton_ConsignQuery.BackgroundImage = Nothing
            Me.ToolStripButton_ConsignQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ConsignQuery.Name = "ToolStripButton_ConsignQuery"
            '
            'ToolStripButton_DeliveryQuery
            '
            Me.ToolStripButton_DeliveryQuery.AccessibleDescription = Nothing
            Me.ToolStripButton_DeliveryQuery.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_DeliveryQuery, "ToolStripButton_DeliveryQuery")
            Me.ToolStripButton_DeliveryQuery.BackgroundImage = Nothing
            Me.ToolStripButton_DeliveryQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_DeliveryQuery.Name = "ToolStripButton_DeliveryQuery"
            '
            'ToolStripButton_PaymentQuery
            '
            Me.ToolStripButton_PaymentQuery.AccessibleDescription = Nothing
            Me.ToolStripButton_PaymentQuery.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_PaymentQuery, "ToolStripButton_PaymentQuery")
            Me.ToolStripButton_PaymentQuery.BackgroundImage = Nothing
            Me.ToolStripButton_PaymentQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_PaymentQuery.Name = "ToolStripButton_PaymentQuery"
            '
            'ToolStripButton_StaffCommission
            '
            Me.ToolStripButton_StaffCommission.AccessibleDescription = Nothing
            Me.ToolStripButton_StaffCommission.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_StaffCommission, "ToolStripButton_StaffCommission")
            Me.ToolStripButton_StaffCommission.BackgroundImage = Nothing
            Me.ToolStripButton_StaffCommission.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_StaffCommission.Name = "ToolStripButton_StaffCommission"
            '
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.AccessibleDescription = Nothing
            Me.ToolStripButton_Refresh.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Refresh, "ToolStripButton_Refresh")
            Me.ToolStripButton_Refresh.BackgroundImage = Nothing
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            '
            'ToolStripButton_ExportExcel
            '
            Me.ToolStripButton_ExportExcel.AccessibleDescription = Nothing
            Me.ToolStripButton_ExportExcel.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_ExportExcel, "ToolStripButton_ExportExcel")
            Me.ToolStripButton_ExportExcel.BackgroundImage = Nothing
            Me.ToolStripButton_ExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_ExportExcel.Name = "ToolStripButton_ExportExcel"
            '
            'ToolStripButton_Print
            '
            Me.ToolStripButton_Print.AccessibleDescription = Nothing
            Me.ToolStripButton_Print.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Print, "ToolStripButton_Print")
            Me.ToolStripButton_Print.BackgroundImage = Nothing
            Me.ToolStripButton_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me.ToolStripButton_Print.Name = "ToolStripButton_Print"
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.AccessibleDescription = Nothing
            Me.ToolStripButton_Close.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripButton_Close, "ToolStripButton_Close")
            Me.ToolStripButton_Close.BackgroundImage = Nothing
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.AccessibleDescription = Nothing
            Me.PanelControl_Filter.AccessibleName = Nothing
            resources.ApplyResources(Me.PanelControl_Filter, "PanelControl_Filter")
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.Panel_DateRange)
            Me.PanelControl_Filter.Controls.Add(Me.Panel_Options)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
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
            CTag24.ParentControl = Me.PanelControl_Filter
            CTag24.SkipValidate = False
            CTag24.TimeButtonTextBox = Nothing
            CTag24.ToolTip = ""
            CTag24.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag24
            '
            'Panel_DateRange
            '
            Me.Panel_DateRange.AccessibleDescription = Nothing
            Me.Panel_DateRange.AccessibleName = Nothing
            resources.ApplyResources(Me.Panel_DateRange, "Panel_DateRange")
            Me.Panel_DateRange.BackgroundImage = Nothing
            Me.Panel_DateRange.Controls.Add(Me.Label2)
            Me.Panel_DateRange.Controls.Add(Me.DateEdit_FromDate)
            Me.Panel_DateRange.Controls.Add(Me.DateEdit_ToDate)
            Me.Panel_DateRange.Controls.Add(Me.Label3)
            Me.Panel_DateRange.Font = Nothing
            Me.Panel_DateRange.Name = "Panel_DateRange"
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
            CTag6.ParentControl = Me.Panel_DateRange
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_DateRange.Tag = CTag6
            '
            'Label2
            '
            Me.Label2.AccessibleDescription = Nothing
            Me.Label2.AccessibleName = Nothing
            resources.ApplyResources(Me.Label2, "Label2")
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.Name = "Label2"
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
            CTag2.ParentControl = Me.Label2
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag2
            '
            'DateEdit_FromDate
            '
            resources.ApplyResources(Me.DateEdit_FromDate, "DateEdit_FromDate")
            Me.DateEdit_FromDate.BackgroundImage = Nothing
            Me.DateEdit_FromDate.EditValue = Nothing
            Me.DateEdit_FromDate.Name = "DateEdit_FromDate"
            Me.DateEdit_FromDate.Properties.AccessibleDescription = Nothing
            Me.DateEdit_FromDate.Properties.AccessibleName = Nothing
            Me.DateEdit_FromDate.Properties.AutoHeight = CType(resources.GetObject("DateEdit_FromDate.Properties.AutoHeight"), Boolean)
            Me.DateEdit_FromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_FromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_FromDate.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_FromDate.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.EditMask = resources.GetString("DateEdit_FromDate.Properties.Mask.EditMask")
            Me.DateEdit_FromDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_FromDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_FromDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_FromDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_FromDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_FromDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_FromDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag3.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag3.IsButtonCustomed = False
            CTag3.IsTextValid = True
            CTag3.KeyValueAbsentable = False
            CTag3.LeagleText = ""
            CTag3.NumericButtonTextBox = Nothing
            CTag3.ParentControl = Me.DateEdit_FromDate
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_FromDate.Tag = CTag3
            '
            'DateEdit_ToDate
            '
            resources.ApplyResources(Me.DateEdit_ToDate, "DateEdit_ToDate")
            Me.DateEdit_ToDate.BackgroundImage = Nothing
            Me.DateEdit_ToDate.EditValue = Nothing
            Me.DateEdit_ToDate.Name = "DateEdit_ToDate"
            Me.DateEdit_ToDate.Properties.AccessibleDescription = Nothing
            Me.DateEdit_ToDate.Properties.AccessibleName = Nothing
            Me.DateEdit_ToDate.Properties.AutoHeight = CType(resources.GetObject("DateEdit_ToDate.Properties.AutoHeight"), Boolean)
            Me.DateEdit_ToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("DateEdit_ToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.DateEdit_ToDate.Properties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_ToDate.Properties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.EditMask = resources.GetString("DateEdit_ToDate.Properties.Mask.EditMask")
            Me.DateEdit_ToDate.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.MaskType = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_ToDate.Properties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.PlaceHolder"), Char)
            Me.DateEdit_ToDate.Properties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_ToDate.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_ToDate.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.AccessibleDescription = Nothing
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.AccessibleName = Nothing
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.AutoHeight = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.AutoHeight"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.AutoComplete = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.BeepOnError = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.BeepOnError"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.EditMask = resources.GetString("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.EditMask")
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.IgnoreMaskBlank"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.MaskType = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.PlaceHolder = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.PlaceHolder"), Char)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.SaveLiteral = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.SaveLiteral"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.ShowPlaceHolders"), Boolean)
            Me.DateEdit_ToDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("DateEdit_ToDate.Properties.VistaTimeProperties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag4.ParentControl = Me.DateEdit_ToDate
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_ToDate.Tag = CTag4
            '
            'Label3
            '
            Me.Label3.AccessibleDescription = Nothing
            Me.Label3.AccessibleName = Nothing
            resources.ApplyResources(Me.Label3, "Label3")
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.Name = "Label3"
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
            CTag5.ParentControl = Me.Label3
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag5
            '
            'Panel_Options
            '
            Me.Panel_Options.AccessibleDescription = Nothing
            Me.Panel_Options.AccessibleName = Nothing
            resources.ApplyResources(Me.Panel_Options, "Panel_Options")
            Me.Panel_Options.BackgroundImage = Nothing
            Me.Panel_Options.Controls.Add(Me.Label_CustomerID)
            Me.Panel_Options.Controls.Add(Me.Label_CustomerName)
            Me.Panel_Options.Controls.Add(Me.LookUpEdit_Pos)
            Me.Panel_Options.Controls.Add(Me.ButtonEdit_CustomerCode)
            Me.Panel_Options.Controls.Add(Me.LookUpEdit_TurnoverStyle)
            Me.Panel_Options.Controls.Add(Me.Label_Customer)
            Me.Panel_Options.Controls.Add(Me.Label_SupplierID)
            Me.Panel_Options.Controls.Add(Me.Label4)
            Me.Panel_Options.Controls.Add(Me.Label_SupplierName)
            Me.Panel_Options.Controls.Add(Me.Label6)
            Me.Panel_Options.Controls.Add(Me.ButtonEdit_SupplierCode)
            Me.Panel_Options.Controls.Add(Me.LookUpEdit_TurnoverType)
            Me.Panel_Options.Controls.Add(Me.Label_Supplier)
            Me.Panel_Options.Controls.Add(Me.Label5)
            Me.Panel_Options.Font = Nothing
            Me.Panel_Options.Name = "Panel_Options"
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
            CTag21.ParentControl = Me.Panel_Options
            CTag21.SkipValidate = False
            CTag21.TimeButtonTextBox = Nothing
            CTag21.ToolTip = ""
            CTag21.ValueType = XL.Common.ControlValueType.Character
            Me.Panel_Options.Tag = CTag21
            '
            'Label_CustomerID
            '
            Me.Label_CustomerID.AccessibleDescription = Nothing
            Me.Label_CustomerID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_CustomerID, "Label_CustomerID")
            Me.Label_CustomerID.Font = Nothing
            Me.Label_CustomerID.Name = "Label_CustomerID"
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
            CTag7.ParentControl = Me.Label_CustomerID
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomerID.Tag = CTag7
            '
            'Label_CustomerName
            '
            Me.Label_CustomerName.AccessibleDescription = Nothing
            Me.Label_CustomerName.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_CustomerName, "Label_CustomerName")
            Me.Label_CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomerName.Font = Nothing
            Me.Label_CustomerName.Name = "Label_CustomerName"
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
            CTag8.ParentControl = Me.Label_CustomerName
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomerName.Tag = CTag8
            '
            'LookUpEdit_Pos
            '
            resources.ApplyResources(Me.LookUpEdit_Pos, "LookUpEdit_Pos")
            Me.LookUpEdit_Pos.BackgroundImage = Nothing
            Me.LookUpEdit_Pos.EditValue = Nothing
            Me.LookUpEdit_Pos.Name = "LookUpEdit_Pos"
            Me.LookUpEdit_Pos.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_Pos.Properties.AccessibleName = Nothing
            Me.LookUpEdit_Pos.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_Pos.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_Pos.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_Pos.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_Pos.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_CODE", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("POS_NAME", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_Pos.Properties.DisplayMember = "POS_NAME"
            Me.LookUpEdit_Pos.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_Pos.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.EditMask = resources.GetString("LookUpEdit_Pos.Properties.Mask.EditMask")
            Me.LookUpEdit_Pos.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_Pos.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_Pos.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_Pos.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_Pos.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_Pos.Properties.ValueMember = "POS_ID"
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
            CTag9.ParentControl = Me.LookUpEdit_Pos
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_Pos.Tag = CTag9
            '
            'ButtonEdit_CustomerCode
            '
            resources.ApplyResources(Me.ButtonEdit_CustomerCode, "ButtonEdit_CustomerCode")
            Me.ButtonEdit_CustomerCode.BackgroundImage = Nothing
            Me.ButtonEdit_CustomerCode.EditValue = Nothing
            Me.ButtonEdit_CustomerCode.Name = "ButtonEdit_CustomerCode"
            Me.ButtonEdit_CustomerCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_CustomerCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_CustomerCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_CustomerCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_CustomerCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_CustomerCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_CustomerCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_CustomerCode.Properties.Mask.EditMask")
            Me.ButtonEdit_CustomerCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_CustomerCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_CustomerCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_CustomerCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_CustomerCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_CustomerCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_CustomerCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag10.ParentControl = Me.ButtonEdit_CustomerCode
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_CustomerCode.Tag = CTag10
            '
            'LookUpEdit_TurnoverStyle
            '
            resources.ApplyResources(Me.LookUpEdit_TurnoverStyle, "LookUpEdit_TurnoverStyle")
            Me.LookUpEdit_TurnoverStyle.BackgroundImage = Nothing
            Me.LookUpEdit_TurnoverStyle.EditValue = Nothing
            Me.LookUpEdit_TurnoverStyle.Name = "LookUpEdit_TurnoverStyle"
            Me.LookUpEdit_TurnoverStyle.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_TurnoverStyle.Properties.AccessibleName = Nothing
            Me.LookUpEdit_TurnoverStyle.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_TurnoverStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_TurnoverStyle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverStyle.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.EditMask = resources.GetString("LookUpEdit_TurnoverStyle.Properties.Mask.EditMask")
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_TurnoverStyle.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_TurnoverStyle.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_TurnoverStyle.Properties.ValueMember = "ITEM_VALUE"
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
            CTag11.ParentControl = Me.LookUpEdit_TurnoverStyle
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverStyle.Tag = CTag11
            '
            'Label_Customer
            '
            Me.Label_Customer.AccessibleDescription = Nothing
            Me.Label_Customer.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_Customer, "Label_Customer")
            Me.Label_Customer.Font = Nothing
            Me.Label_Customer.Name = "Label_Customer"
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
            CTag12.ParentControl = Me.Label_Customer
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Label_Customer.Tag = CTag12
            '
            'Label_SupplierID
            '
            Me.Label_SupplierID.AccessibleDescription = Nothing
            Me.Label_SupplierID.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_SupplierID, "Label_SupplierID")
            Me.Label_SupplierID.Font = Nothing
            Me.Label_SupplierID.Name = "Label_SupplierID"
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
            CTag13.ParentControl = Me.Label_SupplierID
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierID.Tag = CTag13
            '
            'Label4
            '
            Me.Label4.AccessibleDescription = Nothing
            Me.Label4.AccessibleName = Nothing
            resources.ApplyResources(Me.Label4, "Label4")
            Me.Label4.BackColor = System.Drawing.Color.White
            Me.Label4.ForeColor = System.Drawing.Color.Black
            Me.Label4.Name = "Label4"
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
            CTag14.ParentControl = Me.Label4
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.Label4.Tag = CTag14
            '
            'Label_SupplierName
            '
            Me.Label_SupplierName.AccessibleDescription = Nothing
            Me.Label_SupplierName.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_SupplierName, "Label_SupplierName")
            Me.Label_SupplierName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_SupplierName.Font = Nothing
            Me.Label_SupplierName.Name = "Label_SupplierName"
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
            CTag15.ParentControl = Me.Label_SupplierName
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.Label_SupplierName.Tag = CTag15
            '
            'Label6
            '
            Me.Label6.AccessibleDescription = Nothing
            Me.Label6.AccessibleName = Nothing
            resources.ApplyResources(Me.Label6, "Label6")
            Me.Label6.BackColor = System.Drawing.Color.White
            Me.Label6.ForeColor = System.Drawing.Color.Black
            Me.Label6.Name = "Label6"
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
            CTag16.ParentControl = Me.Label6
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.Label6.Tag = CTag16
            '
            'ButtonEdit_SupplierCode
            '
            resources.ApplyResources(Me.ButtonEdit_SupplierCode, "ButtonEdit_SupplierCode")
            Me.ButtonEdit_SupplierCode.BackgroundImage = Nothing
            Me.ButtonEdit_SupplierCode.EditValue = Nothing
            Me.ButtonEdit_SupplierCode.Name = "ButtonEdit_SupplierCode"
            Me.ButtonEdit_SupplierCode.Properties.AccessibleDescription = Nothing
            Me.ButtonEdit_SupplierCode.Properties.AccessibleName = Nothing
            Me.ButtonEdit_SupplierCode.Properties.AutoHeight = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.AutoHeight"), Boolean)
            Me.ButtonEdit_SupplierCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_SupplierCode.Properties.Mask.AutoComplete = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.ButtonEdit_SupplierCode.Properties.Mask.BeepOnError = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.BeepOnError"), Boolean)
            Me.ButtonEdit_SupplierCode.Properties.Mask.EditMask = resources.GetString("ButtonEdit_SupplierCode.Properties.Mask.EditMask")
            Me.ButtonEdit_SupplierCode.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.ButtonEdit_SupplierCode.Properties.Mask.MaskType = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.ButtonEdit_SupplierCode.Properties.Mask.PlaceHolder = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.PlaceHolder"), Char)
            Me.ButtonEdit_SupplierCode.Properties.Mask.SaveLiteral = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.SaveLiteral"), Boolean)
            Me.ButtonEdit_SupplierCode.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.ButtonEdit_SupplierCode.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("ButtonEdit_SupplierCode.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag17.ParentControl = Me.ButtonEdit_SupplierCode
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_SupplierCode.Tag = CTag17
            '
            'LookUpEdit_TurnoverType
            '
            resources.ApplyResources(Me.LookUpEdit_TurnoverType, "LookUpEdit_TurnoverType")
            Me.LookUpEdit_TurnoverType.BackgroundImage = Nothing
            Me.LookUpEdit_TurnoverType.EditValue = Nothing
            Me.LookUpEdit_TurnoverType.Name = "LookUpEdit_TurnoverType"
            Me.LookUpEdit_TurnoverType.Properties.AccessibleDescription = Nothing
            Me.LookUpEdit_TurnoverType.Properties.AccessibleName = Nothing
            Me.LookUpEdit_TurnoverType.Properties.AutoHeight = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.AutoHeight"), Boolean)
            Me.LookUpEdit_TurnoverType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.LookUpEdit_TurnoverType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.LookUpEdit_TurnoverType.Properties.DisplayMember = "ITEM_MEANING"
            Me.LookUpEdit_TurnoverType.Properties.Mask.AutoComplete = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.LookUpEdit_TurnoverType.Properties.Mask.BeepOnError = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.BeepOnError"), Boolean)
            Me.LookUpEdit_TurnoverType.Properties.Mask.EditMask = resources.GetString("LookUpEdit_TurnoverType.Properties.Mask.EditMask")
            Me.LookUpEdit_TurnoverType.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.LookUpEdit_TurnoverType.Properties.Mask.MaskType = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.LookUpEdit_TurnoverType.Properties.Mask.PlaceHolder = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.PlaceHolder"), Char)
            Me.LookUpEdit_TurnoverType.Properties.Mask.SaveLiteral = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.SaveLiteral"), Boolean)
            Me.LookUpEdit_TurnoverType.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.LookUpEdit_TurnoverType.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("LookUpEdit_TurnoverType.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.LookUpEdit_TurnoverType.Properties.ValueMember = "ITEM_VALUE"
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
            CTag18.ParentControl = Me.LookUpEdit_TurnoverType
            CTag18.SkipValidate = False
            CTag18.TimeButtonTextBox = Nothing
            CTag18.ToolTip = ""
            CTag18.ValueType = XL.Common.ControlValueType.Character
            Me.LookUpEdit_TurnoverType.Tag = CTag18
            '
            'Label_Supplier
            '
            Me.Label_Supplier.AccessibleDescription = Nothing
            Me.Label_Supplier.AccessibleName = Nothing
            resources.ApplyResources(Me.Label_Supplier, "Label_Supplier")
            Me.Label_Supplier.Font = Nothing
            Me.Label_Supplier.Name = "Label_Supplier"
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
            CTag19.ParentControl = Me.Label_Supplier
            CTag19.SkipValidate = False
            CTag19.TimeButtonTextBox = Nothing
            CTag19.ToolTip = ""
            CTag19.ValueType = XL.Common.ControlValueType.Character
            Me.Label_Supplier.Tag = CTag19
            '
            'Label5
            '
            Me.Label5.AccessibleDescription = Nothing
            Me.Label5.AccessibleName = Nothing
            resources.ApplyResources(Me.Label5, "Label5")
            Me.Label5.BackColor = System.Drawing.Color.White
            Me.Label5.ForeColor = System.Drawing.Color.Black
            Me.Label5.Name = "Label5"
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
            CTag20.ParentControl = Me.Label5
            CTag20.SkipValidate = False
            CTag20.TimeButtonTextBox = Nothing
            CTag20.ToolTip = ""
            CTag20.ValueType = XL.Common.ControlValueType.Character
            Me.Label5.Tag = CTag20
            '
            'TextEdit_Search
            '
            resources.ApplyResources(Me.TextEdit_Search, "TextEdit_Search")
            Me.TextEdit_Search.BackgroundImage = Nothing
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Properties.AccessibleDescription = Nothing
            Me.TextEdit_Search.Properties.AccessibleName = Nothing
            Me.TextEdit_Search.Properties.AutoHeight = CType(resources.GetObject("TextEdit_Search.Properties.AutoHeight"), Boolean)
            Me.TextEdit_Search.Properties.Mask.AutoComplete = CType(resources.GetObject("TextEdit_Search.Properties.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.TextEdit_Search.Properties.Mask.BeepOnError = CType(resources.GetObject("TextEdit_Search.Properties.Mask.BeepOnError"), Boolean)
            Me.TextEdit_Search.Properties.Mask.EditMask = resources.GetString("TextEdit_Search.Properties.Mask.EditMask")
            Me.TextEdit_Search.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("TextEdit_Search.Properties.Mask.IgnoreMaskBlank"), Boolean)
            Me.TextEdit_Search.Properties.Mask.MaskType = CType(resources.GetObject("TextEdit_Search.Properties.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.TextEdit_Search.Properties.Mask.PlaceHolder = CType(resources.GetObject("TextEdit_Search.Properties.Mask.PlaceHolder"), Char)
            Me.TextEdit_Search.Properties.Mask.SaveLiteral = CType(resources.GetObject("TextEdit_Search.Properties.Mask.SaveLiteral"), Boolean)
            Me.TextEdit_Search.Properties.Mask.ShowPlaceHolders = CType(resources.GetObject("TextEdit_Search.Properties.Mask.ShowPlaceHolders"), Boolean)
            Me.TextEdit_Search.Properties.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("TextEdit_Search.Properties.Mask.UseMaskAsDisplayFormat"), Boolean)
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
            CTag22.ParentControl = Me.TextEdit_Search
            CTag22.SkipValidate = False
            CTag22.TimeButtonTextBox = Nothing
            CTag22.ToolTip = ""
            CTag22.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag22
            '
            'Label1
            '
            Me.Label1.AccessibleDescription = Nothing
            Me.Label1.AccessibleName = Nothing
            resources.ApplyResources(Me.Label1, "Label1")
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.Name = "Label1"
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
            CTag23.ParentControl = Me.Label1
            CTag23.SkipValidate = False
            CTag23.TimeButtonTextBox = Nothing
            CTag23.ToolTip = ""
            CTag23.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag23
            '
            'GridControl_Turnover
            '
            Me.GridControl_Turnover.AccessibleDescription = Nothing
            Me.GridControl_Turnover.AccessibleName = Nothing
            resources.ApplyResources(Me.GridControl_Turnover, "GridControl_Turnover")
            Me.GridControl_Turnover.BackgroundImage = Nothing
            Me.GridControl_Turnover.ContextMenuStrip = Me.ContextMenuStrip_Grid
            Me.GridControl_Turnover.EmbeddedNavigator.AccessibleDescription = Nothing
            Me.GridControl_Turnover.EmbeddedNavigator.AccessibleName = Nothing
            Me.GridControl_Turnover.EmbeddedNavigator.Anchor = CType(resources.GetObject("GridControl_Turnover.EmbeddedNavigator.Anchor"), System.Windows.Forms.AnchorStyles)
            Me.GridControl_Turnover.EmbeddedNavigator.BackgroundImage = Nothing
            Me.GridControl_Turnover.EmbeddedNavigator.BackgroundImageLayout = CType(resources.GetObject("GridControl_Turnover.EmbeddedNavigator.BackgroundImageLayout"), System.Windows.Forms.ImageLayout)
            Me.GridControl_Turnover.EmbeddedNavigator.ImeMode = CType(resources.GetObject("GridControl_Turnover.EmbeddedNavigator.ImeMode"), System.Windows.Forms.ImeMode)
            Me.GridControl_Turnover.EmbeddedNavigator.Name = ""
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
            CTag25.ParentControl = Me.GridControl_Turnover.EmbeddedNavigator
            CTag25.SkipValidate = False
            CTag25.TimeButtonTextBox = Nothing
            CTag25.ToolTip = ""
            CTag25.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Turnover.EmbeddedNavigator.Tag = CTag25
            Me.GridControl_Turnover.EmbeddedNavigator.TextLocation = CType(resources.GetObject("GridControl_Turnover.EmbeddedNavigator.TextLocation"), DevExpress.XtraEditors.NavigatorButtonsTextLocation)
            Me.GridControl_Turnover.EmbeddedNavigator.ToolTip = resources.GetString("GridControl_Turnover.EmbeddedNavigator.ToolTip")
            Me.GridControl_Turnover.EmbeddedNavigator.ToolTipIconType = CType(resources.GetObject("GridControl_Turnover.EmbeddedNavigator.ToolTipIconType"), DevExpress.Utils.ToolTipIconType)
            Me.GridControl_Turnover.EmbeddedNavigator.ToolTipTitle = resources.GetString("GridControl_Turnover.EmbeddedNavigator.ToolTipTitle")
            Me.GridControl_Turnover.Font = Nothing
            Me.GridControl_Turnover.MainView = Me.GridView_Turnover
            Me.GridControl_Turnover.Name = "GridControl_Turnover"
            Me.GridControl_Turnover.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit_TurnoverType, Me.RepositoryItemLookUpEdit_TurnoverStyle, Me.RepositoryItemLookUpEdit_ConsignStatus, Me.RepositoryItemLookUpEdit_BalanceStatus})
            Me.GridControl_Turnover.TabStop = False
            Me.GridControl_Turnover.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Turnover})
            '
            'ContextMenuStrip_Grid
            '
            Me.ContextMenuStrip_Grid.AccessibleDescription = Nothing
            Me.ContextMenuStrip_Grid.AccessibleName = Nothing
            resources.ApplyResources(Me.ContextMenuStrip_Grid, "ContextMenuStrip_Grid")
            Me.ContextMenuStrip_Grid.BackgroundImage = Nothing
            Me.ContextMenuStrip_Grid.Font = Nothing
            Me.ContextMenuStrip_Grid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem_CopyTurnoverCode})
            Me.ContextMenuStrip_Grid.Name = "ContextMenuStrip_Grid"
            '
            'ToolStripMenuItem_CopyTurnoverCode
            '
            Me.ToolStripMenuItem_CopyTurnoverCode.AccessibleDescription = Nothing
            Me.ToolStripMenuItem_CopyTurnoverCode.AccessibleName = Nothing
            resources.ApplyResources(Me.ToolStripMenuItem_CopyTurnoverCode, "ToolStripMenuItem_CopyTurnoverCode")
            Me.ToolStripMenuItem_CopyTurnoverCode.BackgroundImage = Nothing
            Me.ToolStripMenuItem_CopyTurnoverCode.Name = "ToolStripMenuItem_CopyTurnoverCode"
            Me.ToolStripMenuItem_CopyTurnoverCode.ShortcutKeyDisplayString = Nothing
            '
            'GridView_Turnover
            '
            resources.ApplyResources(Me.GridView_Turnover, "GridView_Turnover")
            Me.GridView_Turnover.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_TurnoverCode, Me.GridColumn_TurnoverTime, Me.GridColumn_PosCode, Me.GridColumn_PosName, Me.GridColumn_EmployeeName, Me.GridColumn_TurnoverType, Me.GridColumn_TurnoverStyle, Me.GridColumn_TurnoverConsignStatus, Me.GridColumn_BalanceStatus, Me.GridColumn_PayAmount, Me.GridColumn_SumPrice, Me.GridColumn_CustomerName, Me.GridColumn_PointUse, Me.GridColumn_PointGain, Me.GridColumn_PointToRMBRate, Me.GridColumn_RMBToPointRAte, Me.GridColumn_SupplierName, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition2.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition2.Appearance.Options.UseBackColor = True
            StyleFormatCondition2.ApplyToRow = True
            StyleFormatCondition2.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition2.Value1 = "TURNOVER_CONSIGN_NOT_YET"
            StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.White
            StyleFormatCondition3.Appearance.BackColor2 = System.Drawing.Color.Blue
            StyleFormatCondition3.Appearance.Options.UseBackColor = True
            StyleFormatCondition3.ApplyToRow = True
            StyleFormatCondition3.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition3.Value1 = "BALANCE_NOT_YET"
            StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.Red
            StyleFormatCondition4.Appearance.BackColor2 = System.Drawing.Color.Blue
            StyleFormatCondition4.Appearance.Options.UseBackColor = True
            StyleFormatCondition4.ApplyToRow = True
            StyleFormatCondition4.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition4.Value1 = "ALL_NOT_YET"
            Me.GridView_Turnover.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3, StyleFormatCondition4})
            Me.GridView_Turnover.GridControl = Me.GridControl_Turnover
            Me.GridView_Turnover.Name = "GridView_Turnover"
            Me.GridView_Turnover.OptionsView.ColumnAutoWidth = False
            Me.GridView_Turnover.OptionsView.ShowFooter = True
            Me.GridView_Turnover.OptionsView.ShowGroupPanel = False
            Me.GridView_Turnover.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn_TurnoverCode, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'GridColumn_TurnoverCode
            '
            resources.ApplyResources(Me.GridColumn_TurnoverCode, "GridColumn_TurnoverCode")
            Me.GridColumn_TurnoverCode.FieldName = "TURNOVER_CODE"
            Me.GridColumn_TurnoverCode.Name = "GridColumn_TurnoverCode"
            Me.GridColumn_TurnoverCode.OptionsColumn.ReadOnly = True
            Me.GridColumn_TurnoverCode.SummaryItem.DisplayFormat = resources.GetString("GridColumn_TurnoverCode.SummaryItem.DisplayFormat")
            Me.GridColumn_TurnoverCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            '
            'GridColumn_TurnoverTime
            '
            resources.ApplyResources(Me.GridColumn_TurnoverTime, "GridColumn_TurnoverTime")
            Me.GridColumn_TurnoverTime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm"
            Me.GridColumn_TurnoverTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_TurnoverTime.FieldName = "TURNOVER_TIME"
            Me.GridColumn_TurnoverTime.Name = "GridColumn_TurnoverTime"
            Me.GridColumn_TurnoverTime.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PosCode
            '
            resources.ApplyResources(Me.GridColumn_PosCode, "GridColumn_PosCode")
            Me.GridColumn_PosCode.FieldName = "POS_CODE"
            Me.GridColumn_PosCode.Name = "GridColumn_PosCode"
            Me.GridColumn_PosCode.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PosName
            '
            resources.ApplyResources(Me.GridColumn_PosName, "GridColumn_PosName")
            Me.GridColumn_PosName.FieldName = "POS_NAME"
            Me.GridColumn_PosName.Name = "GridColumn_PosName"
            Me.GridColumn_PosName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_EmployeeName
            '
            resources.ApplyResources(Me.GridColumn_EmployeeName, "GridColumn_EmployeeName")
            Me.GridColumn_EmployeeName.FieldName = "STAFF_NAME"
            Me.GridColumn_EmployeeName.Name = "GridColumn_EmployeeName"
            Me.GridColumn_EmployeeName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_TurnoverType
            '
            resources.ApplyResources(Me.GridColumn_TurnoverType, "GridColumn_TurnoverType")
            Me.GridColumn_TurnoverType.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverType
            Me.GridColumn_TurnoverType.FieldName = "TURNOVER_TYPE"
            Me.GridColumn_TurnoverType.Name = "GridColumn_TurnoverType"
            Me.GridColumn_TurnoverType.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_TurnoverType
            '
            Me.RepositoryItemLookUpEdit_TurnoverType.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_TurnoverType.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_TurnoverType, "RepositoryItemLookUpEdit_TurnoverType")
            Me.RepositoryItemLookUpEdit_TurnoverType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_TurnoverType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_TurnoverType.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverType.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverType.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverType.Name = "RepositoryItemLookUpEdit_TurnoverType"
            Me.RepositoryItemLookUpEdit_TurnoverType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_TurnoverStyle
            '
            resources.ApplyResources(Me.GridColumn_TurnoverStyle, "GridColumn_TurnoverStyle")
            Me.GridColumn_TurnoverStyle.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverStyle
            Me.GridColumn_TurnoverStyle.FieldName = "TURNOVER_STYLE"
            Me.GridColumn_TurnoverStyle.Name = "GridColumn_TurnoverStyle"
            Me.GridColumn_TurnoverStyle.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_TurnoverStyle
            '
            Me.RepositoryItemLookUpEdit_TurnoverStyle.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_TurnoverStyle.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_TurnoverStyle, "RepositoryItemLookUpEdit_TurnoverStyle")
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverStyle.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_TurnoverStyle.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_TurnoverStyle.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_TurnoverStyle.Name = "RepositoryItemLookUpEdit_TurnoverStyle"
            Me.RepositoryItemLookUpEdit_TurnoverStyle.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_TurnoverConsignStatus
            '
            resources.ApplyResources(Me.GridColumn_TurnoverConsignStatus, "GridColumn_TurnoverConsignStatus")
            Me.GridColumn_TurnoverConsignStatus.ColumnEdit = Me.RepositoryItemLookUpEdit_ConsignStatus
            Me.GridColumn_TurnoverConsignStatus.FieldName = "TURNOVER_CONSIGN_STATUS"
            Me.GridColumn_TurnoverConsignStatus.Name = "GridColumn_TurnoverConsignStatus"
            Me.GridColumn_TurnoverConsignStatus.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_ConsignStatus
            '
            Me.RepositoryItemLookUpEdit_ConsignStatus.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_ConsignStatus.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_ConsignStatus, "RepositoryItemLookUpEdit_ConsignStatus")
            Me.RepositoryItemLookUpEdit_ConsignStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_ConsignStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_ConsignStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_ConsignStatus.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_ConsignStatus.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_ConsignStatus.Name = "RepositoryItemLookUpEdit_ConsignStatus"
            Me.RepositoryItemLookUpEdit_ConsignStatus.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_BalanceStatus
            '
            resources.ApplyResources(Me.GridColumn_BalanceStatus, "GridColumn_BalanceStatus")
            Me.GridColumn_BalanceStatus.ColumnEdit = Me.RepositoryItemLookUpEdit_BalanceStatus
            Me.GridColumn_BalanceStatus.FieldName = "BALANCE_STATUS"
            Me.GridColumn_BalanceStatus.Name = "GridColumn_BalanceStatus"
            Me.GridColumn_BalanceStatus.OptionsColumn.AllowFocus = False
            '
            'RepositoryItemLookUpEdit_BalanceStatus
            '
            Me.RepositoryItemLookUpEdit_BalanceStatus.AccessibleDescription = Nothing
            Me.RepositoryItemLookUpEdit_BalanceStatus.AccessibleName = Nothing
            resources.ApplyResources(Me.RepositoryItemLookUpEdit_BalanceStatus, "RepositoryItemLookUpEdit_BalanceStatus")
            Me.RepositoryItemLookUpEdit_BalanceStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.RepositoryItemLookUpEdit_BalanceStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", " ", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_BalanceStatus.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.AutoComplete = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.AutoComplete"), DevExpress.XtraEditors.Mask.AutoCompleteType)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.BeepOnError = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.BeepOnError"), Boolean)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.EditMask = resources.GetString("RepositoryItemLookUpEdit_BalanceStatus.Mask.EditMask")
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.IgnoreMaskBlank = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.IgnoreMaskBlank"), Boolean)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.MaskType = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.MaskType"), DevExpress.XtraEditors.Mask.MaskType)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.PlaceHolder = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.PlaceHolder"), Char)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.SaveLiteral = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.SaveLiteral"), Boolean)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.ShowPlaceHolders = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.ShowPlaceHolders"), Boolean)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Mask.UseMaskAsDisplayFormat = CType(resources.GetObject("RepositoryItemLookUpEdit_BalanceStatus.Mask.UseMaskAsDisplayFormat"), Boolean)
            Me.RepositoryItemLookUpEdit_BalanceStatus.Name = "RepositoryItemLookUpEdit_BalanceStatus"
            Me.RepositoryItemLookUpEdit_BalanceStatus.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_PayAmount
            '
            resources.ApplyResources(Me.GridColumn_PayAmount, "GridColumn_PayAmount")
            Me.GridColumn_PayAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_PayAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_PayAmount.FieldName = "PAY_AMOUNT"
            Me.GridColumn_PayAmount.Name = "GridColumn_PayAmount"
            Me.GridColumn_PayAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_PayAmount.SummaryItem.DisplayFormat = resources.GetString("GridColumn_PayAmount.SummaryItem.DisplayFormat")
            Me.GridColumn_PayAmount.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_SumPrice
            '
            resources.ApplyResources(Me.GridColumn_SumPrice, "GridColumn_SumPrice")
            Me.GridColumn_SumPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_SumPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_SumPrice.FieldName = "SUM_PRICE"
            Me.GridColumn_SumPrice.Name = "GridColumn_SumPrice"
            Me.GridColumn_SumPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_SumPrice.SummaryItem.DisplayFormat = resources.GetString("GridColumn_SumPrice.SummaryItem.DisplayFormat")
            Me.GridColumn_SumPrice.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
            '
            'GridColumn_CustomerName
            '
            resources.ApplyResources(Me.GridColumn_CustomerName, "GridColumn_CustomerName")
            Me.GridColumn_CustomerName.FieldName = "CLIENT_NAME"
            Me.GridColumn_CustomerName.Name = "GridColumn_CustomerName"
            Me.GridColumn_CustomerName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PointUse
            '
            resources.ApplyResources(Me.GridColumn_PointUse, "GridColumn_PointUse")
            Me.GridColumn_PointUse.FieldName = "POINT_USE"
            Me.GridColumn_PointUse.Name = "GridColumn_PointUse"
            Me.GridColumn_PointUse.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PointGain
            '
            resources.ApplyResources(Me.GridColumn_PointGain, "GridColumn_PointGain")
            Me.GridColumn_PointGain.FieldName = "POINT_GAIN"
            Me.GridColumn_PointGain.Name = "GridColumn_PointGain"
            Me.GridColumn_PointGain.OptionsColumn.AllowFocus = False
            '
            'GridColumn_PointToRMBRate
            '
            resources.ApplyResources(Me.GridColumn_PointToRMBRate, "GridColumn_PointToRMBRate")
            Me.GridColumn_PointToRMBRate.FieldName = "POINT_TO_RMB_RATE"
            Me.GridColumn_PointToRMBRate.Name = "GridColumn_PointToRMBRate"
            Me.GridColumn_PointToRMBRate.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RMBToPointRAte
            '
            resources.ApplyResources(Me.GridColumn_RMBToPointRAte, "GridColumn_RMBToPointRAte")
            Me.GridColumn_RMBToPointRAte.FieldName = "RMB_TO_POINT_RATE"
            Me.GridColumn_RMBToPointRAte.Name = "GridColumn_RMBToPointRAte"
            Me.GridColumn_RMBToPointRAte.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SupplierName
            '
            resources.ApplyResources(Me.GridColumn_SupplierName, "GridColumn_SupplierName")
            Me.GridColumn_SupplierName.FieldName = "SUPPLIER_NAME"
            Me.GridColumn_SupplierName.Name = "GridColumn_SupplierName"
            Me.GridColumn_SupplierName.OptionsColumn.AllowFocus = False
            '
            'GridColumn_RowHighlight
            '
            resources.ApplyResources(Me.GridColumn_RowHighlight, "GridColumn_RowHighlight")
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'SaveFileDialog_ExportExcel
            '
            resources.ApplyResources(Me.SaveFileDialog_ExportExcel, "SaveFileDialog_ExportExcel")
            '
            'M_02_00101
            '
            Me.AccessibleDescription = Nothing
            Me.AccessibleName = Nothing
            resources.ApplyResources(Me, "$this")
            Me.BackgroundImage = Nothing
            Me.Controls.Add(Me.GridControl_Turnover)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Name = "M_02_00101"
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
            CTag26.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag26.IsButtonCustomed = False
            CTag26.IsTextValid = True
            CTag26.KeyValueAbsentable = False
            CTag26.LeagleText = ""
            CTag26.NumericButtonTextBox = Nothing
            CTag26.ParentControl = Me
            CTag26.SkipValidate = False
            CTag26.TimeButtonTextBox = Nothing
            CTag26.ToolTip = ""
            CTag26.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag26
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            Me.Panel_DateRange.ResumeLayout(False)
            Me.Panel_DateRange.PerformLayout()
            CType(Me.DateEdit_FromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_FromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_ToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel_Options.ResumeLayout(False)
            Me.Panel_Options.PerformLayout()
            CType(Me.LookUpEdit_Pos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_CustomerCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverStyle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ButtonEdit_SupplierCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LookUpEdit_TurnoverType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Turnover, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ContextMenuStrip_Grid.ResumeLayout(False)
            CType(Me.GridView_Turnover, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverStyle, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_ConsignStatus, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_BalanceStatus, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_TurnoverType As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_ToDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DateEdit_FromDate As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_TurnoverStyle As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents LookUpEdit_Pos As DevExpress.XtraEditors.LookUpEdit
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents GridControl_Turnover As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Turnover As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_SumPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PayAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverTime As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PosName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_EmployeeName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverStyle As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverConsignStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_BalanceStatus As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverStyle As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents RepositoryItemLookUpEdit_ConsignStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_SupplierName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_BalanceStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents ToolStripButton_ConsignQuery As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_DeliveryQuery As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_PaymentQuery As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_ExportExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents Panel_DateRange As System.Windows.Forms.Panel
        Friend WithEvents Panel_Options As System.Windows.Forms.Panel
        Friend WithEvents ToolStripButton_StaffCommission As System.Windows.Forms.ToolStripButton
        Friend WithEvents SaveFileDialog_ExportExcel As System.Windows.Forms.SaveFileDialog
        Friend WithEvents ContextMenuStrip_Grid As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents ToolStripMenuItem_CopyTurnoverCode As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ToolStripButton_Print As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridColumn_PointUse As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PointGain As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PointToRMBRate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RMBToPointRAte As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Label_CustomerName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_CustomerCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_Customer As System.Windows.Forms.Label
        Friend WithEvents Label_SupplierID As System.Windows.Forms.Label
        Friend WithEvents Label_SupplierName As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_SupplierCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_Supplier As System.Windows.Forms.Label
        Friend WithEvents Label_CustomerID As System.Windows.Forms.Label

#End Region

    End Class

End Namespace
