using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab3
{
    public class Colo
    {
        private TrackBar tbBlue;
        private TrackBar tbGreen;
        private TrackBar tbRed;
        private TrackBar tbSaturation;
        private TrackBar tbBrightness;
        private PictureBox displayPictureBox;
        

        public Colo(TrackBar tbBlue, TrackBar tbGreen, TrackBar tbRed, TrackBar tbSaturation, TrackBar tbBrightness, PictureBox pbRGB) 
        {
            this.tbBlue = tbBlue;
            this.tbGreen = tbGreen;
            this.tbRed = tbRed;
            this.tbSaturation = tbSaturation;
            this.tbBrightness = tbBrightness;
            this.displayPictureBox = pbRGB;

            InitializeTrackBarsColor();
        }
        public void InitializeTrackBarsColor()
        {
            tbBlue.Minimum = 0;
            tbBlue.Maximum = 255;

            tbGreen.Minimum = 0;
            tbGreen.Maximum = 255;

            tbRed.Minimum = 0;
            tbRed.Maximum = 255;

            tbBlue.Value = 0;
            tbGreen.Value = 0;
            tbRed.Value = 0;
            tbSaturation.Value = 100;
            tbBrightness.Value = 100;

            UpdateColor();
        }

        public void UpdateColor()
        {
            var hue = (tbBlue.Value, tbRed.Value, tbGreen.Value);
            
            int saturation = tbSaturation.Value;
            int brightness = tbBrightness.Value;

            int red = tbRed.Value;
            int green = tbGreen.Value;
            int blue = tbBlue.Value;

            //Color color = HsvToRgb(hue, saturation, brightness);
            //displayPictureBox.BackColor = color;
        }



//        private Color RgbToHsv(int hue, double saturation, double brightness)
  //      {

       // }

    }
}
