using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeLucros
{
    public class Poupanca : CalculadoraAluguel
    {
        public void CalculaRendimento()
        {
            Rendimento = (ValorPoupanca * Juros) / 100;
        }
    }
}
