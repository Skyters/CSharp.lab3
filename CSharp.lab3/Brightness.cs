using System;

namespace CSharp.lab3
{
    public class Brightness
    {
        private int value;

        public int Value => value;

        public Brightness(int value)
        {
            this.value = Math.Clamp(value, 0, 100);
        }

        private Brightness WithValue(int newValue)
            => new Brightness(Math.Clamp(newValue, 0, 100));

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