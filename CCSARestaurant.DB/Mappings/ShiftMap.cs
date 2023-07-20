using CCSARestaurant.Core;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.DB.Mappings
{
    public class ShiftMap : ClassMap<Shift>
    {
        public ShiftMap()
        {
            Id(shift => shift.Id);
            HasManyToMany(shift => shift.ChefsOnShift);
        }
    }
}
