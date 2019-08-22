using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colores = new List<string>();
            colores.Add("Rojo");
            colores.Add("Verde");
            colores.Add("Azul");
            colores.Add("Blanco");

            colores.RemoveAt(1);
            colores.Remove("Azul");

            Console.WriteLine("Número de elementos:     " + colores.Count + "\n");

            int indColor = 1;
            foreach(string color in colores)
            {
                Console.WriteLine("Elemento " + indColor.ToString() + ": " + color);
                indColor++;
            }

            Console.ReadLine();

        }
    }
}
