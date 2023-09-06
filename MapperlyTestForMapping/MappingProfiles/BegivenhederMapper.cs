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
        public static partial BegivenhederDto ToBegivenhederDto(Begivenheder begivenheder);

    }
}
