Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils

Namespace Utils

    Public Class Login
        Inherits XL.Win.Window.BaseLoginForm


#Region " Windows auto generated code"

        Public Sub New()
            MyBase.New()

            '该调用是 Windows 窗体设计器所必需的。
            InitializeComponent()

            '在 InitializeComponent() 调用之后添加任何初始化

        End Sub

        '窗体重写 dispose 以清理组件列表。
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub
        Private components As System.ComponentModel.IContainer

        'Windows 窗体设计器所必需的

        '注意: 以下过程是 Windows 窗体设计器所必需的
        '可以使用 Windows 窗体设计器修改此过程。
        '不要使用代码编辑器修改它。
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Me.Label4 = New System.Windows.Forms.Label
            CType(Me.TextEdit_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Label_Title
            '
            Me.Label_Title.Visible = False
         
            '
            'TextEdit_Password
            '
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.Transparent
            Me.Label4.Font = New System.Drawing.Font("SimHei", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            Me.Label4.Location = New System.Drawing.Point(152, 136)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(272, 32)
            Me.Label4.TabIndex = 11
            Me.Label4.Text = "Sub System Title"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
            '
            'Login
            '
            Me.AcceptButton = Me.SimpleButton_Login
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
            Me.BackColor = System.Drawing.Color.WhiteSmoke
            Me.ClientSize = New System.Drawing.Size(584, 322)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Login"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.TextEdit_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Protected Overrides Sub DoInitialize()

            WinDecl.UPGRADE_FILE_LIST.Add("MyPosClient.exe")
            WinDecl.UPGRADE_FILE_LIST.Add("MyPosXAuto.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("MyPosXService.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("XL.Common.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("XL.DB.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("XL.Win.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("office.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("en/MyPosClient.resources.dll")
            WinDecl.UPGRADE_FILE_LIST.Add("en/XL.Win.resources.dll")
            WinDecl.UPGRADE_RELAUNCH_FILENAME = "MyPosClient.exe"
            SysInfo.SYS_LM = 2000

            If XL.Common.CommDecl.SYSTEM_MODE <> SystemModes.StandardNoDB AndAlso _
               XL.Common.CommDecl.SYSTEM_MODE <> SystemModes.StandardNoDBNoLogin AndAlso _
               XL.Common.CommDecl.SYSTEM_MODE <> SystemModes.Demo Then

                XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf MyPosXService.Facade.OpSysConfig.GetSysValue, AddressOf MyPosXService.Facade.OpSysConfig.SetSysValue)
                MyPosXAuto.XDB.DBInitializor.InitCommonItemTableFields()
                MyPosXAuto.TK.SetUniqueContraints()
                MyPosXAuto.XDB.DBInitializor.InitBelongTableFields()
                MyPosXAuto.Decls.LOCAL_CACHE_DATA_PATH = WinTK.GetResourceFilePath(ResourceType.Data, String.Empty)

                XL.DB.DBDecl.InUseInfoDeletable = True

            End If

            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.EDLMP))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.EDLSysConfig))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.EDLBizTurnover))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizConfig))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizHistory))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizInventory))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizLink))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizLocation))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizManage))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizMaster))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLBizTurnover))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLCIV))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLMP))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLMV))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLSysConfig))
            WinTK.RegisterRemoteType(GetType(MyPosXAuto.DataLayer.DLXV))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00101))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00102))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00103))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00201))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00202))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00203))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00204))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00205))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00206))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00301))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00302))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00303))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00304))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00401))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00402))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00404))
            'WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00501))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00601))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00602))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00603))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00801))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00802))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00803))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00804))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00901))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_00902))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_01001))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_01002))
            'WinTK.RegisterRemoteType(GetType(MyPosXService.S_01_01003))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00101))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00102))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00103))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00104))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00105))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00106))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00107))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00108))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00109))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00110))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00111))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00201))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00202))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00203))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00204))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00301))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00302))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00401))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00402))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00501))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00601))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00602))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00603))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00604))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00701))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00801))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00802))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00901))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_00902))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01001))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01002))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01101))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01201))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01301))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01302))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01303))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_02_01304))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00101))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00102))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00103))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00201))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00301))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00302))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00401))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00501))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00601))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00701))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00702))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00801))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_00901))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01001))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01002))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01101))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01201))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01301))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01401))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01501))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_03_01601))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_08_00101))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_08_00201))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_08_00301))
            WinTK.RegisterRemoteType(GetType(MyPosXService.S_08_00401))

            WinTK.RegisterRemoteType(GetType(MyPosXAuto.XDB.DBInitializor))
            WinTK.RegisterRemoteType(GetType(MyPosXService.ServiceTK))


            System.Runtime.Remoting.RemotingConfiguration.CustomErrorsMode = System.Runtime.Remoting.CustomErrorsModes.Off
            System.Runtime.Remoting.RemotingConfiguration.CustomErrorsEnabled(False)

            CommDecl.SYSTEM_START_RUNNING_TIME = MyPosXService.Facade.OpSysConfig.GetServerTime()
            CommDecl.SYSTEM_IS_ONLINE = True
            Me.ShowStatusMessage(MyPosXService.Decls.MSG_STATUS_0017)
            TK.DownloadCacheData()
        

            Utils.Decls.CURRENT_POS_ROW = MyPosXAuto.Facade.AfBizMaster.GetM_MP_POSRow(SysInfo.ReadLocalSysInfo(MyPosXService.Decls.LVN_CURRENT_POS_ID))

        End Sub


        Protected Overrides Function AttempHandleLoginException(ByVal ex As Exception) As String

            CommDecl.SYSTEM_IS_ONLINE = False
            Return MyPosXService.Decls.MSG_STATUS_0018

        End Function

        Protected Overrides Sub BeforeLogin()
            Utils.TK.InitDefaultData()

        End Sub

        Protected Overrides Sub AfterLogin()



            MyPosXAuto.Facade.AfBizMaster.FillM_STAFFRowSEntity( _
                Utils.Decls.LOGIN_STAFF_ROW_SE, _
                SysInfo.LoginUserOptions.Options(Utils.UserOptionsBox.OPN_STAFF_ID))


            'Utils.TK.GetBarcodeOrder()


        End Sub

        Protected Overrides Sub DoSetMainForm()

            Me._baseMainForm = New MainForm

        End Sub

        Protected Overrides Sub DoUpgradeXDB()

            Dim dbInitializor As MyPosXAuto.XDB.DBInitializor
            If MyPosXAuto.Decls.CURRENT_DB_TYPE <> XL.DB.DBDecl.DBType.Remoting Then
                dbInitializor = New MyPosXAuto.XDB.DBInitializor
            Else
                dbInitializor = CType(Activator.GetObject(GetType(MyPosXAuto.XDB.DBInitializor), _
                    String.Format("tcp://{0}/DBInitializor.remote", _
                        SysInfo.ReadLocalSysInfo(CommDecl.XLSLVN_SYSTEM_REMOTE_SERVICE_URL))), MyPosXAuto.XDB.DBInitializor)
            End If

            dbInitializor.DoInitialize(True, False)

            MyPosXAuto.Decls.CONNECTION_STRING = XL.DB.DBDecl.CurrentConnectionString
            MyPosXAuto.Decls.CURRENT_DB_TYPE = XL.DB.DBDecl.CurrentDatabaseType
            MyPosXAuto.Decls.REMOTE_DB_TYPE = XL.DB.DBDecl.CurrentDatabaseType

            XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf MyPosXService.Facade.OpSysConfig.GetSysValue, AddressOf MyPosXService.Facade.OpSysConfig.SetSysValue)

        End Sub

        Protected Overrides Sub DoSetXFormTransaction()

            Me._trWriteSysInfo = AddressOf MyPosXService.Facade.OpSysConfig.SetSysValue
            Me._trReadSysInfo = AddressOf MyPosXService.Facade.OpSysConfig.GetSysValue

            XL.Win.XForm.XFormTK.SetTrGetSecureRow(AddressOf MyPosXService.Facade.OpSysConfig.GetSecureRow)
            XL.Win.XForm.XFormTK.SetTrGetSecureList(AddressOf MyPosXService.Facade.OpSysConfig.GetSecureList)
            XL.Win.XForm.XFormTK.SetTrCreateSecureInfo(AddressOf MyPosXService.Facade.OpSysConfig.CreateSecureInfo)
            XL.Win.XForm.XFormTK.SetTrReviseSecureInfo(AddressOf MyPosXService.Facade.OpSysConfig.ReviseSecureInfo)
            XL.Win.XForm.XFormTK.SetTrDeleteSecureInfo(AddressOf MyPosXService.Facade.OpSysConfig.DeleteSecureInfo)

            XL.Win.XForm.XFormTK.SetTrGetUserRow(AddressOf MyPosXService.Facade.OpSysConfig.GetUserRow)
            XL.Win.XForm.XFormTK.SetTrGetUserList(AddressOf MyPosXService.Facade.OpSysConfig.GetUserList)
            XL.Win.XForm.XFormTK.SetTrCreateUserInfo(AddressOf MyPosXService.Facade.OpSysConfig.CreateUserInfo)
            XL.Win.XForm.XFormTK.SetTrReviseUserInfo(AddressOf MyPosXService.Facade.OpSysConfig.ReviseUserInfo)
            XL.Win.XForm.XFormTK.SetTrDeleteUserInfo(AddressOf MyPosXService.Facade.OpSysConfig.DeleteUserInfo)

            XL.Win.XForm.XFormTK.SetTrValidateUserPassword(AddressOf MyPosXService.Facade.OpSysConfig.ValidateUserPassword)
            XL.Win.XForm.XFormTK.SetTrValidateUserNamePassword(AddressOf MyPosXService.Facade.OpSysConfig.ValidateUserNamePassword)

            XL.Win.XForm.XFormTK.SetTrReviseCommonItemClassifyInfo(AddressOf MyPosXService.Facade.OpSysConfig.ReviseCommonItemClassifyInfo)
            XL.Win.XForm.XFormTK.SetTrCreateCommonItem(AddressOf MyPosXService.Facade.OpSysConfig.CreateCommonItem)
            XL.Win.XForm.XFormTK.SetTrReviseCommonItem(AddressOf MyPosXService.Facade.OpSysConfig.ReviseCommonItemInfo)
            XL.Win.XForm.XFormTK.SetTrIsCommonItemInUse(AddressOf MyPosXService.Facade.OpSysConfig.IsCommonItemInUse)
            XL.Win.XForm.XFormTK.SetTrGetCommonItemList(AddressOf MyPosXService.Facade.OpSysConfig.GetCommonItemList)
            XL.Win.XForm.XFormTK.SetTRGetCommonItemClassifyRow(AddressOf MyPosXService.Facade.OpSysConfig.GetCommonItemClassifyRow)
            XL.Win.XForm.XFormTK.SetTrGetCommonItemClassifyList(AddressOf MyPosXService.Facade.OpSysConfig.GetCommonItemClassifyList)
            XL.Win.XForm.XFormTK.SetTrDeleteCommonItem(AddressOf MyPosXService.Facade.OpSysConfig.DeleteCommonItem)
            XL.Win.XForm.XFormTK.SetTrGetCommonItemRow(AddressOf MyPosXService.Facade.OpSysConfig.GetCommonItemRow)
            XL.Win.XForm.XFormTK.SetTrCreateCommonItemClassify(AddressOf MyPosXService.Facade.OpSysConfig.CreateCommonItemClassify)
            XL.Win.XForm.XFormTK.SetTrCreateFixedCommonItem(AddressOf MyPosXService.Facade.OpSysConfig.CreateFixedCommonItem)
            XL.Win.XForm.XFormTK.SetTrGetCommonItemFlagList(AddressOf MyPosXService.Facade.OpSysConfig.GetCommonItemFlagList)
            XL.Win.XForm.XFormTK.SetTrDeleteCommonItemClassifyAndItemExcludingNames(AddressOf MyPosXService.Facade.OpSysConfig.DeleteCommonItemClassifyAndItemExcludingNames)
            XL.Win.XForm.XFormTK.SetTrDeleteCommonItemOfClassifyExcludingValues(AddressOf MyPosXService.Facade.OpSysConfig.DeleteCommonItemOfClassifyExcludingValues)
            XL.Win.XForm.XFormTK.SetTrAttemptCreateDefaultAuthority(AddressOf MyPosXService.Facade.OpSysConfig.AttemptCreateDefaultAuthority)
            XL.Win.XForm.XFormTK.SetTrGetSuperSecureID(AddressOf MyPosXService.Facade.OpSysConfig.GetSuperSecureID)

            XL.Win.XForm.XFormTK.SetTrReviseCommonItemMeaningLanguageByID(AddressOf MyPosXService.Facade.OpSysConfig.ReviseCommonItemMeaningLanguageByID)
            XL.Win.XForm.XFormTK.SetTrReviseCommonItemMeaningLanguagebyCV(AddressOf MyPosXService.Facade.OpSysConfig.ReviseCommonItemMeaningLanguageByCV)
            XL.Win.XForm.XFormTK.SetTrReviseCommonClassifyLanguage(AddressOf MyPosXService.Facade.OpSysConfig.ReviseCommonClassifyLanguage)

            XL.Win.XForm.XFormTK.SetTrCreateLog(AddressOf MyPosXService.Facade.OpSysConfig.CreateLog)
            XL.Win.XForm.XFormTK.SetTrCreateLog(AddressOf MyPosXService.Facade.OpSysConfig.CreateLog)
            XL.Win.XForm.XFormTK.SetTrDeleteLogData(AddressOf MyPosXService.Facade.OpSysConfig.DeleteLogData)
            XL.Win.XForm.XFormTK.SetTrDeleteLogInfo(AddressOf MyPosXService.Facade.OpSysConfig.DeleteLogInfo)
            XL.Win.XForm.XFormTK.SetTrGetLogRow(AddressOf MyPosXService.Facade.OpSysConfig.GetLogRow)
            XL.Win.XForm.XFormTK.SetTrGetLogList(AddressOf MyPosXService.Facade.OpSysConfig.GetLogList)
            XL.Win.XForm.XFormTK.SetTRExportLogExcel(AddressOf Utils.TK.ExportSLog)

            XL.Win.XForm.XFormTK.SetTrRemoveUserAccountOccupication(AddressOf MyPosXService.Facade.OpSysConfig.RemoveUserAccountOccupication)
            XL.Win.XForm.XFormTK.SetTrSweapUserAccountOccupication(AddressOf MyPosXService.Facade.OpSysConfig.SweapUserAccountOccupication)

            XL.Win.XForm.XFormTK.SetTrGetUserOptionsBox(AddressOf Utils.TK.GetUserOptionsBox)
            XL.Win.XForm.XFormTK.SetTrGetSecureOptionsBox(AddressOf Utils.TK.GetSecureOptionsBox)

            XL.Win.XForm.XFormTK.SetTrGetInformMessageRow(AddressOf MyPosXService.Facade.OpSysConfig.GetInformMessageRow)
            XL.Win.XForm.XFormTK.SetTrGetInformMessageList(AddressOf MyPosXService.Facade.OpSysConfig.GetInformMessageList)
            XL.Win.XForm.XFormTK.SetTrRenewInformMessage(AddressOf MyPosXService.Facade.OpSysConfig.RenewInformMessage)


        End Sub

    End Class

End Namespace
