namespace ConsoleAppEx18.Entities
{
    class Candidate
    {
        public string Name { get; private set; }
        public int Votes { get; private set; }

        public Candidate(string name, int votes)
        {
            Name = name;
            Votes = votes;
        }

        public int SumVotes(int votes)
        {
            return Votes += votes;
        }
    }
}
