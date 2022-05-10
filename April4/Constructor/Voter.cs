using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April4.Constructor
{
    class Voter
    {
        long adharcard;
        string votername;
        string votecasted;

        public Voter()
        {
            Console.WriteLine("in Voter default Constructor ");
        }
        public void setAdharcard(long adhar)
        {
            adharcard = adhar;
        }
        public long getAdharcard()
        {
            return adharcard;
        }
        public void setVotername(string name)
        {
            votername = name;
        }
        public string getVotername()
        {
            return votername;
        }
        public void setVotecasted(string vc)
        {
            votecasted = vc;
        }
        public string getVotecasted()
        {
            return votecasted;
        }
    }

    class TestVoter
    {
        static void Main(string[] args)
        {
            Voter v1 = new Voter();
            Voter v2 = new Voter();
            Voter v3 = new Voter();
            v1.setAdharcard(1234567890);
            v1.setVotername("Manali");
            v1.setVotecasted("Sonali");
            /*           string vc = v1.getVotecasted();
                       long adhar = v1.getAdharcard();
                       string name = v1.getVotername();
            */

            Console.WriteLine($"Votername:{v1.getVotername()}\nAdharcard:{v1.getAdharcard()}\nVotecasted:{v1.getVotecasted()}");
        }
    }
}
    
