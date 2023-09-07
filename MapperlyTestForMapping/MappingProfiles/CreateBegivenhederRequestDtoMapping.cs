using MapperlyMappingTest;
using MapperlyTestForMapping.DTO;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.MappingProfiles
{
    [Mapper(PropertyNameMappingStrategy = PropertyNameMappingStrategy.CaseInsensitive)]
    public static partial class LinkDtoToLinkMapping
    {
       
        [MapProperty(nameof(CreateRequestLinkDto.Linknavn), nameof(Link.Label))]
        [MapProperty(nameof(CreateRequestLinkDto.LinkUrl), nameof(Link.Url))]
       
        public static partial Link MapLinkDtoToObj(CreateRequestLinkDto createRequestLinkDto);
    }

    [Mapper(PropertyNameMappingStrategy = PropertyNameMappingStrategy.CaseInsensitive)]
    public static partial class CreateBegivenhederRequestDtoMapping
    {
        
        [MapProperty(nameof(BegivenhederCreateRequestDto.Titel),nameof(Models.Begivenheder.Titel))]
        [MapProperty(nameof(BegivenhederCreateRequestDto.Beskrivelse), nameof(Models.Begivenheder.Beskrivelse))]
        [MapProperty(nameof(BegivenhederCreateRequestDto.PublishDateOnly), nameof(Models.Begivenheder.PublishDateOnly))]
        [MapProperty(nameof(BegivenhederCreateRequestDto.PublishTimeOnly), nameof(Models.Begivenheder.PublishTimeOnly))]
        //[MapProperty(nameof(BegivenhederCreateRequestDto.Prioritet), nameof(Models.Begivenheder.Prioritet))]
        //[MapProperty(nameof(BegivenhederCreateRequestDto.Stoftype), nameof(Models.Begivenheder.Stoftype))]
        [MapProperty(nameof(BegivenhederCreateRequestDto.Link), nameof(Models.Begivenheder.Links))]
        public static partial Models.Begivenheder MapDtoToObj(BegivenhederCreateRequestDto begivenhederCreateRequestDto);
    }
}
