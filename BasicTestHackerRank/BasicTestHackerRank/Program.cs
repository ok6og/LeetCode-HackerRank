namespace BasicTestHackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public class Team
        {
            public string teamName;
            public int noOfPlayers;

            public Team(string _teamName, int _noOfPlayers)
            {
                teamName = _teamName;
                noOfPlayers = _noOfPlayers;
            }

            public void AddPlayer(int count)
            {
                noOfPlayers = noOfPlayers + count;
            }

            public bool RemovePlayer(int count)
            {
                if (noOfPlayers >= count)
                {
                    noOfPlayers = noOfPlayers - count;
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public class Subteam : Team
        {

            public Subteam(string _teamName, int _noOfPlayers) : base(_teamName, _noOfPlayers)
            {
                    
            }

            public void ChangeTeamName(string name)
            {
                teamName = name;
            }


        }
    }
}
