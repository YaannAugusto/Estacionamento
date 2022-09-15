using System.IO;
using System.Linq;
using System;
using AppEstacionamento;

namespace AppEstacionamento
{
class Program {
  static void Main(string[] args) 
  {
    
    string op;
     string car = "";
    bool exib = true;

     
    Console.WriteLine("Digite o preço inicial: ");
    int init = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Agora digite o preço por hora : ");
    int hour = Convert.ToInt32(Console.ReadLine());

    while(exib == true)
    {
        Console.Clear();
        Console.WriteLine("Digite a sua opção:");
        Console.WriteLine("1 - Cadastrar veículo");
        Console.WriteLine("2 - Remover veículo");
        Console.WriteLine("3 - Listar veículos");
        Console.WriteLine("4 - Encerrar");

        op = Console.ReadLine();
        switch(op)
        {
            case "1":
             Console.WriteLine("Digite a placa do veículo que deseja adicionar: ");
            car = Console.ReadLine();
            Estacionamento.AdicionarVeiculo(car);
           
            break;

            case "2":
            Estacionamento.RemoveVeiculo(car, hour, init);
            
            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadLine();
            
            break;

            case "3":
            Estacionamento.ListVeiculo();
            
            break;

            case "4":
            Console.WriteLine("O programa se encerrou");
            exib = false;
            break;

            default:
            Estacionamento.Error(op);

            Console.WriteLine("Aperte qualquer tecla para continuar!");
            Console.ReadLine();
            break;
        }
    }

  }
}

}
