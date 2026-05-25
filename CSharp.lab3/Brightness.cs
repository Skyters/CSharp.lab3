using System;

namespace CSharp.lab3
{
    public class Brightness
    {
        private int value;
        private TrackBar tbBrightness;

        public int Value => value;

        public Brightness(int value, TrackBar tbBrightness)
        {
            this.value = Math.Clamp(value, 0, 100);
            this.tbBrightness = tbBrightness;
        }

        private Brightness WithValue(int newValue)
        {
            var clamped = Math.Clamp(newValue, 0, 100);
            tbBrightness.Value = clamped;
            return new Brightness(clamped, tbBrightness);
        }

        public static Brightness operator +(Brightness brightness, int delta)
            => brightness.WithValue(brightness.value + delta);

        public static Brightness operator +(int delta, Brightness brightness)
            => brightness.WithValue(brightness.value + delta);

        public static Brightness operator -(Brightness brightness, int delta)
            => brightness.WithValue(brightness.value - delta);

        public static Brightness operator -(int delta, Brightness brightness)
            => brightness.WithValue(delta - brightness.value);

    }
}