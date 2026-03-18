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
        this.tbGreen = Green;
        this.tbRed = Red;
        this.tbSaturation = saturation;
        this.tbBrightness = brightness;
        this.displayPictureBox = pbRGB;

        InitializeTrackBarsHSV();
    }

    private void InitializeTrackBarsHSV()
    {
        tbBlue.Minimum = 0;
        tbBlue.Maximum = 240;

        tbGreen.Minimum = 0;
        tbGreen.Maximum = 120;

        tbRed.Minimum = 0;
        tbRed.Maximum = 360;

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

        Color color = HsvToRgb(red, blue, green, saturation, brightness);
        displayPictureBox.BackColor = color;
    }
   

    public double colorRgb(double red, double blue, double green)
    {       
        return (red + blue + green );
    }

    private Color HsvToRgb(double red, double blue, double green, double saturation, double brightness)
    {
        var h = colorRgb(red, blue, green);
        double s = saturation;
        double v = brightness;

        int hi = Convert.ToInt32(Math.Floor(h / 60)) % 6;

        double vmin = ((100 - s) * v) / 100;
        double a = (v - vmin) * ((h % 60) / 60);
        double vinc = vmin + a;
        double vdec = v - a;

        red = 0; green = 0; blue = 0;

        switch (hi)
        {
            case 0: red = v; green = vinc; blue = vmin; break;
            case 1: red = vdec; green = v; blue = vmin; break;
            case 2: red = vmin; green = v; blue = vinc; break;
            case 3: red = vmin; green = vdec; blue = v; break;
            case 4: red = vinc; green = vmin; blue = v; break;
            case 5: red = v; green = vmin; blue = vdec; break;
        }

        return Color.FromArgb(
            (int)(red * 2.55),
            (int)(green * 2.55),
            (int)(blue * 2.55)
        );
    }
}