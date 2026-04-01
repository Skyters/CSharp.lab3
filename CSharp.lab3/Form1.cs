namespace CSharp.lab3
{
    public partial class Form1 : Form
    {

        private HSV hsv;
        private RGB rgb;

        public Form1()
        {
            InitializeComponent();
            hsv = new HSV(tbHue, tbSaturation, tbBrightness, pbHSV);
            rgb = new RGB(tbHue, tbBlue, tbRed, tbGreen, tbSaturation, tbBrightness, pbRGB);
        }

        private void tbSaturation_Scroll(object sender, EventArgs e)
        {
            lblDirectionSaturation.Text = $"{tbSaturation.Value}%";
            hsv.UpdateColor();
            rgb.UpdateColor();
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            lblDirectionBrightness.Text = $"{tbBrightness.Value}%";
            hsv.UpdateColor();
            rgb.UpdateColor();
        }

        private void tbHue_Scroll(object sender, EventArgs e)
        {
            lblDirectionHue.Text = $"{tbHue.Value}°";
            hsv.UpdateColor();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            lblDirectionBlue.Text = $"{tbBlue.Value}";
            rgb.UpdateColor();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            lblDirectionRed.Text = $"{tbRed.Value}";
            rgb.UpdateColor();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            lblDirectionGreen.Text = $"{tbGreen.Value}";
            rgb.UpdateColor();
        }
    }
}
