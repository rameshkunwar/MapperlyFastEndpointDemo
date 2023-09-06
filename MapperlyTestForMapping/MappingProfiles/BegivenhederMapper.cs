using MapperlyTestForMapping.DTO;
using MapperlyTestForMapping.Models;
using Riok.Mapperly.Abstractions;

namespace MapperlyTestForMapping.MappingProfiles
{
    [Mapper(PropertyNameMappingStrategy = PropertyNameMappingStrategy.CaseInsensitive)]
    public static partial class BegivenhederMapper
    {
        [MapProperty(nameof(Begivenheder.Headline), nameof(BegivenhederDto.Titel))]
        [MapProperty(nameof(Begivenheder.Description), nameof(BegivenhederDto.Beskrivelse))]
        [MapProperty(nameof(Begivenheder.DateOnly), nameof(BegivenhederDto.PublishDateOnly))]
        [MapProperty(nameof(Begivenheder.TimeOnly), nameof(BegivenhederDto.PublishTimeOnly))]
        [MapProperty(nameof(Begivenheder.Links), nameof(BegivenhederDto.MyLink))]

        public static partial BegivenhederDto ToBegivenhederDto(Begivenheder begivenheder);




        [MapProperty(nameof(BegivenhederDto.Titel), nameof(Begivenheder.Headline))]
        [MapProperty(nameof(BegivenhederDto.Beskrivelse), nameof(Begivenheder.Description))]
        [MapProperty(nameof(BegivenhederDto.PublishDateOnly), nameof(Begivenheder.DateOnly))]
        [MapProperty(nameof(BegivenhederDto.PublishTimeOnly), nameof(Begivenheder.TimeOnly))]
        [MapProperty(nameof(BegivenhederDto.MyLink), nameof(Begivenheder.Links))]
        public static partial Begivenheder ToBegivenheder(BegivenhederDto begivenhederDto);

    }
}
