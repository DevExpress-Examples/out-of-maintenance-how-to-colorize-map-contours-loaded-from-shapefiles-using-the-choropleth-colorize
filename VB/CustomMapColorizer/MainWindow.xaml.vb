Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Media
Imports DevExpress.Xpf.Map

Namespace CustomMapColorizer
	Partial Public Class MainWindow
		Inherits Window
		Private loadedShapes As List(Of MapItem)
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ShapefileLoader_ShapesLoaded(ByVal sender As Object, ByVal e As ShapesLoadedEventArgs)
			loadedShapes = e.Shapes
			PrepareShapesByPopulation()
		End Sub
		Private Sub PrepareShapesByPopulation()
			If loadedShapes IsNot Nothing Then
				For Each item As MapItem In loadedShapes
					Dim shape As MapShape = TryCast(item, MapShape)
					shape.Fill = New SolidColorBrush(ColorGenerator.GetColorByPopulation(Convert.ToInt32(CDbl(item.Attributes("POP_EST").Value))))
				Next item
			End If
		End Sub
	End Class
End Namespace
