//Containmen


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleBatch.April6.containmen
{
    class CompassBox
    {
        string brand;
        int price;
        Pencil pencil;
        Pen pen; 
        Eraser eraser;
        Scale scale;
        public string Brand              //property
        {
            set { brand = value; }
            get { return brand; }
        }

        public int Price                   //property
        {
            set { price = value; }
            get { return price; }
        }
        public CompassBox()                   //default constructor
        {
        }

        public CompassBox(Pencil pencil, Pen pen, Eraser eraser, Scale scale)      ///parameterized constructor
        {
            this.pencil = pencil;
            this.pen = pen;
            this.eraser = eraser;
            this.scale = scale;
        }

       //property

        internal Pen Pen { get => Pen1; set => Pen1 = value; }
        internal Pencil Pencil { get => pencil; set => pencil = value; }
        internal Pen Pen1 { get => pen; set => pen = value; }
        internal Eraser Eraser { get => eraser; set => eraser = value; }
        internal Scale Scale { get => scale; set => scale = value; }
    }
    class Pencil
    {
        string name;
        int price;

        public Pencil(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
    class Pen
    { }
    class Eraser
    { }
    class Scale
    { }


    class testCompassBox
    {
        static void Main(string[] args)
        {
            CompassBox c = new CompassBox();
            c.Pen = new Pen();
                     }
    }
}
