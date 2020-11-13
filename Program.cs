using System;

namespace categorias_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            if (idade < 5)
            {
                Console.WriteLine("Você ainda não está em nenhuma categoria");
            }
            if (idade >= 5 && idade <= 7)
            {
                Console.Write("Você se está na categoria Infantil A");
            }
            if (idade >= 8 && idade <= 10)
            {
                Console.Write("Você se está na categoria Infantil B");
            }
            if (idade >= 11 && idade <= 13)
            {
                Console.Write("Você se está na categoria Juvenil A");
            }
            if (idade >= 14 && idade <= 17)
            {
                Console.Write("Você se está na categoria Juvenil B");
            }
            else
            {
                Console.Write("Você se está na categoria Sênior");
            }
        }
    }
}
