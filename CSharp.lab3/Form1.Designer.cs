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
            lblBrightness = new Label();
            lblDirectionBrightness = new Label();
            tbDirectionBrightness = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)tbDirectionBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionBrightness).BeginInit();
            SuspendLayout();
            // 
            // tbDirectionBlue
            // 
            tbDirectionBlue.Location = new Point(12, 186);
            tbDirectionBlue.Maximum = 360;
            tbDirectionBlue.Name = "tbDirectionBlue";
            tbDirectionBlue.Size = new Size(159, 56);
            tbDirectionBlue.TabIndex = 0;
            tbDirectionBlue.Scroll += tbDirection_Scroll;
            // 
            // lblDirectionBlue
            // 
            lblDirectionBlue.AutoSize = true;
            lblDirectionBlue.Location = new Point(177, 186);
            lblDirectionBlue.Name = "lblDirectionBlue";
            lblDirectionBlue.Size = new Size(23, 20);
            lblDirectionBlue.TabIndex = 1;
            lblDirectionBlue.Text = "0°";
            // 
            // tbDirectionRed
            // 
            tbDirectionRed.Location = new Point(12, 271);
            tbDirectionRed.Maximum = 360;
            tbDirectionRed.Name = "tbDirectionRed";
            tbDirectionRed.Size = new Size(159, 56);
            tbDirectionRed.TabIndex = 2;
            tbDirectionRed.Scroll += tbDirectionRed_Scroll;
            // 
            // lblDirectionRed
            // 
            lblDirectionRed.AutoSize = true;
            lblDirectionRed.Location = new Point(177, 271);
            lblDirectionRed.Name = "lblDirectionRed";
            lblDirectionRed.Size = new Size(23, 20);
            lblDirectionRed.TabIndex = 3;
            lblDirectionRed.Text = "0°";
            // 
            // tbDirectionGreen
            // 
            tbDirectionGreen.Location = new Point(12, 342);
            tbDirectionGreen.Maximum = 360;
            tbDirectionGreen.Name = "tbDirectionGreen";
            tbDirectionGreen.Size = new Size(159, 56);
            tbDirectionGreen.TabIndex = 4;
            // 
            // lblDirectionGreen
            // 
            lblDirectionGreen.AutoSize = true;
            lblDirectionGreen.Location = new Point(177, 342);
            lblDirectionGreen.Name = "lblDirectionGreen";
            lblDirectionGreen.Size = new Size(23, 20);
            lblDirectionGreen.TabIndex = 5;
            lblDirectionGreen.Text = "0°";
            // 
            // lblBlue
            // 
            lblBlue.AutoSize = true;
            lblBlue.Location = new Point(22, 163);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(54, 20);
            lblBlue.TabIndex = 6;
            lblBlue.Text = "Синий";
            // 
            // lblRed
            // 
            lblRed.AutoSize = true;
            lblRed.Location = new Point(22, 245);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(71, 20);
            lblRed.TabIndex = 7;
            lblRed.Text = "Красный";
            // 
            // lblGreen
            // 
            lblGreen.AutoSize = true;
            lblGreen.Location = new Point(22, 319);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(70, 20);
            lblGreen.TabIndex = 8;
            lblGreen.Text = "Зелёный";
            // 
            // lblSaturation
            // 
            lblSaturation.AutoSize = true;
            lblSaturation.Location = new Point(216, 319);
            lblSaturation.Name = "lblSaturation";
            lblSaturation.Size = new Size(114, 20);
            lblSaturation.TabIndex = 11;
            lblSaturation.Text = "Насыщённость";
            // 
            // lblDirectionSaturation
            // 
            lblDirectionSaturation.AutoSize = true;
            lblDirectionSaturation.Location = new Point(371, 342);
            lblDirectionSaturation.Name = "lblDirectionSaturation";
            lblDirectionSaturation.Size = new Size(17, 20);
            lblDirectionSaturation.TabIndex = 10;
            lblDirectionSaturation.Text = "0";
            // 
            // tbDirectionSaturation
            // 
            tbDirectionSaturation.Location = new Point(206, 342);
            tbDirectionSaturation.Maximum = 100;
            tbDirectionSaturation.Name = "tbDirectionSaturation";
            tbDirectionSaturation.Size = new Size(159, 56);
            tbDirectionSaturation.TabIndex = 9;
            tbDirectionSaturation.Value = 1;
            tbDirectionSaturation.Scroll += tbDirectionSaturation_Scroll;
            // 
            // lblBrightness
            // 
            lblBrightness.AutoSize = true;
            lblBrightness.Location = new Point(410, 319);
            lblBrightness.Name = "lblBrightness";
            lblBrightness.Size = new Size(64, 20);
            lblBrightness.TabIndex = 14;
            lblBrightness.Text = "Яркость";
            // 
            // lblDirectionBrightness
            // 
            lblDirectionBrightness.AutoSize = true;
            lblDirectionBrightness.Location = new Point(565, 342);
            lblDirectionBrightness.Name = "lblDirectionBrightness";
            lblDirectionBrightness.Size = new Size(17, 20);
            lblDirectionBrightness.TabIndex = 13;
            lblDirectionBrightness.Text = "0";
            // 
            // tbDirectionBrightness
            // 
            tbDirectionBrightness.Location = new Point(400, 342);
            tbDirectionBrightness.Maximum = 100;
            tbDirectionBrightness.Name = "tbDirectionBrightness";
            tbDirectionBrightness.Size = new Size(159, 56);
            tbDirectionBrightness.TabIndex = 12;
            tbDirectionBrightness.Scroll += tbDirectionBrightness_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBrightness);
            Controls.Add(lblDirectionBrightness);
            Controls.Add(tbDirectionBrightness);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbDirectionBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbDirectionBrightness).EndInit();
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
        private Label lblBrightness;
        private Label lblDirectionBrightness;
        private TrackBar tbDirectionBrightness;
    }
}
