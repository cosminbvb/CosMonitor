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
using System.Net;

namespace CosMonitor
{
    public partial class InternetForm : Form
    {
        public InternetForm()
        {
            InitializeComponent();
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

        private void InternetForm_Load(object sender, EventArgs e)
        {
            
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                int timp = Convert.ToInt32(numericUpDown1.Value);
                string comanda = "/C ping  8.8.8.8 " + " -n " + timp;
                System.Diagnostics.ProcessStartInfo p = new System.Diagnostics.ProcessStartInfo("CMD.exe", comanda);
                p.UseShellExecute = false;
                p.RedirectStandardOutput = true;
                //p.CreateNoWindow = true;
                //p.RedirectStandardInput = true;
                var proc = System.Diagnostics.Process.Start(p);
                string output = proc.StandardOutput.ReadToEnd();
                int x = output.LastIndexOf("Packets");
                ResultLabel.Text = output.Substring(x);
            }
            
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

        private void GPU_Click(object sender, EventArgs e)
        {
            GPUForm temp = new GPUForm();
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

        private void IPlabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatismyip.com/");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.speedtest.net/");
        }

    }
}
