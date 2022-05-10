using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace AppleBatch.delegates
{   class Training
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
        public string override ToString()
        {
            return $"Student {sname} from batch {batch}\n attening lec.of {sub} taken by {trainer}";

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
        public string override ToString()
        {
            return $"Student {sname} from batch {batch} not yet placed";

        }
    }
    class Placed
    {
        string stud;
        string company;
        string location;
        string jobrole;
        int package;

        public Placed(string stud, string company, string location, string jobrole, int package)
        {
            this.stud = stud;
            this.company = company;
            this.location = location;
            this.jobrole = jobrole;
            this.package = package;
        }

        public string Stud { get => stud; set => stud = value; }
        public string Company { get => company; set => company = value; }
        public string Location { get => location; set => location = value; }
        public string Jobrole { get => jobrole; set => jobrole = value; }
        public int Package { get => package; set => package = value; }

        public string override ToString()
        {
            return $"Student {stud} placed in {company} at {location} as {jobrole} with package {package}.";

        }

        }
        class func
        {
        public static void AcceptPlaced(string stud, string company, string location, string jobrole, int package)
        {
            Console.WriteLine("");
        }
            static void Main(string[] args)
            {
            Hashtable ht = new Hashtable();
           
        
             Action<string, string, string, string,int> a1 =AcceptPlaced;

            }
        }
    }

