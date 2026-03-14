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
            tbDirectionBlue = new TrackBar();
            lblDirectionBlue = new Label();
            tbDirectionRed = new TrackBar();
            lblDirectionRed = new Label();
            tbDirectionGreen = new TrackBar();
            lblDirectionGreen = new Label();
            lblBlue = new Label();
            lblRed = new Label();
            lblGreen = new Label();
            lblSaturation = new Label();
            lblDirectionSaturation = new Label();
            tbDirectionSaturation = new TrackBar();
            lblValue = new Label();
            lblDirectionBrightness = new Label();
            tbDirectionValue = new TrackBar();
            button1 = new Button();
            pnlHSV = new Panel();
            pnlRGB = new Panel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)tbDirectionBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionValue).BeginInit();
            SuspendLayout();
            // 
            // tbDirectionBlue
            // 
            tbDirectionBlue.Location = new Point(10, 140);
            tbDirectionBlue.Margin = new Padding(3, 2, 3, 2);
            tbDirectionBlue.Maximum = 360;
            tbDirectionBlue.Name = "tbDirectionBlue";
            tbDirectionBlue.Size = new Size(139, 45);
            tbDirectionBlue.TabIndex = 0;
            tbDirectionBlue.Scroll += tbDirection_Scroll;
            // 
            // lblDirectionBlue
            // 
            lblDirectionBlue.AutoSize = true;
            lblDirectionBlue.Location = new Point(155, 140);
            lblDirectionBlue.Name = "lblDirectionBlue";
            lblDirectionBlue.Size = new Size(18, 15);
            lblDirectionBlue.TabIndex = 1;
            lblDirectionBlue.Text = "0°";
            // 
            // tbDirectionRed
            // 
            tbDirectionRed.Location = new Point(10, 203);
            tbDirectionRed.Margin = new Padding(3, 2, 3, 2);
            tbDirectionRed.Maximum = 360;
            tbDirectionRed.Name = "tbDirectionRed";
            tbDirectionRed.Size = new Size(139, 45);
            tbDirectionRed.TabIndex = 2;
            tbDirectionRed.Scroll += tbDirectionRed_Scroll;
            // 
            // lblDirectionRed
            // 
            lblDirectionRed.AutoSize = true;
            lblDirectionRed.Location = new Point(155, 203);
            lblDirectionRed.Name = "lblDirectionRed";
            lblDirectionRed.Size = new Size(18, 15);
            lblDirectionRed.TabIndex = 3;
            lblDirectionRed.Text = "0°";
            // 
            // tbDirectionGreen
            // 
            tbDirectionGreen.Location = new Point(10, 256);
            tbDirectionGreen.Margin = new Padding(3, 2, 3, 2);
            tbDirectionGreen.Maximum = 360;
            tbDirectionGreen.Name = "tbDirectionGreen";
            tbDirectionGreen.Size = new Size(139, 45);
            tbDirectionGreen.TabIndex = 4;
            // 
            // lblDirectionGreen
            // 
            lblDirectionGreen.AutoSize = true;
            lblDirectionGreen.Location = new Point(155, 256);
            lblDirectionGreen.Name = "lblDirectionGreen";
            lblDirectionGreen.Size = new Size(18, 15);
            lblDirectionGreen.TabIndex = 5;
            lblDirectionGreen.Text = "0°";
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(19, 122);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(43, 15);
            lblBlue.TabIndex = 6;
            lblBlue.Text = "Синий";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(19, 184);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(56, 15);
            lblRed.TabIndex = 7;
            lblRed.Text = "Красный";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(19, 239);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(56, 15);
            lblGreen.TabIndex = 8;
            lblGreen.Text = "Зелёный";
            // 
            // lblSaturation
            // 
            lblSaturation.AutoSize = true;
            lblSaturation.Location = new Point(189, 239);
            lblSaturation.Name = "lblSaturation";
            lblSaturation.Size = new Size(92, 15);
            lblSaturation.TabIndex = 11;
            lblSaturation.Text = "Насыщённость";
            // 
            // lblDirectionSaturation
            // 
            lblDirectionSaturation.AutoSize = true;
            lblDirectionSaturation.Location = new Point(325, 256);
            lblDirectionSaturation.Name = "lblDirectionSaturation";
            lblDirectionSaturation.Size = new Size(13, 15);
            lblDirectionSaturation.TabIndex = 10;
            lblDirectionSaturation.Text = "0";
            // 
            // tbDirectionSaturation
            // 
            tbDirectionSaturation.Location = new Point(180, 256);
            tbDirectionSaturation.Margin = new Padding(3, 2, 3, 2);
            tbDirectionSaturation.Maximum = 100;
            tbDirectionSaturation.Name = "tbDirectionSaturation";
            tbDirectionSaturation.Size = new Size(139, 45);
            tbDirectionSaturation.TabIndex = 9;
            tbDirectionSaturation.Value = 1;
            tbDirectionSaturation.Scroll += tbDirectionSaturation_Scroll;
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(359, 239);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(51, 15);
            lblValue.TabIndex = 14;
            lblValue.Text = "Яркость";
            // 
            // lblDirectionBrightness
            // 
            lblDirectionBrightness.AutoSize = true;
            lblDirectionBrightness.Location = new Point(494, 256);
            lblDirectionBrightness.Name = "lblDirectionBrightness";
            lblDirectionBrightness.Size = new Size(13, 15);
            lblDirectionBrightness.TabIndex = 13;
            lblDirectionBrightness.Text = "0";
            // 
            // tbDirectionValue
            // 
            tbDirectionValue.Location = new Point(350, 256);
            tbDirectionValue.Margin = new Padding(3, 2, 3, 2);
            tbDirectionValue.Maximum = 100;
            tbDirectionValue.Name = "tbDirectionValue";
            tbDirectionValue.Size = new Size(139, 45);
            tbDirectionValue.TabIndex = 12;
            tbDirectionValue.Scroll += tbDirectionBrightness_Scroll;
            // 
            // button1
            // 
            button1.Location = new Point(19, 9);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 15;
            button1.Text = "Задание";
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlHSV
            // 
            pnlHSV.BackColor = SystemColors.Control;
            pnlHSV.Location = new Point(196, 44);
            pnlHSV.Margin = new Padding(3, 2, 3, 2);
            pnlHSV.Name = "pnlHSV";
            pnlHSV.Size = new Size(123, 167);
            pnlHSV.TabIndex = 16;
            // 
            // pnlRGB
            // 
            pnlRGB.Location = new Point(359, 44);
            pnlRGB.Margin = new Padding(3, 2, 3, 2);
            pnlRGB.Name = "pnlRGB";
            pnlRGB.Size = new Size(123, 167);
            pnlRGB.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 26);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 18;
            label1.Text = "HSV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 26);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 19;
            label2.Text = "RGB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 338);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlRGB);
            Controls.Add(pnlHSV);
            Controls.Add(button1);
            Controls.Add(lblValue);
            Controls.Add(lblDirectionBrightness);
            Controls.Add(tbDirectionValue);
            Controls.Add(lblSaturation);
            Controls.Add(lblDirectionSaturation);
            Controls.Add(tbDirectionSaturation);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(lblBlue);
            Controls.Add(lblDirectionGreen);
            Controls.Add(tbDirectionGreen);
            Controls.Add(lblDirectionRed);
            Controls.Add(tbDirectionRed);
            Controls.Add(lblDirectionBlue);
            Controls.Add(tbDirectionBlue);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbDirectionBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbDirectionBlue;
        private Label lblDirectionBlue;
        private TrackBar tbDirectionRed;
        private Label lblDirectionRed;
        private TrackBar tbDirectionGreen;
        private Label lblDirectionGreen;
        private Label lblBlue;
        private Label lblRed;
        private Label lblGreen;
        private Label lblSaturation;
        private Label lblDirectionSaturation;
        private TrackBar tbDirectionSaturation;
        private Label lblValue;
        private Label lblDirectionBrightness;
        private TrackBar tbDirectionValue;
        private Button button1;
        private Panel pnlHSV;
        private Panel pnlRGB;
        private Label label1;
        private Label label2;
    }
}
