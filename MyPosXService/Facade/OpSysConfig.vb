Imports XL.Common
Imports XL.Common.Utils
Imports MyPosXAuto.Facade
Imports System.Collections
Imports System.Data

Namespace Facade

    Public Class OpSysConfig

#Region "Sys value related"

        Public Shared Function GetSysValue(ByVal valueName As String) As String

            Dim sysValueConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfS_SYS_VALUE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            sysValueConditions.Add(AfSysConfig.S_SYS_VALUEColumns.SYS_VALUE_NAMEColumn, "=", valueName)
            sysValueConditions.Add(AfSysConfig.S_SYS_VALUEColumns.SYSTEM_TITLEColumn, "=", CommDecl.SYSTEM_TITLE)
            Dim sysValueRow As MyPosXAuto.FTs.FT_S_SYS_VALUERow = _
                MyPosXAuto.Facade.AfSysConfig.GetS_SYS_VALUERow(sysValueConditions)

            If IsNothing(sysValueRow) = True Then
                Return String.Empty
            End If

            Return sysValueRow.CONTENT

        End Function


        Public Shared Sub SetSysValue(ByVal valueName As String, ByVal valueContent As String)

            Dim sysValueConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfS_SYS_VALUE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            sysValueConditions.Add(MyPosXAuto.Facade.AfSysConfig.S_SYS_VALUEColumns.SYS_VALUE_NAMEColumn, "=", valueName)
            sysValueConditions.Add(MyPosXAuto.Facade.AfSysConfig.S_SYS_VALUEColumns.SYSTEM_TITLEColumn, "=", CommDecl.SYSTEM_TITLE)
            Dim sysValueRow As MyPosXAuto.FTs.FT_S_SYS_VALUERow = _
            MyPosXAuto.Facade.AfSysConfig.GetS_SYS_VALUERow(sysValueConditions)

            If IsNothing(sysValueRow) = True Then
                MyPosXAuto.Facade.AfSysConfig.CreateS_SYS_VALUEInfo(valueContent, System.Guid.NewGuid.ToString, valueName, CommDecl.SYSTEM_TITLE)
            Else
                MyPosXAuto.Facade.AfSysConfig.ReviseS_SYS_VALUEInfo(sysValueRow.SYS_VALUE_ID, valueContent, valueName, CommDecl.SYSTEM_TITLE)
            End If

        End Sub

#End Region

