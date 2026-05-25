using System;

namespace CSharp.lab3
{
    public class Saturation
    {
        private int value;
        private TrackBar tbSaturation;

        public int Value => value;

        public Saturation(int value, TrackBar tbSaturation)
        {
            this.value = Math.Clamp(value, 0, 100);
            this.tbSaturation = tbSaturation;
        }

        private Saturation WithValue(int newValue)
        {
            var clamped = Math.Clamp(newValue, 0, 100);
            tbSaturation.Value = clamped;
            return new Saturation(clamped, tbSaturation);
        }

        public static Saturation operator +(Saturation saturation, int delta)
            => saturation.WithValue(saturation.value + delta);

        public static Saturation operator +(int delta, Saturation saturation)
            => saturation.WithValue(saturation.value + delta);

        public static Saturation operator -(Saturation saturation, int delta)
            => saturation.WithValue(saturation.value - delta);

        public static Saturation operator -(int delta, Saturation saturation)
            => saturation.WithValue(delta - saturation.value);

    }
}