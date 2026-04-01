using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharp.lab3
{
    public class Green
    {
        private int value;
        private TrackBar tbGreen;

        public Green(int value, TrackBar tbGreen)
        {
            this.value = value;
            this.tbGreen = tbGreen;
        }

        public static Green operator +(int value, Green green)
        {
            var newValue = Math.Clamp(green.value + value, 0, 255);

            return new Green(newValue, green.tbGreen);
        }

        public static Green operator -(int value, Green green)
        {
            var newValue = Math.Clamp(green.value - value, 0, 255);

            return new Green(newValue, green.tbGreen);
        }
    }
}
