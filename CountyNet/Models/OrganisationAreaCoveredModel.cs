using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountyNet.Models
{
    public class OrganisationAreaCovered
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Authority> Authority { get; set; }
    }
}