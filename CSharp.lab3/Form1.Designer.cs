namespace CSharp.lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbSaturation = new TrackBar();
            tbBrightness = new TrackBar();
            lblDirectionSaturation = new Label();
            lblDirectionBrightness = new Label();
            bnTask = new Button();
            pbHSV = new PictureBox();
            lblHSV = new Label();
            lblNameTbSaturation = new Label();
            lblNameTbBrightness = new Label();
            tbHue = new TrackBar();
            lblDirectionHue = new Label();
            lblNameHSV = new Label();
            tbBlue = new TrackBar();
            tbRed = new TrackBar();
            tbGreen = new TrackBar();
            lblNameBlue = new Label();
            lblNameRed = new Label();
            lblNameGreen = new Label();
            pbRGB = new PictureBox();
            lblDirectionRed = new Label();
            lblDirectionGreen = new Label();
            lblDirectionBlue = new Label();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHSV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbHue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRGB).BeginInit();
            SuspendLayout();
            // 
            // tbSaturation
            // 
            tbSaturation.Location = new Point(218, 447);
            tbSaturation.Margin = new Padding(3, 4, 3, 4);
            tbSaturation.Maximum = 100;
            tbSaturation.Name = "tbSaturation";
            tbSaturation.Size = new Size(119, 56);
            tbSaturation.TabIndex = 3;
            tbSaturation.Scroll += tbSaturation_Scroll;
            // 
            // tbBrightness
            // 
            tbBrightness.Location = new Point(387, 447);
            tbBrightness.Margin = new Padding(3, 4, 3, 4);
            tbBrightness.Maximum = 100;
            tbBrightness.Name = "tbBrightness";
            tbBrightness.Size = new Size(119, 56);
            tbBrightness.TabIndex = 5;
            tbBrightness.Scroll += tbBrightness_Scroll;
            // 
            // lblDirectionSaturation
            // 
            lblDirectionSaturation.AutoSize = true;
            lblDirectionSaturation.Location = new Point(337, 447);
            lblDirectionSaturation.Name = "lblDirectionSaturation";
            lblDirectionSaturation.Size = new Size(45, 20);
            lblDirectionSaturation.TabIndex = 10;
            lblDirectionSaturation.Text = "100%";
            // 
            // lblDirectionBrightness
            // 
            lblDirectionBrightness.AutoSize = true;
            lblDirectionBrightness.Location = new Point(513, 447);
            lblDirectionBrightness.Name = "lblDirectionBrightness";
            lblDirectionBrightness.Size = new Size(45, 20);
            lblDirectionBrightness.TabIndex = 11;
            lblDirectionBrightness.Text = "100%";
            // 
            // bnTask
            // 
            bnTask.Location = new Point(59, 96);
            bnTask.Margin = new Padding(3, 4, 3, 4);
            bnTask.Name = "bnTask";
            bnTask.Size = new Size(86, 31);
            bnTask.TabIndex = 12;
            bnTask.Text = "Задание";
            bnTask.UseVisualStyleBackColor = true;
            // 
            // pbHSV
            // 
            pbHSV.Location = new Point(223, 216);
            pbHSV.Margin = new Padding(3, 4, 3, 4);
            pbHSV.Name = "pbHSV";
            pbHSV.Size = new Size(114, 197);
            pbHSV.TabIndex = 13;
            pbHSV.TabStop = false;
            // 
            // lblHSV
            // 
            lblHSV.AutoSize = true;
            lblHSV.Location = new Point(223, 192);
            lblHSV.Name = "lblHSV";
            lblHSV.Size = new Size(37, 20);
            lblHSV.TabIndex = 14;
            lblHSV.Text = "HSV";
            // 
            // lblNameTbSaturation
            // 
            lblNameTbSaturation.AutoSize = true;
            lblNameTbSaturation.Location = new Point(223, 423);
            lblNameTbSaturation.Name = "lblNameTbSaturation";
            lblNameTbSaturation.Size = new Size(114, 20);
            lblNameTbSaturation.TabIndex = 19;
            lblNameTbSaturation.Text = "Насыщенность";
            // 
            // lblNameTbBrightness
            // 
            lblNameTbBrightness.AutoSize = true;
            lblNameTbBrightness.Location = new Point(401, 423);
            lblNameTbBrightness.Name = "lblNameTbBrightness";
            lblNameTbBrightness.Size = new Size(64, 20);
            lblNameTbBrightness.TabIndex = 20;
            lblNameTbBrightness.Text = "Яркость";
            // 
            // tbHue
            // 
            tbHue.Location = new Point(45, 192);
            tbHue.Margin = new Padding(3, 4, 3, 4);
            tbHue.Maximum = 360;
            tbHue.Name = "tbHue";
            tbHue.Size = new Size(119, 56);
            tbHue.TabIndex = 21;
            tbHue.Scroll += tbHue_Scroll;
            // 
            // lblDirectionHue
            // 
            lblDirectionHue.AutoSize = true;
            lblDirectionHue.Location = new Point(170, 192);
            lblDirectionHue.Name = "lblDirectionHue";
            lblDirectionHue.Size = new Size(23, 20);
            lblDirectionHue.TabIndex = 22;
            lblDirectionHue.Text = "0°";
            // 
            // lblNameHSV
            // 
            lblNameHSV.AutoSize = true;
            lblNameHSV.Location = new Point(59, 168);
            lblNameHSV.Name = "lblNameHSV";
            lblNameHSV.Size = new Size(37, 20);
            lblNameHSV.TabIndex = 23;
            lblNameHSV.Text = "HSV";
            // 
            // tbBlue
            // 
            tbBlue.Location = new Point(718, 178);
            tbBlue.Maximum = 360;
            tbBlue.Minimum = 240;
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(130, 56);
            tbBlue.TabIndex = 24;
            tbBlue.Value = 240;
            tbBlue.Scroll += tbBlue_Scroll;
            // 
            // tbRed
            // 
            tbRed.Location = new Point(718, 251);
            tbRed.Maximum = 120;
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(130, 56);
            tbRed.TabIndex = 25;
            tbRed.Scroll += tbRed_Scroll;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(718, 96);
            tbGreen.Maximum = 240;
            tbGreen.Minimum = 120;
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(130, 56);
            tbGreen.TabIndex = 26;
            tbGreen.Value = 240;
            tbGreen.Scroll += tbGreen_Scroll;
            // 
            // lblNameBlue
            // 
            lblNameBlue.AutoSize = true;
            lblNameBlue.Location = new Point(718, 155);
            lblNameBlue.Name = "lblNameBlue";
            lblNameBlue.Size = new Size(54, 20);
            lblNameBlue.TabIndex = 27;
            lblNameBlue.Text = "Синий";
            // 
            // lblNameRed
            // 
            lblNameRed.AutoSize = true;
            lblNameRed.Location = new Point(718, 228);
            lblNameRed.Name = "lblNameRed";
            lblNameRed.Size = new Size(71, 20);
            lblNameRed.TabIndex = 28;
            lblNameRed.Text = "Красный";
            // 
            // lblNameGreen
            // 
            lblNameGreen.AutoSize = true;
            lblNameGreen.Location = new Point(719, 73);
            lblNameGreen.Name = "lblNameGreen";
            lblNameGreen.Size = new Size(70, 20);
            lblNameGreen.TabIndex = 29;
            lblNameGreen.Text = "Зелёный";
            // 
            // pbRGB
            // 
            pbRGB.Location = new Point(464, 182);
            pbRGB.Name = "pbRGB";
            pbRGB.Size = new Size(113, 185);
            pbRGB.TabIndex = 30;
            pbRGB.TabStop = false;
            // 
            // lblDirectionRed
            // 
            lblDirectionRed.AutoSize = true;
            lblDirectionRed.Location = new Point(854, 251);
            lblDirectionRed.Name = "lblDirectionRed";
            lblDirectionRed.Size = new Size(17, 20);
            lblDirectionRed.TabIndex = 31;
            lblDirectionRed.Text = "0";
            // 
            // lblDirectionGreen
            // 
            lblDirectionGreen.AutoSize = true;
            lblDirectionGreen.Location = new Point(854, 96);
            lblDirectionGreen.Name = "lblDirectionGreen";
            lblDirectionGreen.Size = new Size(17, 20);
            lblDirectionGreen.TabIndex = 32;
            lblDirectionGreen.Text = "0";
            // 
            // lblDirectionBlue
            // 
            lblDirectionBlue.AutoSize = true;
            lblDirectionBlue.Location = new Point(854, 178);
            lblDirectionBlue.Name = "lblDirectionBlue";
            lblDirectionBlue.Size = new Size(17, 20);
            lblDirectionBlue.TabIndex = 33;
            lblDirectionBlue.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblDirectionBlue);
            Controls.Add(lblDirectionGreen);
            Controls.Add(lblDirectionRed);
            Controls.Add(pbRGB);
            Controls.Add(lblNameGreen);
            Controls.Add(lblNameRed);
            Controls.Add(lblNameBlue);
            Controls.Add(tbGreen);
            Controls.Add(tbRed);
            Controls.Add(tbBlue);
            Controls.Add(lblNameHSV);
            Controls.Add(lblDirectionHue);
            Controls.Add(tbHue);
            Controls.Add(lblNameTbBrightness);
            Controls.Add(lblNameTbSaturation);
            Controls.Add(lblHSV);
            Controls.Add(pbHSV);
            Controls.Add(bnTask);
            Controls.Add(lblDirectionBrightness);
            Controls.Add(lblDirectionSaturation);
            Controls.Add(tbBrightness);
            Controls.Add(tbSaturation);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHSV).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbHue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRGB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar tbSaturation;
        private TrackBar tbBrightness;
        private Label lblDirectionSaturation;
        private Label lblDirectionBrightness;
        private Button bnTask;
        private PictureBox pbHSV;
        private Label lblHSV;
        private Label lblNameTbSaturation;
        private Label lblNameTbBrightness;
        private TrackBar tbHue;
        private Label lblDirectionHue;
        private Label lblNameHSV;
        private TrackBar tbBlue;
        private TrackBar tbRed;
        private TrackBar tbGreen;
        private Label lblNameBlue;
        private Label lblNameRed;
        private Label lblNameGreen;
        private PictureBox pbRGB;
        private Label lblDirectionRed;
        private Label lblDirectionGreen;
        private Label lblDirectionBlue;
    }
}
