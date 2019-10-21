namespace CosMonitor
{
    partial class GPUForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPUForm));
            this.decor1 = new System.Windows.Forms.Panel();
            this.Internet_button = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GPU = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.Button();
            this.RebootButton = new System.Windows.Forms.Button();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.GPUTimer = new System.Windows.Forms.Timer(this.components);
            this.celsiusLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GPUTemplabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GPUloadlevel = new System.Windows.Forms.Label();
            this.GPUProgressBar = new CircularProgressBar.CircularProgressBar();
            this.GPUname_label = new System.Windows.Forms.Label();
            this.Welcome_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.installedVRAMlabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VRAMlabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UsedVramLabel = new System.Windows.Forms.Label();
            this.label9999 = new System.Windows.Forms.Label();
            this.GPUcoreLabel = new System.Windows.Forms.Label();
            this.label999 = new System.Windows.Forms.Label();
            this.GPUmemoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.decor1.SuspendLayout();
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
            this.decor1.TabIndex = 14;
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
            this.RebootButton.Click += new System.EventHandler(this.RebootButton_Click);
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseAppButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseAppButton.Image")));
            this.CloseAppButton.Location = new System.Drawing.Point(1355, 12);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(64, 48);
            this.CloseAppButton.TabIndex = 13;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // GPUTimer
            // 
            this.GPUTimer.Enabled = true;
            this.GPUTimer.Interval = 1000;
            this.GPUTimer.Tick += new System.EventHandler(this.GPUTimer_Tick);
            // 
            // celsiusLabel
            // 
            this.celsiusLabel.AutoSize = true;
            this.celsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.celsiusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.celsiusLabel.Location = new System.Drawing.Point(883, 413);
            this.celsiusLabel.Name = "celsiusLabel";
            this.celsiusLabel.Size = new System.Drawing.Size(29, 24);
            this.celsiusLabel.TabIndex = 46;
            this.celsiusLabel.Text = "°C";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(725, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = " Usage:";
            // 
            // GPUTemplabel
            // 
            this.GPUTemplabel.AutoSize = true;
            this.GPUTemplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUTemplabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GPUTemplabel.Location = new System.Drawing.Point(855, 413);
            this.GPUTemplabel.Name = "GPUTemplabel";
            this.GPUTemplabel.Size = new System.Drawing.Size(20, 24);
            this.GPUTemplabel.TabIndex = 41;
            this.GPUTemplabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(726, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 40;
            this.label6.Text = "Temperature:";
            // 
            // GPUloadlevel
            // 
            this.GPUloadlevel.AutoSize = true;
            this.GPUloadlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUloadlevel.ForeColor = System.Drawing.Color.White;
            this.GPUloadlevel.Location = new System.Drawing.Point(895, 273);
            this.GPUloadlevel.Name = "GPUloadlevel";
            this.GPUloadlevel.Size = new System.Drawing.Size(0, 29);
            this.GPUloadlevel.TabIndex = 39;
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
            this.GPUProgressBar.Location = new System.Drawing.Point(834, 200);
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
            this.GPUProgressBar.TabIndex = 38;
            this.GPUProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.GPUProgressBar.Value = 10;
            // 
            // GPUname_label
            // 
            this.GPUname_label.AutoSize = true;
            this.GPUname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUname_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GPUname_label.Location = new System.Drawing.Point(322, 200);
            this.GPUname_label.Name = "GPUname_label";
            this.GPUname_label.Size = new System.Drawing.Size(0, 25);
            this.GPUname_label.TabIndex = 37;
            // 
            // Welcome_label
            // 
            this.Welcome_label.AutoSize = true;
            this.Welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Welcome_label.ForeColor = System.Drawing.Color.MediumBlue;
            this.Welcome_label.Location = new System.Drawing.Point(488, 110);
            this.Welcome_label.Name = "Welcome_label";
            this.Welcome_label.Size = new System.Drawing.Size(0, 25);
            this.Welcome_label.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(490, 446);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 20);
            this.label13.TabIndex = 52;
            this.label13.Text = "MB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(530, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "MB";
            // 
            // installedVRAMlabel
            // 
            this.installedVRAMlabel.AutoSize = true;
            this.installedVRAMlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.installedVRAMlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.installedVRAMlabel.Location = new System.Drawing.Point(471, 392);
            this.installedVRAMlabel.Name = "installedVRAMlabel";
            this.installedVRAMlabel.Size = new System.Drawing.Size(18, 20);
            this.installedVRAMlabel.TabIndex = 50;
            this.installedVRAMlabel.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(323, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Installed Vram:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(323, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 24);
            this.label7.TabIndex = 48;
            this.label7.Text = "Free Vram:";
            // 
            // VRAMlabel
            // 
            this.VRAMlabel.AutoSize = true;
            this.VRAMlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VRAMlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.VRAMlabel.Location = new System.Drawing.Point(438, 442);
            this.VRAMlabel.Name = "VRAMlabel";
            this.VRAMlabel.Size = new System.Drawing.Size(18, 20);
            this.VRAMlabel.TabIndex = 47;
            this.VRAMlabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(321, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 29);
            this.label5.TabIndex = 53;
            this.label5.Text = "Real Time Information:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(490, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "MB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(323, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Used Vram:";
            // 
            // UsedVramLabel
            // 
            this.UsedVramLabel.AutoSize = true;
            this.UsedVramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UsedVramLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UsedVramLabel.Location = new System.Drawing.Point(438, 499);
            this.UsedVramLabel.Name = "UsedVramLabel";
            this.UsedVramLabel.Size = new System.Drawing.Size(18, 20);
            this.UsedVramLabel.TabIndex = 54;
            this.UsedVramLabel.Text = "0";
            // 
            // label9999
            // 
            this.label9999.AutoSize = true;
            this.label9999.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9999.ForeColor = System.Drawing.SystemColors.Control;
            this.label9999.Location = new System.Drawing.Point(323, 278);
            this.label9999.Name = "label9999";
            this.label9999.Size = new System.Drawing.Size(100, 24);
            this.label9999.TabIndex = 57;
            this.label9999.Text = "GPU Core:";
            // 
            // GPUcoreLabel
            // 
            this.GPUcoreLabel.AutoSize = true;
            this.GPUcoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUcoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GPUcoreLabel.Location = new System.Drawing.Point(434, 280);
            this.GPUcoreLabel.Name = "GPUcoreLabel";
            this.GPUcoreLabel.Size = new System.Drawing.Size(18, 20);
            this.GPUcoreLabel.TabIndex = 58;
            this.GPUcoreLabel.Text = "0";
            // 
            // label999
            // 
            this.label999.AutoSize = true;
            this.label999.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label999.ForeColor = System.Drawing.SystemColors.Control;
            this.label999.Location = new System.Drawing.Point(322, 337);
            this.label999.Name = "label999";
            this.label999.Size = new System.Drawing.Size(128, 24);
            this.label999.TabIndex = 60;
            this.label999.Text = "GPU Memory:";
            // 
            // GPUmemoryLabel
            // 
            this.GPUmemoryLabel.AutoSize = true;
            this.GPUmemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GPUmemoryLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.GPUmemoryLabel.Location = new System.Drawing.Point(470, 337);
            this.GPUmemoryLabel.Name = "GPUmemoryLabel";
            this.GPUmemoryLabel.Size = new System.Drawing.Size(18, 20);
            this.GPUmemoryLabel.TabIndex = 61;
            this.GPUmemoryLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(490, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "MHz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(519, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "MHz";
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AppVersionLabel.Location = new System.Drawing.Point(1242, 783);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(174, 32);
            this.AppVersionLabel.TabIndex = 64;
            this.AppVersionLabel.Text = "Beta Version 1.1.0.0 \r\nMade by Cosmin Petrescu\r\n";
            // 
            // GPUForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1428, 824);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GPUmemoryLabel);
            this.Controls.Add(this.label999);
            this.Controls.Add(this.GPUcoreLabel);
            this.Controls.Add(this.label9999);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsedVramLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.installedVRAMlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VRAMlabel);
            this.Controls.Add(this.celsiusLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GPUTemplabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GPUloadlevel);
            this.Controls.Add(this.GPUProgressBar);
            this.Controls.Add(this.GPUname_label);
            this.Controls.Add(this.Welcome_label);
            this.Controls.Add(this.CloseAppButton);
            this.Controls.Add(this.decor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1428, 824);
            this.MinimumSize = new System.Drawing.Size(1428, 824);
            this.Name = "GPUForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "GPUForm";
            this.Load += new System.EventHandler(this.GPUForm_Load);
            this.Shown += new System.EventHandler(this.GPUForm_Shown);
            this.decor1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel decor1;
        private System.Windows.Forms.Button Internet_button;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button GPU;
        private System.Windows.Forms.Button CPU;
        private System.Windows.Forms.Button RebootButton;
        private System.Windows.Forms.Button CloseAppButton;
        private System.Windows.Forms.Timer GPUTimer;
        private System.Windows.Forms.Label celsiusLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label GPUTemplabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label GPUloadlevel;
        private CircularProgressBar.CircularProgressBar GPUProgressBar;
        private System.Windows.Forms.Label GPUname_label;
        private System.Windows.Forms.Label Welcome_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label installedVRAMlabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label VRAMlabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label UsedVramLabel;
        private System.Windows.Forms.Label label9999;
        private System.Windows.Forms.Label GPUcoreLabel;
        private System.Windows.Forms.Label label999;
        private System.Windows.Forms.Label GPUmemoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label AppVersionLabel;
    }
}