using System;

namespace CSharp.lab3
{
    public class Blue
    {
        private int value;

        public int Value => value;

        public Blue(int value)
        {
            this.value = Math.Clamp(value, 0, 255);
        }

        private Blue WithValue(int newValue)
            => new Blue(Math.Clamp(newValue, 0, 255));

        public static Blue operator +(Blue blue, int delta)
            => blue.WithValue(blue.value + delta);

        public static Blue operator +(int delta, Blue blue)
            => blue.WithValue(blue.value + delta);

        public static Blue operator -(Blue blue, int delta)
            => blue.WithValue(blue.value - delta);

        public static Blue operator -(int delta, Blue blue)
            => blue.WithValue(delta - blue.value);
    }
}