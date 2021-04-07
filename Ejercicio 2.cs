using System;
using System.Collections.Generic;
 
namespace ParametrosReferencia
{
    class Program
    {
        private int[] vec;
 
        public Program()
        {
            Console.Write("Tamaño del vector:");
            int tam = int.Parse(Console.ReadLine());
            vec = new int[tam];
        }
 
        public void Cargar()
        {
            for (var f = 0; f < vec.Length; f++)
            {
                Console.Write("Ingrese elemento:");
                vec[f] = int.Parse(Console.ReadLine());
            }
        }
 
        public void MayorMenor(out int mayor,out int menor)
        {
            mayor=vec[0];
            menor=vec[0];
            for (var f = 1; f < vec.Length; f++)
            {
                if (vec[f] > Mayor)
                {
                    mayor = vec[f];
                }
                else
                {
                    if (vec[f] < menor)
                    {
                        menor = vec[f];
                    }
                }
            }
        }
 
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Cargar();
            int mayor, menor;
            p.MayorMenor(out mayor, out menor);
            Console.WriteLine("El mayor elemento del vector es:" + mayor);
            Console.WriteLine("El menor elemento del vector es:" + menor);
            Console.ReadKey();
        }
    }
}