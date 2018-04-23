using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Calendar;
using DevExpress.Utils;
using DevExpress.XtraScheduler;

namespace SchedulerTooltip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carsDBDataSet.CarScheduling' table. You can move, or remove it, as needed.
            this.carSchedulingTableAdapter.Fill(this.carsDBDataSet.CarScheduling);

        }

        DateTime selectedDate = DateTime.MinValue;
        private void dateNavigator1_MouseMove(object sender, MouseEventArgs e)
        {
            CalendarHitInfo chi = dateNavigator1.GetHitInfo(dateNavigator1.PointToClient(Form1.MousePosition));

            if (chi.HitObject != null)
            {
                string date = chi.HitDate.ToString();
                SuperToolTip sTooltip1 = GetToolTipInfo(chi);
                ToolTipControlInfo ttci = new ToolTipControlInfo();

                ttci.ToolTipType = ToolTipType.SuperTip;
                ttci.SuperTip = sTooltip1;
                ttci.ToolTipPosition = Form1.MousePosition;
                ttci.Interval = 500;
                ttci.Object = date;
                
                toolTipController1.ShowHint(ttci);
            }
        }

        private SuperToolTip GetToolTipInfo(CalendarHitInfo chi)
        {
            SuperToolTip sTooltip1 = new SuperToolTip();
            AppointmentBaseCollection abc = schedulerStorage2.GetAppointments(chi.HitDate, chi.HitDate.AddDays(1));

            ToolTipTitleItem titleItem1 = new ToolTipTitleItem();
            //titleItem1.Text = "Date: " + date;
            // Create a tooltip item that represents the SuperTooltip's contents.
            ToolTipItem item1 = new ToolTipItem();

            item1.Image = Image.FromFile("untitled.bmp"); //SchedulerTooltip.Properties.Resources.untitled;
            
            // Add the tooltip items to the SuperTooltip.
            sTooltip1.Items.Add(titleItem1);
            sTooltip1.Items.Add(item1);
            
            foreach (Appointment apt in abc)
            {
                titleItem1.Text += apt.Subject + " ";
                item1.Text += String.Format("({0}-{1})\n", apt.Start, apt.End);
            }

            return sTooltip1;
        }


    }
}