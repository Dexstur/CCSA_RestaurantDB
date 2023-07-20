using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.Core
{
    public class Shift : Entity
    {
        public virtual List<Chef> ChefsOnShift { get; set; }
    }
}
