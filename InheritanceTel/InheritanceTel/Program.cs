using System;
namespace InheritanceTel
{
    class Telephone
    {
        protected string _phonetype;
        public string phonetype
        {
            get 
            { 
                return _phonetype; 
            } 
        set
            {
                _phonetype = value;
            }
        }
        public Telephone() 
        {
        
        }
        public Telephone(string phType)
        {
            _phonetype = phType;
        }
        public void Ring()
        {
            Console.WriteLine($"Ringing the {_phonetype}");
        }

        class Electronicphone:Telephone
        {
            public Electronicphone() 
            {
                _phonetype = "Digital";
            }
            public void Run()
            {
                base.Ring();
            }
        }
        class program
        {
            static void Main(string[] args) 
            {
                Electronicphone phone = new Electronicphone();
                phone.Run();
            }
        }
    }
}
