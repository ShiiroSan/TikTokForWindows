using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokForWindows
{
    class Utils
    {
        public static string NormalizeNumber(int numberToNormalize)
        {
            if (numberToNormalize > 1000 && numberToNormalize < 1000000)
            {
                float reducedNumber = (float)numberToNormalize / 1000;
                if (reducedNumber > 99)
                {
                    return (int)reducedNumber + "K";
                }
                if (reducedNumber > 9 && reducedNumber < 100)
                {
                    return reducedNumber.ToString("##.#") + "K";
                }
                if (reducedNumber > 0 && reducedNumber < 10)
                {
                    return reducedNumber.ToString("#.##") + "K";
                }
            }
            return numberToNormalize.ToString();
        }
    }
}
