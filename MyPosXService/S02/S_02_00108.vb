Imports XL.Common
Imports XL.Common.Utils
Imports System.Data
Imports MyPosXAuto.Facade



Public Class S_02_00108
    Inherits MarshalByRefObject

    Public Shared Function GetInstance() As S_02_00108

        Dim result As S_02_00108
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00108), _
                                String.Format("tcp://{0}/S_02_00108.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00108)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00108
        End If

        Return result

    End Function

    Public Enum LCs
        None
        View
        Utld0003
        Utld0004
        Utld0005
    End Enum




    Public Function ServInitDisplay( _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByVal valLoginStaffID As String, _
        ByRef refStaffRowSE As MyPosXAuto.FTs.FT_M_STAFFRowSEntity, _
        ByVal valTurnoverID As String, _
        ByRef refTurnoverRowSE As MyPosXAuto.FTs.FT_H_MP_TURNOVERRowSEntity, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity(refStaffRowSE, valLoginStaffID)

        MyPosXAuto.Facade.AfBizTurnover.FillH_MP_TURNOVERRowSEntity(refTurnoverRowSE, valTurnoverID)

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


    Public Function ServLoadInfo( _
        ByVal valConsignID As String, _
        ByVal valEditingTurnoverID As String, _
        ByRef refTurnoverRowSE As MyPosXAuto.FTs.FT_H_MP_TURNOVERRowSEntity, _
        ByRef refTurnoverConsignDtlList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_CONSIGN_DTL, _
        ByRef refConsignRowSE As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_CONSIGNRowSEntity, _
        ByRef refConsignRecpList As MyPosXAuto.FTs.FT_XV_H_MP_TOVR_CONSIGN_RECP) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim result As String = String.Empty

        If valConsignID.Length = 0 Then

            MyPosXAuto.Facade.AfBizTurnover.FillH_MP_TURNOVERRowSEntity(refTurnoverRowSE, valEditingTurnoverID)

            Dim consignSituationConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_MP_TURNOVER_CONSIGN_SITUATION(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            consignSituationConditions.Add(AfMV.MV_MP_TURNOVER_CONSIGN_SITUATIONColumns.TURNOVER_IDColumn, "=", valEditingTurnoverID)
            consignSituationConditions.Add("CONSIGN_WARE_AMOUNT < DTL_WARE_AMOUNT")

            Dim consignSituationList As New MyPosXAuto.FTs.FT_MV_MP_TURNOVER_CONSIGN_SITUATION
            MyPosXAuto.Facade.AfMV.FillFT_MV_MP_TURNOVER_CONSIGN_SITUATION(consignSituationConditions, consignSituationList)

            Dim consignSituationRow As MyPosXAuto.FTs.FT_MV_MP_TURNOVER_CONSIGN_SITUATIONRow
            Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_CONSIGN_DTLRow
            For Each consignSituationRow In consignSituationList
                bindingRow = refTurnoverConsignDtlList.NewXV_H_MP_TURNOVER_CONSIGN_DTLRow
                refTurnoverConsignDtlList.AddXV_H_MP_TURNOVER_CONSIGN_DTLRow(bindingRow)

                bindingRow.WARE_ID = consignSituationRow.WARE_ID
                bindingRow.WARE_CODE = consignSituationRow.WARE_CODE
                bindingRow.WARE_NAME = consignSituationRow.WARE_NAME
                bindingRow.SPEC = consignSituationRow.SPEC
                bindingRow.MODEL = consignSituationRow.MODEL
                bindingRow.WARE_AMOUNT = consignSituationRow.DTL_WARE_AMOUNT - consignSituationRow.CONSIGN_WARE_AMOUNT
            Next

            Return String.Empty
        End If

        Dim consignLogConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_CONSIGN(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        consignLogConditions.Add( _
             AfXV.XV_H_MP_TURNOVER_CONSIGNColumns.CONSIGN_IDColumn, _
            "=", _
            valConsignID)

        MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVER_CONSIGNRowSEntity(refConsignRowSE, consignLogConditions)

        Dim consignDtlConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_CONSIGN_DTL(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        consignDtlConditions.Add(AfXV.XV_H_MP_TURNOVER_CONSIGN_DTLColumns.CONSIGN_IDColumn, "=", valConsignID)
        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_CONSIGN_DTL(consignDtlConditions, refTurnoverConsignDtlList)

        Dim consignRecipientCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TOVR_CONSIGN_RECP(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        consignRecipientCondition.Add(AfXV.XV_H_MP_TOVR_CONSIGN_RECPColumns.CONSIGN_IDColumn, "=", valConsignID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TOVR_CONSIGN_RECP(consignRecipientCondition, refConsignRecpList)

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


    Public Function ServSaveInfo( _
        ByVal valEditingTurnoverID As String, _
        ByRef refRevisingConsignID As String, _
        ByVal valConsignDueDate As DateTime, _
        ByVal valEmployeeID As String, _
        ByVal valConfirmOnSave As Boolean, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_CONSIGN_DTL _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim consignID As String

        If refRevisingConsignID.Length = 0 Then

            consignID = Guid.NewGuid.ToString

            MyPosXAuto.Facade.AfBizTurnover.CreateH_MP_TURNOVER_CONSIGNInfo( _
                Facade.OpBizTurnover.GetAutoConsignCode(False, valEditingTurnoverID), _
                valConsignDueDate, _
                consignID, _
                valEmployeeID, _
                valConfirmOnSave, _
                False, _
                valEditingTurnoverID)

        Else

            consignID = refRevisingConsignID
            MyPosXAuto.Facade.AfBizTurnover.ReviseH_MP_TURNOVER_CONSIGNInfo( _
                refRevisingConsignID, _
                Nothing, _
                valConsignDueDate, _
                valEmployeeID, _
                valConfirmOnSave, _
                False, _
                valEditingTurnoverID)

        End If


        Dim bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_CONSIGN_DTLRow
        For counter As Integer = 0 To refBindingList.Count - 1

            bindingRow = refBindingList(counter)
            If bindingRow.RowState <> DataRowState.Deleted Then
                bindingRow.CONSIGN_ID = consignID
                If bindingRow.WARE_AMOUNT <= 0 Then
                    bindingRow.Delete()
                ElseIf bindingRow.DETAIL_ID.Length = 0 Then
                    bindingRow.DETAIL_ID = Guid.NewGuid.ToString
                End If
            End If

        Next

        If refBindingList.UndeletedRowCount = 0 Then
            Return MyPosXService.Decls.MSG_ALERT_00023
        End If

        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_CONSIGN_DTLData(refBindingList)

        If valConfirmOnSave = True Then
            Facade.OpMP.ExecuteMP_MP_EXECUTE_FINISH_TURNOVER_CONSIGN_BALANCE(valEditingTurnoverID)
        End If


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
