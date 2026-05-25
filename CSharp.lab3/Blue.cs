using System;

namespace CSharp.lab3
{
    public class Blue
    {
        private int value;
        private TrackBar tbBlue;

        public int Value => value;

        public Blue(int value, TrackBar tbBlue)
        {
            this.value = Math.Clamp(value, 0, 255);
            this.tbBlue = tbBlue;
        }

        private Blue WithValue(int newValue)
        {
            var clamped = Math.Clamp(newValue, 0, 255);
            tbBlue.Value = clamped;
            return new Blue(clamped, tbBlue);
        }

        public static Blue operator +(Blue blue, int delta)
            => blue.WithValue(blue.value + delta);

        public static Blue operator +(int delta, Blue blue)
            => blue.WithValue(blue.value + delta);

        public static Blue operator -(Blue blue, int delta)
            => blue.WithValue(blue.value - delta);

        public static Blue operator -(int delta, Blue blue)
            => blue.WithValue(delta - blue.value);

        public override string ToString() => value.ToString();
    }
}