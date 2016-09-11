using System.IO;


namespace ToneReader
{
    public static  class Serialization
    {
        public static string Serialize(EmailAnalysis analysis)
        {
           var serializer = new System.Xml.Serialization.XmlSerializer(typeof(EmailAnalysis));
            using (var serialized = new StringWriter())
            {
                serializer.Serialize(serialized, analysis);
                return serialized.ToString();
            }
        }
    }
}
