using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.IO;
using System.Threading;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;



namespace CosMonitor      
{

    public partial class MainScreen : Form
    {

        #region declars

        private int eroare = 1;
        string val;
        double valdouble;
        int numberofcores;
        private Thread cpuThread;
        private double[] cpuArray = new double[60];
        private double[] gpuArray = new double[60];

        PerformanceCounter CPUusage = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
        PerformanceCounter AvailableMemory= new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter UPtime = new PerformanceCounter("System", "System Up Time");

        //computer for accessing OpenHardwareMonitor data
        private Computer c = new Computer { CPUEnabled = true };

        private int counter = 0;
        private int cpuTempTotal;
        private int cpuTemp1;
        private int cpuTemp2;
        private int cpuTemp3;
        private int cpuTemp4;

        private string path = @"c:\NVSMI";
        private string sourcePath = @"C:\Program Files\NVIDIA Corporation\NVSMI\";
        private string destinationPath = @"c:\NVSMI";
   
        private Char delimiter2 = 'W';
        private int gpuCount = 0;
        private string output;

        //variables for GPU data

        private int gpuTemp;
        private int gpuLoad;
        private int gpuVramInstalled;
        private int gpuVramUsed;

        #endregion

        public MainScreen()
        {
            InitializeComponent();
            c.Open();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            cpuThread = new Thread(new ThreadStart(this.getPerformanceCounters));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }
        private void MainScreen_Shown(object sender, EventArgs e)
        {
            GetComponent("Win32_Processor", "Name");
            CPUName_label.Text = val;
            GetComponent("Win32_VideoController", "Name");
            GPUname_label.Text = val;
            GetComponent("Win32_PhysicalMemory", "Capacity");
            TotalMemLabel.Text = (valdouble / 1024 / 1024).ToString() + " MB";
            MemoryProgressBar.Maximum = (int)(valdouble / 1024 / 1024);
            nrcores();

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

        private void nrcores()
        {
            GetComponent("Win32_Processor", "NumberOfEnabledCore");
            numberofcores = Int32.Parse(val);
        }

        #region GPU functions

        private void gpu_info(string a, ref int b, Label c)
        {
            try
            {

                //checking for directory for NVIDIA files 

                if (!Directory.Exists(path))
                {

                    //trying to create the directory

                    DirectoryInfo di = Directory.CreateDirectory(path);
                    Console.Write("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                    //copying to new directory

                    NVIDIAGPU();
                }
            }
            catch (Exception e)
            {
                if (eroare == 1)
                {
                    eroare = 0;
                    MessageBox.Show("Unable to access NVIDIA files" + e.ToString());
                    return;
                }
            }

            try
            {
                gpuCount = 0;

                //starting the process that gathers NVIDIA data 

                ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", a);
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.CreateNoWindow = true;

                Process process = Process.Start(processStartInfo);
                using (StreamReader streamReader = process.StandardOutput)
                {
                    output = streamReader.ReadToEnd();
                }

                String[] substrings = output.Split(delimiter2);

                //displaying/memorizing GPU data pulled

                foreach (var substring in substrings)
                {
                    if (gpuCount == 0)
                    {
                        c.Text = String.Join("", substring.Where(Char.IsDigit));
                        b = Convert.ToInt16(String.Join("", substring.Where(Char.IsDigit)));
                    }

                    gpuCount++;
                }
            }
            catch
            {
                if (eroare == 1)
                {
                    eroare = 0;
                    MessageBox.Show("Unable to acess NVIDIA files");
                    return;
                }
            }
        }

        private void NVIDIAGPU()
        {

            //copying NVIDIA files to directory in C:\

            sourcePath = sourcePath.EndsWith(@"\") ? sourcePath : sourcePath + @"\";
            destinationPath = destinationPath.EndsWith(@"\") ? destinationPath : destinationPath + @"\";

            try
            {
                if (Directory.Exists(sourcePath))
                {
                    if (Directory.Exists(destinationPath) == false)
                    {
                        Directory.CreateDirectory(destinationPath);
                    }

                    foreach (string files in Directory.GetFiles(sourcePath))
                    {
                        FileInfo fileInfo = new FileInfo(files);
                        fileInfo.CopyTo(string.Format(@"{0}\{1}", destinationPath, fileInfo.Name), true);
                    }
                }
            }
            catch (Exception)
            {
                if (eroare == 1)
                {
                    eroare = 0;
                    MessageBox.Show("NVIDIA File Access Error");
                }
            }
        }

        #endregion

        #region CPU temp function

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
                        if (counter == 0 && counter < numberofcores)
                        {
                            cpuTemp1 = (int)sensor.Value;
                        }
                        if (counter == 1 && counter < numberofcores)
                        {
                            cpuTemp2 = (int)sensor.Value;
                        }
                        if (counter == 2 && counter < numberofcores)
                        {
                            cpuTemp3 = (int)sensor.Value;
                        }
                        if (counter == 3 && counter < numberofcores)
                        {
                            cpuTemp4 = (int)sensor.Value;
                        }

                        counter++;

                        cpuTempTotal = (cpuTemp1 + cpuTemp2 + cpuTemp3 + cpuTemp4) / 4;
                        CPUTemp_label.Text = cpuTempTotal.ToString() + " °C";

                    }
                }
            }
        }

