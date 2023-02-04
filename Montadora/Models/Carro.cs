
namespace Models
{
    public class Carro
    {
        public string Marca { get; set; }//
        public string Modelo { get; set; }//
        public string Placa { get; set; }//
        public int AnoFabricacao { get; set; }//
        /// <summary>
        /// // registra quilometros rodados
        /// </summary>
        public int Odometro { get; set; } //
        public int PercentualCombustivel { get; set; }//
        public int VelocidadeMaxima { get; set; }//
        public bool Ligado { get; set; }//
        public int VelocidadeAtual { get; set; }
        public Pneu PneuDianteiroEsquerdo { get; set; }
        public Pneu PneuDianteiroDireito { get; set; }
        public Pneu PneuTrazeiroEsquerdo { get; set; }
        public Pneu PneuTrazeiroDireito { get; set; }
        public Pneu PneuEstepe { get; set; }




        public Carro(string _marca, string _modelo, string _placa, int _anoFabricacao, int _velocidadeMaxima, int _velocidadeAtual)
        {
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuDianteiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuTrazeiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuTrazeiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuEstepe = new Pneu(16, 70, "Estepe",true);

            Marca = _marca;
            Modelo = _modelo;
            Placa = _placa;
            AnoFabricacao = _anoFabricacao;
            VelocidadeMaxima = _velocidadeMaxima;



            VelocidadeAtual = 0;
            Odometro = 0;
            PercentualCombustivel = 0;
            Ligado = false;

           

        }

        public void Ligar()
        {
            
            if (PercentualCombustivel > 0)
                {
                    Ligado = true;
                    Console.WriteLine("O carro está ligado");
                    return;
                }
            
        }

        public void Destigar()
        {
            Ligado = false;
            VelocidadeAtual=0;
            PneuDianteiroDireito = 0;
            PneuDianteiroEsquerdo = 0;
            PneuTrazeiroDireito = 0;
            PneuTrazeiroEsquerdo = 0;
        }
        public void Acelerar()
        {

        }

        public void Frear()
        {

        }
        public void Abastecer()
        {

        }

    }
}
