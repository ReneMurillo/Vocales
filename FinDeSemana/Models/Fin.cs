using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinDeSemana.Models
{
    public class Fin
    {
        private string Dia;

        public string VerificarDia(string pDia)
        {
            Dia = pDia;
            string mensaje = "";
            switch (Dia)
            {
                case "lunes":
                case "martes":
                case "miercoles":
                case "jueves":
                case "viernes":
                    mensaje = "Es un día de semana";
                    break;
                case "sabado":
                case "domingo":
                    mensaje = "Es un fin de semana";
                    break;
                default:
                    mensaje = "El parámetro ingresado no corresponde a un día válido";
                    break;
            }
            return mensaje;
        }
    }
}