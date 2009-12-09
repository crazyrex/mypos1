
'===========================================================
'Code generated by Softlands Solution
'-----------------------------------------------------------
'基本信息, 商品BOM管理
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
        Utld0002
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


    Public Function ServLoadList( _
        ByVal valWareCodesString As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOM, _
        ByRef refChooseRootWareList As MyPosXAuto.FTs.FT_M_MP_WARE _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try
            Dim wareCodes = CommTK.StrToAL(valWareCodesString)

            Dim bomCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_WARE_BOM(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim bomRow As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOMRow
            refBindingList.Clear()
            Dim bindingRow As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOMRow
            Dim wareCondition As New MyPosXAuto.Facade.AfBizMaster.ConditionOfM_MP_WARE(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
            Dim addedChooseRootWareIDs As New List(Of String)
            Dim rootOwningWareID As String = String.Empty

            '找出所有的根货品
            Dim owningWareIDQueue As New Queue(Of String)
            For Each wareCode As String In wareCodes

                '根据货品条码找到为组合件的记录
                bomCondition.Clear()
                bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.OWNING_WARE__WARE_CODEColumn, "=", wareCode)
                bomRow = MyPosXAuto.Facade.AfXV.GetXV_S_MP_WARE_BOMRow(bomCondition)

                If IsNothing(bomRow) = True Then

                    wareCondition.Clear()
                    wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_CODEColumn, "=", wareCode)
                    warerow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(wareCondition)

                    If IsNothing(wareRow) = True Then
                        Continue For
                    End If

                    bindingRow = refBindingList.NewXV_S_MP_WARE_BOMRow
                    refBindingList.AddXV_S_MP_WARE_BOMRow(bindingRow)
                    bindingRow.ROW_HIGHLIGHT = Decls.ROW_HIGHLIGHT_BOM_ROOT
                    bindingRow.BELONG_WARE__WARE_ID = wareRow.WARE_ID
                    bindingRow.BELONG_WARE__WARE_CODE = wareRow.WARE_CODE
                    bindingRow.BELONG_WARE__WARE_NAME = wareRow.WARE_NAME

                    Continue For
                Else
                    bindingRow = refBindingList.NewXV_S_MP_WARE_BOMRow
                    refBindingList.AddXV_S_MP_WARE_BOMRow(bindingRow)
                    bindingRow.ROW_HIGHLIGHT = Decls.ROW_HIGHLIGHT_BOM_ROOT
                    bindingRow.BELONG_WARE__WARE_ID = bomRow.OWNING_WARE__WARE_ID
                    bindingRow.BELONG_WARE__WARE_CODE = bomRow.OWNING_WARE__WARE_CODE
                    bindingRow.BELONG_WARE__WARE_NAME = bomRow.OWNING_WARE__WARE_NAME
                    owningWareIDQueue.Enqueue(bomRow.OWNING_WARE__WARE_ID)

                End If


                Do While IsNothing(bomRow) = False

                    rootOwningWareID = bomRow.OWNING_WARE__WARE_ID
                    bomCondition.Clear()
                    bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.BELONG_WARE__WARE_IDColumn, "=", bomRow.OWNING_WARE__WARE_ID)
                    bomRow = MyPosXAuto.Facade.AfXV.GetXV_S_MP_WARE_BOMRow(bomCondition)

                    
                Loop


                If addedChooseRootWareIDs.Contains(rootOwningWareID) = False AndAlso _
                    bindingRow.BELONG_WARE__WARE_ID <> rootOwningWareID Then
                    wareCondition.Clear()
                    wareCondition.Add(MyPosXAuto.Facade.AfBizMaster.M_MP_WAREColumns.WARE_IDColumn, "=", rootOwningWareID)
                    MyPosXAuto.Facade.AfBizMaster.FillFT_M_MP_WARE(wareCondition, refChooseRootWareList)
                    addedChooseRootWareIDs.Add(rootOwningWareID)
                End If
            Next

            Dim bomList As New MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOM

            '开始以广度优先递归，填充数状列表
            Do While owningWareIDQueue.Count > 0

                bomList.Clear()
                bomCondition.Clear()
                bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.OWNING_WARE__WARE_IDColumn, "=", owningWareIDQueue.Dequeue)
                MyPosXAuto.Facade.AfXV.FillFT_XV_S_MP_WARE_BOM(bomCondition, bomList)

                For Each bomRow In bomList
                    owningWareIDQueue.Enqueue(bomRow.BELONG_WARE__WARE_ID)
                Next

                refBindingList.ImportTable(bomList, Nothing)
            Loop


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


    Public Function ServAddWare( _
        ByVal rootWareID As String, _
        ByVal valAddingWareIDString As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOM _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try

            Dim bomCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_WARE_BOM(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            Dim bomRow As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOMRow
            Dim wareRow As MyPosXAuto.FTs.FT_M_MP_WARERow
            Dim rootWareUpperWareIDs As New List(Of String)


            bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.BELONG_WARE__WARE_IDColumn, "=", rootWareID)
            bomRow = MyPosXAuto.Facade.AfXV.GetXV_S_MP_WARE_BOMRow(bomCondition)
            Do While IsNothing(bomRow) = False AndAlso bomRow.OWNING_WARE__WARE_ID.Length > 0
                bomCondition.Clear()
                bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.BELONG_WARE__WARE_IDColumn, "=", bomRow.OWNING_WARE__WARE_ID)
                bomRow = MyPosXAuto.Facade.AfXV.GetXV_S_MP_WARE_BOMRow(bomCondition)
                rootWareUpperWareIDs.Add(bomRow.OWNING_WARE__WARE_ID)
            Loop


            For Each addingWareID As String In CommTK.StrToAL(valAddingWareIDString)
                bomCondition.Clear()
                bomCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.BELONG_WARE__WARE_IDColumn, "=", addingWareID)

                bomRow = refBindingList.FindRowByCondition(bomCondition)
                If IsNothing(bomRow) = False Then
                    Continue For
                End If

                wareRow = MyPosXAuto.Facade.AfBizMaster.GetM_MP_WARERow(addingWareID)
                If IsNothing(wareRow) = True Then
                    Continue For
                End If

                If rootWareUpperWareIDs.Contains(wareRow.WARE_ID) = True Then
                    Continue For
                End If

                bomRow = refBindingList.NewXV_S_MP_WARE_BOMRow()
                refBindingList.AddXV_S_MP_WARE_BOMRow(bomRow)
                bomRow.BELONG_QTY = 1
                bomRow.BELONG_WARE__WARE_ID = wareRow.WARE_ID
                bomRow.BELONG_WARE__WARE_CODE = wareRow.WARE_CODE
                bomRow.BELONG_WARE__WARE_NAME = wareRow.WARE_NAME
                bomRow.WARE_BOM_TYPE = MyPosXService.Decls.DEFAULT_CI_VALUE_WARE_BOM_TYPE_NONE
                bomRow.ROW_HIGHLIGHT = MyPosXService.Decls.ROW_HIGHLIGHT_MODIFIED

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


    Public Function ServSaveInfo( _
        ByVal rootWareID As String, _
        ByRef refBindingList As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOM _
        ) As String

        If Me.ValidateAuthPassword(CommDecl.CURRENT_LOCAL_REMOTE_AUTH_PASSWORD) = False Then Return CommDecl.MSG_ALERT_REMOTE_AUTH_DENIED

        Try

            Dim dbBomList As New MyPosXAuto.FTs.FT_S_MP_WARE_BOM
            Dim dbBomRow As MyPosXAuto.FTs.FT_S_MP_WARE_BOMRow
            Dim dbBomCondition As New MyPosXAuto.Facade.AfBizConfig.ConditionOfS_MP_WARE_BOM(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            dbBomCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_WARE_BOMColumns.OWNING_WAREColumn, "=", rootWareID)
            MyPosXAuto.Facade.AfBizConfig.FillFT_S_MP_WARE_BOM(dbBomCondition, dbBomList)

            Dim involvedWareIDs As New ArrayList

            Dim bindingCondition As New MyPosXAuto.Facade.AfXV.ConditionOfXV_S_MP_WARE_BOM(XL.DB.Utils.Condition.LogicOperators.Logic_And)
            bindingCondition.Add(MyPosXAuto.Facade.AfXV.XV_S_MP_WARE_BOMColumns.OWNING_WARE__WARE_IDColumn, "=", rootWareID)
            For Each bindingRow As MyPosXAuto.FTs.FT_XV_S_MP_WARE_BOMRow In refBindingList.FindRowsByCondition(bindingCondition)
                involvedWareIDs.Add(bindingRow.BELONG_WARE__WARE_ID)
                dbBomCondition.Clear()
                dbBomCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_WARE_BOMColumns.BELONG_WAREColumn, "=", bindingRow.BELONG_WARE__WARE_ID)
                dbBomRow = dbBomList.FindRowByCondition(dbBomCondition)

                If IsNothing(dbBomRow) = False Then
                    dbBomRow.WARE_BOM_TYPE = bindingRow.WARE_BOM_TYPE
                    dbBomRow.BELONG_QTY = bindingRow.BELONG_QTY
                    Continue For
                End If

                dbBomList.AddNewS_MP_WARE_BOMRow( _
                    bindingRow.BELONG_QTY, _
                    bindingRow.BELONG_WARE__WARE_ID, _
                    Guid.NewGuid.ToString, _
                    rootWareID, _
                    bindingRow.WARE_BOM_TYPE)
            Next

            dbBomCondition.Clear()
            dbBomCondition.Add(MyPosXAuto.Facade.AfBizConfig.S_MP_WARE_BOMColumns.BELONG_WAREColumn, False, involvedWareIDs)
            dbBomList.RemoveFT_S_MP_WARE_BOMRows(dbBomCondition)

            MyPosXAuto.Facade.AfBizConfig.SaveBatchS_MP_WARE_BOMData(dbBomList)
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


    Public Function ServBizUtld0004( _
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

