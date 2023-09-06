using MapperlyMappingTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.Models
{
    public class Kontakt:BaseEntity<int>
    {
        public string Navn { get; private set; }
        public string Telephone { get; private set; }
        public string Email { get; private set; }

        public Link Link { get; set; }
    }
}
