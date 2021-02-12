using System;

namespace CleverBit.Core
{
    public class Employee
    {
        public int Id { get; set; }
        public int RegionID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual Region Region { get; set; }
    }
}
