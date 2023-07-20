using CCSARestaurant.Core;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCSARestaurant.DB.Mappings
{
    public class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap()
        {
            Id(cust => cust.Id);
            Map(cust => cust.FirstName);
            Map(cust => cust.Surname);
            Map(cust => cust.PhoneNumber);
            References(cust => cust.FavouriteDish);
        }
    }
}
