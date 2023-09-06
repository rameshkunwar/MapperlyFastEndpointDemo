namespace MapperlyTestForMapping.DTO
{
    public record BegivenhederDto
    {
        public string Titel { get; init; }
        public string? Beskrivelse { get; init; }
        public string PublishDateOnly { get; init; }
        public string PublishTimeOnly { get; init; }
        public int Prioritet { get; init; }
        public int Stoftype { get; init; }
        //public List<LinkDto> Link { get; init; }

        public BegivenhederDto()
        {

        }

        public BegivenhederDto(string headline, string? description, string dateOnly, string timeOnly,
            int prioritet, int stoftype)
        {
            Titel = headline;
            Beskrivelse = description;
            PublishDateOnly = dateOnly;
            PublishTimeOnly = timeOnly;
            Prioritet = prioritet;
            Stoftype = stoftype;
        }

    }
}
