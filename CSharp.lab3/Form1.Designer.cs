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
            ((System.ComponentModel.ISupportInitialize)tbSaturation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHSV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbHue).BeginInit();
            SuspendLayout();
            // 
            // tbSaturation
            // 
            tbSaturation.Location = new Point(191, 335);
            tbSaturation.Maximum = 100;
            tbSaturation.Name = "tbSaturation";
            tbSaturation.Size = new Size(104, 45);
            tbSaturation.TabIndex = 3;
            tbSaturation.Scroll += tbSaturation_Scroll;
            // 
            // tbBrightness
            // 
            tbBrightness.Location = new Point(339, 335);
            tbBrightness.Maximum = 100;
            tbBrightness.Name = "tbBrightness";
            tbBrightness.Size = new Size(104, 45);
            tbBrightness.TabIndex = 5;
            tbBrightness.Scroll += tbBrightness_Scroll;
            // 
            // lblDirectionSaturation
            // 
            lblDirectionSaturation.AutoSize = true;
            lblDirectionSaturation.Location = new Point(295, 335);
            lblDirectionSaturation.Name = "lblDirectionSaturation";
            lblDirectionSaturation.Size = new Size(35, 15);
            lblDirectionSaturation.TabIndex = 10;
            lblDirectionSaturation.Text = "100%";
            // 
            // lblDirectionBrightness
            // 
            lblDirectionBrightness.AutoSize = true;
            lblDirectionBrightness.Location = new Point(449, 335);
            lblDirectionBrightness.Name = "lblDirectionBrightness";
            lblDirectionBrightness.Size = new Size(35, 15);
            lblDirectionBrightness.TabIndex = 11;
            lblDirectionBrightness.Text = "100%";
            // 
            // bnTask
            // 
            bnTask.Location = new Point(52, 72);
            bnTask.Name = "bnTask";
            bnTask.Size = new Size(75, 23);
            bnTask.TabIndex = 12;
            bnTask.Text = "Задание";
            bnTask.UseVisualStyleBackColor = true;
            // 
            // pbHSV
            // 
            pbHSV.Location = new Point(195, 162);
            pbHSV.Name = "pbHSV";
            pbHSV.Size = new Size(100, 148);
            pbHSV.TabIndex = 13;
            pbHSV.TabStop = false;
            // 
            // lblHSV
            // 
            lblHSV.AutoSize = true;
            lblHSV.Location = new Point(195, 144);
            lblHSV.Name = "lblHSV";
            lblHSV.Size = new Size(29, 15);
            lblHSV.TabIndex = 14;
            lblHSV.Text = "HSV";
            // 
            // lblNameTbSaturation
            // 
            lblNameTbSaturation.AutoSize = true;
            lblNameTbSaturation.Location = new Point(195, 317);
            lblNameTbSaturation.Name = "lblNameTbSaturation";
            lblNameTbSaturation.Size = new Size(92, 15);
            lblNameTbSaturation.TabIndex = 19;
            lblNameTbSaturation.Text = "Насыщенность";
            // 
            // lblNameTbBrightness
            // 
            lblNameTbBrightness.AutoSize = true;
            lblNameTbBrightness.Location = new Point(351, 317);
            lblNameTbBrightness.Name = "lblNameTbBrightness";
            lblNameTbBrightness.Size = new Size(51, 15);
            lblNameTbBrightness.TabIndex = 20;
            lblNameTbBrightness.Text = "Яркость";
            // 
            // tbHue
            // 
            tbHue.Location = new Point(39, 144);
            tbHue.Maximum = 360;
            tbHue.Name = "tbHue";
            tbHue.Size = new Size(104, 45);
            tbHue.TabIndex = 21;
            tbHue.Scroll += tbHue_Scroll;
            // 
            // lblDirectionHue
            // 
            lblDirectionHue.AutoSize = true;
            lblDirectionHue.Location = new Point(149, 144);
            lblDirectionHue.Name = "lblDirectionHue";
            lblDirectionHue.Size = new Size(18, 15);
            lblDirectionHue.TabIndex = 22;
            lblDirectionHue.Text = "0°";
            // 
            // lblNameHSV
            // 
            lblNameHSV.AutoSize = true;
            lblNameHSV.Location = new Point(52, 126);
            lblNameHSV.Name = "lblNameHSV";
            lblNameHSV.Size = new Size(29, 15);
            lblNameHSV.TabIndex = 23;
            lblNameHSV.Text = "HSV";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tbSaturation).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbBrightness).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHSV).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbHue).EndInit();
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
    }
}
