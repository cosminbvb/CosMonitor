namespace CosMonitor
{
    partial class InternetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetForm));
            this.decor1 = new System.Windows.Forms.Panel();
            this.Internet_button = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.GPU = new System.Windows.Forms.Button();
            this.CPU = new System.Windows.Forms.Button();
            this.RebootButton = new System.Windows.Forms.Button();
            this.CloseAppButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.IPlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppVersionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.decor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.decor1.TabIndex = 1;
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
            this.CloseAppButton.Location = new System.Drawing.Point(1352, 12);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(64, 48);
            this.CloseAppButton.TabIndex = 11;
            this.CloseAppButton.UseVisualStyleBackColor = true;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Black;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartButton.Location = new System.Drawing.Point(596, 311);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(114, 73);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Start Testing";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(235, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Check your internet stability:";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Label.ForeColor = System.Drawing.Color.Gray;
            this.Label.Location = new System.Drawing.Point(236, 495);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(645, 192);
            this.Label.TabIndex = 17;
            this.Label.Text = resources.GetString("Label.Text");
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Blue;
            this.ResultLabel.Location = new System.Drawing.Point(770, 300);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 26);
            this.ResultLabel.TabIndex = 20;
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IPlabel.Location = new System.Drawing.Point(784, 106);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(176, 29);
            this.IPlabel.TabIndex = 62;
            this.IPlabel.Text = "What\'s my IP?";
            this.IPlabel.Click += new System.EventHandler(this.IPlabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(235, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 29);
            this.label2.TabIndex = 63;
            this.label2.Text = "How does it work?";
            // 
            // AppVersionLabel
            // 
            this.AppVersionLabel.AutoSize = true;
            this.AppVersionLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AppVersionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.AppVersionLabel.Location = new System.Drawing.Point(1242, 783);
            this.AppVersionLabel.Name = "AppVersionLabel";
            this.AppVersionLabel.Size = new System.Drawing.Size(174, 32);
            this.AppVersionLabel.TabIndex = 65;
            this.AppVersionLabel.Text = "Beta Version 1.1.0.0 \r\nMade by Cosmin Petrescu\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(235, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(535, 29);
            this.label3.TabIndex = 66;
            this.label3.Text = "Click here for information regardin your Public IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(235, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 58);
            this.label4.TabIndex = 67;
            this.label4.Text = "Click here for a speedtest:\r\n\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(533, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "Speedtest";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Black;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(240, 354);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(182, 30);
            this.numericUpDown1.TabIndex = 70;
            // 
            // InternetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1428, 824);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AppVersionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPlabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.CloseAppButton);
            this.Controls.Add(this.decor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1428, 824);
            this.MinimumSize = new System.Drawing.Size(1428, 824);
            this.Name = "InternetForm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InternetForm";
            this.Load += new System.EventHandler(this.InternetForm_Load);
            this.decor1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AppVersionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}