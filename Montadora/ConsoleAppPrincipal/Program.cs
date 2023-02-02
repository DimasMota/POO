using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pneu pneu1 = new Pneu(16, 150, false, "Carro de passeio");
           
           


            

            Pneu pneu2 = new Pneu(16, 70, true, "Pneu de Estepe");
           
           
            

            pneu1.Girar(6);
            pneu2.Girar(6);
            pneu2.Girar(15);
            pneu2.Girar(130);
            pneu2.Frear(10);
            pneu1.Exibir();
            Console.WriteLine("\n\n");
            pneu2.Exibir();
        }
        


    }
}