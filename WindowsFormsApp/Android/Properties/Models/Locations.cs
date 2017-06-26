﻿using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android
{
   
    public class Locations<T>
    {
        Location loc;
        public Locations(Location loc)
        {
            this.loc = loc;
        }
        public void SetLocation(string x_coord , string y_coord)
        {
            
        }
        public Option<Location> GetLocation(int education_id)
        {
            var LinqQuery = (from l in locations where educaton_id = education_id
                             select l).ToList();

            return new Some<Location>(LinqQuery);
        }
        
        public List<Option<Location>> GetLocations()
        {
           // return new Some<Location>(List<Location>());
        }
    }

}
