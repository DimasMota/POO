using ModelsDes;
using System.Runtime.CompilerServices;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string y;
            
            Caneta caneta1 = new Caneta("PILOTO", "BIC", "AZUL", "VERMELHA"); //marca , modelo, cor, cor da tinta





            caneta1.Exibir();



            Console.WriteLine("\n\n");

            do
            {

                Console.WriteLine("A caneta tem duração de 100h de escrita continua. \n Insira a quantidade de horas que você usou: ");
                int x = Convert.ToInt32(Console.ReadLine());

                caneta1.Escrever(x);

                caneta1.Exibir();

                Console.WriteLine("Deseja registra mais uso? [0] sim  [1] Não");
                y = Console.ReadLine();


            } while (y == "0");

           




        }
    }
}