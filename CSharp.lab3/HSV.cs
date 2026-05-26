using CSharp.lab3;

public class HSV
{
    public Color UpdateColor(int hue, int saturation, int brightness)
    {
        var sat = new Saturation(saturation);
        var bri = new Brightness(brightness);

        return HsvToRgb(hue, sat.Value, bri.Value);
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