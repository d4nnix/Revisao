using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
   public class Dan
    {
    public string nome;

        public List<string> habilidades;
        public string habs;
      
        int idade;

        public void ExibirDados()
        {
            Console.WriteLine($"Me chamo: {nome}");
            Console.WriteLine("Minhas hablidades são:");
            foreach (var item in habilidades) 
            {
                Console.Write($"-{habilidades}");
            }
        }
    }
}
