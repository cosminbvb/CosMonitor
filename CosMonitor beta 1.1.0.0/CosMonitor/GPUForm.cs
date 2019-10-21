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

namespace CosMonitor
{

    public partial class GPUForm : Form
    {
        #region declars

        string val;
        private int eroare = 1;
        private string path = @"c:\NVSMI";
        private string sourcePath = @"C:\Program Files\NVIDIA Corporation\NVSMI\";
        private string destinationPath = @"c:\NVSMI";

        private Char delimiter2 = 'W';
        private int gpuCount = 0;
        private string output;

        private int gpuTemp;
        private int gpuLoad;
        private int gpuVramFree;
        private int gpuVramInstalled;
        private int gpuVramUsed;
        private int gpuCore;
        private int gpuMem;

        #endregion

        public GPUForm()
        {
            InitializeComponent();
        }
        private void GPUForm_Load(object sender, EventArgs e)
        {

        }
        private void GPUForm_Shown(object sender, EventArgs e)
        {
            GetComponent("Win32_VideoController", "Name");
            GPUname_label.Text = val; //!!!!!!!!!!!!!!!nu arata ambele placi video 
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

        private void GPUTimer_Tick(object sender, EventArgs e)
        {
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=utilization.memory --format=csv", ref gpuLoad, GPUloadlevel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=temperature.gpu --format=csv", ref gpuTemp, GPUTemplabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=memory.free --format=csv", ref gpuVramFree, VRAMlabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=memory.total --format=csv", ref gpuVramInstalled, installedVRAMlabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=memory.used --format=csv", ref gpuVramUsed, UsedVramLabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=clocks.sm --format=csv", ref gpuCore, GPUcoreLabel);
            gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=clocks.mem --format=csv", ref gpuMem, GPUmemoryLabel);
            //gpu_info(@"/C cd c:\NVSMI&nvidia-smi --query-gpu=clocks.gr --format=csv", ref gpuShader, GPUshaderLabel);
            //mai incearca asta
            // https://briot-jerome.developpez.com/fichiers/blog/nvidia-smi/list.txt
            //verifica daca da bine cu open hardware monitor


            GPUProgressBar.Value = gpuLoad;
            GPUloadlevel.Text += " %";
           
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

        private void CPU_Click(object sender, EventArgs e)
        {
            CpuForm temp = new CpuForm();
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
