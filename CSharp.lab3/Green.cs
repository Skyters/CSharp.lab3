using System;

namespace CSharp.lab3
{
    public class Green
    {
        private int value;
        private TrackBar tbGreen;

        public int Value => value;

        public Green(int value, TrackBar tbGreen)
        {
            this.value = Math.Clamp(value, 0, 255);
            this.tbGreen = tbGreen;
        }

        private Green WithValue(int newValue)
        {
            var clamped = Math.Clamp(newValue, 0, 255);
            tbGreen.Value = clamped;
            return new Green(clamped, tbGreen);
        }

        public static Green operator +(Green green, int delta)
            => green.WithValue(green.value + delta);

        public static Green operator +(int delta, Green green)
            => green.WithValue(green.value + delta);

        public static Green operator -(Green green, int delta)
            => green.WithValue(green.value - delta);

        public static Green operator -(int delta, Green green)
            => green.WithValue(delta - green.value);

        public override string ToString() => value.ToString();
    }
}