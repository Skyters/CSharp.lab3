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
            pbHSVandRGB = new PictureBox();
            lblDirectionRed = new Label();
            lblDirectionGreen = new Label();
            lblDirectionBlue = new Label();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbHue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHSVandRGB).BeginInit();
            SuspendLayout();
            // 
            // tbSaturation
            // 
            tbSaturation.Location = new Point(45, 272);
            tbSaturation.Margin = new Padding(3, 4, 3, 4);
            tbSaturation.Maximum = 100;
            tbSaturation.Name = "tbSaturation";
            tbSaturation.Size = new Size(119, 56);
            tbSaturation.TabIndex = 3;
            tbSaturation.Scroll += tbSaturation_Scroll;
            // 
            // tbBrightness
            // 
            tbBrightness.Location = new Point(45, 356);
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
            lblDirectionSaturation.Location = new Point(164, 272);
            lblDirectionSaturation.Name = "lblDirectionSaturation";
            lblDirectionSaturation.Size = new Size(45, 20);
            lblDirectionSaturation.TabIndex = 10;
            lblDirectionSaturation.Text = "100%";
            // 
            // lblDirectionBrightness
            // 
            lblDirectionBrightness.AutoSize = true;
            lblDirectionBrightness.Location = new Point(171, 356);
            lblDirectionBrightness.Name = "lblDirectionBrightness";
            lblDirectionBrightness.Size = new Size(45, 20);
            lblDirectionBrightness.TabIndex = 11;
            lblDirectionBrightness.Text = "100%";
            // 
            // bnTask
            // 
            bnTask.Location = new Point(224, 13);
            bnTask.Margin = new Padding(3, 4, 3, 4);
            bnTask.Name = "bnTask";
            bnTask.Size = new Size(86, 31);
            bnTask.TabIndex = 12;
            bnTask.Text = "Задание";
            bnTask.UseVisualStyleBackColor = true;
            
            // 
            // lblNameTbSaturation
            // 
            lblNameTbSaturation.AutoSize = true;
            lblNameTbSaturation.Location = new Point(50, 248);
            lblNameTbSaturation.Name = "lblNameTbSaturation";
            lblNameTbSaturation.Size = new Size(114, 20);
            lblNameTbSaturation.TabIndex = 19;
            lblNameTbSaturation.Text = "Насыщенность";
            // 
            // lblNameTbBrightness
            // 
            lblNameTbBrightness.AutoSize = true;
            lblNameTbBrightness.Location = new Point(59, 332);
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
            tbBlue.Location = new Point(356, 356);
            tbBlue.Maximum = 255;
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(130, 56);
            tbBlue.TabIndex = 24;
            tbBlue.Scroll += tbBlue_Scroll;
            // 
            // tbRed
            // 
            tbRed.Location = new Point(356, 192);
            tbRed.Maximum = 255;
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(130, 56);
            tbRed.TabIndex = 25;
            tbRed.Scroll += tbRed_Scroll;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(356, 274);
            tbGreen.Maximum = 255;
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(130, 56);
            tbGreen.TabIndex = 26;
            tbGreen.Scroll += tbGreen_Scroll;
            // 
            // lblNameBlue
            // 
            lblNameBlue.AutoSize = true;
            lblNameBlue.Location = new Point(356, 333);
            lblNameBlue.Name = "lblNameBlue";
            lblNameBlue.Size = new Size(54, 20);
            lblNameBlue.TabIndex = 27;
            lblNameBlue.Text = "Синий";
            // 
            // lblNameRed
            // 
            lblNameRed.AutoSize = true;
            lblNameRed.Location = new Point(356, 169);
            lblNameRed.Name = "lblNameRed";
            lblNameRed.Size = new Size(71, 20);
            lblNameRed.TabIndex = 28;
            lblNameRed.Text = "Красный";
            // 
            // lblNameGreen
            // 
            lblNameGreen.AutoSize = true;
            lblNameGreen.Location = new Point(357, 251);
            lblNameGreen.Name = "lblNameGreen";
            lblNameGreen.Size = new Size(70, 20);
            lblNameGreen.TabIndex = 29;
            lblNameGreen.Text = "Зелёный";
            // 
            // pbHSVandRGB
            // 
            pbHSVandRGB.Location = new Point(224, 192);
            pbHSVandRGB.Name = "pbHSVandRGB";
            pbHSVandRGB.Size = new Size(113, 185);
            pbHSVandRGB.TabIndex = 30;
            pbHSVandRGB.TabStop = false;
            // 
            // lblDirectionRed
            // 
            lblDirectionRed.AutoSize = true;
            lblDirectionRed.Location = new Point(492, 192);
            lblDirectionRed.Name = "lblDirectionRed";
            lblDirectionRed.Size = new Size(17, 20);
            lblDirectionRed.TabIndex = 31;
            lblDirectionRed.Text = "0";
            // 
            // lblDirectionGreen
            // 
            lblDirectionGreen.AutoSize = true;
            lblDirectionGreen.Location = new Point(492, 274);
            lblDirectionGreen.Name = "lblDirectionGreen";
            lblDirectionGreen.Size = new Size(17, 20);
            lblDirectionGreen.TabIndex = 32;
            lblDirectionGreen.Text = "0";
            // 
            // lblDirectionBlue
            // 
            lblDirectionBlue.AutoSize = true;
            lblDirectionBlue.Location = new Point(492, 356);
            lblDirectionBlue.Name = "lblDirectionBlue";
            lblDirectionBlue.Size = new Size(17, 20);
            lblDirectionBlue.TabIndex = 33;
            lblDirectionBlue.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 414);
            Controls.Add(lblDirectionBlue);
            Controls.Add(lblDirectionGreen);
            Controls.Add(lblDirectionRed);
            Controls.Add(pbHSVandRGB);
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
            ((System.ComponentModel.ISupportInitialize)tbHue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHSVandRGB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar tbSaturation;
        private TrackBar tbBrightness;
        private Label lblDirectionSaturation;
        private Label lblDirectionBrightness;
        private Button bnTask;
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
        private PictureBox pbHSVandRGB;
        private Label lblDirectionRed;
        private Label lblDirectionGreen;
        private Label lblDirectionBlue;
    }
}
