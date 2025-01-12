using System;
using System.ComponentModel.Design;

class Program
{
  static void Main(string[] args)
  {
    Menu();

  }

  private static void Menu()
  {

    Console.Clear();
    Console.WriteLine("Escolha a operação (+, -, *, /): ");
    string operacao = Console.ReadLine();
    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());
    Console.WriteLine("");

    switch (operacao)
    {
      case "+":
        Console.WriteLine(Soma(v1, v2));
        break;
      case "-":
        Console.WriteLine(Subtracao(v1, v2));
        break;

      case "*":
        Console.WriteLine(Multiplicacao(v1, v2));
        break;

      case "/":
        if (v2 != 0)
          Console.WriteLine(Divisao(v1, v2));
        else
          Console.WriteLine("Erro: Divisão por 0");
        break;

      default:
        Console.WriteLine("Operação inválida, tente novamente.");
        System.Threading.Thread.Sleep(2000); // Atraso de 2 segundos
        Menu(); // Volta ao menu
        break;

      

    }
    Console.WriteLine("\nPressione 'M' para voltar ao menu ou 'S' para sair.");
    var tecla = Console.ReadKey(true).Key;

    if (tecla == ConsoleKey.S)
    {
      Console.WriteLine("Saindo Do Programa");
      System.Environment.Exit(0);
    }
    else if (tecla != ConsoleKey.M)
    {
      Console.WriteLine("\nTecla inválida. Voltando ao menu...");
    
    }
      Menu();
  }



private static float Divisao(float v1, float v2) => v1 / v2;


private static float Multiplicacao(float v1, float v2) => v1 * v2;


private static float Subtracao(float v1, float v2) =>  v1 - v2;


static float Soma(float v1, float v2) =>  v1 + v2;

}
