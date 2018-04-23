' Developer Express Code Central Example:
' How to create a DXRibbonWindow
' 
' This example shows how to create a DXRibbonWindow and add a RibbonControl to the
' window.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2186


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Ribbon

Namespace DXRibbonWindow_Ex
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DXRibbonWindow
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
