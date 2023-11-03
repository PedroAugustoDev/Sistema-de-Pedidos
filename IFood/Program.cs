using IFood.Entities;
using IFood.Entities.Enums;
using System;

namespace IFood
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-- Entre com os dados do Cliente --");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write($"{nome}, digite seu email: ");
            string email = Console.ReadLine();

            Console.Write($"{nome}, digite sua data de aniversário (DD/MM/YYYY): ");
            DateTime b = DateTime.Parse(Console.ReadLine());

            Client client = new Client(nome, email, b);
            Order order = new Order(DateTime.Now, OrderStatus.Processing, client);

            Console.Write("Quantos item você terá em seu pedido? ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < number; i++)
            {
                Console.WriteLine($"Cadastro do produto {i +1}");
                Console.Write("Digite o nome do Produto: ");
                string produtoNome = Console.ReadLine();
                Console.Write($"Digite o preço de {produtoNome}: ");
                double precoProd = double.Parse(Console.ReadLine());
                Console.Write($"Digite a quantidade de {produtoNome} que você vai levar: ");
                int qtd = int.Parse(Console.ReadLine());
                order.AddItem(new OrderItem(qtd, new Product(produtoNome, precoProd)));
            }
            Console.Clear();
            Console.WriteLine(order);
        }
    }
}