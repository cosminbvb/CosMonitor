namespace CosMonitor
{
    partial class CpuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CpuForm));
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.decor1 = new System.Windows.Forms.Panel();
            this.Internet_button = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GPU = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.Button();
            this.RebootButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NumberCoresLabel = new System.Windows.Forms.Label();
            this.CPUName_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CPUTemp_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPUusage_label = new System.Windows.Forms.Label();
            this.CPUProgressBar = new CircularProgressBar.CircularProgressBar();
            this.UpdateTimerCPU = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.LogicalProcessorsLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.EnabledCoresLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CORE1TEMPlabel = new System.Windows.Forms.Label();
            this.CORE2TEMPlabel = new System.Windows.Forms.Label();
            this.CORE3TEMPlabel = new System.Windows.Forms.Label();
            this.CORE4TEMPlabel = new System.Windows.Forms.Label();
            this.CORE5TEMPlabel = new System.Windows.Forms.Label();
            this.CORE6TEMPlabel = new System.Windows.Forms.Label();
            this.CORE7TEMPlabel = new System.Windows.Forms.Label();
            this.CORE8TEMPlabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.decor1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppButton.Image")));
            this.CloseAppButton.Location = new System.Drawing.Point(1352, 12);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(64, 48);
            this.CloseAppButton.TabIndex = 12;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // decor1
            // 
            this.decor1.Controls.Add(this.Internet_button);
            this.decor1.Controls.Add(this.HomeButton);
            this.decor1.Controls.Add(this.GPU);
            this.decor1.Controls.Add(this.CPU);
            this.decor1.Controls.Add(this.RebootButton);
            this.decor1.Dock = System.Windows.Forms.DockStyle.Left;
            this.decor1.Location = new System.Drawing.Point(0, 0);
            this.decor1.Name = "decor1";
            this.decor1.Size = new System.Drawing.Size(148, 824);
            this.decor1.TabIndex = 13;
            // 
            // Internet_button
            // 
            this.Internet_button.FlatAppearance.BorderSize = 0;
            this.Internet_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Internet_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Internet_button.ForeColor = System.Drawing.Color.White;
            this.Internet_button.Image = ((System.Drawing.Image)(resources.GetObject("Internet_button.Image")));
            this.Internet_button.Location = new System.Drawing.Point(3, 452);
            this.Internet_button.Name = "Internet_button";
            this.Internet_button.Size = new System.Drawing.Size(142, 106);
            this.Internet_button.TabIndex = 10;
            this.Internet_button.UseVisualStyleBackColor = true;
            this.Internet_button.Click += new System.EventHandler(this.Internet_button_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(-2, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(150, 106);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // GPU
            // 
            this.GPU.FlatAppearance.BorderSize = 0;
            this.GPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPU.ForeColor = System.Drawing.Color.White;
            this.GPU.Image = ((System.Drawing.Image)(resources.GetObject("GPU.Image")));
            this.GPU.Location = new System.Drawing.Point(0, 323);
            this.GPU.Name = "GPU";
            this.GPU.Size = new System.Drawing.Size(145, 48);
            this.GPU.TabIndex = 1;
            this.GPU.Text = "GPU";
            this.GPU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.GPU.UseVisualStyleBackColor = true;
            this.GPU.Click += new System.EventHandler(this.GPU_Click);
            // 
            // CPU
            // 
            this.CPU.FlatAppearance.BorderSize = 0;
            this.CPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPU.ForeColor = System.Drawing.Color.White;
            this.CPU.Image = ((System.Drawing.Image)(resources.GetObject("CPU.Image")));
            this.CPU.Location = new System.Drawing.Point(1, 181);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(144, 48);
            this.CPU.TabIndex = 0;
            this.CPU.Text = "CPU";
            this.CPU.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CPU.UseVisualStyleBackColor = true;
            // 
            // RebootButton
            // 
            this.RebootButton.FlatAppearance.BorderSize = 0;
            this.RebootButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RebootButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RebootButton.ForeColor = System.Drawing.Color.Yellow;
            this.RebootButton.Location = new System.Drawing.Point(3, 774);
            this.RebootButton.Name = "RebootButton";
            this.RebootButton.Size = new System.Drawing.Size(142, 38);
            this.RebootButton.TabIndex = 9;
            this.RebootButton.Text = "Reboot PC";
            this.RebootButton.UseVisualStyleBackColor = true;
            this.RebootButton.Click += new System.EventHandler(this.RebootButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Number of Cores:";
            // 
            // NumberCoresLabel
            // 
            this.NumberCoresLabel.AutoSize = true;
            this.NumberCoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NumberCoresLabel.ForeColor = System.Drawing.Color.White;
            this.NumberCoresLabel.Location = new System.Drawing.Point(482, 205);
            this.NumberCoresLabel.Name = "NumberCoresLabel";
            this.NumberCoresLabel.Size = new System.Drawing.Size(23, 25);
            this.NumberCoresLabel.TabIndex = 17;
            this.NumberCoresLabel.Text = "0";
            // 
            // CPUName_label
            // 
            this.CPUName_label.AutoSize = true;
            this.CPUName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUName_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CPUName_label.Location = new System.Drawing.Point(307, 149);
            this.CPUName_label.Name = "CPUName_label";
            this.CPUName_label.Size = new System.Drawing.Size(23, 25);
            this.CPUName_label.TabIndex = 18;
            this.CPUName_label.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1128, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(829, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Total Temperature:";
            // 
            // CPUTemp_label
            // 
            this.CPUTemp_label.AutoSize = true;
            this.CPUTemp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUTemp_label.ForeColor = System.Drawing.SystemColors.Control;
            this.CPUTemp_label.Location = new System.Drawing.Point(1005, 378);
            this.CPUTemp_label.Name = "CPUTemp_label";
            this.CPUTemp_label.Size = new System.Drawing.Size(0, 24);
            this.CPUTemp_label.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(828, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = " Usage:";
            // 
            // CPUusage_label
            // 
            this.CPUusage_label.AutoSize = true;
            this.CPUusage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUusage_label.ForeColor = System.Drawing.Color.White;
            this.CPUusage_label.Location = new System.Drawing.Point(998, 237);
            this.CPUusage_label.Name = "CPUusage_label";
            this.CPUusage_label.Size = new System.Drawing.Size(0, 29);
            this.CPUusage_label.TabIndex = 20;
            // 
            // CPUProgressBar
            // 
            this.CPUProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.CPUProgressBar.AnimationSpeed = 1000;
            this.CPUProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CPUProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.CPUProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPUProgressBar.InnerColor = System.Drawing.Color.Black;
            this.CPUProgressBar.InnerMargin = 2;
            this.CPUProgressBar.InnerWidth = -1;
            this.CPUProgressBar.Location = new System.Drawing.Point(937, 168);
            this.CPUProgressBar.MarqueeAnimationSpeed = 2000;
            this.CPUProgressBar.Name = "CPUProgressBar";
            this.CPUProgressBar.OuterColor = System.Drawing.Color.DimGray;
            this.CPUProgressBar.OuterMargin = -25;
            this.CPUProgressBar.OuterWidth = 26;
            this.CPUProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CPUProgressBar.ProgressWidth = 25;
            this.CPUProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPUProgressBar.Size = new System.Drawing.Size(185, 171);
            this.CPUProgressBar.StartAngle = 270;
            this.CPUProgressBar.Step = 1;
            this.CPUProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.CPUProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPUProgressBar.SubscriptText = ".23";
            this.CPUProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPUProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPUProgressBar.SuperscriptText = "°C";
            this.CPUProgressBar.TabIndex = 19;
            this.CPUProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPUProgressBar.Value = 10;
            // 
            // UpdateTimerCPU
            // 
            this.UpdateTimerCPU.Enabled = true;
            this.UpdateTimerCPU.Interval = 1500;
            this.UpdateTimerCPU.Tick += new System.EventHandler(this.UpdateTimerCPU_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(308, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Number of Logical Processors";
            // 
            // LogicalProcessorsLabel
            // 
            this.LogicalProcessorsLabel.AutoSize = true;
            this.LogicalProcessorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogicalProcessorsLabel.ForeColor = System.Drawing.Color.White;
            this.LogicalProcessorsLabel.Location = new System.Drawing.Point(605, 299);
            this.LogicalProcessorsLabel.Name = "LogicalProcessorsLabel";
            this.LogicalProcessorsLabel.Size = new System.Drawing.Size(23, 25);
            this.LogicalProcessorsLabel.TabIndex = 28;
            this.LogicalProcessorsLabel.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(308, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Number of Enabled Cores";
            // 
            // EnabledCoresLabel
            // 
            this.EnabledCoresLabel.AutoSize = true;
            this.EnabledCoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnabledCoresLabel.ForeColor = System.Drawing.Color.White;
            this.EnabledCoresLabel.Location = new System.Drawing.Point(567, 254);
            this.EnabledCoresLabel.Name = "EnabledCoresLabel";
            this.EnabledCoresLabel.Size = new System.Drawing.Size(23, 25);
            this.EnabledCoresLabel.TabIndex = 32;
            this.EnabledCoresLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 62;
            this.label1.Text = "Temp Core #1 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(307, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 63;
            this.label9.Text = "Temp Core #2 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(308, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "Temp Core #3 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(309, 495);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 25);
            this.label12.TabIndex = 65;
            this.label12.Text = "Temp Core #4 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(309, 538);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 25);
            this.label13.TabIndex = 66;
            this.label13.Text = "Temp Core #5 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(309, 577);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 25);
            this.label14.TabIndex = 67;
            this.label14.Text = "Temp Core #6 :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(309, 616);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 25);
            this.label15.TabIndex = 68;
            this.label15.Text = "Temp Core #7 :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(309, 655);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 25);
            this.label16.TabIndex = 69;
            this.label16.Text = "Temp Core #8 :";
            // 
            // CORE1TEMPlabel
            // 
            this.CORE1TEMPlabel.AutoSize = true;
            this.CORE1TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE1TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE1TEMPlabel.Location = new System.Drawing.Point(462, 377);
            this.CORE1TEMPlabel.Name = "CORE1TEMPlabel";
            this.CORE1TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE1TEMPlabel.TabIndex = 70;
            this.CORE1TEMPlabel.Text = "0";
            // 
            // CORE2TEMPlabel
            // 
            this.CORE2TEMPlabel.AutoSize = true;
            this.CORE2TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE2TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE2TEMPlabel.Location = new System.Drawing.Point(462, 415);
            this.CORE2TEMPlabel.Name = "CORE2TEMPlabel";
            this.CORE2TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE2TEMPlabel.TabIndex = 71;
            this.CORE2TEMPlabel.Text = "0";
            // 
            // CORE3TEMPlabel
            // 
            this.CORE3TEMPlabel.AutoSize = true;
            this.CORE3TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE3TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE3TEMPlabel.Location = new System.Drawing.Point(463, 455);
            this.CORE3TEMPlabel.Name = "CORE3TEMPlabel";
            this.CORE3TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE3TEMPlabel.TabIndex = 72;
            this.CORE3TEMPlabel.Text = "0";
            // 
            // CORE4TEMPlabel
            // 
            this.CORE4TEMPlabel.AutoSize = true;
            this.CORE4TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE4TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE4TEMPlabel.Location = new System.Drawing.Point(464, 495);
            this.CORE4TEMPlabel.Name = "CORE4TEMPlabel";
            this.CORE4TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE4TEMPlabel.TabIndex = 73;
            this.CORE4TEMPlabel.Text = "0";
            // 
            // CORE5TEMPlabel
            // 
            this.CORE5TEMPlabel.AutoSize = true;
            this.CORE5TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE5TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE5TEMPlabel.Location = new System.Drawing.Point(464, 538);
            this.CORE5TEMPlabel.Name = "CORE5TEMPlabel";
            this.CORE5TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE5TEMPlabel.TabIndex = 74;
            this.CORE5TEMPlabel.Text = "0";
            // 
            // CORE6TEMPlabel
            // 
            this.CORE6TEMPlabel.AutoSize = true;
            this.CORE6TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE6TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE6TEMPlabel.Location = new System.Drawing.Point(464, 577);
            this.CORE6TEMPlabel.Name = "CORE6TEMPlabel";
            this.CORE6TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE6TEMPlabel.TabIndex = 75;
            this.CORE6TEMPlabel.Text = "0";
            // 
            // CORE7TEMPlabel
            // 
            this.CORE7TEMPlabel.AutoSize = true;
            this.CORE7TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE7TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE7TEMPlabel.Location = new System.Drawing.Point(464, 616);
            this.CORE7TEMPlabel.Name = "CORE7TEMPlabel";
            this.CORE7TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE7TEMPlabel.TabIndex = 76;
            this.CORE7TEMPlabel.Text = "0";
            // 
            // CORE8TEMPlabel
            // 
            this.CORE8TEMPlabel.AutoSize = true;
            this.CORE8TEMPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CORE8TEMPlabel.ForeColor = System.Drawing.Color.White;
            this.CORE8TEMPlabel.Location = new System.Drawing.Point(464, 655);
            this.CORE8TEMPlabel.Name = "CORE8TEMPlabel";
            this.CORE8TEMPlabel.Size = new System.Drawing.Size(23, 25);
            this.CORE8TEMPlabel.TabIndex = 77;
            this.CORE8TEMPlabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(307, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 29);
            this.label6.TabIndex = 26;
            this.label6.Text = "Real Time Information:";
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AppVersionLabel.Location = new System.Drawing.Point(1242, 783);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(174, 32);
            this.AppVersionLabel.TabIndex = 78;
            this.AppVersionLabel.Text = "Beta Version 1.1.0.0 \r\nMade by Cosmin Petrescu\r\n";
            // 
            // CpuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1428, 824);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.CORE8TEMPlabel);
            this.Controls.Add(this.CORE7TEMPlabel);
            this.Controls.Add(this.CORE6TEMPlabel);
            this.Controls.Add(this.CORE5TEMPlabel);
            this.Controls.Add(this.CORE4TEMPlabel);
            this.Controls.Add(this.CORE3TEMPlabel);
            this.Controls.Add(this.CORE2TEMPlabel);
            this.Controls.Add(this.CORE1TEMPlabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnabledCoresLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LogicalProcessorsLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CPUTemp_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CPUusage_label);
            this.Controls.Add(this.CPUProgressBar);
            this.Controls.Add(this.CPUName_label);
            this.Controls.Add(this.NumberCoresLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.decor1);
            this.Controls.Add(this.CloseAppButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1428, 824);
            this.MinimumSize = new System.Drawing.Size(1428, 824);
            this.Name = "CpuForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "CpuForm";
            this.Load += new System.EventHandler(this.CpuForm_Load);
            this.Shown += new System.EventHandler(this.CpuForm_Shown);
            this.decor1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Panel decor1;
        private System.Windows.Forms.Button Internet_button;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button GPU;
        private System.Windows.Forms.Button CPU;
        private System.Windows.Forms.Button RebootButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumberCoresLabel;
        private System.Windows.Forms.Label CPUName_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CPUTemp_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CPUusage_label;
        private CircularProgressBar.CircularProgressBar CPUProgressBar;
        private System.Windows.Forms.Timer UpdateTimerCPU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LogicalProcessorsLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label EnabledCoresLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label CORE1TEMPlabel;
        private System.Windows.Forms.Label CORE2TEMPlabel;
        private System.Windows.Forms.Label CORE3TEMPlabel;
        private System.Windows.Forms.Label CORE4TEMPlabel;
        private System.Windows.Forms.Label CORE5TEMPlabel;
        private System.Windows.Forms.Label CORE6TEMPlabel;
        private System.Windows.Forms.Label CORE7TEMPlabel;
        private System.Windows.Forms.Label CORE8TEMPlabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AppVersionLabel;
    }
}