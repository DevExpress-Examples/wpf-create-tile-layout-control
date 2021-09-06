Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Media
Imports System.Windows.Media.Imaging

Namespace WpfApplication2

	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Public ReadOnly Property Agents() As List(Of Agent)
			Get
				Return WpfApplication2.Agents.DataSource
			End Get
		End Property
	End Class

	Public Class Agent
		Public Property AgentName() As String
		Public Property Phone() As String
		Public Property Photo() As String
		Public ReadOnly Property PhotoSource() As ImageSource
			Get
				Return If(String.IsNullOrEmpty(Photo), Nothing, New BitmapImage(New Uri(Photo, UriKind.Relative)))
			End Get
		End Property
	End Class

	Public Module Agents
		Public ReadOnly DataSource As New List(Of Agent) From {
			New Agent With {
				.AgentName = "Anthony Peterson",
				.Phone = "(555) 444-0782",
				.Photo = "Images/1.jpg"
			},
			New Agent With {
				.AgentName = "Rachel Scott",
				.Phone = "(555) 249-1614",
				.Photo = "Images/2.jpg"
			},
			New Agent With {
				.AgentName = "Albert Walker",
				.Phone = "(555) 232-2303",
				.Photo = "Images/3.jpg"
			}
		}
	End Module
End Namespace
