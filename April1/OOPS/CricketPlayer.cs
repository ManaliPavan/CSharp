using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April1.OOPS
{
    class CricketPlayer
    {
        String playerName;
        int wickets;
        int runs;
        int age;
        static string country;

        public void accept()
        {
            Console.WriteLine("enter (name,no of wickets,runs,age");
            playerName = Console.ReadLine();
            wickets = Convert.ToInt32(Console.ReadLine());
            runs= Convert.ToInt32(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine($"Player Details:\nName:{playerName}\nWickets:{wickets}\nRuns:{runs}\nAge:{age}\nCountry:{country}");
        }
        public void Main(string [] args)
        {
            CricketPlayer p1 = new CricketPlayer();
            p1.accept();
            p1.display();
            CricketPlayer p2 = new CricketPlayer();
            p2.accept();
            p2.display();
        }
    }
}
