using CSharp.lab3;
using System.Diagnostics.Eventing.Reader;

public class RGB
{
    private TrackBar tbHue;
    private TrackBar tbBlue;
    private TrackBar tbGreen;
    private TrackBar tbRed;
    private TrackBar tbSaturation;
    private TrackBar tbBrightness;
    private PictureBox displayPictureBox;

    public RGB(TrackBar hue, TrackBar blue, TrackBar red, TrackBar green, TrackBar saturation, TrackBar brightness, PictureBox pbRGB)
    {
        tbHue = hue;
        this.tbBlue = blue;
        this.tbGreen = green;
        this.tbRed = red;
        this.tbSaturation = saturation;
        this.tbBrightness = brightness;
        this.displayPictureBox = pbRGB;

        InitializeTrackBarsHSV();
    }

    private void InitializeTrackBarsHSV()
    {
        tbHue.Minimum = 0;
        tbHue.Maximum = 360;

        tbBlue.Minimum = 0;
        tbBlue.Maximum = 255;

        tbGreen.Minimum = 0;
        tbGreen.Maximum = 255;

        tbRed.Minimum = 0;
        tbRed.Maximum = 255;

        tbSaturation.Minimum = 0;
        tbSaturation.Maximum = 100;

        tbBrightness.Minimum = 0;
        tbBrightness.Maximum = 100;

        UpdateColor();
    }

    public void UpdateColor()
    {
        int hue = tbHue.Value;
        int blue = tbBlue.Value;
        int green = tbGreen.Value;
        int red = tbRed.Value;
        int saturation = tbSaturation.Value;
        int brightness = tbBrightness.Value;

        Color color = RgbToHsv(hue, red, blue, green, saturation, brightness);
        displayPictureBox.BackColor = color;
    }
   

    public double Hue(double red, double blue, double green)
    {       
        return (red + blue + green);
    }

    private Color RgbToHsv(double hue, double red, double blue, double green, double saturation, double brightness)
    {
        hue = Hue(red, blue, green);
        double max = Math.Max(hue, hue);
        double min = Math.Min(hue, hue);
        

        if (max == min)
        {
            if (max == red && green >= blue) 
            {
                hue = (60 * (green - blue) / (max - min)) + 0;
            }

            else if  (max == red && green < blue)
            {
                hue = (60 * (green - blue) / (max - min)) + 360;
            }

            else if (max == green)
            {
                hue = (60 * (blue - red) / (max - min)) + 120;
            }

            else if(max == blue)
            {
                hue = (60 * (red - green) / (max - min)) + 240;
            }

            else if (max == 0)
            {
                saturation = 0;
            }

            else
            {
                saturation = 1 - min / max;
            }

            brightness = max;
        }

        return Color.FromArgb(
            (int)(red ),
            (int)(green),
            (int)(blue)
        );
    }
}