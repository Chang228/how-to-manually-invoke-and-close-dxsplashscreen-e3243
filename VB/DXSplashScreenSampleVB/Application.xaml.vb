﻿' Developer Express Code Central Example:
' How to manually invoke and close DXSplashScreen
' 
' This example shows how to manually invoke and close DXSplashScreen. By default,
' DXSplashScreen contains a progress bar, indicating the progress of the
' application load. This example also shows how you can manually change the
' progress in code.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3243

Imports System.Windows
Imports DevExpress.Xpf.Core

Namespace DXSplashScreenSample
    Partial Public Class App
        Inherits Application
        Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
            MyBase.OnStartup(e)
            DXSplashScreen.Show(Of SplashScreenView)()
        End Sub
    End Class
End Namespace