using Revisao;



using System.ComponentModel;

ana habilidade = new ana();
habilidade.nome = "Augusto";
habilidade.habsana.Add ("andar de cavalo");



Dan hab = new Dan();
hab.nome = "Dan";
<<<<<<<<< Temporary merge branch 1
hab.habilidades.Add("Correr");
hab.habilidades.Add("autoconhecimento");
hab.ExibirDados();
=========
hab.habilidades = new List<string>() {"Correr", "autoconhecimento"};

>>>>>>>>> Temporary merge branch 2
