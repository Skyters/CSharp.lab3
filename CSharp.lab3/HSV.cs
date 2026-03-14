using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.lab3
{
    public class HSV
    {
        private PictureBox pnlHSV;
        private TrackBar tbDirectionBlue;
        private TrackBar tbDirectionRed;
        private TrackBar tbDirectionGreen;

        public HSV(PictureBox pnlHSV, TrackBar tbDirectionBlue, TrackBar tbDirectionRed, TrackBar tbDirectionGreen) 
        {
            this.pnlHSV = pnlHSV; 
            this.tbDirectionBlue = tbDirectionBlue; 
            this.tbDirectionRed = tbDirectionRed; 
            this.tbDirectionGreen = tbDirectionGreen;
        }

        public void InitializeTrackBars()
        {
            tbDirectionBlue.Minimum = 0;
            tbDirectionBlue.Maximum = 255;
            tbDirectionBlue.ValueChanged += TrackBar_ValueChanged;

            tbDirectionRed.Minimum = 0;
            tbDirectionRed.Maximum = 255;
            tbDirectionRed.ValueChanged += TrackBar_ValueChanged;

            tbDirectionGreen.Minimum = 0;
            tbDirectionGreen.Maximum = 255;
            tbDirectionGreen.ValueChanged += TrackBar_ValueChanged;

        }

        private void TrackBar_ValueChanged(object sender, EventArgs e)
        {

            pnlHSV.BackColor = Color.FromArgb(
                tbDirectionBlue.Value,
                tbDirectionRed.Value,
                tbDirectionGreen.Value
            );
        }
    }
}
