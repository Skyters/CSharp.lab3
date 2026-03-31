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
            this.value = tbGreen.Value = value;
            this.tbGreen = tbGreen;
        }

        public static Green operator +(int value, Green instance)
        {
            var newValue = instance.value + value;

            var green = new Green(newValue, instance.tbGreen);

            return green;
        }

        public static Green operator -(int value, Green instance)
        {
            var newValue = instance.value - value;

            var green = new Green(newValue, instance.tbGreen);

            return green;
        }
    }
}
