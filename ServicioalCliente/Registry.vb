Imports Microsoft.Win32
Public Class Reg
    Shared Sub SaveSetting(ByVal appName As String, ByVal section As String, ByVal key As String, ByVal setting As String)
        'Los datos se guardan en:
        'HKEY_CURRENT_USER\Software\VB and VBA Program Settings
        Dim rk As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\VB and VBA Program Settings\" + appName + "\\" + section)
        rk.SetValue(key, setting)
    End Sub
    Shared Function GetSetting(ByVal appName As String, ByVal section As String, ByVal key As String) As String
        Return GetSetting(appName, section, key, "")
    End Function
    Shared Function GetSetting(ByVal appName As String, ByVal section As String, ByVal key As String, ByVal sDefault As String) As String
        Dim rk As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\VB and VBA Program Settings\" + appName + "\\" + section)
        Dim s As String = sDefault
        If Not (rk Is Nothing) Then
            s = CType(rk.GetValue(key), String)
        End If
        Return s
    End Function
End Class
