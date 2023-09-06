using MapperlyTestForMapping.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyMappingTest
{
    public class Link:BaseEntity<int>, IAggregateRoot
    {
        public string Label { get;  private set; }
        public string Url { get;  private set; }
        public Guid BegivenhederId { get; set; }
        public Begivenheder Begivenheder { get; set; } = default!;
        public int KontaktId { get; set; }
        public Kontakt Kontakt { get; set; }

        public Link() { }

        [MapperConstructor]
        public Link(string linknavn, string linkUrl)
        {
            Label = linknavn;
            Url = linkUrl;

        }

       
        public Link(string linknavn, string linkUrl, DateTime updated, int kontaktId)
        {
            Label = linknavn;
            Url = linkUrl;
            Updated = updated;
            KontaktId = kontaktId;
        }

        
    }
}
