Namespace Manifest

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class M_01_00206
        'Inherits System.Windows.Forms.UserControl
        Inherits XL.Win.Component.BaseForm

#Region" Windows ������������ɵĴ���"

        Public Sub New()
            MyBase.New()

            '�õ����� Windows ���������������ġ�
            InitializeComponent()

            '�� InitializeComponent() ����֮������κγ�ʼ��

        End Sub

        '������д dispose ����������б�
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Windows ����������������
        Private components As System.ComponentModel.IContainer

        'ע��: ���¹����� Windows ����������������
        '����ʹ�� Windows ����������޸Ĵ˹��̡�
        '��Ҫʹ�ô���༭���޸�����
        Friend WithEvents ToolStrip_Form As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton_Refresh As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_Close As System.Windows.Forms.ToolStripButton
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim CTag1 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag8 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag2 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag3 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag4 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag5 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag6 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag7 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag16 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag14 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(M_01_00206))
            Dim CTag9 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag10 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag11 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
            Dim CTag12 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag13 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag15 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Dim CTag17 As XL.Win.Utils.CTag = New XL.Win.Utils.CTag
            Me.ToolStrip_Form = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_Refresh = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_Close = New System.Windows.Forms.ToolStripButton
            Me.PanelControl_Filter = New DevExpress.XtraEditors.PanelControl
            Me.Label_WareID = New System.Windows.Forms.Label
            Me.Label_CustomCode = New System.Windows.Forms.Label
            Me.ButtonEdit_WareCode = New DevExpress.XtraEditors.ButtonEdit
            Me.Label18 = New System.Windows.Forms.Label
            Me.TextEdit_Search = New DevExpress.XtraEditors.TextEdit
            Me.Label1 = New System.Windows.Forms.Label
            Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
            Me.XtraTabPage_ComponentOption = New DevExpress.XtraTab.XtraTabPage
            Me.SplitContainerControl_BomSetup = New DevExpress.XtraEditors.SplitContainerControl
            Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
            Me.TreeList_Component = New DevExpress.XtraTreeList.TreeList
            Me.TreeListColumn_TreeIcon = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.RepositoryItemImageComboBox_TreeIcon = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.ImageCollection_TreeIcon = New DevExpress.Utils.ImageCollection(Me.components)
            Me.TreeListColumn_Component = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.RepositoryItemTextEdit_ComponentName = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
            Me.TreeListColumn_ComponentRowHighlight = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
            Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_AddComponent = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_RemoveComponent = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_RefreshComponents = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_SaveComponents = New System.Windows.Forms.ToolStripButton
            Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
            Me.GridControl_Ware = New DevExpress.XtraGrid.GridControl
            Me.GridView_Ware = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.GridColumn_RowSelect = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCheckEdit_Select = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
            Me.GridColumn_WareCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_CustomCode = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemCalcEdit_MaxQty = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
            Me.RepositoryItemCalcEdit_MinQty = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
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
            Me.GridColumn_SupplierID = New DevExpress.XtraGrid.Columns.GridColumn
            Me.RepositoryItemLookUpEdit_SupplierID = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
            Me.GridColumn_Remarks = New DevExpress.XtraGrid.Columns.GridColumn
            Me.GridColumn_RowHighlight = New DevExpress.XtraGrid.Columns.GridColumn
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
            Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
            Me.ToolStripButton_AddOptions = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_RemoveOptions = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_RefreshOptions = New System.Windows.Forms.ToolStripButton
            Me.ToolStripButton_SaveOptions = New System.Windows.Forms.ToolStripButton
            Me.XtraTabPage_OverView = New DevExpress.XtraTab.XtraTabPage
            Me.TreeList_OverViewList = New DevExpress.XtraTreeList.TreeList
            Me.TreeListColumn1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
            Me.TreeListColumn2 = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
            Me.TreeListColumn3 = New DevExpress.XtraTreeList.Columns.TreeListColumn
            Me.ToolStripButton_Choose = New System.Windows.Forms.ToolStripButton
            Me.ToolStrip_Form.SuspendLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl_Filter.SuspendLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.XtraTabControl1.SuspendLayout()
            Me.XtraTabPage_ComponentOption.SuspendLayout()
            CType(Me.SplitContainerControl_BomSetup, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerControl_BomSetup.SuspendLayout()
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl1.SuspendLayout()
            CType(Me.TreeList_Component, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemImageComboBox_TreeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ImageCollection_TreeIcon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit_ComponentName, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolStrip2.SuspendLayout()
            CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupControl2.SuspendLayout()
            CType(Me.GridControl_Ware, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView_Ware, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_MaxQty, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_MinQty, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemLookUpEdit_SupplierID, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ToolStrip1.SuspendLayout()
            Me.XtraTabPage_OverView.SuspendLayout()
            CType(Me.TreeList_OverViewList, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.ToolStrip_Form.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_Choose, Me.ToolStripButton_Refresh, Me.ToolStripButton_Close})
            Me.ToolStrip_Form.Location = New System.Drawing.Point(0, 0)
            Me.ToolStrip_Form.Name = "ToolStrip_Form"
            Me.ToolStrip_Form.Size = New System.Drawing.Size(749, 25)
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
            'ToolStripButton_Refresh
            '
            Me.ToolStripButton_Refresh.Name = "ToolStripButton_Refresh"
            Me.ToolStripButton_Refresh.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Refresh.Text = "ˢ��"
            Me.ToolStripButton_Refresh.Visible = False
            '
            'ToolStripButton_Close
            '
            Me.ToolStripButton_Close.Name = "ToolStripButton_Close"
            Me.ToolStripButton_Close.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Close.Text = "�ر�"
            '
            'PanelControl_Filter
            '
            Me.PanelControl_Filter.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl_Filter.Appearance.Options.UseBackColor = True
            Me.PanelControl_Filter.Controls.Add(Me.Label_WareID)
            Me.PanelControl_Filter.Controls.Add(Me.Label_CustomCode)
            Me.PanelControl_Filter.Controls.Add(Me.ButtonEdit_WareCode)
            Me.PanelControl_Filter.Controls.Add(Me.Label18)
            Me.PanelControl_Filter.Controls.Add(Me.TextEdit_Search)
            Me.PanelControl_Filter.Controls.Add(Me.Label1)
            Me.PanelControl_Filter.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl_Filter.Location = New System.Drawing.Point(0, 25)
            Me.PanelControl_Filter.Name = "PanelControl_Filter"
            Me.PanelControl_Filter.Size = New System.Drawing.Size(749, 48)
            Me.PanelControl_Filter.TabIndex = 10001
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
            CTag8.ParentControl = Me.PanelControl_Filter
            CTag8.SkipValidate = False
            CTag8.TimeButtonTextBox = Nothing
            CTag8.ToolTip = ""
            CTag8.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl_Filter.Tag = CTag8
            '
            'Label_WareID
            '
            Me.Label_WareID.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_WareID.Location = New System.Drawing.Point(346, 19)
            Me.Label_WareID.Name = "Label_WareID"
            Me.Label_WareID.Size = New System.Drawing.Size(25, 18)
            Me.Label_WareID.TabIndex = 10004
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
            CTag2.ParentControl = Me.Label_WareID
            CTag2.SkipValidate = False
            CTag2.TimeButtonTextBox = Nothing
            CTag2.ToolTip = ""
            CTag2.ValueType = XL.Common.ControlValueType.Character
            Me.Label_WareID.Tag = CTag2
            Me.Label_WareID.Text = "ID"
            Me.Label_WareID.Visible = False
            '
            'Label_CustomCode
            '
            Me.Label_CustomCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.Label_CustomCode.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label_CustomCode.Location = New System.Drawing.Point(188, 16)
            Me.Label_CustomCode.Name = "Label_CustomCode"
            Me.Label_CustomCode.Size = New System.Drawing.Size(152, 21)
            Me.Label_CustomCode.TabIndex = 10003
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
            CTag3.ParentControl = Me.Label_CustomCode
            CTag3.SkipValidate = False
            CTag3.TimeButtonTextBox = Nothing
            CTag3.ToolTip = ""
            CTag3.ValueType = XL.Common.ControlValueType.Character
            Me.Label_CustomCode.Tag = CTag3
            '
            'ButtonEdit_WareCode
            '
            Me.ButtonEdit_WareCode.Location = New System.Drawing.Point(66, 16)
            Me.ButtonEdit_WareCode.Name = "ButtonEdit_WareCode"
            Me.ButtonEdit_WareCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.ButtonEdit_WareCode.Size = New System.Drawing.Size(116, 21)
            Me.ButtonEdit_WareCode.TabIndex = 10002
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
            CTag4.ParentControl = Me.ButtonEdit_WareCode
            CTag4.SkipValidate = False
            CTag4.TimeButtonTextBox = Nothing
            CTag4.ToolTip = ""
            CTag4.ValueType = XL.Common.ControlValueType.Character
            Me.ButtonEdit_WareCode.Tag = CTag4
            '
            'Label18
            '
            Me.Label18.AutoSize = True
            Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label18.Location = New System.Drawing.Point(5, 19)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(55, 15)
            Me.Label18.TabIndex = 10001
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
            CTag5.ParentControl = Me.Label18
            CTag5.SkipValidate = False
            CTag5.TimeButtonTextBox = Nothing
            CTag5.ToolTip = ""
            CTag5.ValueType = XL.Common.ControlValueType.Character
            Me.Label18.Tag = CTag5
            Me.Label18.Text = "��Ʒ����"
            '
            'TextEdit_Search
            '
            Me.TextEdit_Search.EditValue = ""
            Me.TextEdit_Search.Location = New System.Drawing.Point(559, 16)
            Me.TextEdit_Search.Name = "TextEdit_Search"
            Me.TextEdit_Search.Size = New System.Drawing.Size(184, 21)
            Me.TextEdit_Search.TabIndex = 10000
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
            CTag6.ParentControl = Me.TextEdit_Search
            CTag6.SkipValidate = False
            CTag6.TimeButtonTextBox = Nothing
            CTag6.ToolTip = ""
            CTag6.ValueType = XL.Common.ControlValueType.Character
            Me.TextEdit_Search.Tag = CTag6
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.BackColor = System.Drawing.Color.White
            Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.Label1.ForeColor = System.Drawing.Color.Black
            Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.Label1.Location = New System.Drawing.Point(511, 19)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(31, 15)
            Me.Label1.TabIndex = 10000
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
            CTag7.ParentControl = Me.Label1
            CTag7.SkipValidate = False
            CTag7.TimeButtonTextBox = Nothing
            CTag7.ToolTip = ""
            CTag7.ValueType = XL.Common.ControlValueType.Character
            Me.Label1.Tag = CTag7
            Me.Label1.Text = "����"
            '
            'XtraTabControl1
            '
            Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.XtraTabControl1.Location = New System.Drawing.Point(0, 73)
            Me.XtraTabControl1.Name = "XtraTabControl1"
            Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage_ComponentOption
            Me.XtraTabControl1.Size = New System.Drawing.Size(749, 456)
            Me.XtraTabControl1.TabIndex = 10000
            Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_ComponentOption, Me.XtraTabPage_OverView})
            Me.XtraTabControl1.TabStop = False
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
            CTag16.ParentControl = Me.XtraTabControl1
            CTag16.SkipValidate = False
            CTag16.TimeButtonTextBox = Nothing
            CTag16.ToolTip = ""
            CTag16.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabControl1.Tag = CTag16
            Me.XtraTabControl1.Text = "XtraTabControl1"
            '
            'XtraTabPage_ComponentOption
            '
            Me.XtraTabPage_ComponentOption.Controls.Add(Me.SplitContainerControl_BomSetup)
            Me.XtraTabPage_ComponentOption.Name = "XtraTabPage_ComponentOption"
            Me.XtraTabPage_ComponentOption.Size = New System.Drawing.Size(740, 424)
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
            CTag14.ParentControl = Me.XtraTabPage_ComponentOption
            CTag14.SkipValidate = False
            CTag14.TimeButtonTextBox = Nothing
            CTag14.ToolTip = ""
            CTag14.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_ComponentOption.Tag = CTag14
            Me.XtraTabPage_ComponentOption.Text = "��ǰ��Ʒ"
            '
            'SplitContainerControl_BomSetup
            '
            Me.SplitContainerControl_BomSetup.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainerControl_BomSetup.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainerControl_BomSetup.Name = "SplitContainerControl_BomSetup"
            Me.SplitContainerControl_BomSetup.Panel1.Controls.Add(Me.GroupControl1)
            Me.SplitContainerControl_BomSetup.Panel1.Text = "Panel1"
            Me.SplitContainerControl_BomSetup.Panel2.Controls.Add(Me.GroupControl2)
            Me.SplitContainerControl_BomSetup.Panel2.Text = "Panel2"
            Me.SplitContainerControl_BomSetup.Size = New System.Drawing.Size(740, 424)
            Me.SplitContainerControl_BomSetup.SplitterPosition = 220
            Me.SplitContainerControl_BomSetup.TabIndex = 10000
            Me.SplitContainerControl_BomSetup.Text = "SplitContainerControl1"
            '
            'GroupControl1
            '
            Me.GroupControl1.Controls.Add(Me.TreeList_Component)
            Me.GroupControl1.Controls.Add(Me.PanelControl1)
            Me.GroupControl1.Controls.Add(Me.ToolStrip2)
            Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
            Me.GroupControl1.Name = "GroupControl1"
            Me.GroupControl1.Size = New System.Drawing.Size(216, 420)
            Me.GroupControl1.TabIndex = 0
            Me.GroupControl1.Text = "���"
            '
            'TreeList_Component
            '
            Me.TreeList_Component.AllowDrop = True
            Me.TreeList_Component.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn_TreeIcon, Me.TreeListColumn_Component, Me.TreeListColumn_ComponentRowHighlight})
            Me.TreeList_Component.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeList_Component.KeyFieldName = "COMPONENT_ID"
            Me.TreeList_Component.Location = New System.Drawing.Point(2, 96)
            Me.TreeList_Component.Name = "TreeList_Component"
            Me.TreeList_Component.OptionsBehavior.DragNodes = True
            Me.TreeList_Component.ParentFieldName = "PARENT_COMPONENT"
            Me.TreeList_Component.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit_ComponentName, Me.RepositoryItemImageComboBox_TreeIcon})
            Me.TreeList_Component.Size = New System.Drawing.Size(212, 322)
            Me.TreeList_Component.TabIndex = 10003
            '
            'TreeListColumn_TreeIcon
            '
            Me.TreeListColumn_TreeIcon.ColumnEdit = Me.RepositoryItemImageComboBox_TreeIcon
            Me.TreeListColumn_TreeIcon.FieldName = "DSR_FT_ROW_REMARK"
            Me.TreeListColumn_TreeIcon.Name = "TreeListColumn_TreeIcon"
            Me.TreeListColumn_TreeIcon.OptionsColumn.AllowFocus = False
            Me.TreeListColumn_TreeIcon.Visible = True
            Me.TreeListColumn_TreeIcon.VisibleIndex = 0
            '
            'RepositoryItemImageComboBox_TreeIcon
            '
            Me.RepositoryItemImageComboBox_TreeIcon.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "ROOT_WARE", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "COMPONENT", 1)})
            Me.RepositoryItemImageComboBox_TreeIcon.LargeImages = Me.ImageCollection_TreeIcon
            Me.RepositoryItemImageComboBox_TreeIcon.Name = "RepositoryItemImageComboBox_TreeIcon"
            Me.RepositoryItemImageComboBox_TreeIcon.SmallImages = Me.ImageCollection_TreeIcon
            '
            'ImageCollection_TreeIcon
            '
            Me.ImageCollection_TreeIcon.ImageStream = CType(resources.GetObject("ImageCollection_TreeIcon.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
            '
            'TreeListColumn_Component
            '
            Me.TreeListColumn_Component.Caption = "���"
            Me.TreeListColumn_Component.ColumnEdit = Me.RepositoryItemTextEdit_ComponentName
            Me.TreeListColumn_Component.FieldName = "COMPONENT_NAME"
            Me.TreeListColumn_Component.Name = "TreeListColumn_Component"
            Me.TreeListColumn_Component.Visible = True
            Me.TreeListColumn_Component.VisibleIndex = 1
            Me.TreeListColumn_Component.Width = 191
            '
            'RepositoryItemTextEdit_ComponentName
            '
            Me.RepositoryItemTextEdit_ComponentName.AutoHeight = False
            Me.RepositoryItemTextEdit_ComponentName.Name = "RepositoryItemTextEdit_ComponentName"
            '
            'TreeListColumn_ComponentRowHighlight
            '
            Me.TreeListColumn_ComponentRowHighlight.Caption = "������ʾ"
            Me.TreeListColumn_ComponentRowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.TreeListColumn_ComponentRowHighlight.Name = "TreeListColumn_ComponentRowHighlight"
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(2, 46)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(212, 50)
            Me.PanelControl1.TabIndex = 10002
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
            CTag9.ParentControl = Me.PanelControl1
            CTag9.SkipValidate = False
            CTag9.TimeButtonTextBox = Nothing
            CTag9.ToolTip = ""
            CTag9.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl1.Tag = CTag9
            '
            'ToolStrip2
            '
            Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddComponent, Me.ToolStripButton_RemoveComponent, Me.ToolStripButton_RefreshComponents, Me.ToolStripButton_SaveComponents})
            Me.ToolStrip2.Location = New System.Drawing.Point(2, 21)
            Me.ToolStrip2.Name = "ToolStrip2"
            Me.ToolStrip2.Size = New System.Drawing.Size(212, 25)
            Me.ToolStrip2.TabIndex = 10001
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
            CTag10.ParentControl = Me.ToolStrip2
            CTag10.SkipValidate = False
            CTag10.TimeButtonTextBox = Nothing
            CTag10.ToolTip = ""
            CTag10.ValueType = XL.Common.ControlValueType.Character
            Me.ToolStrip2.Tag = CTag10
            '
            'ToolStripButton_AddComponent
            '
            Me.ToolStripButton_AddComponent.Name = "ToolStripButton_AddComponent"
            Me.ToolStripButton_AddComponent.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_AddComponent.Text = "���"
            '
            'ToolStripButton_RemoveComponent
            '
            Me.ToolStripButton_RemoveComponent.Name = "ToolStripButton_RemoveComponent"
            Me.ToolStripButton_RemoveComponent.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_RemoveComponent.Text = "ȥ��"
            '
            'ToolStripButton_RefreshComponents
            '
            Me.ToolStripButton_RefreshComponents.Name = "ToolStripButton_RefreshComponents"
            Me.ToolStripButton_RefreshComponents.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_RefreshComponents.Text = "ˢ��"
            '
            'ToolStripButton_SaveComponents
            '
            Me.ToolStripButton_SaveComponents.Name = "ToolStripButton_SaveComponents"
            Me.ToolStripButton_SaveComponents.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_SaveComponents.Text = "����"
            Me.ToolStripButton_SaveComponents.Visible = False
            '
            'GroupControl2
            '
            Me.GroupControl2.Controls.Add(Me.GridControl_Ware)
            Me.GroupControl2.Controls.Add(Me.PanelControl2)
            Me.GroupControl2.Controls.Add(Me.ToolStrip1)
            Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
            Me.GroupControl2.Name = "GroupControl2"
            Me.GroupControl2.Size = New System.Drawing.Size(510, 420)
            Me.GroupControl2.TabIndex = 1
            Me.GroupControl2.Text = "��Ʒѡ��"
            '
            'GridControl_Ware
            '
            Me.GridControl_Ware.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl_Ware.EmbeddedNavigator.Name = ""
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
            CTag11.ParentControl = Me.GridControl_Ware.EmbeddedNavigator
            CTag11.SkipValidate = False
            CTag11.TimeButtonTextBox = Nothing
            CTag11.ToolTip = ""
            CTag11.ValueType = XL.Common.ControlValueType.Character
            Me.GridControl_Ware.EmbeddedNavigator.Tag = CTag11
            Me.GridControl_Ware.Location = New System.Drawing.Point(2, 96)
            Me.GridControl_Ware.MainView = Me.GridView_Ware
            Me.GridControl_Ware.Name = "GridControl_Ware"
            Me.GridControl_Ware.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit_Select, Me.RepositoryItemLookUpEdit_SupplierID, Me.RepositoryItemCalcEdit_UnitPrice, Me.RepositoryItemCalcEdit_UnitCost, Me.RepositoryItemCalcEdit_MinQty, Me.RepositoryItemCalcEdit_MaxQty})
            Me.GridControl_Ware.Size = New System.Drawing.Size(506, 322)
            Me.GridControl_Ware.TabIndex = 10004
            Me.GridControl_Ware.TabStop = False
            Me.GridControl_Ware.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView_Ware})
            '
            'GridView_Ware
            '
            Me.GridView_Ware.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn_RowSelect, Me.GridColumn_WareCode, Me.GridColumn_CustomCode, Me.GridColumn_WareName, Me.GridColumn_Spec, Me.GridColumn_Model, Me.GridColumn_Attribute1, Me.GridColumn_Attribute2, Me.GridColumn_Attribute3, Me.GridColumn_Attribute4, Me.GridColumn_UnitName, Me.GridColumn_UnitPrice, Me.GridColumn_Unitcost, Me.GridColumn_SupplierID, Me.GridColumn_Remarks, Me.GridColumn_RowHighlight})
            StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Lime
            StyleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White
            StyleFormatCondition1.Appearance.Options.UseBackColor = True
            StyleFormatCondition1.ApplyToRow = True
            StyleFormatCondition1.Column = Me.GridColumn_RowHighlight
            StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
            StyleFormatCondition1.Value1 = "SEARCH_MATCH"
            Me.GridView_Ware.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
            Me.GridView_Ware.GridControl = Me.GridControl_Ware
            Me.GridView_Ware.Name = "GridView_Ware"
            Me.GridView_Ware.OptionsView.ColumnAutoWidth = False
            Me.GridView_Ware.OptionsView.ShowFooter = True
            Me.GridView_Ware.OptionsView.ShowGroupPanel = False
            '
            'GridColumn_RowSelect
            '
            Me.GridColumn_RowSelect.Caption = "ѡ��"
            Me.GridColumn_RowSelect.ColumnEdit = Me.RepositoryItemCheckEdit_Select
            Me.GridColumn_RowSelect.FieldName = "DSR_FT_ROW_SELECTED"
            Me.GridColumn_RowSelect.Name = "GridColumn_RowSelect"
            Me.GridColumn_RowSelect.Visible = True
            Me.GridColumn_RowSelect.VisibleIndex = 0
            '
            'RepositoryItemCheckEdit_Select
            '
            Me.RepositoryItemCheckEdit_Select.AutoHeight = False
            Me.RepositoryItemCheckEdit_Select.Name = "RepositoryItemCheckEdit_Select"
            '
            'GridColumn_WareCode
            '
            Me.GridColumn_WareCode.Caption = "��Ʒ����"
            Me.GridColumn_WareCode.FieldName = "WARE_CODE"
            Me.GridColumn_WareCode.Name = "GridColumn_WareCode"
            Me.GridColumn_WareCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareCode.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
            Me.GridColumn_WareCode.Visible = True
            Me.GridColumn_WareCode.VisibleIndex = 1
            '
            'GridColumn_CustomCode
            '
            Me.GridColumn_CustomCode.Caption = "�Զ�����"
            Me.GridColumn_CustomCode.FieldName = "CUSTOM_CODE"
            Me.GridColumn_CustomCode.Name = "GridColumn_CustomCode"
            Me.GridColumn_CustomCode.OptionsColumn.AllowFocus = False
            Me.GridColumn_CustomCode.Visible = True
            Me.GridColumn_CustomCode.VisibleIndex = 2
            '
            'RepositoryItemCalcEdit_MaxQty
            '
            Me.RepositoryItemCalcEdit_MaxQty.AutoHeight = False
            Me.RepositoryItemCalcEdit_MaxQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_MaxQty.Name = "RepositoryItemCalcEdit_MaxQty"
            '
            'RepositoryItemCalcEdit_MinQty
            '
            Me.RepositoryItemCalcEdit_MinQty.AutoHeight = False
            Me.RepositoryItemCalcEdit_MinQty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_MinQty.Name = "RepositoryItemCalcEdit_MinQty"
            '
            'GridColumn_WareName
            '
            Me.GridColumn_WareName.Caption = "��Ʒ����"
            Me.GridColumn_WareName.FieldName = "WARE_NAME"
            Me.GridColumn_WareName.Name = "GridColumn_WareName"
            Me.GridColumn_WareName.OptionsColumn.AllowFocus = False
            Me.GridColumn_WareName.Visible = True
            Me.GridColumn_WareName.VisibleIndex = 3
            '
            'GridColumn_Spec
            '
            Me.GridColumn_Spec.Caption = "��Ʒ���"
            Me.GridColumn_Spec.FieldName = "SPEC"
            Me.GridColumn_Spec.Name = "GridColumn_Spec"
            Me.GridColumn_Spec.OptionsColumn.AllowFocus = False
            Me.GridColumn_Spec.Visible = True
            Me.GridColumn_Spec.VisibleIndex = 4
            '
            'GridColumn_Model
            '
            Me.GridColumn_Model.Caption = "��Ʒ�ͺ�"
            Me.GridColumn_Model.FieldName = "MODEL"
            Me.GridColumn_Model.Name = "GridColumn_Model"
            Me.GridColumn_Model.OptionsColumn.AllowFocus = False
            Me.GridColumn_Model.Visible = True
            Me.GridColumn_Model.VisibleIndex = 5
            '
            'GridColumn_Attribute1
            '
            Me.GridColumn_Attribute1.Caption = "����1"
            Me.GridColumn_Attribute1.FieldName = "ATTRIBUTE1"
            Me.GridColumn_Attribute1.Name = "GridColumn_Attribute1"
            Me.GridColumn_Attribute1.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute1.Visible = True
            Me.GridColumn_Attribute1.VisibleIndex = 6
            '
            'GridColumn_Attribute2
            '
            Me.GridColumn_Attribute2.Caption = "����2"
            Me.GridColumn_Attribute2.FieldName = "ATTRIBUTE2"
            Me.GridColumn_Attribute2.Name = "GridColumn_Attribute2"
            Me.GridColumn_Attribute2.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute2.Visible = True
            Me.GridColumn_Attribute2.VisibleIndex = 7
            '
            'GridColumn_Attribute3
            '
            Me.GridColumn_Attribute3.Caption = "����3"
            Me.GridColumn_Attribute3.FieldName = "ATTRIBUTE3"
            Me.GridColumn_Attribute3.Name = "GridColumn_Attribute3"
            Me.GridColumn_Attribute3.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute3.Visible = True
            Me.GridColumn_Attribute3.VisibleIndex = 8
            '
            'GridColumn_Attribute4
            '
            Me.GridColumn_Attribute4.Caption = "����4"
            Me.GridColumn_Attribute4.FieldName = "ATTRIBUTE4"
            Me.GridColumn_Attribute4.Name = "GridColumn_Attribute4"
            Me.GridColumn_Attribute4.OptionsColumn.AllowFocus = False
            Me.GridColumn_Attribute4.Visible = True
            Me.GridColumn_Attribute4.VisibleIndex = 9
            '
            'GridColumn_UnitName
            '
            Me.GridColumn_UnitName.Caption = "��λ"
            Me.GridColumn_UnitName.FieldName = "UNIT_NAME"
            Me.GridColumn_UnitName.Name = "GridColumn_UnitName"
            Me.GridColumn_UnitName.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitName.Visible = True
            Me.GridColumn_UnitName.VisibleIndex = 10
            '
            'GridColumn_UnitPrice
            '
            Me.GridColumn_UnitPrice.Caption = "����"
            Me.GridColumn_UnitPrice.ColumnEdit = Me.RepositoryItemCalcEdit_UnitPrice
            Me.GridColumn_UnitPrice.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_UnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_UnitPrice.FieldName = "UNIT_PRICE"
            Me.GridColumn_UnitPrice.Name = "GridColumn_UnitPrice"
            Me.GridColumn_UnitPrice.OptionsColumn.AllowFocus = False
            Me.GridColumn_UnitPrice.Visible = True
            Me.GridColumn_UnitPrice.VisibleIndex = 11
            '
            'RepositoryItemCalcEdit_UnitPrice
            '
            Me.RepositoryItemCalcEdit_UnitPrice.AutoHeight = False
            Me.RepositoryItemCalcEdit_UnitPrice.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_UnitPrice.Name = "RepositoryItemCalcEdit_UnitPrice"
            '
            'GridColumn_Unitcost
            '
            Me.GridColumn_Unitcost.Caption = "�ɱ�"
            Me.GridColumn_Unitcost.ColumnEdit = Me.RepositoryItemCalcEdit_UnitCost
            Me.GridColumn_Unitcost.DisplayFormat.FormatString = "{0:#,##0.00}"
            Me.GridColumn_Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.GridColumn_Unitcost.FieldName = "UNIT_COST"
            Me.GridColumn_Unitcost.Name = "GridColumn_Unitcost"
            Me.GridColumn_Unitcost.OptionsColumn.AllowFocus = False
            Me.GridColumn_Unitcost.Visible = True
            Me.GridColumn_Unitcost.VisibleIndex = 12
            '
            'RepositoryItemCalcEdit_UnitCost
            '
            Me.RepositoryItemCalcEdit_UnitCost.AutoHeight = False
            Me.RepositoryItemCalcEdit_UnitCost.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemCalcEdit_UnitCost.Name = "RepositoryItemCalcEdit_UnitCost"
            '
            'GridColumn_SupplierID
            '
            Me.GridColumn_SupplierID.Caption = "��Ӧ������"
            Me.GridColumn_SupplierID.ColumnEdit = Me.RepositoryItemLookUpEdit_SupplierID
            Me.GridColumn_SupplierID.FieldName = "SUPPLIER_ID"
            Me.GridColumn_SupplierID.Name = "GridColumn_SupplierID"
            Me.GridColumn_SupplierID.OptionsColumn.AllowFocus = False
            Me.GridColumn_SupplierID.Visible = True
            Me.GridColumn_SupplierID.VisibleIndex = 13
            '
            'RepositoryItemLookUpEdit_SupplierID
            '
            Me.RepositoryItemLookUpEdit_SupplierID.AutoHeight = False
            Me.RepositoryItemLookUpEdit_SupplierID.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.RepositoryItemLookUpEdit_SupplierID.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SUPPLIER_NAME", "Name1", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
            Me.RepositoryItemLookUpEdit_SupplierID.DisplayMember = "SUPPLIER_NAME"
            Me.RepositoryItemLookUpEdit_SupplierID.Name = "RepositoryItemLookUpEdit_SupplierID"
            Me.RepositoryItemLookUpEdit_SupplierID.NullText = ""
            Me.RepositoryItemLookUpEdit_SupplierID.ValueMember = "SUPPLIER_ID"
            '
            'GridColumn_Remarks
            '
            Me.GridColumn_Remarks.Caption = "��ע"
            Me.GridColumn_Remarks.FieldName = "REMARK"
            Me.GridColumn_Remarks.Name = "GridColumn_Remarks"
            Me.GridColumn_Remarks.OptionsColumn.AllowFocus = False
            Me.GridColumn_Remarks.Visible = True
            Me.GridColumn_Remarks.VisibleIndex = 14
            '
            'GridColumn_RowHighlight
            '
            Me.GridColumn_RowHighlight.Caption = "������ʾ"
            Me.GridColumn_RowHighlight.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.GridColumn_RowHighlight.Name = "GridColumn_RowHighlight"
            Me.GridColumn_RowHighlight.OptionsColumn.AllowFocus = False
            '
            'PanelControl2
            '
            Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl2.Appearance.Options.UseBackColor = True
            Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl2.Location = New System.Drawing.Point(2, 46)
            Me.PanelControl2.Name = "PanelControl2"
            Me.PanelControl2.Size = New System.Drawing.Size(506, 50)
            Me.PanelControl2.TabIndex = 10003
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
            CTag12.ParentControl = Me.PanelControl2
            CTag12.SkipValidate = False
            CTag12.TimeButtonTextBox = Nothing
            CTag12.ToolTip = ""
            CTag12.ValueType = XL.Common.ControlValueType.Character
            Me.PanelControl2.Tag = CTag12
            '
            'ToolStrip1
            '
            Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton_AddOptions, Me.ToolStripButton_RemoveOptions, Me.ToolStripButton_RefreshOptions, Me.ToolStripButton_SaveOptions})
            Me.ToolStrip1.Location = New System.Drawing.Point(2, 21)
            Me.ToolStrip1.Name = "ToolStrip1"
            Me.ToolStrip1.Size = New System.Drawing.Size(506, 25)
            Me.ToolStrip1.TabIndex = 10001
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
            CTag13.ParentControl = Me.ToolStrip1
            CTag13.SkipValidate = False
            CTag13.TimeButtonTextBox = Nothing
            CTag13.ToolTip = ""
            CTag13.ValueType = XL.Common.ControlValueType.Character
            Me.ToolStrip1.Tag = CTag13
            '
            'ToolStripButton_AddOptions
            '
            Me.ToolStripButton_AddOptions.Name = "ToolStripButton_AddOptions"
            Me.ToolStripButton_AddOptions.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_AddOptions.Text = "���"
            '
            'ToolStripButton_RemoveOptions
            '
            Me.ToolStripButton_RemoveOptions.Name = "ToolStripButton_RemoveOptions"
            Me.ToolStripButton_RemoveOptions.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_RemoveOptions.Text = "ȥ��"
            '
            'ToolStripButton_RefreshOptions
            '
            Me.ToolStripButton_RefreshOptions.Name = "ToolStripButton_RefreshOptions"
            Me.ToolStripButton_RefreshOptions.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_RefreshOptions.Text = "ˢ��"
            '
            'ToolStripButton_SaveOptions
            '
            Me.ToolStripButton_SaveOptions.Name = "ToolStripButton_SaveOptions"
            Me.ToolStripButton_SaveOptions.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_SaveOptions.Text = "����"
            Me.ToolStripButton_SaveOptions.Visible = False
            '
            'XtraTabPage_OverView
            '
            Me.XtraTabPage_OverView.Controls.Add(Me.TreeList_OverViewList)
            Me.XtraTabPage_OverView.Name = "XtraTabPage_OverView"
            Me.XtraTabPage_OverView.Size = New System.Drawing.Size(740, 424)
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
            CTag15.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            CTag15.IsButtonCustomed = False
            CTag15.IsTextValid = True
            CTag15.KeyValueAbsentable = False
            CTag15.LeagleText = ""
            CTag15.NumericButtonTextBox = Nothing
            CTag15.ParentControl = Me.XtraTabPage_OverView
            CTag15.SkipValidate = False
            CTag15.TimeButtonTextBox = Nothing
            CTag15.ToolTip = ""
            CTag15.ValueType = XL.Common.ControlValueType.Character
            Me.XtraTabPage_OverView.Tag = CTag15
            Me.XtraTabPage_OverView.Text = "��֯�ṹ"
            '
            'TreeList_OverViewList
            '
            Me.TreeList_OverViewList.AllowDrop = True
            Me.TreeList_OverViewList.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.TreeListColumn1, Me.TreeListColumn2, Me.TreeListColumn3})
            Me.TreeList_OverViewList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TreeList_OverViewList.KeyFieldName = "COMPONENT_ID"
            Me.TreeList_OverViewList.Location = New System.Drawing.Point(0, 0)
            Me.TreeList_OverViewList.Name = "TreeList_OverViewList"
            Me.TreeList_OverViewList.OptionsBehavior.DragNodes = True
            Me.TreeList_OverViewList.OptionsView.AutoWidth = False
            Me.TreeList_OverViewList.ParentFieldName = "PARENT_COMPONENT"
            Me.TreeList_OverViewList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemImageComboBox1})
            Me.TreeList_OverViewList.Size = New System.Drawing.Size(740, 424)
            Me.TreeList_OverViewList.TabIndex = 10004
            '
            'TreeListColumn1
            '
            Me.TreeListColumn1.ColumnEdit = Me.RepositoryItemImageComboBox1
            Me.TreeListColumn1.FieldName = "DSR_FT_ROW_REMARK"
            Me.TreeListColumn1.Name = "TreeListColumn1"
            Me.TreeListColumn1.OptionsColumn.AllowFocus = False
            Me.TreeListColumn1.Visible = True
            Me.TreeListColumn1.VisibleIndex = 0
            Me.TreeListColumn1.Width = 114
            '
            'RepositoryItemImageComboBox1
            '
            Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "ROOT_WARE", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "COMPONENT", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("", "OPTION", 2)})
            Me.RepositoryItemImageComboBox1.LargeImages = Me.ImageCollection_TreeIcon
            Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
            Me.RepositoryItemImageComboBox1.SmallImages = Me.ImageCollection_TreeIcon
            '
            'TreeListColumn2
            '
            Me.TreeListColumn2.Caption = "���"
            Me.TreeListColumn2.ColumnEdit = Me.RepositoryItemTextEdit1
            Me.TreeListColumn2.FieldName = "COMPONENT_NAME"
            Me.TreeListColumn2.Name = "TreeListColumn2"
            Me.TreeListColumn2.OptionsColumn.AllowFocus = False
            Me.TreeListColumn2.Visible = True
            Me.TreeListColumn2.VisibleIndex = 1
            Me.TreeListColumn2.Width = 646
            '
            'RepositoryItemTextEdit1
            '
            Me.RepositoryItemTextEdit1.AutoHeight = False
            Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
            '
            'TreeListColumn3
            '
            Me.TreeListColumn3.Caption = "������ʾ"
            Me.TreeListColumn3.FieldName = "DSR_FT_ROW_HIGHLIGHT"
            Me.TreeListColumn3.Name = "TreeListColumn3"
            '
            'ToolStripButton_Choose
            '
            Me.ToolStripButton_Choose.Name = "ToolStripButton_Choose"
            Me.ToolStripButton_Choose.Size = New System.Drawing.Size(36, 22)
            Me.ToolStripButton_Choose.Text = "ѡ��"
            Me.ToolStripButton_Choose.Visible = False
            '
            'M_01_00206
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.Controls.Add(Me.XtraTabControl1)
            Me.Controls.Add(Me.PanelControl_Filter)
            Me.Controls.Add(Me.ToolStrip_Form)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Font = New System.Drawing.Font("Arial", 9.0!)
            Me.FormStatus = XL.Win.Component.BaseForm.FormStatuses.Loading_IA_AfterFormLoaded
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "M_01_00206"
            Me.Size = New System.Drawing.Size(749, 529)
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
            CTag17.ParentControl = Me
            CTag17.SkipValidate = False
            CTag17.TimeButtonTextBox = Nothing
            CTag17.ToolTip = ""
            CTag17.ValueType = XL.Common.ControlValueType.Character
            Me.Tag = CTag17
            Me.ToolStrip_Form.ResumeLayout(False)
            Me.ToolStrip_Form.PerformLayout()
            CType(Me.PanelControl_Filter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl_Filter.ResumeLayout(False)
            Me.PanelControl_Filter.PerformLayout()
            CType(Me.ButtonEdit_WareCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit_Search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.XtraTabControl1.ResumeLayout(False)
            Me.XtraTabPage_ComponentOption.ResumeLayout(False)
            CType(Me.SplitContainerControl_BomSetup, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerControl_BomSetup.ResumeLayout(False)
            CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl1.ResumeLayout(False)
            Me.GroupControl1.PerformLayout()
            CType(Me.TreeList_Component, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemImageComboBox_TreeIcon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ImageCollection_TreeIcon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit_ComponentName, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolStrip2.ResumeLayout(False)
            Me.ToolStrip2.PerformLayout()
            CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupControl2.ResumeLayout(False)
            Me.GroupControl2.PerformLayout()
            CType(Me.GridControl_Ware, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView_Ware, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCheckEdit_Select, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_MaxQty, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_MinQty, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemCalcEdit_UnitCost, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemLookUpEdit_SupplierID, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ToolStrip1.ResumeLayout(False)
            Me.ToolStrip1.PerformLayout()
            Me.XtraTabPage_OverView.ResumeLayout(False)
            CType(Me.TreeList_OverViewList, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents PanelControl_Filter As DevExpress.XtraEditors.PanelControl
        Friend WithEvents TextEdit_Search As DevExpress.XtraEditors.TextEdit
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents SplitContainerControl_BomSetup As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
        Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Friend WithEvents XtraTabPage_ComponentOption As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents XtraTabPage_OverView As DevExpress.XtraTab.XtraTabPage
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton_SaveComponents As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_AddComponent As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_RemoveComponent As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_RefreshComponents As System.Windows.Forms.ToolStripButton
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
        Friend WithEvents ToolStripButton_SaveOptions As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_AddOptions As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_RemoveOptions As System.Windows.Forms.ToolStripButton
        Friend WithEvents ToolStripButton_RefreshOptions As System.Windows.Forms.ToolStripButton
        Friend WithEvents GridControl_Ware As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView_Ware As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents GridColumn_RowSelect As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCheckEdit_Select As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
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
        Friend WithEvents RepositoryItemCalcEdit_UnitPrice As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_Unitcost As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemCalcEdit_UnitCost As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents GridColumn_SupplierID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents RepositoryItemLookUpEdit_SupplierID As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Friend WithEvents GridColumn_Remarks As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents GridColumn_RowHighlight As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Label_WareID As System.Windows.Forms.Label
        Friend WithEvents Label_CustomCode As System.Windows.Forms.Label
        Friend WithEvents ButtonEdit_WareCode As DevExpress.XtraEditors.ButtonEdit
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents TreeList_Component As DevExpress.XtraTreeList.TreeList
        Friend WithEvents TreeListColumn_Component As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents TreeListColumn_ComponentRowHighlight As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemTextEdit_ComponentName As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents TreeListColumn_TreeIcon As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemImageComboBox_TreeIcon As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Friend WithEvents ImageCollection_TreeIcon As DevExpress.Utils.ImageCollection
        Friend WithEvents RepositoryItemCalcEdit_MinQty As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents RepositoryItemCalcEdit_MaxQty As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit
        Friend WithEvents TreeList_OverViewList As DevExpress.XtraTreeList.TreeList
        Friend WithEvents TreeListColumn1 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
        Friend WithEvents TreeListColumn2 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Friend WithEvents TreeListColumn3 As DevExpress.XtraTreeList.Columns.TreeListColumn
        Friend WithEvents ToolStripButton_Choose As System.Windows.Forms.ToolStripButton

#End Region

    End Class

End Namespace

