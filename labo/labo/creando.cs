using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace labo_01
{
    class creando
    {

        static Usuarios us = new Usuarios();
        static string rut = "us.txt";
        static StreamWriter lug;
        static int b,l;

        static string det(string a)
        {
            Console.Clear();
            Console.WriteLine("Ingrese " + a + ":");
            return (Console.ReadLine());
        }
        static void usue(string usua, string contrar)
        {
           
            Console.WriteLine("¿Que opcion desea elejir? \n\n 1. Administrador  \n 2. Trabajador");
            b = int.Parse(Console.ReadLine());
            Console.Clear();

            if (b == 1)
            {
                lug = File.AppendText(rut);
                lug.WriteLine("nombre del usuario: " + usua + "\nContraseña: " + contrar);
                lug.WriteLine("Administrador");
                us.uss= usua;
                us.con = contrar;
                lug.Close();
            }
            else
            {
                lug = File.AppendText(rut);
                lug.WriteLine("nombre del usuario: " + usua + "\nContraseña: " + contrar);
                lug.WriteLine("Trabajador");
                us.us = usua;
                us.contra = contrar;
                lug.Close();
            }
        }
        public void cracio()
        {
            char op = 's';
            while (op != 'n')
            {
                usue(det("nombre del usuario "), det("Contrase{a: "));
                lug = File.AppendText(rut);
                lug.WriteLine("\n");
                lug.Close();
                Console.Clear();
                Console.WriteLine("¿Quiere ingresear otro usuario? [s/n]:");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
               
                
            }
            Console.Clear();
            lug = File.AppendText(rut);
            lug.WriteLine("\n");
            lug.Close();
            Console.Clear();

            Console.WriteLine("Para salir al menu principala precione [1]");
            l = int.Parse(Console.ReadLine());

            if (l == 1)
            {
                Console.Clear();
                us.indi();

            }
           
           

        }
        public void regis()
        {
           
            TextReader leer_arc = new StreamReader("us.txt");
            Console.WriteLine(leer_arc.ReadToEnd());
            leer_arc.Close();

            Console.WriteLine("Para salir al menu principala precione [1]");
            l = int.Parse(Console.ReadLine());

            if (l == 1)
            {
                Console.Clear();
                us.indi();

            }
            


        }
        public void ult()
        {
            us.indi();
        }
    }
}
