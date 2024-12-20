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
                Id = begivenheder.Id,
                Titel = begivenheder.Titel,
                Beskrivelse = begivenheder.Beskrivelse,
                PublishDateOnly = begivenheder.PublishDateOnly.ToString(),
                PublishTimeOnly = begivenheder.PublishTimeOnly.ToString(),
                Prioritet = begivenheder.Prioritet,
                Stoftype = begivenheder.Stoftype,
                IPTC = begivenheder.IPTC,
                HistId = begivenheder.HistId,
                Links = MapToList(begivenheder.Links),
                Kontakts = MapToList1(begivenheder.Kontakts)
            };
            return target;
        }

        public static partial global::MapperlyTestForMapping.Models.Begivenheder ToBegivenheder(global::MapperlyTestForMapping.DTO.BegivenhederDto begivenhederDto)
        {
            var target = new global::MapperlyTestForMapping.Models.Begivenheder();
            foreach (var item in begivenhederDto.Links)
            {
                target.Links.Add(MapToLink(item));
            }

            foreach (var item1 in begivenhederDto.Kontakts)
            {
                target.Kontakts.Add(MapToKontakt(item1));
            }

            target.Id = begivenhederDto.Id;
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

        private static global::MapperlyMappingTest.Link MapToLink(global::MapperlyMappingTest.MyLinkDto source)
        {
            var target = new global::MapperlyMappingTest.Link(source.Label, source.Url);
            return target;
        }

        private static global::MapperlyTestForMapping.Models.Kontakt MapToKontakt(global::MapperlyTestForMapping.DTO.KontaktDto source)
        {
            var target = new global::MapperlyTestForMapping.Models.Kontakt(source.Navn, source.Telephone, source.Email);
            return target;
        }
    }
}