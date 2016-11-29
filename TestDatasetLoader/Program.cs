using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tonal.Data;
using Tonal.Model;
using TestDatasetLoader.AnalysisService;
using System.Reflection;
using System.IO;
using System.Threading;

namespace TestDatasetLoader
{
    class Program
    {
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
        static DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1925, 1, 1);
            int range = (new DateTime(1990, 1, 1) - start).Days;
            return start.AddDays(gen.Next(range));
        }
        static void Main(string[] args)
        {
            Tonal.Data.MemberDataService memberDataService = new Tonal.Data.MemberDataService();
            AnalysisService.TonalAnalysisServiceClient service = new AnalysisService.TonalAnalysisServiceClient();

            var members = new List<Tonal.Model.Member>();
            string memberPath = Path.Combine(AssemblyDirectory, "TestData", "Members.csv");
            string[] membersData = File.ReadAllLines(memberPath);
            foreach (string memberEntry in membersData)
            {

                string[] memberEntrySplit = memberEntry.Split(',');
                Tonal.Model.Member thisMember = new Tonal.Model.Member();
                thisMember.email = memberEntrySplit[0];
                thisMember.gender = new Gender() { GenderId = Convert.ToInt32(memberEntrySplit[1]) };
                thisMember.state = new State() { StateId = Convert.ToInt32(memberEntrySplit[2]) };
                thisMember.education = new Education() { EducationId = Convert.ToInt32(memberEntrySplit[3]) };
                thisMember.birthDate = RandomDay();
               // memberDataService.Create(thisMember);
                members.Add(thisMember);
            }
            int emailCount = 0;
            string dataPath = Path.Combine(AssemblyDirectory, "TestData","Emails");
            string[] fileEntries = Directory.GetFiles(dataPath);
            Array.Sort(fileEntries);
            foreach(string file in fileEntries)
            {
                var member = members.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
                string email = member.email;
                string body = File.ReadAllText(file);
                try
                {
                    Console.WriteLine("Processing " + Path.GetFileName(file) + " by " + email);
                    service.GetAnalysis(email, body);
                    emailCount++;
                    Console.WriteLine("Processed Email " + emailCount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Email Failed to Load");
                }
            }
            Console.WriteLine("Done!");
            Console.ReadLine();

        }
    }
}
