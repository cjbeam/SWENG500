using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Outlook;

namespace ToneAnalyzer
{
   internal static class Configuration
    {

        internal static class MailCatergory
        {
           internal static Dictionary<string, Microsoft.Office.Interop.Outlook.OlCategoryColor>  IncludedCategories =
                new Dictionary<string, OlCategoryColor>()
                {
                    {
                    "Joy",
                    OlCategoryColor.olCategoryColorYellow
                    },
                    {
                    "Fear",
                    OlCategoryColor.olCategoryColorBlack
                    },
                    {
                    "Anger",
                    OlCategoryColor.olCategoryColorRed
                    },
                    {
                    "Sadness",
                    OlCategoryColor.olCategoryColorBlue
                    },
                    {
                    "Disgust",
                    OlCategoryColor.olCategoryColorDarkGreen
                    },
                };
            internal static double Threshold = .60;

            internal static List<string> StopMessageCategories = new List<string>() {"Anger"};
        }
        internal static class Tone
        {
            internal static List<string> IncludedCategories = new List<string>() {"emotion_tone","language_tone","social_tone"};
        }

    }
}
