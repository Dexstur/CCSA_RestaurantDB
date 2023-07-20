using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.Core
{
    public class Chef : Entity
    {
        public virtual string Name { get; set; }
        public virtual List<Dish> Dishes { get; set; }
        public virtual List<Shift> Shifts { get; set; }
    }
}
