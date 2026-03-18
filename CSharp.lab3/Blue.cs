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

        public static Blue operator+(int value, Blue instance)
        {
            var newValue = instance.value + value;

            var blue = new Blue(newValue, instance.tbBlue);

            return blue;
        }

        public static Blue operator -(int value, Blue instance)
        {
            var newValue = instance.value - value;

            var blue = new Blue(newValue, instance.tbBlue);

            return blue;
        }
    }
}
