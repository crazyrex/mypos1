Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade


Public Class S_02_00110
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_02_00110

        Dim result As S_02_00110
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00110), _
                                String.Format("tcp://{0}/S_02_00110.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00110)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00110
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
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        refSysWareSpecModelDiscard = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_WARE_SPEC_MODEL_DISCARD))

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

        Return result

    End Function

    Public Function ServAddRecipientByCode( _
        ByVal valRecipientCode As String, _
        ByVal valConsignID As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        Dim recipientCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfT_MP_RECIPIENT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        recipientCondition.Add(AfBizTurnover.T_MP_RECIPIENTColumns.RECP_BARCODEColumn, "=", valRecipientCode)

        Dim recipientRow As MyPosXAuto.FTs.FT_T_MP_RECIPIENTRow = Nothing
        MyPosXAuto.Facade.AfBizTurnover.GetT_MP_RECIPIENTRow(recipientCondition)

        If IsNothing(recipientRow) = True Then
            Return MyPosXService.Decls.MSG_ALERT_00035
        End If

        Dim recpConsigningCondition As New MyPosXAuto.Facade.AfBizTurnover.ConditionOfL_MP_RECP_CONSIGNING(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        Dim recpConsigningRow As MyPosXAuto.FTs.FT_L_MP_RECP_CONSIGNINGRow

        recpConsigningCondition.Add(AfBizTurnover.L_MP_RECP_CONSIGNINGColumns.RECIPIENT_IDColumn, "=", recipientRow.RECIPIENT_ID)
        recpConsigningRow = MyPosXAuto.Facade.AfBizTurnover.GetL_MP_RECP_CONSIGNINGRow(recpConsigningCondition)

        If IsNothing(recpConsigningRow) = False Then
            Return MyPosXService.Decls.MSG_ALERT_00036
        End If

        Dim recpWareList As New MyPosXAuto.FTs.FT_XV_T_MP_RECIPIENT_WARE
        Dim recpWareRow As MyPosXAuto.FTs.FT_XV_T_MP_RECIPIENT_WARERow

        Dim recpWareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_RECIPIENT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        recpWareCondition.Add(AfXV.XV_T_MP_RECIPIENT_WAREColumns.RECIPIENT_IDColumn, "=", recipientRow.RECIPIENT_ID)
        MyPosXAuto.Facade.AfXV.FillFT_XV_T_MP_RECIPIENT_WARE(recpWareCondition, recpWareList)

        If recpWareList.Count = 0 Then
            Return MyPosXService.Decls.MSG_ALERT_00037
        End If

        Dim linkID = Guid.NewGuid.ToString
        MyPosXAuto.Facade.AfBizTurnover.CreateL_MP_RECP_CONSIGNINGInfo( _
            valConsignID, _
            linkID, _
            recipientRow.RECIPIENT_ID)

        Dim detailID = Guid.NewGuid.ToString
        MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TOVR_CONSIGN_RECPInfo( _
            valConsignID, _
            detailID, _
            recipientRow.RECIPIENT_ID)

        Dim consignRecpWareList As New MyPosXAuto.FTs.FT_XV_H_MP_TOVR_CONSIGN_RECP_WARE
        Dim consignRecpWareRow As MyPosXAuto.FTs.FT_XV_H_MP_TOVR_CONSIGN_RECP_WARERow

        For Each recpWareRow In recpWareList

            consignRecpWareRow = consignRecpWareList.NewXV_H_MP_TOVR_CONSIGN_RECP_WARERow
            consignRecpWareList.AddXV_H_MP_TOVR_CONSIGN_RECP_WARERow(consignRecpWareRow)

            consignRecpWareRow.WARE_ID = recpWareRow.WARE_ID
            consignRecpWareRow.WARE_AMOUNT = recpWareRow.WARE_AMOUNT
            consignRecpWareRow.DETAIL_ID = detailID

        Next

        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TOVR_CONSIGN_RECP_WAREData(consignRecpWareList)

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
