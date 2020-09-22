Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace DataUpdatesExample
	Public Class Device
		Implements INotifyPropertyChanged, INotifyPropertyChanging

'INSTANT VB NOTE: The field name was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private name_Conflict As String
'INSTANT VB NOTE: The field group was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private group_Conflict As String
'INSTANT VB NOTE: The field sensor1 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor2 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor3 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor4 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor5 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor6 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor7 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor8 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor9 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor10 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor11 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor12 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor13 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor14 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor15 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor16 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor17 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor18 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor19 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor20 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor21 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor22 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor23 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor24 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor25 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor26 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor27 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor28 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor29 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor30 was renamed since Visual Basic does not allow fields to have the same name as other class members:
'INSTANT VB NOTE: The field sensor31 was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private sensor1_Conflict, sensor2_Conflict, sensor3_Conflict, sensor4_Conflict, sensor5_Conflict, sensor6_Conflict, sensor7_Conflict, sensor8_Conflict, sensor9_Conflict, sensor10_Conflict, sensor11_Conflict, sensor12_Conflict, sensor13_Conflict, sensor14_Conflict, sensor15_Conflict, sensor16_Conflict, sensor17_Conflict, sensor18_Conflict, sensor19_Conflict, sensor20_Conflict, sensor21_Conflict, sensor22_Conflict, sensor23_Conflict, sensor24_Conflict, sensor25_Conflict, sensor26_Conflict, sensor27_Conflict, sensor28_Conflict, sensor29_Conflict, sensor30_Conflict, sensor31_Conflict As Integer
		Private Shared rnd As New Random()

		Public Property Name() As String
			Get
				Return name_Conflict
			End Get
			Set(ByVal value As String)
				RaisePropertyChanging(NameOf(Name))
				name_Conflict = value
				RaisePropertyChanged(NameOf(Name))
			End Set
		End Property
		Public Property Group() As String
			Get
				Return group_Conflict
			End Get
			Set(ByVal value As String)
				RaisePropertyChanging(NameOf(Group))
				group_Conflict = value
				RaisePropertyChanged(NameOf(Group))
			End Set
		End Property
		Public Property Sensor1() As Integer
			Get
				Return sensor1_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor1))
				sensor1_Conflict = value
				RaisePropertyChanged(NameOf(Sensor1))
			End Set
		End Property
		Public Property Sensor2() As Integer
			Get
				Return sensor2_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor2))
				sensor2_Conflict = value
				RaisePropertyChanged(NameOf(Sensor2))
			End Set
		End Property
		Public Property Sensor3() As Integer
			Get
				Return sensor3_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor3))
				sensor3_Conflict = value
				RaisePropertyChanged(NameOf(Sensor3))
			End Set
		End Property
		Public Property Sensor4() As Integer
			Get
				Return sensor4_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor4))
				sensor4_Conflict = value
				RaisePropertyChanged(NameOf(Sensor4))
			End Set
		End Property
		Public Property Sensor5() As Integer
			Get
				Return sensor5_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor5))
				sensor5_Conflict = value
				RaisePropertyChanged(NameOf(Sensor5))
			End Set
		End Property
		Public Property Sensor6() As Integer
			Get
				Return sensor6_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor6))
				sensor6_Conflict = value
				RaisePropertyChanged(NameOf(Sensor6))
			End Set
		End Property
		Public Property Sensor7() As Integer
			Get
				Return sensor7_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor7))
				sensor7_Conflict = value
				RaisePropertyChanged(NameOf(Sensor7))
			End Set
		End Property
		Public Property Sensor8() As Integer
			Get
				Return sensor8_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor8))
				sensor8_Conflict = value
				RaisePropertyChanged(NameOf(Sensor8))
			End Set
		End Property
		Public Property Sensor9() As Integer
			Get
				Return sensor9_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor9))
				sensor9_Conflict = value
				RaisePropertyChanged(NameOf(Sensor9))
			End Set
		End Property
		Public Property Sensor10() As Integer
			Get
				Return sensor10_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor10))
				sensor10_Conflict = value
				RaisePropertyChanged(NameOf(Sensor10))
			End Set
		End Property
		Public Property Sensor11() As Integer
			Get
				Return sensor11_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor11))
				sensor11_Conflict = value
				RaisePropertyChanged(NameOf(Sensor11))
			End Set
		End Property
		Public Property Sensor12() As Integer
			Get
				Return sensor12_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor12))
				sensor12_Conflict = value
				RaisePropertyChanged(NameOf(Sensor12))
			End Set
		End Property
		Public Property Sensor13() As Integer
			Get
				Return sensor13_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor13))
				sensor13_Conflict = value
				RaisePropertyChanged(NameOf(Sensor13))
			End Set
		End Property
		Public Property Sensor14() As Integer
			Get
				Return sensor14_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor14))
				sensor14_Conflict = value
				RaisePropertyChanged(NameOf(Sensor14))
			End Set
		End Property
		Public Property Sensor15() As Integer
			Get
				Return sensor15_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor15))
				sensor15_Conflict = value
				RaisePropertyChanged(NameOf(Sensor15))
			End Set
		End Property
		Public Property Sensor16() As Integer
			Get
				Return sensor16_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor16))
				sensor16_Conflict = value
				RaisePropertyChanged(NameOf(Sensor16))
			End Set
		End Property
		Public Property Sensor17() As Integer
			Get
				Return sensor17_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor17))
				sensor17_Conflict = value
				RaisePropertyChanged(NameOf(Sensor17))
			End Set
		End Property
		Public Property Sensor18() As Integer
			Get
				Return sensor18_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor18))
				sensor18_Conflict = value
				RaisePropertyChanged(NameOf(Sensor18))
			End Set
		End Property
		Public Property Sensor19() As Integer
			Get
				Return sensor19_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor19))
				sensor19_Conflict = value
				RaisePropertyChanged(NameOf(Sensor19))
			End Set
		End Property
		Public Property Sensor20() As Integer
			Get
				Return sensor20_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor20))
				sensor20_Conflict = value
				RaisePropertyChanged(NameOf(Sensor20))
			End Set
		End Property
		Public Property Sensor21() As Integer
			Get
				Return sensor21_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor21))
				sensor21_Conflict = value
				RaisePropertyChanged(NameOf(Sensor21))
			End Set
		End Property
		Public Property Sensor22() As Integer
			Get
				Return sensor22_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor22))
				sensor22_Conflict = value
				RaisePropertyChanged(NameOf(Sensor22))
			End Set
		End Property
		Public Property Sensor23() As Integer
			Get
				Return sensor23_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor23))
				sensor23_Conflict = value
				RaisePropertyChanged(NameOf(Sensor23))
			End Set
		End Property
		Public Property Sensor24() As Integer
			Get
				Return sensor24_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor24))
				sensor24_Conflict = value
				RaisePropertyChanged(NameOf(Sensor24))
			End Set
		End Property
		Public Property Sensor25() As Integer
			Get
				Return sensor25_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor25))
				sensor25_Conflict = value
				RaisePropertyChanged(NameOf(Sensor25))
			End Set
		End Property
		Public Property Sensor26() As Integer
			Get
				Return sensor26_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor26))
				sensor26_Conflict = value
				RaisePropertyChanged(NameOf(Sensor26))
			End Set
		End Property
		Public Property Sensor27() As Integer
			Get
				Return sensor27_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor27))
				sensor27_Conflict = value
				RaisePropertyChanged(NameOf(Sensor27))
			End Set
		End Property
		Public Property Sensor28() As Integer
			Get
				Return sensor28_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor28))
				sensor28_Conflict = value
				RaisePropertyChanged(NameOf(Sensor28))
			End Set
		End Property
		Public Property Sensor29() As Integer
			Get
				Return sensor29_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor29))
				sensor29_Conflict = value
				RaisePropertyChanged(NameOf(Sensor29))
			End Set
		End Property
		Public Property Sensor30() As Integer
			Get
				Return sensor30_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor30))
				sensor30_Conflict = value
				RaisePropertyChanged(NameOf(Sensor30))
			End Set
		End Property
		Public Property Sensor31() As Integer
			Get
				Return sensor31_Conflict
			End Get
			Set(ByVal value As Integer)
				RaisePropertyChanging(NameOf(Sensor31))
				sensor31_Conflict = value
				RaisePropertyChanged(NameOf(Sensor31))
			End Set
		End Property


		Protected Sub RaisePropertyChanged(ByVal propertyName As String)
			PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		Protected Sub RaisePropertyChanging(ByVal propertyName As String)
			PropertyChangingEvent?.Invoke(Me, New PropertyChangingEventArgs(propertyName))
		End Sub

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

		Public Sub SetRandomSensorValues(ByVal all As Boolean)
			Sensor1 = rnd.Next(100, 1000)
			Sensor2 = rnd.Next(100, 1000)
			Sensor3 = rnd.Next(100, 1000)
			If all Then
				Sensor4 = rnd.Next(100, 1000)
				Sensor5 = rnd.Next(100, 1000)
				Sensor6 = rnd.Next(100, 1000)
				Sensor7 = rnd.Next(100, 1000)
				Sensor8 = rnd.Next(100, 1000)
				Sensor9 = rnd.Next(100, 1000)
				Sensor10 = rnd.Next(100, 1000)
				Sensor11 = rnd.Next(100, 1000)
				Sensor12 = rnd.Next(100, 1000)
				Sensor13 = rnd.Next(100, 1000)
				Sensor14 = rnd.Next(100, 1000)
				Sensor15 = rnd.Next(100, 1000)
				Sensor16 = rnd.Next(100, 1000)
				Sensor17 = rnd.Next(100, 1000)
				Sensor18 = rnd.Next(100, 1000)
				Sensor19 = rnd.Next(100, 1000)
				Sensor20 = rnd.Next(100, 1000)
				Sensor21 = rnd.Next(100, 1000)
				Sensor22 = rnd.Next(100, 1000)
				Sensor23 = rnd.Next(100, 1000)
				Sensor25 = rnd.Next(100, 1000)
				Sensor26 = rnd.Next(100, 1000)
				Sensor27 = rnd.Next(100, 1000)
				Sensor28 = rnd.Next(100, 1000)
				Sensor29 = rnd.Next(100, 1000)
				Sensor30 = rnd.Next(100, 1000)
				Sensor31 = rnd.Next(100, 1000)
			End If
		End Sub
	End Class
End Namespace
