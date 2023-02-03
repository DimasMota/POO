using System.Runtime;

namespace ModelsDes
{
    public class Caneta
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string CorTinta { get; set; }
        public bool Nova { get; set; }
        public int PercentualTinta { get; set; }

        public Caneta(string _marca, string _modelo, string _cor, string _cortinta)
        {
            Marca = _marca;
            Modelo = _modelo;
            Cor = _cor;
            CorTinta = _cortinta;


            Nova = true;
            PercentualTinta = 100;
        }
        
        
        public void Escrever(int _escrita)
        {
            PercentualTinta = PercentualTinta - _escrita;
            
            if (PercentualTinta < 90)
            {
                Nova = false;
            }
            
            if(PercentualTinta < 0)
            {
                PercentualTinta = 0;
            }
        }

        public void Exibir()
        {
            Console.WriteLine("Marca:" + Marca);
            Console.WriteLine("Modelo:" + Modelo);
            Console.WriteLine("Cor da Caneta: " + Cor);
            Console.WriteLine("Cor da Tinta: " + CorTinta);
            Console.WriteLine("Nova: " + Nova);
            Console.WriteLine("Quantidade de Tinta: " + PercentualTinta);
        }

    }

   
}