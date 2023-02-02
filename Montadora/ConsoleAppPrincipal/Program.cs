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


            Console.WriteLine(caneta1.Marca);
        

        }
    }
}