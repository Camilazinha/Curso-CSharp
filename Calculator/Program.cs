using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Menu();
    }

    static void Menu()
    {

      Console.Clear();

      Console.WriteLine("Por favor, escolha o que quer fazer:\n\n1- Adição\n2- Subtração\n3- Divisão\n4- Multiplicação\n\n0- Sair");
      Console.WriteLine("----------------");


      int opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1:
          Soma();
          break;
        case 2:
          Subtracao();
          break;
        case 3:
          Divisao();
          break;
        case 4:
          Multiplicacao();
          break;
        case 0:
          System.Environment.Exit(0);
          break;
        default:
          Console.WriteLine("Opa! Parece que você digitou errado, tente novamente.");
          break;
      }
    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("|| Adição");

      Console.WriteLine("Informe o primeiro valor:");
      double valor1 = double.Parse(Console.ReadLine()); //ReadLine lê como string

      Console.WriteLine("Informe o segundo valor:");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine(""); // Só pra não ficar grudado

      double resultado = valor1 + valor2;
      Console.WriteLine("O resultado da soma é: " + resultado);
      //v2 -> "[...] soma é: + (valor1 + valor2));

      //v3 - > Console.WriteLine($"O resultado da soma é: {resultado}); 
      //v4 -> "[...] soma é: {valor1 + valor2}"); 

      Console.ReadKey();
      Menu();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.WriteLine("|| Subtração");

      Console.WriteLine("Informe o primeiro valor:");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Informe o segundo valor:");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 - valor2;
      Console.WriteLine($"O resultado da subtração é: {resultado}");

      Console.ReadKey();
      Menu();

    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("|| Divisão");

      Console.WriteLine("");

      Console.WriteLine("Informe o primeiro valor:");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Informe o segundo valor: ");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 / valor2;
      Console.WriteLine($"{valor1} dividido por {valor2} resulta em: {resultado}");

      Console.ReadKey();
      Menu();

    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("|| Multiplicação");

      Console.WriteLine("Informe o primeiro valor:");
      double valor1 = double.Parse(Console.ReadLine());

      Console.WriteLine("Informe o segundo valor:");
      double valor2 = double.Parse(Console.ReadLine());

      Console.WriteLine("");

      double resultado = valor1 * valor2;
      Console.WriteLine("O resultado da multiplicação é: " + resultado);

      Console.ReadKey();
      Menu();

    }
  }
}