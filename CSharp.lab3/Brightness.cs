using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab3
{
    public class Brightness
    {
        private int value;
        private TrackBar tbBrightness;

        public Brightness(int value, TrackBar tbRed)
        {
            this.value = value;
            this.tbBrightness = tbRed;
        }

        public static Brightness operator +(int value, Brightness brightness)
        {
            var newValue = Math.Clamp(brightness.value + value, 0, 100);

            return new Brightness(newValue, brightness.tbBrightness);
        }

        public static Brightness operator -(int value, Brightness brightness)
        {
            var newValue = Math.Clamp(brightness.value - value, 0, 100);

            return new Brightness(newValue, brightness.tbBrightness);
        }

        public void InitializeTrackBars()
        {

            tbBrightness.Minimum = 0;
            tbBrightness.Maximum = 100;

            tbBrightness.Value = 100;
        }
    }
}
