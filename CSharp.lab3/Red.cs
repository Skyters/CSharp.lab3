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

        public static Red operator +(int value, Red instance)
        {
            var newValue = instance.value + value;

            var red = new Red(newValue, instance.tbRed);

            return red;
        }

        public static Red operator -(int value, Red instance)
        {
            var newValue = instance.value - value;

            var red = new Red(newValue, instance.tbRed);

            return red;
        }
    }
}
