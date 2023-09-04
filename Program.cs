using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_Ibarra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hashset
            HashSet<string> ColoresHashSet7 = new HashSet<string>();    
            HashSet<string> ColoresHashSet6 = new HashSet<string>();

            //Alimentar datos
                //Conjunto 1
                    Console.WriteLine("Ingresa los colores del conjunto 1");
                    int ContadorConjunto1 = 0;
                    for (int i = 0; i<7; i++)
                    {
                        Console.Write("{0}-", ContadorConjunto1 = ContadorConjunto1 + 1);
                        string var = Console.ReadLine();
                        ColoresHashSet7.Add(var);
                    }
                //Conjunto 2
                    Console.WriteLine("Ingresa los colores del conjunto 2");
                    int ContadorConjunto2 = 0;
                    for(int i = 0; i<6; i++) 
                    {
                        Console.Write(ContadorConjunto2 = ContadorConjunto2 + 1);
                        string var = Console.ReadLine();
                        ColoresHashSet6.Add(var);
                    }
            //Unión de Conjunto 1 y Conjunto 2
            HashSet<string> Union1 = new HashSet<string>(ColoresHashSet7);
            Union1.UnionWith(ColoresHashSet6);

            //Desplegar Conjunto 1
            Console.WriteLine("Conjunto A ={");
            foreach(string i in ColoresHashSet7)
            {
                Console.WriteLine("{0}", i);
            }


            Console.ReadKey();
        }
    }
}
