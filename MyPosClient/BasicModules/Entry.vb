Imports XL.Common
Imports XL.Common.Utils
Imports XL.Win
Imports XL.Win.Utils
Imports System.Globalization
Imports System.Threading
Imports System.Diagnostics

Namespace Utils

    Public Class Entry

        '   
        'This object is just to avoid multi launch
        '   
        Private Shared _mutexObject As Mutex


        Public Shared Sub Main()


            Try


                'Length of System title must be over 10 Chars, Space bar is allowed
                XL.Common.CommDecl.SYSTEM_TITLE = "Softland My Pos"
                XL.Common.CommDecl.SYSTEM_MODE = SystemModes.Standard
                XL.Common.CommDecl.SYSTEM_REG_KEY = "fjp29jfp.qfcj"
                CommDecl.SYSTEM_SHOULD_BE_ONLINE = False
                WinDecl.SYSTEM_CLIENT_OUT_OF_DATE_UPGRADE_FORCED = True

                XL.Common.Utils.SysInfo.SetLocalTRSysInfo(AddressOf WinTK.GetSysConfig, AddressOf WinTK.SetSysConfig)
                XL.Common.Utils.SysInfo.SetShareTRSysInfo(AddressOf WinTK.GetSysConfig, AddressOf WinTK.SetSysConfig)

                CommDecl.CURRENT_LANGUAGE_OPTION = CommTK.FInteger(SysInfo.ReadLocalSysInfo(CommDecl.XLSSVN_SYSTEM_LANGUAGE))
                Select Case CommDecl.CURRENT_LANGUAGE_OPTION
                    Case CommDecl.LANGUAGE_OPTION_ENGLISH
                        Thread.CurrentThread.CurrentUICulture = New CultureInfo("en")
                    Case CommDecl.LANGUAGE_OPTION_JAPANESE
                        Thread.CurrentThread.CurrentUICulture = New CultureInfo("jp")
                End Select

                Dim currentProcesses As Process() = Process.GetProcesses()
                For Each currentProcess As Process In currentProcesses
                    If currentProcess.ProcessName = "XUpgrador" Then
                        Application.Exit()
                        Return
                    End If
                Next

                '   
                ' Get existing mutex object before me   
                '   
                Entry._mutexObject = New Mutex(False, XL.Common.CommDecl.SYSTEM_TITLE)
            Catch e As ApplicationException

                '   
                ' forbidden multi launching 
                '   
                MessageBox.Show(WinDecl.MSG_ALERT_00001, XL.Common.CommDecl.SYSTEM_TITLE)
                Return
            End Try

            ' 
            ' Single launch regulation start
            ' 
            'If Entry._mutexObject.WaitOne(0, False) = True Then


            '   
            'Do initizlizations on start
            '   
            Entry.DoInitialize()

            '   
            'ready to Show Login  
            Dim splashPath As String = WinTK.GetResourceFilePath(ResourceType.Tool, "Splasher.exe")

            If IO.File.Exists(splashPath) = True Then
                CommTK.LaunchApplication(Nothing, splashPath, True)
            End If
            Application.Run(New Login)

            '   
            ' Release mutex object
            '   
            'Entry._mutexObject.ReleaseMutex()

            'Else

            ''   
            ''    Release the mutex object     
            ''   
            'MessageBox.Show(XL.Win.Globals.MESSAGE_OK_BOX_TEXT_00001, XL.Common.CommDecl.SYSTEM_TITLE)

            ''   
            ''    activate the conflicting application     
            ''   
            'AppActivate(XL.Common.CommDecl.SYSTEM_TITLE)

            'End If

            ' 
            ' Ready to end application
            ' 
            Entry._mutexObject.Close()

            System.Diagnostics.Process.GetCurrentProcess.Kill()
        End Sub


        Public Shared Sub DoInitialize()


        End Sub


    End Class

End Namespace
