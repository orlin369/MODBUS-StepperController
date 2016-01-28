using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepperControl
{
    public static class AppUtils
    {
        /// <summary>
        /// Decimal separator depending of the culture.
        /// </summary>
        public static char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

        public static string CreateProgramName()
        {
            DateTime time = DateTime.Now;             // Use current time.
            string format = "yyMMddHHmmss";   // Use this format.
            return "StepperController_" + time.ToString(format);
        }

        /// <summary>
        /// Replace no metter , or . with correct regional decimal delimiter.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CorrectDecDelimiter(string value)
        {
            value = value.Replace(',', AppUtils.DecimalSeparator);
            value = value.Replace('.', AppUtils.DecimalSeparator);

            return value;
        }



    }
}
