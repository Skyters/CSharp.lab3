using CSharp.lab3;

public class RGB
{
    private TrackBar tbBlue;
    private TrackBar tbGreen;
    private TrackBar tbRed;
    private TrackBar tbSaturation;
    private TrackBar tbBrightness;
    private PictureBox displayPictureBox;

    public RGB(TrackBar Blue, TrackBar Red, TrackBar Green, TrackBar saturation, TrackBar brightness, PictureBox pbRGB)
    {
        this.tbBlue = Blue;
        this.tbGreen = Red;
        this.tbRed = Green;
        this.tbSaturation = saturation;
        this.tbBrightness = brightness;
        this.displayPictureBox = pbRGB;

        InitializeTrackBarsHSV();
    }

    private void InitializeTrackBarsHSV()
    {
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

        tbBlue.Value = 0;
        tbGreen.Value = 0;
        tbRed.Value = 0;
        tbSaturation.Value = 100;
        tbBrightness.Value = 100;

        UpdateColor();
    }

    public void UpdateColor()
    {
        int blue = tbBlue.Value;
        int green = tbGreen.Value;
        int red = tbRed.Value;
        int saturation = tbSaturation.Value;
        int brightness = tbBrightness.Value;

        Color color = HsvToRgb(blue, red, green, saturation, brightness);
        displayPictureBox.BackColor = color;
    }

    private Color HsvToRgb(int red, int blue, int green, double saturation, double brightness)
    {
        double h = 
        double s = saturation;
        double v = brightness;

        int hi = Convert.ToInt32(Math.Floor(h / 60)) % 6;

        double vmin = ((100 - s) * v) / 100;
        double a = (v - vmin) * ((h % 60) / 60);
        double vinc = vmin + a;
        double vdec = v - a;

        double r = 0, g = 0, b = 0;

        switch (hi)
        {
            case 0: r = v; g = vinc; b = vmin; break;
            case 1: r = vdec; g = v; b = vmin; break;
            case 2: r = vmin; g = v; b = vinc; break;
            case 3: r = vmin; g = vdec; b = v; break;
            case 4: r = vinc; g = vmin; b = v; break;
            case 5: r = v; g = vmin; b = vdec; break;
        }

        return Color.FromArgb(
            (int)(r * 2.55),
            (int)(g * 2.55),
            (int)(b * 2.55)
        );
    }
}