using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{
    class Reptile : Animal
    {

        public bool WarmBlooded { get; set; }
        public bool WaterBreathing { get; set; }
        public bool HasClaws { get; set; }
        public string Type { get; set; }

        public Reptile()
        {

        }

        public Reptile(int Age, int Legs, bool HasFur, string Name, bool WarmBlooded, bool WaterBreathing, bool HasClaws, string Type)
        {
            this.Age = Age;
            this.Legs = Legs;
            this.HasFur = HasFur;
            this.Name = Name;
            this.WarmBlooded = WarmBlooded;
            this.WaterBreathing = WaterBreathing;
            this.HasClaws = HasClaws;
            this.Type = Type;








        }


    }
}
