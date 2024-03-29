Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade



Public Class S_01_00205
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00205

        Dim result As S_01_00205
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_01_00205), _
                                String.Format("tcp://{0}/S_01_00205.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00205)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00205
        End If

        Return result

    End Function

    Public Enum LCs
        None
        Utld0002
        Utld0003
        Utld0004
        Utld0005
    End Enum



    Public Function ServInitDisplay( _
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


    Public Function ServImport( _
        ByRef refWareList As MyPosXAuto.FTs.FT_M_MP_WARE, _
        ByVal valWareClassifyID As String, _
        ByVal valDistinguishBy As Integer, _
        ByVal automateWareCode As Boolean) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
        Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim wareCode As String
        Dim counter As Integer = 0
        Dim wareID As String

        'XL.Win.Window.XLProgressBox.SetProgressRange(valWareList.UndeletedRowCount, 400, False)

        wareCondition.Clear()
        For Each bindingRow As MyPosXAuto.FTs.FT_M_MP_WARERow In refWareList.FindRowsByCondition(wareCondition)

            If bindingRow.ROW_HIGHLIGHT <> MyPosXService.Decls.ROW_HIGHLIGHT_REPEAT_CONFLICT Then

                wareCode = bindingRow.CUSTOM_CODE

                wareCondition.Clear()
                If valDistinguishBy = 1 Then
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.CUSTOM_CODEColumn, "=", bindingRow.CUSTOM_CODE)
                Else
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.WARE_NAMEColumn, "=", bindingRow.WARE_NAME)
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.SPECColumn, "=", bindingRow.SPEC)
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.MODELColumn, "=", bindingRow.MODEL)
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.ATTRIBUTE1Column, "=", bindingRow.ATTRIBUTE1)
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.ATTRIBUTE2Column, "=", bindingRow.ATTRIBUTE2)
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.ATTRIBUTE3Column, "=", bindingRow.ATTRIBUTE3)
                    wareCondition.Add(AfBizMaster.M_MP_WAREColumns.ATTRIBUTE4Column, "=", bindingRow.ATTRIBUTE4)
                End If

                'XL.Win.Window.XLProgressBox.DisplayProgress(XService.Decls.MSG_PROGRESS_0004, counter, bindingRow.WARE_CODE)

                wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                If IsNothing(wareRow) = True Then


                    If automateWareCode = True Then
                        wareCode = Facade.OpBizMaster.GetAutoWareCode(False, valWareClassifyID, String.Empty, String.Empty)
                    End If

                    wareID = Guid.NewGuid.ToString
                    MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WAREInfo( _
                        bindingRow.ATTRIBUTE1, _
                        bindingRow.ATTRIBUTE2, _
                        bindingRow.ATTRIBUTE3, _
                        bindingRow.ATTRIBUTE4, _
                        bindingRow.CUSTOM_CODE, _
                        bindingRow.GUARANTEE_DAYS, _
                        False, _
                        0, _
                        bindingRow.MODEL, _
                        bindingRow.MODEL_EN, _
                        bindingRow.PRACT_CODE_REQUIRED, _
                        bindingRow.REMARK, _
                        bindingRow.SPEC, _
                        bindingRow.SPEC_EN, _
                        bindingRow.SUPPLIER_ID, _
                        bindingRow.UNIT_COST, _
                        bindingRow.UNIT_NAME, _
                        bindingRow.UNIT_PRICE, _
                        valWareClassifyID, _
                        wareCode, _
                        wareID, _
                        Nothing, _
                        bindingRow.WARE_NAME, _
                        bindingRow.WARE_NAME_EN)

                Else

                    MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WAREInfo( _
                        wareRow.WARE_ID, _
                        bindingRow.ATTRIBUTE1, _
                        bindingRow.ATTRIBUTE2, _
                        bindingRow.ATTRIBUTE3, _
                        bindingRow.ATTRIBUTE4, _
                        bindingRow.CUSTOM_CODE, _
                        bindingRow.GUARANTEE_DAYS, _
                        False, _
                        0, _
                        bindingRow.MODEL, _
                        bindingRow.MODEL_EN, _
                        bindingRow.PRACT_CODE_REQUIRED, _
                        bindingRow.REMARK, _
                        bindingRow.SPEC, _
                        bindingRow.SPEC_EN, _
                        bindingRow.SUPPLIER_ID, _
                        bindingRow.UNIT_COST, _
                        bindingRow.UNIT_NAME, _
                        bindingRow.UNIT_PRICE, _
                        valWareClassifyID, _
                        wareRow.WARE_CODE, _
                        Nothing, _
                        bindingRow.WARE_NAME, _
                        bindingRow.WARE_NAME_EN)

                End If

                bindingRow.Delete()
            End If

            counter += 1

        Next

        'XL.Win.Window.XLProgressBox.CloseXLProgressBox()

        Return result

    End Function


    Public Function ServReadExcel( _
        ByVal valWareClassifyID As String, _
        ByRef refAutoWareCode As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

        refAutoWareCode = Facade.OpBizMaster.GetAutoWareCode(True, valWareClassifyID, String.Empty, String.Empty)

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
