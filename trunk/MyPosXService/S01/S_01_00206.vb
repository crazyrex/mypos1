
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'������Ϣ, ��ƷBOM����
'
'===========================================================
Imports XL.Common
Imports XL.Common.Utils
Imports System.Collections
Imports System.Collections.Generic

Public Class S_01_00206
    Inherits XL.DB.Utils.BaseService

    Public Shared Function GetInstance() As S_01_00206

        Dim result As S_01_00206
        If MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.DBType.Remoting Then

            Try

                result = CType(Activator.GetObject(GetType(S_01_00206), _
                    String.Format("tcp://{0}/S_01_00206.remote", _
                        SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))),  _
                    S_01_00206)

                If result.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then
                    Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                    ex.SetMessage(CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED)
                    Throw ex
                End If

            Catch ex As Exception

                Dim remoteConnectionEx As New XLException(XLException.ErrorClassify.ReadDataError)
                remoteConnectionEx.SetMessage(CommDecl.MSG_ALERT_REMOTE_CONNECTION_INAVAILABLE)
                Throw remoteConnectionEx

            End Try

        Else

            result = New S_01_00206
        End If

        Return result

    End Function

    Public Enum LCs
        None
        ChooseOptionOfComponent
        Utld0003
        Utld0004
        Utld0005
    End Enum


    'Public Function ServInitDisplay( _
    '    ByVal valLanguagOption As Integer, _
    '    ByRef refPurchaseWayList As XAuto.FTs.FT_CIV_PURCHASE_WAY, _
    '    ByRef refAssetAbsentTypeList As XAuto.FTs.FT_CIV_ASSET_ABSENT_TYPE, _
    '    ByRef refAssetConformationList As XAuto.FTs.FT_CIV_ASSET_CONFORMATION, _
    '    ByRef refEliminateWayList As XAuto.FTs.FT_CIV_ELIMINATE_WAY, _
    '    ByRef refInAccountCredenceTextList As XAuto.FTs.FT_CIV_IN_ACCOUNT_CREDENCE_TEXT, _
    '    ByRef refSysManageFormMustConfirm As Boolean _
    '    ) As String
    '
    '    XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)
    '
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_CONFORMATIONList(valLanguagOption, String.Empty, refAssetConformationList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_ABSENT_TYPEList(valLanguagOption, String.Empty, refAssetAbsentTypeList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ELIMINATE_WAYList(valLanguagOption, String.Empty, refEliminateWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_PURCHASE_WAYList(valLanguagOption, String.Empty, refPurchaseWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_IN_ACCOUNT_CREDENCE_TEXTList(valLanguagOption, String.Empty, refInAccountCredenceTextList, False)
    '
    '    refSysManageFormMustConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_MANAGE_FORM_MUST_CONFIRM))
    '
    '    Return String.Empty
    '
    'End Function


    'Public Function ServInitDisplay( _
    '    ByVal valLanguagOption As Integer, _
    '    ByRef refPurchaseWayList As XAuto.FTs.FT_CIV_PURCHASE_WAY, _
    '    ByRef refAssetAbsentTypeList As XAuto.FTs.FT_CIV_ASSET_ABSENT_TYPE, _
    '    ByRef refAssetConformationList As XAuto.FTs.FT_CIV_ASSET_CONFORMATION, _
    '    ByRef refEliminateWayList As XAuto.FTs.FT_CIV_ELIMINATE_WAY, _
    '    ByRef refInAccountCredenceTextList As XAuto.FTs.FT_CIV_IN_ACCOUNT_CREDENCE_TEXT, _
    '    ByRef refSysManageFormMustConfirm As Boolean _
    '    ) As String
    '
    '    XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf Facade.OpSysConfig.GetSysValue, AddressOf Facade.OpSysConfig.SetSysValue)
    '
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_CONFORMATIONList(valLanguagOption, String.Empty, refAssetConformationList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ASSET_ABSENT_TYPEList(valLanguagOption, String.Empty, refAssetAbsentTypeList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_ELIMINATE_WAYList(valLanguagOption, String.Empty, refEliminateWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_PURCHASE_WAYList(valLanguagOption, String.Empty, refPurchaseWayList, False)
    '    MyPosXAuto.Facade.AfCIV.FillCI_IN_ACCOUNT_CREDENCE_TEXTList(valLanguagOption, String.Empty, refInAccountCredenceTextList, False)
    '
    '    refSysManageFormMustConfirm = CommTK.FBoolean(SysInfo.ReadShareSysInfo(Decls.SVN_MANAGE_FORM_MUST_CONFIRM))
    '
    '    Return String.Empty
    '
    'End Function


    'Public Function ServLoadList( _
    '    ByVal valWareCodesString As String, _
    '    ByRef refBindingList As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOM, _
    '    ByRef refChooseRootWareList As MyPosXAuto.FTs.FT_M_MP_WARE _
    '    ) As String

    '    If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

    '    Try
    '        Dim wareCodes = CommTK.StrToAL(valWareCodesString)

    '        Dim bomCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_WARE_BOM(XL.DB.Utils.Condition.LogicOperators.Logic_And)
    '        Dim bomRow As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOMRow
    '        refBindingList.Clear()
    '        Dim bindingRow As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOMRow
    '        Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
    '        Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
    '        Dim addedChooseRootWareIDs As New List(Of String)
    '        Dim rootOwningWareID As String = String.Empty

    '        '�ҳ����еĸ���Ʒ
    '        Dim owningWareIDQueue As New Queue(Of String)
    '        For Each wareCode As String In wareCodes

    '            '���ݻ�Ʒ�����ҵ�Ϊ��ϼ��ļ�¼
    '            bomCondition.Clear()
    '            bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.OWNING_WARE__WARE_CODEColumn, "=", wareCode)
    '            bomRow = MyPosXAuto.Facade.AfXV.GetXV_S_MP_WARE_BOMRow(bomCondition)

    '            If IsNothing(bomRow) = True Then

    '                wareCondition.Clear()
    '                wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", wareCode)
    '                warerow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

    '                If IsNothing(wareRow) = True Then
    '                    Continue For
    '                End If

    '                bindingRow = refBindingList.NewXV_S_MP_WARE_BOMRow
    '                refBindingList.AddXV_S_MP_WARE_BOMRow(bindingRow)
    '                bindingRow.ROW_HIGHLIGHT = Decls.ROW_HIGHLIGHT_BOM_ROOT
    '                bindingRow.BELONG_WARE__WARE_ID = wareRow.WARE_ID
    '                bindingRow.BELONG_WARE__WARE_CODE = wareRow.WARE_CODE
    '                bindingRow.BELONG_WARE__WARE_NAME = wareRow.WARE_NAME

    '                Continue For
    '            Else
    '                bindingRow = refBindingList.NewXV_S_MP_WARE_BOMRow
    '                refBindingList.AddXV_S_MP_WARE_BOMRow(bindingRow)
    '                bindingRow.ROW_HIGHLIGHT = Decls.ROW_HIGHLIGHT_BOM_ROOT
    '                bindingRow.BELONG_WARE__WARE_ID = bomRow.OWNING_WARE__WARE_ID
    '                bindingRow.BELONG_WARE__WARE_CODE = bomRow.OWNING_WARE__WARE_CODE
    '                bindingRow.BELONG_WARE__WARE_NAME = bomRow.OWNING_WARE__WARE_NAME
    '                owningWareIDQueue.Enqueue(bomRow.OWNING_WARE__WARE_ID)

    '            End If


    '            Do While IsNothing(bomRow) = False

    '                rootOwningWareID = bomRow.OWNING_WARE__WARE_ID
    '                bomCondition.Clear()
    '                bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.BELONG_WARE__WARE_IDColumn, "=", bomRow.OWNING_WARE__WARE_ID)
    '                bomRow = MyPosXAuto.Facade.AfXV.GetXV_S_MP_WARE_BOMRow(bomCondition)


    '            Loop


    '            If addedChooseRootWareIDs.Contains(rootOwningWareID) = False AndAlso _
    '                bindingRow.BELONG_WARE__WARE_ID <> rootOwningWareID Then
    '                wareCondition.Clear()
    '                wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_IDColumn, "=", rootOwningWareID)
    '                MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(wareCondition, refChooseRootWareList)
    '                addedChooseRootWareIDs.Add(rootOwningWareID)
    '            End If
    '        Next

    '        Dim bomList As New MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOM

    '        '��ʼ�Թ�����ȵݹ飬�����״�б�
    '        Do While owningWareIDQueue.Count > 0

    '            bomList.Clear()
    '            bomCondition.Clear()
    '            bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.OWNING_WARE__WARE_IDColumn, "=", owningWareIDQueue.Dequeue)
    '            MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_WARE_BOM(bomCondition, bomList)

    '            For Each bomRow In bomList
    '                owningWareIDQueue.Enqueue(bomRow.BELONG_WARE__WARE_ID)
    '            Next

    '            refBindingList.ImportTable(bomList, Nothing)
    '        Loop


    '    Catch ex As XL.Common.Utils.XLException

    '        Dim logContentBuilder As New LineStrBuilder
    '        logContentBuilder.AppendLine("Message: {0}", ex.Message)
    '        logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)

    '        'WinTK.OutputLog("XL Exception", logContentBuilder.ToString())

    '        Return logContentBuilder.ToString()

    '    Catch ex As Exception

    '        Dim logContentBuilder As New LineStrBuilder
    '        logContentBuilder.AppendLine("Message: {0}", ex.Message)
    '        logContentBuilder.AppendLine("Stack Trace: {0}", ex.StackTrace)


    '        Return logContentBuilder.ToString()

    '    End Try

    '    Return String.Empty

    'End Function


    Public Function ServAddOptions( _
        ByVal valComponentID As String, _
        ByVal valAddingWareIDString As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_S_MP_BOM_COMP_WARE_OPT _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try

            Dim optionRow As MyPosXAuto.FTs.FT_XV_S_MP_BOM_COMP_WARE_OPTRow
            Dim componentRow = MyPosXAuto.Facade.AfBizConfig.GetS_MP_BOM_COMPONENTRow(valComponentID)

            Dim existingWareIDs As New List(Of String)
            For Each optionRow In refBindingList
                existingWareIDs.Add(optionRow.WARE_ID)
            Next

            Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
            Dim optionCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_BOM_COMP_WARE_OPT(XL.DB.Utils.Condition.LogicOperators.Logic_And)

            For Each addingWareID As String In CommTK.StrToAL(valAddingWareIDString)

                If existingWareIDs.Contains(addingWareID) = True Then
                    Continue For
                End If

                wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(addingWareID)
                If IsNothing(wareRow) = True Then
                    Continue For
                End If

                optionCondition.Clear()
                optionCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_BOM_COMP_WARE_OPTColumns.WARE_IDColumn, "=", addingWareID)

                If refBindingList.FindRowsByCondition(optionCondition).Count > 0 Then
                    Continue For
                End If

                optionRow = refBindingList.NewXV_S_MP_BOM_COMP_WARE_OPTRow()
                refBindingList.AddXV_S_MP_BOM_COMP_WARE_OPTRow(optionRow)
                optionRow.COMPONENT_ID = valComponentID
                optionRow.OPTION_ID = Guid.NewGuid.ToString
                optionRow.WARE_ID = wareRow.WARE_ID
                optionRow.WARE_CODE = wareRow.WARE_CODE
                optionRow.WARE_NAME = wareRow.WARE_NAME
                optionRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_MODIFIED

            Next

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


    Public Function ServSaveComponentList( _
        ByVal valComposingWareID As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENT _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try


            Dim dbComponentList As New MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENT
            Dim dbComponentRow As MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENTRow
            Dim dbComponentCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_BOM_COMPONENT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            dbComponentCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_BOM_COMPONENTColumns.COMPOSING_WAREColumn, "=", valComposingWareID)
            MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_BOM_COMPONENT(dbComponentCondition, dbComponentList)

            Dim involvedComponentIDs As New ArrayList

            For Each bindingRow As MyPosXAuto.FTs.FT_S_MP_BOM_COMPONENTRow In refBindingList

                If bindingRow.COMPONENT_ID = valComposingWareID Then
                    Continue For
                End If

                involvedComponentIDs.Add(bindingRow.COMPONENT_ID)
                dbComponentCondition.Clear()
                dbComponentCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_BOM_COMPONENTColumns.COMPONENT_IDColumn, "=", bindingRow.COMPONENT_ID)
                dbComponentRow = dbComponentList.FindRowByCondition(dbComponentCondition)

                If IsNothing(dbComponentRow) = True Then
                    dbComponentRow = dbComponentList.NewS_MP_BOM_COMPONENTRow
                    dbComponentList.AddS_MP_BOM_COMPONENTRow(dbComponentRow)

                End If

                dbComponentRow.CloneDataRow(bindingRow)

            Next

            dbComponentCondition.Clear()
            dbComponentCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_BOM_COMPONENTColumns.COMPONENT_IDColumn, False, involvedComponentIDs)
            dbComponentList.RemoveFT_S_MP_BOM_COMPONENTRows(dbComponentCondition)

            MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_BOM_COMPONENTData(dbComponentList)
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


    Public Function ServSaveOptionList( _
        ByVal valComponentID As String, _
        ByRef refOptionList As MyPosXAuto.FTs.FT_XV_S_MP_BOM_COMP_WARE_OPT _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try
            Dim optionCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_BOM_COMP_WARE_OPT(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            optionCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_BOM_COMP_WARE_OPTColumns.COMPONENT_IDColumn, "=", valComponentID)

            Dim dbOptionList As New MyPosXAuto.FTs.FT_S_MP_BOM_COMP_WARE_OPT
            Dim dbOptionRow As MyPosXAuto.FTs.FT_S_MP_BOM_COMP_WARE_OPTRow
            MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_BOM_COMP_WARE_OPT(optionCondition, dbOptionList)

            Dim involvedOptionIDs As New ArrayList
            For Each optionRow As MyPosXAuto.FTs.FT_XV_S_MP_BOM_COMP_WARE_OPTRow In refOptionList.FindRowsByCondition(Nothing)

                involvedOptionIDs.Add(optionRow.OPTION_ID)
                optionCondition.Clear()
                optionCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_BOM_COMP_WARE_OPTColumns.OPTION_IDColumn, "=", optionRow.OPTION_ID)

                dbOptionRow = dbOptionList.FindRowByCondition(optionCondition)

                If IsNothing(dbOptionRow) = True Then
                    dbOptionRow = dbOptionList.NewS_MP_BOM_COMP_WARE_OPTRow
                    dbOptionList.AddS_MP_BOM_COMP_WARE_OPTRow(dbOptionRow)
                End If

                dbOptionRow.CloneDataRow(optionRow)
            Next

            optionCondition.Clear()
            optionCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_BOM_COMP_WARE_OPTColumns.OPTION_IDColumn, False, involvedOptionIDs)
            dbOptionList.RemoveFT_S_MP_BOM_COMP_WARE_OPTRows(optionCondition)
            MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_BOM_COMP_WARE_OPTData(dbOptionList)

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


    Public Function ServBizUtld0005( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0006( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0007( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0008( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0009( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0010( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0011( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0012( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0013( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0014( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0015( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0016( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0017( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0018( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0019( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


    Public Function ServBizUtld0020( _
        ByVal valParaUtld As String, _
        ByRef refParaUtld As String _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try



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


End Class
