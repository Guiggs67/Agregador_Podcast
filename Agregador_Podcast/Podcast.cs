using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Agregador_Podcast
{
    internal class Podcast
    {
        public string Host { get; }

        public string Nome { get; }

        public int Totalep => ep.Count;
        

        public Podcast(string host, string nome)
        {
            Host = host;
            Nome = nome;
            
        }

        List<Episodio> ep = new List<Episodio>();
      public void AdicionarEp(Episodio episodio)
        {
            ep.Add(episodio);
        }
    
        public void Exibir()
        {
            Console.WriteLine("Podcast: " + Nome);
            Console.WriteLine("Apresentação: " + Host);
            Console.WriteLine();

            foreach(Episodio ep in ep.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(ep.Resumo);
            }
           

        }
    }
}
