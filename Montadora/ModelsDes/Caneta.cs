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

    }

   
}