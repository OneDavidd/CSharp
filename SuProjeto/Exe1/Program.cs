using System;

class Program
{
   static void Main()
   {
      // Criando um vetor de inteiros
      int[] vetor = { 8, 9, 10, 14, 27 };

      // Ordenando o vetor
      Array.Sort(vetor);

      // Exibindo o vetor ordenado
      Console.WriteLine("Vetor ordenado:");
      foreach (int numero in vetor)
      {
         Console.Write(numero + " ");
      }

      // Aguarda o usuário pressionar uma tecla antes de fechar o console
      Console.ReadKey();
   }
}