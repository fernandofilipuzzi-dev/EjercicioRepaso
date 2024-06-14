using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Controlador
    {
       public string[] Nombres = new string[1000];
        public  int Contador = 0;
        public int[] Dni = new int[1000];
        public double[] Notas = new double[1000];


        public void AgregarAlumno(string nombre,int dni,double nota)
        {
            Nombres[Contador] = nombre;
            Dni[Contador] = dni;
            Notas[Contador] = nota;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double acumulador = 0;
            double promedio = 0;
            for (int i = 0; i < Contador; i++)
            {
               acumulador += Notas[i];
            }
            if (Contador > 0)
            {
                promedio = acumulador/ Contador;
            }
            return promedio;
        }
    }
}
