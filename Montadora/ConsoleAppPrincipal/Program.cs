using ModelsDes;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caneta caneta1 = new Caneta("PILOTO", "BIC", "AZUL", "VERMELHA"); //marca , modelo, cor, cor da tinta





            caneta1.Exibir();



            Console.WriteLine("\n\n");

            Console.WriteLine("A caneta tem duração de 100h de escrita continua. \n Insira a quantidade de horas que você usou: ");
            int x = Convert.ToInt32(Console.ReadLine());

            caneta1.Escrever(x);

            caneta1.Exibir();




        }
    }
}