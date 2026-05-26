using CSharp.lab3;

public class RGB
{
    public RgbResult UpdateColor(int redValue, int greenValue, int blueValue)
    {
        var red = new Red(redValue);
        var green = new Green(greenValue);
        var blue = new Blue(blueValue);

        Color color = Color.FromArgb(red.Value, green.Value, blue.Value);

        HsvResult hsv = RgbToHsv(red.Value, green.Value, blue.Value);

        var saturation = new Saturation(hsv.Saturation);
        var brightness = new Brightness(hsv.Brightness);

        return new RgbResult(color, hsv.Hue, saturation.Value, brightness.Value);
    }

    private HsvResult RgbToHsv(int r, int g, int b)
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

        return new HsvResult(
            (int)Math.Round(h),
            (int)Math.Round(s * 100),
            (int)Math.Round(v * 100)
        );
    }
}

public class HsvResult
{
    public int Hue { get; }
    public int Saturation { get; }
    public int Brightness { get; }

    public HsvResult(int hue, int saturation, int brightness)
    {
        Hue = hue;
        Saturation = saturation;
        Brightness = brightness;
    }
}

public class RgbResult
{
    public Color Color { get; }
    public int Hue { get; }
    public int Saturation { get; }
    public int Brightness { get; }

    public RgbResult(Color color, int hue, int saturation, int brightness)
    {
        Color = color;
        Hue = hue;
        Saturation = saturation;
        Brightness = brightness;
    }
}