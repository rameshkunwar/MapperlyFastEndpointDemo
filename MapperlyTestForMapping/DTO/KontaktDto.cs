namespace MapperlyTestForMapping.DTO
{
    public record KontaktDto(string Navn, string Telephone, string Email)
    {
        public KontaktDto() : this(default!, default!, default!)
        {

        }
    }
}
