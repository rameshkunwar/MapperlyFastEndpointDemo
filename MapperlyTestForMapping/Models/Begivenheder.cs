using MapperlyMappingTest;
using Riok.Mapperly.Abstractions;

namespace MapperlyTestForMapping.Models
{
    public class Begivenheder : BaseEntity<Guid>, IAggregateRoot
    {
        public string Headline { get; private set; } = default!;
        public string? Description { get; private set; }
        //public string? TosFYI { get; private set; }
        public int NewsValue { get; private set; }
        public int Prioritet { get; private set; }
        public int Stoftype { get; private set; }

        //should represent by en enum, expected values could be Finished, Unfinished
        //public int BegivenhederStatus { get; private set; }
        //public string? IPTC { get; private set; }
        //public string? HistId { get; private set; }
        public DateOnly DateOnly { get; private set; }
        public TimeOnly TimeOnly { get; private set; }

        public IList<Link> Links { get; private set; } = new List<Link>();

        [MapperConstructor]
        public Begivenheder(string Titel, string? Beskrivelse, DateOnly PublishDateOnly,
            TimeOnly PublishTimeOnly, int prioritet, int stoftype,
            List<Link> myLink)
        {
            Headline = Titel;
            Description = Beskrivelse;
            //TosFYI = tosFYI;

            Prioritet = prioritet;
            Stoftype = stoftype;
            //BegivenhederStatus = begivenhederStatus;
            //IPTC = iPTC;
            //HistId = histId;
            DateOnly = PublishDateOnly;
            TimeOnly = PublishTimeOnly;
            Links = myLink;
        }
        public Begivenheder() { }
    }
}
