using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.Core
{
    public class Dish : Entity
    {
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual Chef Chef { get; set; }
    }
}
