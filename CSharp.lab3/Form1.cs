namespace CSharp.lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            lblDirectionBlue.Text = $"{tbDirectionBlue.Value}°";
        }

        private void tbDirectionRed_Scroll(object sender, EventArgs e)
        {
            lblDirectionRed.Text = $"{tbDirectionRed.Value}°";
        }

        private void tbDirectionSaturation_Scroll(object sender, EventArgs e)
        {
            lblDirectionSaturation.Text = $"{tbDirectionSaturation.Value}";
        }

        private void tbDirectionBrightness_Scroll(object sender, EventArgs e)
        {
            lblDirectionBrightness.Text = $"{tbDirectionBrightness.Value}";
        }
    }
}