        #endregion

        #region HardwareInfo 
        private void GetComponent(string hwclass, string syntax)
        {
            val = "";
            valdouble = 0;
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                val += (Convert.ToString(mj[syntax])) + "\n";
                if(syntax=="Capacity")//special case when we need the output to be an int (for installed ram)
                    valdouble += Convert.ToInt64(mj[syntax]);
            
            }
        }

        #endregion

        #region CHART
   
        private void getPerformanceCounters()
        {
            PerformanceCounter CPUusage = new PerformanceCounter("Processor Information", "% Processor Utility", "_Total");
            
            while (true)//loop
            {
                cpuArray[cpuArray.Length - 1] = Clamp(Math.Round(CPUusage.NextValue(), 0),0,100);
                gpuArray[gpuArray.Length - 1] = Clamp(gpuLoad, 0, 100);

                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);
                Array.Copy(gpuArray, 1, gpuArray, 0, gpuArray.Length - 1);


                if (mainchart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { updateMainChart(); });
                }
                else
                {
                    //......
                }

                Thread.Sleep(1000);
            }
        }
        private void updateMainChart()
        {
            mainchart.Series["CPU"].Points.Clear();
            for (int j = 0; j < cpuArray.Length - 1; ++j)
            {
                mainchart.Series["CPU"].Points.AddY(Clamp(cpuArray[j],0, 100));
            }

            mainchart.Series["GPU (dedicated)"].Points.Clear();
            for (int j = 0; j < gpuArray.Length - 1; ++j)
            {
                mainchart.Series["GPU (dedicated)"].Points.AddY(Clamp(gpuArray[j], 0, 100));
            }
        }

        #endregion

        #region TABS

        private void CPU_Click(object sender, EventArgs e)
        {
            CpuForm tempcpu = new CpuForm();
            tempcpu.Show();
            tempcpu.Top = this.Top;
            tempcpu.Left = this.Left;
            this.Hide();//*
        }

        private void GPU_Click(object sender, EventArgs e)
        {
            GPUForm tempgpu = new GPUForm();
            tempgpu.Show();
            tempgpu.Top = this.Top;
            tempgpu.Left = this.Left;
            this.Hide();//*
        }

        private void Internet_button_Click(object sender, EventArgs e)
        {
            InternetForm tempnet = new InternetForm();
            tempnet.Show();
            tempnet.Top = this.Top;
            tempnet.Left = this.Left;
            this.Hide();//*
        }

        private void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reboot(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "-r -t 0");
        }

        #endregion

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            #region declars
            int x = (int)CPUusage.NextValue();
            int y = (int)AvailableMemory.NextValue();
            #endregion

            #region CPU,RAM

            cpu_use_temp();
            x = (int)Clamp(x, 0, 100);
            CPUusage_label.Text = x + "%";
            AvailableMem_label.Text = y + "MB"; 
            CPUProgressBar.Value = x;
            MemoryProgressBar.Value = y;

            #endregion

            #region GPU

            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=utilization.memory --format=csv", ref gpuLoad, GPUloadlevel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=temperature.gpu --format=csv", ref gpuTemp, GPUTemplabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=memory.total --format=csv", ref gpuVramInstalled, installedVRAMlabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=memory.used --format=csv", ref gpuVramUsed, UsedVramLabel);


            GPUProgressBar.Value = gpuLoad;
            GPUloadlevel.Text += " %";

            #endregion

        }

        private double Clamp(double value, double min, double max)
        {
            if (value < min)
                return min;

            if (value > max)
                return max;

            return value;
        }

    }
}
