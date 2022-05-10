using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April5.Property
{
    class Country
    {
        string countryname, capital;
        int noOfstates, noOflanguages;
        long population;
        public string Countryname
        {
            get
            {return countryname; }
            set
            { this.countryname = value; }
           
        }
        public int NoOfstates
        {
            get
            { return noOfstates; }
            set
            { this.noOfstates = value; }
            
        }
        public int NoOflanguages
        {
            get
            { return noOflanguages; }
            set
            { this.noOflanguages = value; }
        }
        public string Capital
        {
            get
            { return capital; }
            set
            { this.capital = value; }
        }
        public long Population
        {
            get
            { return population; }
            set
            { this.population = value; }
        }
    }
    class TestCountry
    {
        static void Main(string[] args)
        {
            Country c1 = new Country();
            c1.Countryname = "India";
            c1.NoOfstates = 10;
            c1.NoOflanguages = 10;
            c1.Capital = "Delhi";
            c1.Population = 10000000000;
            Console.WriteLine($"Country:{c1.Countryname}\nNo of States:{c1.NoOfstates}\nNo of languages:{c1.NoOflanguages}\nCapital:{c1.Capital}\nPopulation:{c1.Population}");
        }
    }
}

/* 
         Country:India
        No of States:10
        No of languages:10
        Capital:Delhi
        Population:10000000000
*/