
using Riok.Mapperly.Abstractions;

namespace MapperlyMappingTest
{
    [Mapper]
    public static  partial class LinkMapper
    {
        //[MapProperty(nameof(Link.Label), nameof(LinkDto.LinkName))]
        //[MapProperty(nameof(Link.Url), nameof(LinkDto.LinkWWW))]
        public static partial LinkDto MapLinkToDto(Link link);
    }

    [Mapper]
    public static partial class LinkDtoMapper
    {
        [MapProperty(nameof(LinkDto.Label), "Label")]
        [MapProperty(nameof(LinkDto.Url), nameof(Link.Url))]
        public static partial Link MapLinkDtoToLink(LinkDto linkDto);
    }
}