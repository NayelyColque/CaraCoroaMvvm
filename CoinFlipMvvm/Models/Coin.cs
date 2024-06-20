using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipMvvm.Models
{
    public class Coin
    {
        public string LadoEscolhido { get; set; }
        public string LadoSorteado { get; set; }


        //M�todo Jogar a moeda. Retorna o Lado sorteado como uma string
        public string Jogar()
        {
            LadoSorteado = new Random().Next(2) == 0 ? "cara" : "coroa";
            return (LadoSorteado);
        }
    }
}
