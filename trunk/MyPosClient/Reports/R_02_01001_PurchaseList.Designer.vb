﻿Namespace Reports


    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Public Class R_02_01001_PurchaseList
        Inherits DevExpress.XtraReports.UI.XtraReport

        'XtraReport overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Designer
        'It can be modified using the Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
            Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
            Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
            Me.XrLabel_Title = New DevExpress.XtraReports.UI.XRLabel
            Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
            Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
            Me.XrTableCell_BatchCode = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_WareCode = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_CustomCode = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_WareName = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_TurnoverBookStatus = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_Attribute1 = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_WareAmount = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_UnitPrice = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_SumPrice = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_UnitDiscount = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_SumDiscount = New DevExpress.XtraReports.UI.XRTableCell
            Me.XrTableCell_CurrentAmount = New DevExpress.XtraReports.UI.XRTableCell
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
            Me.Detail.Height = 25
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'PageHeader
            '
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
            Me.PageHeader.Height = 25
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'XrTable1
            '
            Me.XrTable1.Font = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTable1.Location = New System.Drawing.Point(0, 0)
            Me.XrTable1.Name = "XrTable1"
            Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
            Me.XrTable1.Size = New System.Drawing.Size(758, 25)
            Me.XrTable1.StylePriority.UseFont = False
            Me.XrTable1.StylePriority.UseTextAlignment = False
            Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrTableRow1
            '
            Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell7, Me.XrTableCell4, Me.XrTableCell8, Me.XrTableCell1, Me.XrTableCell9, Me.XrTableCell5, Me.XrTableCell10, Me.XrTableCell2, Me.XrTableCell11, Me.XrTableCell6, Me.XrTableCell12, Me.XrTableCell3})
            Me.XrTableRow1.Name = "XrTableRow1"
            Me.XrTableRow1.Size = New System.Drawing.Size(758, 25)
            '
            'XrTableCell4
            '
            Me.XrTableCell4.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell4.Location = New System.Drawing.Point(62, 0)
            Me.XrTableCell4.Name = "XrTableCell4"
            Me.XrTableCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell4.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell4.StylePriority.UseBorders = False
            Me.XrTableCell4.Text = "货品代码"
            '
            'XrTableCell1
            '
            Me.XrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell1.Location = New System.Drawing.Point(188, 0)
            Me.XrTableCell1.Name = "XrTableCell1"
            Me.XrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell1.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell1.StylePriority.UseBorders = False
            Me.XrTableCell1.Text = "货品名称"
            '
            'XrTableCell5
            '
            Me.XrTableCell5.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell5.Location = New System.Drawing.Point(313, 0)
            Me.XrTableCell5.Name = "XrTableCell5"
            Me.XrTableCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell5.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell5.StylePriority.UseBorders = False
            Me.XrTableCell5.Text = "属性1 "
            '
            'XrTableCell2
            '
            Me.XrTableCell2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell2.Location = New System.Drawing.Point(439, 0)
            Me.XrTableCell2.Name = "XrTableCell2"
            Me.XrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell2.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell2.StylePriority.UseBorders = False
            Me.XrTableCell2.Text = "单价"
            '
            'XrTableCell6
            '
            Me.XrTableCell6.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell6.Location = New System.Drawing.Point(566, 0)
            Me.XrTableCell6.Name = "XrTableCell6"
            Me.XrTableCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell6.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell6.StylePriority.UseBorders = False
            Me.XrTableCell6.Text = "单件折扣"
            '
            'XrTableCell3
            '
            Me.XrTableCell3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell3.Location = New System.Drawing.Point(694, 0)
            Me.XrTableCell3.Name = "XrTableCell3"
            Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell3.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell3.StylePriority.UseBorders = False
            Me.XrTableCell3.Text = "当前在库数量"
            '
            'PageFooter
            '
            Me.PageFooter.Height = 30
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'ReportHeader
            '
            Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel_Title})
            Me.ReportHeader.Height = 79
            Me.ReportHeader.Name = "ReportHeader"
            '
            'XrLabel_Title
            '
            Me.XrLabel_Title.Font = New System.Drawing.Font("Arial Black", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XrLabel_Title.Location = New System.Drawing.Point(258, 17)
            Me.XrLabel_Title.Name = "XrLabel_Title"
            Me.XrLabel_Title.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrLabel_Title.Size = New System.Drawing.Size(192, 50)
            Me.XrLabel_Title.Text = "零售物品报表"
            Me.XrLabel_Title.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrTableCell7
            '
            Me.XrTableCell7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                        Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell7.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell7.Name = "XrTableCell7"
            Me.XrTableCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell7.Size = New System.Drawing.Size(62, 25)
            Me.XrTableCell7.StylePriority.UseBorders = False
            Me.XrTableCell7.Text = "批号 "
            '
            'XrTableCell8
            '
            Me.XrTableCell8.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell8.Location = New System.Drawing.Point(125, 0)
            Me.XrTableCell8.Name = "XrTableCell8"
            Me.XrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell8.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell8.StylePriority.UseBorders = False
            Me.XrTableCell8.Text = "自定货号"
            '
            'XrTableCell9
            '
            Me.XrTableCell9.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell9.Location = New System.Drawing.Point(251, 0)
            Me.XrTableCell9.Name = "XrTableCell9"
            Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell9.Size = New System.Drawing.Size(62, 25)
            Me.XrTableCell9.StylePriority.UseBorders = False
            Me.XrTableCell9.Text = "订货状态"
            '
            'XrTableCell10
            '
            Me.XrTableCell10.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell10.Location = New System.Drawing.Point(376, 0)
            Me.XrTableCell10.Name = "XrTableCell10"
            Me.XrTableCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell10.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell10.StylePriority.UseBorders = False
            Me.XrTableCell10.Text = "数量"
            '
            'XrTableCell11
            '
            Me.XrTableCell11.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell11.Location = New System.Drawing.Point(502, 0)
            Me.XrTableCell11.Name = "XrTableCell11"
            Me.XrTableCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell11.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell11.StylePriority.UseBorders = False
            Me.XrTableCell11.Text = "小计"
            '
            'XrTableCell12
            '
            Me.XrTableCell12.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell12.Location = New System.Drawing.Point(630, 0)
            Me.XrTableCell12.Name = "XrTableCell12"
            Me.XrTableCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell12.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell12.StylePriority.UseBorders = False
            Me.XrTableCell12.Text = "折扣小计"
            '
            'XrTable2
            '
            Me.XrTable2.Font = New System.Drawing.Font("黑体", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTable2.Location = New System.Drawing.Point(0, 0)
            Me.XrTable2.Name = "XrTable2"
            Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
            Me.XrTable2.Size = New System.Drawing.Size(758, 25)
            Me.XrTable2.StylePriority.UseFont = False
            Me.XrTable2.StylePriority.UseTextAlignment = False
            Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            '
            'XrTableRow2
            '
            Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell_BatchCode, Me.XrTableCell_WareCode, Me.XrTableCell_CustomCode, Me.XrTableCell_WareName, Me.XrTableCell_TurnoverBookStatus, Me.XrTableCell_Attribute1, Me.XrTableCell_WareAmount, Me.XrTableCell_UnitPrice, Me.XrTableCell_SumPrice, Me.XrTableCell_UnitDiscount, Me.XrTableCell_SumDiscount, Me.XrTableCell_CurrentAmount})
            Me.XrTableRow2.Name = "XrTableRow2"
            Me.XrTableRow2.Size = New System.Drawing.Size(758, 25)
            '
            'XrTableCell_BatchCode
            '
            Me.XrTableCell_BatchCode.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                        Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_BatchCode.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_BatchCode.Location = New System.Drawing.Point(0, 0)
            Me.XrTableCell_BatchCode.Name = "XrTableCell_BatchCode"
            Me.XrTableCell_BatchCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_BatchCode.Size = New System.Drawing.Size(62, 25)
            Me.XrTableCell_BatchCode.StylePriority.UseBorders = False
            Me.XrTableCell_BatchCode.StylePriority.UseFont = False
            Me.XrTableCell_BatchCode.StylePriority.UseTextAlignment = False
            Me.XrTableCell_BatchCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_WareCode
            '
            Me.XrTableCell_WareCode.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_WareCode.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_WareCode.Location = New System.Drawing.Point(62, 0)
            Me.XrTableCell_WareCode.Name = "XrTableCell_WareCode"
            Me.XrTableCell_WareCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_WareCode.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell_WareCode.StylePriority.UseBorders = False
            Me.XrTableCell_WareCode.StylePriority.UseFont = False
            Me.XrTableCell_WareCode.StylePriority.UseTextAlignment = False
            Me.XrTableCell_WareCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_CustomCode
            '
            Me.XrTableCell_CustomCode.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_CustomCode.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_CustomCode.Location = New System.Drawing.Point(125, 0)
            Me.XrTableCell_CustomCode.Name = "XrTableCell_CustomCode"
            Me.XrTableCell_CustomCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_CustomCode.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell_CustomCode.StylePriority.UseBorders = False
            Me.XrTableCell_CustomCode.StylePriority.UseFont = False
            Me.XrTableCell_CustomCode.StylePriority.UseTextAlignment = False
            Me.XrTableCell_CustomCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_WareName
            '
            Me.XrTableCell_WareName.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_WareName.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_WareName.Location = New System.Drawing.Point(188, 0)
            Me.XrTableCell_WareName.Name = "XrTableCell_WareName"
            Me.XrTableCell_WareName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_WareName.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell_WareName.StylePriority.UseBorders = False
            Me.XrTableCell_WareName.StylePriority.UseFont = False
            Me.XrTableCell_WareName.StylePriority.UseTextAlignment = False
            Me.XrTableCell_WareName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_TurnoverBookStatus
            '
            Me.XrTableCell_TurnoverBookStatus.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_TurnoverBookStatus.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_TurnoverBookStatus.Location = New System.Drawing.Point(251, 0)
            Me.XrTableCell_TurnoverBookStatus.Name = "XrTableCell_TurnoverBookStatus"
            Me.XrTableCell_TurnoverBookStatus.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_TurnoverBookStatus.Size = New System.Drawing.Size(62, 25)
            Me.XrTableCell_TurnoverBookStatus.StylePriority.UseBorders = False
            Me.XrTableCell_TurnoverBookStatus.StylePriority.UseFont = False
            Me.XrTableCell_TurnoverBookStatus.StylePriority.UseTextAlignment = False
            Me.XrTableCell_TurnoverBookStatus.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_Attribute1
            '
            Me.XrTableCell_Attribute1.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_Attribute1.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_Attribute1.Location = New System.Drawing.Point(313, 0)
            Me.XrTableCell_Attribute1.Name = "XrTableCell_Attribute1"
            Me.XrTableCell_Attribute1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_Attribute1.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell_Attribute1.StylePriority.UseBorders = False
            Me.XrTableCell_Attribute1.StylePriority.UseFont = False
            Me.XrTableCell_Attribute1.StylePriority.UseTextAlignment = False
            Me.XrTableCell_Attribute1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_WareAmount
            '
            Me.XrTableCell_WareAmount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_WareAmount.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_WareAmount.Location = New System.Drawing.Point(376, 0)
            Me.XrTableCell_WareAmount.Name = "XrTableCell_WareAmount"
            Me.XrTableCell_WareAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_WareAmount.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell_WareAmount.StylePriority.UseBorders = False
            Me.XrTableCell_WareAmount.StylePriority.UseFont = False
            Me.XrTableCell_WareAmount.StylePriority.UseTextAlignment = False
            Me.XrTableCell_WareAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_UnitPrice
            '
            Me.XrTableCell_UnitPrice.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_UnitPrice.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_UnitPrice.Location = New System.Drawing.Point(439, 0)
            Me.XrTableCell_UnitPrice.Name = "XrTableCell_UnitPrice"
            Me.XrTableCell_UnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_UnitPrice.Size = New System.Drawing.Size(63, 25)
            Me.XrTableCell_UnitPrice.StylePriority.UseBorders = False
            Me.XrTableCell_UnitPrice.StylePriority.UseFont = False
            Me.XrTableCell_UnitPrice.StylePriority.UseTextAlignment = False
            Me.XrTableCell_UnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_SumPrice
            '
            Me.XrTableCell_SumPrice.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_SumPrice.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_SumPrice.Location = New System.Drawing.Point(502, 0)
            Me.XrTableCell_SumPrice.Name = "XrTableCell_SumPrice"
            Me.XrTableCell_SumPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_SumPrice.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell_SumPrice.StylePriority.UseBorders = False
            Me.XrTableCell_SumPrice.StylePriority.UseFont = False
            Me.XrTableCell_SumPrice.StylePriority.UseTextAlignment = False
            Me.XrTableCell_SumPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_UnitDiscount
            '
            Me.XrTableCell_UnitDiscount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_UnitDiscount.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_UnitDiscount.Location = New System.Drawing.Point(566, 0)
            Me.XrTableCell_UnitDiscount.Name = "XrTableCell_UnitDiscount"
            Me.XrTableCell_UnitDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_UnitDiscount.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell_UnitDiscount.StylePriority.UseBorders = False
            Me.XrTableCell_UnitDiscount.StylePriority.UseFont = False
            Me.XrTableCell_UnitDiscount.StylePriority.UseTextAlignment = False
            Me.XrTableCell_UnitDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_SumDiscount
            '
            Me.XrTableCell_SumDiscount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_SumDiscount.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_SumDiscount.Location = New System.Drawing.Point(630, 0)
            Me.XrTableCell_SumDiscount.Name = "XrTableCell_SumDiscount"
            Me.XrTableCell_SumDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_SumDiscount.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell_SumDiscount.StylePriority.UseBorders = False
            Me.XrTableCell_SumDiscount.StylePriority.UseFont = False
            Me.XrTableCell_SumDiscount.StylePriority.UseTextAlignment = False
            Me.XrTableCell_SumDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'XrTableCell_CurrentAmount
            '
            Me.XrTableCell_CurrentAmount.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
            Me.XrTableCell_CurrentAmount.Font = New System.Drawing.Font("宋体", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.XrTableCell_CurrentAmount.Location = New System.Drawing.Point(694, 0)
            Me.XrTableCell_CurrentAmount.Name = "XrTableCell_CurrentAmount"
            Me.XrTableCell_CurrentAmount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
            Me.XrTableCell_CurrentAmount.Size = New System.Drawing.Size(64, 25)
            Me.XrTableCell_CurrentAmount.StylePriority.UseBorders = False
            Me.XrTableCell_CurrentAmount.StylePriority.UseFont = False
            Me.XrTableCell_CurrentAmount.StylePriority.UseTextAlignment = False
            Me.XrTableCell_CurrentAmount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            '
            'R_02_01001_PurchaseList
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader})
            Me.Margins = New System.Drawing.Printing.Margins(70, 16, 70, 70)
            Me.Version = "8.1"
            CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
        Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
        Friend WithEvents XrLabel_Title As DevExpress.XtraReports.UI.XRLabel
        Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
        Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Friend WithEvents XrTableCell_BatchCode As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_WareCode As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_CustomCode As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_WareName As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_TurnoverBookStatus As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_Attribute1 As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_WareAmount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_UnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_SumPrice As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_UnitDiscount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_SumDiscount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell_CurrentAmount As DevExpress.XtraReports.UI.XRTableCell
        Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    End Class
End Namespace
