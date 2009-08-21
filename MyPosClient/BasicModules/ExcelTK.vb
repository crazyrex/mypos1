Imports System.Reflection
Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports MyPosXAuto.Facade
Imports Microsoft.Office.Interop


Namespace Utils
    Public Class ExcelTK

        Private _openExcel As New Excel.Application
        Private _openBook As Excel.Workbook
        Private _openSheet As Excel.Worksheet
        Private _opRange As Excel.Range
        Private _fileName As String
        Private _sheetsCount As Integer = 0


        Public Enum BorderPart
            Left = 1
            Right = 2
            Top = 4
            Bottom = 8
            Vertical = 16
            Horizonal = 32
        End Enum


        Public Sub New(Optional ByVal fileName As String = "")

            Me._openExcel = CType(CreateObject("Excel.Application"), Excel.Application)
            Me._openBook = CType(_openExcel.Workbooks.Add, Excel.Workbook)
            Me._openSheet = CType(_openBook.Worksheets(1), Excel.Worksheet)
            Me._fileName = fileName

        End Sub

        Public Sub Open(ByVal fileName As String)

            Me._openExcel.Workbooks.Open(fileName)
            Me._fileName = fileName

        End Sub

        Public Sub ClearRegion(ByVal startRow As Integer, ByVal startColumn As Integer, ByVal endRow As Integer, ByVal endColumn As Integer)
            If startRow > endRow OrElse startColumn > endColumn Then
                Return
            End If
            Me._opRange = Me._openExcel.Range(Me._openExcel.Cells(startRow, startColumn), Me._openExcel.Cells(endRow, endColumn))
            Me._opRange.ClearContents()
        End Sub

        Public Sub InsertRow(ByVal rowCounter As Integer)
            Me._opRange = CType(Me._openExcel.Rows(rowCounter), Excel.Range)
            Me._opRange.Insert(Excel.XlInsertShiftDirection.xlShiftDown)
        End Sub

        Public Sub MergeCell(ByVal startRow As Integer, ByVal startColumn As Integer, ByVal endRow As Integer, ByVal endColumn As Integer)

            If startRow > endRow OrElse startColumn > endColumn Then
                Return
            End If
            Me._opRange = Me._openExcel.Range(Me._openExcel.Cells(startRow, startColumn), Me._openExcel.Cells(endRow, endColumn))
            Me._opRange.Merge()

        End Sub

        Public Sub SetRowHeight(ByVal rowCounter As Integer, ByVal rowHight As Double)
            Me._opRange = CType(Me._openExcel.Rows(rowCounter), Excel.Range)
            Me._opRange.RowHeight = rowHight

        End Sub

        Public Sub SetColumnWidth(ByVal columnIndex As Integer, ByVal columnWidth As Double)

            Me._opRange = CType(Me._openExcel.Columns(columnIndex), Excel.Range)
            Me._opRange.ColumnWidth = columnWidth

        End Sub

        Public Sub SetColorIndex(ByVal index As Integer, ByVal color As Color)

            Me._openBook.Colors(index) = color

        End Sub

        Public Sub SetCellText( _
            ByVal rowCell As Integer, _
            ByVal columnCell As Integer, _
            ByVal writeText As String, _
            ByVal align As Excel.XlHAlign, _
            ByVal font As Font, _
            ByVal color As Color, _
            ByVal backColor As Color, _
            Optional ByVal numberFormat As String = "G/通用格式")

            Me._opRange = CType(Me._openSheet.Cells(rowCell, columnCell), Excel.Range)
            Me._opRange.WrapText = True
            Me._opRange.NumberFormatLocal = numberFormat

            Dim fontStyle As String = String.Empty
            If (font.Style And Drawing.FontStyle.Bold) > 0 Then
                fontStyle &= " 加粗"
            End If

            If (font.Style And Drawing.FontStyle.Italic) > 0 Then
                fontStyle &= " 倾斜"
            End If

            Me._opRange.Characters.Font.FontStyle = fontStyle.Trim


            Me._opRange.HorizontalAlignment = align

            Me._opRange.Font.Name = font.Name
            Me._opRange.Characters.Font.Size = font.Size
            Me._opRange.Font.Color = CommTK.GetColorRGB(color)
            Me._opRange.FormulaR1C1 = CommTK.GetTranslatedString(writeText)
            Me._opRange.Interior.Color = CommTK.GetColorRGB(backColor)

        End Sub

        Public Sub SetCellTextFont( _
            ByVal cellRow As Integer, _
            ByVal cellColumn As Integer, _
            ByVal textStart As Integer, _
            ByVal textLength As Integer, _
            ByVal font As Font, _
            ByVal color As Color)

            Dim range As Microsoft.Office.Interop.Excel.Range = _
                CType(Me._openSheet.Cells(cellRow, cellColumn), Excel.Range)

            If textStart + textLength > range.Characters.Text.Length Then
                textLength = range.Characters.Text.Length - textStart
            End If

            range.Characters(textStart, textLength).Font.Size = font.Size
            range.Characters(textStart, textLength).Font.Color = CommTK.GetColorRGB(color)

            range.Characters(textStart, textLength).Font.FontStyle = String.Empty

            Dim fontStyle As String = String.Empty
            If (font.Style And Drawing.FontStyle.Bold) > 0 Then
                fontStyle &= " 加粗"
            End If

            If (font.Style And Drawing.FontStyle.Italic) > 0 Then
                fontStyle &= " 倾斜"
            End If

            range.Characters(textStart, textLength).Font.FontStyle = fontStyle.Trim

            If (font.Style And Drawing.FontStyle.Underline) > 0 Then
                range.Characters(textStart, textLength).Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle
            End If

            range.Characters(textStart, textLength).Font.Name = font.FontFamily.Name
            If font.Strikeout = True Then
                range.Characters(textStart, textLength).Font.Strikethrough = True
            End If

        End Sub

        Public Sub InsertPicture( _
            ByVal row As Integer, _
            ByVal column As Integer, _
            ByVal pictureImage As Image, _
            ByVal offsetX As Integer, _
            ByVal offsetY As Integer, _
            Optional ByVal width As Integer = 0, _
            Optional ByVal height As Integer = 0)

            Me._opRange = Me._openSheet.Range(Me._openExcel.Cells(row, column), Me._openExcel.Cells(row, column))
            Dim picturePath As String = WinTK.GetResourceFilePath(ResourceType.TempFile, "ExportPicturePic")
            If IO.File.Exists(picturePath) = True Then
                IO.File.Delete(picturePath)
            End If
            If width > 0 And height > 0 Then
                pictureImage = CommTK.GetThumbnail(pictureImage, width, height)
            End If
            pictureImage.Save(picturePath)

            Me._opRange.Select()
            Me._openSheet.Shapes.AddPicture( _
                picturePath, _
                Microsoft.Office.Core.MsoTriState.msoFalse, _
                Microsoft.Office.Core.MsoTriState.msoTrue, _
                CommTK.FInteger(Me._opRange.Left) + offsetX, _
                CommTK.FInteger(Me._opRange.Top) + offsetY, _
                pictureImage.Width, _
                pictureImage.Height)

        End Sub

        Public Sub SetFrameLine( _
            ByVal startRow As Integer, _
            ByVal startColumn As Integer, _
            ByVal endRow As Integer, _
            ByVal endColumn As Integer, _
            ByVal borderParts As BorderPart, _
            ByVal borderColor As Color, _
            Optional ByVal LineStyle As Excel.XlLineStyle = Excel.XlLineStyle.xlContinuous, _
            Optional ByVal lineWeight As Excel.XlBorderWeight = Excel.XlBorderWeight.xlThin)

            Me._opRange = Me._openSheet.Range(Me._openExcel.Cells(startRow, startColumn), Me._openExcel.Cells(endRow, endColumn))
            If (borderParts And BorderPart.Left) > 0 Then
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = LineStyle
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = lineWeight
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeLeft).Color = CommTK.GetColorRGB(borderColor)
            End If

            If (borderParts And BorderPart.Right) > 0 Then
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = LineStyle
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = lineWeight
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeRight).Color = CommTK.GetColorRGB(borderColor)
            End If

            If (borderParts And BorderPart.Top) > 0 Then
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = LineStyle
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = lineWeight
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeTop).Color = CommTK.GetColorRGB(borderColor)
            End If

            If (borderParts And BorderPart.Bottom) > 0 Then
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = LineStyle
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = lineWeight
                Me._opRange.Borders(Excel.XlBordersIndex.xlEdgeBottom).Color = CommTK.GetColorRGB(borderColor)
            End If

            If (borderParts And BorderPart.Vertical) > 0 AndAlso endColumn > startColumn Then
                Me._opRange.Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = LineStyle
                Me._opRange.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = lineWeight
                Me._opRange.Borders(Excel.XlBordersIndex.xlInsideVertical).Color = CommTK.GetColorRGB(borderColor)
            End If

            If (borderParts And BorderPart.Horizonal) > 0 AndAlso endRow > startRow Then
                Me._opRange.Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = LineStyle
                Me._opRange.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = lineWeight
                Me._opRange.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Color = CommTK.GetColorRGB(borderColor)
            End If

        End Sub

        Public Sub QuitAndClose()
            Me._openBook.Close(False)
            Me._openExcel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openSheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openBook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openExcel)
            System.GC.Collect()
        End Sub

        Public Sub SaveAndClose()
            If IO.File.Exists(Me._fileName) = False Then
                Me._openBook.SaveAs(Me._fileName)
            Else
                Me._openExcel.ActiveWorkbook.Save()
            End If
            Me._openBook.Close()
            Me._openExcel.Quit()

            If IsNothing(Me._opRange) = False Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._opRange)
            End If
            If IsNothing(Me._openSheet) = False Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openSheet)
            End If
            If IsNothing(Me._openBook) = False Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openBook)
            End If
            If IsNothing(Me._openExcel) = False Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openExcel)
            End If
            System.GC.Collect()

        End Sub

        Public Function SelectSheet(ByVal sheetName As String) As Boolean
            Try
                Me._openSheet = CType(Me._openExcel.Sheets(sheetName), Excel.Worksheet)
                Me._openSheet.Select()

                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        Public Sub RemoveRow(ByVal row As Integer)
            Me._opRange = CType(Me._openSheet.Rows(Row), Excel.Range)
            Me._opRange.Delete(Shift:=-4162)
        End Sub

        Public Sub SetVisible(ByVal isVisible As Boolean)
            Me._openExcel.Visible = isVisible
        End Sub

        Public Sub FreezeColumn(ByVal columnCounter As Integer)

            Me._opRange = CType(Me._openSheet.Columns(columnCounter), Excel.Range)
            Me._opRange.Select()
            'Me._openSheet.FreezePanes = True
            Me._openExcel.ActiveWindow.FreezePanes = True

        End Sub

        Public Sub DeleteSheets(ByVal sheetName As String)
            Me._openSheet = CType(Me._openExcel.Sheets(sheetName), Excel.Worksheet)
            Me._openSheet.Delete()
        End Sub

        Public Sub AddSheet(ByVal sheetName As String, Optional ByVal isExist As Boolean = False)
            Me._openExcel.Sheets().Add()
            Me._sheetsCount += 1

            If isExist = False Then
                Me._openSheet = CType(Me._openExcel.Sheets("Sheet" & Me._openExcel.Sheets.Count), Excel.Worksheet)
            Else
                Me._openSheet = CType(Me._openExcel.Sheets("Sheet" & Me._sheetsCount), Excel.Worksheet)
            End If

            Me._openSheet.Name = sheetName

            Me._openSheet.Move(Me._openExcel.Sheets.Item(Me._openExcel.Sheets.Count - 3))

        End Sub

        Public Property BackColor(ByVal startRow As Integer, ByVal startColumn As Integer, Optional ByVal endRow As Integer = 0, Optional ByVal endColumn As Integer = 0) As Color
            Get
                If endRow = 0 Then
                    endRow = startRow
                End If

                If endColumn = 0 Then
                    endColumn = startColumn
                End If

                Me._openExcel.Range(Me._openExcel.Cells(startRow, startColumn), Me._openExcel.Cells(endRow, endColumn)).Select()
                Return Color.FromArgb(CommTK.FInteger(Me._opRange.Interior.ColorIndex))
            End Get
            Set(ByVal Value As Color)
                Me._opRange = Me._openExcel.Range(Me._openExcel.Cells(startRow, startColumn), Me._openExcel.Cells(endRow, endColumn))
                Me._opRange.Interior.Color = CommTK.GetColorRGB(Value)
            End Set
        End Property


        Public Sub SetHyperLink( _
            ByVal startColumn As Integer, _
            ByVal startRow As Integer, _
            ByVal endColumn As Integer, _
            ByVal endRow As Integer, _
            ByVal sheetName As String, _
            ByVal displayText As String, _
            Optional ByVal targetSheetRow As Integer = 1, _
            Optional ByVal targetSheetColumn As Integer = 1)

            Me._openExcel.Range( _
                Me._openExcel.Cells(startRow, startColumn), _
                Me._openExcel.Cells(endRow, endColumn)).Select()

            Dim columnNo As String = _
                CommTK.GetXNaryNumber("ABCDEFGHIJKLMNOPQRSTUVWXYZ", 1)

            Dim cellNo As String = String.Format("{0}{1}", columnNo, targetSheetRow)

            Me._openSheet.Hyperlinks.Add( _
                Me._opRange, _
                "", _
                String.Format("'{0}'!{1}", sheetName, cellNo), _
                , displayText)


        End Sub

        Public Sub ClearContext()

            Me._openExcel.Cells.ClearContents()
            Me._openExcel.Cells.Interior.Color = CommTK.GetColorRGB(Color.White)

            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlLineStyle.xlContinuous
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).Weight = Excel.XlBorderWeight.xlHairline
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeTop).Color = CommTK.GetColorRGB(Color.White)
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).Weight = Excel.XlBorderWeight.xlHairline
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeBottom).Color = CommTK.GetColorRGB(Color.White)
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlLineStyle.xlContinuous
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).Weight = Excel.XlBorderWeight.xlHairline
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeLeft).Color = CommTK.GetColorRGB(Color.White)
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlLineStyle.xlContinuous
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).Weight = Excel.XlBorderWeight.xlHairline
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlEdgeRight).Color = CommTK.GetColorRGB(Color.White)
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlInsideHorizontal).LineStyle = Excel.XlLineStyle.xlContinuous
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Weight = Excel.XlBorderWeight.xlHairline
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlInsideHorizontal).Color = CommTK.GetColorRGB(Color.White)
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlInsideVertical).LineStyle = Excel.XlLineStyle.xlContinuous
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlInsideVertical).Weight = Excel.XlBorderWeight.xlHairline
            Me._openExcel.Cells.Borders(Excel.XlBordersIndex.xlInsideVertical).Color = CommTK.GetColorRGB(Color.White)
            Me._openExcel.Cells.UnMerge()

        End Sub

        Public Sub SetSheetColor(ByVal sheets As ArrayList, ByVal color As Color)

            For Each sheet As Excel.Worksheet In Me._openExcel.ActiveWorkbook.Sheets
                If sheets.Contains(sheet.Name) = False AndAlso sheet.Name <> "Index" Then
                    sheet.Tab.Color = CommTK.GetColorRGB(color)
                End If
            Next

        End Sub


        Public Function GetCellText(ByVal rowCounter As Integer, ByVal columnCounter As Integer) As String
            Me._opRange = CType(Me._openExcel.Cells(rowCounter, columnCounter), Excel.Range)
            Me._opRange.Select()

            Return CommTK.FString(Me._openExcel.ActiveCell.FormulaR1C1).Trim

        End Function

        Public Sub Close()
            Me._openExcel.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Me._openExcel)
            System.GC.Collect()
        End Sub

        Public Function GetSheetsCount() As Integer
            Return Me._openExcel.Sheets.Count
        End Function

        Public Sub SetSheetZoom(ByVal zoomValue As Integer)
            Me._openSheet.PageSetup.Zoom = zoomValue
        End Sub

        Public Sub SetSheetOritation(ByVal ori As Excel.XlPageOrientation)
            Me._openSheet.PageSetup.Orientation = ori
        End Sub


    End Class
End Namespace
