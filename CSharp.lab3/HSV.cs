public class HSV
{
    private TrackBar tbHue;
    private TrackBar tbSaturation;
    private TrackBar tbBrightness;
    private PictureBox displayPictureBox;

    public HSV(TrackBar hue, TrackBar saturation, TrackBar brightness, PictureBox pbHSV)
    {
        this.tbHue = hue;
        this.tbSaturation = saturation;
        this.tbBrightness = brightness;
        this.displayPictureBox = pbHSV;

        InitializeTrackBarsHSV();
    }

    private void InitializeTrackBarsHSV()
    {
        tbHue.Minimum = 0;
        tbHue.Maximum = 360;

        tbSaturation.Minimum = 0;
        tbSaturation.Maximum = 100;

        tbBrightness.Minimum = 0;
        tbBrightness.Maximum = 100;

        tbHue.Value = 0;
        tbSaturation.Value = 100;
        tbBrightness.Value = 100;

        UpdateColor();
    }

    public void UpdateColor()
    {
        int hue = tbHue.Value;
        int saturation = tbSaturation.Value;
        int brightness = tbBrightness.Value;

        Color color = HsvToRgb(hue, saturation, brightness);
        displayPictureBox.BackColor = color;
    }

    private Color HsvToRgb(int hue, double saturation, double brightness)
    {
        double h = hue;
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