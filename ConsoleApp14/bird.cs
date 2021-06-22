using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Bird : Animal

    {
        public bool CanFly { get; set; }
        public string Type { get; set; }
        public bool HasFeathers { get; set; }
        public bool DoesMigrate { get; set; }

        public Bird()
        {

        }
        

        public Bird(int Age, int Legs, bool HasFur, string Name, bool CanFly, string Type, bool HasFeathers, bool DoesMigrate)
        {
            this.Age = Age;
            this.Legs = Legs;
            this.HasFur = HasFur;
            this.Name = Name;
            this.CanFly = CanFly;
            this.Type = Type;
            this.HasFeathers = HasFeathers;
            this.DoesMigrate = DoesMigrate;


        }









    }
}
