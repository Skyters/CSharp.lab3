using System;

namespace CSharp.lab3
{
    public class Red
    {
        private int value;
        private TrackBar tbRed;

        public int Value => value;

        public Red(int value, TrackBar tbRed)
        {
            this.value = Math.Clamp(value, 0, 255);
            this.tbRed = tbRed;
        }

        private Red WithValue(int newValue)
        {
            var clamped = Math.Clamp(newValue, 0, 255);
            tbRed.Value = clamped;
            return new Red(clamped, tbRed);
        }

        public static Red operator +(Red red, int delta)
            => red.WithValue(red.value + delta);

        public static Red operator +(int delta, Red red)
            => red.WithValue(red.value + delta);

        public static Red operator -(Red red, int delta)
            => red.WithValue(red.value - delta);

        public static Red operator -(int delta, Red red)
            => red.WithValue(delta - red.value);

        public override string ToString() => value.ToString();
    }
}