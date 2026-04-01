using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharp.lab3
{
    public class Blue
    {
        private int value;
        private TrackBar tbBlue;

        public Blue(int value, TrackBar tbBlue) 
        {
            this.value = value;
            this.tbBlue = tbBlue;
        }

        public static Blue operator+(int value, Blue blue)
        {
            var newValue = Math.Clamp(blue.value + value, 0, 255);

            return new Blue(newValue, blue.tbBlue);
        }

        public static Blue operator -(int value, Blue blue)
        {
            var newValue = Math.Clamp(blue.value - value, 0, 255);

            return new Blue(newValue, blue.tbBlue);
        }
    }
}
