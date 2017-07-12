using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeLucros
{
    public class CalculadoraAluguel
    {
        public double ValorPoupanca { get; set; }
        public double Juros { get; set; }
        public double Rendimento { get; set; }
        public double ValorCompra { get; set; }
        public double ValorAluguel { get; set; }
        
        public bool CalculaDiferenca()
        {
            if(Rendimento <= ValorAluguel)
            {
                return true;
            }
            return false;
        }
        public bool RetornaDiferencaCompraImovel()
        {
            if(ValorPoupanca < ValorCompra)
            {
                return true;
            }
            return false;
        }
    }
}
