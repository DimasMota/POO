using ModelsDes;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caneta caneta1 = new Caneta("PILOTO", "BIC", "AZUL", "VERMELHA"); //marca , modelo, cor, cor da tinta



            Console.WriteLine("Marca:" + caneta1.Marca);
            Console.WriteLine("Modelo:" + caneta1.Modelo);
            Console.WriteLine("Cor da Caneta: " + caneta1.Cor);
            Console.WriteLine("Cor da Tinta: " + caneta1.CorTinta);
            Console.WriteLine("Nova: " + caneta1.Nova);
            Console.WriteLine("Quantidade de Tinta: " + caneta1.PercentualTinta);

            Console.WriteLine("\n\n");

            Console.WriteLine("A caneta tem duração de 100h de escrita continua. \n Insira a quantidade de horas que você usou: ");
            int x = Convert.ToInt32(Console.ReadLine());

            caneta1.Escrever(x);
            
            Console.WriteLine("Marca:" + caneta1.Marca);
            Console.WriteLine("Modelo:" + caneta1.Modelo); 
            Console.WriteLine("Cor da Caneta: " + caneta1.Cor);
            Console.WriteLine("Cor da Tinta: " + caneta1.CorTinta);
            Console.WriteLine("Nova: " + caneta1.Nova);
            Console.WriteLine("Quantidade de Tinta: " + caneta1.PercentualTinta);
        

        }
    }
}