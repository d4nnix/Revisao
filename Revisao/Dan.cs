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

        public List<string> habilidades = new List<string>();

      
        int idade;

        public void ExibirDados()
        {
            Console.WriteLine($"Me chamo: {nome}");
            Console.WriteLine("Minhas hablidades são:");
            foreach (string item in habilidades) 
            {
                Console.WriteLine($"-{item}");
            }
        }
    }
}
