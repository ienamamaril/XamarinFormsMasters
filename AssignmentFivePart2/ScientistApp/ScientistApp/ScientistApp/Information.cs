using System;
namespace ScientistApp
{
    public class Information
    {
        public string Name { get; set; }

        public string Image { get; set; } 

        public string Year { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
