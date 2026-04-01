using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab3
{
    public class Red
    {
        private int value;
        private TrackBar tbRed;

        public Red(int value, TrackBar tbRed)
        {
            this.value = value;
            this.tbRed = tbRed;
        }

        public static Red operator +(int value, Red red)
        {
            var newValue = Math.Clamp(red.value + value, 0, 255);

            return new Red(newValue, red.tbRed);
        }

        public static Red operator -(int value, Red red)
        {
            var newValue = Math.Clamp(red.value - value, 0, 255);

            return new Red(newValue, red.tbRed);
        }
    }
}
