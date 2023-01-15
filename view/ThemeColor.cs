using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace view
{
    public static class ThemeColor

    {
       public static List<string> colorsList = new List<string>()
        {
                                                            "#87CEEB",
                                                            "#00BFFF",
                                                            "#1E90FF",
                                                            "#6495ED",
                                                            "#4682B4",
       };
        public static Color ChangeColorBrightness(Color color,double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                    
                blue *= correctionFactor;

            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A,(byte)red,(byte)green,(byte)blue);

        }
    }
}
