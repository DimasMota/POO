using Models;
using System.Numerics;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //    Pneu pneu1 = new Pneu(16, 150, "Carro de passeio");
        //    Pneu pneu2 = new Pneu(16, 70, "Pneu de Estepe", true);

            Carro carro1 = new Carro("Volkswagen", "fusca","QKM0032 ", 1973, 140 );// marca, modelo, placa, ano, velocidade
            Carro carro2 = new Carro("Chevroler", "Opala", "QKM0044 ", 1980, 180);


            carro1.Abastecer(80);
            carro1.Ligar();
            carro1.Acelerar(40);
            carro1.Frear(8);
            carro1.Acelerar(100);
            carro1.Frear(40);
            carro1.Frear(10);
            carro1.Desligar();
            carro1.PneuDianteiroEsquerdo = carro1.PneuEstepe;
            carro1.Ligar();
            carro1.Acelerar(10);
            carro1.Acelerar(15);
            carro1.Acelerar(54);
            carro1.Acelerar(10);
            carro1.Frear(40);

            carro1.Exibir();

        }


    }
}