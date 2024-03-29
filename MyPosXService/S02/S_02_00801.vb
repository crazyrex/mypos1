Imports XL.Common
Imports XL.Common.Utils
Imports System.Collections
Imports System.Data

Public Class S_02_00801
    Inherits MarshalByRefObject
    Public Shared Function GetInstance() As S_02_00801

        Dim result As S_02_00801
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try
                result = CType(Activator.GetObject(GetType(S_02_00801), _
                                String.Format("tcp://{0}/S_02_00801.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_02_00801)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_02_00801
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


    Public Function ServBizUtld0004( _
        ByVal valTurnoverID As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)



        'Dim servResult As String = _
        '    Me._service.ServUtld0001(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServInitDisplay( _
        ByVal valLanguagOption As Integer, _
        ByRef refSysWareSpecModelDiscard As Boolean, _
        ByRef refSysHideFinancials As Boolean, _
        ByRef refSysShowCustomWareCode As Boolean, _
        ByRef refSysAttribute1 As String, _
        ByRef refSysAttribute2 As String, _
        ByRef refSysAttribute3 As String, _
        ByRef refSysAttribute4 As String, _
        ByRef refTurnoverBookStatusList As MyPosXAuto.FTs.FT_CIV_TURNOVER_BOOK_STATUS) As String

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

        MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_BOOK_STATUSList(valLanguagOption, String.Empty, refTurnoverBookStatusList, True)

        Return result

    End Function


    Public Function ServAddPractWareByCode( _
        ByVal valPractBarcode As String, _
        ByRef refPractWareRowSE As MyPosXAuto.FTs.FT_XV_T_MP_PRACT_WARERowSEntity _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim practWareConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        practWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_PRACT_WAREColumns.PRACT_BARCODEColumn, "=", valPractBarcode)
        'practWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_PRACT_WAREColumns.CURRENT_POSColumn, "=", 0)

        MyPosXAuto.Facade.AfXV.FillXV_T_MP_PRACT_WARERowSEntity(refPractWareRowSE, practWareConditions)

        If refPractWareRowSE.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00008
        End If
        'Dim servResult As String = _
        '    Me._service.ServUtld0003(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServLoadTurnoverInfoByCode( _
        ByVal valTurnoverCode As String, _
        ByRef refTurnoverRowSE As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE _
        ) As String


        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        '''
        Dim turnoverConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        turnoverConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVERColumns.TURNOVER_CODEColumn, "=", valTurnoverCode)

        MyPosXAuto.Facade.AfXV.FillXV_H_MP_TURNOVERRowSEntity(refTurnoverRowSE, turnoverConditions)

        If refTurnoverRowSE.IsNull = True Then
            Return MyPosXService.Decls.MSG_ALERT_00057
        End If

        '''XV_H_MP_TURNOVER_DTL_PRACT_WARE条件TURNOVER_IDColumn改为H_MP_TURNOVER_TURNOVER_IDColumn
        Dim practWareConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        practWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.H_MP_TURNOVER_TURNOVER_IDColumn, "=", refTurnoverRowSE.TURNOVER_ID)

        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL_PRACT_WARE(practWareConditions, refBindingList)

        'Dim servResult As String = _
        '    Me._service.ServUtld0004(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServSaveInfo( _
        ByVal valTurnoverID As String, _
        ByRef refPractWareList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim turnoverRow As MyPosXAuto.FTs.FT_H_MP_TURNOVERRow = MyPosXAuto.Facade.AfBizTurnover.GetH_MP_TURNOVERRow(valTurnoverID)
        'Dim historyID As string
        For Each bindingRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow In refPractWareList
            '--------------------------------------
            If turnoverRow.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN Then
                MyPosXAuto.Facade.AfBizTurnover.ReviseT_MP_PRACT_WARERow(bindingRow.PRACT_BARCODE, MyPosXAuto.Facade.AfBizTurnover.T_MP_PRACT_WAREColumns.CURRENT_POSColumn, turnoverRow.POS_ID)
            Else
                MyPosXAuto.Facade.AfBizTurnover.ReviseT_MP_PRACT_WARERow(bindingRow.PRACT_BARCODE, MyPosXAuto.Facade.AfBizTurnover.T_MP_PRACT_WAREColumns.CURRENT_POSColumn, 0)
            End If
        Next


        MyPosXAuto.Facade.AfBizTurnover.SaveBatchH_MP_TURNOVER_DTL_PRACT_WAREData(refPractWareList)

        Facade.OpBizTurnover.SycronizePractTurnoverDtl(valTurnoverID)
        Facade.OpBizTurnover.GenerateDefaultTurnoverConsign(valTurnoverID)
        'Dim servResult As String = _
        '    Me._service.ServUtld0005(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServImportFromMobile( _
        ByVal valTurnoverRowSE As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVERRowSEntity, _
        ByVal valReadPractWareList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE, _
        ByRef refPractDtlList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim readPractWareRow As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARERow = Nothing
        Dim practDtlCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)

        Dim practWareRow As MyPosXAuto.FTs.FT_XV_T_MP_PRACT_WARERow = Nothing
        Dim practWareCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_T_MP_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)


        For Each readPractWareRow In valReadPractWareList

            practWareCondition.Clear()
            practWareCondition.Add(MyPosXAuto.Facade.AfXV.XV_T_MP_PRACT_WAREColumns.PRACT_BARCODEColumn, "=", readPractWareRow.PRACT_BARCODE)

            practWareRow = MyPosXAuto.Facade.AfXV.GetXV_T_MP_PRACT_WARERow(practWareCondition)

            If IsNothing(practWareRow) = True Then
                Continue For
            End If

            If valTurnoverRowSE.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_IN AndAlso _
                practWareRow.CURRENT_POS = valTurnoverRowSE.POS_ID Then
                Continue For
            End If


            If valTurnoverRowSE.TURNOVER_TYPE = MyPosXAuto.Decls.CIVALUE_TURNOVER_TYPE_CHECK_OUT AndAlso _
                practWareRow.CURRENT_POS <> valTurnoverRowSE.POS_ID Then
                Continue For
            End If

            practDtlCondition.Clear()
            practDtlCondition.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.PRACT_BARCODEColumn, "=", practWareRow.PRACT_BARCODE)

            readPractWareRow = refPractDtlList.FindRowByCondition(practDtlCondition)
            If IsNothing(readPractWareRow) = False Then
                Continue For
            End If

            readPractWareRow = refPractDtlList.NewXV_H_MP_TURNOVER_DTL_PRACT_WARERow
            refPractDtlList.AddXV_H_MP_TURNOVER_DTL_PRACT_WARERow(readPractWareRow)

            readPractWareRow.PRACT_BARCODE = practWareRow.PRACT_BARCODE
            readPractWareRow.H_MP_TURNOVER_TURNOVER_ID = CommTK.FString(valTurnoverRowSE.TURNOVER_ID)

            readPractWareRow.WARE_ID = practWareRow.WARE_ID
            readPractWareRow.WARE_NAME = practWareRow.WARE_NAME
            readPractWareRow.SPEC = practWareRow.SPEC
            readPractWareRow.MODEL = practWareRow.MODEL
            readPractWareRow.UNIT_NAME = practWareRow.UNIT_NAME
            readPractWareRow.ATTRIBUTE1 = practWareRow.ATTRIBUTE1
            readPractWareRow.ATTRIBUTE2 = practWareRow.ATTRIBUTE2
            readPractWareRow.ATTRIBUTE3 = practWareRow.ATTRIBUTE3
            readPractWareRow.ATTRIBUTE4 = practWareRow.ATTRIBUTE4
            readPractWareRow.REMARK = practWareRow.REMARK
            readPractWareRow.WARE_CODE = practWareRow.WARE_CODE
            readPractWareRow.CUSTOM_CODE = practWareRow.CUSTOM_CODE

            readPractWareRow.PRACT_REMARKS = practWareRow.PRACT_REMARKS


        Next

        Return String.Empty

    End Function


    Public Function ServBizUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0007(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0008(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0009(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0010(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0011(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0012(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0013(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0014(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0015(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0016(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0017(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0018(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0019(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


    Public Function ServBizUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0020(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return String.Empty

    End Function


End Class
