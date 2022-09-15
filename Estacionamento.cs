using System.IO;
using System.Linq;
using System;
using AppEstacionamento;


namespace AppEstacionamento
{


public class Estacionamento 
{

    static List<string> Cars = new List<string>();
    //public List<Estacionamento> cars {get; private set; }

    public static void AdicionarVeiculo(string car)
    {
        Cars.Add(car);
        Console.WriteLine("Aperte qualquer tecla para continuar!");
        Console.ReadLine();
    }

    public static string RemoveVeiculo(string car, int hour, int init)
    {
        if(Cars.Any())
        {
           Console.WriteLine("Digite a placa do veículo que deseja remover: ");
           car = Console.ReadLine();
           int count = ContaEstac(hour, init);
           Console.WriteLine($"o veículo {car} foi removido e o preço total foi de: R$ {count}");
           Cars.Remove(car);  
           return car;
        }
        else
        {
            Console.WriteLine("Não ha nenhum veiculo no estacionamento");
            return null;
        }
       
    }

    public static int ContaEstac(int hour, int init)
    {
        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado: ");
        int stay = Convert.ToInt32(Console.ReadLine());
        return   init + (hour * stay);
    }

    public static void ListVeiculo()
    {
        if(Cars.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach(string car in Cars)
                 Console.WriteLine($"{car}");
        }
        else
        {
             Console.WriteLine("Não há nenhum veiculo no estacionamento");
        }
        
        Console.WriteLine("Aperte qualquer tecla para continuar!");
        Console.ReadLine();
    }

    public static void Error(string op)
    {
        Console.WriteLine($"A opcao {op} nao existe!");
    }
}
}