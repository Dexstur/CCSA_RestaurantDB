using CCSARestaurant.Core;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.DB.Mappings
{
    public class DishMap:ClassMap<Dish>
    {
        public DishMap()
        {
            Id(dish => dish.Id);
            Map(dish => dish.Name);
            Map(dish => dish.Price);
            References(dish => dish.Chef);
        }
    }
}
