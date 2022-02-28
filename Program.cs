using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasljeđivanje
{
    internal class Program
    {
        public static void Main()
        {
            Bijelogoricno hrast = new Bijelogoricno();
            Crnogoricno bor = new Crnogoricno();

            Console.WriteLine($"Hrast : {hrast.OpadajuListovi}");
            Console.WriteLine($"Bor : {bor.OpadajuListovi}");

            Console.ReadKey();
        }
    }

    public class Biljka
    {
    }

    public class Stablo : Biljka
    {
        bool opadajuListovi;
        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }

        public Stablo(bool arg_opadajuListovi)
        {
            opadajuListovi = arg_opadajuListovi;
        }
    }

    public class Cvijet : Biljka { }

    public class Bijelogoricno : Stablo
    {
        public Bijelogoricno(bool opadajuListovi = true) : base(opadajuListovi) { }
    }

    public class Crnogoricno : Stablo
    {
        public Crnogoricno(bool opadajuListovi = false) : base(opadajuListovi) { }
    }


   
}
