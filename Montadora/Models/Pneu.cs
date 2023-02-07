﻿namespace Models
{
    public class Pneu
    {
        // atributos ou propriedades
        public string Cor { get; set; }
        public int Aro { get; set; }
        public string Tipo { get; set; }
        public bool TWI { get; set; }
        public int PercentualBorracha { get; set; }
        public bool Estourado { get; set; }
        public int VelocidadeMaxima { get; set; }
        public int VelocidadeAtual { get; set; }
        public bool Estepe { get; set; }

        // CONSTRUTOR para inserir valores
        public Pneu(int _aro, int _velocidade, string _tipo, bool _estepe = false) // constror feito com ctor 
        {
            Aro = _aro;
            VelocidadeMaxima = _velocidade;
            Estepe = _estepe;
            Tipo = _tipo;

            VelocidadeAtual = 0;
            Estourado = false;
            TWI = false;
            Cor = "Preta";
            PercentualBorracha = 100;
        }

        // metodos (aççao
       public void Girar(int _velocidade)
        {
            VelocidadeAtual = VelocidadeAtual + _velocidade;
            PercentualBorracha = PercentualBorracha - 3;
            if ( VelocidadeAtual > VelocidadeMaxima ||  PercentualBorracha <= 30)
            {
                EstourarPneu();
            }
         
        }

        public void EstourarPneu()
        {
            Estourado = true;
            VelocidadeAtual = 0;
        }
        public void Frear(int _reducao)
        {
            VelocidadeAtual = VelocidadeAtual - _reducao;
            PercentualBorracha = PercentualBorracha - 5;

            if (PercentualBorracha <= 30)
            {
                EstourarPneu();
            }
            if (VelocidadeAtual < 0)
            {
                VelocidadeAtual = 0;
            }
        }
        public void Exibir()
        {
            Console.WriteLine("Aro: " + Aro);
            Console.WriteLine("Percentual de Borracha: " + PercentualBorracha);
            Console.WriteLine("Cor: " + Cor);
            Console.WriteLine("Velocidade Máxima: " + VelocidadeMaxima);
            Console.WriteLine("Estepe: " + Estepe);
            Console.WriteLine("Estourado: " + Estourado);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("TWI: " + TWI);
            Console.WriteLine("Velocidade Atual: " + VelocidadeAtual);
        }


    }
}