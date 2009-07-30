Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections

Namespace Facade

    Public Class OpBizMaster

        Public Shared Function GetPosWarePrice(ByVal wareID As String, ByVal posID As String, ByRef origionPrice As Decimal) As Decimal

            Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(posID)

            Dim warePriceSetDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            warePriceSetDtlConditions.Add( _
                AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, _
                "=", _
                posRow.POS_SET_ID)

            warePriceSetDtlConditions.Add( _
                AfXV.XV_S_MP_POS_SET_WAREColumns.WARE_IDColumn, _
                "=", _
                wareID)

            Dim posSetWareRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow = _
                MyPosXAuto.Facade.AfXV.GetXV_S_MP_POS_SET_WARERow(warePriceSetDtlConditions)

            If IsNothing(posSetWareRow) = True Then
                Return 0
            End If

            origionPrice = posSetWareRow.UNIT_PRICE
            Return (posSetWareRow.PRICE_SCALE * origionPrice / 100) - posSetWareRow.INDIVIDUAL_DISCOUNT


        End Function

        Public Shared Function GetPosWareCost(ByVal wareID As String, ByVal posID As String) As Decimal

            Dim posRow As MyPosXAuto.FTs.FT_M_MP_POSRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(posID)

            Dim warePriceSetDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            warePriceSetDtlConditions.Add( _
                AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, _
                "=", _
                posRow.POS_SET_ID)

            warePriceSetDtlConditions.Add( _
                AfXV.XV_S_MP_POS_SET_WAREColumns.WARE_IDColumn, _
                "=", _
                wareID)

            Dim posSetWareRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow = _
                MyPosXAuto.Facade.AfXV.GetXV_S_MP_POS_SET_WARERow(warePriceSetDtlConditions)

            If IsNothing(posSetWareRow) = True Then
                Return 0
            End If

            Return posSetWareRow.UNIT_COST * posSetWareRow.PRICE_SCALE / 100

        End Function

        Public Shared Function GetWareClassifyIDPath(ByVal wareClassifyID As String, ByRef classifyDepth As Integer) As String

            Dim result As String = String.Empty
            Dim wareClassifyCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            Dim wareClassifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow
            Dim wareClassifyIDPath As New ArrayList

            classifyDepth = 0
            Do While wareClassifyID.Length <> 0

                wareClassifyIDPath.Add(wareClassifyID)
                wareClassifyCondition = New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
                wareClassifyCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_IDColumn, "=", wareClassifyID)
                wareClassifyRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(wareClassifyCondition)

                If IsNothing(wareClassifyRow) = True Then
                    Return String.Empty
                End If

                classifyDepth += 1
                wareClassifyID = wareClassifyRow.PARENT_ID

            Loop

            Dim counter As Integer


            For counter = wareClassifyIDPath.Count - 1 To 0 Step -1
                result &= CommTK.FString(wareClassifyIDPath(counter)) & "/"
            Next

            result = "/" & result

            Return result

        End Function

        Public Shared Function GetWareInfoString(ByVal wareID As String, ByVal posID As String, ByVal breakLines As Boolean) As String

            Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareID)


            Dim resultBuilder As New LineStrBuilder
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE)) = True Then
                resultBuilder.AppendLine(wareRow.CUSTOM_CODE)
            End If


            resultBuilder.AppendFormat("{0} {1} {2}", wareRow.WARE_NAME, wareRow.SPEC, wareRow.MODEL)
            If breakLines = True Then
                resultBuilder.AppendLine(String.Empty)
            End If

            Dim labelPrintSet As String = SysInfo.ReadShareSysInfo(CommDecl.XLSSVN_LABEL_PRINT_SET).ToUpper

            Select Case labelPrintSet
                Case "POWER LEGEND"
                Case Else
                    resultBuilder.AppendLine("{0} {1} {2} {3}", wareRow.ATTRIBUTE1, wareRow.ATTRIBUTE2, wareRow.ATTRIBUTE3, wareRow.ATTRIBUTE4)
            End Select

            'Dim origionPrice As Decimal
            'If posID > 0 AndAlso _
            '    CommTK.FBoolean(SysInfo.ReadShareSysInfo(XService.Decls.SVN_HIDE_FINANCIALS)) = False Then
            '    resultBuilder.AppendLine("{0}", Facade.OpBizMaster.GetPosWarePrice(wareID, posID, origionPrice))

            'End If

            Return resultBuilder.ToString

        End Function

        Public Shared Function GetShelfLocationInfoString(ByVal locationID As String) As String


            Dim locationRow As MyPosXAuto.FTs.FT_M_MP_POS_LOCATIONRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_POS_LOCATIONRow(locationID)

            If IsNothing(locationRow) = True Then
                Return String.Empty
            End If

            Dim resultBuilder As New LineStrBuilder

            Return String.Format("{0}/{1}/{2}", _
                locationRow.AREA_CODE, _
                locationRow.SHELF_CODE, _
                locationRow.LOCATION_CODE)

            Return resultBuilder.ToString

        End Function

        Public Shared Function GetLocationIDByCode(ByVal locationCode As String) As String
            Dim codes As String() = locationCode.Split("/"c)

            If codes.Length < 3 Then
                Return String.Empty
            End If

            Dim locationCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_POS_LOCATION(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            locationCondition.Add(AfBizMaster.M_MP_POS_LOCATIONColumns.AREA_CODEColumn, "=", codes(0))
            locationCondition.Add(AfBizMaster.M_MP_POS_LOCATIONColumns.SHELF_CODEColumn, "=", codes(1))
            locationCondition.Add(AfBizMaster.M_MP_POS_LOCATIONColumns.LOCATION_CODEColumn, "=", codes(2))

            Dim locationRow As MyPosXAuto.FTs.FT_M_MP_POS_LOCATIONRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_POS_LOCATIONRow(locationCondition)

            If IsNothing(locationRow) = True Then
                Return String.Empty
            End If

            Return locationRow.LOCATION_ID
        End Function

#Region "Get auto code"

        Public Shared Function GetAutoCustomerCode(ByVal preview As Boolean) As String

            Dim codePrefix As String = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_CLIENT_CODE_PREFIX)

            Dim result As String

            Dim serialPreview As String = "XXXX"
            Dim serialReal As String = "0000"

            Dim seedName As String = _
                String.Format("{0}{1:yyMM}", _
                    codePrefix, _
                    DateTime.Now)

            If preview = True Then
                result = String.Format("{0}{1}", _
                    seedName, _
                    serialPreview)
            Else

                Dim locationSeedValue As Integer = _
                    Facade.OpSysConfig.GetNewSeedID(seedName)

                result = String.Format("{0}{1:" & serialReal & "}", _
                    seedName, _
                    locationSeedValue)
            End If

            Return result

        End Function

        Public Shared Function GetAutoSupplierCode(ByVal preview As Boolean) As String

            Dim codePrefix As String = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_SUPPLIER_CODE_PREFIX)

            Dim result As String

            Dim serialPreview As String = "XXXX"
            Dim serialReal As String = "0000"

            Dim seedName As String = _
                String.Format("{0}{1:yyMM}", _
                    codePrefix, _
                    DateTime.Now)

            If preview = True Then
                result = String.Format("{0}{1}", _
                    seedName, _
                    serialPreview)
            Else

                Dim locationSeedValue As Integer = _
                    Facade.OpSysConfig.GetNewSeedID(seedName)

                result = String.Format("{0}{1:" & serialReal & "}", _
                    seedName, _
                    locationSeedValue)
            End If

            Return result

        End Function

        Public Shared Function GetAutoWareCode( _
            ByVal preview As Boolean, _
            ByVal classifyID As String, _
            ByVal supplierCode As String, _
            ByVal surfix As String) As String

            Dim classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow = _
                MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(classifyID)

            If IsNothing(classifyRow) = True Then
                Return String.Empty
            End If

            Dim idLength = CommTK.FInteger(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_ID_LENTH))
            If idLength <= 3 Or idLength > 9 Then
                idLength = 4
                SysInfo.WriteShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_ID_LENTH, CommTK.FString(idLength))
            End If


            Dim resultBuilder As New LineStrBuilder
            resultBuilder.AppendFormat(classifyRow.WARE_CLASSIFY_CODE)

            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_HYPHON)) = True Then
                resultBuilder.AppendFormat("-")
            End If

            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SUPPLIER_CODE)) = True Then
                resultBuilder.AppendFormat(supplierCode)
            End If

            If preview = True Then
                resultBuilder.AppendFormat(StrDup(idLength, "X"))
                If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SURFIX)) = True Then
                    resultBuilder.AppendFormat(surfix)
                End If

                Return resultBuilder.ToString
            End If

            Dim seedName As String = String.Format("{0}_{1}", MyPosXService.Decls.SPX_WARE_CODE, classifyID)
            Dim seedValue As Integer = Facade.OpSysConfig.GetNewSeedID(seedName)

            resultBuilder.AppendFormat("{0:" + StrDup(idLength, "0") + "}", seedValue)
            If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SURFIX)) = True Then
                resultBuilder.AppendFormat(surfix)
            End If

            Return resultBuilder.ToString


        End Function

        Public Shared Function IsAutoWareCode(ByVal classifyID As String, ByVal wareCode As String) As Boolean

            Dim classifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow = _
                    MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(classifyID)

            If IsNothing(classifyRow) = True Then
                Return False
            End If

            If wareCode.StartsWith(classifyRow.WARE_CLASSIFY_CODE & "-") = False Then
                Return False

            End If

            If wareCode.Length - classifyRow.WARE_CLASSIFY_CODE.Length <> 5 Then
                Return False
            End If

            If CommTK.IsNumericValue(wareCode.Substring(classifyRow.WARE_CLASSIFY_CODE.Length + 1, wareCode.Length - classifyRow.WARE_CLASSIFY_CODE.Length - 1)) = False Then
                Return False
            End If

            Return True

        End Function

        Public Shared Function GetAutoRecipientCode(ByVal preview As Boolean, ByVal recipientType As Integer) As String

            Dim recipientBarcodeCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_RECP_TYPE_BARCODE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            recipientBarcodeCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_RECP_TYPE_BARCODEColumns.RECIPIENT_TYPEColumn, "=", recipientType)
            Dim recipientBarcodeRow As MyPosXAuto.FTs.FT_S_MP_RECP_TYPE_BARCODERow = _
                MyPosXAuto.Facade.AfBizConfig.GetS_MP_RECP_TYPE_BARCODERow(recipientBarcodeCondition)

            If IsNothing(recipientBarcodeRow) = True Then
                Return String.Empty
            End If
            Dim seedName As String = String.Format("{0}{1}", MyPosXService.Decls.SPX_RECIPIENT_BARCODE, recipientBarcodeRow.BARCODE_PREFIX)

            Dim resultBuilder As New LineStrBuilder

            Dim serialPreview As String = "XXXX"
            Dim serialReal As String = "0000"

            resultBuilder.AppendFormat("{0}-", recipientBarcodeRow.BARCODE_PREFIX)
            If preview = True Then
                resultBuilder.AppendFormat("XXXX")
                Return resultBuilder.ToString
            Else

                Dim seedValue As Integer = _
                    Facade.OpSysConfig.GetNewSeedID(seedName)

                resultBuilder.AppendFormat("{0:0000}", seedValue)
            End If

            Return resultBuilder.ToString

        End Function
