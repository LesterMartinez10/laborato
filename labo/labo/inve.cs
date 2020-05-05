using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace labo_01
{
    class inve
    {
        static Usuarios us = new Usuarios();
        static string ruts = "in.txt";
        static StreamWriter les;
        static int l;

        static void progre(string nom, string can, string pre)
        {
                Console.Clear();
                les = File.AppendText(ruts);
                les.WriteLine("nombre del producto:" + nom + "\nCantidad:" + can + "\nPrecio:" + pre);
                les.Close();
         }
            static string dotiss(string h)
            {
                Console.Clear();
                Console.WriteLine("Ingrese " + h + ":");
                return (Console.ReadLine());
            }             
        public void or()
        {
            char op = 's';

            while (op != 'n')
            {
                progre(dotiss("nombre del producto"), dotiss("Cantidad"), dotiss("Precio"));
                les = File.AppendText(ruts);
                les.WriteLine("\n");
                les.Close();
                Console.Clear();
                Console.WriteLine("¿Quiere ingresear otro producto? [s/n]:");
                op = char.Parse(Console.ReadLine());
                Console.Clear();  
                
                             
            }
            Console.Clear();
            les = File.AppendText(ruts);
            les.WriteLine("\n");
            les.Close();
            Console.Clear();                                
                Console.WriteLine("Desea salir al menu principala presione [1]");
                l = int.Parse(Console.ReadLine());

                if (l == 1)
                {
                    Console.Clear();
                    us.indi();

                }
               

        }
        public void inests()
        {
            TextReader leer_a = new StreamReader("in.txt");
            Console.WriteLine(leer_a.ReadToEnd());
            leer_a.Close();
            
                Console.WriteLine("Desea salir al menu principala presione [1]");
                l = int.Parse(Console.ReadLine());
                if (l == 1)
                {
                    Console.Clear();
                    us.indi();
                }
               
                      
        }
    }
}
