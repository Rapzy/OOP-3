using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Gun
    {
        public string type { get; protected set; }
        public string name { get; set; }
        public abstract void Shoot();
        public virtual string GetFullType()
        {
            return "Gun";
        }
    }
}
