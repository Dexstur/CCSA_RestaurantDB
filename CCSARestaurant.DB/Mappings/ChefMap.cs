using CCSARestaurant.Core;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.DB.Mappings
{
    public class ChefMap : ClassMap<Chef>
    {
        public ChefMap()
        {
            Id(chef => chef.Id);
            Map(chef => chef.Name);
            HasMany(chef => chef.Dishes);
            HasManyToMany(chef => chef.Shifts);
        }
    }
}