#End Region

        Public Shared Sub ImportClassifyList( _
            ByVal parentWareClassifyID As String, _
            ByVal wareClassifyList As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFY, _
            ByVal classifyRows As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow(), _
            ByRef involvedClassifyCodes As ArrayList)

            Dim wareClassifyCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            Dim wareClassifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow = Nothing
            Dim dbWareClassifyRow As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow = Nothing
            Dim childClassifyRows As MyPosXAuto.FTs.FT_M_MP_WARE_CLASSIFYRow() = Nothing
            Dim wareClassifyID As String

            For Each wareClassifyRow In classifyRows

                involvedClassifyCodes.Add(wareClassifyRow.WARE_CLASSIFY_CODE)
                wareClassifyCondition.Clear()
                wareClassifyCondition.Add(AfBizMaster.M_MP_WARE_CLASSIFYColumns.WARE_CLASSIFY_CODEColumn, "=", wareClassifyRow.WARE_CLASSIFY_CODE)

                dbWareClassifyRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARE_CLASSIFYRow(wareClassifyCondition)

                If IsNothing(dbWareClassifyRow) = True Then

                    wareClassifyID = Guid.NewGuid.ToString
                    MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WARE_CLASSIFYInfo( _
                        wareClassifyRow.CLASSIFY_DEPTH, _
                        parentWareClassifyID, _
                        wareClassifyRow.REMARK, _
                        wareClassifyRow.WARE_CLASSIFY_CODE, _
                        wareClassifyID, _
                        wareClassifyRow.WARE_CLASSIFY_ID_PATH, _
                        wareClassifyRow.WARE_CLASSIFY_NAME)
                Else
                    wareClassifyID = dbWareClassifyRow.WARE_CLASSIFY_ID
                    MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WARE_CLASSIFYInfo( _
                        wareClassifyID, _
                        wareClassifyRow.CLASSIFY_DEPTH, _
                        parentWareClassifyID, _
                        wareClassifyRow.REMARK, _
                        wareClassifyRow.WARE_CLASSIFY_CODE, _
                        wareClassifyRow.WARE_CLASSIFY_ID_PATH, _
                        wareClassifyRow.WARE_CLASSIFY_NAME)
                End If



                wareClassifyCondition.Clear()
                wareClassifyCondition.Add(AfBizMaster.M_MP_WARE_CLASSIFYColumns.PARENT_IDColumn, "=", wareClassifyRow.WARE_CLASSIFY_ID)
                childClassifyRows = wareClassifyList.FindRowsByCondition(wareClassifyCondition)


                Facade.OpBizMaster.ImportClassifyList( _
                    wareClassifyID, _
                    wareClassifyList, _
                    childClassifyRows, _
                    involvedClassifyCodes)

            Next


        End Sub

        
    End Class

End Namespace