#Region "Security related"

        Public Shared Function GetServerTime() As DateTime

            Dim sysConfigDataLayer As MyPosXAuto.DataLayer.EDLSysConfig = MyPosXAuto.DataLayer.EDLSysConfig.GetInstance()

            Return sysConfigDataLayer.GetServerTime()

        End Function
        Public Shared Sub GetSecureList(ByVal showSuperSecure As Boolean, ByRef resultData As DataSet)


            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim secureConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfS_SECURE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            If showSuperSecure = False Then
                secureConditions.Add( _
                    MyPosXAuto.Facade.AfSysConfig.S_SECUREColumns.SECURE_IDColumn, "<>", Security.SuperSecureID)
            End If

            MyPosXAuto.Facade.AfSysConfig.GetS_SECUREData(secureConditions, sysConfigDataSet)

            resultData = sysConfigDataSet

        End Sub
        Public Shared Sub GetSecureInfo(ByVal secureID As String, ByRef resultData As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim secureConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_SECURE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            secureConditions.Add( _
                    MyPosXAuto.Facade.AfSysConfig.S_SECUREColumns.SECURE_IDColumn, "=", secureID)

            MyPosXAuto.Facade.AfSysConfig.GetS_SECUREData(secureConditions, sysConfigDataSet)

            resultData = sysConfigDataSet

        End Sub
        Public Shared Sub CreateSecureInfo(ByRef secureID As String, ByVal secureName As String, ByVal secureOptions As String)

            secureID = System.Guid.NewGuid.ToString
            MyPosXAuto.Facade.AfSysConfig.CreateS_SECUREInfo( _
                secureID, _
                secureName, _
                secureOptions)

        End Sub
        Public Shared Sub ReviseSecureInfo(ByVal secureID As String, ByVal secureName As String, ByVal secureOptions As String)

            MyPosXAuto.Facade.AfSysConfig.ReviseS_SECUREInfo( _
                secureID, secureName, secureOptions)

        End Sub

        Public Shared Sub DeleteSecureInfo(ByVal secureID As String)

            MyPosXAuto.Facade.AfSysConfig.DeleteS_SECUREInfo(secureID)

        End Sub
        Public Shared Sub GetUserInfo(ByVal userID As String, ByRef resultData As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim userConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_USER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            userConditions.Add(AfSysConfig.S_USERColumns.USER_IDColumn, "=", userID)
            MyPosXAuto.Facade.AfSysConfig.GetS_USERData(userConditions, sysConfigDataSet)

            resultData = sysConfigDataSet

        End Sub
        Public Shared Sub GetUserList(ByRef resultData As DataSet)

            Dim mvDataSet As New MyPosXAuto.MV

            MyPosXAuto.Facade.AfMV.GetMV_USERData(Nothing, mvDataSet)

            resultData = mvDataSet

        End Sub
        Public Shared Sub CreateUserInfo(ByRef userID As String, ByVal userName As String, ByVal userPassword As String, ByVal secureID As String, ByVal userOptions As String)

            MyPosXAuto.Facade.AfSysConfig.CreateS_USERInfo( _
                0, _
                String.Empty, _
                secureID, _
                userName, _
                userID, _
                userOptions, _
                Security.Encrypt(userPassword))

        End Sub
        Public Shared Sub ReviseUserInfo(ByVal userID As String, ByVal userName As String, ByVal userPassword As String, ByVal secureID As String, ByVal userOptions As String)


            MyPosXAuto.Facade.AfSysConfig.ReviseS_USERInfo( _
                userID, _
                0, _
                Nothing, _
                secureID, _
                userName, _
                userOptions, _
                Security.Encrypt(userPassword))


        End Sub
        Public Shared Sub DeleteUserInfo(ByVal userID As String)

            MyPosXAuto.Facade.AfSysConfig.DeleteS_USERInfo(userID)

        End Sub
        Public Shared Function ValidateUserPassword(ByVal userID As String, ByVal password As String) As Boolean


            Dim userConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_USER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            userConditions.Add(MyPosXAuto.Facade.AfSysConfig.S_USERColumns.USER_IDColumn, " = ", userID)

            Dim userRow As MyPosXAuto.FTs.FT_S_USERRow = _
                MyPosXAuto.Facade.AfSysConfig.GetS_USERRow(userConditions)

            If IsNothing(userRow) = True Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(Decls.MSG_OK_00011)
                Throw ex
            End If

            Return (XL.Common.Utils.Security.Decrypt(userRow.USER_PASSWORD) = password)


        End Function

        Public Shared Function GetSuperSecureID() As String

            Dim result As String = String.Empty

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim secureConditions As New  _
                MyPosXAuto.Facade.AfSysConfig.ConditionOfS_SECURE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            secureConditions.Add(MyPosXAuto.Facade.AfSysConfig.S_SECUREColumns.SECURE_NAMEColumn, "=", CommDecl.SYSTEM_DEFAULT_SECURE_NAME)
            Dim secureRow As MyPosXAuto.FTs.FT_S_SECURERow = _
                MyPosXAuto.Facade.AfSysConfig.GetS_SECURERow(secureConditions)

            If IsNothing(secureRow) = False Then
                result = secureRow.SECURE_ID
            End If

            Return result

        End Function


        Public Shared Function AttemptCreateDefaultAuthority() As Boolean

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim result As Boolean

            Dim secureConditions As New  _
                MyPosXAuto.facade.AfSysConfig.ConditionOfS_SECURE(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            secureConditions.Add( _
                MyPosXAuto.Facade.AfSysConfig.S_SECUREColumns.SECURE_NAMEColumn, _
                "=", _
                CommDecl.SYSTEM_DEFAULT_SECURE_NAME)

            Dim secureRow As MyPosXAuto.FTs.FT_S_SECURERow = _
                MyPosXAuto.Facade.AfSysConfig.GetS_SECURERow(secureConditions)

            Dim secureID As String
            If IsNothing(secureRow) = True Then

                secureID = System.Guid.NewGuid.ToString
                MyPosXAuto.Facade.AfSysConfig.CreateS_SECUREInfo( _
                    secureID, _
                    CommDecl.SYSTEM_DEFAULT_SECURE_NAME, _
                    String.Empty)
            Else
                secureID = secureRow.SECURE_ID
            End If

            Dim userConditions As New  _
                MyPosXAuto.facade.AfSysConfig.ConditionOfS_USER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            userConditions.Add(MyPosXAuto.Facade.AfSysConfig.S_USERColumns.USER_ACCOUNTColumn, "=", CommDecl.SYSTEM_DEFAULT_ACCOUNT)
            Dim userRow As MyPosXAuto.FTs.FT_S_USERRow = _
                MyPosXAuto.Facade.AfSysConfig.GetS_USERRow(userConditions)

            Dim userID As String
            If IsNothing(userRow) = True Then
                userID = System.Guid.NewGuid.ToString
                MyPosXAuto.Facade.AfSysConfig.CreateS_USERInfo( _
                    0, _
                    String.Empty, _
                    secureID, _
                    CommDecl.SYSTEM_DEFAULT_ACCOUNT, _
                    userID, _
                    String.Empty, _
                    Security.Encrypt(String.Empty))

                result = True

            Else


                If userRow.SECURE_ID <> secureID Then

                    userID = userRow.USER_ID
                    MyPosXAuto.Facade.AfSysConfig.ReviseS_USERInfo( _
                        userID, _
                        0, _
                        Nothing, _
                        secureID, _
                        Nothing, _
                        Nothing, _
                        Nothing)

                End If

            End If

            Return result
        End Function


        Public Shared Function ValidateUserNamePassword(ByVal userName As String, ByVal password As String) As Boolean

            Dim userConditions As New  _
                MyPosXAuto.facade.AfMV.ConditionOfMV_USER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            userConditions.Add(AfMV.MV_USERColumns.USER_ACCOUNTColumn, "=", userName)

            Dim userRow As MyPosXAuto.FTs.FT_MV_USERRow = _
                MyPosXAuto.Facade.AfMV.GetMV_USERRow(userConditions)

            If IsNothing(userRow) = True Then
                Return False
            End If

            Dim userPassword As String = Security.Decrypt(userRow.USER_PASSWORD)
            If userPassword <> password Then
                Return False
            End If

            XL.Common.Utils.Security.SecureID = userRow.SECURE_ID

            If userRow.USER_OPTIONS.Length > 0 Then
                XL.Common.Utils.SysInfo.LoginUserOptions.SetXml(userRow.USER_OPTIONS)
            End If

            If userRow.SECURE_OPTIONS.Length > 0 Then
                XL.Common.Utils.SysInfo.LoginSecureOptions.SetXml(userRow.SECURE_OPTIONS)
            End If

            Return True

        End Function
        Public Shared Sub RemoveUserAccountOccupication(ByVal userName As String)

            MyPosXAuto.TK.ResetConnection()

            Dim userConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_USER(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            userConditions.Add(AfSysConfig.S_USERColumns.USER_ACCOUNTColumn, "=", userName)
            MyPosXAuto.Facade.AfSysConfig.ReviseS_USERData(userConditions, AfSysConfig.S_USERColumns.OWN_IDColumn, 0)

        End Sub
        Public Shared Sub SweapUserAccountOccupication()

            MyPosXAuto.Facade.AfSysConfig.ReviseS_USERData(Nothing, AfSysConfig.S_USERColumns.OWN_IDColumn, 0)

        End Sub

#End Region

#Region "Common item related"

        Public Shared Sub GetCommonItemClassifyList(ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEM_CLASSIFYData(Nothing, sysConfigDataSet)
            result = sysConfigDataSet

        End Sub
        Public Shared Sub CreateCommonItemClassify( _
            ByVal classifyName As String, _
            ByVal classifyType As String, _
            ByVal maintainable As Boolean)

            Dim itemClassifyConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfM_COMMON_ITEM_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            itemClassifyConditions.Add( _
                MyPosXAuto.Facade.AfSysConfig.M_COMMON_ITEM_CLASSIFYColumns.CLASSIFY_NAMEColumn, _
                "=", _
                classifyName)

            Dim itemClassifyRow As MyPosXAuto.FTs.FT_M_COMMON_ITEM_CLASSIFYRow = _
                MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEM_CLASSIFYRow(itemClassifyConditions)

            If IsNothing(itemClassifyRow) = False Then

                MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEM_CLASSIFYInfo( _
                    classifyName, _
                    Nothing, _
                    Nothing, _
                    Nothing, _
                    classifyType, _
                    Nothing, _
                    maintainable, _
                    CommDecl.SYSTEM_TITLE)

            Else

                MyPosXAuto.Facade.AfSysConfig.CreateM_COMMON_ITEM_CLASSIFYInfo( _
                    classifyName, _
                    String.Empty, _
                    String.Empty, _
                    String.Empty, _
                    classifyType, _
                    String.Empty, _
                    maintainable, _
                    CommDecl.SYSTEM_TITLE)

            End If

        End Sub

        Public Shared Sub ReviseCommonItemClassifyInfo(ByVal classifyName As String, ByVal flagClassifyName As String)


            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEM_CLASSIFYInfo( _
                classifyName, _
                Nothing, _
                Nothing, _
                Nothing, _
                Nothing, _
                flagClassifyName, _
                True, _
                CommDecl.SYSTEM_TITLE)

        End Sub

        Public Shared Sub GetCommonItemClassifyInfo(ByVal classifyName As String, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig


            Dim itemClassifyConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfM_COMMON_ITEM_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            itemClassifyConditions.Add(AfSysConfig.M_COMMON_ITEM_CLASSIFYColumns.CLASSIFY_NAMEColumn, "=", classifyName)

            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEM_CLASSIFYData(itemClassifyConditions, sysConfigDataSet)

            If sysConfigDataSet.M_COMMON_ITEM_CLASSIFY.Count = 0 Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(Decls.MSG_OK_00011)
                Throw ex
            End If

            result = sysConfigDataSet

        End Sub
        Public Shared Sub GetCommonItemList(ByVal classifyName As String, ByVal itemFlag As String, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig

            Dim commonItemConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            If classifyName.Length > 0 Then
                commonItemConditions.Add(MyPosXAuto.Facade.AfSysConfig.M_COMMON_ITEMColumns.ITEM_CLASSIFYColumn, "=", classifyName)
            End If
            If itemFlag.Length > 0 Then
                commonItemConditions.Add(MyPosXAuto.Facade.AfSysConfig.M_COMMON_ITEMColumns.ITEM_FLAGColumn, "=", itemFlag)
            End If

            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEMData(commonItemConditions, sysConfigDataSet)

            result = sysConfigDataSet


        End Sub
        Public Shared Sub GetCommonItemClassifyByName( _
            ByVal classifyName As String, _
            ByRef result As MyPosXAuto.SysConfig)


            Dim itemClassifyConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfM_COMMON_ITEM_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            itemClassifyConditions.Add(MyPosXAuto.Facade.AfSysConfig.M_COMMON_ITEM_CLASSIFYColumns.CLASSIFY_NAMEColumn, "=", classifyName)
            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEM_CLASSIFYData(itemClassifyConditions, result)

            If result.M_COMMON_ITEM_CLASSIFY.Count = 0 Then

                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(Decls.MSG_OK_00003)
                Throw ex

            End If

        End Sub
        Public Shared Sub GetCommonItemInfo(ByVal itemID As String, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim sysConfigDataLayer As MyPosXAuto.DataLayer.DLSysConfig = MyPosXAuto.DataLayer.DLSysConfig.GetInstance()

            Dim commonItemConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            commonItemConditions.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_IDColumn, "=", itemID)

            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEMData(commonItemConditions, sysConfigDataSet)
            If sysConfigDataSet.M_COMMON_ITEM.Count = 0 Then

                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(Decls.MSG_OK_00011)
                Throw ex

            End If

            result = sysConfigDataSet

        End Sub

        Public Shared Function IsCommonItemInUse(ByVal itemID As String) As Boolean

            Dim initializor As MyPosXAuto.XDB.DBInitializor = MyPosXAuto.XDB.DBInitializor.GetInstance()

            Return initializor.IsCommonItemInUse(itemID)

        End Function

        Public Shared Sub CreateFixedCommonItem( _
            ByVal classifyName As String, _
            ByVal itemValue As Integer, _
            ByVal itemMeaning As String, _
            ByVal itemFlag As String)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim commonItemConditions As New MyPosXAuto.facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            commonItemConditions.Add(MyPosXAuto.Facade.AfSysConfig.M_COMMON_ITEMColumns.ITEM_CLASSIFYColumn, "=", classifyName)
            commonItemConditions.Add(MyPosXAuto.Facade.AfSysConfig.M_COMMON_ITEMColumns.ITEM_VALUEColumn, "=", itemValue)

            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEMData(commonItemConditions, sysConfigDataSet)

            Dim itemID As String
            If sysConfigDataSet.M_COMMON_ITEM.Count > 0 Then
                itemID = sysConfigDataSet.M_COMMON_ITEM(0).ITEM_ID
                MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEMInfo(itemID, True, classifyName, itemFlag, Nothing, Nothing, itemMeaning, Nothing, Nothing, itemValue)
            Else
                itemID = System.Guid.NewGuid.ToString
                MyPosXAuto.Facade.AfSysConfig.CreateM_COMMON_ITEMInfo(True, classifyName, itemFlag, itemFlag, itemFlag, itemID, itemMeaning, itemMeaning, itemMeaning, itemValue)
            End If

        End Sub




        Public Shared Function CreateCommonItem( _
            ByRef itemID As String, _
            ByVal classifyName As String, _
            ByVal itemMeaning As String, _
            ByVal itemFlag As String, _
            ByVal isReadOnly As Boolean) As Integer

            Dim itemValue As Integer


            Dim sysConfigDataSet As New MyPosXAuto.SysConfig

            Dim commonItemCondition As New MyPosXAuto.Facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            commonItemCondition.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_MEANINGColumn, "=", itemMeaning)
            commonItemCondition.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_CLASSIFYColumn, "=", classifyName)
            commonItemCondition.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_FLAGColumn, "=", itemFlag)

            MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEMData(commonItemCondition, sysConfigDataSet)

            If sysConfigDataSet.M_COMMON_ITEM.Count > 0 Then
                itemValue = sysConfigDataSet.M_COMMON_ITEM(0).ITEM_VALUE
                Return itemValue

            End If

            itemValue = OpSysConfig.GetNewSeedID(String.Format("COMMON_ITEM_{0}", CommTK.GetUrlEncodel(classifyName)))
            itemID = System.Guid.NewGuid.ToString
            AfSysConfig.CreateM_COMMON_ITEMInfo( _
                isReadOnly, _
                classifyName, _
                itemFlag, _
                itemFlag, _
                itemFlag, _
                itemID, _
                itemMeaning, _
                itemMeaning, _
                itemMeaning, _
                itemValue)

            Return itemValue
        End Function
        Public Shared Sub ReviseCommonItemInfo( _
            ByVal itemID As String, _
            ByVal itemMeaning As String, _
            ByVal itemFlag As String, _
            ByVal isReadOnly As Boolean)


            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEMInfo( _
                itemID, _
                isReadOnly, _
                Nothing, _
                itemFlag, _
                Nothing, _
                Nothing, _
                itemMeaning, _
                Nothing, _
                Nothing, _
                CommDecl.NULL_INTEGER)

        End Sub
        Public Shared Sub ReviseCommonClassifyLanguage( _
                    ByVal classifyName As String, _
                    ByVal classifyNameEn As String, _
                    ByVal classifyNameJp As String)


            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEM_CLASSIFYRow( _
                 classifyName, _
                 AfSysConfig.M_COMMON_ITEM_CLASSIFYColumns.CLASSIFY_NAME_ENColumn, _
                 classifyNameEn)

            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEM_CLASSIFYRow( _
                 classifyName, _
                 AfSysConfig.M_COMMON_ITEM_CLASSIFYColumns.CLASSIFY_NAME_JPColumn, _
                 classifyNameJp)

        End Sub
        Public Shared Sub ReviseCommonItemMeaningLanguageByID( _
            ByVal itemID As String, _
            ByVal itemMeaningEn As String, _
            ByVal itemMeaningJp As String)


            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEMRow( _
                 itemID, _
                 AfSysConfig.M_COMMON_ITEMColumns.ITEM_MEANING_ENColumn, _
                 itemMeaningEn)

            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEMRow( _
                 itemID, _
                 AfSysConfig.M_COMMON_ITEMColumns.ITEM_MEANING_JPColumn, _
                 itemMeaningJp)

        End Sub

        Public Shared Sub ReviseCommonItemMeaningLanguageByCV( _
            ByVal classifyName As String, _
            ByVal itemValue As Integer, _
            ByVal itemMeaningEn As String, _
            ByVal itemMeaningJp As String)

            Dim itemConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            itemConditions.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_CLASSIFYColumn, " = ", classifyName)
            itemConditions.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_VALUEColumn, " = ", itemValue)

            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEMData( _
                 itemConditions, _
                 AfSysConfig.M_COMMON_ITEMColumns.ITEM_MEANING_ENColumn, _
                 itemMeaningEn)

            MyPosXAuto.Facade.AfSysConfig.ReviseM_COMMON_ITEMData( _
                 itemConditions, _
                 AfSysConfig.M_COMMON_ITEMColumns.ITEM_MEANING_JPColumn, _
                 itemMeaningJp)

        End Sub
        Public Shared Sub GetCommonItemFlagList(ByVal classifyName As String, ByRef result As DataSet)

            Dim mvDataSet As New MyPosXAuto.MV
            Dim commonItemFlagConditions As New MyPosXAuto.Facade.AfMV.ConditionOfMV_COMMON_ITEM_FLAG(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            commonItemFlagConditions.Add(AfMV.MV_COMMON_ITEM_FLAGColumns.ITEM_CLASSIFYColumn, "=", classifyName)
            AfMV.GetMV_COMMON_ITEM_FLAGData(commonItemFlagConditions, mvDataSet)

            result = mvDataSet


        End Sub
        Public Shared Sub DeleteCommonItemClassifyAndItemExcludingNames(ByVal excludingNameList As ArrayList)

            Dim commonItemClassifyConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfM_COMMON_ITEM_CLASSIFY(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            commonItemClassifyConditions.Add(AfSysConfig.M_COMMON_ITEM_CLASSIFYColumns.CLASSIFY_NAMEColumn, False, excludingNameList)

            MyPosXAuto.Facade.AfSysConfig.DeleteM_COMMON_ITEM_CLASSIFYData(commonItemClassifyConditions)

            Dim commonItemConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            commonItemConditions.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_CLASSIFYColumn, False, excludingNameList)

            MyPosXAuto.Facade.AfSysConfig.DeleteM_COMMON_ITEMData(commonItemConditions)

        End Sub
        Public Shared Sub DeleteCommonItemOfClassifyExcludingValues(ByVal classifyName As String, ByVal itemValueLists As ArrayList)

            Dim commonItemConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfM_COMMON_ITEM(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)
            commonItemConditions.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_CLASSIFYColumn, " =", classifyName)
            commonItemConditions.Add(AfSysConfig.M_COMMON_ITEMColumns.ITEM_VALUEColumn, False, itemValueLists)

            MyPosXAuto.Facade.AfSysConfig.DeleteM_COMMON_ITEMData(commonItemConditions)

        End Sub

        Public Shared Sub DeleteCommonItem(ByVal itemID As String)

            Dim itemRow As MyPosXAuto.FTs.FT_M_COMMON_ITEMRow = _
                MyPosXAuto.Facade.AfSysConfig.GetM_COMMON_ITEMRow(itemID)

            If IsNothing(itemRow) = True Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(CommDecl.MSG_ALERT_COMMON_ITEM_NOT_EXIST)
                Throw ex
            End If


            If itemRow.IS_READONLY = True Then
                Dim ex As New XLException(XLException.ErrorClassify.ReadDataError)
                ex.SetMessage(CommDecl.MSG_ALERT_COMMON_ITEM_IS_READONLY)
                Throw ex
            End If

            MyPosXAuto.Facade.AfSysConfig.DeleteM_COMMON_ITEMInfo(itemID)

        End Sub
#End Region

#Region "Log related"

        Public Shared Sub CreateLog(ByVal title As String, ByVal content As String)


            MyPosXAuto.Facade.AfSysConfig.CreateS_LOGInfo( _
                content, _
                CommDecl.SYSTEM_CURRENT_MACHINE_NAME, _
                DateTime.Now, _
                System.Guid.NewGuid.ToString, _
                title)

        End Sub

        Public Shared Sub DeleteLogData(ByVal dateFrom As DateTime, ByVal dateTo As DateTime)

            Dim logConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_LOG(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            If dateFrom <> CommDecl.NULL_DATE Then
                logConditions.Add(AfSysConfig.S_LOGColumns.CREATE_TIMEColumn, ">=", dateFrom)
            End If

            If dateTo <> CommDecl.NULL_DATE Then
                logConditions.Add(AfSysConfig.S_LOGColumns.CREATE_TIMEColumn, "<=", dateTo)
            End If

            MyPosXAuto.Facade.AfSysConfig.DeleteS_LOGData(logConditions)

        End Sub

        Public Shared Sub DeleteLogInfo(ByVal logID As String)

            MyPosXAuto.Facade.AfSysConfig.DeleteS_LOGInfo(logID)

        End Sub

        Public Shared Sub GetLogInfo(ByVal logID As String, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim logConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_LOG(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            logConditions.Add(AfSysConfig.S_LOGColumns.LOG_IDColumn, "=", logID)

            MyPosXAuto.Facade.AfSysConfig.GetS_LOGData(logConditions, sysConfigDataSet)

            result = sysConfigDataSet

        End Sub
        Public Shared Sub GetLogList(ByVal dateFrom As DateTime, ByVal dateTo As DateTime, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim logConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_LOG(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            If dateFrom <> CommDecl.NULL_DATE Then
                logConditions.Add(AfSysConfig.S_LOGColumns.CREATE_TIMEColumn, ">=", dateFrom)
            End If

            If dateTo <> CommDecl.NULL_DATE Then
                logConditions.Add(AfSysConfig.S_LOGColumns.CREATE_TIMEColumn, "<=", dateTo)
            End If

            MyPosXAuto.Facade.AfSysConfig.GetS_LOGData(logConditions, sysConfigDataSet)

            result = sysConfigDataSet

        End Sub

        Public Shared Sub GetInformMessageInfo(ByVal InformMessageID As String, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim informMessageConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_SYS_INFORM_REPO(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            InformMessageConditions.Add(AfSysConfig.S_SYS_INFORM_REPOColumns.INFORM_IDColumn, "=", InformMessageID)

            MyPosXAuto.Facade.AfSysConfig.GetS_SYS_INFORM_REPOData(InformMessageConditions, sysConfigDataSet)

            result = sysConfigDataSet

        End Sub

        Public Shared Sub GetInformMessageList(ByVal dateFrom As DateTime, ByVal dateTo As DateTime, ByRef result As DataSet)

            Dim sysConfigDataSet As New MyPosXAuto.SysConfig
            Dim informMessageConditions As New MyPosXAuto.Facade.AfSysConfig.ConditionOfS_SYS_INFORM_REPO(XL.DB.Utils.ConditionBuilder.LogicOperators.Logic_And)

            If dateFrom <> CommDecl.NULL_DATE Then
                informMessageConditions.Add(AfSysConfig.S_SYS_INFORM_REPOColumns.DSR_LAST_UPDATE_TIMEColumn, ">=", dateFrom)
            End If

            If dateTo <> CommDecl.NULL_DATE Then
                informMessageConditions.Add(AfSysConfig.S_SYS_INFORM_REPOColumns.DSR_LAST_UPDATE_TIMEColumn, "<=", dateTo)
            End If

            MyPosXAuto.Facade.AfSysConfig.GetS_SYS_INFORM_REPOData(InformMessageConditions, sysConfigDataSet)

            result = sysConfigDataSet

        End Sub

#End Region

        Public Shared Function CreateInformMessage( _
            ByVal sendDueTime As DateTime, _
            ByVal receiverEmailAddresses As String, _
            ByVal emailSubject As String, _
            ByVal emailBody As String, _
            ByVal receiverCellPhones As String, _
            ByVal smsContent As String, _
            ByVal createMachine As String, _
            ByVal ParamArray smsContentValues As String()) As String

            Dim informID As String = System.Guid.NewGuid.ToString()
            MyPosXAuto.Facade.AfSysConfig.CreateS_SYS_INFORM_REPOInfo( _
                emailBody, _
                False, _
                emailSubject, _
                informID, _
                receiverCellPhones, _
                receiverEmailAddresses, _
                sendDueTime, _
                createMachine, _
                OpSysConfig.GetServerTime, _
                CommTK.GetStringSubstituted(smsContent, smsContentValues), _
                False, _
                CommDecl.SYSTEM_TITLE)

            Return informID

        End Function

        Public Shared Sub RenewInformMessage(ByVal informID As String)

            MyPosXAuto.Facade.AfSysConfig.ReviseS_SYS_INFORM_REPORow(informID, AfSysConfig.S_SYS_INFORM_REPOColumns.EMAIL_SENTColumn, False)
            MyPosXAuto.Facade.AfSysConfig.ReviseS_SYS_INFORM_REPORow(informID, AfSysConfig.S_SYS_INFORM_REPOColumns.SMS_SENTColumn, False)

        End Sub

        Public Shared Function GetLatestSeedID(ByVal seedName As String) As Integer

            Dim SysConfigDataLayer As MyPosXAuto.DataLayer.EDLSysConfig = MyPosXAuto.DataLayer.EDLSysConfig.GetInstance()
            Return SysConfigDataLayer.GetLatestSeedID(seedName)

        End Function

        Public Shared Function GetNewSeedID(ByVal seedName As String) As Integer

            Dim SysConfigDataLayer As MyPosXAuto.DataLayer.EDLSysConfig = MyPosXAuto.DataLayer.EDLSysConfig.GetInstance()
            Return SysConfigDataLayer.GetNewSeedID(seedName)

        End Function


    End Class

End Namespace

