using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperlyTestForMapping
{
    public enum StoftyperTypes
    {
        Indland = 1,
        Udland = 2,
        Kriminal = 3,
        Politik = 4,
        Erhverv = 6,
        Sport = 7,
        DagsDato = 55,
        /// <summary>
        /// Most likely, this will be dropped
        /// </summary>
        Finans = 56
    }

    public enum OldPubliatisTidOgStedStoftyperTypes
    {
        DagsDato = 995,
        Erhverv = 992,
        Indland = 1208,
        Kriminal = 1004,
        Personalia = 1003,
        Politik = 1001,
        Sport = 1005,
        Udland = 1006
    }

    public enum FormatterTypes
    {
        Plus = 1,
        Net = 2,
        Print = 6,
        Lyd = 9,
        Liveblog = 53,
        Streaming = 54,
        Navne = 27,
        Fakta = 7,
        Grafik = 10,
        Foto = 104,
        Video = 105,
        //ToDo:Feature, fri og anmeldelser har format typer 116,117,118,119,120,121, skal undersøge om 119-121
        Feature = 116,
        Fri = 117,
        Anmeldelser = 118,
        Finans = 22
    }

    public enum RedaktionTypes
    {
        NU = 917,
        Plus = 918,
        Indland = 919,
        Erhverv = 920,
        Grafik = 921,
        Jylland = 922,
        Multimedie = 923,
        Politi = 925,
        Politisk = 926,
        Sport = 927,
        Service = 928,
        Udland = 929,
        Underholdning = 930,
        EDB = 931,
        Research = 932,
        Fakta = 933,
        Bruxelles = 1013,
        Ekstern = 1217,
        Finans = 1213,
        Fokus = 1211
    }

    public enum PriorityTypes
    {
        Standard_Nyhed = 4,
        Prioriteret = 3,
        Klokke = 2
    }
}
