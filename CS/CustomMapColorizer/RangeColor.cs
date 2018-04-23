using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace CustomMapColorizer
{
    public class RangeColor
    {
        readonly int rangeMin;
        readonly int rangeMax;
        readonly Color fill;

        public int RangeMin
        {
            get { return rangeMin; }
        }
        public int RangeMax
        {
            get { return rangeMax; }
        }
        public Color Fill
        {
            get { return fill; }
        }

        public RangeColor(int rangeMin, int rangeMax, Color fill)
        {
            this.rangeMin = rangeMin;
            this.rangeMax = rangeMax;
            this.fill = fill;
        }
    }
}

