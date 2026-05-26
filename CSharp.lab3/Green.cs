using System;

namespace CSharp.lab3
{
    public class Green
    {
        private int value;

        public int Value => value;

        public Green(int value)
        {
            this.value = Math.Clamp(value, 0, 255);
        }

        private Green WithValue(int newValue)
            => new Green(Math.Clamp(newValue, 0, 255));

        public static Green operator +(Green green, int delta)
            => green.WithValue(green.value + delta);

        public static Green operator +(int delta, Green green)
            => green.WithValue(green.value + delta);

        public static Green operator -(Green green, int delta)
            => green.WithValue(green.value - delta);

        public static Green operator -(int delta, Green green)
            => green.WithValue(delta - green.value);
    }
}