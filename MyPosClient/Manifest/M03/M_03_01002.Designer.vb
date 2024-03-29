Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_01002
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
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Add = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Save = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Remove = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.LinkLabel_ApplySellDiscount = New System.Windows.Forms.LinkLabel
            Me.SpinEdit_SellDiscount = New DevExpress.XtraEditors.SpinEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_Customer = New DevExpress.XtraGrid.GridControl
            Me.GridView_Customer = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_CustomerCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomerName = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Address = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WorkPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Fax = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Linkman = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CellPhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Email = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Title = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Department = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PostCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_HomePhone = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_City = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_State = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_Country = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_WebSite = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr2 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr3 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr4 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr5 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientAttr6 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighLight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_SellDiscount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemSpinEdit_SellDiscount = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.SpinEdit_SellDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Customer, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemSpinEdit_SellDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'ToolStripButton_Add
            '
            Me.ToolStripButton_Add.Name = "ToolStripButton_Add"
            Me.ToolStripButton_Add.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Add.Text = "添加"
            Me.ToolStripButton_Add.Visible = False
            '
            'ToolStripButton_Save
            '
            Me.ToolStripButton_Save.Name = "ToolStripButton_Save"
            Me.ToolStripButton_Save.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Save.Text = "保存"
            '
            'ToolStripButton_Remove
            '
            Me.ToolStripButton_Remove.Name = "ToolStripButton_Remove"
            Me.ToolStripButton_Remove.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Remove.Text = "去除"
            Me.ToolStripButton_Remove.Visible = False
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
            Me.PanelControl1.Controls.Add(Me.LinkLabel_ApplySellDiscount)
            Me.PanelControl1.Controls.Add(Me.SpinEdit_SellDiscount)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(700, 73)
            Me.PanelControl1.TabIndex = 10000
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
            CTag5.ParentControl = Me.PanelControl1
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag5
            '
            'LinkLabel_ApplySellDiscount
            '
            Me.LinkLabel_ApplySellDiscount.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.LinkLabel_ApplySellDiscount.Location = New System.Drawing.Point(212, 24)
            Me.LinkLabel_ApplySellDiscount.Name = "LinkLabel_ApplySellDiscount"
            Me.LinkLabel_ApplySellDiscount.Size = New System.Drawing.Size(35, 20)
            Me.LinkLabel_ApplySellDiscount.TabIndex = 10006
            Me.LinkLabel_ApplySellDiscount.TabStop = True
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
            CTag2.ParentControl = Me.LinkLabel_ApplySellDiscount
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.LinkLabel_ApplySellDiscount.Tag = CTag2
            Me.LinkLabel_ApplySellDiscount.Text = "采用"
            '
            'SpinEdit_SellDiscount
            '
            Me.SpinEdit_SellDiscount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.SpinEdit_SellDiscount.Location = New System.Drawing.Point(90, 21)
            Me.SpinEdit_SellDiscount.Name = "SpinEdit_SellDiscount"
            Me.SpinEdit_SellDiscount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.SpinEdit_SellDiscount.Size = New System.Drawing.Size(116, 21)
            Me.SpinEdit_SellDiscount.TabIndex = 10005
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
            CTag3.ParentControl = Me.SpinEdit_SellDiscount
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.SpinEdit_SellDiscount.Tag = CTag3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.Transparent
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(5, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(79, 15)
            Me.Label1.TabIndex = 10004
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
            CTag4.ParentControl = Me.Label1
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag4
            Me.Label1.Text = "统一额外折扣"
            '
            'GridControl_Customer
            '
            Me.GridControl_Customer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Customer.EmbeddedNavigator.Name = ""
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
            CTag6.ParentControl = Me.GridControl_Customer.EmbeddedNavigator
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Customer.EmbeddedNavigator.Tag = CTag6
            Me.GridControl_Customer.Location = New System.Drawing.Point(0, 98)
            Me.GridControl_Customer.MainView = Me.GridView_Customer
            Me.GridControl_Customer.Name = "GridControl_Customer"
            Me.GridControl_Customer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit_SellDiscount})
            Me.GridControl_Customer.Size = New System.Drawing.Size(700, 402)
            Me.GridControl_Customer.TabIndex = 10001
            Me.GridControl_Customer.TabStop = False
            Me.GridControl_Customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Customer})
            '
            'GridView_Customer
            '
            Me.GridView_Customer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_CustomerCode, Me.GridColumn_CustomerName, Me.GridColumn_Address, Me.GridColumn_WorkPhone, Me.GridColumn_Fax, Me.GridColumn_Linkman, Me.GridColumn_CellPhone, Me.GridColumn_Email, Me.GridColumn_Title, Me.GridColumn_Department, Me.GridColumn_PostCode, Me.GridColumn_Remarks, Me.GridColumn_HomePhone, Me.GridColumn_City, Me.GridColumn_State, Me.GridColumn_Country, Me.GridColumn_WebSite, Me.GridColumn_ClientAttr1, Me.GridColumn_ClientAttr2, Me.GridColumn_ClientAttr3, Me.GridColumn_ClientAttr4, Me.GridColumn_ClientAttr5, Me.GridColumn_ClientAttr6, Me.GridColumn_RowHighLight, Me.GridColumn_SellDiscount})
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Customer.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Customer.GridControl = Me.GridControl_Customer
            Me.GridView_Customer.Name = "GridView_Customer"
            Me.GridView_Customer.OptionsView.ColumnAutoWidth = False
            Me.GridView_Customer.OptionsView.ShowFooter = True
            Me.GridView_Customer.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_CustomerCode
            '
            Me.GridColumn_CustomerCode.Caption = "客户编码"
            Me.GridColumn_CustomerCode.FieldName = "CLIENT_CODE"
            Me.GridColumn_CustomerCode.Name = "GridColumn_CustomerCode"
            Me.GridColumn_CustomerCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomerCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_CustomerCode.Visible = True
            Me.GridColumn_CustomerCode.VisibleIndex = 1
            '
            'GridColumn_CustomerName
            '
            Me.GridColumn_CustomerName.Caption = "客户名"
            Me.GridColumn_CustomerName.FieldName = "CLIENT_NAME"
            Me.GridColumn_CustomerName.Name = "GridColumn_CustomerName"
            Me.GridColumn_CustomerName.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomerName.Visible = True
            Me.GridColumn_CustomerName.VisibleIndex = 2
            '
            'GridColumn_Address
            '
            Me.GridColumn_Address.Caption = "地址"
            Me.GridColumn_Address.FieldName = "ADDRESS"
            Me.GridColumn_Address.Name = "GridColumn_Address"
            Me.GridColumn_Address.OptionsColumn.AllowFocus = False
            Me.GridColumn_Address.Visible = True
            Me.GridColumn_Address.VisibleIndex = 3
            '
            'GridColumn_WorkPhone
            '
            Me.GridColumn_WorkPhone.Caption = "工作电话"
            Me.GridColumn_WorkPhone.FieldName = "WORK_PHONE"
            Me.GridColumn_WorkPhone.Name = "GridColumn_WorkPhone"
            Me.GridColumn_WorkPhone.OptionsColumn.AllowFocus = False
            Me.GridColumn_WorkPhone.Visible = True
            Me.GridColumn_WorkPhone.VisibleIndex = 4
            '
            'GridColumn_Fax
            '
            Me.GridColumn_Fax.Caption = "传真"
            Me.GridColumn_Fax.FieldName = "FAX"
            Me.GridColumn_Fax.Name = "GridColumn_Fax"
            Me.GridColumn_Fax.OptionsColumn.AllowFocus = False
            Me.GridColumn_Fax.Visible = True
            Me.GridColumn_Fax.VisibleIndex = 5
            '
            'GridColumn_Linkman
            '
            Me.GridColumn_Linkman.Caption = "联系人"
            Me.GridColumn_Linkman.FieldName = "LINKMAN"
            Me.GridColumn_Linkman.Name = "GridColumn_Linkman"
            Me.GridColumn_Linkman.OptionsColumn.AllowFocus = False
            Me.GridColumn_Linkman.Visible = True
            Me.GridColumn_Linkman.VisibleIndex = 6
            '
            'GridColumn_CellPhone
            '
            Me.GridColumn_CellPhone.Caption = "手机"
            Me.GridColumn_CellPhone.FieldName = "CELL_PHONE"
            Me.GridColumn_CellPhone.Name = "GridColumn_CellPhone"
            Me.GridColumn_CellPhone.OptionsColumn.AllowFocus = False
            Me.GridColumn_CellPhone.Visible = True
            Me.GridColumn_CellPhone.VisibleIndex = 7
            '
            'GridColumn_Email
            '
            Me.GridColumn_Email.Caption = "电子邮件"
            Me.GridColumn_Email.FieldName = "EMAIL"
            Me.GridColumn_Email.Name = "GridColumn_Email"
            Me.GridColumn_Email.OptionsColumn.AllowFocus = False
            Me.GridColumn_Email.Visible = True
            Me.GridColumn_Email.VisibleIndex = 8
            '
            'GridColumn_Title
            '
            Me.GridColumn_Title.Caption = "职务"
            Me.GridColumn_Title.FieldName = "TITLE"
            Me.GridColumn_Title.Name = "GridColumn_Title"
            Me.GridColumn_Title.OptionsColumn.AllowFocus = False
            Me.GridColumn_Title.Visible = True
            Me.GridColumn_Title.VisibleIndex = 9
            '
            'GridColumn_Department
            '
            Me.GridColumn_Department.Caption = "部门"
            Me.GridColumn_Department.FieldName = "DEPARTMENT"
            Me.GridColumn_Department.Name = "GridColumn_Department"
            Me.GridColumn_Department.OptionsColumn.AllowFocus = False
            Me.GridColumn_Department.Visible = True
            Me.GridColumn_Department.VisibleIndex = 10
            '
            'GridColumn_PostCode
            '
            Me.GridColumn_PostCode.Caption = "邮编"
            Me.GridColumn_PostCode.FieldName = "POST_CODE"
            Me.GridColumn_PostCode.Name = "GridColumn_PostCode"
            Me.GridColumn_PostCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_PostCode.Visible = True
            Me.GridColumn_PostCode.VisibleIndex = 11
            '
            'GridColumn_Remarks
            '
            Me.GridColumn_Remarks.Caption = "备注"
            Me.GridColumn_Remarks.FieldName = "REMARKS"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remarks.Visible = True
            Me.GridColumn_Remarks.VisibleIndex = 12
            '
            'GridColumn_HomePhone
            '
            Me.GridColumn_HomePhone.Caption = "家庭电话"
            Me.GridColumn_HomePhone.FieldName = "HOME_PHONE"
            Me.GridColumn_HomePhone.Name = "GridColumn_HomePhone"
            Me.GridColumn_HomePhone.OptionsColumn.AllowFocus = False
            Me.GridColumn_HomePhone.Visible = True
            Me.GridColumn_HomePhone.VisibleIndex = 13
            '
            'GridColumn_City
            '
            Me.GridColumn_City.Caption = "城市"
            Me.GridColumn_City.FieldName = "CITY"
            Me.GridColumn_City.Name = "GridColumn_City"
            Me.GridColumn_City.OptionsColumn.AllowFocus = False
            Me.GridColumn_City.Visible = True
            Me.GridColumn_City.VisibleIndex = 14
            '
            'GridColumn_State
            '
            Me.GridColumn_State.Caption = "省/州"
            Me.GridColumn_State.FieldName = "STATE"
            Me.GridColumn_State.Name = "GridColumn_State"
            Me.GridColumn_State.OptionsColumn.AllowFocus = False
            Me.GridColumn_State.Visible = True
            Me.GridColumn_State.VisibleIndex = 15
            '
            'GridColumn_Country
            '
            Me.GridColumn_Country.Caption = "国家"
            Me.GridColumn_Country.FieldName = "COUNTRY"
            Me.GridColumn_Country.Name = "GridColumn_Country"
            Me.GridColumn_Country.OptionsColumn.AllowFocus = False
            Me.GridColumn_Country.Visible = True
            Me.GridColumn_Country.VisibleIndex = 16
            '
            'GridColumn_WebSite
            '
            Me.GridColumn_WebSite.Caption = "网页"
            Me.GridColumn_WebSite.FieldName = "WEB_SITE"
            Me.GridColumn_WebSite.Name = "GridColumn_WebSite"
            Me.GridColumn_WebSite.OptionsColumn.AllowFocus = False
            Me.GridColumn_WebSite.Visible = True
            Me.GridColumn_WebSite.VisibleIndex = 17
            '
            'GridColumn_ClientAttr1
            '
            Me.GridColumn_ClientAttr1.Caption = "ClientAttr1"
            Me.GridColumn_ClientAttr1.FieldName = "CLIENT_ATTR1"
            Me.GridColumn_ClientAttr1.Name = "GridColumn_ClientAttr1"
            Me.GridColumn_ClientAttr1.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientAttr1.Visible = True
            Me.GridColumn_ClientAttr1.VisibleIndex = 18
            '
            'GridColumn_ClientAttr2
            '
            Me.GridColumn_ClientAttr2.Caption = "ClientAttr2"
            Me.GridColumn_ClientAttr2.FieldName = "CLIENT_ATTR2"
            Me.GridColumn_ClientAttr2.Name = "GridColumn_ClientAttr2"
            Me.GridColumn_ClientAttr2.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientAttr2.Visible = True
            Me.GridColumn_ClientAttr2.VisibleIndex = 19
            '
            'GridColumn_ClientAttr3
            '
            Me.GridColumn_ClientAttr3.Caption = "ClientAttr3"
            Me.GridColumn_ClientAttr3.FieldName = "CLIENT_ATTR3"
            Me.GridColumn_ClientAttr3.Name = "GridColumn_ClientAttr3"
            Me.GridColumn_ClientAttr3.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientAttr3.Visible = True
            Me.GridColumn_ClientAttr3.VisibleIndex = 20
            '
            'GridColumn_ClientAttr4
            '
            Me.GridColumn_ClientAttr4.Caption = "ClientAttr4"
            Me.GridColumn_ClientAttr4.FieldName = "CLIENT_ATTR4"
            Me.GridColumn_ClientAttr4.Name = "GridColumn_ClientAttr4"
            Me.GridColumn_ClientAttr4.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientAttr4.Visible = True
            Me.GridColumn_ClientAttr4.VisibleIndex = 21
            '
            'GridColumn_ClientAttr5
            '
            Me.GridColumn_ClientAttr5.Caption = "ClientAttr5"
            Me.GridColumn_ClientAttr5.FieldName = "CLIENT_ATTR5"
            Me.GridColumn_ClientAttr5.Name = "GridColumn_ClientAttr5"
            Me.GridColumn_ClientAttr5.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientAttr5.Visible = True
            Me.GridColumn_ClientAttr5.VisibleIndex = 22
            '
            'GridColumn_ClientAttr6
            '
            Me.GridColumn_ClientAttr6.Caption = "ClientAttr6"
            Me.GridColumn_ClientAttr6.FieldName = "CLIENT_ATTR6"
            Me.GridColumn_ClientAttr6.Name = "GridColumn_ClientAttr6"
            Me.GridColumn_ClientAttr6.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientAttr6.Visible = True
            Me.GridColumn_ClientAttr6.VisibleIndex = 23
            '
            'GridColumn_RowHighLight
            '
            Me.GridColumn_RowHighLight.Caption = "GridColumn19"
            Me.GridColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighLight.Name = "GridColumn_RowHighLight"
            Me.GridColumn_RowHighLight.OptionsColumn.AllowFocus = False
            '
            'GridColumn_SellDiscount
            '
            Me.GridColumn_SellDiscount.Caption = "额外折扣"
            Me.GridColumn_SellDiscount.ColumnEdit = Me.RepositoryItemSpinEdit_SellDiscount
            Me.GridColumn_SellDiscount.FieldName = "SELL_DISCOUNT"
            Me.GridColumn_SellDiscount.Name = "GridColumn_SellDiscount"
            Me.GridColumn_SellDiscount.Visible = True
            Me.GridColumn_SellDiscount.VisibleIndex = 0
            '
            'RepositoryItemSpinEdit_SellDiscount
            '
            Me.RepositoryItemSpinEdit_SellDiscount.AutoHeight = False
            Me.RepositoryItemSpinEdit_SellDiscount.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.RepositoryItemSpinEdit_SellDiscount.Name = "RepositoryItemSpinEdit_SellDiscount"
            '
            'M_03_01002
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_Customer)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_03_01002"
            Me.Size = New System.Drawing.Size(700, 500)
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
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.SpinEdit_SellDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_Customer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Customer, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemSpinEdit_SellDiscount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents GridControl_Customer As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Customer As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_CustomerCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CustomerName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Address As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WorkPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Fax As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Linkman As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_CellPhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Email As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Title As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Department As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PostCode As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_HomePhone As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_City As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_State As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Country As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_WebSite As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr1 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr2 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr3 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr4 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr5 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientAttr6 As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighLight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents LinkLabel_ApplySellDiscount As System.Windows.Forms.LinkLabel
        Friend WithEvents SpinEdit_SellDiscount As DevExpress.XtraEditors.SpinEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridColumn_SellDiscount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemSpinEdit_SellDiscount As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

#End Region

    End Class

End Namespace
