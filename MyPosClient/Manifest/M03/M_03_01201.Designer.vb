Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_03_01201
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
        Friend WithEvents ToolStripButton_ShowFilter As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Delete As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_View As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Create = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_ShowFilter = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Delete = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_View = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.Label_ClientID = New System.Windows.Forms.Label
            Me.Label_ClientName = New System.Windows.Forms.Label
            Me.ButtonEdit_ClientCode = New DevExpress.XtraEditors.ButtonEdit
            Me.DateEdit_End = New DevExpress.XtraEditors.DateEdit
            Me.DateEdit_Begin = New DevExpress.XtraEditors.DateEdit
            Me.Label2 = New System.Windows.Forms.Label
            Me.Label3 = New System.Windows.Forms.Label
            Me.Label1 = New System.Windows.Forms.Label
            Me.GridControl_ClientPointIO = New DevExpress.XtraGrid.GridControl
            Me.GridView_ClientPointIO = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_IODate = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_ClientID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_ClientID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_PointAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_TurnoverID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_TurnoverID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Remark = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_MoneyAmount = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_PointIOType = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_PointIOType = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_RowSelected = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_RowSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_RowHighLight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.ButtonEdit_ClientCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_End.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_End.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_Begin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DateEdit_Begin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl_ClientPointIO, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_ClientPointIO, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_ClientID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_PointIOType, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_Create, Me.ToolStripButton_ShowFilter, Me.ToolStripButton_Delete, Me.ToolStripButton_Refresh, Me.ToolStripButton_View, Me.ToolStripButton_Close})
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
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            Me.ToolStripButton_Choose.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Choose.Text = "选择"
            Me.ToolStripButton_Choose.Visible = False
            '
            'ToolStripButton_Create
            '
            Me.ToolStripButton_Create.Name = "ToolStripButton_Create"
            Me.ToolStripButton_Create.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_Create.Text = "新建"
            '
            'ToolStripButton_ShowFilter
            '
            Me.ToolStripButton_ShowFilter.Name = "ToolStripButton_ShowFilter"
            Me.ToolStripButton_ShowFilter.Size = New System.Drawing.Size(59, 22)
            Me.ToolStripButton_ShowFilter.Text = "筛选条件"
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
            'ToolStripButton_View
            '
            Me.ToolStripButton_View.Name = "ToolStripButton_View"
            Me.ToolStripButton_View.Size = New System.Drawing.Size(35, 22)
            Me.ToolStripButton_View.Text = "查看"
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
            Me.PanelControl1.Controls.Add(Me.Label_ClientID)
            Me.PanelControl1.Controls.Add(Me.Label_ClientName)
            Me.PanelControl1.Controls.Add(Me.ButtonEdit_ClientCode)
            Me.PanelControl1.Controls.Add(Me.DateEdit_End)
            Me.PanelControl1.Controls.Add(Me.DateEdit_Begin)
            Me.PanelControl1.Controls.Add(Me.Label2)
            Me.PanelControl1.Controls.Add(Me.Label3)
            Me.PanelControl1.Controls.Add(Me.Label1)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(700, 65)
            Me.PanelControl1.TabIndex = 10001
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
            CTag10.ParentControl = Me.PanelControl1
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag10
            '
            'Label_ClientID
            '
            Me.Label_ClientID.BackColor = System.Drawing.Color.White
            Me.Label_ClientID.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_ClientID.ForeColor = System.Drawing.Color.Black
            Me.Label_ClientID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_ClientID.Location = New System.Drawing.Point(373, 41)
            Me.Label_ClientID.Name = "Label_ClientID"
            Me.Label_ClientID.Size = New System.Drawing.Size(62, 15)
            Me.Label_ClientID.TabIndex = 10003
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
            CTag2.ParentControl = Me.Label_ClientID
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ClientID.Tag = CTag2
            Me.Label_ClientID.Text = "ClientID"
            Me.Label_ClientID.Visible = False
            '
            'Label_ClientName
            '
            Me.Label_ClientName.BackColor = System.Drawing.Color.White
            Me.Label_ClientName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_ClientName.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label_ClientName.ForeColor = System.Drawing.Color.Black
            Me.Label_ClientName.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_ClientName.Location = New System.Drawing.Point(230, 37)
            Me.Label_ClientName.Name = "Label_ClientName"
            Me.Label_ClientName.Size = New System.Drawing.Size(129, 25)
            Me.Label_ClientName.TabIndex = 10002
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
            CTag3.ParentControl = Me.Label_ClientName
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_ClientName.Tag = CTag3
            '
            'ButtonEdit_ClientCode
            '
            Me.ButtonEdit_ClientCode.Location = New System.Drawing.Point(75, 38)
            Me.ButtonEdit_ClientCode.Name = "ButtonEdit_ClientCode"
            Me.ButtonEdit_ClientCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_ClientCode.Size = New System.Drawing.Size(149, 20)
            Me.ButtonEdit_ClientCode.TabIndex = 10001
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
            CTag4.ParentControl = Me.ButtonEdit_ClientCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_ClientCode.Tag = CTag4
            '
            'DateEdit_End
            '
            Me.DateEdit_End.EditValue = Nothing
            Me.DateEdit_End.Location = New System.Drawing.Point(255, 8)
            Me.DateEdit_End.Name = "DateEdit_End"
            Me.DateEdit_End.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_End.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_End.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_End.Size = New System.Drawing.Size(149, 20)
            Me.DateEdit_End.TabIndex = 10000
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
            CTag5.ParentControl = Me.DateEdit_End
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_End.Tag = CTag5
            '
            'DateEdit_Begin
            '
            Me.DateEdit_Begin.EditValue = Nothing
            Me.DateEdit_Begin.Location = New System.Drawing.Point(75, 8)
            Me.DateEdit_Begin.Name = "DateEdit_Begin"
            Me.DateEdit_Begin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.DateEdit_Begin.Properties.NullDate = New Date(1753, 1, 1, 12, 0, 0, 0)
            Me.DateEdit_Begin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.DateEdit_Begin.Size = New System.Drawing.Size(149, 20)
            Me.DateEdit_Begin.TabIndex = 10000
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
            CTag6.ParentControl = Me.DateEdit_Begin
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.DateEdit_Begin.Tag = CTag6
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.BackColor = System.Drawing.Color.White
            Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label2.ForeColor = System.Drawing.Color.Black
            Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label2.Location = New System.Drawing.Point(232, 13)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(19, 15)
            Me.Label2.TabIndex = 10000
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
            CTag7.ParentControl = Me.Label2
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label2.Tag = CTag7
            Me.Label2.Text = "至"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.BackColor = System.Drawing.Color.White
            Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label3.ForeColor = System.Drawing.Color.Black
            Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label3.Location = New System.Drawing.Point(8, 41)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(31, 15)
            Me.Label3.TabIndex = 10000
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
            CTag8.ParentControl = Me.Label3
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.Label3.Tag = CTag8
            Me.Label3.Text = "客户"
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(8, 14)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(43, 15)
            Me.Label1.TabIndex = 10000
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
            CTag9.ParentControl = Me.Label1
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag9
            Me.Label1.Text = "日期从"
            '
            'GridControl_ClientPointIO
            '
            Me.GridControl_ClientPointIO.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_ClientPointIO.EmbeddedNavigator.Name = ""
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
            CTag11.ParentControl = Me.GridControl_ClientPointIO.EmbeddedNavigator
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_ClientPointIO.EmbeddedNavigator.Tag = CTag11
            Me.GridControl_ClientPointIO.Location = New System.Drawing.Point(0, 90)
            Me.GridControl_ClientPointIO.MainView = Me.GridView_ClientPointIO
            Me.GridControl_ClientPointIO.Name = "GridControl_ClientPointIO"
            Me.GridControl_ClientPointIO.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_RowSelected, Me.RepositoryItemLookUpEdit_TurnoverID, Me.RepositoryItemLookUpEdit_ClientID, Me.RepositoryItemLookUpEdit_PointIOType})
            Me.GridControl_ClientPointIO.Size = New System.Drawing.Size(700, 410)
            Me.GridControl_ClientPointIO.TabIndex = 10002
            Me.GridControl_ClientPointIO.TabStop = False
            Me.GridControl_ClientPointIO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_ClientPointIO})
            '
            'GridView_ClientPointIO
            '
            Me.GridView_ClientPointIO.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_IODate, Me.GridColumn_ClientID, Me.GridColumn_PointIOType, Me.GridColumn_PointAmount, Me.GridColumn_TurnoverID, Me.GridColumn_Remark, Me.GridColumn_MoneyAmount, Me.GridColumn_RowSelected, Me.GridColumn_RowHighLight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighLight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_ClientPointIO.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_ClientPointIO.GridControl = Me.GridControl_ClientPointIO
            Me.GridView_ClientPointIO.Name = "GridView_ClientPointIO"
            Me.GridView_ClientPointIO.OptionsView.ColumnAutoWidth = False
            Me.GridView_ClientPointIO.OptionsView.ShowFooter = True
            Me.GridView_ClientPointIO.OptionsView.ShowGroupPanel = False
            Me.GridView_ClientPointIO.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn_TurnoverID, DevExpress.Data.ColumnSortOrder.Ascending)})
            '
            'GridColumn_IODate
            '
            Me.GridColumn_IODate.Caption = "出入日期"
            Me.GridColumn_IODate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm"
            Me.GridColumn_IODate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            Me.GridColumn_IODate.FieldName = "IO_DATE"
            Me.GridColumn_IODate.Name = "GridColumn_IODate"
            Me.GridColumn_IODate.OptionsColumn.AllowEdit = False
            Me.GridColumn_IODate.OptionsColumn.AllowFocus = False
            Me.GridColumn_IODate.SummaryItem.FieldName = "CLIENT_CODE"
            Me.GridColumn_IODate.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_IODate.Visible = True
            Me.GridColumn_IODate.VisibleIndex = 1
            '
            'GridColumn_ClientID
            '
            Me.GridColumn_ClientID.Caption = "客户"
            Me.GridColumn_ClientID.ColumnEdit = Me.RepositoryItemLookUpEdit_ClientID
            Me.GridColumn_ClientID.FieldName = "CLIENT_ID"
            Me.GridColumn_ClientID.Name = "GridColumn_ClientID"
            Me.GridColumn_ClientID.OptionsColumn.AllowEdit = False
            Me.GridColumn_ClientID.OptionsColumn.AllowFocus = False
            Me.GridColumn_ClientID.Visible = True
            Me.GridColumn_ClientID.VisibleIndex = 2
            '
            'RepositoryItemLookUpEdit_ClientID
            '
            Me.RepositoryItemLookUpEdit_ClientID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_ClientID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_ClientID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CLIENT_NAME", "Name2", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_ClientID.DisplayMember = "CLIENT_NAME"
            Me.RepositoryItemLookUpEdit_ClientID.Name = "RepositoryItemLookUpEdit_ClientID"
            Me.RepositoryItemLookUpEdit_ClientID.ValueMember = "CLIENT_ID"
            '
            'GridColumn_PointAmount
            '
            Me.GridColumn_PointAmount.Caption = "出入点数"
            Me.GridColumn_PointAmount.FieldName = "POINT_AMOUNT"
            Me.GridColumn_PointAmount.Name = "GridColumn_PointAmount"
            Me.GridColumn_PointAmount.OptionsColumn.AllowEdit = False
            Me.GridColumn_PointAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_PointAmount.Visible = True
            Me.GridColumn_PointAmount.VisibleIndex = 4
            '
            'GridColumn_TurnoverID
            '
            Me.GridColumn_TurnoverID.Caption = "出入库编号"
            Me.GridColumn_TurnoverID.ColumnEdit = Me.RepositoryItemLookUpEdit_TurnoverID
            Me.GridColumn_TurnoverID.FieldName = "TURNOVER_ID"
            Me.GridColumn_TurnoverID.Name = "GridColumn_TurnoverID"
            Me.GridColumn_TurnoverID.OptionsColumn.AllowEdit = False
            Me.GridColumn_TurnoverID.OptionsColumn.AllowFocus = False
            Me.GridColumn_TurnoverID.Visible = True
            Me.GridColumn_TurnoverID.VisibleIndex = 5
            '
            'RepositoryItemLookUpEdit_TurnoverID
            '
            Me.RepositoryItemLookUpEdit_TurnoverID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_TurnoverID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_TurnoverID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TURNOVER_CODE", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_TurnoverID.DisplayMember = "TURNOVER_CODE"
            Me.RepositoryItemLookUpEdit_TurnoverID.Name = "RepositoryItemLookUpEdit_TurnoverID"
            Me.RepositoryItemLookUpEdit_TurnoverID.ValueMember = "TURNOVER_ID"
            '
            'GridColumn_Remark
            '
            Me.GridColumn_Remark.Caption = "备注"
            Me.GridColumn_Remark.FieldName = "REMARK"
            Me.GridColumn_Remark.Name = "GridColumn_Remark"
            Me.GridColumn_Remark.OptionsColumn.AllowEdit = False
            Me.GridColumn_Remark.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remark.Visible = True
            Me.GridColumn_Remark.VisibleIndex = 6
            '
            'GridColumn_MoneyAmount
            '
            Me.GridColumn_MoneyAmount.Caption = "对应金额"
            Me.GridColumn_MoneyAmount.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_MoneyAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_MoneyAmount.FieldName = "MONEY_AMOUNT"
            Me.GridColumn_MoneyAmount.Name = "GridColumn_MoneyAmount"
            Me.GridColumn_MoneyAmount.OptionsColumn.AllowEdit = False
            Me.GridColumn_MoneyAmount.OptionsColumn.AllowFocus = False
            Me.GridColumn_MoneyAmount.Visible = True
            Me.GridColumn_MoneyAmount.VisibleIndex = 7
            '
            'GridColumn_PointIOType
            '
            Me.GridColumn_PointIOType.Caption = "点数出入类型"
            Me.GridColumn_PointIOType.ColumnEdit = Me.RepositoryItemLookUpEdit_PointIOType
            Me.GridColumn_PointIOType.FieldName = "POINT_IO_TYPE"
            Me.GridColumn_PointIOType.Name = "GridColumn_PointIOType"
            Me.GridColumn_PointIOType.OptionsColumn.AllowFocus = False
            Me.GridColumn_PointIOType.Visible = True
            Me.GridColumn_PointIOType.VisibleIndex = 3
            '
            'RepositoryItemLookUpEdit_PointIOType
            '
            Me.RepositoryItemLookUpEdit_PointIOType.AutoHeight = False
            Me.RepositoryItemLookUpEdit_PointIOType.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_PointIOType.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ITEM_MEANING", "Name3", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_PointIOType.DisplayMember = "ITEM_MEANING"
            Me.RepositoryItemLookUpEdit_PointIOType.Name = "RepositoryItemLookUpEdit_PointIOType"
            Me.RepositoryItemLookUpEdit_PointIOType.ValueMember = "ITEM_VALUE"
            '
            'GridColumn_RowSelected
            '
            Me.GridColumn_RowSelected.Caption = "选择"
            Me.GridColumn_RowSelected.ColumnEdit = Me.RepositoryItemCheckEdit_RowSelected
            Me.GridColumn_RowSelected.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelected.Name = "GridColumn_RowSelected"
            Me.GridColumn_RowSelected.Visible = True
            Me.GridColumn_RowSelected.VisibleIndex = 0
            '
            'RepositoryItemCheckEdit_RowSelected
            '
            Me.RepositoryItemCheckEdit_RowSelected.AutoHeight = False
            Me.RepositoryItemCheckEdit_RowSelected.Name = "RepositoryItemCheckEdit_RowSelected"
            '
            'GridColumn_RowHighLight
            '
            Me.GridColumn_RowHighLight.Caption = "HighLight"
            Me.GridColumn_RowHighLight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighLight.Name = "GridColumn_RowHighLight"
            Me.GridColumn_RowHighLight.OptionsColumn.AllowFocus = False
            '
            'M_03_01201
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.GridControl_ClientPointIO)
            Me.Controls.Add(Me.PanelControl1)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_03_01201"
            Me.Size = New System.Drawing.Size(700, 500)
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
            CTag12.ParentControl = Me
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag12
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            Me.PanelControl1.PerformLayout()
            CType(Me.ButtonEdit_ClientCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_End.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_End.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_Begin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DateEdit_Begin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl_ClientPointIO, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_ClientPointIO, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_ClientID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_TurnoverID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_PointIOType, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_RowSelected, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents DateEdit_End As DevExpress.XtraEditors.DateEdit
        Friend WithEvents DateEdit_Begin As DevExpress.XtraEditors.DateEdit
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents GridControl_ClientPointIO As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_ClientPointIO As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_IODate As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_ClientID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_PointAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_TurnoverID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_Remark As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_MoneyAmount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowSelected As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_RowSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Friend WithEvents RepositoryItemLookUpEdit_TurnoverID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_RowHighLight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ButtonEdit_ClientCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label_ClientID As System.Windows.Forms.Label
        Friend WithEvents Label_ClientName As System.Windows.Forms.Label
        Friend WithEvents RepositoryItemLookUpEdit_ClientID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_PointIOType As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_PointIOType As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

#End Region

    End Class

End Namespace

