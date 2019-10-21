namespace CosMonitor
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.decor1 = new System.Windows.Forms.Panel();
            this.Internet_button = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GPU = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.Button();
            this.RebootButton = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.CPUProgressBar = new CircularProgressBar.CircularProgressBar();
            this.CPUusage_label = new System.Windows.Forms.Label();
            this.MemoryProgressBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.AvailableMem_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CPUTemp_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CPUName_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CPUclockspeed_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GPUname_label = new System.Windows.Forms.Label();
            this.GPUProgressBar = new CircularProgressBar.CircularProgressBar();
            this.GPUloadlevel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GPUTemplabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.installedVRAMlabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mainchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UsedVramLabel = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TotalMemLabel = new System.Windows.Forms.Label();
            this.decor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).BeginInit();
            this.SuspendLayout();
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
            this.decor1.TabIndex = 0;
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
            this.CPU.Click += new System.EventHandler(this.CPU_Click);
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
            this.RebootButton.Click += new System.EventHandler(this.Reboot);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 1000;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppButton.Image")));
            this.CloseAppButton.Location = new System.Drawing.Point(1352, 12);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(64, 48);
            this.CloseAppButton.TabIndex = 10;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseApp);
            // 
            // CPUProgressBar
            // 
            this.CPUProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseInOut;
            this.CPUProgressBar.AnimationSpeed = 1000;
            this.CPUProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CPUProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.CPUProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CPUProgressBar.InnerColor = System.Drawing.Color.Black;
            this.CPUProgressBar.InnerMargin = 2;
            this.CPUProgressBar.InnerWidth = -1;
            this.CPUProgressBar.Location = new System.Drawing.Point(249, 115);
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
            this.CPUProgressBar.TabIndex = 2;
            this.CPUProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.CPUProgressBar.Value = 68;
            // 
            // CPUusage_label
            // 
            this.CPUusage_label.AutoSize = true;
            this.CPUusage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUusage_label.ForeColor = System.Drawing.Color.White;
            this.CPUusage_label.Location = new System.Drawing.Point(310, 184);
            this.CPUusage_label.Name = "CPUusage_label";
            this.CPUusage_label.Size = new System.Drawing.Size(0, 29);
            this.CPUusage_label.TabIndex = 3;
            // 
            // MemoryProgressBar
            // 
            this.MemoryProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.MemoryProgressBar.AnimationSpeed = 1000;
            this.MemoryProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.MemoryProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.MemoryProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MemoryProgressBar.InnerColor = System.Drawing.Color.Black;
            this.MemoryProgressBar.InnerMargin = 2;
            this.MemoryProgressBar.InnerWidth = -1;
            this.MemoryProgressBar.Location = new System.Drawing.Point(641, 116);
            this.MemoryProgressBar.MarqueeAnimationSpeed = 2000;
            this.MemoryProgressBar.Maximum = 64000;
            this.MemoryProgressBar.Name = "MemoryProgressBar";
            this.MemoryProgressBar.OuterColor = System.Drawing.Color.DimGray;
            this.MemoryProgressBar.OuterMargin = -25;
            this.MemoryProgressBar.OuterWidth = 26;
            this.MemoryProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.MemoryProgressBar.ProgressWidth = 25;
            this.MemoryProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.MemoryProgressBar.Size = new System.Drawing.Size(187, 171);
            this.MemoryProgressBar.StartAngle = 270;
            this.MemoryProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.MemoryProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MemoryProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.MemoryProgressBar.SubscriptText = ".23";
            this.MemoryProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MemoryProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.MemoryProgressBar.SuperscriptText = "°C";
            this.MemoryProgressBar.TabIndex = 4;
            this.MemoryProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.MemoryProgressBar.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(299, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = " Usage";
            // 
            // AvailableMem_label
            // 
            this.AvailableMem_label.AutoSize = true;
            this.AvailableMem_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AvailableMem_label.ForeColor = System.Drawing.Color.White;
            this.AvailableMem_label.Location = new System.Drawing.Point(685, 191);
            this.AvailableMem_label.Name = "AvailableMem_label";
            this.AvailableMem_label.Size = new System.Drawing.Size(0, 25);
            this.AvailableMem_label.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(650, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Available Memory";
            // 
            // CPUTemp_label
            // 
            this.CPUTemp_label.AutoSize = true;
            this.CPUTemp_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUTemp_label.ForeColor = System.Drawing.SystemColors.Control;
            this.CPUTemp_label.Location = new System.Drawing.Point(342, 347);
            this.CPUTemp_label.Name = "CPUTemp_label";
            this.CPUTemp_label.Size = new System.Drawing.Size(0, 24);
            this.CPUTemp_label.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(210, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Temperature:";
            // 
            // CPUName_label
            // 
            this.CPUName_label.AutoSize = true;
            this.CPUName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUName_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CPUName_label.Location = new System.Drawing.Point(212, 306);
            this.CPUName_label.Name = "CPUName_label";
            this.CPUName_label.Size = new System.Drawing.Size(0, 20);
            this.CPUName_label.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(296, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "CPU";
            // 
            // CPUclockspeed_label
            // 
            this.CPUclockspeed_label.AutoSize = true;
            this.CPUclockspeed_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CPUclockspeed_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CPUclockspeed_label.Location = new System.Drawing.Point(212, 388);
            this.CPUclockspeed_label.Name = "CPUclockspeed_label";
            this.CPUclockspeed_label.Size = new System.Drawing.Size(0, 20);
            this.CPUclockspeed_label.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(683, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "RAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1030, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 38);
            this.label5.TabIndex = 18;
            this.label5.Text = "GPU";
            // 
            // GPUname_label
            // 
            this.GPUname_label.AutoSize = true;
            this.GPUname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUname_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GPUname_label.Location = new System.Drawing.Point(974, 292);
            this.GPUname_label.Name = "GPUname_label";
            this.GPUname_label.Size = new System.Drawing.Size(0, 20);
            this.GPUname_label.TabIndex = 19;
            // 
            // GPUProgressBar
            // 
            this.GPUProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CircularEaseInOut;
            this.GPUProgressBar.AnimationSpeed = 1000;
            this.GPUProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.GPUProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.GPUProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GPUProgressBar.InnerColor = System.Drawing.Color.Black;
            this.GPUProgressBar.InnerMargin = 2;
            this.GPUProgressBar.InnerWidth = -1;
            this.GPUProgressBar.Location = new System.Drawing.Point(978, 115);
            this.GPUProgressBar.MarqueeAnimationSpeed = 2000;
            this.GPUProgressBar.Name = "GPUProgressBar";
            this.GPUProgressBar.OuterColor = System.Drawing.Color.DimGray;
            this.GPUProgressBar.OuterMargin = -25;
            this.GPUProgressBar.OuterWidth = 26;
            this.GPUProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GPUProgressBar.ProgressWidth = 25;
            this.GPUProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.GPUProgressBar.Size = new System.Drawing.Size(185, 171);
            this.GPUProgressBar.StartAngle = 270;
            this.GPUProgressBar.Step = 1;
            this.GPUProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.GPUProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GPUProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.GPUProgressBar.SubscriptText = ".23";
            this.GPUProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.GPUProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.GPUProgressBar.SuperscriptText = "°C";
            this.GPUProgressBar.TabIndex = 21;
            this.GPUProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.GPUProgressBar.Value = 68;
            // 
            // GPUloadlevel
            // 
            this.GPUloadlevel.AutoSize = true;
            this.GPUloadlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUloadlevel.ForeColor = System.Drawing.Color.White;
            this.GPUloadlevel.Location = new System.Drawing.Point(1041, 188);
            this.GPUloadlevel.Name = "GPUloadlevel";
            this.GPUloadlevel.Size = new System.Drawing.Size(0, 29);
            this.GPUloadlevel.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(976, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Temperature:";
            // 
            // GPUTemplabel
            // 
            this.GPUTemplabel.AutoSize = true;
            this.GPUTemplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUTemplabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GPUTemplabel.Location = new System.Drawing.Point(1106, 347);
            this.GPUTemplabel.Name = "GPUTemplabel";
            this.GPUTemplabel.Size = new System.Drawing.Size(0, 24);
            this.GPUTemplabel.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1032, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = " Usage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1034, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 18);
            this.label10.TabIndex = 28;
            this.label10.Text = "(dedicated)";
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.celsiusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.celsiusLabel.Location = new System.Drawing.Point(1134, 347);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(29, 24);
            this.celsiusLabel.TabIndex = 29;
            this.celsiusLabel.Text = "°C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(1183, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Installed Vram:";
            // 
            // installedVRAMlabel
            // 
            this.installedVRAMlabel.AutoSize = true;
            this.installedVRAMlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.installedVRAMlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.installedVRAMlabel.Location = new System.Drawing.Point(1310, 163);
            this.installedVRAMlabel.Name = "installedVRAMlabel";
            this.installedVRAMlabel.Size = new System.Drawing.Size(0, 20);
            this.installedVRAMlabel.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(1361, 163);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 32;
            this.label12.Text = "MB";
            // 
            // mainchart
            // 
            this.mainchart.BackColor = System.Drawing.Color.Black;
            this.mainchart.BorderSkin.BackColor = System.Drawing.Color.White;
            this.mainchart.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackImageTransparentColor = System.Drawing.Color.White;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.mainchart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend1";
            this.mainchart.Legends.Add(legend1);
            this.mainchart.Location = new System.Drawing.Point(151, 423);
            this.mainchart.Name = "mainchart";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 3;
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Lime;
            series2.Legend = "Legend1";
            series2.MarkerBorderWidth = 3;
            series2.Name = "GPU (dedicated)";
            this.mainchart.Series.Add(series1);
            this.mainchart.Series.Add(series2);
            this.mainchart.Size = new System.Drawing.Size(1265, 401);
            this.mainchart.TabIndex = 34;
            this.mainchart.Text = "chart1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(1332, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "MB";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(1183, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 20);
            this.label13.TabIndex = 58;
            this.label13.Text = "Used Vram:";
            // 
            // UsedVramLabel
            // 
            this.UsedVramLabel.AutoSize = true;
            this.UsedVramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsedVramLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedVramLabel.Location = new System.Drawing.Point(1287, 197);
            this.UsedVramLabel.Name = "UsedVramLabel";
            this.UsedVramLabel.Size = new System.Drawing.Size(0, 20);
            this.UsedVramLabel.TabIndex = 57;
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AppVersionLabel.Location = new System.Drawing.Point(1242, 783);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(174, 32);
            this.AppVersionLabel.TabIndex = 60;
            this.AppVersionLabel.Text = "Beta Version 1.1.0.0 \r\nMade by Cosmin Petrescu\r\n";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(637, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 24);
            this.label14.TabIndex = 61;
            this.label14.Text = "Installed Memory:";
            // 
            // TotalMemLabel
            // 
            this.TotalMemLabel.AutoSize = true;
            this.TotalMemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TotalMemLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TotalMemLabel.Location = new System.Drawing.Point(800, 308);
            this.TotalMemLabel.Name = "TotalMemLabel";
            this.TotalMemLabel.Size = new System.Drawing.Size(0, 24);
            this.TotalMemLabel.TabIndex = 62;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1428, 824);
            this.Controls.Add(this.TotalMemLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.UsedVramLabel);
            this.Controls.Add(this.mainchart);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.installedVRAMlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GPUTemplabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GPUloadlevel);
            this.Controls.Add(this.GPUProgressBar);
            this.Controls.Add(this.GPUname_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CPUclockspeed_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CPUName_label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CPUTemp_label);
            this.Controls.Add(this.CloseAppButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AvailableMem_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MemoryProgressBar);
            this.Controls.Add(this.CPUusage_label);
            this.Controls.Add(this.CPUProgressBar);
            this.Controls.Add(this.decor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1428, 824);
            this.MinimumSize = new System.Drawing.Size(1428, 824);
            this.Name = "MainScreen";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CosMonitor";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.Shown += new System.EventHandler(this.MainScreen_Shown);
            this.decor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel decor1;
        private System.Windows.Forms.Button GPU;
        private System.Windows.Forms.Button CPU;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button CloseAppButton;
        private CircularProgressBar.CircularProgressBar CPUProgressBar;
        private System.Windows.Forms.Label CPUusage_label;
        private CircularProgressBar.CircularProgressBar MemoryProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AvailableMem_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CPUTemp_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CPUName_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CPUclockspeed_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GPUname_label;
        private System.Windows.Forms.Button RebootButton;
        private System.Windows.Forms.Button Internet_button;
        private CircularProgressBar.CircularProgressBar GPUProgressBar;
        private System.Windows.Forms.Label GPUloadlevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label GPUTemplabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label installedVRAMlabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainchart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label UsedVramLabel;
        private System.Windows.Forms.Label AppVersionLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TotalMemLabel;
    }
}

