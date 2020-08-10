using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnoBisexto
{
    public static class AnoUtil
    {
        public  static bool VerificarseAnoEhBisexto(int aAno)
        {
            bool anoEhBisexto = false;

            anoEhBisexto = (((aAno % 4) == 0) && ((aAno % 100) != 0) || ((aAno % 400) == 0));

            return anoEhBisexto;
        }
    }
}
