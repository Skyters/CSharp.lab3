using CSharp.lab3;

public class RGB
{
    private TrackBar tbBlue;
    private TrackBar tbGreen;
    private TrackBar tbRed;
    private TrackBar tbHue;
    private TrackBar tbSaturation;
    private TrackBar tbBrightness;
    private PictureBox displayPictureBox;

    public RGB(TrackBar blue, TrackBar red, TrackBar green, TrackBar hue, TrackBar saturation, TrackBar brightness,  PictureBox pbRGB)
    {
        this.tbBlue = blue;
        this.tbGreen = green;
        this.tbRed = red;
        this.tbHue = hue;
        this.tbSaturation = saturation;
        this.tbBrightness = brightness;
        this.displayPictureBox = pbRGB;

        InitializeTrackBars();
    }

    private void InitializeTrackBars()
    {
        tbRed.Minimum = 0; tbRed.Maximum = 255;
        tbGreen.Minimum = 0; tbGreen.Maximum = 255;
        tbBlue.Minimum = 0; tbBlue.Maximum = 255;

        UpdateColor();
    }

    public void UpdateColor()
    {
        var red = new Red(tbRed.Value, tbRed) + 0;
        var green = new Green(tbGreen.Value, tbGreen) + 0;
        var blue = new Blue(tbBlue.Value, tbBlue) + 0;

        displayPictureBox.BackColor = Color.FromArgb(red.Value, green.Value, blue.Value);

        RgbToHsv(red.Value, green.Value, blue.Value, out int hue, out int saturation, out int brightness);

        var sat = new Saturation(Math.Clamp(saturation, 0, 100), tbSaturation) + 0;
        var bri = new Brightness(Math.Clamp(brightness, 0, 100), tbBrightness) + 0;

        tbHue.Value = Math.Clamp(hue, tbHue.Minimum, tbHue.Maximum);
    }

    private void RgbToHsv(int r, int g, int b, out int hue, out int saturation, out int brightness)
    {
        double rd = r / 255.0;
        double gd = g / 255.0;
        double bd = b / 255.0;

        double max = Math.Max(rd, Math.Max(gd, bd));
        double min = Math.Min(rd, Math.Min(gd, bd));
        double delta = max - min;

        double h = 0;

        if (delta > 0)
        {
            if (max == rd)
            {
                h = 60 * (((gd - bd) / delta) % 6);
            }
            else if (max == gd)
            {
                h = 60 * (((bd - rd) / delta) + 2);
            }
            else
            {
                h = 60 * (((rd - gd) / delta) + 4);
            }
        }

        if (h < 0)
        {
            h += 360;
        }

        double s = 0;

        if (max > 0)
        {
            s = delta / max;
        }

        double v = max;

        hue = (int)Math.Round(h);
        saturation = (int)Math.Round(s * 100);
        brightness = (int)Math.Round(v * 100);
    }
}