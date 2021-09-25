using System;
using ConsoleAppEx18.Entities;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppEx18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria diretório
            string dir = Path.GetTempPath() + @"\Votes";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            try
            {
                // Cria CSV
                var sourcePath = new FileInfo(dir + @"\in.csv");
                using (StreamWriter sw = sourcePath.CreateText())
                {
                    sw.WriteLine("Alex Blue,15");
                    sw.WriteLine("Maria Green,22");
                    sw.WriteLine("Bob Brown,21");
                    sw.WriteLine("Alex Blue,30");
                    sw.WriteLine("Bob Brown,15");
                    sw.WriteLine("Maria Green,27");
                    sw.WriteLine("Maria Green,22");
                    sw.WriteLine("Bob Brown,25");
                    sw.WriteLine("Alex Blue,31");
                }

                Dictionary<string, int> votesByCandidates = new Dictionary<string, int>();

                using (StreamReader sr = File.OpenText(dir + @"\in.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        int votes = Convert.ToInt32(line[1]);

                        Candidate candidate = new Candidate(name, votes);

                        if (votesByCandidates.ContainsKey(candidate.Name))
                        { 
                            int addVotes = Convert.ToInt32(votesByCandidates[candidate.Name]);
                            votesByCandidates[candidate.Name] = candidate.SumVotes(addVotes);
                        }
                        else
                        {
                            votesByCandidates.Add(candidate.Name, candidate.Votes);
                        }
                    }

                    foreach (var candidate in votesByCandidates)
                    {
                        Console.WriteLine($"{candidate.Key}: {candidate.Value}");
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
