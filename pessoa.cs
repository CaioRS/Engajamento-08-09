using System;

class Pessoa {
 
 private string Nome ; 
 private int Idade;
 private double Peso;
 private double Altura;

 //SETS
public void PegaNome (string NovoNome){
  Nome = NovoNome;
}

public void PegaIdade (int NovaIdade){
  if(NovaIdade>0){
    Idade = NovaIdade;
  }
  else Console.WriteLine("IDADE INVALIDA");
}

public void PegaPeso (double NovoPeso ){
  if(NovoPeso>0){
    Peso = NovoPeso;
  }
  else Console.WriteLine("PESO INVALIDO");
}

public void PegaAltura(double NovaAltura){
  if(NovaAltura>0){
    Altura = NovaAltura;
  }
  else Console.WriteLine("ALTURA INVALIDA");
}

//GETS
public string NomeAtual(){
return Nome;
}

public int IdadeAtual(){
return Idade;
}

public double PesoAtual(){
return Peso;
}

public double AlturaAtual(){
return Altura;
}

//metodos
public void Envelhecer(int anos){
 if(anos>0){
   while(Idade<21){
    Idade = Idade + anos;
    Altura = Altura + 0.5 ; 
    }
   Idade = Idade + anos; 
  }
}

public void Engordar(double P){
  if(P>0){
    Peso = Peso + P;
  }
}

public void Emagrecer(double P){
  if(P<Peso){
    Peso = Peso - P;
  }
}

public void Crescer(double A){
  if(A>0){
    Altura = Altura + A;
  }
}

}