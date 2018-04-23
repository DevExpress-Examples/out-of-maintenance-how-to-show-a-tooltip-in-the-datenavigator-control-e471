Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Calendar
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler

Namespace SchedulerTooltip
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
			Me.carSchedulingTableAdapter.Fill(Me.carsDBDataSet.CarScheduling)

		End Sub

		Private selectedDate As DateTime = DateTime.MinValue
		Private Sub dateNavigator1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dateNavigator1.MouseMove
			Dim chi As CalendarHitInfo = dateNavigator1.GetHitInfo(dateNavigator1.PointToClient(Form1.MousePosition))

			If chi.HitObject IsNot Nothing Then
				Dim [date] As String = chi.HitDate.ToString()
				Dim sTooltip1 As SuperToolTip = GetToolTipInfo(chi)
				Dim ttci As New ToolTipControlInfo()

				ttci.ToolTipType = ToolTipType.SuperTip
				ttci.SuperTip = sTooltip1
				ttci.ToolTipPosition = Form1.MousePosition
				ttci.Interval = 500
				ttci.Object = [date]

				toolTipController1.ShowHint(ttci)
			End If
		End Sub

		Private Function GetToolTipInfo(ByVal chi As CalendarHitInfo) As SuperToolTip
			Dim sTooltip1 As New SuperToolTip()
			Dim abc As AppointmentBaseCollection = schedulerStorage2.GetAppointments(chi.HitDate, chi.HitDate.AddDays(1))

			Dim titleItem1 As New ToolTipTitleItem()
			'titleItem1.Text = "Date: " + date;
			' Create a tooltip item that represents the SuperTooltip's contents.
			Dim item1 As New ToolTipItem()

			item1.Image = Image.FromFile("untitled.bmp") 'SchedulerTooltip.Properties.Resources.untitled;

			' Add the tooltip items to the SuperTooltip.
			sTooltip1.Items.Add(titleItem1)
			sTooltip1.Items.Add(item1)

			For Each apt As Appointment In abc
				titleItem1.Text += apt.Subject & " "
				item1.Text += String.Format("({0}-{1})" & Constants.vbLf, apt.Start, apt.End)
			Next apt

			Return sTooltip1
		End Function


	End Class
End Namespace