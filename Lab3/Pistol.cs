using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Pistol : Firearm
    {
        public Pistol(string name, int clip_size):base(name,clip_size)
        {
            this.name = name;
            this.clip_size = clip_size;
            ammo = clip_size;
            type = "Pistol";
        }
    }
}
