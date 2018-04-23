Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Media

Namespace CustomMapColorizer
	Public Class RangeColor
		Private ReadOnly rangeMin_Renamed As Integer
		Private ReadOnly rangeMax_Renamed As Integer
		Private ReadOnly fill_Renamed As Color

		Public ReadOnly Property RangeMin() As Integer
			Get
				Return rangeMin_Renamed
			End Get
		End Property
		Public ReadOnly Property RangeMax() As Integer
			Get
				Return rangeMax_Renamed
			End Get
		End Property
		Public ReadOnly Property Fill() As Color
			Get
				Return fill_Renamed
			End Get
		End Property

		Public Sub New(ByVal rangeMin As Integer, ByVal rangeMax As Integer, ByVal fill As Color)
			Me.rangeMin_Renamed = rangeMin
			Me.rangeMax_Renamed = rangeMax
			Me.fill_Renamed = fill
		End Sub
	End Class
End Namespace

