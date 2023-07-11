using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregador_Podcast
{
    internal class Episodio
    {
        public int Ordem { get; }
        public int Duracao { get; }

        public string Titulo { get; }
        public string Resumo 
        {
            get
            {
                return "Nº: " + Ordem + "\nEpisódio: " + Titulo + "\nTempo: " + Duracao + "\nConvidados: " + string.Join(",", convidados) + "\n";
            }


         }

        

        public Episodio(int ordem, int duracao , string titulo)
        {
            Duracao = duracao;
            Ordem = ordem;
            Titulo = titulo;
        }

        List<string> convidados = new List<string>();

        public void AdicionarCovidado(string convidado)
        {
            convidados.Add(convidado);
        }


    }
}
