using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab3
{
    public class Colo
    {
        private TrackBar tbBlue;
        private TrackBar tbGreen;
        private TrackBar tbRed;
        private TrackBar tbSaturation;
        private TrackBar tbBrightness;
        private PictureBox displayPictureBox;
        

        public Colo(TrackBar tbBlue, TrackBar tbGreen, TrackBar tbRed, TrackBar tbSaturation, TrackBar tbBrightness, PictureBox pbRGB) 
        {
            this.tbBlue = tbBlue;
            this.tbGreen = tbGreen;
            this.tbRed = tbRed;
            this.tbSaturation = tbSaturation;
            this.tbBrightness = tbBrightness;
            this.displayPictureBox = pbRGB;

            InitializeTrackBarsColor();
        }
        public void InitializeTrackBarsColor()
        {
            tbBlue.Minimum = 0;
            tbBlue.Maximum = 255;

            tbGreen.Minimum = 0;
            tbGreen.Maximum = 255;

            tbRed.Minimum = 0;
            tbRed.Maximum = 255;

            tbBlue.Value = 0;
            tbGreen.Value = 0;
            tbRed.Value = 0;
            tbSaturation.Value = 100;
            tbBrightness.Value = 100;

            UpdateColor();
        }

        public void UpdateColor()
        {

            
            int saturation = tbSaturation.Value;
            int brightness = tbBrightness.Value;

            int red = tbRed.Value;
            int green = tbGreen.Value;
            int blue = tbBlue.Value;

            var hsv = RgbToHsv(red, green, blue);
            


            Color color = HsvToRgb(hsv.Hue, saturation, brightness);
            displayPictureBox.BackColor = color;
        }

        private Color HsvToRgb(int hue, double saturation, double brightness)
        {
            int h = hue;
            double s = saturation;
            double v = brightness;

            int hi = Convert.ToInt32(Math.Floor(h / 60)) % 6;

            double vmin = ((100 - s) * v) / 100;
            double a = (v - vmin) * ((h % 60) / 60);
            double vinc = vmin + a;
            double vdec = v - a;

            double blue = 0;
            double green = 0; 
            double red = 0;

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
}
