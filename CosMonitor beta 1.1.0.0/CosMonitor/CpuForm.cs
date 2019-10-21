using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;

namespace CosMonitor

{
    public partial class CpuForm : Form
    {

        #region declars

        string val;
        PerformanceCounter CPUusage = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");

        //computer for accessing OpenHardwareMonitor data
        private Computer c = new Computer { CPUEnabled = true };

        private int counter = 0;
        private int cpuTempTotal=0;
        private int cpuTemp1=0;
        private int cpuTemp2=0;
        private int cpuTemp3=0;
        private int cpuTemp4=0;
        private int cpuTemp5=0;
        private int cpuTemp6=0;
        private int cpuTemp7=0;
        private int cpuTemp8=0;
        int numberofcores;

        #endregion

        public CpuForm()
        {
            InitializeComponent();
            c.Open();
        }
        private void CpuForm_Load(object sender, EventArgs e)
        {

        }
        private void CpuForm_Shown(object sender, EventArgs e)
        {
            GetComponent("Win32_Processor", "Name");
            CPUName_label.Text = val;
            GetComponent("Win32_Processor", "NumberOfCores");
            NumberCoresLabel.Text = val;
            GetComponent("Win32_Processor", "NumberOfEnabledCore");
            EnabledCoresLabel.Text = val;
            numberofcores = Int32.Parse(val);
            GetComponent("Win32_Processor", "NumberOfLogicalProcessors");
            LogicalProcessorsLabel.Text = val;
        }

        private void cpu_use_temp()
        {
            counter = 0;
            foreach (IHardware hardware in c.Hardware)
            {
                hardware.Update();

                foreach (ISensor sensor in hardware.Sensors)
                {
                    if (sensor.SensorType == SensorType.Temperature)
                    {
                        if (counter == 0 && counter<numberofcores)
                        {
                            cpuTemp1 = (int)sensor.Value;
                            CORE1TEMPlabel.Text = cpuTemp1.ToString() + " °C";
                        }
                        if (counter == 1 && counter < numberofcores)
                        {
                            cpuTemp2 = (int)sensor.Value;
                            CORE2TEMPlabel.Text = cpuTemp2.ToString() + " °C";
                        }
                        if (counter == 2 && counter < numberofcores)
                        {
                            cpuTemp3 = (int)sensor.Value;
                            CORE3TEMPlabel.Text = cpuTemp3.ToString() + " °C";
                        }
                        if (counter == 3 && counter < numberofcores)
                        {
                            cpuTemp4 = (int)sensor.Value;
                            CORE4TEMPlabel.Text = cpuTemp4.ToString() + " °C";
                        }
                        if (counter == 4 && counter < numberofcores)
                        {
                            cpuTemp5 = (int)sensor.Value;
                            CORE5TEMPlabel.Text = cpuTemp5.ToString() + " °C";
                        }
                        if (counter == 5 && counter < numberofcores)
                        {
                            cpuTemp6 = (int)sensor.Value;
                            CORE6TEMPlabel.Text = cpuTemp6.ToString() + " °C";
                        }
                        if (counter == 6 && counter < numberofcores)
                        {
                            cpuTemp7 = (int)sensor.Value;
                            CORE7TEMPlabel.Text = cpuTemp7.ToString() + " °C";
                        }
                        if (counter == 7 && counter < numberofcores)
                        {
                            cpuTemp8 = (int)sensor.Value;
                            CORE8TEMPlabel.Text = cpuTemp8.ToString() + " °C";
                        }

                        counter++;


                        cpuTempTotal = (cpuTemp1 + cpuTemp2 + cpuTemp3 + cpuTemp4) / 4;
                        CPUTemp_label.Text = cpuTempTotal.ToString() + " °C";

                    }
                }
            }
        }

        protected override void WndProc(ref Message m)//makes the form movable
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private double Clamp(double value, double min, double max)
        {
            if (value < min)
                return min;

            if (value > max)
                return max;

            return value;
        }

        #region HardwareInfo 
        private void GetComponent(string hwclass, string syntax)
        {
            val = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                //Hardware_label.Text=Hardware_label.Text+(Convert.ToString(mj[syntax])) + "\n"; pt a afisa mai multe in acelasi label
                val += (Convert.ToString(mj[syntax])) + "\n";
            }
        }
        #endregion

        private void UpdateTimerCPU_Tick(object sender, EventArgs e)
        {
            cpu_use_temp();
            int x = (int)CPUusage.NextValue();
            x = (int)Clamp(x, 0, 100);
            CPUusage_label.Text = x + "%";
            CPUProgressBar.Value = x;

        }

        #region TABS

        private void HomeButton_Click(object sender, EventArgs e)
        {
            MainScreen temp1 = new MainScreen();
            temp1.Show();
            temp1.Top = this.Top;
            temp1.Left = this.Left;
            this.Hide();//*
        }

        private void GPU_Click(object sender, EventArgs e)
        {
            GPUForm temp = new GPUForm();
            temp.Show();
            temp.Top = this.Top;
            temp.Left = this.Left;
            this.Hide();//*
        }

        private void Internet_button_Click(object sender, EventArgs e)
        {
            InternetForm temp = new InternetForm();
            temp.Show();
            temp.Top = this.Top;
            temp.Left = this.Left;
            this.Hide();//*
        }

        private void RebootButton_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 0"); //uses system.diagnostics
        }

        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
