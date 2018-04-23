Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Media

Namespace CustomMapColorizer
	Public NotInheritable Class ColorGenerator
		Private Shared colorsPopulation() As RangeColor = { New RangeColor(200000, 1400000, Color.FromArgb(255, &HA8, &H3A, &H78)), New RangeColor(34000, 200000, Color.FromArgb(255, &HBF, &H51, &H8F)), New RangeColor(22000, 34000, Color.FromArgb(255, &HD2, &H64, &HA2)), New RangeColor(12700, 22000, Color.FromArgb(255, &HE2, &H74, &HB2)), New RangeColor(9200, 12700, Color.FromArgb(255, &HF1, &H83, &HC1)), New RangeColor(6200, 9200, Color.FromArgb(255, &HFD, &H8F, &HCD)), New RangeColor(4200, 6200, Color.FromArgb(255, &HFF, &HAB, &HDA)), New RangeColor(2200, 4200, Color.FromArgb(255, &HFF, &HC1, &HE4)), New RangeColor(650, 2200, Color.FromArgb(255, &HFF, &HD1, &HEA)), New RangeColor(-100, 650, Color.FromArgb(255, &HFF, &HDF, &HF1))}

		Private Sub New()
		End Sub
		Public Shared Function GetColorByPopulation(ByVal population As Integer) As Color
			For Each rangePopulation As RangeColor In colorsPopulation
				If population >= rangePopulation.RangeMin * 1000 AndAlso population < rangePopulation.RangeMax * 1000 Then
					Return rangePopulation.Fill
				End If
			Next rangePopulation
			Return Color.FromArgb(255, 255, 255, 255)
		End Function
	End Class
End Namespace

