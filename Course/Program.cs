using System;
using System.Buffers;
using System.ComponentModel.Design;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Course
{
    class Program
    {

        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Entre os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            Produto p = new Produto(nome, preco);

            
            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            



        }
    }
}