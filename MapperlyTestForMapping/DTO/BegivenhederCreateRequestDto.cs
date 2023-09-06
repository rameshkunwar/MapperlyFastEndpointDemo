using MapperlyMappingTest;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.DTO
{
    public record BegivenhederCreateRequestDto(
        string Titel,
        string? Beskrivelse,
        string PublishDateOnly,
        string PublishTimeOnly,
        StoftyperTypes Stoftype,
        PriorityTypes Prioritet,
        //BegivenhederSted? BegivenhederSted,
        //Kontakt? Kontakt,
        List<CreateRequestLinkDto?> Link
    )
    {
        public BegivenhederCreateRequestDto() : this(default, default, default, default, default, default, default) { }
    }
    public record BegivenhederSted(
       string? Stednavn,
       int? Nummer,
       //If it's only programpunkt then, once can only fill this field. If it's via Google, all fields will be filled
       string By,
       int? Postnr,
       string? Land,
       //F.eks., Sal 02, rum 553
       string? Notefelt,
       //hidden fields, these are needed to how link using Google Maps api
       string? PlaceId,
       string? Latitude,
       string? Longitude,
       //International phone number f.eks., +1 718-760-6200
       string? IntlTelefonNummer,
       //Formatted phone number, f.eks., (718) 760-6200
       string? TelefonNummer,
       //Formatted address f.eks., Flushing Meadow - Corona Park, Flushing, NY 11368, USA
       string? FuldAdresse
   )
    {
        public BegivenhederSted() :
            this(default, default, default, default, default, default, default, default, default, default, default, default)
        { }
    }

    public record Kontakt(
        string Kontaktnavn,
        string? Telefon,
        string? Email
    )
    {
        public Kontakt() : this(default, default, default) { }
    }
    public record CreateRequestLinkDto(
        string Linknavn,
        string LinkUrl
    )
    {
        
        public CreateRequestLinkDto() : this(default!, default!) { }
    }
}
