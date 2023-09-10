﻿// <auto-generated />
#nullable enable
namespace MapperlyTestForMapping.MappingProfiles
{
    //[Mapper(UseDeepCloning = true)]
    public static partial class BegivenhederMapper
    {
        public static partial global::MapperlyTestForMapping.DTO.BegivenhederDto ToBegivenhederDto(global::MapperlyTestForMapping.Models.Begivenheder begivenheder)
        {
            var target = new global::MapperlyTestForMapping.DTO.BegivenhederDto()
            {
                Links = MapToList(begivenheder.Links),
                Kontakts = MapToList1(begivenheder.Kontakts),
                PublishDateOnly = begivenheder.PublishDateOnly.ToString(),
                PublishTimeOnly = begivenheder.PublishTimeOnly.ToString(),
                Titel = begivenheder.Titel,
                Beskrivelse = begivenheder.Beskrivelse,
                Prioritet = begivenheder.Prioritet,
                Stoftype = begivenheder.Stoftype
            };
            return target;
        }

        public static partial global::MapperlyTestForMapping.Models.Begivenheder ToBegivenheder(global::MapperlyTestForMapping.DTO.BegivenhederDto begivenhederDto)
        {
            var target = new global::MapperlyTestForMapping.Models.Begivenheder(begivenhederDto.Titel, begivenhederDto.Beskrivelse, global::System.DateOnly.Parse(begivenhederDto.PublishDateOnly), global::System.TimeOnly.Parse(begivenhederDto.PublishTimeOnly), begivenhederDto.Prioritet, begivenhederDto.Stoftype, MapToList3(begivenhederDto.Links), MapToList4(begivenhederDto.Kontakts));
            return target;
        }

        public static partial global::MapperlyTestForMapping.DTO.EditBegivenhederDto ToEditBegivenheder(global::MapperlyTestForMapping.Models.Begivenheder begivenheder1)
        {
            var target = new global::MapperlyTestForMapping.DTO.EditBegivenhederDto()
            {
                Id = begivenheder1.Id,
                Created = begivenheder1.Created,
                Titel = begivenheder1.Titel,
                Beskrivelse = begivenheder1.Beskrivelse,
                PublishDateOnly = begivenheder1.PublishDateOnly.ToString(),
                PublishTimeOnly = begivenheder1.PublishTimeOnly.ToString(),
                Prioritet = begivenheder1.Prioritet,
                Stoftype = begivenheder1.Stoftype,
                links = MapToList2(begivenheder1.Links)
            };
            return target;
        }

        private static global::MapperlyMappingTest.MyLinkDto MapToMyLinkDto(global::MapperlyMappingTest.Link source)
        {
            var target = new global::MapperlyMappingTest.MyLinkDto()
            {
                Label = source.Label,
                Url = source.Url
            };
            return target;
        }

        private static global::System.Collections.Generic.List<global::MapperlyMappingTest.MyLinkDto> MapToList(global::System.Collections.Generic.IList<global::MapperlyMappingTest.Link> source)
        {
            var target = new global::System.Collections.Generic.List<global::MapperlyMappingTest.MyLinkDto>(source.Count);
            foreach (var item in source)
            {
                target.Add(MapToMyLinkDto(item));
            }

            return target;
        }

        private static global::MapperlyTestForMapping.DTO.KontaktDto MapToKontaktDto(global::MapperlyTestForMapping.Models.Kontakt source)
        {
            var target = new global::MapperlyTestForMapping.DTO.KontaktDto()
            {
                Navn = source.Navn,
                Telephone = source.Telephone,
                Email = source.Email
            };
            return target;
        }

        private static global::System.Collections.Generic.List<global::MapperlyTestForMapping.DTO.KontaktDto> MapToList1(global::System.Collections.Generic.IList<global::MapperlyTestForMapping.Models.Kontakt> source)
        {
            var target = new global::System.Collections.Generic.List<global::MapperlyTestForMapping.DTO.KontaktDto>(source.Count);
            foreach (var item in source)
            {
                target.Add(MapToKontaktDto(item));
            }

            return target;
        }

        private static global::System.Collections.Generic.List<global::MapperlyMappingTest.MyLinkDto> MapToList2(global::System.Collections.Generic.IList<global::MapperlyMappingTest.Link> source)
        {
            var target = new global::System.Collections.Generic.List<global::MapperlyMappingTest.MyLinkDto>(source.Count);
            foreach (var item in source)
            {
                target.Add(MapToMyLinkDto(item));
            }

            return target;
        }

        private static global::MapperlyMappingTest.Link MapToLink(global::MapperlyMappingTest.MyLinkDto source)
        {
            var target = new global::MapperlyMappingTest.Link(source.Label, source.Url);
            return target;
        }

        private static global::System.Collections.Generic.List<global::MapperlyMappingTest.Link> MapToList3(global::System.Collections.Generic.List<global::MapperlyMappingTest.MyLinkDto> source)
        {
            var target = new global::System.Collections.Generic.List<global::MapperlyMappingTest.Link>(source.Count);
            foreach (var item in source)
            {
                target.Add(MapToLink(item));
            }

            return target;
        }

        private static global::MapperlyTestForMapping.Models.Kontakt MapToKontakt(global::MapperlyTestForMapping.DTO.KontaktDto source)
        {
            var target = new global::MapperlyTestForMapping.Models.Kontakt(source.Navn, source.Telephone, source.Email);
            return target;
        }

        private static global::System.Collections.Generic.List<global::MapperlyTestForMapping.Models.Kontakt> MapToList4(global::System.Collections.Generic.List<global::MapperlyTestForMapping.DTO.KontaktDto> source)
        {
            var target = new global::System.Collections.Generic.List<global::MapperlyTestForMapping.Models.Kontakt>(source.Count);
            foreach (var item in source)
            {
                target.Add(MapToKontakt(item));
            }

            return target;
        }
    }
}