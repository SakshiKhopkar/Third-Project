using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Project
{
    public class Player2
    {
        private int runs;
        private string name;
        public Player2(int runs,string name) 
        {
            this.runs = runs;
            this.name = name;
        }
        public int Run
        {
         get { return runs; }
        }
        public override string ToString()
        {
            return$"{runs}-{name}";
        }
    }
    public class Cheakrun:IComparer
    {
        public int Compare(object x, object y)
        {
            Player2 p1= (Player2)x;
            Player2 p2= (Player2)y;
            if (p1.Run > p2.Run)
            {
                return 1;
            }
            else if(p1.Run < p2.Run)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class RunPlayer2
    {
        static void Main(string[] args)
        {
            Player2 sachin = new Player2(100, "sachin");
            Player2 virat = new Player2(200, "virat");
            Cheakrun c1= new Cheakrun();
            int result =c1.Compare(sachin, virat);
            if(result == 1)
            {
                Console.WriteLine("sachin has more run than virat");
            }
            else if(result == -1)
            {
                Console.WriteLine("Sachich has less run than virat");
            }
            else
            {
                Console.WriteLine("both sachin and virat has same run");
            }
        }
    }
}
