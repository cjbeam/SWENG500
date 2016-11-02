using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToneAnalyzer
{
   public static class Helper
    {
        public static Dictionary<string, double> DocumentLevelCategoryScores(EmailAnalysis emailAnalysis, List<string> includedCategories)
        {
            var categoryTones = new List<EmailAnalysis.Tone>();
            foreach (var tc in emailAnalysis.BodyResult.CategoryAnalyses)
            {
                if (includedCategories.Contains(tc.CategoryId))
                {
                    categoryTones.AddRange(tc.Tones);
                }
            }
            var categoryScores = categoryTones.ToDictionary(tone => tone.ToneName, tone => tone.Score);
            return categoryScores;
        }
    }
}
