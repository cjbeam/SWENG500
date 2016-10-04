using System.Collections.Generic;
using Newtonsoft.Json;

namespace ToneAnalyzer
{
    public struct EmailAnalysis
    {
        [JsonProperty("document_tone")]
        public BodyAnalysis BodyResult { get; set; }

        [JsonProperty("sentences_tone")]
        public List<SentenceAnalysis> SentenceResult { get; set; }

        public struct Tone
        {
            [JsonProperty("score")]
            public double Score { get; set; }

            [JsonProperty("tone_id")]
            public string ToneId { get; set; }

            [JsonProperty("tone_name")]
            public string ToneName { get; set; }
        }
        public struct CategoryAnalysis
        {
            [JsonProperty("tones")]
            public List<Tone> Tones { get; set; }

            [JsonProperty("category_id")]
            public string CategoryId { get; set; }

            [JsonProperty("category_name")]
            public string CategoryName { get; set; }
        }
        public struct BodyAnalysis
        {
            [JsonProperty("tone_categories")]
            public List<CategoryAnalysis> CategoryAnalyses { get; set; }
        }
        public struct SentenceAnalysis
        {
            [JsonProperty("sentence_id")]
            public int SentenceId { get; set; }

            [JsonProperty("text")]
            public string Text { get; set; }

            [JsonProperty("input_from")]
            public int InputFrom { get; set; }

            [JsonProperty("input_to")]
            public int InputTo { get; set; }

            [JsonProperty("tone_categories")]
            public List<CategoryAnalysis> CategoryAnalyses { get; set; }
        }
    }
}