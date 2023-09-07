using MapperlyMappingTest;

namespace MapperlyTestForMapping.Models
{
    public class Kontakt : BaseEntity<int>
    {
        public string Navn { get; private set; }
        public string Telephone { get; private set; }
        public string Email { get; private set; }

        //public Link Link { get; set; }

        public Kontakt(string navn, string telephone, string email)
        {
            Navn = navn;
            Telephone = telephone;
            Email = email;
        }
    }
}
