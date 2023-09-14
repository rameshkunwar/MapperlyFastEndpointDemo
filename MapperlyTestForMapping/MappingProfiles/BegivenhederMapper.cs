using MapperlyTestForMapping.DTO;
using MapperlyTestForMapping.Models;
using Riok.Mapperly.Abstractions;

namespace MapperlyTestForMapping.MappingProfiles
{
    [Mapper(PropertyNameMappingStrategy = PropertyNameMappingStrategy.CaseInsensitive)]
    //[Mapper(UseDeepCloning = true)]
    public static partial class BegivenhederMapper
    {
        //[MapProperty(nameof(Begivenheder.Titel), nameof(BegivenhederDto.Titel))]
        //[MapProperty(nameof(Begivenheder.Beskrivelse), nameof(BegivenhederDto.Beskrivelse))]
        //[MapProperty(nameof(Begivenheder.PublishDateOnly), nameof(BegivenhederDto.PublishDateOnly))]
        //[MapProperty(nameof(Begivenheder.PublishTimeOnly), nameof(BegivenhederDto.PublishTimeOnly))]
        // [MapProperty(nameof(Begivenheder.Links), nameof(BegivenhederDto.Links))]

        public static partial BegivenhederDto ToBegivenhederDto(Begivenheder begivenheder);




        //[MapProperty(nameof(BegivenhederDto.Titel), nameof(Begivenheder.Titel))]
        //[MapProperty(nameof(BegivenhederDto.Beskrivelse), nameof(Begivenheder.Beskrivelse))]
        //[MapProperty(nameof(BegivenhederDto.PublishDateOnly), nameof(Begivenheder.PublishDateOnly))]
        //[MapProperty(nameof(BegivenhederDto.PublishTimeOnly), nameof(Begivenheder.PublishTimeOnly))]
        //[MapProperty(nameof(BegivenhederDto.Links), nameof(Begivenheder.Links))]

        //[MapperIgnoreSource(nameof(BegivenhederDto.TosFYI))]
        [MapperIgnoreTarget(nameof(Begivenheder.TosFYI))]
        public static partial Begivenheder ToBegivenheder(BegivenhederDto begivenhederDto);


        //public static partial EditBegivenhederDto ToEditBegivenheder(Begivenheder begivenheder1);

    }
}
