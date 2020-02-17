using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_2.Helpers
{
    public class Comparar
    {
        public static int elMayor(IEnumerable<int> numeros)
        {
            int mayor = int.MinValue;
            foreach (int numero in numeros)
                if (numero > mayor)
                    mayor = numero;
            return mayor;
        }
        public static int elMenor(IEnumerable<int> numeros)
        {
            int menor = int.MaxValue;
            foreach (int numero in numeros)
                if (numero < menor)
                    menor = numero;
            return menor;
        }
    }
}
