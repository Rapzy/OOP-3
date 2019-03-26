using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Rifle:Firearm
    {
        public int fire_rate { get; set; }
        public Rifle(string name, int clip_size, int fire_rate) : base(name, clip_size)
        {
            type = "Rifle ";
            this.fire_rate = fire_rate;
        }
        public override void Print_Info()
        {
            Console.WriteLine("Gun: {0}", name);
            Console.WriteLine("Type: {0}", type);
            Console.WriteLine("Fire rate: {0}", fire_rate);
            Console.WriteLine("Clip: {0}/{1}", ammo, clip_size);
            Console.WriteLine("=======================");
        }
    }
}
