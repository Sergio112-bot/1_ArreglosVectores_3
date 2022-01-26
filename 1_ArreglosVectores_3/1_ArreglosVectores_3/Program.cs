using System;

namespace _1_ArreglosVectores_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[13];

            nombres[0] = "Nestor";
            nombres[1] = "Miguel";
            nombres[2] = "Alejandro Calixto";
            nombres[3] = "Obed";
            nombres[4] = "Jesus";
            nombres[5] = "Pedro";
            nombres[6] = "Diego";
            nombres[7] = "Siul";
            nombres[8] = "Alejandro Monjaraz";
            nombres[9] = "Maria";
            nombres[10] = "Ian";
            nombres[11] = "Esau";
            nombres[12] = "Sergio";

            Console.WriteLine(nombres[5] + "\n");

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}
