Imports XL.Common
Imports XL.Common.Utils



Public Class S_01_00203        
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_01_00203                                           
                                                                                                 
        Dim result As S_01_00203                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_01_00203), _
                                String.Format("tcp://{0}/S_01_00203.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_01_00203)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_01_00203
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
        ByRef refSysShowCustomWareCode As Boolean, _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByRef refSysShowEnglishItemName As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String, _
        ByRef refSysAutoWareCodeSurfix As Boolean) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refSysShowCustomWareCode = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_CUSTOM_WARE_CODE))
        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))
        refSysHideFinancials = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_HIDE_FINANCIALS))
        refSysShowEnglishItemName = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_SHOW_ENGLISH_ITEM_NAME))

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

        refSysAutoWareCodeSurfix = CommTK.FBoolean(SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_AUTO_WARE_CODE_SURFIX))
        Return result

    End Function


    Public Function ServGetAutoWareCode( _
        ByRef refWareCode As String, _
        ByVal valWareClassifyID As String, _
        ByVal valSupplierCode As String, _
        ByVal valSurfix As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refWareCode = Facade.OpBizMaster.GetAutoWareCode(True, valWareClassifyID, valSupplierCode, valSurfix)

        Return result

    End Function


    Public Function ServUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)


        Dim result As String = String.Empty

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


    Public Function ServSaveInfo( _
        ByVal valWareClassifyID As String, _
        ByVal valEditingWareID As String, _
        ByVal valManualCode As Boolean, _
        ByVal valCustomCodeVisible As Boolean, _
        ByRef refWareCode As String, _
        ByRef refCustomCode As String, _
        ByVal valAttribute1 As String, _
        ByVal valAttribute2 As String, _
        ByVal valAttribute3 As String, _
        ByVal valAttribute4 As String, _
        ByVal valModel As String, _
        ByVal valModelEn As String, _
        ByVal valRemarks As String, _
        ByVal valSpec As String, _
        ByVal valSpecEn As String, _
        ByVal valSupplierID As String, _
        ByVal valUnitCost As Decimal, _
        ByVal valUnitPrice As Decimal, _
        ByVal valUnitName As String, _
        ByVal valWareName As String, _
        ByVal valWareNameEn As String, _
        ByVal valIsRetired As Boolean, _
        ByVal valGuaranteeDays As Integer, _
        ByVal valPractCodeRequired As Boolean, _
        ByVal valWareCodeSurfix As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Try

            Dim wareBatchPrefix As String = SysInfo.ReadShareSysInfo(MyPosXService.Decls.SVN_WARE_BATCH_PREFIX)

            If wareBatchPrefix.StartsWith(refWareCode) = True Then
                Return MyPosXService.Decls.MSG_ALERT_00031
            End If

            Dim supplierRowSE As New MyPosXAuto.FTs.FT_M_MP_SUPPLIERRowSEntity
            MyPosXAuto.Facade.AfBizMaster.FillM_MP_SUPPLIERRowSEntity(supplierRowSE, valSupplierID)
            Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.CUSTOM_CODEColumn, "=", refCustomCode)

            If valEditingWareID = String.Empty Then

                If valManualCode = False Then
                    refWareCode = Facade.OpBizMaster.GetAutoWareCode(False, valWareClassifyID, supplierRowSE.SUPPLIER_CODE, valWareCodeSurfix)
                End If

                If valCustomCodeVisible = False Then
                    refCustomCode = refWareCode
                End If

                If MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARECount(wareCondition) > 0 Then
                    Return Decls.MSG_ALERT_00068
                End If

                valEditingWareID = Guid.NewGuid.ToString

                MyPosXAuto.Facade.AfBizMaster.CreateM_MP_WAREInfo( _
                    valAttribute1, _
                    valAttribute2, _
                    valAttribute3, _
                    valAttribute4, _
                    refCustomCode, _
                    valGuaranteeDays, _
                    valIsRetired, _
                    0, _
                    valModel, _
                    valModelEn, _
                    valPractCodeRequired, _
                    valRemarks, _
                    valSpec, _
                    valSpecEn, _
                    valSupplierID, _
                    valUnitCost, _
                    valUnitName, _
                    valUnitPrice, _
                    valWareClassifyID, _
                    refWareCode, _
                    valEditingWareID, _
                    Nothing, _
                    valWareName, _
                    valWareNameEn)

                Return String.Empty

            End If

            wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_IDColumn, "<>", valEditingWareID)

            If MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARECount(wareCondition) > 0 Then
                Return Decls.MSG_ALERT_00068
            End If


            MyPosXAuto.Facade.AfBizMaster.ReviseM_MP_WAREInfo( _
                    valEditingWareID, _
                    valAttribute1, _
                    valAttribute2, _
                    valAttribute3, _
                    valAttribute4, _
                    refCustomCode, _
                    CommDecl.NULL_INTEGER, _
                    valIsRetired, _
                    valGuaranteeDays, _
                    valModel, _
                    valModelEn, _
                    valPractCodeRequired, _
                    valRemarks, _
                    valSpec, _
                    valSpecEn, _
                    valSupplierID, _
                    valUnitCost, _
                    valUnitName, _
                    valUnitPrice, _
                    valWareClassifyID, _
                    refWareCode, _
                    Nothing, _
                    valWareName, _
                    valWareNameEn)




        Catch ex As XL.Common.Utils.XLException

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

            'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

            Return logContentBuilder.ToString()

        Catch ex As Exception

            Dim logContentBuilder As New LineStrBuilder
            logContentBuilder.AppendLine("Message: {0}", ex.Message)
            logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


            Return logContentBuilder.ToString()

        End Try

        Return String.Empty


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
