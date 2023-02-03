using ModelsDes;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Caneta caneta1 = new Caneta();
            caneta1.Marca = "Piloto";
            caneta1.Modelo = "Style";
            caneta1.Cor = "Preta";
            caneta1.CorTinta = "Azul";
            caneta1.Nova = true;
            caneta1.PercentualTinta = 100;

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