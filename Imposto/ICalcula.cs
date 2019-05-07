using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imposto
{
    public interface ICalcula
    {
        decimal JurosCompostos(decimal valorInicial, int meses);
    }
}
