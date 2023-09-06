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
        public LinkDto() : this(default, default, default, default, default) { }
    }

    public record Kontakt(string KontaktNavn, string? Telefon, string? Email);


    public record MyLinkDto
    {
        public string LinkNavn { get; init; } = default!;
        public string LinkUrl { get; init; } = default!;

        public MyLinkDto(string label, string url)
        {
            LinkNavn = label;
            LinkUrl = url;
        }
    }

}
