using System;
using System.Collections.Generic;

namespace ToneAnalyzer
{
   internal static class Configuration
    {

        internal static class MailCatergory
        {

           

            internal static double Threshold(string category)
            {
                double threshold = 1;
                switch (category)
                {
                    case "Anger":
                        threshold = Properties.Settings.Default.AngerThreshold;
                        break;
                    case "Disgust":
                        threshold = Properties.Settings.Default.DisgustThreshold;
                        break;
                    case "Fear":
                        threshold = Properties.Settings.Default.FearThreshold;
                        break;
                    case "Joy":
                        threshold = Properties.Settings.Default.JoyThreshold;
                        break;
                    case "Sadness":
                        threshold = Properties.Settings.Default.SadnessThreshold;
                        break;
                    case "Analytical":
                        threshold = Properties.Settings.Default.AnalyticalThreshold;
                        break;
                    case "Confident":
                        threshold = Properties.Settings.Default.ConfidentThreshold;
                        break;
                    case "Tentative":
                        threshold = Properties.Settings.Default.TentativeThreshold;
                        break;
                    case "Openness":
                        threshold = Properties.Settings.Default.OpennessThreshold;
                        break;
                    case "Conscientiousness":
                        threshold = Properties.Settings.Default.ConscientiousnessThreshold;
                        break;
                    case "Agreeableness":
                        threshold = Properties.Settings.Default.AgreeablenessThreshold;
                        break;
                    case "Emotional Range":
                        threshold = Properties.Settings.Default.EmotionalRangeThreshold;
                        break;
                    case "Extraversion":
                        threshold = Properties.Settings.Default.ExtraversionThreshold;
                        break;
                }
                        return threshold;
            }



            internal static List<string> StopMessageCategories()
            {
                List<string> alerts = new List<string>();
                if (Properties.Settings.Default.AngerAlert) alerts.Add("Anger");
                if (Properties.Settings.Default.DisgustAlert) alerts.Add("Disgust");
                if (Properties.Settings.Default.FearAlert) alerts.Add("Fear");
                if (Properties.Settings.Default.JoyAlert) alerts.Add("Joy");
                if (Properties.Settings.Default.SadnessAlert) alerts.Add("Sadness");
                if (Properties.Settings.Default.AnalyticalAlert) alerts.Add("Analytical");
                if (Properties.Settings.Default.ConfidentAlert) alerts.Add("Confident");
                if (Properties.Settings.Default.TentativeAlert) alerts.Add("Tentative");
                if (Properties.Settings.Default.OpennessAlert) alerts.Add("Openness");
                if (Properties.Settings.Default.ConscientiousnessAlert) alerts.Add("Conscientiousness");
                if (Properties.Settings.Default.ExtraversionAlert) alerts.Add("Extraversion");
                if (Properties.Settings.Default.AgreeablenessAlert) alerts.Add("Agreeableness");
                if (Properties.Settings.Default.EmotionalRangeAlert) alerts.Add("Emotional Range");
                return alerts;
            }

            internal static List<string> IncludeCategories()
            {
                List<string> categories = new List<string>();
                if (Properties.Settings.Default.AngerIncluded) categories.Add("Anger");
                if (Properties.Settings.Default.DisgustIncluded) categories.Add("Disgust");
                if (Properties.Settings.Default.FearIncluded) categories.Add("Fear");
                if (Properties.Settings.Default.JoyIncluded) categories.Add("Joy");
                if (Properties.Settings.Default.SadnessIncluded) categories.Add("Sadness");
                if (Properties.Settings.Default.AnalyticalIncluded) categories.Add("Analytical");
                if (Properties.Settings.Default.ConfidentIncluded) categories.Add("Confident");
                if (Properties.Settings.Default.TentativeIncluded) categories.Add("Tentative");
                if (Properties.Settings.Default.OpennessIncluded) categories.Add("Openness");
                if (Properties.Settings.Default.ConscientiousnessIncluded) categories.Add("Conscientiousness");
                if (Properties.Settings.Default.ExtraversionIncluded) categories.Add("Extraversion");
                if (Properties.Settings.Default.AgreeablenessIncluded) categories.Add("Agreeableness");
                if (Properties.Settings.Default.EmotionalRangeIncluded) categories.Add("Emotional Range");
                return categories;
            }
        }
        internal static class Tone
        {
            internal static List<string> IncludedCategories = new List<string>() {"emotion_tone","language_tone","social_tone"};
        }

    }
}
