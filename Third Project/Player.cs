using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    public class Player
    {
        private int runs;
        private string name;
        public Player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return$"{runs}-{name}";
        }
    }
    public class Team:IEnumerable
    {
        private Player[] players;
        public Team()
        {
            players = new Player[3]
            {
              new Player(22,"sachin"),
              new Player(44,"virat"),
              new Player(55,"Rohit")
            };
            

        }

        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }
    public class program2
    {
        static void Main(string[] args)
        {
            Team team=new Team();
            foreach(var item in team)
            {
                Console.WriteLine(item);
            }
        }
    }
}
