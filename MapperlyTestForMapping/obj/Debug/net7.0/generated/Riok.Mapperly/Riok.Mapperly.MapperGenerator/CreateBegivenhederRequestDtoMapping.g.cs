﻿// <auto-generated />
#nullable enable
namespace MapperlyTestForMapping.MappingProfiles
{
    public static partial class CreateBegivenhederRequestDtoMapping
    {
        public static partial global::MapperlyTestForMapping.Models.Begivenheder MapDtoToObj(global::MapperlyTestForMapping.DTO.BegivenhederCreateRequestDto begivenhederCreateRequestDto)
        {
            var target = new global::MapperlyTestForMapping.Models.Begivenheder();
            foreach (var item in begivenhederCreateRequestDto.Link)
            {
                target.Links.Add(MapToLink(item));
            }

            return target;
        }

        private static global::MapperlyMappingTest.Link MapToLink(global::MapperlyTestForMapping.DTO.CreateRequestLinkDto? source)
        {
            if (source == null)
                throw new System.ArgumentNullException(nameof(source));
            var target = new global::MapperlyMappingTest.Link();
            return target;
        }
    }
}