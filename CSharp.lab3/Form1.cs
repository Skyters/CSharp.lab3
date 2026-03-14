namespace CSharp.lab3
{
    public partial class Form1 : Form
    {

        private HSV hsv;

        public Form1()
        {
            InitializeComponent();

            hsv = new HSV(tbHSV, ptrBoxHSV);
        }

        private void tbHSV_Scroll(object sender, EventArgs e)
        {
            lblDirectionHSV.Text = $"{tbHSV.Value}°";
            hsv.UpdateColor(Color.Blue, tbDirectionBlue.Value);
        }

        private void tbDirectionBlue_Scroll(object sender, EventArgs e)
        {
            lblDirectionBlue.Text = $"{tbDirectionBlue.Value}°";
            

        }

        private void tbDirectionRed_Scroll(object sender, EventArgs e)
        {
            lblDirectionRed.Text = $"{tbDirectionRed.Value}°";
            //hsv.UpdateColor(Color.Red, tbDirectionRed.Value);

        }

        private void tbDirectionGreen_Scroll(object sender, EventArgs e)
        {
            lblDirectionGreen.Text = $"{tbDirectionGreen.Value}°";
            //hsv.UpdateColor(Color.Green, tbDirectionGreen.Value);
        }

        private void tbDirectionSaturation_Scroll(object sender, EventArgs e)
        {
            lblDirectionSaturation.Text = $"{tbDirectionSaturation.Value}";
        }

        private void tbDirectionBrightness_Scroll(object sender, EventArgs e)
        {
            lblDirectionBrightness.Text = $"{tbDirectionValue.Value}";
        }

    }


}
