using System;

class MainClass {
  public static void Main (string[] args) {
    
    string nome;
    int idade, menu=1;
    double altura , peso;

    
    Pessoa pessoa1 = new Pessoa();

    Console.Write("Digite o nome da Pessoa: ");
    nome = Console.ReadLine();
    pessoa1.PegaNome(nome);
    
    Console.Write("Digite a idade da Pessoa: ");
    idade = int.Parse(Console.ReadLine());
    pessoa1.PegaIdade(idade);

    Console.Write("Digite o peso da Pessoa: ");
    peso = double.Parse(Console.ReadLine());
    pessoa1.PegaPeso(peso);

    Console.Write("Digite a altura da Pessoa: ");
    altura = double.Parse(Console.ReadLine());
    pessoa1.PegaAltura(altura);

    Console.WriteLine(pessoa1.NomeAtual());
    Console.WriteLine(pessoa1.IdadeAtual());
    Console.WriteLine(pessoa1.PesoAtual()); 
    Console.WriteLine(pessoa1.AlturaAtual());  


  while(menu != 0){

    Console.WriteLine("Digite 1 para Envelhecer");
    Console.WriteLine("Digite 2 para Engordar");
    Console.WriteLine("Digite 3 para Emagrecer");
    Console.WriteLine("Digite 4 para Crescer");
 

    menu = int.Parse(Console.ReadLine());

   if(menu == 1){
     Console.Write("Digite quantos anos:   ");
     idade = int.Parse(Console.ReadLine());
     pessoa1.Envelhecer(idade);
    Console.WriteLine(pessoa1.NomeAtual());
    Console.WriteLine(pessoa1.IdadeAtual());
    Console.WriteLine(pessoa1.PesoAtual()); 
    Console.WriteLine(pessoa1.AlturaAtual()); 
    }
   if(menu == 2){
     Console.Write("Digite quantos quilos:   ");
     peso = double.Parse(Console.ReadLine());
      pessoa1.Engordar(peso);
    Console.WriteLine(pessoa1.NomeAtual());
    Console.WriteLine(pessoa1.IdadeAtual());
    Console.WriteLine(pessoa1.PesoAtual()); 
    Console.WriteLine(pessoa1.AlturaAtual()); 
    }
   if(menu == 3){
     Console.Write("Digite quantos quilos:   ");
     peso = double.Parse(Console.ReadLine());
      pessoa1.Emagrecer(peso);
    Console.WriteLine(pessoa1.NomeAtual());
    Console.WriteLine(pessoa1.IdadeAtual());
    Console.WriteLine(pessoa1.PesoAtual()); 
    Console.WriteLine(pessoa1.AlturaAtual()); 
    }
   if(menu == 4){
     Console.Write("Digite quantos metros:   ");
     altura = double.Parse(Console.ReadLine());
     pessoa1.Crescer(altura);
    Console.WriteLine(pessoa1.NomeAtual());
    Console.WriteLine(pessoa1.IdadeAtual());
    Console.WriteLine(pessoa1.PesoAtual()); 
    Console.WriteLine(pessoa1.AlturaAtual()); 
    }



  }




  }
}