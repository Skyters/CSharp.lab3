using System;

namespace CSharp.lab3
{
    public class Saturation
    {
        private int value;

        public int Value => value;

        public Saturation(int value)
        {
            this.value = Math.Clamp(value, 0, 100);
        }

        private Saturation WithValue(int newValue)
            => new Saturation(Math.Clamp(newValue, 0, 100));

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