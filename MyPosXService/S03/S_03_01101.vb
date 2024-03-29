Imports XL.Common
Imports XL.Common.Utils

Public Class S_03_01101        
    Inherits MarshalByRefObject
    Public Shared Function GetInstance() As S_03_01101                                           
                                                                                                 
        Dim result As S_03_01101                                                                 
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting AndAlso CommDecl.SYSTEM_IS_ONLINE Then

            Try

                result = CType(Activator.GetObject(GetType(S_03_01101), _
                                String.Format("tcp://{0}/S_03_01101.remote", _
                                    SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                                S_03_01101)

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try
        Else

            result = New S_03_01101
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


    Public Function ServLoadList( _
        ByVal valDateFrom As Date, _
        ByVal valDateTo As Date, _
        ByVal valTurnoverCode As String, _
        ByVal valBarcode As String, _
        ByRef refTurnoverDtlPractWareList As MyPosXAuto.FTs.FT_XV_H_MP_TURNOVER_DTL_PRACT_WARE _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        Dim practWareConditions As New MyPosXAuto.Facade.AfXV.ConditionOfXV_H_MP_TURNOVER_DTL_PRACT_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
        practWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.TURNOVER_TIMEColumn, ">=", valDateFrom)
        practWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.TURNOVER_TIMEColumn, "<=", valDateTo)

        If valTurnoverCode.Trim.Length > 0 Then
            practWareConditions.Add(MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.TURNOVER_CODEColumn, "=", valTurnoverCode)
        End If

        If valBarcode.Trim.Length > 0 Then
            practWareConditions.Add( _
                MyPosXAuto.Facade.AfXV.XV_H_MP_TURNOVER_DTL_PRACT_WAREColumns.PRACT_BARCODEColumn, _
                "like", _
                String.Format("%{0}%", valBarcode))
        End If

        MyPosXAuto.Facade.AfXV.FillFT_XV_H_MP_TURNOVER_DTL_PRACT_WARE(practWareConditions, refTurnoverDtlPractWareList)
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
        ByRef refChooseTurnoverTypeList As MyPosXAuto.FTs.FT_CIV_TURNOVER_TYPE, _
        ByRef refChooseTurnoverStyleList As MyPosXAuto.FTs.FT_CIV_TURNOVER_STYLE) As String

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

        MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_TYPEList(valLanguagOption, String.Empty, refChooseTurnoverTypeList, True)
        MyPosXAuto.Facade.AfCIV.FillCI_TURNOVER_STYLEList(valLanguagOption, String.Empty, refChooseTurnoverStyleList, True)

        Return result

    End Function


    Public Function ServBizUtld0003( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0003(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0004( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0004(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0005(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
    End Function                            


    Public Function ServBizUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)

        'Dim servResult As String = _
        '    Me._service.ServUtld0006(

        'If servResult.length > 0 Then
        '    Return servResult
        'End If

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
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

        Return string.Empty                       
                                            
    End Function                            


    End Class
