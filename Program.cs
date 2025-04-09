using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicion1sem_3
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, n2, suma;                                       //llamar variables (en reserva)
            Console.Write("Ingrese numero 1:");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese numero 2:");
            // es igual a leer a pseint
            n2 = int.Parse(Console.ReadLine());
            suma = n1 + n2;
            Console.WriteLine("la suma es :"+suma);              //une y concatena el texto con el reultado
            Console.ReadKey();
        }
        


    }

}
