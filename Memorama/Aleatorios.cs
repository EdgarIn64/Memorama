using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memorama
{
    internal class Aleatorios
    {
        private Random _random;

        public Aleatorios()
        {
            this._random = new Random();
        }

        public int generarNumeroAleatorio(int longitud)
        {
            return this._random.Next(0, longitud);
        }

        public int[] generarNumerosAleatorios(int longitud)
        {
            if (longitud <= 0)
            {
                return null;
            }
            int[] numeros = new int[longitud];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = generarNumeroAleatorio(longitud);
            }
            return numeros;
        }

        public int[] generarNumerosAleatoriosNoRepetidos(int longitud)
        {
            if (longitud <= 0)
            {
                return null;
            }

            int[] numeros = new int[longitud];

            bool repetido;
            int numero;
            int indice = 0;

            while (indice < numeros.Length)
            {
                repetido = false;
                numero = generarNumeroAleatorio(longitud);

                for (int i = 0; i < indice; i++)
                {
                    if (numeros[i] == numero)
                    {
                        repetido = true;
                    }
                }

                if (!repetido)
                {
                    numeros[indice] = numero;
                    indice++;
                }
            }

            return numeros;
        }
    }
}
