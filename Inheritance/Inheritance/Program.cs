using System;
namespace Inheritance
{

    class Fruit
    {
        private int _fid;
        public int Fid
        {
            get { return _fid; }
            set { _fid = value; }
        }
        private string _fname;

        public string Fname
        {
            get { return _fname; }
            set
            {

                if (value != null)
                    _fname = value;
                else
                    Console.WriteLine("Input valid fruit name");
            }
        }

        public Fruit()
        {

        }

        public Fruit(int fid,string fname)
        {
            _fid = fid;
            _fname = fname;

        }

        public void display()
        {
            Console.WriteLine("Fruit Id:" + Fid);
            Console.WriteLine("Fruit Name:" + Fname);
        }
    }


        class Orange : Fruit
        {
            string origin;
            string[] ORIGIN = { "Maharashtra", "Himachal", "Telangana" };
            private string _origin;
            public string Origin
            {
                get { return _origin; }
                set
                {
                    if (Array.BinarySearch(ORIGIN, value) < 0)
                        _origin = value;
                    else
                        Console.WriteLine("Invalid Origin");
                }
            }

            public Orange()
            {
            
            }
            public Orange(int fid,string fname,string origin):base(fid,fname)
            {
             Origin= origin;
            }
            public void print()
            {
                Console.WriteLine("Fruit Id:" + Fid);
                Console.WriteLine("Fruit Name:" + Fname);
                Console.WriteLine("Fruit origin:" + Origin);
            }
        }
        class program
        {
            static void Main(string[] args)
            {
                Orange o = new Orange(101, "Nagpur Orange", "Goa");
                o.print();
        }
    }
}
