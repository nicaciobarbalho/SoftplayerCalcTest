using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    public class Calcula : ICalcula
    {
        readonly decimal JUROS = 0.01M;

        /// <summary>
        /// Cálculo de juros compostos
        /// </summary>
        /// <param name="valorInicial">Valor inicial é um decimal recebido como parâmetro</param>
        /// <param name="meses">Tempo é um inteiro, que representa meses, também recebido como parâmetro</param>
        /// <returns>Resultado final deve ser truncado (sem arredondamento) em duas casas decimais</returns>
        public decimal JurosCompostos(decimal valorInicial, int meses)
        {
           return Math.Round(valorInicial * (decimal)Math.Pow( (double)(1 + JUROS), (double)meses), 2);       
        }
    }
}
