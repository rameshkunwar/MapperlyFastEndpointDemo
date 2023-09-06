using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.Models
{
    public record BegivenhederResponse(
        List<BegivenhederReadOnly> BegivenhederReadOnly,
        DateOnly FetchedFrom,
        DateOnly FetchedTo,
        int ItemsFetched
        );

    public record BegivenhederReadOnly(
          Guid Id,
        string Headline,
        int Stoftype,
        int Prioritet,
        int NewsValue,
        DateTime? Updated,
        DateTime Created,
        DateOnly PublishDate,
        TimeOnly PublishTime,
        Guid BegivenhederParentId,
        int? DaekkerId)
    {
        //this default constructor is for Dapper as it needs an empty constructor
        public BegivenhederReadOnly() : this(default, default!, default, default, default, default, default, default, default, default, default) { }
    }
}
