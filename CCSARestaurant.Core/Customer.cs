using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.Core
{
    public class Customer : Entity
    {
        public virtual string FirstName { get; set; }
        public virtual string Surname { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual Dish FavouriteDish { get; set; }
    }
}
