Imports Microsoft.VisualBasic
Imports System
Namespace SchedulerTooltip
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim timeRuler1 As New DevExpress.XtraScheduler.TimeRuler()
			Dim timeRuler2 As New DevExpress.XtraScheduler.TimeRuler()
			Me.dateNavigator1 = New DevExpress.XtraScheduler.DateNavigator()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
			Me.schedulerStorage2 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
			Me.carsDBDataSet = New SchedulerTooltip.CarsDBDataSet()
			Me.carSchedulingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.carSchedulingTableAdapter = New SchedulerTooltip.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter()
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.schedulerStorage2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dateNavigator1
			' 
			Me.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Left
			Me.dateNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.dateNavigator1.Name = "dateNavigator1"
			Me.dateNavigator1.SchedulerControl = Me.schedulerControl1
			Me.dateNavigator1.Size = New System.Drawing.Size(199, 564)
			Me.toolTipController1.SetSuperTip(Me.dateNavigator1, Nothing)
			Me.dateNavigator1.TabIndex = 0
			Me.dateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo
'			Me.dateNavigator1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.dateNavigator1_MouseMove);
			' 
			' toolTipController1
			' 
			Me.toolTipController1.AutoPopDelay = 1000
			' 
			' schedulerControl1
			' 
			Me.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.schedulerControl1.Location = New System.Drawing.Point(199, 0)
			Me.schedulerControl1.Name = "schedulerControl1"
			Me.schedulerControl1.Size = New System.Drawing.Size(718, 564)
			Me.schedulerControl1.Start = New System.DateTime(2008, 9, 8, 0, 0, 0, 0)
			Me.schedulerControl1.Storage = Me.schedulerStorage2
			Me.schedulerControl1.TabIndex = 1
			Me.schedulerControl1.Text = "schedulerControl1"
			Me.schedulerControl1.ToolTipController = Me.toolTipController1
			Me.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1)
			Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2)
			' 
			' schedulerStorage2
			' 
			Me.schedulerStorage2.Appointments.DataSource = Me.carSchedulingBindingSource
			Me.schedulerStorage2.Appointments.Mappings.AllDay = "AllDay"
			Me.schedulerStorage2.Appointments.Mappings.Description = "Description"
			Me.schedulerStorage2.Appointments.Mappings.End = "EndTime"
			Me.schedulerStorage2.Appointments.Mappings.Label = "Label"
			Me.schedulerStorage2.Appointments.Mappings.Location = "Location"
			Me.schedulerStorage2.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
			Me.schedulerStorage2.Appointments.Mappings.ReminderInfo = "ReminderInfo"
			Me.schedulerStorage2.Appointments.Mappings.Start = "StartTime"
			Me.schedulerStorage2.Appointments.Mappings.Status = "Status"
			Me.schedulerStorage2.Appointments.Mappings.Subject = "Subject"
			Me.schedulerStorage2.Appointments.Mappings.Type = "EventType"
			' 
			' carsDBDataSet
			' 
			Me.carsDBDataSet.DataSetName = "CarsDBDataSet"
			Me.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' carSchedulingBindingSource
			' 
			Me.carSchedulingBindingSource.DataMember = "CarScheduling"
			Me.carSchedulingBindingSource.DataSource = Me.carsDBDataSet
			' 
			' carSchedulingTableAdapter
			' 
			Me.carSchedulingTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(917, 564)
			Me.Controls.Add(Me.schedulerControl1)
			Me.Controls.Add(Me.dateNavigator1)
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "Form1"
			Me.toolTipController1.SetSuperTip(Me, Nothing)
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dateNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.schedulerStorage2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carSchedulingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dateNavigator1 As DevExpress.XtraScheduler.DateNavigator
		Private toolTipController1 As DevExpress.Utils.ToolTipController
		Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
		Private schedulerStorage2 As DevExpress.XtraScheduler.SchedulerStorage
		Private carsDBDataSet As CarsDBDataSet
		Private carSchedulingBindingSource As System.Windows.Forms.BindingSource
		Private carSchedulingTableAdapter As SchedulerTooltip.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter

	End Class
End Namespace

