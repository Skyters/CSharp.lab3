namespace CSharp.lab3
{
    public partial class Form1 : Form
    {
        private HSV hsv;
        private RGB rgb;

        public Form1()
        {
            InitializeComponent();

            hsv = new HSV();
            rgb = new RGB();

            InitializeTrackBars();
            UpdateHsvDisplay();
        }

        private void InitializeTrackBars()
        {
            tbHue.Minimum = 0; tbHue.Maximum = 360;
            tbSaturation.Minimum = 0; tbSaturation.Maximum = 100;
            tbBrightness.Minimum = 0; tbBrightness.Maximum = 100;
            tbRed.Minimum = 0; tbRed.Maximum = 255;
            tbGreen.Minimum = 0; tbGreen.Maximum = 255;
            tbBlue.Minimum = 0; tbBlue.Maximum = 255;

            tbHue.Value = 0;
            tbSaturation.Value = 100;
            tbBrightness.Value = 100;
        }

        private void tbHue_Scroll(object sender, EventArgs e)
        {
            lblDirectionHue.Text = $"{tbHue.Value}°";
            UpdateHsvDisplay();
        }

        private void tbSaturation_Scroll(object sender, EventArgs e)
        {
            lblDirectionSaturation.Text = $"{tbSaturation.Value}%";
            UpdateHsvDisplay();
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            lblDirectionBrightness.Text = $"{tbBrightness.Value}%";
            UpdateHsvDisplay();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            lblDirectionRed.Text = $"{tbRed.Value}";
            UpdateRgbDisplay();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            lblDirectionGreen.Text = $"{tbGreen.Value}";
            UpdateRgbDisplay();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            lblDirectionBlue.Text = $"{tbBlue.Value}";
            UpdateRgbDisplay();
        }


        private void UpdateHsvDisplay()
        {
            Color color = hsv.UpdateColor(tbHue.Value, tbSaturation.Value, tbBrightness.Value);
            pbHSVandRGB.BackColor = color;
        }

        private void UpdateRgbDisplay()
        {
            RgbResult result = rgb.UpdateColor(tbRed.Value, tbGreen.Value, tbBlue.Value);

            pbHSVandRGB.BackColor = result.Color;

            // синхронизация HSV-ползунков
            tbHue.Value = Math.Clamp(result.Hue, tbHue.Minimum, tbHue.Maximum);
            tbSaturation.Value = Math.Clamp(result.Saturation, tbSaturation.Minimum, tbSaturation.Maximum);
            tbBrightness.Value = Math.Clamp(result.Brightness, tbBrightness.Minimum, tbBrightness.Maximum);

            // синхронизация подписи HSV
            lblDirectionHue.Text = $"{tbHue.Value}°";
            lblDirectionSaturation.Text = $"{tbSaturation.Value}%";
            lblDirectionBrightness.Text = $"{tbBrightness.Value}%";
        }
    }
}