namespace CSharp.lab3
{
    public partial class Form1 : Form
    {
        private HSV hsv;
        private RGB rgb;

        public Form1()
        {
            InitializeComponent();
            hsv = new HSV(tbHue, tbSaturation, tbBrightness, pbHSVandRGB);
            rgb = new RGB(tbBlue, tbRed, tbGreen, tbHue, tbSaturation, tbBrightness, pbHSVandRGB);
        }


        private void tbHue_Scroll(object sender, EventArgs e)
        {
            lblDirectionHue.Text = $"{tbHue.Value}°";
            hsv.UpdateColor();
        }

        private void tbSaturation_Scroll(object sender, EventArgs e)
        {
            lblDirectionSaturation.Text = $"{tbSaturation.Value}%";
            hsv.UpdateColor();
        }

        private void tbBrightness_Scroll(object sender, EventArgs e)
        {
            lblDirectionBrightness.Text = $"{tbBrightness.Value}%";
            hsv.UpdateColor();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            lblDirectionRed.Text = $"{tbRed.Value}";
            rgb.UpdateColor();
            SyncHsvLabels();
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            lblDirectionGreen.Text = $"{tbGreen.Value}";
            rgb.UpdateColor();
            SyncHsvLabels();
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            lblDirectionBlue.Text = $"{tbBlue.Value}";
            rgb.UpdateColor();
            SyncHsvLabels();
        }

        private void SyncHsvLabels()
        {
            lblDirectionHue.Text = $"{tbHue.Value}°";
            lblDirectionSaturation.Text = $"{tbSaturation.Value}%";
            lblDirectionBrightness.Text = $"{tbBrightness.Value}%";
        }

        private void bnTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Цвет заданный в пространстве HSV, а также под каждую характеристику отдельный тип. Реализовать операции:\r\n\r\nДобавление/вычитание красного цвета\r\nДобавление/вычитание синего цвета\r\nДобавление/вычитание зеленого цвета\r\nДобавление/вычитание насыщености\r\nДобавление/вычитание яркости\r\nПеревод в RGB");
        }
    }
}