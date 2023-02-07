
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




        public Carro(string _marca, string _modelo, string _placa, int _anoFabricacao, int _velocidadeMaxima)
        {
            PneuDianteiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuDianteiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuTrazeiroEsquerdo = new Pneu(16, 150, "Carro de passeio");
            PneuTrazeiroDireito = new Pneu(16, 150, "Carro de passeio");
            PneuEstepe = new Pneu(16, 70, "Estepe", true);

            Marca = _marca;  // marca, modelo, placa, ano, velocidade
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
                PercentualCombustivel = PercentualCombustivel - 3;
                Console.WriteLine("O carro está ligado");
                return;
            }
            if (PercentualCombustivel <= 0)
            {
                Desligar();
            }

        }

        public void Desligar()
        {
            Ligado = false;
            Parar();
        }
        public void Acelerar(int _impulso)
        {
            if (Ligado == true && _impulso > 0)
            {
                VelocidadeAtual = VelocidadeAtual + _impulso;
                PneuDianteiroDireito.Girar(_impulso);
                PneuDianteiroEsquerdo.Girar(_impulso);
                PneuTrazeiroDireito.Girar(_impulso);
                PneuTrazeiroEsquerdo.Girar(_impulso);
                if(PneuDianteiroDireito.Estourado || PneuDianteiroEsquerdo.Estourado||
                   PneuTrazeiroDireito.Estourado||PneuTrazeiroEsquerdo.Estourado)
                {
                    Parar();
                }
                Odometro = Odometro + 18;
                PercentualCombustivel = PercentualCombustivel - 3;
                if (PercentualCombustivel <= 0)
                {
                    Desligar();
                    PercentualCombustivel = 0;
                    return;
                }
                
            }




        }

        private void Parar()
        {
            VelocidadeAtual = 0;
            PneuDianteiroDireito.VelocidadeAtual = 0;
            PneuDianteiroEsquerdo.VelocidadeAtual = 0;
            PneuTrazeiroDireito.VelocidadeAtual = 0;
            PneuTrazeiroEsquerdo.VelocidadeAtual = 0;
        }

        public void Frear(int _reduzir)
        {
            VelocidadeAtual = VelocidadeAtual - _reduzir;
            PneuDianteiroDireito.Frear(_reduzir);
            PneuDianteiroEsquerdo.Frear(_reduzir);
            PneuTrazeiroDireito.Frear(_reduzir);
            PneuTrazeiroEsquerdo.Frear(_reduzir);

            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
               

            }
        }
        /// <summary>
        /// Este metodo vai abartecer o carro.
        /// </summary>
        /// <param name="_quantidadeCombustivel">Informe o percentual de combustivel que deseja abastecer,
        /// caso informe 0 o metodo ira completar o tanque o valor não pode ser superior a 100</param>
        public void Abastecer(int _quantidadeCombustivel)
        {

            if (_quantidadeCombustivel == 0)
                _quantidadeCombustivel = 100 - PercentualCombustivel;

            if (PercentualCombustivel + _quantidadeCombustivel > 100)
            {
                Console.WriteLine("A QUANTIDADE DE COMBUSTÍVEL ULTRAPASSA O LIMITE");
            }

            if (PercentualCombustivel < 100)
            {
                PercentualCombustivel = PercentualCombustivel + _quantidadeCombustivel;
            }



        }

        public void Exibir()
        {
            Console.WriteLine(" Marca: "+ Marca);
            Console.WriteLine("Modelo: " + Modelo);
            Console.WriteLine("Placa: " + Placa);
            Console.WriteLine("Ano de fabricação: " + AnoFabricacao);
            Console.WriteLine("Odometro: " + Odometro);
            Console.WriteLine("Percentual de Combustível: " + PercentualCombustivel);
            Console.WriteLine("Velociade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Carro Ligado: " + Ligado);
            Console.WriteLine("Velocidade atual: " + VelocidadeAtual);

            Console.WriteLine("\n Pneu dianteiro esquerdo");
            PneuDianteiroEsquerdo.Exibir();
            Console.WriteLine("\n Pneu dianteiro direito");
            PneuDianteiroDireito.Exibir();
            Console.WriteLine("\n Pneu trazeiro esquerdo");
            PneuTrazeiroEsquerdo.Exibir();
            Console.WriteLine("\n Pneu trazeiro direito");
            PneuTrazeiroDireito.Exibir();
            Console.WriteLine("\n Pneu Estepe");
            PneuEstepe.Exibir();

    }

}
}
