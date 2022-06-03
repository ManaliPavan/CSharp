using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.delegates
{

    class Training
    {
        string sname;
        string batch;
        string sub;
        string trainer;


        public Training(string sname, string batch, string sub, string trainer)
        {
            this.Sname = sname;
            this.Batch = batch;
            this.Sub = sub;
            this.Trainer = trainer;
        }

        public string Sname { get => sname; set => sname = value; }
        public string Batch { get => batch; set => batch = value; }
        public string Sub { get => sub; set => sub = value; }
        public string Trainer { get => trainer; set => trainer = value; }
        public override string ToString()
        {
            return $"Student {sname} from batch {batch}\n attening lec.of {sub} taken by {trainer}";

        }
        public override bool Equals(object obj)
        {
            Training t = (Training)obj;
            return
                   sname == t.sname &&
                   batch == t.batch &&
                   sub == t.sub &&
                   trainer == t.trainer;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sname, batch, sub, trainer);
        }
    }
    class NotPlaced
    {
        string sname;
        string batch;

        public NotPlaced(string sname, string batch)
        {
            this.Sname = sname;
            this.Batch = batch;
        }

        public string Sname { get => sname; set => sname = value; }
        public string Batch { get => batch; set => batch = value; }
        public override string ToString()
        {
            return $"Student {sname} from batch {batch} not yet placed";

        }
        public override bool Equals(object obj)
        {
            NotPlaced np = (NotPlaced)obj;
            return
                   sname == np.sname &&
                   batch == np.batch;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sname, batch);
        }
    }
    class Placed
    {
        string sname;
        string company;
        string location;
        string jobrole;
        int package;

        public Placed(string sname, string company, string location, string jobrole, int package)
        {
            this.sname= sname;
            this.company = company;
            this.location = location;
            this.jobrole = jobrole;
            this.package = package;
        }

        public string Sname { get => sname; set => sname = value; }
        public string Company { get => company; set => company = value; }
        public string Location { get => location; set => location = value; }
        public string Jobrole { get => jobrole; set => jobrole = value; }
        public int Package { get => package; set => package = value; }

        public override string ToString()
        {
            return $"Student {sname} placed in {company} at {location} as {jobrole} with package {package}.";

        }
        public override bool Equals(object obj)
        {
            Placed p = (Placed)obj;
            return
                   sname == p.sname &&
                   company == p.company &&
                   location == p.location &&
                   jobrole == p.jobrole &&
                   package == p.package;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sname, company, location, jobrole, package);
        }

    }
    class sort : IComparer
    {
        public int Compare(dynamic x, dynamic y)
        {
            return x.sname.CompareTo(y.sname);
        }
    }

    class Action1                     
    {
        public static Dictionary<dynamic,string> d1 = new Dictionary<dynamic,string>();
       /* public static void AcceptPlaced(string s, string c, string l, string j, int p)
        {

            d1.Add((s, c, l, j, p), "Placed");

        }
        public static void AcceptTraining(string s, string b, string sb, string t)
        {
            d1.Add((s, b, sb, t), "Training");
        }
        public static void AcceptNotPlaced(string st, string bh)
        {
            d1.Add((st, bh), "NotPlaced");
        }*/
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("choose where you want to store data\n1.training\n2.placed\n3.notplaced\n4.sort with value");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many i/p");
                int repeat = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        while (repeat != 0)
                        {
                            Action<string, string, string, string> a1 = (string s, string b, string sb, string t)=> 
                            {
                                d1.Add((s, b, sb, t), "Training");
                            };
                            Console.WriteLine("Enter details\n\n| name | batch | subject | trainer | ");
                            string s = Console.ReadLine();
                            string b = Console.ReadLine();
                            string sb = Console.ReadLine();
                            string t = Console.ReadLine();
                            a1(s, b, sb, t);
                            repeat--;
                        }
                        break;

                    case 2:
                        while (repeat != 0)
                        {
                            Action<string, string, string, string, int> a2 = (string s, string c, string l, string j, int p)=>
                            {
                                d1.Add((s, c, l, j, p), "Placed");
                            };
                            Console.WriteLine("Enter details\n\n| name | company | location | jobrole | package| ");
                            string n = Console.ReadLine();
                            string c = Console.ReadLine();
                            string l = Console.ReadLine();
                            string j = Console.ReadLine();
                            int p = Convert.ToInt32(Console.ReadLine());
                            a2(n, c, l, j, p);
                            repeat--;
                        }
                        break;
                    case 3:
                        while (repeat != 0)
                        {
                            Action<string, string> a3 = (string st, string bh)=>
                            {
                                d1.Add((st, bh), "NotPlaced");
                            };
                            Console.WriteLine("Enter details\n\n| name | batch | ");
                            string st = Console.ReadLine();
                            string bh = Console.ReadLine();
                            a3(st, bh);
                            repeat--;
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Sort with value");

                            foreach (KeyValuePair<dynamic,string> d in d1)
                            {
                                if (d.Value=="Training")
                                {
                                    Console.WriteLine(d.Key + " : " + d.Value+"\n\n") ;
                                }
                            }
                            Console.WriteLine("\n\n\n");
                            foreach (KeyValuePair<dynamic,string> d in d1)
                            {
                                if (d.Value=="NotPlaced")
                                {
                                    Console.WriteLine(d.Key + " : " + d.Value);
                                }
                            }
                            Console.WriteLine("\n\n\n");
                            foreach (KeyValuePair<dynamic,string> d in d1)
                            {
                                if (d.Value=="Placed")
                                {
                                    Console.WriteLine(d.Key + " : " + d.Value);
                                }
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Invalid I/p");
                        break;
                }
                Console.WriteLine("\n\n");
                foreach (KeyValuePair<dynamic, string> d in d1)
                {
                    Console.WriteLine(d.Key + " : " + d.Value);
                }
            }
        }
    }
}
    

