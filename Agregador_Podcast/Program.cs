using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregador_Podcast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Episodio ep1 = new Episodio(2, 120, "Jogabilidade Justificada");
            ep1.AdicionarCovidado("Caio, Mikkan");
            Console.WriteLine(ep1.Resumo);

            Episodio ep2 = new Episodio(1,120, "RPGs");
            ep2.AdicionarCovidado("Tucano, Sr. K");
            Console.WriteLine(ep2.Resumo);

            Console.WriteLine("-----------------------------------------------");
            Podcast P = new Podcast("Guilherme", "Gameficado");
            P.AdicionarEp(ep1);
            P.AdicionarEp(ep2);
            P.Exibir();


            Console.ReadKey();
        }
    }
}
