﻿// <auto-generated />
#nullable enable
namespace MapperlyTestForMapping.MappingProfiles
{
    public static partial class FilterSpecificationMapper
    {
        public static partial global::MapperlyTestForMapping.Models.FilterSpecificationModel MapDtoToFilterSpecification(global::MapperlyTestForMapping.DTO.FilterSpecificationDto filterSpecificationDto)
        {
            var target = new global::MapperlyTestForMapping.Models.FilterSpecificationModel(filterSpecificationDto.From, filterSpecificationDto.To, filterSpecificationDto.Stoftyper, filterSpecificationDto.Formatter, filterSpecificationDto.NewsValue, filterSpecificationDto.Limit);
            return target;
        }
    }
}