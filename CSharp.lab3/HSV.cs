using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab3
{
    public class HSV
    {
        private Color currentColor;
        private TrackBar tbBlue;
        private TrackBar tbRed;
        private TrackBar tbGreen;
        private TrackBar tbHSV;
        private PictureBox displayPictureBox;

        public HSV(TrackBar HSV, PictureBox pictureBox)
        {
            //     this.tbBlue = blue;
            //    this.tbRed = red;
            //    this.tbGreen = green;
            this.tbHSV = HSV;
            this.displayPictureBox = pictureBox;

            InitializeTrackBars();
        }

        private void InitializeTrackBars()
        {
            tbHSV.Minimum = 0;
            tbHSV.Maximum = 360;

            tbBlue.Minimum = 0;
            tbBlue.Maximum = 255;

            tbRed.Minimum = 0;
            tbRed.Maximum = 255;

            tbGreen.Minimum = 0;
            tbGreen.Maximum = 255;
        }

        public void UpdateColor(Color baseColor, int hueValue)
        {
            currentColor = baseColor;

            // UpdatePictureBoxColor();
        }

        private void UpdatePictureBoxColor()
        {
            if (displayPictureBox != null)
            {
                displayPictureBox.BackColor = Color.FromArgb(
                    tbRed.Value % 255,
                    tbGreen.Value % 255,
                    tbBlue.Value % 255
                );
            }
        }
    }
}