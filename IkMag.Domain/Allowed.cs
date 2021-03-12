using System;

namespace IkMag.Domain
{
    public class Allowed
    {
        public int ID { get; set; }
        public string CAT { get; set; }
        public string AllowedRule { get; set; }
        public string RestrictionRule { get; set; }
        public bool HasRestrictions { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }
    }
}
