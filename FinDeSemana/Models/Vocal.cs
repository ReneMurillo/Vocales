using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinDeSemana.Models
{
    public class Vocal
    {
        private string Palabra;

        public string ContarVocales(string pWord)
        {
            int contadorVocales = 0;
            int contadorConsonantes = 0;
            int contadorEspacios = 0;
            string mensaje = "";

            Palabra = pWord;

            for (int i = 0; i < Palabra.Length; i++)
            {
                if((Convert.ToChar(Palabra[i])) == 'a')
                {
                    contadorVocales += 1;
                }
                if ((Convert.ToChar(Palabra[i])) == 'e')
                {
                    contadorVocales += 1;
                }
                if ((Convert.ToChar(Palabra[i])) == 'i')
                {
                    contadorVocales += 1;
                }
                if ((Convert.ToChar(Palabra[i])) == 'o')
                {
                    contadorVocales += 1;
                }
                if ((Convert.ToChar(Palabra[i])) == 'u')
                {
                    contadorVocales += 1;
                }
                if ((Convert.ToChar(Palabra[i])) == ' ')
                {
                    contadorEspacios += 1;
                }

                contadorConsonantes = (Palabra.Length - contadorVocales) - contadorEspacios;
                mensaje = string.Format("La palabra {0} tiene {1} vocales y {2} consonantes", Palabra, contadorVocales, contadorConsonantes);

                
            }
            return mensaje;
        }
    }
}