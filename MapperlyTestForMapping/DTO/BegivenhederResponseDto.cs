using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping.DTO
{
    public class BegivenhederResponseDto
    {        
        public DateOnly From { get; set; }
        public DateOnly To { get; set; }
        public int ItemsFetched { get; set; }
        public List<BegivenhederForListningVindue> BegivenhederForListningVindue { get; set; }
    }

    public class BegivenhederForListningVindue
    {
        public Guid Id { get; set; }
        public string Headline { get; set; }
        public int Stoftype { get; set; }
        public int Prioritet { get; set; }
        public int NewsValue { get; set; }
        public DateTime Updated { get; set; }
        public DateTime Created { get; set; }
        public DateOnly PublishDate { get; set; }
        public TimeOnly PublishTime { get; set; }
        public Guid BegivenhederParentId { get; set; }
        public int? DaekkerId { get; set; }
    }
}
