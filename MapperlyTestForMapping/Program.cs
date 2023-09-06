﻿// See https://aka.ms/new-console-template for more information
using MapperlyMappingTest;
using MapperlyTestForMapping.DTO;
using MapperlyTestForMapping.MappingProfiles;
using MapperlyTestForMapping.Models;
using System.Text.Json;

Console.WriteLine("Hello, World!");

Link link = new Link("Ritzau", "https://ritzau.dk", DateTime.Now, 1);
//var mapper = new LinkMapper();

LinkDto dto = LinkMapper.MapLinkToDto(link);
//var dto = mapper.MapLinkToDto(link);

Console.WriteLine(dto.Label);
Console.WriteLine(dto.Url);

Link myLink = LinkDtoMapper.MapLinkDtoToLink(dto);

/* filter specification model */
FilterSpecificationDto filtersDto = new FilterSpecificationDto(DateOnly.Parse("2023-08-20"), DateOnly.Parse("2023-08-25"), new int[] { 1, 3, 5 }, null, null, 12);

FilterSpecificationModel filtersModel = FilterSpecificationMapper.MapDtoToFilterSpecification(filtersDto);

Console.WriteLine("From = " + filtersModel.FromAndToDate.From);

/* Begivenheder read only */

List<BegivenhederReadOnly> begivenheders = new()
{
    new BegivenhederReadOnly(Guid.NewGuid(), "sample headline", 1, 2, 1, null, DateTime.Now, DateOnly.Parse("2023-08-21"), TimeOnly.Parse("13:15"), Guid.NewGuid(), null),
     new BegivenhederReadOnly(Guid.NewGuid(), "sample headline", 1, 2, 1, null, DateTime.Now, DateOnly.Parse("2023-08-21"), TimeOnly.Parse("13:15"), Guid.NewGuid(), null)
};

//var begivenhederRes = new BegivenhederResponse(begivenheders, DateOnly.Parse("2023-08-20"), DateOnly.Parse("2023-08-25"), 25);

//var begivenhederDto = BegivenhederListningResponseMapper.MapBegivenhederReadOnlyToDto(begivenhederRes);

//Console.WriteLine("Items fetched = " + begivenhederDto.ItemsFetched);
//Console.WriteLine("Items fetched upto = " + begivenhederDto.To);

//Console.WriteLine("actual items fetched = " + begivenhederDto.BegivenhederForListningVindue.Count);

///*
// * begivenheder reuest dto
// */

//var linkDto = new CreateRequestLinkDto(Linknavn: "ritzaU", LinkUrl: "https://ritzau.dk");

//var requestDto = new BegivenhederCreateRequestDto("titel", "beskrivse", "2023-08-21", "12:45", 
//    MapperlyTestForMapping.StoftyperTypes.Indland, MapperlyTestForMapping.PriorityTypes.Prioriteret,
//    new List<CreateRequestLinkDto?> { linkDto});

//var begivObj = CreateBegivenhederRequestDtoMapping.MapDtoToObj(requestDto);
//Console.WriteLine(begivObj.Headline);

Begivenheder begivenheder = new Begivenheder("titel", "beskrivelse", DateOnly.Parse("2023-08-10"), TimeOnly.Parse("10:20"), 1, 2, new List<Link>());

BegivenhederDto begivDto = BegivenhederMapper.ToBegivenhederDto(begivenheder);

string serialized = JsonSerializer.Serialize(begivDto);
Console.WriteLine(serialized);

BegivenhederDto? deserialized = JsonSerializer.Deserialize<BegivenhederDto>(serialized);
Console.WriteLine("\n" + deserialized);

Console.ReadLine();

Console.WriteLine(begivDto.ToString());


