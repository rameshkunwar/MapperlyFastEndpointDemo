﻿// <auto-generated />
#nullable enable
namespace MapperlyMappingTest
{
    public static partial class LinkMapper
    {
        public static partial global::MapperlyMappingTest.LinkDto MapLinkToDto(global::MapperlyMappingTest.Link link)
        {
            var target = new global::MapperlyMappingTest.LinkDto()
            {
                Label = link.Label,
                Url = link.Url,
                Created = link.Created,
                Updated = link.Updated ?? throw new System.ArgumentNullException(nameof(link.Updated)),
                Kontakt = link.Kontakt
            };
            return target;
        }
    }
}