using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.DTO
{
    public record FilterSpecificationDto(
        DateOnly From, DateOnly To, int[]? Stoftyper, int[]? Formatter, int? NewsValue, int? Limit
        );
}
