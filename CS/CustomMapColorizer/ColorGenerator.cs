using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace CustomMapColorizer
{
    public static class ColorGenerator
    {
        static RangeColor[] colorsPopulation = { new RangeColor(200000, 1400000, Color.FromArgb(255, 0xA8, 0x3A, 0x78)), new RangeColor(34000, 200000, Color.FromArgb(255, 0xBF, 0x51, 0x8F)), new RangeColor(22000, 34000, Color.FromArgb(255, 0xD2, 0x64, 0xA2)),
                                                 new RangeColor(12700, 22000, Color.FromArgb(255, 0xE2, 0x74, 0xB2)), new RangeColor(9200, 12700, Color.FromArgb(255, 0xF1, 0x83, 0xC1)), new RangeColor(6200, 9200, Color.FromArgb(255, 0xFD, 0x8F, 0xCD)),
                                                 new RangeColor(4200, 6200, Color.FromArgb(255, 0xFF, 0xAB, 0xDA)), new RangeColor(2200, 4200, Color.FromArgb(255, 0xFF, 0xC1, 0xE4)), new RangeColor(650, 2200, Color.FromArgb(255, 0xFF, 0xD1, 0xEA)),
                                                 new RangeColor(-100, 650, Color.FromArgb(255, 0xFF, 0xDF, 0xF1))};

        public static Color GetColorByPopulation(int population)
        {
            foreach (RangeColor rangePopulation in colorsPopulation)
            {
                if (population >= rangePopulation.RangeMin * 1000 && population < rangePopulation.RangeMax * 1000)
                {
                    return rangePopulation.Fill;
                }
            }
            return Color.FromArgb(255, 255, 255, 255);
        }
    }
}

