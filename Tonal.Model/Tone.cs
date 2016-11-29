using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tonal.Model
{
    public enum ToneEnum
    {
        Anger,
        Disgust,
        Fear,
        Joy,
        Sadness,
        Analytical,
        Confident,
        Tentative,
        Agreeableness,
        Conscientiousness,
        EmotionalRange,
        Extraversion,
        Openness
    }

    public class EmotionTone
    {
        public int Anger { get; set; }
        public int Disgust { get; set; }
        public int Fear { get; set; }
        public int Joy { get; set; }
        public int Sadness { get; set; }
    }

    public class LanguageTone
    {
        public int Analytical { get; set; }
        public int Confident { get; set; }
        public int Tentative { get; set; }
    }

    public class SocialTone
    {
        public int Agreeableness { get; set; }
        public int Conscientiousness { get; set; }
        public int EmotionalRange { get; set; }
        public int Extraversion { get; set; }
        public int Openness { get; set; }
    }
    
    public class EducationAnalysisEmotionTone
    {
        public EmotionTone Highschool { get; set; }
        public EmotionTone TwoYearCollege { get; set; }
        public EmotionTone University { get; set; }
        public EmotionTone PostGraduate { get; set; }
        public EmotionTone PhDPostDoctoral { get; set; }
        public EmotionTone Other { get; set; }
    }

    public class EducationAnalysisLanguageTone
    {
        public LanguageTone Highschool { get; set; }
        public LanguageTone TwoYearCollege { get; set; }
        public LanguageTone University { get; set; }
        public LanguageTone PostGraduate { get; set; }
        public LanguageTone PhDPostDoctoral { get; set; }
        public LanguageTone Other { get; set; }
    }

    public class EducationAnalysisSocialTone
    {
        public SocialTone Highschool { get; set; }
        public SocialTone TwoYearCollege { get; set; }
        public SocialTone University { get; set; }
        public SocialTone PostGraduate { get; set; }
        public SocialTone PhDPostDoctoral { get; set; }
        public SocialTone Other { get; set; }
    }
    //    public class GenderAnalysisEmotionTone
    //{
    //    public EmotionTone Highschool { get; set; }
    //    public EmotionTone TwoYearCollege { get; set; }
    //    public EmotionTone University { get; set; }
    //    public EmotionTone PostGraduate { get; set; }
    //    public EmotionTone PhDPostDoctoral { get; set; }
    //    public EmotionTone Other { get; set; }
    //}

    //public class GenderAnalysisLanguageTone
    //{
    //    public LanguageTone Highschool { get; set; }
    //    public LanguageTone TwoYearCollege { get; set; }
    //    public LanguageTone University { get; set; }
    //    public LanguageTone PostGraduate { get; set; }
    //    public LanguageTone PhDPostDoctoral { get; set; }
    //    public LanguageTone Other { get; set; }
    //}

    //public class GenderAnalysisSocialTone
    //{
    //    public SocialTone Highschool { get; set; }
    //    public SocialTone TwoYearCollege { get; set; }
    //    public SocialTone University { get; set; }
    //    public SocialTone PostGraduate { get; set; }
    //    public SocialTone PhDPostDoctoral { get; set; }
    //    public SocialTone Other { get; set; }
    //}

    //public class StateAnalysisEmotionTone
    //{
    //    public EmotionTone Highschool { get; set; }
    //    public EmotionTone TwoYearCollege { get; set; }
    //    public EmotionTone University { get; set; }
    //    public EmotionTone PostGraduate { get; set; }
    //    public EmotionTone PhDPostDoctoral { get; set; }
    //    public EmotionTone Other { get; set; }
    //}

    //public class StateAnalysisLanguageTone
    //{
    //    public LanguageTone Highschool { get; set; }
    //    public LanguageTone TwoYearCollege { get; set; }
    //    public LanguageTone University { get; set; }
    //    public LanguageTone PostGraduate { get; set; }
    //    public LanguageTone PhDPostDoctoral { get; set; }
    //    public LanguageTone Other { get; set; }
    //}

    //public class StateAnalysisSocialTone
    //{
    //    public SocialTone Highschool { get; set; }
    //    public SocialTone TwoYearCollege { get; set; }
    //    public SocialTone University { get; set; }
    //    public SocialTone PostGraduate { get; set; }
    //    public SocialTone PhDPostDoctoral { get; set; }
    //    public SocialTone Other { get; set; }
    //}
}
