using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Firearm : Gun
    {
        public int clip_size { get; set; }
        public int ammo { get; protected set; }
        public Firearm(string name, int clip_size)
        {
            this.name = name;
            this.clip_size = clip_size;
            ammo = clip_size;
            type = "Firearm";
        }
        public override void Shoot()
        {
            if (ammo > 0)
            {
                Console.WriteLine("Pew");
                Console.WriteLine("=======================");
                ammo -= 1;
            }
            else
            {
                Console.WriteLine("No ammo");
                Console.WriteLine("=======================");
            }
        }
        public void Reload()
        {
            ammo = clip_size;
            Console.WriteLine("{0} reloaded!", name);
            Console.WriteLine("=======================");
        }
        public override void Print_Info()
        {
            Console.WriteLine("Gun: {0}", name);
            Console.WriteLine("Type: {0}", type);
            Console.WriteLine("Clip: {0}/{1}", ammo, clip_size);
            Console.WriteLine("=======================");
        }
        public override string GetFullType()
        {
            return name + " is " + type + base.GetFullType();
        }
    }
}
