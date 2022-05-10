using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April4
{
    class Movie
    {
        string moviename;
        string producer;
        string director;
        string actorname;
        int rating;

        public void setMoviename(string mn)
        {
            moviename=mn;
        }
        public string getMoviename()
        {
            return moviename;
        }

        public void setProducer(string p)
        {
           producer  = p;
        }
        public string getProducer()
        {
            return producer;
        }
        public void setDirector(string d)
        {
            director = d;
        }
        public string getDirector()
        {
            return director;
        }
        public void setActorname(string an)
        {
           actorname = an;
        }
        public string getActorname()
        {
            return actorname;
        }
        public void setRating(int r)
        {
            rating = r;

        }
        public int getRating()
        {
            return rating;
        }
        public string checkRating(int r)
        {
            if(r<=1)
            {
                return "flopp";
            }
            else if(r<=3)
            {
                return "hit";
            }
            else
            {
                return "super hit";
            }
        }
    }

    class TestMovie
    {
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            Console.WriteLine("Enter Moviename");
            m1.setMoviename(Console.ReadLine());
            Console.WriteLine("Enter Producer name");
            m1.setProducer(Console.ReadLine());
            Console.WriteLine("Enter Director name");
            m1.setDirector(Console.ReadLine());
            Console.WriteLine("Enter Actor name");
            m1.setActorname(Console.ReadLine());
            Console.WriteLine("Enter Rating(1-5)");
            m1.setRating(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine($"Movie Details:\nMovieName:{m1.getMoviename()}\nProducer:{m1.getProducer()}\nDirector:{m1.getDirector()}\nActorName:{m1.getActorname()}\nRating:{m1.getRating()}");
            Console.WriteLine(m1.checkRating(m1.getRating()));
        }
    }
}


/*
        Enter Moviename
        rrr
        Enter Producer name
        www
        Enter Director name
        qqq
        Enter Actor name
        aaa
        Enter Rating(1-5)
        5
        Movie Details:
        MovieName:rrr
        Producer:www
        Director:qqq
        ActorName:aaa
        Rating:5
        super hit
*/