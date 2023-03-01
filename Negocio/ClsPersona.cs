using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio1VladimirAlexanderVel_squezAlas.Entidades;

namespace Laboratorio1VladimirAlexanderVel_squezAlas.Negocio
{
    public class ClsPersona
    {
     public String CalcularIMC(Persona per)
        {
            double Promedio = per.Peso / Math.Pow(per.Altura, 2);

            if(Promedio > 25)
            {
                return $"Estimado, usted tiene sobre peso, lo siento...";
            }
            else 
            {
                return $"Enhorabuena, tiene un excelente peso ideal, siga por ese camino";
            }
        }

        public String MayorDeEdad(Persona per)
        {
            if(per.Edad >= 18)
            {
                return $"Mayor de edad";
            }
            else
            {
                return $"Menor de edad";
            }
        }   
    }
}