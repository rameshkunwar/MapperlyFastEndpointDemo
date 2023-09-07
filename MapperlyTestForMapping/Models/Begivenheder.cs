using MapperlyMappingTest;
using Riok.Mapperly.Abstractions;

namespace MapperlyTestForMapping.Models
{
    public class Begivenheder : BaseEntity<Guid>, IAggregateRoot
    {
        public string Titel { get; private set; } = default!;
        public string? Beskrivelse { get; private set; }
        //public string? TosFYI { get; private set; }
        //  public int NewsValue { get; private set; }
        public int Prioritet { get; private set; }
        public int Stoftype { get; private set; }

        //should represent by en enum, expected values could be Finished, Unfinished
        //public int BegivenhederStatus { get; private set; }
        //public string? IPTC { get; private set; }
        //public string? HistId { get; private set; }
        public DateOnly PublishDateOnly { get; private set; }
        public TimeOnly PublishTimeOnly { get; private set; }

        public IList<Link> Links { get; private set; } = new List<Link>();

        public IList<Kontakt> Kontakts { get; private set; } = new List<Kontakt>();

        [MapperConstructor]
        public Begivenheder(string Titel, string? Beskrivelse, DateOnly PublishDateOnly,
            TimeOnly PublishTimeOnly, int prioritet, int stoftype,
            List<Link> links, List<Kontakt> kontakts)
        {
            this.Titel = Titel;
            this.Beskrivelse = Beskrivelse;
            //TosFYI = tosFYI;

            Prioritet = prioritet;
            Stoftype = stoftype;
            //BegivenhederStatus = begivenhederStatus;
            //IPTC = iPTC;
            //HistId = histId;
            this.PublishDateOnly = PublishDateOnly;
            this.PublishTimeOnly = PublishTimeOnly;
            Links = links;
            Kontakts = kontakts;
        }
        public Begivenheder() { }
    }
}
