Imports XL.Common
Imports XL.Common.Utils



Public Class S_01_00402        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00402                                           
                                                                                                 
        Dim result As S_01_00402                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try

                result = CType(Activator.GetObject(GetType(S_01_00402), _
                                String.Format("tcp://{0}/S_01_00402.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00402)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00402
        End If

        Return result

    End Function

    Public Enum LCs
        None
        View
        Edit
        Utld0004
        Utld0005
    End Enum



    Public Function ServInitDisplay( _
        ByVal valLanguagOption As Integer, _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByRef refSysShowCustomWareCode As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
        refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))

        refSysAttribute1 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1)
        refSysAttribute2 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2)
        refSysAttribute3 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3)
        refSysAttribute4 = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4)

        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE1_HIDDEN)) = True Then
            refSysAttribute1 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE2_HIDDEN)) = True Then
            refSysAttribute2 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE3_HIDDEN)) = True Then
            refSysAttribute3 = String.Empty
        End If
        If CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_CUSTOM_ATTRIBUTE4_HIDDEN)) = True Then
            refSysAttribute4 = String.Empty
        End If


        refSysShowCustomWareCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE))

        Return result

    End Function


    Public Function ServSaveInfo( _
        ByRef refRevisingSetID As String, _
        ByVal valPosType As Integer, _
        ByVal valPriceScale As Integer, _
        ByVal valRemark As String, _
        ByVal valSetCode As String, _
        ByVal valEmployeeCommissionRate As Double, _
        ByVal valRetailOperatorSalesShare As Boolean, _
        ByVal valPosSetWareList As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        If refRevisingSetID = String.Empty Then

            Dim setID = Guid.NewGuid.ToString
            MyPosXAuto.Facade.AfBizConfig.CreateS_MP_POS_SETInfo( _
                valPosType, _
                valPriceScale, _
                valRemark, _
                valRetailOperatorSalesShare, _
                valSetCode, _
                setID, _
                valEmployeeCommissionRate)


        Else

            MyPosXAuto.Facade.AfBizConfig.ReviseS_MP_POS_SETInfo( _
                    refRevisingSetID, _
                    valPosType, _
                    valPriceScale, _
                    valRemark, _
                    valRetailOperatorSalesShare, _
                    valSetCode, _
                    valEmployeeCommissionRate)

        End If

        For Each bindingRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow In valPosSetWareList.FindRowsByCondition(Nothing)
            If bindingRow.RowState <> Data.DataRowState.Deleted Then
                bindingRow.SET_ID = refRevisingSetID
            End If

            If bindingRow.DETAIL_ID.Length = 0 Then
                bindingRow.DETAIL_ID = Guid.NewGuid.ToString
            End If
        Next

        MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_POS_SET_WAREData(valPosSetWareList)

        'Dim dbCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        'dbCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", refRevisingSetID)
        'Dim dbList As New MyPosXAuto.FTs.FT_S_MP_POS_SET_WARE
        'MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_POS_SET_WARE(dbCondition, dbList)

        'Dim dbRow As MyPosXAuto.FTs.FT_S_MP_POS_SET_WARERow
        'Dim existingDetailIDs As New Collections.ArrayList

        'For Each bindingRow As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARERow In valPosSetWareList.FindRowsUndeleted

        '    bindingRow.SET_ID = refRevisingSetID

        '    dbCondition.Clear()
        '    dbCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.WARE_IDColumn, "=", bindingRow.WARE_ID)

        '    dbRow = dbList.FindRowByCondition(dbCondition)

        '    If IsNothing(dbRow) = False Then

        '        If dbRow.DETAIL_ID <> bindingRow.DETAIL_ID Then
        '            dbList.AddNewS_MP_POS_SET_WARERow( _
        '                bindingRow.DETAIL_ID, _
        '                bindingRow.INDIVIDUAL_DISCOUNT, _
        '                bindingRow.LOWER_LIMIT, _
        '                bindingRow.SET_ID, _
        '                bindingRow.UNIT_COST, _
        '                bindingRow.UNIT_PRICE, _
        '                bindingRow.WARE_ID)
        '            existingDetailIDs.Add(bindingRow.DETAIL_ID)
        '        Else
        '            existingDetailIDs.Add(dbRow.DETAIL_ID)
        '            dbRow.CloneDataRow(bindingRow)
        '        End If
        '    Else
        '        dbList.AddNewS_MP_POS_SET_WARERow( _
        '            bindingRow.DETAIL_ID, _
        '            bindingRow.INDIVIDUAL_DISCOUNT, _
        '            bindingRow.LOWER_LIMIT, _
        '            bindingRow.SET_ID, _
        '            bindingRow.UNIT_COST, _
        '            bindingRow.UNIT_PRICE, _
        '            bindingRow.WARE_ID)
        '        existingDetailIDs.Add(bindingRow.DETAIL_ID)

        '    End If

        'Next

        'MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_POS_SET_WAREData(dbList)

        'dbCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_POS_SET_WAREColumns.DETAIL_IDColumn, False, existingDetailIDs)
        'MyPosXAuto.Facade.AfBizConfig.DeleteS_MP_POS_SET_WAREData(dbCondition)
        MyPosXService.Facade.OpMP.ExecuteMP_MP_EXECUTE_DELETE_REDUNDANCY_POS_SET_WARE()

        Return result

    End Function


    Public Function ServLoadInfo( _
        ByVal valSetID As String, _
        ByRef refPosSetRowSE As MyPosXAuto.FTs.FT_S_MP_POS_SETRowSEntity, _
        ByRef refPosSetWareList As MyPosXAuto.FTs.FT_XV_S_MP_POS_SET_WARE) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        MyPosXAuto.Facade.AfBizConfig.FillS_MP_POS_SETRowSEntity(refPosSetRowSE, valSetID)

        Dim priceSetDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_POS_SET_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        priceSetDtlConditions.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_POS_SET_WAREColumns.SET_IDColumn, "=", valSetID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_POS_SET_WARE(priceSetDtlConditions, refPosSetWareList)

        Return result

    End Function


    Public Function ServUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


    Public Function ServUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        Return result

    End Function


End Class
