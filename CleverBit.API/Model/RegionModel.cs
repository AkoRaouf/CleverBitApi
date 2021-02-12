using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverBit.API.Model
{
    public class RegionModel
    {
        public string Name { get; set; }

        public int ParentRegionID { get; set; }
    }
}
