namespace SchedulerTooltip
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            this.dateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage2 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.carsDBDataSet = new SchedulerTooltip.CarsDBDataSet();
            this.carSchedulingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSchedulingTableAdapter = new SchedulerTooltip.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateNavigator1
            // 
            this.dateNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateNavigator1.Location = new System.Drawing.Point(0, 0);
            this.dateNavigator1.Name = "dateNavigator1";
            this.dateNavigator1.SchedulerControl = this.schedulerControl1;
            this.dateNavigator1.Size = new System.Drawing.Size(199, 564);
            this.toolTipController1.SetSuperTip(this.dateNavigator1, null);
            this.dateNavigator1.TabIndex = 0;
            this.dateNavigator1.View = DevExpress.XtraEditors.Controls.DateEditCalendarViewType.MonthInfo;
            this.dateNavigator1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dateNavigator1_MouseMove);
            // 
            // toolTipController1
            // 
            this.toolTipController1.AutoPopDelay = 1000;
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(199, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(718, 564);
            this.schedulerControl1.Start = new System.DateTime(2008, 9, 8, 0, 0, 0, 0);
            this.schedulerControl1.Storage = this.schedulerStorage2;
            this.schedulerControl1.TabIndex = 1;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.ToolTipController = this.toolTipController1;
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler2);
            // 
            // schedulerStorage2
            // 
            this.schedulerStorage2.Appointments.DataSource = this.carSchedulingBindingSource;
            this.schedulerStorage2.Appointments.Mappings.AllDay = "AllDay";
            this.schedulerStorage2.Appointments.Mappings.Description = "Description";
            this.schedulerStorage2.Appointments.Mappings.End = "EndTime";
            this.schedulerStorage2.Appointments.Mappings.Label = "Label";
            this.schedulerStorage2.Appointments.Mappings.Location = "Location";
            this.schedulerStorage2.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
            this.schedulerStorage2.Appointments.Mappings.ReminderInfo = "ReminderInfo";
            this.schedulerStorage2.Appointments.Mappings.Start = "StartTime";
            this.schedulerStorage2.Appointments.Mappings.Status = "Status";
            this.schedulerStorage2.Appointments.Mappings.Subject = "Subject";
            this.schedulerStorage2.Appointments.Mappings.Type = "EventType";
            // 
            // carsDBDataSet
            // 
            this.carsDBDataSet.DataSetName = "CarsDBDataSet";
            this.carsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carSchedulingBindingSource
            // 
            this.carSchedulingBindingSource.DataMember = "CarScheduling";
            this.carSchedulingBindingSource.DataSource = this.carsDBDataSet;
            // 
            // carSchedulingTableAdapter
            // 
            this.carSchedulingTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 564);
            this.Controls.Add(this.schedulerControl1);
            this.Controls.Add(this.dateNavigator1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.toolTipController1.SetSuperTip(this, null);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSchedulingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.DateNavigator dateNavigator1;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage2;
        private CarsDBDataSet carsDBDataSet;
        private System.Windows.Forms.BindingSource carSchedulingBindingSource;
        private SchedulerTooltip.CarsDBDataSetTableAdapters.CarSchedulingTableAdapter carSchedulingTableAdapter;

    }
}

