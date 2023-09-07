﻿using MapperlyMappingTest;

namespace MapperlyTestForMapping.DTO
{
    //public record BegivenhederDto
    //{
    //    public string Titel { get; init; }
    //    public string? Beskrivelse { get; init; }
    //    public string PublishDateOnly { get; init; }
    //    public string PublishTimeOnly { get; init; }
    //    public int Prioritet { get; init; }
    //    public int Stoftype { get; init; }


    //    //[JsonInclude]
    //    //[JsonPropertyName("links")]
    //    public List<MyLinkDto> Links { get; private init; }

    //    public BegivenhederDto()
    //    {

    //    }

    //    public BegivenhederDto(string headline, string? description, string dateOnly, string timeOnly,
    //        int prioritet, int stoftype, List<MyLinkDto> links)
    //    {
    //        Titel = headline;
    //        Beskrivelse = description;
    //        PublishDateOnly = dateOnly;
    //        PublishTimeOnly = timeOnly;
    //        Prioritet = prioritet;
    //        Stoftype = stoftype;
    //        Links = links;
    //    }

    //}

    public record BegivenhederDto(string Titel, string? Beskrivelse, string PublishDateOnly, string PublishTimeOnly, int Prioritet, int Stoftype, List<MyLinkDto> Links, List<KontaktDto> Kontakts)
    {
        public BegivenhederDto() : this(default!, default, default!, default!, default!, default, default!, default!)
        {

        }
    }

    public record EditBegivenhederDto(Guid Id, DateTime Created, string Titel, string? Beskrivelse, string PublishDateOnly, string PublishTimeOnly, int Prioritet, int Stoftype, List<MyLinkDto> links)
    {
        public EditBegivenhederDto() : this(default, default, default!, default, default!, default!, default!, default, default!)
        {

        }
    }
}
