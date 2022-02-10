using System;
using System.Globalization;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dador do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            Console.Write("Qunatidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizado: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removidos do estoque: ");
             qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);


        }
    }
}
