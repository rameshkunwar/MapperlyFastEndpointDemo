using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyMappingTest
{
    //public class LinkDto
    //{
    //    public int Id { get; set; }
    //    public string LinkName { get;  set; }
    //    public string LinkWWW { get;  set; }
    //    public DateTime Created { get; set; }
    //    public DateTime Updated { get; set; }
    //}

    public record LinkDto(string Label, string Url, DateTime Created, DateTime Updated, Kontakt Kontakt)
    {
        public LinkDto():this(default, default, default, default, default ) { }
    }

    public record Kontakt(string KontaktNavn, string? Telefon, string? Email);

}
