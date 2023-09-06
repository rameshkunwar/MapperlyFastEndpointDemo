using MapperlyTestForMapping.DTO;
using MapperlyTestForMapping.Models;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.MappingProfiles
{
    [Mapper]
    public static partial class BegivenhederListningResponseMapper
    {
        [MapProperty(new[] {nameof(BegivenhederResponse.BegivenhederReadOnly)}, new[] {nameof(BegivenhederResponseDto.BegivenhederForListningVindue)} )]
        public static partial BegivenhederResponseDto MapBegivenhederReadOnlyToDto(BegivenhederResponse begivenhederResponse);
    }
}
