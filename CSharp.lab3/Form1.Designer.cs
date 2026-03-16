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
            tbBlue = new TrackBar();
            tbHSV = new TrackBar();
            tbRed = new TrackBar();
            tbSaturation = new TrackBar();
            tbGreen = new TrackBar();
            tbBrightness = new TrackBar();
            lblDirectionHSV = new Label();
            lblDirectionBlue = new Label();
            lblDirectionRed = new Label();
            lblDirectionGreen = new Label();
            lblDirectionSaturation = new Label();
            lblDirectionBrightness = new Label();
            bn = new Button();
            pbHSV = new PictureBox();
            lblHSV = new Label();
            ((System.ComponentModel.ISupportInitialize)tbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbHSV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHSV).BeginInit();
            SuspendLayout();
            // 
            // tbBlue
            // 
            tbBlue.Location = new Point(39, 214);
            tbBlue.Name = "tbBlue";
            tbBlue.Size = new Size(104, 45);
            tbBlue.TabIndex = 0;
            // 
            // tbHSV
            // 
            tbHSV.Location = new Point(39, 163);
            tbHSV.Name = "tbHSV";
            tbHSV.Size = new Size(104, 45);
            tbHSV.TabIndex = 1;
            // 
            // tbRed
            // 
            tbRed.Location = new Point(39, 265);
            tbRed.Name = "tbRed";
            tbRed.Size = new Size(104, 45);
            tbRed.TabIndex = 2;
            // 
            // tbSaturation
            // 
            tbSaturation.Location = new Point(191, 316);
            tbSaturation.Name = "tbSaturation";
            tbSaturation.Size = new Size(104, 45);
            tbSaturation.TabIndex = 3;
            // 
            // tbGreen
            // 
            tbGreen.Location = new Point(39, 316);
            tbGreen.Name = "tbGreen";
            tbGreen.Size = new Size(104, 45);
            tbGreen.TabIndex = 4;
            // 
            // tbBrightness
            // 
            tbBrightness.Location = new Point(339, 316);
            tbBrightness.Name = "tbBrightness";
            tbBrightness.Size = new Size(104, 45);
            tbBrightness.TabIndex = 5;
            // 
            // lblDirectionHSV
            // 
            lblDirectionHSV.AutoSize = true;
            lblDirectionHSV.Location = new Point(149, 163);
            lblDirectionHSV.Name = "lblDirectionHSV";
            lblDirectionHSV.Size = new Size(18, 15);
            lblDirectionHSV.TabIndex = 6;
            lblDirectionHSV.Text = "0°";
            // 
            // lblDirectionBlue
            // 
            lblDirectionBlue.AutoSize = true;
            lblDirectionBlue.Location = new Point(149, 214);
            lblDirectionBlue.Name = "lblDirectionBlue";
            lblDirectionBlue.Size = new Size(18, 15);
            lblDirectionBlue.TabIndex = 7;
            lblDirectionBlue.Text = "0°";
            // 
            // lblDirectionRed
            // 
            lblDirectionRed.AutoSize = true;
            lblDirectionRed.Location = new Point(149, 265);
            lblDirectionRed.Name = "lblDirectionRed";
            lblDirectionRed.Size = new Size(18, 15);
            lblDirectionRed.TabIndex = 8;
            lblDirectionRed.Text = "0°";
            // 
            // lblDirectionGreen
            // 
            lblDirectionGreen.AutoSize = true;
            lblDirectionGreen.Location = new Point(149, 316);
            lblDirectionGreen.Name = "lblDirectionGreen";
            lblDirectionGreen.Size = new Size(18, 15);
            lblDirectionGreen.TabIndex = 9;
            lblDirectionGreen.Text = "0°";
            // 
            // lblDirectionSaturation
            // 
            lblDirectionSaturation.AutoSize = true;
            lblDirectionSaturation.Location = new Point(295, 316);
            lblDirectionSaturation.Name = "lblDirectionSaturation";
            lblDirectionSaturation.Size = new Size(18, 15);
            lblDirectionSaturation.TabIndex = 10;
            lblDirectionSaturation.Text = "0°";
            // 
            // lblDirectionBrightness
            // 
            lblDirectionBrightness.AutoSize = true;
            lblDirectionBrightness.Location = new Point(449, 316);
            lblDirectionBrightness.Name = "lblDirectionBrightness";
            lblDirectionBrightness.Size = new Size(18, 15);
            lblDirectionBrightness.TabIndex = 11;
            lblDirectionBrightness.Text = "0°";
            // 
            // bn
            // 
            bn.Location = new Point(52, 72);
            bn.Name = "bn";
            bn.Size = new Size(75, 23);
            bn.TabIndex = 12;
            bn.Text = "Задание";
            bn.UseVisualStyleBackColor = true;
            // 
            // pbHSV
            // 
            pbHSV.Location = new Point(387, 93);
            pbHSV.Name = "pbHSV";
            pbHSV.Size = new Size(100, 148);
            pbHSV.TabIndex = 13;
            pbHSV.TabStop = false;
            // 
            // lblHSV
            // 
            lblHSV.AutoSize = true;
            lblHSV.Location = new Point(387, 75);
            lblHSV.Name = "lblHSV";
            lblHSV.Size = new Size(29, 15);
            lblHSV.TabIndex = 14;
            lblHSV.Text = "HSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHSV);
            Controls.Add(pbHSV);
            Controls.Add(bn);
            Controls.Add(lblDirectionBrightness);
            Controls.Add(lblDirectionSaturation);
            Controls.Add(lblDirectionGreen);
            Controls.Add(lblDirectionRed);
            Controls.Add(lblDirectionBlue);
            Controls.Add(lblDirectionHSV);
            Controls.Add(tbBrightness);
            Controls.Add(tbGreen);
            Controls.Add(tbSaturation);
            Controls.Add(tbRed);
            Controls.Add(tbHSV);
            Controls.Add(tbBlue);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbHSV).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHSV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbBlue;
        private TrackBar tbHSV;
        private TrackBar tbRed;
        private TrackBar tbSaturation;
        private TrackBar tbGreen;
        private TrackBar tbBrightness;
        private Label lblDirectionHSV;
        private Label lblDirectionBlue;
        private Label lblDirectionRed;
        private Label lblDirectionGreen;
        private Label lblDirectionSaturation;
        private Label lblDirectionBrightness;
        private Button bn;
        private PictureBox pbHSV;
        private Label lblHSV;
    }
}
