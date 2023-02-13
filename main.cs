using System;

class Program {
  public static void Main (string[] args) {
    
    /*Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever:  

-  o maior preço lido  

-  a média aritmética dos preços dos produtos */

double  preco, maior, menor, media;
    String entrada, codigo ;
    int qtde=15;
    preco=0.00;
    maior= 0.00;
    menor= 0.00;
    media= 0.00;
  

    for (int i=0; i<qtde; i++)
    {
    Console.WriteLine("Digite o código");
    codigo= Console.ReadLine();
    Console.WriteLine("Digite o Preço");
    entrada = Console.ReadLine();
    preco = Double.Parse(entrada);
    if(i == 0)
    {
      maior = preco;
      menor=preco;
    }
    else
    {
      if(preco>maior)
       {
         maior = preco;
       } 
      if(preco<menor)
      {
        menor = preco;
      }
    }
    media = media+preco;
    
    }

    media = media/qtde;
    Console.WriteLine("maior Preço = "+ maior+ ", menor preco = "+ menor+ ", média = "+media);
    
  }
}